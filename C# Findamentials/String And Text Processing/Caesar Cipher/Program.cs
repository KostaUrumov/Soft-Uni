using System;
using System.Text;

namespace _4.__Caesar_Cipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string message = Console.ReadLine();
            StringBuilder encryptedMessage = new StringBuilder();
            for (int i = 0; i < message.Length; i++)
            {
                char c = message[i];
                char s = Convert.ToChar(c + 3 );
                encryptedMessage.Append(s);
            }

            Console.WriteLine(encryptedMessage);
        }
    }
}
