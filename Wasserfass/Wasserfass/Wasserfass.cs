using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wasserfass
{
    public class Wasserfass
    {
        private int MinimalPegel { get; }
        private int MaximalPegel { get; }
        public int Fuellstand { get; private set; }
        public int Kapizitaet { get; }

        public Wasserfass( int fuellstand,  int kapizitaet)
        {
            MinimalPegel = 0;
            MaximalPegel = kapizitaet;
            this.Fuellstand = fuellstand;
            this.Kapizitaet = kapizitaet;
        }
        public int befüllend(int menge)
        {
            if (menge > 0)
            {
                if (Fuellstand + menge <= Kapizitaet)
                {
                    Fuellstand += menge;
                    return Fuellstand;

                }
            }
            return 0;
        }

       

        public int entnehmen(int menge) 
        {
            if (menge > 0)
            {
                if (Fuellstand - menge <= Kapizitaet)
                {
                    Fuellstand -= menge;
                    return Fuellstand;
                }
            }
            return 0;

        }
        public int entleeren()
        {
            Fuellstand = MinimalPegel;
            return Fuellstand;
        }


    }
}
