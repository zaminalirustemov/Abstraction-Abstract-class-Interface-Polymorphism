using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime;
using System.Text;
using System.Threading.Tasks;
using static System.Reflection.Metadata.BlobBuilder;

namespace User__Student__Group
{
    internal class Group
    {
        public Group(string groupNo, int studentLimit)
        {
            this.GroupNo = groupNo;
            this.StudentLimit = studentLimit;

        }
        private int _studentLimit;
        private string _groupNo;



        public string GroupNo
        {
            get => _groupNo;
            set
            {
                if (CheckGroupNo(value))
                {
                    _groupNo = value;
                }
            }
        }

        public int StudentLimit
        {
            get => _studentLimit;
            set
            {
                if (CheckGroupLimit(value))
                {
                    _studentLimit = value;
                }
                
            }
        }
        private Student[] Students = new Student[0];

        public bool CheckGroupNo(string groupNo)
        {
            for (int i = 0; i < groupNo.Length; i++)
            {
                if (groupNo.Length == 5 &&char.IsUpper(groupNo[0]) == true && char.IsUpper(groupNo[1]) && true && char.IsDigit(groupNo[2]) == true && char.IsDigit(groupNo[3]) == true && char.IsDigit(groupNo[4]) == true)
                {
                    return true;
                }
                
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("Must start with 2 capital letters and 3 numbers.");
            Console.ResetColor();
            return false;
        }

        public bool CheckGroupLimit(int studentLimit)
        {
            for (int i = 0; i < studentLimit; i++)
            {
                if (studentLimit >= 5 && studentLimit <= 18)
                {
                    return true;
                }
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("The number of students can be between 5-18");
            Console.ResetColor();
            return false;
        }

        public void AddStudent(Student student)
        {
            if (Students.Length < StudentLimit)
            {
                Array.Resize(ref Students, Students.Length + 1);
                Students[Students.Length - 1] = student;
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("There are enough children in the class");
                Console.ResetColor();
            }
        }
        public void AddStudent(ref Student[] studentsArray, Student student)
        {
            Array.Resize(ref studentsArray, studentsArray.Length + 1);
            studentsArray[studentsArray.Length - 1] = student;
        }

        public Student[] GetStudent(int id)
        {
            Student[] filteredstudents = new Student[0];
            for (int i = 0; i < Students.Length; i++)
            {
                if (Students[i].Id == id)
                {
                    AddStudent(ref filteredstudents, Students[i]);
                }
            }
            return filteredstudents;
        }

        public Student[] GetAllStudents()
        {
            return Students;
        }
    }
}