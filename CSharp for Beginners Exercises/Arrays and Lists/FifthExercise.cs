// 5- Write a program and ask the user to supply a list of comma separated numbers(e.g 5, 1, 9, 2, 10). 
// If the list is empty or includes less than 5 numbers, display "Invalid List" and ask the user to re-try; 
// otherwise, display the 3 smallest numbers in the list.

using System;
using System.Collections.Generic;

namespace CSharp_for_Beginners_Exercises.Arrays_and_Lists
{
    internal class FifthExercise
    {
        public void Run()
        {
            SeparateListWithCommas();
        }

        private static void SeparateListWithCommas()
        {
            Console.WriteLine("Enter a list of numbers separated by commas: ");
            var input = Console.ReadLine();

            if (string.IsNullOrEmpty(input))
            {
                Console.WriteLine("Invalid list. Please retry");
            }
            else
            {
                var numbers = input.Split((','));
                var nums = new List<int>();

                if (numbers.Length > 5)
                    Console.WriteLine("Invalid list. Please retry.");
                else
                {
                    foreach (var x in numbers)
                    {
                        nums.Add(Convert.ToInt32(x));
                    }

                    for (int i = 0; i < 3; i++)
                    {
                        nums.Sort();
                        Console.WriteLine(nums[i]);
                    }
                }
            }
        }
    }
}
