using SmartHome_dki_es.Zimmer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome_dki_es.Aktoren
{
    internal class Jalousiesteuerung : ZimmerDecorator

    { 
       
        public void VerarbeiteWetterdaten(Wetterdaten wetterdaten, bool personImZimmer)
        {
        // Regel: Senke die Jalousie, wenn Aussentemperatur höher als vorgegebene Zimmertemperatur und keine Person im Zimmer
        if (wetterdaten.Aussentemperatur > VorgegebeneTemperatur && !personImZimmer)
        {
            Console.WriteLine($"Jalousie wird heruntergefahren - zu warm.");
        }
        else
        {
            Console.WriteLine($"Jalousie bleibt in Position - angenehme Temperatur oder Person im Zimmer.");
        }
        }

        public void VerarbeiteWetterdaten(double aussenTemperatur, double windgeschwindigkeit, bool personImZimmer)
        {
            throw new NotImplementedException();
        }
    }
}