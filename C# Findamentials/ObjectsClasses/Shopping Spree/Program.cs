using System;
using System.Collections.Generic;
using System.Linq;

namespace _5._Shopping_Spree
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string allPeople = Console.ReadLine();
            string allProducts = Console.ReadLine();
            string[] people = allPeople.Split(';');
            string[] products = allProducts.Split(';');
            List<Person> allPerson = new List<Person>();
            List<Product> productsAll = new List<Product>();

            string namePerson = "";
            string budget = "";

            for (int m = 0; m < people.Length; m++)
            {
                namePerson = "";
                budget = "";

                for (int i = 0; i < people[m].Length; i++)
                {
                    if (people[m][i] == '=')
                    {
                        for (int j = 0; j < i; j++)
                        {
                            namePerson += people[m][j];
                        }

                        for (int s = i + 1; s < people[m].Length; s++)
                        {
                            budget += people[m][s];
                        }
                    }


                }
                    int availableMoney = int.Parse(budget);
                    Person person = new Person();
                    person.Name = namePerson;
                    person.Money = availableMoney;
                    allPerson.Add(person);
            }
            string nameProdcut = "";
            string costProduct = "";

            for (int i = 0; i < products.Length; i++)
            {
                nameProdcut = "";
                costProduct = "";
                if (products[i].Length == 0)
                {
                    break;
                }

                for (int f = 0; f < products[i].Length; f++)
                {
                    if (products[i][f] == '=')
                    {
                        for (int g = 0; g < f; g++)
                        {
                            nameProdcut += products[i][g];
                        }

                        for (int y = f + 1; y < products[i].Length; y++)
                        {
                            costProduct += products[i][y];
                        }
                    }
                }

                int productvalue = int.Parse(costProduct);
                Product product = new Product();
                product.Name = nameProdcut;
                product.Cost = productvalue;
                productsAll.Add(product);

            }

            for (int i = 0; i < allPerson.Count; i++)
            {
                allPerson[i].BagOfProducts = new List<string>();
            }
            
            while (true)
            {
                string personByingProduct = Console.ReadLine();
                string[] personBuying = personByingProduct.Split(' ');
                if (personByingProduct == "END")
                {
                    break;
                }
                
                for (int i = 0; i < allPerson.Count; i++)
                {
                    if (allPerson[i].Name == personBuying[0])
                    {
                        string productToAdd = "";
                        for (int g = 0; g < productsAll.Count; g++)
                        {
                            if (productsAll[g].Name == personBuying[1])
                            {
                                if (allPerson[i].Money >= productsAll[g].Cost)
                                {
                                    productToAdd = productsAll[g].Name;
                                    allPerson[i].Money = allPerson[i].Money - productsAll[g].Cost;
                                    allPerson[i].BagOfProducts.Add(productToAdd);
                                    Console.WriteLine($"{allPerson[i].Name} bought {productToAdd}");
                                }

                                else
                                {
                                    Console.WriteLine($"{allPerson[i].Name} can't afford {productsAll[g].Name}");
                                }
                            }

                        }
                    }

                }

            }
            string toPrint = "";
            for (int i = 0; i < allPerson.Count; i++)
            {
                toPrint = "";
                for (int j = 0; j < allPerson[i].BagOfProducts.Count; j++)
                {
                    
                    if (j == allPerson[i].BagOfProducts.Count - 1)
                    {
                        toPrint += allPerson[i].BagOfProducts[j];
                    }


                    else
                    {
                    toPrint += allPerson[i].BagOfProducts[j] + ", "; 
                    }

                }

                if (allPerson[i].BagOfProducts.Count == 0)
                {
                    Console.WriteLine($"{allPerson[i].Name}" + " - Nothing bought");
                    break;
                }
                Console.WriteLine($"{allPerson[i].Name} - {toPrint}");
            }


        }
        internal class Person
        {
            public string Name { get; set; }
            public int Money { get; set; }

            public List<string> BagOfProducts { get; set; }
        }
        internal class Product
        {
            public string Name { get; set; }
            public int Cost { get; set; }

        }

    }

}
