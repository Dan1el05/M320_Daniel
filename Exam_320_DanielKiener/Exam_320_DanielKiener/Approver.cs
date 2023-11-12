using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_320
{
    public abstract class Approver
    {
        protected Approver successor;

        private ConsoleLogger log = new ConsoleLogger(logger);
        protected ConsoleLogger Logger       {
            get { return Logger; }
            set
            {
               Console.WriteLine("{0} von {1} bearbeitet", purpose, name);
            }
        }

        public string name;

        private  ILogger loge;
        public Approver(ILogger logge)
        {
            this.logge = loge;
        }

            public Approver ()
        {

        }

        public Approver(Approver successor) { }

        public abstract Approver processRequest(Purchase purchase);

    }
}

