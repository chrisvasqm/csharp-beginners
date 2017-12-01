using System;

namespace CSharp_for_Beginners_Exercises.Control_Flow
{
    /*
     * Write a program and ask the user to enter a number. The number should be between 1 to 10.
     * If the user en ters a valid number, display "Valid" on the console. Otherwise, display "Invalid".
     * (This logic is used a lot in applications where values entered into input boxes need to be validadted.)
     */
    internal class ValidNumber
    {
        public void Run()
        {
            Console.WriteLine("Enter a number between 1 to 10");
            var number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(IsBetweenOneToTen(number) ? "Valid" : "Invalid");
        }

        private static bool IsBetweenOneToTen(int number)
        {
            return number >= 1 && number <= 10;
        }
    }
}