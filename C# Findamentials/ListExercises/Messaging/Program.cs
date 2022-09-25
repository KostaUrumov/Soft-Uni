using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace ListExercisesMOre
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string line = Console.ReadLine();
            string textLine = Console.ReadLine();


            List<string> text = new List<string>();
            for (int i = 0; i < textLine.Length; i++)
            {
                char c = textLine[i];
                text.Add(c.ToString());
            }

            int sumNum = 0;

            string toPrint = "";

            
           
            string[] lines = line.Split(' ');

            for (int i = 0; i < lines.Length; i++)
            {
                string lineToUse = lines[i];
                for (int r = 0; r < lineToUse.Length; r++)
                {
                    char c = lineToUse[r];
                    int numberAdd = (int)char.GetNumericValue(c);
                    sumNum += numberAdd;
                }
                if (sumNum > text.Count)
                {
                    int indexWeNeed = sumNum - text.Count;
                    toPrint += text[indexWeNeed];
                    text.RemoveAt(indexWeNeed);
                }
                else
                {
                    toPrint += text[sumNum];
                    text.RemoveAt(sumNum);
                }
                sumNum = 0;
            }
            Console.WriteLine(toPrint);

        }
    }
}
