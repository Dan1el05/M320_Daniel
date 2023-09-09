using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aufgabe06
{
    internal class Person
    {
        private string name;
        private int WutMeter;
    }

    public void Provozieren()
    {
       WutMeter++;
    }

    public int herunterFahren()
    {
        WutMeter--;
    }
}
