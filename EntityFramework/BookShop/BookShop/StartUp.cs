namespace BookShop
{
    using BookShop.Models;
    using Castle.DynamicProxy.Generators;
    using Data;
    using Initializer;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.EntityFrameworkCore.Query.SqlExpressions;
    using System;
    using System.Collections;
    using System.Collections.Generic;
    using System.Linq;
    using System.Security.Cryptography.X509Certificates;
    using System.Text;
    using static System.Reflection.Metadata.BlobBuilder;

    public class StartUp
    {
        public static void Main()
        {
            using var db = new BookShopContext();
            DbInitializer.ResetDatabase(db);
            //string input = Console.ReadLine().ToLower();
            //System.Console.WriteLine(GetBooksByAgeRestriction(db, input));
            //Console.WriteLine(GetGoldenBooks(db));
            //Console.WriteLine(GetBooksByPrice(db));

           //int year = int.Parse(Console.ReadLine());
           
           Console.WriteLine(CountCopiesByAuthor(db));
        }


        public static string GetBooksByAgeRestriction(BookShopContext context, string command)
        {
            StringBuilder result = new StringBuilder();
            var booksTitle = context
                .Books
                .ToArray()
                .Where(b => b.AgeRestriction.ToString().ToLower() == command)
                .Select(b => b.Title)
                .OrderBy(x => x);

            foreach (var p in booksTitle)
            {
                result.AppendLine(p.ToString());
            }
            return result.ToString();
        }

        public static string GetGoldenBooks(BookShopContext context)
        {
            StringBuilder gold = new StringBuilder();
            var pesho = context
                .Books
                .Where(x=> x.Copies < 5000)
                .Select(x => new
                {
                   Titele = x.Title,
                   Order = x.BookId,
                   fff = x.EditionType
                })
                .OrderBy(x => x.Order)
                .ToList();

            foreach (var t in pesho)
            {
                if (t.fff.ToString() == "Gold")
                {
                    gold.AppendLine(t.Titele);
                }
               
            }

            return gold.ToString();
        }

        public static string GetBooksByPrice(BookShopContext context)
        {
           
            var tonkGera = context
                .Books
                .Where (c=> c.Price > 40)
                .Select(c=> new
                {
                    Titles = c.Title,
                    Pricee = c.Price,

                })
                .OrderByDescending(x=>x.Pricee)
            .ToArray();


            return string.Join(Environment.NewLine, tonkGera.Select(b => $"{b.Titles} - ${b.Pricee:f2}")); ;

        }

        public static string GetBooksNotReleasedIn(BookShopContext context, int year)
        {
           
            var tonkGera = context
                .Books
                .Where(x => x.ReleaseDate.Value.Year != year)
                .Select(x => new
                {
                    Titles = x.Title,
                    x.BookId
                })
                .OrderBy(x => x.BookId)
                .ToArray();

            return string.Join(Environment.NewLine, tonkGera.Select(x => x.Titles));
            
        }

        public static string GetBooksReleasedBefore(BookShopContext context, string date)
        {
            
            DateTime data = DateTime.Parse(date);
            var tonkGera = context
                .Books
                .OrderByDescending (x => x.ReleaseDate)
                .Where(x => x.ReleaseDate < data)
                .Select(b => $"{b.Title} - {b.EditionType} - ${b.Price:F2}")
                .ToArray();

            return string.Join(Environment.NewLine,tonkGera);
            
        }


        public static string GetAuthorNamesEndingIn(BookShopContext context, string input)
        {
            
            var tool = context
                .Authors
                .Where (x=> x.FirstName.EndsWith(input))
                .Select (c=> $"{c.FirstName} {c.LastName}")
                .ToArray();
            return string.Join(Environment.NewLine, tool);
        }


        public static string GetBookTitlesContaining(BookShopContext context, string input)
        {
            var misho = context
                .Books
                .Where (x=>x.Title.ToLower().Contains(input.ToLower()))
                .OrderBy(x=>x.Title)
                .Select (x=> $"{x.Title}")
                .ToArray();
            
            return string.Join(Environment.NewLine, misho);
        }

        public static string GetBooksByAuthor(BookShopContext context, string input)
        {
           
            var misho = context
                .Books
                .Where(x => x.Author.LastName.ToLower().StartsWith(input.ToLower()))
                .OrderBy(x=>x.BookId)
                .Select(x => $"{x.Title} ({x.Author.FirstName} {x.Author.LastName})")
                .ToArray();

            return string.Join(Environment.NewLine, misho);
            

        }


        public static int CountBooks(BookShopContext context, int lengthCheck)
        {
            var pesho = context
                .Books
                .Count(x => x.Title.Length > lengthCheck)
                .ToString();
            int result = int.Parse(pesho);
            return result;
        }

        public static string CountCopiesByAuthor(BookShopContext context)
        {
            StringBuilder build = new StringBuilder();
            var pesho = context
                .Authors
                .Select(x => new
                {
                    name = (x.FirstName +" "+ x.LastName),
                    copies = x.Books.Sum(p => p.Copies)
                })
                .OrderByDescending(s => s.copies)
                .ToArray();


            return string.Join(Environment.NewLine, pesho.Select(x => $"{x.name} - {x.copies}") );
        }

    }
}
