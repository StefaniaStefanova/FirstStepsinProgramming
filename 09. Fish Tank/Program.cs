using System;

namespace _09._Fish_Tank
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int duljina = int.Parse(Console.ReadLine());
            int shirochina = int.Parse(Console.ReadLine());
            int visochina = int.Parse(Console.ReadLine());
            double procent = double.Parse(Console.ReadLine());
            int obem = duljina * shirochina * visochina;
            double litri = obem * 0.001;
            double prostranstvo = procent / 100.00;
            double otgovor = litri * (1.00 - prostranstvo);
            Console.WriteLine(otgovor);
        }
    }
}
