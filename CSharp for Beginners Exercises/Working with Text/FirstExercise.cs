// 1- Write a program and ask the user to enter a few numbers separated by a hyphen.Work out if the numbers are consecutive. 
// For example, if the input is "5-6-7-8-9" or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display "Not Consecutive".

using System;
using System.Collections.Generic;

namespace CSharp_for_Beginners_Exercises.Working_with_Text
{
    internal class FirstExercise
    {
        public void Run()
        {
            FindConsecutiveInText();
        }

        public void FindConsecutiveInText()
        {
            Console.WriteLine("Enter a list of numbers separated by '-'");
            var answer = Console.ReadLine();

            var numbers = answer.Split('-');

            Console.WriteLine(IsConsecutive((numbers)) ? "Consecutive" : "Not Consecutive");
        }

        private static bool IsConsecutive(string[] numbers)
        {
            var nums = new List<int>();
            foreach (var number in numbers)
                nums.Add(Convert.ToInt32(number));

            for (var i = 0; i < nums.Count; i++)
                return (nums[i] < nums[i + 1]);

            return false;
        }
    }
}
