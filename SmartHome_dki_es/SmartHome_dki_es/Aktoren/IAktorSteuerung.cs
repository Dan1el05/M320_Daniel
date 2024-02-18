using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome_dki_es.Aktoren
{
    internal interface IAktorSteuerung
    {
        /// <summary>
        ///
        /// </summary>
        /// <param name="aussenTemperatur"></param>
        /// <param name="windgeschwindigkeit"></param>
        /// <param name="personImZimmer"></param>
        void VerarbeiteWetterdaten(double aussenTemperatur, double windgeschwindigkeit, bool personImZimmer);
    }

}
