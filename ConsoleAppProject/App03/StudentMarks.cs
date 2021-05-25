using ConsoleAppProject.Helpers;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;
using ConsoleAppProject;

namespace ConsoleAppProject.App03
{
    public class StudentMarks
    {
        public string [] Students;
        public int[] Marks;

        public const int FIRSTCLASS = 70;
        public const int UPPERSECONDCLASS = 60;
        public const int LOWERSECONDCLASS = 50;
        public const int THIRDCLASS = 40;
        public const int FAIL = 0; 
       
        /// <summary>
        /// 
        /// </summary>
        public void Run()
        {
            ConsoleHelper.OutputHeading("Student Marks");

            InputMarks();
            DisplayStudentData();
            CalculateMinMaxAndMean();
        }
        
        public void InputMarks()
        {
            int mark=0;
            
            Marks = new int[10] ;
            Students = new string[] 
            {
                "John Smith", "John Doe", "Kian Roz", "Yousef Abdullah",
                "Imran Yusuf", "Sajid Sarwar", "Paul Chowdry", "Steve Rodgers",
                "Tony Stark", "Thor Odinson"
            };

            for (int i = 0; i<Students.Length; i++)
            {
                mark = (int)ConsoleHelper.InputNumber(
                    "Please enter a mark for the student " + Students[i] + " > ", 0,100);

                Marks[i] = mark;
            }

            Console.WriteLine("\nYou have successfully added a mark for all the current students \n");
        }

        public Grades CalculateGrade(int Marks)
        {
           if (Marks >= FAIL && Marks <THIRDCLASS)
            {
                return Grades.F;
            }
           else if (Marks >= THIRDCLASS && Marks <LOWERSECONDCLASS)
            {
                return Grades.D;
            }
           else if (Marks >= LOWERSECONDCLASS && Marks <UPPERSECONDCLASS)
            {
                return Grades.C;
            }
           else if (Marks >= UPPERSECONDCLASS && Marks <FIRSTCLASS)
            {
                return Grades.B;
            }
           else
            {
                return Grades.A;
            }
        }

        public void DisplayStudentData()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine("Student name : " + Students[i] +   
                    "\nStudent Mark " + Marks[i] + "\nGrade: " + CalculateGrade(Marks[i])+ "\n");
            }
        }

        public void CalculateMinMaxAndMean()
        {
            int min = Marks[0];
            int max = Marks[0];

            double numCount = 0;
            double mean = 0;

            for (int i =0; i<Marks.Length; i++)
            {
               if (min > Marks [i])
                {
                    min = Marks[i];
                }

                if (max < Marks[i])
                {
                    max = Marks[i];
                }

                mean += Marks[i];
                numCount++;
            }
            Console.WriteLine("The minimum marks are " + min + 
                "\nThe maximum marks are " + max + "\nThe mean marks are "+ mean/numCount);
        }

    }
}
