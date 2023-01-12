using System;
using System.ComponentModel.Design;
using System.Data.SqlClient;
using System.Dynamic;
using System.Globalization;
using System.Security.Principal;
using System.Xml.Linq;

namespace Ado.Net
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connect = new SqlConnection(
                  "Server =DESKTOP-EMH9F7E;" +
                  "Database = MinionsDB; " +
                   "Integrated Security=true");
            connect.Open();
            using (connect)
            {
                int numOfGuru = int.Parse(Console.ReadLine());
                SqlCommand goForIt = new SqlCommand($"exec udf_Names {numOfGuru}", connect);
                SqlCommand getTheminions = new SqlCommand
                    ("create or alter procedure udf_Names (@VilId int)" +
                    "as " +
                    "select " +
                    "all (t.Name), " +
                    "n.Name," +
                    "all(t.Age)"+
                    "from MinionsVillains as m" +
                    "left join Villains as n" +
                    "on n.Id = m.VillainId" +
                    "left join Minions as t" +
                    "on t.Id = m.MininId" +
                    "where n.Id = @VilId", connect);

                SqlDataReader read = goForIt.ExecuteReader();
                while (read.Read())
                {
                    string name = (string) read.GetValue(0);
                    string minion = (string) read.GetValue(1);
                    int age = (int) read.GetValue(2);
                    Console.WriteLine(name, minion, age);
                }

            }

        }
           
    }
}