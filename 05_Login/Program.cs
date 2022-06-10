using System;

namespace _05_Login
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string user_Name = Console.ReadLine();

            string pasword = string.Empty;

            for (int i = user_Name.Length - 1; i >= 0; i--)
            {
                pasword += user_Name[i];
            }
            for (int i = 0; i < 4; i++)
            {
                string inputp = Console.ReadLine();
                if (inputp == pasword)
                {
                    Console.WriteLine($"User {user_Name} logged in.");
                    break;
                }
                else if (i != 3)
                {
                    Console.WriteLine($"Incorrect password. Try again.");
                }
                else
                {
                    Console.WriteLine($"User {user_Name} blocked!");
                }
            }

        }
    }
}
