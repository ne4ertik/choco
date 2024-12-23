namespace ConsoleApp11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int money = Convert.ToInt32(Console.ReadLine());
            int price = Convert.ToInt32(Console.ReadLine());
            int wrap = Convert.ToInt32(Console.ReadLine());

            int vsegochocolate = Chocolatemaximum(money, price, wrap);

            Console.WriteLine($"Максимально возможное количество шоколадок: {Chocolatemaximum}");
        }

        static int Chocolatemaximum(int money, int price, int wrap)
        {

            int chocolates = money / price;
            int wrappers = chocolates;


            while (wrappers >= wrap)
            {

                int newChocolates = wrappers / wrap;
                chocolates += newChocolates;
                wrappers = newChocolates + (wrappers % wrap);
            }

            return chocolates;
        }
    }
    }
}
