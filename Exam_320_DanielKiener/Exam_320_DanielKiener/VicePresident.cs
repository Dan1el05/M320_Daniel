using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exam_320
{
    public class VicePresident : Approver
    {
        
        
            public override Approver processRequest(Purchase purchase) 
        { 

            if (purchase < 25000)
            {
                return new VicePresident();
            }
        }
    }
}
