using System;

namespace _11_Orders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numberOfOrders = int.Parse(Console.ReadLine());
            double totalSum = 0;
            while (numberOfOrders > 0)
            {
                double priceCapsule = double.Parse(Console.ReadLine());
                int days = int.Parse(Console.ReadLine());
                int brCapsule = int.Parse(Console.ReadLine());
                double sum = priceCapsule * days * brCapsule;
                Console.WriteLine($"The price for the coffee is: ${sum:f2}");
                totalSum += sum;
                numberOfOrders--;
            }
            Console.WriteLine($"Total: ${totalSum:f2}");

        }
    }
}
