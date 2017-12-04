using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_for_Beginners_Exercises.Working_with_Text
{
    /*
     * Write a program and ask the user to enter a few numbers separated by a hyphen.
     * If the user simply presses Enter, without supplying any input, exit immediately;
     * otherwise, check to see if there are duplicates.
     *
     * If so, display "Duplicate" on the console.
     */
    internal static class FindDuplicate
    {
        public static void Run()
        {
            Console.WriteLine("Enter a series of numbers separated by '-'");
            var answer = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(answer))
                Environment.Exit(0);

            var numbers = answer.Split('-').Select(number => Convert.ToInt32(number)).ToList();

            Console.WriteLine(HasAnyDuplicate(numbers) ? "Has duplicates" : "No duplicates were found");
        }

        private static bool HasAnyDuplicate(List<int> numbers)
        {
            return numbers.GroupBy(number => number).Any(duplicate => duplicate.Count() > 1);
        }
    }
}
