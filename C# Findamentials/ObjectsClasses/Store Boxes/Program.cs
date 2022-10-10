using System;
using System.Collections.Generic;

namespace _6._Store_Boxes
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
            List<Item> Items = new List<Item>();
            List<Box> BoxList = new List<Box>();
            while (true)
            {
                string commandLine = Console.ReadLine();
                if (commandLine == "end")
                {
                    break;
                }
                   
                string [] boxesInformation = commandLine.Split(' ');

                Box box = new Box();
                
                box.SerialNumber = boxesInformation[0];
                box.Item = boxesInformation[1];
                box.ItemQuantity = boxesInformation[2];
                box.PricePerBox = double.Parse(boxesInformation[3]);


                double price = double.Parse(boxesInformation[2]) * double.Parse(boxesInformation[3]);
                Item item = new Item();
                item.Price = price;
                item.Name = boxesInformation[1];

                BoxList.Add(box);
                Items.Add(item);
            }
            
            List<double> OrderedByPrice = new List<double>();
            for (int i = 0; i < Items.Count; i++)
            {
               OrderedByPrice.Add(Items[i].Price);
            }

            
            OrderedByPrice.Sort();
            OrderedByPrice.Reverse();
            for (int i = 0; i < OrderedByPrice.Count; i++)
            {
                for (int j = 0; j < OrderedByPrice.Count; j++)
                {
                    if (OrderedByPrice[i] == Items[j].Price)
                    {
                        for (int g = 0; g < OrderedByPrice.Count; g++)
                        {
                            if (BoxList[g].Item == Items[j].Name)
                            {
                                Console.WriteLine(BoxList[g].SerialNumber);
                                Console.WriteLine($"-- {BoxList[g].Item} - ${BoxList[g].PricePerBox, 0:f2}: {BoxList[g].ItemQuantity}");
                                Console.WriteLine($"-- ${Items[j].Price, 0:f2}");

                                BoxList.RemoveAt(g);
                                Items.RemoveAt(j);
                                OrderedByPrice.RemoveAt(i);
                                break;
                            }
                        }
                        i--;
                        break;
                    }
                }
            }

        }

    }
}
