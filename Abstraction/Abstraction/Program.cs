using System.Drawing;
using System.Net.WebSockets;
using System.Runtime.Intrinsics.X86;
using User__Student__Group;

namespace Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new("Kamil Aslanov", 78);
            Student student2 = new("Anar Dadasov", 75);
            Student student3 = new("Namiq Mikayilov", 51);
            Student student4 = new("Eli Ibrahimov", 92);
            Student student5 = new("Nicat Abdullayev", 86);


            User user = new("xxxxxx", "XXXxxxx0000000");

            string email;
            string fullname;
            string password;

            bool checkx = false;
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(">>>>>>>WELCOME<<<<<<<");
            Console.ResetColor();
            do
            {
                Console.Write("---Enter fullname: ");
                fullname = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(fullname) == false)
                {
                    checkx = true;
                }

            } while (!checkx);

            bool checky = false;
            do
            {
                Console.Write("---Enter e-mail: ");
                email = Console.ReadLine();
                if (string.IsNullOrWhiteSpace(email) == false)
                {
                    checky = true;
                }

            } while (!checky);


            do
            {
                Console.Write("---Enter password: ");
                password = Console.ReadLine();

            } while (!user.PasswordChecker(password));
            user = new(email, password);
            user.Fullname = fullname;


            string choise;
            do
            {
                Console.WriteLine(">>>>>>>Menu<<<<<<<");
                Console.WriteLine("-----1. Show info\r\n-----2. Create new group\n-----0.quit");
                choise = Console.ReadLine();
                switch (choise)
                {
                    case "1":
                        Console.ForegroundColor = ConsoleColor.DarkBlue;

                        user.ShowInfo();
                        Console.ResetColor();
                        break;
                    case "2":
                        string groupNo;
                        int studentLimit;
                        Group group = new("BB100", 17);

                        do
                        {
                            Console.Write("---Enter GroupNo: ");
                            groupNo = Console.ReadLine();

                        } while (!group.CheckGroupNo(groupNo));


                        do
                        {
                            Console.Write("---Enter studentLimit: ");
                            studentLimit = Convert.ToInt32(Console.ReadLine());

                        } while (!group.CheckGroupLimit(studentLimit));




                        group = new(groupNo, studentLimit);


                        group.AddStudent(student1);
                        group.AddStudent(student2);
                        group.AddStudent(student3);
                        group.AddStudent(student4);
                        group.AddStudent(student5);

                        string k;
                        do
                        {
                            Console.WriteLine(">>>>>>>Menu<<<<<<<");
                            Console.WriteLine("-----1. Show all students\r\n-----2. Get student by id\r\n-----3. Add student\r\n-----0. Back");
                            k = Console.ReadLine();
                            switch (k)
                            {
                                case "1":
                                    Console.WriteLine("---All students:");
                                    foreach (Student student in group.GetAllStudents())
                                    {
                                        Console.ForegroundColor = ConsoleColor.DarkBlue;
                                        Console.WriteLine($"ID:{student.Id}   Fullname:{student.FullName}   Point:{student.Point}");
                                        Console.ResetColor();
                                    }
                                    break;
                                case "2":
                                    Console.Write("---Enter ID: ");
                                    int a = Convert.ToInt32(Console.ReadLine());
                                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                                    Console.WriteLine("\nThe student with the ID you entered:");
                                    foreach (Student student in group.GetStudent(a))
                                    {
                                        Console.WriteLine($"ID:{student.Id}\nFullname:{student.FullName}\nPoint:{student.Point}");
                                        Console.ResetColor();
                                    }
                                    break;
                                case "3":
                                    Console.Write("---Enter fullname: ");
                                    string newfullname = Console.ReadLine();

                                    Console.Write("---Student Point: ");
                                    double newpoint = Convert.ToDouble(Console.ReadLine());

                                    Student newstudent = new(newfullname, newpoint);
                                    group.AddStudent(newstudent);
                                    break;
                                default:
                                    break;
                            }

                        } while (k != "0");

                        break;
                    default:
                        break;
                }

            } while (choise != "0");

        }

    }
}