using SmartHome_dki_es.Zimmer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome_dki_es.Aktoren
{
    class MarkisenSteuerungDecorator : ZimmerDecorator
    {
 
        
        public void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
        // Regel: Fahre die Markise aus, wenn Aussentemperatur höher als vorgegebene Zimmertemperatur und Windgeschwindigkeit unter 30 km/h
        if (wetterdaten.Aussentemperatur > this.VorgegebeneTemperatur && wetterdaten.Windgeschwindigkeit <= 30)
        {
            Console.WriteLine($"Markise in {this.Name} wird ausgefahren - zu warm und wenig Wind.");
        }
        else
        {
            Console.WriteLine($"Markise in {this.Name} bleibt eingefahren - angenehme Temperatur oder zu windig.");
        }
    }

    }
}
