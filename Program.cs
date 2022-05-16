using System;

namespace O_H2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            LiquidManager cm = new LiquidManager();

            cm.CoffeeSimulation(new Liquid("Coffee", rnd.Next(1, 5)));
            cm.CoffeeSimulation(new Liquid("Tea", rnd.Next(1, 5)));
        }
    }
}
