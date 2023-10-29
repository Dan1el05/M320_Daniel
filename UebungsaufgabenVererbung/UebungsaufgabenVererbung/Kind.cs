using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace UebungsaufgabenVererbung
{
    internal class Kind : Person
    {
        public int Alter { get; set; }

        public Kind(string name, string vorname, int iDnumber, string key, int alter) : base(vorname, name, iDnumber, key)
        { Alter = Alter; }
        public override void Esse()
        {
            Console.WriteLine("Ich als Kind {0} {1} esse", Name, Vorname );
        }
        public override void Trage()
        {
            Console.WriteLine("Ich als Kind {0} {1} trage Windeln.", Vorname, Name);
        }
    }
}
