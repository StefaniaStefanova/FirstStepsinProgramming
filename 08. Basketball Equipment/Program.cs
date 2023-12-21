using System;

namespace _08._Basketball_Equipment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int cena = int.Parse(Console.ReadLine());
            double kecove = 0.4 * cena;
            double kecove1 = cena - kecove;
            double ekip = 0.2 * kecove1;
            double ekip1 = kecove1 - ekip;
            double topka = 0.25 * ekip1;
            double aksesoari = 0.20 * topka;
            double cena1 = cena + kecove1 + ekip1 + topka + aksesoari;
            Console.WriteLine(cena1);
        }
    }
}
