using VendingMachine.ConcreteState;

namespace VendingMachine
{
    public class DrinkMachine
    {
        public int canCount { get; set; }

        public DrinkMachineState state { get; set; }
        public ReadyState readyState { get; private set; }
        public EmptyState emptyState { get; private set; }
    
        public DrinkMachine(int canCount)
        {
            readyState = new ReadyState(this);
            emptyState = new EmptyState(this);

            this.canCount = canCount;
            if (canCount > 0)
            {
                state = readyState;
            }
            else
            {
                state = emptyState;
            }
        }

        public void GetDrinkCan()
        {
            state.GetDrinkCan();
        }
    }
}


