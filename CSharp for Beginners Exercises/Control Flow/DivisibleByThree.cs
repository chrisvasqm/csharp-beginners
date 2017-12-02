using System;

namespace CSharp_for_Beginners_Exercises.Control_Flow
{
    /*
     * Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
     * Display the count on the console.
     */
    internal static class DivisibleByThree
    {
        public static void Run()
        {
            Console.WriteLine("How many numbers are divisible by 3? {0}", CountNumbersDivisibleByThree());
        }

        private static int CountNumbersDivisibleByThree()
        {
            var count = 0;
            for (var i = 1; i <= 100; i++)
                if (i % 3 == 0) count++;

            return count;
        }
    }
}