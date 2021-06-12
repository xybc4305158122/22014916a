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
        /// <summary>
        /// My constant variables (Magic Numbers)
        /// </summary>
        public const int FIRSTCLASS = 70;
        public const int UPPERSECONDCLASS = 60;
        public const int LOWERSECONDCLASS = 50;
        public const int THIRDCLASS = 40;
        public const int FAIL = 0;

        /// <summary>
        /// My global array variables.
        /// </summary>
        public string[] Students;
        public int[] Marks;
        public Grades[] Grade;

        /// <summary>
        /// The run method consisting of methods and outputs. It also has a restart 
        /// function.
        /// </summary>
        public void Run()
        {
            string restart;
            ConsoleHelper.OutputHeading("Student Marks");

            do
            {
                SelectChoice();

                Console.WriteLine("Would you like to restart the program: Yes/No");
                restart = Console.ReadLine().ToLower();
            }
            while (restart == "yes");
            {
                Console.WriteLine("Thank You for using the Student Marks :");
            }
        }

        /// <summary>
        /// The select choice method for the user to select what they want to do
        /// </summary>
        public void SelectChoice()
        {

            string [] choices = { "1. Input Marks", "2. Show Grade Profile" };

            int choice = ConsoleHelper.SelectChoice(choices);

            if (choice == 1)
            {
                InputMarks();
            }
            else if (choice == 2)
            {
                DisplayStudentData();  
            }

            Console.WriteLine("Would You like to see the Grade Profile : Yes/No ");
            string choice2 = Console.ReadLine().ToLower();

            if (choice2 == "yes")
            {
                DisplayStudentData();
            }
        }
        
        /// <summary>
        /// This method takes in marks inserted by the user for each of 
        /// the following students in the array.
        /// </summary>
        public void InputMarks()
        {
            int mark=0;
            
            Students = new string[] 
            {
                "John Smith", "John Doe", "Kian Roz", "Yousef Abdullah",
                "Imran Yusuf", "Sajid Sarwar", "Paul Chowdry", "Steve Rodgers",
                "Tony Stark", "Thor Odinson"
            };

            Marks = new int[Students.Length];
            Grade = new Grades[Students.Length];

            for (int i = 0; i<Marks.Length; i++)
            {
                mark = (int)ConsoleHelper.InputNumber(
                    "Please enter a mark for the student " + Students[i] + " > ", 0,100);

                Marks[i] = mark;
            }

            Console.WriteLine("\nYou have successfully added a mark for all the current students \n");
        }

        /// <summary>
        /// This method calculates the grades of the 
        /// </summary>
        /// <param name="Marks"></param>
        /// <returns></returns>
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

        /// <summary>
        /// My display method that will show the student data 
        /// (names & marks)
        /// </summary>
        public void DisplayStudentData()
        {
            for (int i = 0; i < Students.Length; i++)
            {
                Console.WriteLine("Student name : " + Students[i] +   
                    "\nStudent Mark " + Marks[i] + "\nGrade: " + CalculateGrade(Marks[i])+ "\n");
            }
        }

        /// <summary>
        /// The method to calculate the mean of the
        /// total marks.
        /// </summary>
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

        /// <summary>
        /// This method shows the GradeProfile of the of the marks and assigns
        /// a counter for what each student got.
        /// students.
        /// </summary>
        public void CalculateGradeProfile()
        {
            int counterA = 0, counterB = 0, counterC = 0, counterD = 0, counterF = 0;

            ConsoleHelper.OutputTitle("Grade Profile");

            for (int i =0; i<Grade.Length; i++)
            {
                Grade[i] = CalculateGrade(Marks[i]);
            }

            for (int i = 0; i<Grade.Length; i++)
            {
                if (Grade[i] == Grades.A)
                {
                    counterA++;
                }

                if (Grade[i] == Grades.B)
                {
                    counterB++;
                }

                if (Grade[i] == Grades.C)
                {
                    counterC++;
                }

                if (Grade[i] == Grades.D)
                {
                    counterD++;
                }

                if (Grade[i] == Grades.F)
                {
                    counterF++;
                }
            }
            DisplayPercentage("A", counterA);
            DisplayPercentage("B", counterB);
            DisplayPercentage("C", counterC);
            DisplayPercentage("D", counterD);
            DisplayPercentage("F", counterF);
        }

        /// <summary>
        /// The method calculates the percentage of the marks people were given
        /// based on the grade counter.
        /// </summary>
        /// <param name="GradeCounter"></param>
        /// <returns></returns>
        public double CalculatePercentage(int GradeCounter)
        {
            return (GradeCounter * 100) / (Students.Length);
        }

        /// <summary>
        /// The Display percentage to show the user what percentage of what marks
        /// the student had gotten.
        /// </summary>
        /// <param name="grade"></param>
        /// <param name="GradeCounter"></param>
        public void DisplayPercentage(string grade, int GradeCounter)
        {
            Console.WriteLine($"The percentage of students with grade {grade} : > " + CalculatePercentage(GradeCounter) + "%"); ;
        }
    }
}
