using System;
using System.Linq;

namespace CSharp_for_Beginners_Exercises.Working_with_Text
{
    /*
     * Write a program and ask the enter an English word. Count the number of vowels
     * (a, e, i, o, u) in the word. So, if the user enters "inadequate", the program
     * should display 6 in the console.
     */
    public static class CountVowels
    {
        public static void Run()
        {
            Console.WriteLine("Type in a word you wish to know how many vowels has:");
            var input = Console.ReadLine();

            Console.WriteLine("The word '{0}' has {1} vowels", input, CountVowelsInWord(input));
        }

        private static int CountVowelsInWord(string word)
        {
            var counter = 0;
            char[] vowels = {'a', 'e', 'i', 'o', 'u'};
            foreach (var letter in word)
            {
                if (vowels.Contains(letter))
                    counter++;
            }

            return counter;
        }
    }
}