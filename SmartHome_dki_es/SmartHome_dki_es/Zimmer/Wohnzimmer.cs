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
        public RgbColor Ambientebeleuchtung { get; set; }
    }
}
