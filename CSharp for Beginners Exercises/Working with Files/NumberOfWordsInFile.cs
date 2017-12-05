using System;
using System.IO;
using System.Text;

namespace CSharp_for_Beginners_Exercises.Working_with_Files
{
    // Write a program that reads a text file and displays the number of words.
    public class NumberOfWordsInFile
    {
        public static void Run()
        {
            var text = ReadFileToString("/Users/christianvasquez/RiderProjects/udemy-csharp-beginners/" +
                                        "CSharp for Beginners Exercises/Working with Files/words.txt");
            var words = text.Split(' ');
            Console.WriteLine("The word.txt file has {0} words inside it", words.Length);
        }

        private static string ReadFileToString(string filePath)
        {
            using (var streamReader = new StreamReader(@"" + filePath + "", Encoding.UTF8))
                return streamReader.ReadToEnd();
        }
    }
}