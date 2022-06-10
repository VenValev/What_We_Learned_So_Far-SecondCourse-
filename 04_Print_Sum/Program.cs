using System;

namespace _04_Print_Sum
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int start_Seq = int.Parse(Console.ReadLine());
            int end_Seq = int.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = start_Seq; i <= end_Seq; i++)
            {
                Console.Write($"{i} ");
                sum += i;
            }
            Console.WriteLine();
            Console.WriteLine($"Sum: {sum}");

        }
    }
}
