using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_320
{
    public class Purchase
    {
        private int id;
        private static int lastID;
        public string purpose;
        public int Quantiity  { get; private set; }

        public double  Amout { get; private set; }

        public float TaxReat { get; private set; }

        public double TotalAmoutNet { get; private set; }
        public double TotalAmoutGros { get; private set; }


        public Purchase(int quantity, double amout, float taxreat)
        {
            this.Quantiity = quantity;
            this.Amout = amout; 
            this.TaxReat = taxreat;
            TotalAmoutNet = quantity * amout;
            TotalAmoutGros = TotalAmoutGros * taxreat;


        }






    }
}
