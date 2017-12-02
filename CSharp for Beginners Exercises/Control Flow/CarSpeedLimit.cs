using System;

namespace CSharp_for_Beginners_Exercises.Control_Flow
{
    /*
     * Your job is to write a program for a speed camera.
     *
     * For simplicity, ignore the details such as camera, sensors, etc and focus purely on the logic.
     *
     * Write a program that asks the user to enter the speed limit.
     * 
     * Once set, the program asks for the speed of a car.
     *
     * If the user enters a value less than the speed limit, program should dispplay OK on the console.
     *
     * If the value is above the speed limit, the program should calculate the number of demerit points.
     * 
     * For every 5km/hr above the speed limit, 1 demerit poinst should be incurred and displayed on the console.
     * 
     * If the number of demerit poinst is above 12, the program should display License Suspended.
     */
    internal static class CarSpeedLimit
    {
        public static void Run()
        {
            Console.WriteLine("Enter the speed limit value: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the speed of the car");
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (carSpeed > speedLimit)
            {
                var demeritPoints = 0;
                while (carSpeed > speedLimit)
                {
                    carSpeed -= 5;
                    demeritPoints++;
                }

                if (demeritPoints > 12)
                    Console.WriteLine("License Suspended.");
            }
            else
            {
                Console.WriteLine("OK");
            }
        }
    }
}