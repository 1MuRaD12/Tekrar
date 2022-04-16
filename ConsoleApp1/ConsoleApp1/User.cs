using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class User
    {
        private string _username;
        private static string _password;


        public User(string password, string username)
        {
            Password = password;
            Username = username;
        }
        public  string Password
        {
            get => _password;
            set
            {
                if (ppassword(value))
                {
                    _password = value;
                }
            }
        }

        public string Username
        {
            get => _username;
            set
            {
                if (value.Length > 6)
                {
                    _username = value;
                }
            }
        }

        public static bool ppassword(string num)
        {

            bool HasUpper = false;
            bool HasLower = false;
            bool HasDigit = false;
            if (num.Length > 8)
            {
                foreach (var item in num)
                {
                    if (char.IsUpper(item))
                    {
                        HasUpper = true;
                        continue;
                    }
                    if (char.IsLower(item))
                    {
                        HasLower = true;
                        continue;
                    }
                    if (char.IsDigit(item))
                    {
                        HasDigit = true;
                        continue;
                    }
                    

                }
                bool resault = HasDigit && HasLower && HasUpper;
                return resault;
            }
           

            return false;

        }
        
    }
}
