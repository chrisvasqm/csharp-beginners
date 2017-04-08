// 2- Write a program and ask the user to enter a few numbers separated by a hyphen.
// If the user simply presses Enter, without supplying an input, exit immediately; 
// otherwise, check to see if there are duplicates.If so, display "Duplicate" on the console.

using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_for_Beginners_Exercises.Working_with_Text
{
    internal class SecondExercise
    {
        public void Run()
        {
            FindDuplicatesOrExitIfEmpty();
        }

        public void FindDuplicatesOrExitIfEmpty()
        {
            Console.WriteLine("Enter a series of numbers separated by '-'");
            var answer = Console.ReadLine();

            if (string.IsNullOrWhiteSpace(answer))
                Environment.Exit(0);

            var numbers = answer.Split('-').ToList();

            if (HasAnyDuplicate(numbers))
                Console.WriteLine("Duplicate");
        }

        public bool HasAnyDuplicate(List<string> numbers)
        {
            return numbers.GroupBy(n => n).Any(c => c.Count() > 1);
        }
    }
}
