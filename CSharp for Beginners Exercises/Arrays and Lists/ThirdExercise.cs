// 3- Write a program and ask the user to enter 5 numbers.If a number has been previously entered, display an error message and ask the user to re-try. 
// Once the user successfully enters 5 unique numbers, sort them and display the result on the console.

using System;
using System.Collections.Generic;

namespace CSharp_for_Beginners_Exercises.Arrays_and_Lists
{
    internal class ThirdExercise
    {
        public void Run()
        {
            SortUniqueNumbers();
        }

        public void SortUniqueNumbers()
        {
            Console.WriteLine("Enter 5 unique numbers");
            var numbers = new List<int>();

            while (true)
            {
                Console.WriteLine("Your number is: ");
                var input = Convert.ToInt32(Console.ReadLine());

                if (!numbers.Contains(input))
                    numbers.Add(input);
                else if (numbers.Contains(input))
                    Console.WriteLine("Please, provide a number that hasn't been used before");

                if (numbers.Count != 5) continue;
                numbers.Sort();
                break;
            }

            Console.WriteLine("");

            foreach (var x in numbers)
                Console.WriteLine(x);
        }
    }
}
