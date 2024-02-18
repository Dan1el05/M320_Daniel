using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome_dki_es.Zimmer
{
    interface IZimmer
    {
        string Name { get; set; }
        double VorgegebeneTemperatur { get; set; }
        bool PersonImZimmer { get; set; }

        void VerarbeiteWetterdaten(double aussenTemperatur, double windgeschwindigkeit);
    }
}
