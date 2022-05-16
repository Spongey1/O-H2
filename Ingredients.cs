namespace O_H2
{
    // Creates the content for the Machine
    public class Ingredients
    {
        public string Name { get; set; }
        public double Liter { get; set; }
        public string PowderName { get; set; }
        public double PowderAmount { get; set; }

        public Ingredients(string name, double liter, string powderName, double powderAmount)
        {
            Name = name;
            Liter = liter;
            PowderName = powderName;
            PowderAmount = powderAmount;
        }
    }
}