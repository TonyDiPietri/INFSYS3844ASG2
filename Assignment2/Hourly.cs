using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
   public class Hourly : Employee

    {
       public override void computeGross()
        {
            double numberofhourswork;
            double rateperhour;
            Console.WriteLine("number of hours work"); //ask number of hours worked
            numberofhourswork = Convert.ToInt32(Console.ReadLine()); //take in number of hours work and assign it to "hours"

            Console.WriteLine("ask for rate per hour");// ask for rate per hour
            rateperhour = Convert.ToInt32(Console.ReadLine());  //take in rate per hour

            if (numberofhourswork <= 40)
                {
                    gross = (float)(numberofhourswork* rateperhour);
                }
            else
                {
                    gross = (float)((rateperhour * 40) + ((numberofhourswork - 40) * (rateperhour * 1.5)));
                }


            //ask for overtime hours at one and half
            //take in overtime hours at one and half







            // gross = rate * hours;
        }

    }
}
