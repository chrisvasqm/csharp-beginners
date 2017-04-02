// 1- When you post a message on Facebook, depending on the number of people who like your post, Facebook displays 
//    different information.
//
//    If no one likes your post, it doesn't display anything.
//    
//    If only one person likes your post, it displays: [Friend's Name] likes your post.
//    
//    If two people like your post, it displays: [Friend 1]
//    and[Friend 2] like your post.
//    
//    If more than two people like your post, it displays: [Friend 1], [Friend 2] and[Number of Other People] 
//    others like your post.
//
// Write a program and continuously ask the user to enter different names, until the user presses Enter 
// (without supplying a name). Depending on the number of names provided, display a message based on the above pattern.

using System;
using System.Collections.Generic;

namespace CSharp_for_Beginners_Exercises.Arrays_and_Lists
{
    internal class FirstExercise
    {
        public void Run()
        {
            LikeAPost();
        }

        public void LikeAPost()
        {
            var likes = new List<string>();
            while (true)
            {
                Console.WriteLine("Enter a name: (Leave it empty to close the program)");
                var name = Console.ReadLine();

                if (string.IsNullOrEmpty(name))
                    break;

                likes.Add(name);
                GetLikes(likes);
            }
        }

        private static void GetLikes(List<string> likes)
        {
            if (likes.Count > 2)
            {
                var extraLikes = likes.GetRange(2, likes.Count - 2);
                Console.WriteLine("{0}, {1} and {2} liked your post", likes[0], likes[1], extraLikes.Count);
            }
            else if (likes.Count == 2)
                Console.WriteLine("{0} and {1} liked your post", likes[0], likes[1]);
            else
                Console.WriteLine(likes[0] + " liked your post");
        }
    }
}
