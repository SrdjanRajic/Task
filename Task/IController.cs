namespace Task
{
    interface IController
    {
        void Drink(IConsumer consumer, IContainer container);
        void FillContainer(IContainer container, double amount);
    }
}
