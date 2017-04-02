// 2- Write a program and ask the user to enter their name.Use an array to reverse the name and then store the result in 
// a new string. Display the reversed name on the console.

using System;
using System.Collections.Generic;
using System.Linq;

namespace CSharp_for_Beginners_Exercises.Arrays_and_Lists
{
    internal class SecondExercise
    {
        public void Run()
        {
            ReverseName();
        }

        public void ReverseName()
        {
            Console.WriteLine("Enter the name you wish to reverse: ");
            var name = Console.ReadLine();

            if (string.IsNullOrEmpty(name))
            {
                Console.WriteLine("Please provide a name");
            }
            else
            {
                var list = new List<char>();
                foreach (var character in name)
                {
                    list.Add(character);
                }

                list.Reverse();

                var reversedName = string.Join("", list.ToArray());

                Console.WriteLine("The name {0} gets reversed to {1}", name, reversedName);
            }
        }
    }
}
