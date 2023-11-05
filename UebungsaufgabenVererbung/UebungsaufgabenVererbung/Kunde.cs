using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UebungsaufgabenVererbung
{
    internal class Kunde : Person
    {
        public double Umsatz {get; set;}

        public Kunde(string name, string vorname, int iDnumber, string key, double umsatz) : base(vorname, name,iDnumber, key) { Umsatz = umsatz)
       

        public void Kaufe()
        {
            Console.WriteLine("Ich als Kunde {0} {1} kaufe bei Lidel ein.", Vorname, Name);
        }
        public override void Trage()
        {
            Console.WriteLine("Ich als Kunde {0} {1} trage den Einkauf.", Vorname, Name);
        }
        public  void Esse() { }
    }
}
