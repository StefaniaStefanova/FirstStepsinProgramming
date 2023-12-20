namespace Pet_Shop
    {
        internal class Program
        {
            static void Main(string[] args)
            {
                double dogFood = double.Parse(Console.ReadLine());
                int catFood = int.Parse(Console.ReadLine());
                double priceA = dogFood * 2.5;
                int priceB = catFood * 4;
                double price = priceA + priceB;
                Console.WriteLine($"{price} lv.");




            }
        }
    }
}
    }
}