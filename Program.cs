using System;

namespace sixthTask
{
    class Program
    {
        static void Main(string[] args)
        {
            int goldBalance;
            int countCrystalsToBuy;
            int crystalPrice = 67;

            Console.Write("Укажите ваш баланс золотых монет:\t");
            goldBalance = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Вам отправлено предложение о покупке кристаллов");
            Console.WriteLine("Цена за кристалл {0} золотых", crystalPrice);
            Console.Write("Кристаллов к покупке:\t");

            countCrystalsToBuy = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Кристаллов куплено: {0}", countCrystalsToBuy);

            goldBalance -= (countCrystalsToBuy * crystalPrice);
            Console.WriteLine("Ваш остаток золотых: {0}", goldBalance);
        }
    }
}
