using System;

namespace _05._Supplies_for_School
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pens = int.Parse(Console.ReadLine());
            int markers = int.Parse(Console.ReadLine());
            int preparation = int.Parse(Console.ReadLine());
            int sale = int.Parse(Console.ReadLine());
            double pens1 = pens * 5.80;
            double markers1 = markers * 7.20;
            double preparation1 = preparation * 1.20;
            double price = pens1 + markers1 + preparation1;
            double sale1 = sale / 100.00;
            Console.WriteLine(price - (price * sale1));

        }
    }
}