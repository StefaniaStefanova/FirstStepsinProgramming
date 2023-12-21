using System;

namespace _03._Deposit_Calculator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double deposit = double.Parse(Console.ReadLine());
            int months = int.Parse(Console.ReadLine());
            double rate = double.Parse(Console.ReadLine());
            double rate1 = rate / 100;
            double rate2 = deposit * rate1;
            double months1 = rate2 / 12;
            double sum = deposit + months * months1;
            Console.WriteLine(sum);
        }
    }
}
