using System;
using System.Collections.Generic;
using System.Text;

namespace _4._Morse_Code_Translator
{
    internal class Program
    {
        static void Main(string[] args)
        {
           string command = Console.ReadLine();
           string commandInLetters = string.Empty;
           string [] morseCodeparts = command.Split(" | ");

            for (int i = 0; i < morseCodeparts.Length; i++)
            {
                string[] partsOfTheWord = morseCodeparts[i].Split(" ");
                for (int h = 0;  h < partsOfTheWord.Length;  h++)
                {
                    if (partsOfTheWord[h].ToString() == ".-")
                    {
                        commandInLetters += "A";
                        
                    }
                    if (partsOfTheWord[h].ToString() == "-...")
                    {
                        commandInLetters += "B";
                        
                    }
                    if (partsOfTheWord[h].ToString() == "-.-.")
                    {
                        commandInLetters += "C";
                        
                    }
                    if (partsOfTheWord[h].ToString() == "-..")
                    {
                        commandInLetters += "D";
                        
                    }
                    if (partsOfTheWord[h].ToString() == ".")
                    {
                        commandInLetters += "E";
                        
                    }
                    if (partsOfTheWord[h].ToString() == "..-.")
                    {
                        commandInLetters += "F";
                        
                    }
                    if (partsOfTheWord[h].ToString() == "--.")
                    {
                        commandInLetters += "G";
                        
                    }
                    if (partsOfTheWord[h].ToString() == "....")
                    {
                        commandInLetters += "H";
                        
                    }
                    if (partsOfTheWord[h].ToString() == "..")
                    {
                        commandInLetters += "I";
                        
                    }
                    if (partsOfTheWord[h].ToString() == ".---")
                    {
                        commandInLetters += "J";
                        
                    }
                    if (partsOfTheWord[h].ToString() == "-.-")
                    {
                        commandInLetters += "K";
                        
                    }

                    if (partsOfTheWord[h].ToString() == "-.-")
                    {
                        commandInLetters += "K";
                        
                    }

                    if (partsOfTheWord[h].ToString() == ".-..")
                    {
                        commandInLetters += "L";
                        
                    }
                    if (partsOfTheWord[h].ToString() == "--")
                    {
                        commandInLetters += "M";
                        
                    }
                    if (partsOfTheWord[h].ToString() == "-.")
                    {
                        commandInLetters += "N";
                        
                    }
                    if (partsOfTheWord[h].ToString() == "---")
                    {
                        commandInLetters += "O";
                        
                    }
                    if (partsOfTheWord[h].ToString() == ".--.")
                    {
                        commandInLetters += "P";
                        
                    }
                    if (partsOfTheWord[h].ToString() == "--.-")
                    {
                        commandInLetters += "Q";
                        
                    }
                    if (partsOfTheWord[h].ToString() == ".-.")
                    {
                        commandInLetters += "R";
                        
                    }
                    if (partsOfTheWord[h].ToString() == "...")
                    {
                        commandInLetters += "S";
                        
                    }
                    if (partsOfTheWord[h].ToString() == "-")
                    {
                        commandInLetters += "T";
                        
                    }
                    if (partsOfTheWord[h].ToString() == "..-")
                    {
                        commandInLetters += "U";
                        
                    }
                    if (partsOfTheWord[h].ToString() == "...-")
                    {
                        commandInLetters += "V";
                        
                    }
                    if (partsOfTheWord[h].ToString() == ".--")
                    {
                        commandInLetters += "W";
                        
                    }
                    if (partsOfTheWord[h].ToString() == "-..-")
                    {
                        commandInLetters += "X";
                        
                    }
                    if (partsOfTheWord[h].ToString() == "-.--")
                    {
                        commandInLetters += "Y";
                        
                    }
                    if (partsOfTheWord[h].ToString() == "--..")
                    {
                        commandInLetters += "Z";
                        
                    }
                    if (h == partsOfTheWord.Length - 1)
                    {
                        commandInLetters += " ";
                    }
                }


            }
            Console.WriteLine(commandInLetters);

        }
    }
}
