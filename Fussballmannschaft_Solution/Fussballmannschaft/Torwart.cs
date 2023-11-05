namespace Fussballmannschaft
{
    internal class Torwart
    {
        public Torwart(string name) { Name = name; }

        public string Name { get; private set; }

        public void SchussHalten()
        {
            Console.WriteLine($"{Name} hält den Schuss vom Gegner!");
        }
        public void Abstoss()
        {
            Console.WriteLine($"{Name} macht einen Abstoss!");
        }
    }
}
