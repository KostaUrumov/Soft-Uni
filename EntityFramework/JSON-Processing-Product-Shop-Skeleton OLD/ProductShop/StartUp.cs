using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text.Json.Serialization;
using Newtonsoft.Json;
using ProductShop.Data;
using ProductShop.DTOs;
using ProductShop.Models;
using AutoMapper;
using static Microsoft.EntityFrameworkCore.DbLoggerCategory;
using System.Threading.Channels;
using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
using Microsoft.EntityFrameworkCore.ValueGeneration.Internal;
using Microsoft.EntityFrameworkCore;
using System.Runtime.CompilerServices;

namespace ProductShop
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            ProductShopContext dbcontext = new ProductShopContext();
            //dbcontext.Database.EnsureDeleted();
            //dbcontext.Database.EnsureCreated();
            Mapper.Initialize(cfg => cfg.AddProfile(typeof(ProductShopProfile)));
            string jsonReaded = File.ReadAllText("../../../Datasets/categories.json");
            string jsonReaded1 = File.ReadAllText("../../../Datasets/categories-products.json");
            string jsonReaded2 = File.ReadAllText("../../../Datasets/products.json");
            string jsonReaded3 = File.ReadAllText("../../../Datasets/users.json");

            using (dbcontext)
            {
                //ImportUsers(dbcontext, jsonReaded3);
                //ImportCategoryProducts(dbcontext, jsonReaded1);
                //ImportCategories(dbcontext, jsonReaded);
                //ImportProducts(dbcontext, jsonReaded2);


                //Console.WriteLine(GetProductsInRange(dbcontext));
                Console.WriteLine(GetUsersWithProducts(dbcontext));
            }

        }

        public static string ImportUsers(ProductShopContext context, string inputJson)
        {

            UsersDTO[] person = JsonConvert.DeserializeObject<UsersDTO[]>(inputJson);
            ICollection<User> users = new List<User>();
            foreach (var p in person)
            {
                User us = new User();
                us.FirstName = p.Firstname;
                us.LastName = p.Lastname;
                us.Age = p.Age;
                users.Add(us);
            }

            context.Users.AddRange(users);
            context.SaveChanges();
            return $"Successfully imported {users.Count}";
        }

        public static string ImportCategories(ProductShopContext context, string inputJson)
        {
            CategoryDTO[] categories = JsonConvert.DeserializeObject<CategoryDTO[]>(inputJson);
            ICollection < Category > Categories = new List<Category>();
            foreach (var cat in categories)
            {
                Category cats = new Category();
                if (cat.Name != null)
                {
                    cats.Name = cat.Name;
                    Categories.Add(cats);
                }
            }
            context.Categories.AddRange(Categories);
            context.SaveChanges();
            return $"Successfully imported {Categories.Count}";
        }

        public static string ImportProducts(ProductShopContext context, string inputJson)
        {
            ProductDTO[] prods = JsonConvert.DeserializeObject<ProductDTO[]>(inputJson);
            ICollection<Product> Products = new List<Product>();
            foreach (ProductDTO k in prods)
            {

                Product prod = Mapper.Map<Product>(k);

                Products.Add(prod);
                
            }
            context.Products.AddRange(Products);
            context.SaveChanges();
            return $"Successfully imported {Products.Count}";
        }

        public static string ImportCategoryProducts(ProductShopContext context, string inputJson)
        {
            CategoriesProductsDTO[] catProds = JsonConvert.DeserializeObject<CategoriesProductsDTO[]>(inputJson);
            ICollection<CategoryProduct> prods = new List<CategoryProduct>();
            foreach (var yoga in catProds)
            {
                CategoryProduct catsss = new CategoryProduct();
                catsss.CategoryId = yoga.CategoryId;
                catsss.ProductId = yoga.ProductId;
                prods.Add(catsss);
                
            }
            context.AddRange(prods);
            context.SaveChanges();
            return $"Successfully imported {prods.Count}";
        }
        public static string GetProductsInRange(ProductShopContext context)
        {
            var koce = context
                .Products
                .Where(x => x.Price >= 500 && x.Price <= 1000)
                .Select(x=> new
                {
                    name = x.Name,
                    price = x.Price,
                    seller = $"{x.Seller.FirstName} {x.Seller.LastName}"
                })
                .OrderBy(c=> c.price)
                .ToArray();

            string job = JsonConvert.SerializeObject(koce, Formatting.Indented);
            return job;


        }
        public static string GetSoldProducts(ProductShopContext context)
        {
            var join = context
                .Users
                .Where(x => x.ProductsSold.Count > 0)
                .OrderBy(x => x.LastName)
                .ThenBy(x => x.FirstName)
                .Select(x => new
                {
                    firstName = x.FirstName,
                    lastName = x.LastName,
                    soldProducts = x.ProductsSold.Select
                    (f => new
                    {
                        name = f.Name,
                        price = f.Price,
                        buyerFirstName = f.Buyer.FirstName,
                        buyerLastName = f.Buyer.LastName
                    })
                });
            string Returned = JsonConvert.SerializeObject(join, Formatting.Indented);
            return Returned;
        }

        public static string GetCategoriesByProductsCount(ProductShopContext context)
        {
            var lisicky = context
                .Categories
                .Select(x => new
                {
                    category = x.Name,
                    poductsCount = x.CategoryProducts.Select(g => g.CategoryId).Count(),
                    averagePrice = x.CategoryProducts.Select(g => g.Product.Price).Average(),
                    totalRevenue = x.CategoryProducts.Sum(g => g.Product.Price)

                })
                .OrderByDescending(d => d.poductsCount)
                .ToArray();
            
            string result = JsonConvert.SerializeObject(lisicky, Formatting.Indented);
            return result;
        }


        public static string GetUsersWithProducts(ProductShopContext context)
        {
            var tosho = context
                .Products
                .Where(x => x.BuyerId != null)
                .Select(x => new
                {
                    usersCount = x.Name.Count(),
                    users = x.Seller.ProductsSold.Select(g => new
                    {
                        lastName = g.Seller.LastName,
                        age = g.Seller.Age,
                        soldProducts = g.Seller.ProductsSold.Select(j => new
                        {
                            count = j.Seller.ProductsSold.Count(),
                            products = j.Seller.ProductsSold.Select(p => new
                            {
                                name = p.Name,
                                price = p.Price
                            })


                        })
                        .OrderByDescending(y => y.count)
                    })

                })
                .ToArray();
            string rest = JsonConvert.SerializeObject(tosho, Formatting.Indented);
            return rest;
        }

    }
}