using System;
using System.Collections.Generic;

namespace CSharp_for_Beginners_Exercises.Arrays_and_Lists
{
    /*
     * When you post a message on Facebook, depending on the number of people who like
     * your post, Facebook displays different information.
     *
     * If no one likes your post, it doesn't display anything.
     *
     * If only one person likes your post, it displays: [Friend's Name] likes your post.
     *
     * If two people like your post, it displays: [Friend 1]
     * and [Friend 2] like your post.
     *
     * If more than two people like your post, it displays: [Friend 1], [Friend 2] and
     * [Number of Other People] others like your post.
     *
     * Write a program and constinuously ask the user to enter a different name, until
     * the user presses ENTER (without supplying a name). Depending on the number of
     * names provided, display a message based on the above pattern.
     * 
     */
    internal static class FriendsWhoLikeYourPost
    {
        public static void Run()
        {
            var names = new List<string>();

            while (true)
            {
                var name = AskForName();

                if (string.IsNullOrEmpty(name))
                    break;

                names.Add(name);
                Console.WriteLine(GetLikesMessage(names));
            }
        }
        
        private static string AskForName()
        {
            Console.WriteLine("Enter a name: (Leave it empty to close the program)");
            return Console.ReadLine();
        }

        private static string GetLikesMessage(List<string> names)
        {
            if (names.Count > 2)
                return names[0] + ", " + names[1] + " and " + GetExtraLikes(names).Count + " liked your post";
            if (names.Count == 2)
                return names[0] + " and " + names[1] + " liked your post";

            return names[0] + " liked your post";
        }

        private static List<string> GetExtraLikes(List<string> names)
        {
            return names.GetRange(2, names.Count - 2);
        }
    }
}