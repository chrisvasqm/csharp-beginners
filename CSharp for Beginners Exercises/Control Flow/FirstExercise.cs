// Write a program and ask the user to enter a number. The number should be between 1 to 10.
// If the user enters a valid number, display "Valid" on the console. Otherwise, display "Invalid". 
// (This logic is used a lot in applications where values entered into input boxes need to be validated.)

using System;

namespace CSharp_for_Beginners_Exercises.Control_Flow
{
    internal class FirstExercise
    {
        public void Run()
        {
            Console.WriteLine("Enter a number between 1 to 10");
            var input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(IsBetweenOneToTen(input) ? "Valid" : "Invalid");
        }

        private static bool IsBetweenOneToTen(int input)
        {
            return input >= 1 && input <= 10;
        }
    }
}