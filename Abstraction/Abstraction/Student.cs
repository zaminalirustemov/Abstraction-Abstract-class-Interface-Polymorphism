using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User__Student__Group
{
    internal class Student
    {
        public Student(string fullname, double point)
        {
            count++;
            this.Id = count;
            this.FullName = fullname;
            this.Point = point;
        }

        private static int count;
        public int Id { get; set; }
        public string FullName { get; set; }
        public double Point { get; set; }
        public void StudentInfo()
        {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine($"ID:{Id}   Fullname:{FullName}        Point:{Point}");
            Console.ResetColor();
        }
    }
}