// Write a program and continuously ask the user to enter a number or "ok" to exit. 
// Calculate the sum of all the previously entered numbers and display it on the console.

using System;

namespace CSharp_for_Beginners_Exercises.Loops
{
    internal class SecondExercise
    {
        public void Run()
        {
            GetValue();
        }

        private static void GetValue()
        {
            var sum = 0;
            while (true)
            {
                Console.WriteLine("Enter a number: ");
                var input = Console.ReadLine();

                if (input == "ok")
                    break;

                var number = Convert.ToInt32(input);

                sum += number;

                Console.WriteLine("The current sum of all the values is: {0}", sum);
            }
        }
    }
}
