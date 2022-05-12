namespace O_H2
{
    // Handles the creation of liquid
    public class Liquid
    {
        public string Name { get; set; }
        public double Liter { get; set; }

        public Liquid(string name, double liter)
        {
            Name = name;
            Liter = liter;
        }
    }
}