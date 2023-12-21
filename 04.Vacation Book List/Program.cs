using System;

namespace _04._Vacation_Books_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int pages = int.Parse(Console.ReadLine());
            int pages1hour = int.Parse(Console.ReadLine());
            int days = int.Parse(Console.ReadLine());
            int result = pages / pages1hour;
            int result1 = result / days;
            Console.WriteLine(result1);
        }
    }
}