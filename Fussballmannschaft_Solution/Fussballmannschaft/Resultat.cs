using System.Xml.Linq;

namespace Fussballmannschaft
{
    internal class Resultat
    {
        private readonly int toreA, toreB;

        public Resultat(int a, int b) { toreA = a; toreB = b; }

        public override string ToString()
        {
            return $"{toreA} : {toreB}";
        }
    }
}
