using System;

namespace CSharp_for_Beginners_Exercises.Control_Flow
{
    /*
     * Write a program and ask the user to enter the width and height of an image.
     * Then tell if the image is landscape or portrait.
     */
    internal static class LandscapePortraitImage
    {
        public static void Run()
        {
            Console.WriteLine("Type in the width of an image to know if it is on Landscape or Portrait:");

            Console.WriteLine("Width: ");
            var width = Convert.ToInt32(Console.ReadLine());
            
            Console.WriteLine("Height: ");
            var heigth = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine(GetImageOrientation(width, heigth));
        }

        private static string GetImageOrientation(int width, int heigth)
        {
            if (width == heigth)
                return "Both values are the same. The image has a 1:1 ratio";
            if (width > heigth)
                return "Landscape";
            
            return "Portrait";
        }
    }
}