namespace SmartHome_dki_es.Zimmer
{
    internal class Zimmern : IZimmer
    {
        /// <summary>
        /// Ist die Klasse für die verschiedenen Zimmer
        /// </summary>
        /// 
        public Zimmern(string Name, double VorgegebeneTemperatur, bool PersonImZimmer) 
        {
            this.Name = Name;
            this.VorgegebeneTemperatur = VorgegebeneTemperatur;
            this.PersonImZimmer = PersonImZimmer;
        }
        public string Name { get; set; }
        public double VorgegebeneTemperatur { get; set; }
        public bool PersonImZimmer { get; set; }

        public virtual void VerarbeiteWetterdaten(double aussenTemperatur, double windgeschwindigkeit)
        {
            Console.WriteLine($"Zimmer - {Name}, VorgegebeneTemperatur: {VorgegebeneTemperatur}°C, Person im Zimmer: {PersonImZimmer}");
        }
    }
}
