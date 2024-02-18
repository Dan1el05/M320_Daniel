using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome_dki_es.Zimmer.Zimmer
{
    internal class Wohnzimmer : Zimmern
    {
        public Wohnzimmer(string Name, double VorgegebeneTemperatur, bool PersonImZimmer) : base(Name, VorgegebeneTemperatur, PersonImZimmer)
        {
        }

        /// <summary>
        /// Gibt Farbe als Ambinebeleuchtung zurück
        /// </summary>
        public int AmbientebeleuchtungR { get; set; }
        public int AmbientebeleuchtungG { get; set; }
        public int AmbientebeleuchtungB { get; set; }
    }
}
