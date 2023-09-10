using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Wasserfall
{
    internal class Wasserfass
    {
        private int minimalPegel { get; }
        private int maximalPegel { get; }
        public int füllstand { get; }
        public int kapizität { get; }

        private string name;

        private int wasserStand = 10;

       private int befüllen (int menge)

        {
           menge = wasserStand + 1;
            return menge;
        }
        public int entnehmen(int menge)
        {
            menge = wasserStand - 1;
            return menge;

        }

        public int entleeren(int menge) 
        { 
            menge = 0;
            return menge;
        }
    }
}
