using System;

namespace _06_Strong_Number
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string number_input = Console.ReadLine();
            int number = int.Parse(number_input);
            int sum = 0;
            for (int i = 0; i < number_input.Length; i++)
            {
                int fac = 1;
                int digit = int.Parse(number_input[i].ToString());
                while (digit > 0)
                {
                    fac = fac * digit;
                    digit--;
                }
                sum += fac;
            }
            //Console.WriteLine(sum);
            if (sum == number)
            {
                Console.WriteLine("yes");
            }
            else
            {
                Console.WriteLine("no");
            }

        }
    }
}
