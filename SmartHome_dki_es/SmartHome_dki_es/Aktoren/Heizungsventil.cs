using SmartHome_dki_es.Zimmer;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome_dki_es.Aktoren
{
    internal class Heizungsventil : ZimmerDecorator
    {

        public void VerarbeiteWetterdaten(Wetterdaten wetterdaten)
        {
            if (wetterdaten.Aussentemperatur < VorgegebeneTemperatur)
            {
                Console.WriteLine("Das zimmer wird aufgeheizt");
            }
            else
            {
                Console.WriteLine("Heizung ist ausgeschaltet");
            }
        }

        
    }

}
