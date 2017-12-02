using System;

namespace CSharp_for_Beginners_Exercises.Control_Flow
{
    /*
     * Write a program and continously ask the user to enter a number or "ok" to exit.
     * Calculate the sum of all the previously entered numbers and siplay it on the console.
     */
    internal static class SumAllEnteredNumbers
    {
        public static void Run()
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
            }
            
            Console.WriteLine("Sum of all the numbers is: {0}", sum);
        }
    }
}