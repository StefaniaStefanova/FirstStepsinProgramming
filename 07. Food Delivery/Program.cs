using System;

namespace _07._Food_Delivery
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int chicken = int.Parse(Console.ReadLine());
            int fish = int.Parse(Console.ReadLine());
            int vegetarian = int.Parse(Console.ReadLine());
            double chicken1 = chicken * 10.35;
            double fish1 = fish * 12.40;
            double vegetarian1 = vegetarian * 8.15;
            double price = chicken1 + fish1 + vegetarian1;
            double desert = price * 0.20;
            double price1 = desert + price + 2.50;
            Console.WriteLine(price1);

        }
    }
}
