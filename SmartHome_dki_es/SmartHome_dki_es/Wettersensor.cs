using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SmartHome_dki_es
{
    class Wettersensor
    {
        private Wetterdaten wetterdaten;

        public Wettersensor(Wetterdaten wetterdaten)
        {
            this.wetterdaten = wetterdaten;
        }

        public void Tick()s
        {
            wetterdaten.SimuliereZeitverlauf(1);
        }
    }
}
