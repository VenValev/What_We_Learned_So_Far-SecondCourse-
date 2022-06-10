using System;

namespace _03_Vacation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int num_of_People = int.Parse(Console.ReadLine());
            string type_of_Group = Console.ReadLine();
            string day_of_Week = Console.ReadLine();
            double price_one_Person = 0;
            double total_Price = 0;
            if (day_of_Week == "Friday")
            {
                if (type_of_Group == "Students")
                {
                    price_one_Person = 8.45;
                }
                else if (type_of_Group == "Business")
                {
                    price_one_Person = 10.90;
                }
                else
                {
                    price_one_Person = 15.0;
                }
            }
            if (day_of_Week == "Saturday")
            {
                if (type_of_Group == "Students")
                {
                    price_one_Person = 9.80;
                }
                else if (type_of_Group == "Business")
                {
                    price_one_Person = 15.60;
                }
                else
                {
                    price_one_Person = 20.00;
                }
            }
            if (day_of_Week == "Sunday")
            {
                if (type_of_Group == "Students")
                {
                    price_one_Person = 10.46;
                }
                else if (type_of_Group == "Business")
                {
                    price_one_Person = 16.00;
                }
                else
                {
                    price_one_Person = 22.50;
                }
            }
            if (type_of_Group == "Students" && num_of_People >= 30)
            {
                total_Price = (num_of_People * price_one_Person) * 0.85;
            }
            else if (type_of_Group == "Business" && num_of_People >= 100)
            {
                total_Price = (num_of_People * price_one_Person) - (10 * price_one_Person);
            }
            else if (type_of_Group == "Regular" && (num_of_People >= 10 && num_of_People <= 20))
            {
                total_Price = (num_of_People * price_one_Person) * 0.95;
            }
            else
            {
                total_Price = num_of_People * price_one_Person;
            }

            Console.WriteLine($"Total price: {total_Price:f2}");
        }
    }
}
