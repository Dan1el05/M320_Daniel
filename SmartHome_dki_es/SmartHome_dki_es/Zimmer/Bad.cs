using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome_dki_es.Zimmer.Zimmer
{
    internal class Bad : Zimmern
    {
        public Bad(string Name, double VorgegebeneTemperatur, bool PersonImZimmer) : base(Name, VorgegebeneTemperatur, PersonImZimmer)
        {
        }

        /// <summary>
        /// Feuchtigkeit wird zurückgegeben
        /// </summary>
        public int Feuchtigkeit { get; set; }
    }
}