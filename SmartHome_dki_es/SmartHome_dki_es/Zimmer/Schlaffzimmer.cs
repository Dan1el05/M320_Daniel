using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome_dki_es.Zimmer.Zimmer
{
    internal class Schlaffzimmer : Zimmern
    {
        public Schlaffzimmer(string Name, double VorgegebeneTemperatur, bool PersonImZimmer) : base(Name, VorgegebeneTemperatur, PersonImZimmer)
        {
        }

        /// <summary>
        /// Gibt Weckerzeit als DateTime zurück
        /// </summary>
        public DateTime Weckzeit { get; set; }
    }
}
