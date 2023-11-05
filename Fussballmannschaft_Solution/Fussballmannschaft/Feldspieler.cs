namespace Fussballmannschaft
{
    internal class Feldspieler
    {
        public Feldspieler(string name) { Name = name; }

        public string Name { get; private set; }

        public void AufsTorSchiessen()
        {
            Console.WriteLine($"{Name} schiest aufs Tor!");
        }
        public void Graetschen()
        {
            Console.WriteLine($"{Name} macht eine Blutgraetsche!");
        }
        public void Dribbeln()
        {
            Console.WriteLine($"{Name} dribbelt den Gegner schwindlig!");
        }
    }
}
