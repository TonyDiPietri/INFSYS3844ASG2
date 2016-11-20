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
        //commit to work
        public override void computeGross()
        {
            int itemssold;
            int unitprice;
            

            Console.WriteLine("number of units sold"); //ask user for number of items sold
            itemssold = Convert.ToInt32(Console.ReadLine());//take in number items sold

            
            Console.WriteLine("unit price");//ask for unit price
           unitprice = Convert.ToInt32(Console.ReadLine());//take unit price
            gross = (float) ((itemssold * unitprice)*.5) ;//50% of (multiply "itemssold" sold by unit price)

        }
        
    }
}
