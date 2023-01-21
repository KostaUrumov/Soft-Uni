namespace BookShop
{
    using BookShop.Models;
    using Data;
    using Initializer;
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
            string input = Console.ReadLine().ToLower();
            //System.Console.WriteLine(GetBooksByAgeRestriction(db, input));
            //Console.WriteLine(GetGoldenBooks(db));
            //Console.WriteLine(GetBooksByPrice(db));

           //int year = int.Parse(Console.ReadLine());
           Console.WriteLine(GetAuthorNamesEndingIn(db, input));
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
            int number = int.Parse(input.Length.ToString());
            var tool = context
                .Authors
                .Where (x=> x.FirstName.EndsWith(input))
                .Select (c=> $"{c.FirstName} {c.LastName}")
                .ToArray();
            return string.Join(Environment.NewLine, tool);
        }



    }
}
