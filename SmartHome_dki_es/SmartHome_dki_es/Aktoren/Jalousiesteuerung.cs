using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome_dki_es.Aktoren
{
    internal class Jalousiesteuerung : IAktorSteuerung

    {
        private readonly double VorgegebeneTemperatur;
        private string zimmerName;

        public Jalousiesteuerung(string zimmerName)
        {
            this.zimmerName = zimmerName;
        }

        public object Name { get; private set; }

        public void Steuere(double aussenTemperatur, double windgeschwindigkeit, bool personImZimmer)
        {
            if (aussenTemperatur > VorgegebeneTemperatur && !personImZimmer)
            {
                Console.WriteLine($"Jalousie in {zimmerName} wird heruntergefahren - zu warm.");
            }
            else
            {
                Console.WriteLine($"Jalousie in {zimmerName} bleibt in Position - angenehme Temperatur oder Person im Zimmer.");
            }
        }
        public void VerarbeiteWetterdaten(double aussenTemperatur, bool personImZimmer)
        {
        // Regel: Senke die Jalousie, wenn Aussentemperatur höher als vorgegebene Zimmertemperatur und keine Person im Zimmer
        if (aussenTemperatur > this.VorgegebeneTemperatur && !personImZimmer)
        {
            Console.WriteLine($"Jalousie in {this.Name} wird heruntergefahren - zu warm.");
        }
        else
        {
            Console.WriteLine($"Jalousie in {this.Name} bleibt in Position - angenehme Temperatur oder Person im Zimmer.");
        }
        }

        public void VerarbeiteWetterdaten(double aussenTemperatur, double windgeschwindigkeit, bool personImZimmer)
        {
            throw new NotImplementedException();
        }
    }
}