using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UebungsaufgabenVererbung
{
    internal class Lagerist : Person
    {
      
        public double Groesse { get; set; }
        public Lagerist(string name, string vorname, int iDnumber, string key, double groesse) : base(vorname, name, iDnumber, key)
        { Groesse = groesse; }
        public void LagereEin()
        {
            Console.WriteLine("Ich {0} {1} als Lagerist lagere ein.", Vorname, Name);
        }
        public override void Trage()
        {
            Console.WriteLine("Ich als Lagerist {0} {1} trage das Palet.", Vorname, Name);
        }
    }
}
