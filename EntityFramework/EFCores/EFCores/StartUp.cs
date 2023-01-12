using EFCores.Models;
using System.Text;

namespace EFCores
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SoftUniContext context = new SoftUniContext();
            Console.WriteLine(RemoveTown(context));
           
        }

        public static string RemoveTown(SoftUniContext context)
        {
            StringBuilder stringBuilder= new StringBuilder();
            var seattle = context
                .Employees
                .Where (x=>x.Address.Town.Name == "Seattle")
                .ToArray();
            foreach (var v in seattle)
            {
                v.Address = null;   
            }

            var adresID = context
                .Addresses
                .Where (x=>x.Town.Name == "Seattle")
                .ToArray();

            foreach (var item in adresID)
            {
                context.Addresses.Remove(item);
            }

            var adrID = context
                .Towns
                .Where(x => x.Name == "Seattle")
                .ToArray();
           
            context.Towns.Remove(adrID[0]);
            context.SaveChanges();
            stringBuilder.AppendLine($"{seattle.Count()} addresses in Seattle were deleted");

            return stringBuilder.ToString();
        }
    }
}