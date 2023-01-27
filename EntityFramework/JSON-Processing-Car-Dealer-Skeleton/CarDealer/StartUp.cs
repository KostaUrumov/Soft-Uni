using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using AutoMapper;
using CarDealer.Data;
using CarDealer.DTO;
using CarDealer.Models;
using Castle.Core.Resource;
using Newtonsoft.Json;

namespace CarDealer
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            CarDealerContext dbcontext = new CarDealerContext();
            
            
            string jsonInput = File.ReadAllText("../../../Datasets/suppliers.json");
            string jsonParts = File.ReadAllText("../../../Datasets/parts.json");
            string jsonCars = File.ReadAllText("../../../Datasets/cars.json");
            string jsonCustomers = File.ReadAllText("../../../Datasets/customers.json");
            string jsonSales = File.ReadAllText("../../../Datasets/sales.json");

            //Console.WriteLine(ImportSuppliers(dbcontext, jsonInput));
            //Console.WriteLine(ImportParts(dbcontext, jsonParts));
            //Console.WriteLine(ImportCars(dbcontext, jsonCars));
            //Console.WriteLine(ImportCustomers(dbcontext, jsonCustomers));
            //Console.WriteLine(ImportSales(dbcontext, jsonSales));
            //Console.WriteLine(GetOrderedCustomers(dbcontext));
            //Console.WriteLine(GetCarsFromMakeToyota(dbcontext));
            Console.WriteLine(GetLocalSuppliers(dbcontext));
        }

        public static string ImportSuppliers(CarDealerContext context, string inputJson)
        {
            SupplierDTO[] res = JsonConvert.DeserializeObject<SupplierDTO[]>(inputJson);
            ICollection<Supplier> sups = new List<Supplier>();
            foreach (var t in res)
            {
                Supplier hhh = new Supplier();
                hhh.Name = t.Name;
                hhh.IsImporter = t.isImporter;
                sups.Add(hhh);
            }
            context.AddRange(sups);
            context.SaveChanges();
            return $"Successfully imported {sups.Count}.";
        }
        public static string ImportParts(CarDealerContext context, string inputJson)
        {
            PartsDTO[] venzi = JsonConvert.DeserializeObject<PartsDTO[]>(inputJson);
            ICollection<Part> Parts = new List<Part>();
            foreach (var r in venzi)
            {
                Part part = new Part();
                if (r.SupplierId > 31)
                {
                    continue;
                }
                part.SupplierId = r.SupplierId;
                part.Name = r.Name;
                part.Price = r.Price;
                part.Quantity = r.Quantity;
                Parts.Add(part);
            }
            context.AddRange(Parts);
            context.SaveChanges();
            return $"Successfully imported {Parts.Count}";
        }
        public static string ImportCars(CarDealerContext context, string inputJson)
        {
            CarDTO[] cars = JsonConvert.DeserializeObject<CarDTO[]>(inputJson);
            ICollection<Car> carsss = new List<Car>();
            foreach (var gim in cars)
            {
                Car car = new Car();
                car.Make = gim.Make;
                car.Model = gim.Model;
                car.TravelledDistance = gim.TravelledDistance;
                car.PartCars = gim.parts;
                carsss.Add(car);
            }
            context.AddRange(carsss);
            context.SaveChanges();
            return $"Successfully imported {carsss.Count}.";
        }
        public static string ImportCustomers(CarDealerContext context, string inputJson)
        {
            CustomerDTO[] customs = JsonConvert.DeserializeObject<CustomerDTO[]>(inputJson);
            ICollection<Customer> addded = new List<Customer>();
            foreach (var t in customs)
            {
                Customer hop = new Customer();
                hop.Name = t.Name;
                hop.BirthDate = t.Birthdate;
                hop.IsYoungDriver = t.IsYoungDriver;
                addded.Add(hop);
            }
            context.AddRange(addded);
            context.SaveChanges();
            return $"Successfully imported {addded.Count}.";
        }
        public static string ImportSales(CarDealerContext context, string inputJson)
        {
            SalesDTO[] sale = JsonConvert.DeserializeObject<SalesDTO[]>(inputJson);
            ICollection<Sale> salesAdd = new List<Sale>();
            foreach (var t in sale)
            {
                Sale sa = new Sale();
                sa.CarId = t.CarId;
                sa.CustomerId = t.CustomerId;
                sa.Discount = t.Discout;
                salesAdd.Add(sa);
            }
            context.AddRange(salesAdd);
            context.SaveChanges();
            return $"Successfully imported {salesAdd.Count}.";
        }
        public static string GetOrderedCustomers(CarDealerContext context)
        {
            var koce = context
                .Customers
                .OrderBy(x=> x.BirthDate)
                .ThenBy(x=>x.IsYoungDriver)
                .Select(x => new
                {
                    Name = x.Name,
                    BirthDate = x.BirthDate.Date.ToString("dd/MM/yyyy"),
                    IsYoungDriver = x.IsYoungDriver,
                })
               .ToArray();
            string order = JsonConvert.SerializeObject(koce, Formatting.Indented);
            return order;
        }
        public static string GetCarsFromMakeToyota(CarDealerContext context)
        {
            var dari = context
                .Cars
                .Where(c => c.Make == "Toyota")
                .Select(x => new
                {
                    id = x.Id,
                    Make = x.Make,
                    Model = x.Model,
                    TravelledDistance = x.TravelledDistance,
                })
                .OrderBy(x => x.Model)
                .ThenByDescending(x => x.TravelledDistance)
                .ToArray();
            string tate = JsonConvert.SerializeObject(dari, Formatting.Indented);
            return tate;

        }
        public static string GetLocalSuppliers(CarDealerContext context)
        {
            var bonbon = context
                .Suppliers
                .Where(x => x.IsImporter == false)
                .Select(d => new
                {
                    Id = d.Id,
                    Name = d.Name,
                    PartsCount = d.Parts.Count
                })
                .ToArray();
            string venzi = JsonConvert.SerializeObject(bonbon, Formatting.Indented);
            return venzi;
        }
        
    }
}