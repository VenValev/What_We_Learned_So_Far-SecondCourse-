using System;

namespace _01_Extra_Sort_Numbers
{
    class Program
    {
        static void Main(string[] args)
        {

            int num1 = int.Parse(Console.ReadLine());
            int num2 = int.Parse(Console.ReadLine());
            int num3 = int.Parse(Console.ReadLine());
            int min = int.MaxValue;
            int max = int.MinValue;
            int mid = 0;
            if (num1 < min) min = num1;
            if (num2 < min) min = num2;
            if (num3 < min) min = num3;
            if (num1 > max) max = num1;
            if (num2 > max) max = num2;
            if (num3 > max) max = num3;
            if (num1 != max && num1 != min) mid = num1;
            if (num2 != max && num2 != min) mid = num2;
            if (num3 != max && num3 != min) mid = num3;
            Console.WriteLine(max);
            Console.WriteLine(mid);
            Console.WriteLine(min);

        }
    }

}
