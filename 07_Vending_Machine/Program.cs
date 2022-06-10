using System;

namespace _07_Vending_Machine
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string inPut = string.Empty;
            double money = 0;
            while (true)
            {
                inPut = Console.ReadLine();
                if (inPut == "Start")
                {
                    break;
                }
                double currency = double.Parse(inPut);
                if (currency == 0.1 || currency == 0.2 || currency == 0.5 || currency == 1 || currency == 2)
                {
                    money += currency;
                }
                else
                {
                    Console.WriteLine($"Cannot accept {currency}");
                }
            }
            string product = string.Empty;
            while (true)
            {
                product = Console.ReadLine();

                if (product == "End")
                {
                    Console.WriteLine($"Change: {money:f2}");
                    break;
                }

                if (product == "Nuts")
                {
                    if (money - 2 >= 0)
                    {
                        Console.WriteLine($"Purchased nuts");
                        money -= 2;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, not enough money");
                    }
                }
                else if (product == "Water")
                {
                    if (money - 0.7 >= 0)
                    {
                        Console.WriteLine($"Purchased water");
                        money -= 0.7;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, not enough money");
                    }
                }
                else if (product == "Crisps")
                {
                    if (money - 1.5 >= 0)
                    {
                        Console.WriteLine($"Purchased crisps");
                        money -= 1.5;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, not enough money");
                    }
                }
                else if (product == "Soda")
                {
                    if (money - 0.8 >= 0)
                    {
                        Console.WriteLine($"Purchased soda");
                        money -= 0.8;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, not enough money");
                    }
                }
                else if (product == "Coke")
                {
                    if (money - 1 >= 0)
                    {
                        Console.WriteLine($"Purchased coke");
                        money -= 1;
                    }
                    else
                    {
                        Console.WriteLine($"Sorry, not enough money");
                    }
                }
                else
                {
                    Console.WriteLine("Invalid product");
                }

            }

        }
    }
}
