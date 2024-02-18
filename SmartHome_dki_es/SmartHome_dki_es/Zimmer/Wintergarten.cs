using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome_dki_es.Zimmer.Zimmer
{
    internal class Wintergarten : Zimmern
    {
        public Wintergarten(string Name, double VorgegebeneTemperatur, bool PersonImZimmer) : base(Name, VorgegebeneTemperatur, PersonImZimmer)
        {
        }

        /// <summary>
        /// Gibt Sonneneinstrahlung in Lux zurück
        /// </summary>
        public double Sonneneinstrahlung { get; set; }
    }
}
