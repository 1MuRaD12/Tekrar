using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string num;
            string num1;
            string num3;
            bool num2;
            do
            {
                Console.WriteLine("Password");
                num = Console.ReadLine();

            } while (!Admin.ppassword(num));
            do
            {
                Console.WriteLine("Username");
                num1 = Console.ReadLine();

            } while (num1.Length < 6);
            Console.WriteLine("Enter Section");
            num3 = Console.ReadLine();
            Console.WriteLine("Superadmin");
            num2 = Convert.ToBoolean(Console.ReadLine());
            Admin admin = new Admin(num, num1, num2, num3);
            admin.Showinfo();

        }
    }
}