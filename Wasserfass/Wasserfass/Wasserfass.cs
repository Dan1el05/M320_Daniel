using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasserfass
{
    internal class Wasserfass
    {
        private int MinimalPegel { get; }
        private int MaximalPegel { get; }
        public int Fuellstand { get; private set; }
        public int Kapizitaet { get; }

        public Wasserfass(int minimalPegel, int maximalpegel, int fuellstand,  int kapizitaet)
        {
            this.MinimalPegel = minimalPegel;
            this.MaximalPegel = maximalpegel;
            this.Fuellstand = fuellstand;
            this.Kapizitaet = kapizitaet;
        }
        public void befüllend(int menge)
        {
            if (menge > 0)
            {
                if (Fuellstand + menge <= Kapizitaet)
                {
                    Fuellstand += menge;
                }
            }
        }

       

        public void entnehmen(int menge) 
        {
            if (menge > 0)
            {
                if (Fuellstand - menge <= Kapizitaet)
                {
                    Fuellstand -= menge;
                }
            }

        }
        public void entleeren()
        {
            Fuellstand = MinimalPegel;
        }


    }
}
