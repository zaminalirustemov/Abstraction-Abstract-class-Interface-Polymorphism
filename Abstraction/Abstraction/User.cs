using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace User__Student__Group
{
    internal class User : IAccount
    {
        private static int count;

        private string _email;
        private string _password;

        public User(string email, string password)
        {

            this.Id = count++;
            this.Email = email;
            this.Password = password;
        }


        private int Id { get; set; }
        public string Fullname { get; set; }


        public string Email
        {
            get => _email;
            set
            {
                
                if (string.IsNullOrEmpty(value) == false)
                {
                    _email = value;
                }
                
            }
        }

        public string Password
        {
            get => _password;
            set
            {
                if (PasswordChecker(value))
                {
                    _password = value;
                }
            }
        }

        public bool PasswordChecker(string password)
        {

            if (password.Length >= 8 && HasDigit(password) && HasUpper(password) && HasLower(password))
            {
                return true;
            }
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine("- the password must have at least 8 characters\r\n- the password must contain at least 1 capital letter\r\n- the password must contain at least 1 lowercase letter\r\n- the password must have at least 1 digit");
            Console.ResetColor();
            return false;
        }
        public void ShowInfo()
        {
            Console.WriteLine($"ID: {this.Id} Fullname: {this.Fullname} Email: {this.Email}");
        }

        



        public bool HasDigit(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsDigit(input[i]) == true)
                {
                    return true;
                }
            }
            return false;
        }
        public bool HasUpper(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsUpper(input[i]) == true)
                {
                    return true;
                }
            }
            return false;
        }
        public bool HasLower(string input)
        {
            for (int i = 0; i < input.Length; i++)
            {
                if (char.IsLower(input[i]) == true)
                {
                    return true;
                }
            }
            return false;
        }

    }
}