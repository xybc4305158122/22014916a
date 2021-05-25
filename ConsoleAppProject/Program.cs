/*using ConsoleAppProject.App01;
using ConsoleAppProject.App02;*/
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

            StudentMarks grader = new StudentMarks();
            grader.Run();

            /*DistanceConverter converter = new DistanceConverter();
            converter.Run();

            BMI calculator = new App02.BMI();

            calculator.Run();*/

        }
    }
}
