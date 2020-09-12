using System;

namespace VendingMachine
{
    class Program
    {
        static void Main(string[] args)
        {
            DrinkMachine drinkMachine = new DrinkMachine(10);

            for (int i = 0; i < 15; i++)
            {
                drinkMachine.GetDrinkCan();
            }

            Console.ReadLine();
        }
    }
}

