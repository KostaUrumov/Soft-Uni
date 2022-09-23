using System;

namespace _9._Greater_of_Two_Values
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string method  = Console.ReadLine();
           string a = Console.ReadLine();
           string b = Console.ReadLine();

            if (method == "int")
            {

                Console.WriteLine (GetMax(int.Parse(a),int.Parse(b)));
            }

            if (method == "char")
            {
                Console.WriteLine(GetMax(char.Parse(a), char.Parse(b)));
            }

            else if (method =="string")
            {
                Console.WriteLine(GetMax(a, b));
            }
            
            
            
        }

        static int GetMax(int a, int b)
        {
            
            if (a > b)
            {
                return a;
            }

            else 
            {
                return b;
            }
        }

        static char GetMax(char a, char b)
        {
            
            if (a > b)
            {
                return a;
            }

            else
            {
                return b;
            }
        }

        static string GetMax(string a, string b)
        {
            if (a.CompareTo(b) > 0)
            {
                return a;
            }

            else
            {
                return b;
            }
        }
 
    }

}
