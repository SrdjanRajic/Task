using System;

namespace Task
{
    class Bowl : IContainer
    {
        private double volume;
        private double liquidAmount;

        public Bowl(double volume)
        {
            this.volume = volume;
            liquidAmount = 0;
        }

        public double CheckLiquidAmount()
        {
            return liquidAmount;
        }

        public void FillContainer(double amount)
        {
            if (amount <= volume && amount >= 0 && (amount + liquidAmount) <= volume)
            {
                liquidAmount = amount;
                Console.WriteLine("Container has been filled with {0}l of liquid", amount);
            }
            else
            {
                throw new ArgumentOutOfRangeException("There is no room for that much liquid");
            }
        }
    }
}
