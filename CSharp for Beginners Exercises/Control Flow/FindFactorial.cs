using System;

namespace CSharp_for_Beginners_Exercises.Control_Flow
{
    /*
     * Write a program and ask the user to enter a number. Compute the factorial of the number
     * and print it on the console. For example, if the user enters 5, the programs should
     * calculate 5 x 4 x 3 x 2 x 1 and display it as 5! = 120
     */
    internal static class FindFactorial
    {
        public static void Run()
        {
            Console.WriteLine("Type in the number to find it's factorial: ");
            var number = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("{0}! = {1}", number, Factorial(number));
        }

        private static int Factorial(int number)
        {
            if (number == 0 || number == 1)
                return 1;

            return number * Factorial(number - 1);
        }
    }
}