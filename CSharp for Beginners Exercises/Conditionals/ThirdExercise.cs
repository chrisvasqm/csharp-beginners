// Write a program and ask the user to enter the width and height of an image.
// Then tell if the image is landscape or portrait.

using System;

namespace CSharp_for_Beginners_Exercises.Conditionals
{
    internal class ThirdExercise
    {
        public void Run()
        {
            Console.WriteLine("Type in the width of the image: ");
            var width = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Type in the heigth of the image: ");
            var heigth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GetImageOrientation(width, heigth));
        }

        private static string GetImageOrientation(int width, int heigth)
        {
            if (width == heigth)
                return "Both values are the same. The image has a 1:1 ratio";

            return (width > heigth) ? "Landscape" : "Portrait";
        }
    }
}