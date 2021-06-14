using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace ConsoleAppProject.App03
{
    class Student
    {
        string name;
        int Mark;
        char grade;
        int ID;

      public Student (int ID, string name)
        {
            this.ID = ID;
            this.name = name;
        }

        public void SetGrade(char Grade)
        {
            this.grade = Grade;
        }

        public void SetMarks(int Mark)
        {
            this.Mark = Mark;
        }


    }
}
