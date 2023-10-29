using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasserfass
{
    internal class Wasserfass
    {
        private int minimalPegel { get; }
        private int maximalPegel { get; }
        public int fuellstand { get; }
        public int kapizitaet { get; }

        public Wasserfass(int minimalPegel, int maximalpegel, int fuellstand,  int kapizitaet)
        {
            this.minimalPegel = minimalPegel;
            this.maximalPegel = maximalpegel;
            this.fuellstand = fuellstand;
            this.kapizitaet = kapizitaet;
        }
        public void befüllend(int menge, int fuellstand)
        {
            if (menge > 0)
            {
                if (fuellstand + menge <= kapizitaet)
                {
                    fuellstand += menge;
                }
            }
        }

       

        public void entnehmen(int menge, int fuellstand) 
        {
            if (menge > 0)
            {
                if (fuellstand - menge <= kapizitaet)
                {
                    fuellstand -= menge;
                }
            }

        }
        public void entleeren(int fuellstand)
        {
            fuellstand = minimalPegel;
        }


    }
}
