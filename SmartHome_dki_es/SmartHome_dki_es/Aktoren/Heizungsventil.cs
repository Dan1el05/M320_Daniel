using SmartHome_dki_es.Zimmer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome_dki_es.Aktoren
{
    internal class Heizungsventil : IAktorSteuerung
    {
        /// <summary>
        /// Heizungsventil öffenen wenn Bedingung erfüllt
        /// </summary>
        private readonly double VorgegebeneTemperatur;
        private string zimmerName;

        public Heizungsventil(string zimmerName)
        {
            this.zimmerName = zimmerName;
        }

        public object Name { get; private set; }

        public void VerarbeiteWetterdaten(double aussenTemperatur, double windgeschwindigkeit, bool personImZimmer)
        {
            if (aussenTemperatur < VorgegebeneTemperatur)
            {
                Console.WriteLine($"Heizungsventil in {zimmerName} - wird geheizt.");
            }
            else
            {
                Console.WriteLine($"Heizungsventil in {zimmerName} - ausgeschaltet.");
            }
        }

        public void VerarbeiteWetterdaten(double aussenTemperatur, bool personImZimmer)
        {
        // Regel: Öffne das Heizungsventil, wenn Aussentemperatur niedriger als vorgegebene Zimmertemperatur und keine Person im Zimmer
        if (aussenTemperatur < this.VorgegebeneTemperatur && !personImZimmer)
        {
            Console.WriteLine($"Heizungsventil in {this.Name} geöffnet - wird geheizt.");
        }
        else
        {
            Console.WriteLine($"Heizungsventil in {this.Name} geschlossen - es ist warm genug.");
        }
        }
    }

}
