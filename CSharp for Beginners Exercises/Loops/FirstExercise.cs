
// Write a program to count how many numbers between 1 and 100 are divisible by 3 with no remainder.
// Display the count on the console.

using System;

namespace CSharp_for_Beginners_Exercises.Loops
{
    internal class FirstExercise
    {
        public void Run()
        {
            Console.WriteLine(CountNumbersDivisibleByThree(1, 100));
        }

        public int CountNumbersDivisibleByThree(int start, int end)
        {
            var count = 0;
            for (var i = start; i <= end; i++)
            {
                if (i % 3 == 0)
                    count++;
            }

            return count;
        }
    }
}
