using System;

namespace Task
{
    class Program
    {
        static void Main(string[] args)
        {

            Man man1 = new Man(0.4);
            Cat cat1 = new Cat(0.06);
            Bottle bottle1 = new Bottle(1.5);
            Bowl bowl1 = new Bowl(0.16);

            Controller controller = new Controller();

            controller.FillContainer(bottle1, 0.3);
            //controller.FillContainer(bowl1, 0.2);

            controller.Drink(man1, bottle1);
            //controller.Drink(cat1, bowl1);

            Console.ReadLine();
        }
    }
}