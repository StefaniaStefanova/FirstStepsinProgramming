using System;

namespace _06._Repainting
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int nailon = int.Parse(Console.ReadLine());
            int boya = int.Parse(Console.ReadLine());
            int razreditel = int.Parse(Console.ReadLine());
            int chasove = int.Parse(Console.ReadLine());
            double nailon1 = (nailon + 2) * 1.50;
            double procent = boya / 10.00;
            double boya1 = (boya + procent) * 14.50;
            int razreditel1 = razreditel * 5;
            double torbichki = 0.40;
            double cena1 = nailon1 + boya1 + razreditel1 + torbichki;
            double cena2 = (cena1 * 0.3) * chasove;
            Console.WriteLine(cena1 + cena2);




        }
    }
}
