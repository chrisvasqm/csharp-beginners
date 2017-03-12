// Write a program that picks a random number between 1 and 10. Give the user 4 chances to guess the number. 
// If the user guesses the number, display “You won"; otherwise, display “You lost". 
// (To make sure the program is behaving correctly, you can display the secret number on the console first.)

using System;

namespace CSharp_for_Beginners_Exercises.Loops
{
    internal class FourthExercise
    {
        public void Run()
        {
            var guess = GetGuessNumber();

            Console.WriteLine("Try to guess a number from 1 to 10. You have 4 chances");

            AttemptToGuess(guess);
        }

        private static int GetGuessNumber()
        {
            var random = new Random();
            return random.Next(1, 10);
        }

        private static void AttemptToGuess(int guess)
        {
            for (var i = 1; i < 5; i++)
            {
                Console.Write("Guess #{0}: ", i);
                var input = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("");

                if (input == guess)
                {
                    Console.WriteLine("You won!");
                    break;
                }

                if (i != 4) continue;
                Console.WriteLine("You lost :(. The number was {0}", guess);
                break;
            }
        }
    }
}
