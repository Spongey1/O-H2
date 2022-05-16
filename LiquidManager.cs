using System.Threading;
using System;
using System.Collections.Generic;

namespace O_H2
{ // Handles the CoffeeMachine Simulation
    public class LiquidManager : IFilter
    {
        Random rnd = new Random();
        Machine m = new Machine(new List<string> { "Reservoir", "Tube", "Faucet", "Valve", "Power Cord" });
        public bool FilterOn { get; set; }
        public bool isUsed { get; set; }
        public void CoffeeSimulation(Liquid l)
        {
            try
            {
                // Check if the Coffee Machine is ready
                if (FilterOn = true && isUsed == false)
                {
                    WriteSimulation(l);

                    // Random to randomly choose if the "person" remembers to remove the filter or not
                    if (rnd.Next(0, 2) == 0)
                    {
                        Console.WriteLine("Filter removed");
                        FilterOn = false;
                    }
                    else
                    {
                        Console.WriteLine("Filter is used");
                        isUsed = true;
                    }
                }
                else
                {
                    Renew();
                }
            }
            finally
            {
                FilterOn = true;
                isUsed = false;
            }
        }

        public void WriteSimulation(Liquid l)
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("{0} is being made...", l.Name);
            Console.WriteLine("Name: {0}, Liter: {1}", l.Name, l.Liter);
            Console.WriteLine("{0} cups were made", (l.Liter / rnd.NextDouble() * 1).ToString("0.00"));
            Console.WriteLine("-----------------------------------------------------");
        }

        public void Renew()
        {
            Console.WriteLine("Error: Filter is not on or is already used | Solution: Placing new one!");
        }
    }
}