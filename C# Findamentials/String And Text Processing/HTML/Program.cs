using System;

namespace _5._HTML
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string article = Console.ReadLine();
            string content = Console.ReadLine();

            Console.WriteLine("<h1>");
            Console.WriteLine($"    {article}");
            Console.WriteLine("</h1>");
            Console.WriteLine("<article>");
            Console.WriteLine($"    {content}");
            Console.WriteLine("</article>");
            while (true)
            {
                string command = Console.ReadLine();
                if (command == "end of comments")
                {
                    break;
                }
                if (command != "end of comments")
                {
                    Console.WriteLine("<div>");
                    Console.WriteLine($"    {command}");
                    Console.WriteLine("</div>");
                }

            }
        }
    }
}
