using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_for_Beginners_Exercises.Arrays_and_Lists
{
    /*
     * Write a program and ask the user to supply a list of coma separated numbers
     * (e.g. 5, 1, 9, 2, 10).
     *
     * If the list is empty or includes less than 5 numbers, display "Invalid List"
     * and ask the user to re-try; otherwise, display the 3 smallest numbers in the list.
     */
    internal static class ThreeSmallestNumbersInList
    {
        public static void Run()
        {
            Console.WriteLine("Enter a list of numbers separated by commas: ");
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
                Console.WriteLine("The list cannot be empty or null. Please retry");
            else
            {
                var numbers = GetNumbersListSeparatedByComa(input);
                numbers.Sort();
                if (numbers.Count < 5)
                    Console.WriteLine("Invalid list, has less than 5 numbers. Please retry.");
                else
                {
                    var smallestThreeNumbers = new List<int>();
                    for (var i = 0; i < 3; i++)
                        smallestThreeNumbers.Add(numbers[i]);

                    smallestThreeNumbers.ForEach(Console.WriteLine);
                }
            }
        }

        private static List<int> GetNumbersListSeparatedByComa(string input)
        {
            return input.Split((',')).Select(s => Convert.ToInt32(s.Trim())).ToList();
        }
    }
}