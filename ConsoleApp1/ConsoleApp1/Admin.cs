using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    internal class Admin : User
    {
        public bool IsSuperadmin;
        public string Section;

        public Admin(string password, string username, bool issuperadmin, string section) : base(password, username)
        {
            IsSuperadmin = issuperadmin;
            Section = section;
        }
        public void Showinfo()
        {
            Console.WriteLine($"Password:{Password}\nUsername:{Username}\nIsSuperadmin:{IsSuperadmin}\nSection:{Section}");
        }
    }
}
