// 4- Write a program and ask the user to continuously enter a number or type "Quit" to exit. 
// The list of numbers may include duplicates. Display the unique numbers that the user has entered.

using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_for_Beginners_Exercises.Arrays_and_Lists
{
    internal class FourthExercise
    {
        public void Run()
        {
            DisplayUniqueNumbers();
        }

        private static void DisplayUniqueNumbers()
        {
            Console.WriteLine("Enter whatever number you like or 'quit' to exit out and view the results");
            Console.WriteLine("");

            var numbers = new List<int>();

            while (true)
            {
                var input = Console.ReadLine();

                if (input != null && input.ToLower() == "quit")
                {
                    numbers.Sort();

                    var result = numbers.Distinct().ToList();

                    // Displays all the numbers on the list
                    foreach (var number in result)
                        Console.WriteLine(number);
                }
                else
                {
                    numbers.Add(Convert.ToInt32(input));
                }
            }
        }
    }
}
