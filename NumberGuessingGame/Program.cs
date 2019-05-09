using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberGuessingGame
{
    class Program
    {
        static void Main(string[] args)
        {
            //setting tryAgain value to true so game continues until the user chooses to end
            bool tryAgain = true;

            //min, max, and numbeOfTries can be changed in one place to adjust difficulty of the game
            int min = 1;
            int max = 20;
            int numberOfTries = 3;

            //a while loop that keeps going as long as tryAgain stays true. tryAgain can be set to false to break out 
            while (tryAgain == true)
            {
                //set to determine if the user won or not 
                bool winningGuess = false;
                //gets our random number for the user to try to guess and stores in a variable
                int random = GenerateRandomNumber(min, max);
                Console.WriteLine("I'm thinking of a number between {0} and {1}. Can you guess it in {2} tries?", min, max, numberOfTries);

                //asks user to enter a number for the numberOfTries we want to give them
                for (int i = 0; i < numberOfTries ; i++)
                {
                    Console.WriteLine("Enter a number between {0} and {1}:", min, max);
                    var guess = Console.ReadLine();
                        //evaluates if the number was too high too low or just right and tells the user
                        if (int.Parse(guess) > random)
                        {
                            Console.WriteLine("Your guess was too high. \r\n");
                        }
                        if (int.Parse(guess) < random)
                        {
                            Console.Write("Your guess was too low. \r\n");
                        }
                        if (int.Parse(guess) == random)
                        {
                            winningGuess = true;
                            break;
                        }
                }

                //send this message only if they didn't guess correctly
                if (winningGuess == !true)
                {
                    Console.WriteLine("The number I was thinking of was {0}. You didn't get it this time :(", random);
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("You guessed it!! The winning number was {0}.", random);
                    Console.WriteLine();
                }

                Console.WriteLine("Do you want to try again? Type Y or N", random);
                string entry = Console.ReadLine();

                //if the user selects no then we won't try again
                if (entry.ToLower().Equals("n"))
                {
                    tryAgain = false;
                }
            } 
        }

        static int GenerateRandomNumber(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min,max);
        }
    }
}
