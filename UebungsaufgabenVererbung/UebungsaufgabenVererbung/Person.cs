using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UebungsaufgabenVererbung
{
    internal abstract class Person
    {
        public string Name { get; set; }    
        public string Vorname { get; set; }

        protected int IDnumber { get; private set; }
        
        private string Key { get; set; }

        public Person(string name, string vorname, int iDnumber, string key)
        {
            Name = name;
            Vorname = vorname;
            IDnumber = iDnumber;
            Key = key;
        }


        public virtual void Esse()
        {
            Console.WriteLine("Ich {0} {1} esse" ,Vorname ,Name);
        }
        public abstract void Trage();

        
       

    }
}
