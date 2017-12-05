using System;
using System.IO;
using System.Text;

namespace CSharp_for_Beginners_Exercises.Working_with_Files
{
    // Write a program that reads a file and displays the longest word in the file.
    public static class LongestWordInFile
    {
        public static void Run()
        {
            var text = ReadFileToString("/Users/christianvasquez/RiderProjects/" +
                                        "udemy-csharp-beginners/CSharp for Beginners Exercises/" +
                                        "Working with Files/words.txt");
            var words = text.Split(' ');
            var longestWord = "";
            foreach (var word in words)
            {
                if (longestWord.Length < word.Length)
                    longestWord = word;
            }
            Console.WriteLine("The longest word in the word.txt file is: " + longestWord);
        }

        private static string ReadFileToString(string filePath)
        {
            using (var streamReader = new StreamReader(@"" + filePath + "", Encoding.UTF8))
                return streamReader.ReadToEnd();
        }
    }
}