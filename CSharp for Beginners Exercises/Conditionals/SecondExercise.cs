// Write a program which takes two numbers from the console and displays the maximum of the two.

using System;

namespace CSharp_for_Beginners_Exercises.Conditionals
{
    internal class SecondExercise
    {
        public void Run()
        {
            Console.WriteLine("Type in 2 numbers to be compared to know which one is the highest");
            var firstNumber = Convert.ToInt32(Console.ReadLine());
            var secondNumber = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Between {0} and {1}, the highest number is: {2}", firstNumber, secondNumber, GetHigherNumber(firstNumber, secondNumber));
        }

        private static int GetHigherNumber(int firstNumber, int secondNumber)
        {
            if (firstNumber == secondNumber)
                Console.WriteLine("The provided values are the same");

            return (firstNumber > secondNumber) ? firstNumber : secondNumber;
        }
    }
}