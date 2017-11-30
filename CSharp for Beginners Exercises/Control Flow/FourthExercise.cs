// Your job is to write a program for a speed camera. For simplicity, ignore the details such as camera, sensors,
// etc and focus purely on the logic. Write a program that asks the user to enter the speed limit. 
// Once set, the program asks for the speed of a car. If the user enters a value less than the speed limit, 
// program should display Ok on the console. If the value is above the speed limit, the program should calculate 
// the number of demerit points. For every 5km/hr above the speed limit, 1 demerit points should be incurred and 
// displayed on the console. If the number of demerit points is above 12, the program should display License Suspended.

using System;

namespace CSharp_for_Beginners_Exercises.Control_Flow
{
    internal class FourthExercise
    {
        public void Run()
        {
            Console.WriteLine("Enter the speed limit value: ");
            var speedLimit = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter the speed of the car" );
            var carSpeed = Convert.ToInt32(Console.ReadLine());

            if (isHigherThanSpeedLimit(carSpeed, speedLimit))
            {
                var demeritPoints = 0;
                while (isHigherThanSpeedLimit(carSpeed, speedLimit))
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

        private static bool isHigherThanSpeedLimit(int carSpeed, int speedLimit)
        {
            return carSpeed > speedLimit;
        }
    }
}