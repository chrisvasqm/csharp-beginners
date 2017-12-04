using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_for_Beginners_Exercises.Working_with_Text
{
    /*
     * Write a program and ask the user to enter a few numbers separated by a hyphon.
     * Workout if the numbers are consecutive. For example, if the input is "5-6-7-8-9"
     * or "20-19-18-17-16", display a message: "Consecutive"; otherwise, display
     * "Not-Consecutive".
     */
    internal static class ConsecutiveNumbers
    {
        public static void Run()
        {
            Console.WriteLine("Enter a list of numbers separated by '-'");
            var answer = Console.ReadLine();
            var numbers = GetNumbersWithoutHyphon(answer);
            Console.WriteLine(IsConsecutive(numbers) ? "Consecutive" : "Not Consecutive");
        }

        private static List<int> GetNumbersWithoutHyphon(string answer)
        {
            return answer?.Split('-').Select(number => Convert.ToInt32(number)).ToList();
        }

        private static bool IsConsecutive(List<int> numbers)
        {
            var firstNumber = numbers[0];
            var secondNumber = numbers[1];
            var temporalNumber = firstNumber;
            var countConsecutives = 1;
            if (IsAscending(firstNumber, secondNumber))
            {
                foreach (var number in numbers)
                {
                    if (IsAscending(temporalNumber, number))
                    {
                        temporalNumber = number;
                        countConsecutives++;
                    }
                }
            }
            else
            {
                foreach (var number in numbers)
                {
                    if (IsDescending(temporalNumber, number))
                    {
                        temporalNumber = number;
                        countConsecutives++;
                    }
                }
            }

            return numbers.Count == countConsecutives;
        }

        private static bool IsAscending(int current, int next)
        {
            return current - next == -1;
        }

        private static bool IsDescending(int current, int next)
        {
            return current - next == 1;
        }
    }
}