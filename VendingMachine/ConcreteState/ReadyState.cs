using System;

namespace VendingMachine.ConcreteState
{
    public class ReadyState : DrinkMachineState
    {
        public DrinkMachine drinkMachine;

        public ReadyState(DrinkMachine drinkMachine)
        {
            this.drinkMachine = drinkMachine;
        }

        public void GetDrinkCan()
        {
            drinkMachine.canCount -= 1;
            if (drinkMachine.canCount <= 0)
            {
                drinkMachine.state = drinkMachine.emptyState;
            }
            Console.WriteLine("Oto zamówiony napój");
        }
    }
}


