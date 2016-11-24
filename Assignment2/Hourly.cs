using System;
using System.Collections.Generic;
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

    }
}
