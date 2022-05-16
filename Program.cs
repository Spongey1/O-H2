using System;

namespace O_H2
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();
            IngredientManager cm = new IngredientManager();

            cm.Simulation(new Ingredients("Coffee", rnd.Next(1, 5), "Coffee Bean", 9));
            cm.Simulation(new Ingredients("Tea", rnd.Next(1, 5), "Tea bag", 5));
        }
    }
}
