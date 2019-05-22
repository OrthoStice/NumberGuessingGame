using System;

namespace Guessing_Game3
{
    class Program
    {
        static void Main(string[] args)
        {
            //const int MAX_NUMBER = 3;

            Random random = new Random();
            int numberToGuess = random.Next(20) + 1;
            int userGuess = 0;
            int numguesses = 0;

            while (userGuess != numberToGuess)
            {
                numguesses++;

                Console.Write("I am thinking of a number between 1 and 20, enter your number! You have 3 guesses!: ");
                int.TryParse(Console.ReadLine(), out userGuess);

                if (userGuess > numberToGuess)
                {
                    Console.WriteLine("{0} is too high, guess again!", userGuess);
                }
                else if (userGuess < numberToGuess)
                {
                    Console.WriteLine("{0} is too low, guess again!", userGuess);
                }
                else
                {
                    Console.WriteLine("{0} is right! Congrats! Would you like to play again?", userGuess);
                    Console.WriteLine("Number of guesses: {0}", numguesses);
                }
            }

        }


    }
}
