using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rechteck
{
    internal class Rechteck
    {
        //Feld mit einem typischen zugriffmodifizierer
        private int height;
        private int we;
        //Feld mit für welches dessen Wert nich veerändert werden kann
        private readonly int width;

        // ein Feld, für welches ein Standartwert zugewiesen wird
        private string name = "rectangle";

        //4
        public string Vorname { get; }
        public string Nachname { get; }

        public Rechteck(string vorname, string nachname)
        {
            Vorname = vorname;
            Nachname = nachname;
        }

        //5
        private string titel;

        public string Titel
        {
            get { return titel; }
            set { titel = value; }
        }
        //6
        private string text;

        public string Text
        {
            set
            {
                text = value;
                Console.WriteLine($"Druckvorgang: {text}");
            }
        }


        // 7 eine automatisch interpletierte read-ondly
        public int Diagonal { get; }

        //8
        public Point MindePoint {get; set;}

        //9  nicht möglich
        
        //10
        public int Area => width * height;




    }
}
