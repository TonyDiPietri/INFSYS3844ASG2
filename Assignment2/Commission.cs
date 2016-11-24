using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    [Serializable]
    public class Commission : Employee
    {
                
        public override void computeGross()
        {
            if (gross == 0.0)
            {
                int itemssold;
                int unitprice;


                Console.WriteLine("Enter the number of units sold by this employee:"); //ask user for number of items sold
                itemssold = Convert.ToInt32(Console.ReadLine());//take in number items sold


                Console.WriteLine("What is the unit price?");//ask for unit price
                unitprice = Convert.ToInt32(Console.ReadLine());//take unit price
                gross = (float)((itemssold * unitprice) * .5);//50% of (multiply "itemssold" sold by unit price)
                Console.WriteLine("Gross pay calculated as: $" + gross);
            }
            else { //do nothing; continue with program 
            }
        }
    }        
}

