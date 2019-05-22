using System;

namespace KimGuessingGame
{
    class Program
    {
        static int GenerateRandomNumber(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min, max);
        }

        static void Main(string[] args)
        {
            int min = 1;
            int max = 20;
            int returnValue = GenerateRandomNumber(min, max);
            int Guess = 0;
            int numGuesses = 0;

            Console.WriteLine("I am thinking of a number between {0}-{1}.  Can you guess what it is?", min, max);

            while (Guess != returnValue)
            {
                Guess = Convert.ToInt32(Console.ReadLine());
                if (Guess < returnValue)
                {
                    Console.WriteLine("No, the number I am thinking of is higher than " + Guess + " .  Can you guess what it is?");
                }
                if (Guess > returnValue)
                {
                    Console.WriteLine("No, the number I am thinking of is lower than " + Guess + " .  Can you guess what it is");
                }
            }
            numGuesses++;
            Console.WriteLine("Well done! The answer was " + returnValue + ".\nYou took " + numGuesses + " guesses.");
        }
    }

}


