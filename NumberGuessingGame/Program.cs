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
            int min = 1;
            int max = 20;
            Console.WriteLine("I'm thinking of a number between {0} and {1}.  Can you guess it in 3 tries?", min, max);

            // TODO: Create a console app that picks a random number and then gives the user 3 chances to guess it.


            //TODO: Use our GenerateRandomNumber() method to generate the number and store it in a variable.

            //TODO: while loop for three guesses
            //ask the user to guess a number between 1 and 20 (use console.writeline) 
            //store the users answer in a variable
            //use an if else conditional to determine if their guess is equal to yours 
                    //if equal win, give them a win message


            // With each incorrect answer tell the user if the correct answer is higher or lower.
            // At the end ask if they want to play again or end.

            Console.ReadKey();

        }

        static int GenerateRandomNumber(int min, int max)
        {
            Random rnd = new Random();
            return rnd.Next(min,max);
        }
    }
}
