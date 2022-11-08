using System;

namespace Pizza_Calories
{
    internal class Program
    {
        static void Main(string[] args)
        {

            while (true)
            {
                string[] commandLineParts = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);
                if (commandLineParts[0] == "END")
                {
                    break;
                }

                try
                {
                    Dough dough = new Dough(commandLineParts[1].ToLower(), commandLineParts[2].ToLower(), double.Parse(commandLineParts[3]));
                    dough.DoughCalories(double.Parse(commandLineParts[3]), commandLineParts[1].ToLower(), commandLineParts[2].ToLower());

                }
                catch (Exception y)
                {

                    Console.WriteLine(y.Message);
                    return;
                }



                string[] com = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);


                try
                {
                    Topping top = new Topping(com[1].ToLower(), double.Parse(com[2]));
                    top.calculateCal(double.Parse(com[2]), com[1].ToLower());

                }
                catch (Exception y)
                {

                    Console.WriteLine(y.Message);
                    return;
                }

            }
        }
    }
}
