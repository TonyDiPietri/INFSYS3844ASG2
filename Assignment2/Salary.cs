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
            //gross = rate * hours;
            int index;
            //Scanner sc = new Scanner(System.in);
            Console.WriteLine("1) Staff or 2) Executive?");

            index = Convert.ToInt32(Console.ReadLine());

            if (index == 1)
            {
                gross = 50000;
            }
            else if (index == 2)
            {
                gross = 100000;
            }
            else Console.WriteLine("Invalid input.");
            //Prompt for Staff or Executive
            //Set Gross salary to $50,000 for staff and $100,000 for executives
        }

    }
}
