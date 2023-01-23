using System;

namespace Task
{
    class Man : IConsumer
    {
        private double thirst;

        public Man(double thirst)
        {
            if (thirst <= 1 && thirst > 0)
            {
                this.thirst = thirst;
            }
            else
            {
                throw new ArgumentOutOfRangeException("Invalid parameter");
            }
        }

        public void Drink(double amount)
        {
            if (thirst >= amount && amount > 0)
            {
                thirst -= amount;
                if (thirst == 0)
                {
                    Console.WriteLine("The man is not thirsty anymore");
                }
                else
                {
                    Console.WriteLine("The man drank {0:0.###}l of liquid and can still drink {1:0.###}l of liquid", amount, thirst);
                }
            }
            else
            {
                throw new ArgumentOutOfRangeException("The specified amount is larger than needed");
            }
        }
    }
}