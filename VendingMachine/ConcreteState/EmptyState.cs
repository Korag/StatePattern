using System;

namespace VendingMachine.ConcreteState
{
    public class EmptyState : DrinkMachineState
    {
        public DrinkMachine drinkMachine;

        public EmptyState(DrinkMachine drinkMachine)
        {
            this.drinkMachine = drinkMachine;
        }

        public void GetDrinkCan()
        {
            Console.WriteLine("Asortyment wyczerpany. Twoje pieniądze przepadły.");
        }
    }
}


