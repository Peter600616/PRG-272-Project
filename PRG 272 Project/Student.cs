using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PRG_272_Project
{
    internal class Student
    {
        private int studentID ;
        private string studentName;
        private int age;
        private string course;

        public Student() 
        { 
        
        }

        public Student(int studentID, string studentName, int age, string course)
        {
            this.studentID = studentID;
            this.studentName = studentName;
            this.age = age;
            this.course = course;
        }

        public int StudentID { get => studentID; set => studentID = value; }
        public string StudentName { get => studentName; set => studentName = value; }
        public int Age { get => age; set => age = value; }
        public string Course { get => course; set => course = value; }
    }
}
