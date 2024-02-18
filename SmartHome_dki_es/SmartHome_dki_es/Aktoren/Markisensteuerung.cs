using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome_dki_es.Aktoren
{
    class MarkisenSteuerungDecorator : IAktorSteuerung
    {
        private string zimmerName;
        private double VorgegebeneTemperatur;

        public MarkisenSteuerungDecorator(string zimmerName)
        {
            this.zimmerName = zimmerName;
        }

        public object Name { get; private set; }

        /// <summary>
        /// Mit Steuere MarkisenSteuerung regeln
        /// </summary>
        /// <param name="aussenTemperatur"></param>
        /// <param name="windgeschwindigkeit"></param>
        /// <param name="personImZimmer"></param>
        public void Steuere(double aussenTemperatur, double windgeschwindigkeit, bool personImZimmer)
        {
            if (aussenTemperatur > VorgegebeneTemperatur && windgeschwindigkeit <= 30)
            {
                Console.WriteLine($"Markise in {zimmerName} wird ausgefahren - zu warm und wenig Wind.");
            }
            else
            {
                Console.WriteLine($"Markise in {zimmerName} bleibt eingefahren - angenehme Temperatur oder zu windig.");
            }
        }
        
        public void VerarbeiteWetterdaten(double aussenTemperatur, double windgeschwindigkeit)
        {
        // Regel: Fahre die Markise aus, wenn Aussentemperatur höher als vorgegebene Zimmertemperatur und Windgeschwindigkeit unter 30 km/h
        if (aussenTemperatur > this.VorgegebeneTemperatur && windgeschwindigkeit <= 30)
        {
            Console.WriteLine($"Markise in {this.Name} wird ausgefahren - zu warm und wenig Wind.");
        }
        else
        {
            Console.WriteLine($"Markise in {this.Name} bleibt eingefahren - angenehme Temperatur oder zu windig.");
        }
    }

        public void VerarbeiteWetterdaten(double aussenTemperatur, double windgeschwindigkeit, bool personImZimmer)
        {
            throw new NotImplementedException();
        }
    }
}
