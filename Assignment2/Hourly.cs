using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    [Serializable]
    public class Hourly : Employee

    {
       public override void computeGross()
        {
            if (gross == 0.0)
            {
                double numberofhoursworked;
                double rateperhour;
                Console.WriteLine("Please enter your number of hours worked:"); //ask number of hours worked
                numberofhoursworked = Convert.ToInt32(Console.ReadLine()); //take in number of hours work and assign it to "hours"

                Console.WriteLine("What is your hourly rate of pay?");// ask for rate per hour
                rateperhour = Convert.ToInt32(Console.ReadLine());  //take in rate per hour
                hours = (float) numberofhoursworked;

                if (numberofhoursworked <= 40)
                {
                    gross = (float)(numberofhoursworked * rateperhour);
                }
                else
                {
                    gross = (float)((rateperhour * 40) + ((numberofhoursworked - 40) * (rateperhour * 1.5)));
                }

                Console.WriteLine("Gross pay calculated as: $" + gross);
            }
            else
            {
                //do nothing
            }
            
            //ask for overtime hours at one and half
            //take in overtime hours at one and half
            // gross = rate * hours;
        }

        public override void displayEmployee()
        {
            computeNetperc();
            Console.WriteLine("Hours: " + hours);            
            Console.WriteLine("Rate: " + taxrate);
            Console.WriteLine("Gross: " + gross);
            Console.WriteLine("Net: " + net);
            Console.WriteLine("Net%: " + net_percent + "%");
            using (System.IO.StreamWriter sw = File.CreateText("HourlyData.txt"))
            {
                sw.WriteLine("Hours: " + hours);
                sw.WriteLine("Rate: " + taxrate);
                sw.WriteLine("Gross: " + gross);
                sw.WriteLine("Net: " + net);
                sw.WriteLine("Net%: " + net_percent + "%");
            }
        }

    }
}
