namespace SmartHome_dki_es.Zimmer
{
    class Zimmern : IZimmer
    {
        public string Name { get; set; }
        public double VorgegebeneTemperatur { get; set; }
        public bool PersonImZimmer { get; set; }

        public virtual void VerarbeiteWetterdaten(double aussenTemperatur, double windgeschwindigkeit)
        {
            Console.WriteLine($"Zimmer - {Name}, VorgegebeneTemperatur: {VorgegebeneTemperatur}°C, Person im Zimmer: {PersonImZimmer}");
        }
    }
}
