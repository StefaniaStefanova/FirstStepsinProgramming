namespace _09._Yard_Greening
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double metres=double.Parse(Console.ReadLine());
            double price = metres * 7.61;
            double promotion = 0.18 * price;
            double finalprice = price - promotion;
            Console.WriteLine($"The final price is: {finalprice} lv.");
            Console.WriteLine($"The discount is: {promotion} lv.");

        }
    }
}