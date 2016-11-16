using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
   public class Salary:Employee
    {
        public override void computeGross()
        {
            gross = rate * hours;
        }

    }
}
