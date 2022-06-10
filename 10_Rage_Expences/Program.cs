using System;

namespace _10_Rage_Expences
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int lostGame = int.Parse(Console.ReadLine());
            double headsetPrice = double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int brHeadset = lostGame / 2;
            int brMouse = lostGame / 3;
            int brKeyboard = lostGame / 6;
            int brDisplay = lostGame / 12;

            double sum = brHeadset * headsetPrice + brMouse * mousePrice + brKeyboard * keyboardPrice + brDisplay * displayPrice;
            Console.WriteLine($"Rage expenses: {sum:f2} lv.");

        }
    }
}
