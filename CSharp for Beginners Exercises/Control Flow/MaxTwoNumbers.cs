using System;

namespace CSharp_for_Beginners_Exercises.Control_Flow
{
    // Write a program which takes two numbers from the console and displays the maximum of the two.
    internal static class MaxTwoNumbers
    {
        public static void Run()
        {
            Console.WriteLine("Type in 2 numbers (separated by space)to be compared to know which one is the highest");

            Console.WriteLine("First number: ");
            var firstNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Second number: ");
            var secondNumber = Convert.ToInt32(Console.ReadLine());

            if (firstNumber == secondNumber)
                Console.WriteLine("The provided values are the same");
            else
                Console.WriteLine("Between {0} and {1}, the highest number is: {2}", firstNumber, secondNumber,
                    GetHighestNumber(firstNumber, secondNumber));
        }

        private static int GetHighestNumber(int firstNumber, int secondNumber)
        {
            return (firstNumber > secondNumber) ? firstNumber : secondNumber;
        }
    }
}