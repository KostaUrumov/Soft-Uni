using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentInformation
{
    internal class Program
    {

        static void Main(string[] args)
        {

            string newLine = Console.ReadLine();

            string[] arrayString = newLine.Split(' ');
            int[] numLine = new int[arrayString.Length];
            for (int i = 0; i < numLine.Length; i++)
            {
                numLine[i] = int.Parse(arrayString[i]);
            }

            int lowestNumber = int.MaxValue;
            int indexToUse =0;
            int sequence = -1;
            int bestSequence = 0;
            int lowestToUse = 0;
            int lowestIndex = 0;
            int timesDone = 0;
            int count = 0;
            int lowIndex = 0;
            int secondIndex = 0;
            int moreThanOnce = 0;
          
            


            int[] exhibitionArray = new int[arrayString.Length];
            for (int i = 0; i < numLine.Length; i++)
            {
                exhibitionArray[i] = int.Parse(arrayString[i]);
            }

            while (numLine.Length != timesDone)
            {
                sequence = 0;
                lowestNumber = int.MaxValue;

                for (int i = 0; i < numLine.Length; i++)
                {
                    if (numLine[i] < lowestNumber)
                    { 
                    lowestNumber = numLine[i];
                    indexToUse = i;
                    }
                    
                }

                count = 0;
                moreThanOnce = 0;
                for (int k = indexToUse; k < numLine.Length - 1; k++)
                {
                    if (numLine[k] <= numLine[k + 1])
                    {
                        sequence++;
                    }

                    if (numLine[k] > numLine[k + 1])
                    {
                        if (moreThanOnce > 0)
                        { 
                        for (int y = secondIndex + 1; y >= secondIndex; y--)
                        {
                            if (numLine[y] < numLine[y - 1])
                            {
                                sequence--;
                            }

                            else if (numLine[y] > numLine[y - 1])
                            {
                                secondIndex = y;
                                moreThanOnce++;
                                break;
                            }
                        }   

                            }
                        for (int y = k+1; y >= indexToUse; y--)
                        {
                            if (numLine[y] < numLine[y - 1])
                            {
                            sequence--;
                            }
                            else if (numLine[y] > numLine[y - 1])
                            {
                                secondIndex = y;
                                moreThanOnce++;
                                break;

                            }

                        } 
                    }
               }

                if (sequence > bestSequence ||  indexToUse == numLine.Length - 1)
                {
                    lowestToUse = lowestNumber;
                    lowestIndex = indexToUse;
                    numLine[lowestIndex] = int.MaxValue;

                }
                timesDone++;
            }

            for (int i = lowestIndex; i < exhibitionArray.Length; i++)
            {
                if (exhibitionArray[indexToUse] > exhibitionArray[i])
                {
                    exhibitionArray[i] = int.MaxValue;
                }
            }

            


        }
    } 
}

