using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_for_Beginners_Exercises.Control_Flow
{
    /*
     * Write a program and ask the user to enter a series of numbers separated by coma.
     * Find the maximum of the numbers and display it on the console.
     * For example, if the user enters "5, 3, 8, 1, 4", the program should display 8.
     */
    internal static class FindMaxFromList
    {
        public static void Run()
        {
            Console.WriteLine("Enter a series of numbers seperated by commas (Example: 1, 2, 3)");
            var input = Console.ReadLine();
            var numbers = GetListFromValuesSeparatedWithCommas(input);
            var max = numbers?.Max();

            Console.WriteLine("The maximum number is: " + max);
        }

        private static IEnumerable<int> GetListFromValuesSeparatedWithCommas(string input)
        {
            return input?.Split(',').Select(number => Convert.ToInt32(number.Trim())).ToList();
        }
    }
}