using System;

namespace CSharp_for_Beginners_Exercises.Working_with_Text
{
    /*
     * Write a program and ask the user to enter a time value in the 24 hour time format
     * (e.g. 19:00). A valid time should be between 00:00 and 23:59. If the time is valid,
     * display "Ok"; otherwise, display "Invalid Time".
     *
     * If the user doesn't provide any values, consider it as invalid time.
     */
    public static class ValidTimeRange
    {
        public static void Run()
        {
            Console.WriteLine("Type in a time value between 00:00 and 23:59");
            var input = Console.ReadLine();
            if (string.IsNullOrWhiteSpace(input))
            {
                Console.WriteLine("Invalid Time");
            }
            else
            {
                var hour = Convert.ToInt32(input?.Split(':')[0]);
                var minute = Convert.ToInt32(input?.Split(':')[1]);

                if (IsValidHour(hour) && IsValidMinute(minute))
                    Console.WriteLine("Ok");
                else
                    Console.WriteLine("Invalid Time");
            }
        }

        private static bool IsValidHour(int hour)
        {
            return hour >= 0 && hour <= 23;
        }

        private static bool IsValidMinute(int minute)
        {
            return minute >= 0 && minute <= 59;
        }
    }
}