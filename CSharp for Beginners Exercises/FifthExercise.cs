// Write a program and ask the user to enter a series of numbers separated by comma. 
// Find the maximum of the numbers and display it on the console. For example, if the user enters “5, 3, 8, 1, 4", 
// the program should display 8.

using System;
using System.Linq;

namespace CSharp_for_Beginners_Exercises
{
    internal class FifthExercise
    {
        public void Run()
        {
            Console.WriteLine("Enter a series of numbers seperated by commas (Example: 1, 2, 3)");
            var numbers = Console.ReadLine();
            
            GetMaximumValueInArray(numbers);
        }

        private static void GetMaximumValueInArray(string numbers)
        {
            var numberList = numbers.Split(',');

            for (var i = 0; i < numberList.Length; i++)
                numberList[i] = Convert.ToInt32(numberList[i]).ToString();

            Console.WriteLine("The maximum number in the array is: " + numberList.Max());
        }
    }
}