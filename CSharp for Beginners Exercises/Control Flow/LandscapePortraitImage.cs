using System;
using System.Linq;

namespace CSharp_for_Beginners_Exercises.Control_Flow
{
    // Write a program and ask the user to enter the width and height of an image.
    // Then tell if the image is landscape or portrait.
    internal static class LandscapePortraitImage
    {
        public static void Run()
        {
            Console.WriteLine("Type in the width of the image like '1920x1080' ");
            var resolution = Console
                .ReadLine()?
                .Split('x')
                .Select(int.Parse)
                .ToArray();
            
            var width = Convert.ToInt32(resolution?.First());
            var heigth = Convert.ToInt32(resolution?.Last());

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