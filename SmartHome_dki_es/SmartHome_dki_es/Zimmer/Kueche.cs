using SmartHome_dki_es.Aktoren;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace SmartHome_dki_es.Zimmer.Zimmer
{
    internal class Kueche : Zimmern
    {
        public Kueche(string Name, double VorgegebeneTemperatur, bool PersonImZimmer) : base(Name, VorgegebeneTemperatur, PersonImZimmer)
        {
        }


        /// <summary>
        /// Gibt den Status des Herds in der Küche zurück oder legt diesen fest.
        /// </summary>
        public KochherdStatus Kochherd { get; set; }
    }

}
    