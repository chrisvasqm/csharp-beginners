// Write a program and ask the user to enter a number. Compute the factorial of the number and print it on the console. 
// For example, if the user enters 5, the program should calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120.

using System;

namespace CSharp_for_Beginners_Exercises
{
    internal class ThirdExercise
    {
        public void Run()
        {
            Console.WriteLine("Type in the number you want to find the factorial: ");
            var input = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}! = {1}", input, Factorial(input));
        }

        public int Factorial(int number)
        {
            if (number == 0 || number == 1)
                return 1;

            return number * Factorial(number - 1);
        }
    }
}