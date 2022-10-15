using System;

namespace _3._Substring
{
    internal class Program
    {
        static void Main(string[] args)
        {
           
           string signsToBeRemoved = Console.ReadLine();
           string commnadToManipulate = Console.ReadLine();
            while (true)
            {
                int firstSingofSignsToBeRemoved = commnadToManipulate.IndexOf(signsToBeRemoved);
                if (firstSingofSignsToBeRemoved == -1)
                {
                    break;
                }
                else 
                {
                    commnadToManipulate = commnadToManipulate.Remove(firstSingofSignsToBeRemoved, signsToBeRemoved.Length);
                }
            }
            Console.WriteLine(commnadToManipulate);
        }
    }
}
