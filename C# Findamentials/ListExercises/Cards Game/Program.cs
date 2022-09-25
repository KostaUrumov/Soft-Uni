using System;
using System.Collections;
using System.Collections.Generic;


namespace _6._Cards_Game
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string lineOne = Console.ReadLine();
            string lineTwo = Console.ReadLine();
            string [] handOne = lineOne.Split(' ');
            string [] handTwo = lineTwo.Split(' ');

            List<int> playerOneCards = new List<int>();
            List<int> playerTwoCards = new List<int>();

            for (int i = 0; i < handOne.Length; i++)
            {
                playerOneCards.Add(int.Parse(handOne[i]));
            }

            for (int i = 0; i < handTwo.Length; i++)
            {
                playerTwoCards.Add(int.Parse(handTwo[i]));
            }

            while (true)
            {
                if (playerOneCards.Count == 0)
                {
                    break;
                }

                if (playerTwoCards.Count == 0)
                {
                    break;
                }


                if (playerOneCards[0] > playerTwoCards[0])
                {
                    playerOneCards.Add(playerTwoCards[0]);
                    playerOneCards.Add(playerOneCards[0]);
                    playerOneCards.RemoveAt(0);
                    playerTwoCards.RemoveAt(0);
                    continue;
                }

                else if (playerOneCards[0] < playerTwoCards[0])
                {
                    playerTwoCards.Add(playerOneCards[0]);
                    playerTwoCards.Add(playerTwoCards[0]);
                    playerOneCards.RemoveAt(0);
                    playerTwoCards.RemoveAt(0);
                    continue;
                }

                else if (playerOneCards[0] == playerTwoCards[0])
                {
                    playerOneCards.RemoveAt(0);
                    playerTwoCards.RemoveAt(0);
                    continue;

                }
            }

            if (playerOneCards.Count > playerTwoCards.Count)
            {
                int sum = 0;
                for (int i = 0; i < playerOneCards.Count; i++)
                {
                    sum += playerOneCards[i]; 
                }

                Console.WriteLine($"First player wins! Sum: {sum}");
            }

            else if (playerOneCards.Count < playerTwoCards.Count)
            {
                int sum = 0;
                for (int i = 0; i < playerTwoCards.Count; i++)
                {
                    sum += playerTwoCards[i];
                }

                Console.WriteLine($"Second player wins! Sum: {sum}");
            }


        }
    }
}
