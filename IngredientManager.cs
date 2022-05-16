using System;
using System.Collections.Generic;

namespace O_H2
{ // Handles the Machine Simulation
    public class IngredientManager : IFilter
    {
        Random rnd = new Random();
        Machine m = new Machine(new List<string> { "Reservoir", "Tube", "Faucet", "Valve", "Power Cord" }); // and more
        public bool FilterOn { get; set; }
        public bool isUsed { get; set; }
        public void Simulation(Ingredients l)
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
                        Console.WriteLine("Randomly picked; Filter removed");
                        FilterOn = false;
                    }
                    else
                    {
                        Console.WriteLine("Randomly picked; Filter is used");
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

        public void WriteSimulation(Ingredients i)
        {
            Console.WriteLine("-----------------------------------------------------");
            Console.WriteLine("{0} is being made...", i.Name);
            Console.WriteLine("{0}({1} ml) was added to {2}", i.PowderName, i.PowderAmount, i.Name);
            Console.WriteLine("Name: {0}, Liter: {1}", i.Name, i.Liter);
            Console.WriteLine("{0} cups were made", (i.Liter / rnd.NextDouble() * 1).ToString("0.00"));
            Console.WriteLine("-----------------------------------------------------");
        }

        public void Renew()
        {
            Console.WriteLine("Error: Filter is not on or is already used | Solution: Placing new one!");
        }
    }
}