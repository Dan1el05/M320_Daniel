using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome_dki_es
{
    internal class Wetterdaten
    {
        private double aktuelleTemperatur;

        public double AktuelleTemperatur
        {
            get { return aktuelleTemperatur; }
            private set { aktuelleTemperatur = value; }
        }

        public void SimuliereZeitverlauf(int sekunden)
        {
            // Simuliere realistischen Temperaturverlauf über die Zeit
            Random random = new Random();
            double temperaturSchwankung = random.NextDouble() * 2 - 1; // Zufällige Schwankung zwischen -1 und 1
            AktuelleTemperatur += temperaturSchwankung;

            Console.WriteLine($"Aktuelle Temperatur: {AktuelleTemperatur}°C");

            Thread.Sleep(sekunden * 1000); // Simulation von sekunden Sekunden
        }
    }
}
