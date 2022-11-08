using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Reverse_a_String
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var command = Console.ReadLine();
            Stack<string> reversed = new Stack<string>();
            for (int i = 0; i < command.Length; i++)
            {
                reversed.Push(command[i].ToString());
            }

            while (reversed.Count >0)
            {
                Console.Write(reversed.Pop());

            }

        }
    }
}
