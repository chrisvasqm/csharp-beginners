using System;
using System.Linq;

namespace CSharp_for_Beginners_Exercises.Working_with_Text
{
    /*
     * Write a program and ask the user to enter a few words separated by a space.
     * Use the words to create a variable name with PascalCase. For example,
     * if the user types: "number of students". display "NumberOfStudents".
     * Make sure that the program is not dependent on the input. So, if the user
     * types "NUMBER OF STUDENTS", the program should still display "NumberOfStudents".
     */
    public static class ConvertWordToPascalCase
    {
        public static void Run()
        {
            Console.WriteLine("Type in any word/phrase to be converted to PascalCase");
            var input = Console.ReadLine();

            if (String.IsNullOrEmpty(input))
                throw new ArgumentException("Null, whitespaces or empty are not allowed.");

            var words = input.Split(' ')
                .Select(word => word.Trim().ToLower())
                .ToArray();

            Console.WriteLine("PascalCased: " + ConvertToPascalCase(words));
        }

        private static string ConvertToPascalCase(string[] words)
        {
            if (!words.Any())
                throw new ArgumentException("Array or List has no elements.");

            var pascaled = "";
            foreach (var word in words)
                pascaled += CapitalizeFirstLetter(word);

            return pascaled;
        }

        private static string CapitalizeFirstLetter(string word)
        {
            if (String.IsNullOrWhiteSpace(word))
                return string.Empty;

            var letters = word.ToCharArray();
            letters[0] = char.ToUpper(letters[0]);

            return new string(letters);
        }
    }
}