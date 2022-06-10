using System;

namespace _09_Padawan_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {

            double amountOfMoney = double.Parse(Console.ReadLine());
            int numberOfStudents = int.Parse(Console.ReadLine());
            double priceOfLighSabre1 = double.Parse(Console.ReadLine());
            double priceOfRobe1 = double.Parse(Console.ReadLine());
            double priceOfBelt1 = double.Parse(Console.ReadLine());
            double br_lightSabre = numberOfStudents + Math.Ceiling((double)numberOfStudents / 10);
            double br_belt = numberOfStudents - (numberOfStudents / 6);
            //Console.WriteLine(br_lightSabre);
            //Console.WriteLine(br_belt);
            //Console.WriteLine(priceOfLighSabre1 * br_lightSabre + priceOfBelt1 * br_belt + numberOfStudents * priceOfRobe1);
            double sum = priceOfLighSabre1 * br_lightSabre + priceOfBelt1 * br_belt + numberOfStudents * priceOfRobe1;
            if (amountOfMoney >= sum)
            {
                Console.WriteLine($"The money is enough - it would cost {sum:f2}lv.");
            }
            else
            {
                Console.WriteLine($"John will need {sum - amountOfMoney:f2}lv more.");
            }

        }
    }
}
