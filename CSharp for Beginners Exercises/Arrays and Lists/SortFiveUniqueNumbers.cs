using System;
using System.Collections.Generic;

namespace CSharp_for_Beginners_Exercises.Arrays_and_Lists
{
    /*
     * Write a program and ask the user to enter 5 numbers.
     *
     * If a number has been previously entered, display an error message
     * and ask the user to re-try.
     *
     * Once the user successfully enters 5 unique numbers, sort them and display
     * the result on the console.
     */
    internal static class SortFiveUniqueNumbers
    {
        public static void Run()
        {
            Console.WriteLine("Enter 5 unique numbers");
            const int uniqueAmount = 5;

            var numbers = new List<int>();
            while (true)
            {
                Console.WriteLine("Your number is: ");
                var number = Convert.ToInt32(Console.ReadLine());

                if (numbers.Contains(number))
                    Console.WriteLine("Provide a number that hasn't been used before");
                else
                    numbers.Add(number);

                if (numbers.Count == uniqueAmount) continue;
                numbers.Sort();
                break;
            }

            numbers.ForEach(Console.WriteLine);
        }
    }
}