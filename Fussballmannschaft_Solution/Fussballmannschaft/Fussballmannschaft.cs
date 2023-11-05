namespace Fussballmannschaft
{
    internal class Fussballmannschaft
    {
        Torwart torwart;
        List<Feldspieler> feldspieler;

        public Fussballmannschaft(string name, Torwart torwart, List<Feldspieler> feldspieler) 
        { 
            if(feldspieler.Count() != 10)
            {
                throw new ArgumentException("Eine Mannschaft muss aus 10 Feldspieler bestehen. " +
                    $"Anzahl übergebene Feldspieler: {feldspieler.Count()}");
            }
            Name = name;
            this.torwart = torwart;
            this.feldspieler = feldspieler;
        }

        public string Name { get; private set; }

        public int Spielzug()
        {
            Random rand = new Random();
            torwart.SchussHalten();
            feldspieler[rand.Next(feldspieler.Count)].Dribbeln();
            feldspieler[rand.Next(feldspieler.Count)].AufsTorSchiessen();
            feldspieler[rand.Next(feldspieler.Count)].Graetschen();
            torwart.Abstoss();
            int numberOfGoals = rand.Next(1, 4);
            bool positive = rand.Next(2) == 0 ? false : true;
            return positive ? numberOfGoals : -numberOfGoals;
        }
    }
}
