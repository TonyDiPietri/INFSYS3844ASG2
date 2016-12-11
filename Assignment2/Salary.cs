using System;
using System.Collections.Generic;
using System.IO;
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

        public override void displayEmployee()
        {
            computeNetperc();
            //Console.WriteLine("Hours: " + hours);
            Console.WriteLine("Rate: " + taxrate);
            Console.WriteLine("Gross: " + gross);
            Console.WriteLine("Net: " + net);
            Console.WriteLine("Net%: " + net_percent + "%");
            using (System.IO.StreamWriter sw = File.CreateText("SalaryData.txt"))
            {
                //sw.WriteLine("Hours: " + hours);
                sw.WriteLine("Rate: " + taxrate);
                sw.WriteLine("Gross: " + gross);
                sw.WriteLine("Net: " + net);
                sw.WriteLine("Net%: " + net_percent + "%");
            }
        }
    }
}
