using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment2
{
    [Serializable]
    public class Employee
    {
        //TODO: Set up method calls and if statements for computeGross, tax, netperc

        /*********************
             Attributes
        *********************/
        public float rate = 30.0f;
        float taxrate = 0.2f;
        public int hours = 0;
        public float gross = 0.0f;
        float tax = 0.0f;
        float net = 0.0f;
        float net_percent = 0.0f;

        //End Attributes

        /********************
         Constructors
    ********************/
        public Employee()
        {

        }

        /********************
             Methods
        ********************/
        public void menu()
        {
            
            int input = 0;

            while (input != 5)
            {
                Console.WriteLine("Please choose one of the following:");
                Console.WriteLine("1) Compute Gross Pay");
                Console.WriteLine("2) Calculate Tax");
                Console.WriteLine("3) Calculate Net Pay");
                Console.WriteLine("4) Calculate Net Percent");
                Console.WriteLine("5) Display Employee and Exit");

                try
                {
                    input = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Invalid input. Please try again.");
                    menu();
                    throw;
                }
                

                if (input == 1){computeGross();}

                else if (input == 2){computeTax();}

                else if (input == 3){computeNet();}

                else if (input == 4){computeNetperc();}

                else if (input == 5){displayEmployee();}

                else if (input != 1 && input != 2 && input != 3 && input != 4)
                {
                    Console.WriteLine("Invalid input, please try again.");
                }
                else Console.WriteLine("Invalid input, please try again.");
            }
        }

        public virtual void computeGross()
        {
            gross = rate * hours;
        }

        public void computeTax()
        {
            if (tax == 0.0)
            {
                computeGross();
                tax = gross * taxrate;
                Console.WriteLine("Tax calculated as: $" + tax);
            }
            else { }
        }

        public void computeNet()
        {
            if (net == 0.0)
            {
                computeTax();
                net = gross - tax;
                Console.WriteLine("Net pay calculated as $" + net);
            }
            else { }
        }

        public void computeNetperc()
        {
            if (net_percent == 0.0)
            {
                computeNet();
                net_percent = (net / gross) * 100;
                Console.WriteLine("Net percent calculated as " + net_percent + "%");
            }
        }

        public void displayEmployee()
        {
            computeNetperc();
            if (hours != 0.0) { Console.WriteLine("Hours: " + hours); }
            else { }
            Console.WriteLine("Rate: " + taxrate);
            Console.WriteLine("Gross: " + gross);
            Console.WriteLine("Net: " + net);
            Console.WriteLine("Net%: " + net_percent + "%");
        }
    }
}

