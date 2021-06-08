using ConsoleAppProject.App01;
using ConsoleAppProject.App02;
using ConsoleAppProject.App03;
using ConsoleAppProject.Helpers;
using System;

namespace ConsoleAppProject
{
    /// <summary>
    /// The main method in this class is called first
    /// when the application is started.  It will be used
    /// to start Apps 01 to 05 for CO453 CW1
    /// This Project has been modified by:
    /// Abdul Salam 14/12/2020
    /// </summary>
    public static class Program
    {
        public static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            
            Console.WriteLine("BNU CO453 Applications Programming 2020-2021!");
            Console.WriteLine();
            Console.Beep();

            string [] choices = { "\n1. Distance Converter", "2. BMI Calculator", "3. Student Grades",
            "4. Social Network", "5. RPG Game"
            };

            int choice = ConsoleHelper.SelectChoice(choices);

            if (choice == 1)
            {
                DistanceConverter converter = new DistanceConverter();
                converter.Run();
            }
            else if (choice == 2)
            {
                BMI calculator = new App02.BMI();
                calculator.Run();
            }
            else if (choice == 3)
            {
               StudentMarks grader = new StudentMarks();
               grader.Run();
            }

        }
    }
}
