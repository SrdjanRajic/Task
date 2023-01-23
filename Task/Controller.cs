namespace Task
{
    class Controller : IController
    {
        public void Drink(IConsumer consumer, IContainer container)
        {
            consumer.Drink(container.CheckLiquidAmount());
        }

        public void FillContainer(IContainer container, double amount)
        {
            container.FillContainer(amount);
        }
    }
}
