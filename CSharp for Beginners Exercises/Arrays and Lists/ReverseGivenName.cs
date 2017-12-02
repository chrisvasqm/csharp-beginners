using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_for_Beginners_Exercises.Arrays_and_Lists
{
    /*
     * Write a program and ask the user to enter their name.
     * Use an array to reverse the name and then store the result in a new String.
     *
     * Display the reversed name on the console.
     */
    internal static class ReverseGivenName
    {
        public static void Run()
        {
            Console.WriteLine("Enter the name you wish to reverse: ");
            var name = Console.ReadLine();
            var reversedName = GetReversedName(name);
            
            Console.WriteLine("The name {0} gets reversed to {1}", name, reversedName);
        }

        private static string GetReversedName(string name)
        {
            var list = name.ToList();
            list.Reverse();

            return string.Join("", list.ToArray());
        }
    }
}