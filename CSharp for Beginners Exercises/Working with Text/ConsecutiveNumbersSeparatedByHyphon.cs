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
    internal static class ConsecutiveNumbersSeparatedByHyphon
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
            var isAscending = numbers[0] - numbers[1] == -1;
            var countConsecutives = 1;

            if (isAscending)
            {
                for (var i = 0; i < numbers.Count - 1; i++)
                {
                    if (i == numbers.Count && numbers[i - 1] - numbers[i] == -1)
                        countConsecutives++;
                    else if (numbers[i] - numbers[i + 1] == -1)
                        countConsecutives++;
                }
            }
            else
            {
                for (var i = 0; i < numbers.Count - 1; i++)
                {
                    if (i == numbers.Count && numbers[i - 1] - numbers[i] == 1)
                        countConsecutives++;
                    if (numbers[i] - numbers[i + 1] == 1)
                        countConsecutives++;
                }
            }

            return numbers.Count == countConsecutives;
        }
    }
}