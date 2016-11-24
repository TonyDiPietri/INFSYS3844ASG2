using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    [Serializable]
    public class Salary : Employee
    {
        public override void computeGross()
        {
            if (gross == 0.0)
            {
                int index;
                //Scanner sc = new Scanner(System.in);
                Console.WriteLine("1) Staff or 2) Executive?");

                index = Convert.ToInt32(Console.ReadLine());

                if (index == 1) { gross = 50000; }
                else if (index == 2) { gross = 100000; }
                else Console.WriteLine("Invalid input.");

                Console.WriteLine("Gross pay calculated as: $" + gross);

            }

            else { //do nothing; continue with program
            }

        }
    }
}
