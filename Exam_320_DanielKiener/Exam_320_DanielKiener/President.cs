using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_320
{
    public class President : Approver
    {
        
        public override Approver processRequest(Purchase purchase) 
        {
            if (amount < 1000000)
            {
                return new President();
            }

            
        }
    }
}
