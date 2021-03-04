using System;

namespace ConsoleAppProject.App02
{
    /// <summary>
    /// Please describe the main features of this App
    /// </summary>
    /// <author>
    /// Eman Limbu version 0.1
    /// </author>
    public class BMI
    {
        private int unitinput;
        private Double metheight;
        private Double metweight;
        private Double impfeet;
        private Double impinches;
        private Double impstones;
        private Double imppounds;
        private Double metbmi;
        private Double impbmi;

        public void Run()
        {
            Displayheading();
            Units();
            Diffunits();
            Calculatebmi();
            Outputbmi();
            Metscore();
            Bamemsg();
        }

        private void Displayheading()
        {
            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("-----------------------------------");
            Console.WriteLine("\tBody Mass Index Calculator");
            Console.WriteLine("\tby Eman Limbu");
            Console.WriteLine("-----------------------------------");
        }

        private void Units()
        {
            Console.WriteLine("\t1.Metric Units");
            Console.WriteLine("\t2.Imperial Units");
            Console.Write("\nPlease enter your choice 1 or 2 > ");
            string value = Console.ReadLine();
            unitinput = Convert.ToInt32(value);
        }

        private void Diffunits()
        {
            if (unitinput == 1)
            {
                Console.Write("\nEnter your height in metres > ");
                string Mheight = Console.ReadLine();
                metheight = Convert.ToDouble(Mheight);
                Console.Write("\nEnter your weight in to a nearest whole Kg > ");
                string Mweight = Console.ReadLine();
                metweight = Convert.ToDouble(Mweight);
            }

            else if (unitinput == 2)
            {
                Console.WriteLine("\nEnter your height to the nearest whole feet and inches");

                Console.Write("\nEnter your height in feet > ");
                string Ifeet = Console.ReadLine();
                impfeet = Convert.ToDouble(Ifeet);

                Console.Write("Enter your height in inches > ");
                string Iinches = Console.ReadLine();
                impinches = Convert.ToDouble(Iinches);

                Console.WriteLine("\nEnter your weight to the nearest whole stones and pounds");
                Console.Write("\nEnter your weight in stones > ");
                string Istones = Console.ReadLine();
                impstones = Convert.ToDouble(Istones);

                Console.Write("Enter your weight in pounds > ");
                string Ipounds = Console.ReadLine();
                imppounds = Convert.ToDouble(Ipounds);
            }

        }

        private void Calculatebmi()
        {
            if (unitinput == 1)
            {
                metbmi = metweight / (metheight * metheight);
            }

            else if (unitinput == 2)
            {
                impbmi = (impstones * 14 + imppounds) * 703 / ((impfeet * 12 + impinches) * impfeet * 12 + impinches);
            }
        }
    
        private void Outputbmi()
        {
            if (unitinput == 1)
            {
                Console.WriteLine("Your BMI is " + metbmi);
            }

             else if (unitinput == 2)
             {
                Console.WriteLine("Your BMI is " + Math.Round(impbmi, 2));
             }
        }

        private void Metscore()
        {
            if (metbmi <= 18.50)
            {
                Console.WriteLine("You are in the underweight range!\n");
            }

            else if (metbmi >= 18.50)
            {
                Console.WriteLine("You are in the normal range!\n");
            }

            else if (metbmi >= 25.0 - 29.9)
            {
                Console.WriteLine("You are in the Overweight range!\n");
            }

            else if (metbmi >= 30.0 - 34.9)
            {
                Console.WriteLine("You are in the Obese Class 1 range!\n");
            }

            else if (metbmi >= 35.0)
            {
                Console.WriteLine("You are in the Obese Class 2 range!\n");
            }

            else if (metbmi >= 40.0)
            {
                Console.WriteLine("You are in the Obese Class 3 range!\n");
            }

        }

        private void Bamemsg()
        {
            Console.WriteLine("If you are black, Asain or other minority");
            Console.WriteLine("ethinc groups, you have a higher risk\n");

            Console.WriteLine("Adults 23.0 or more are at increased risk");
            Console.WriteLine("Adults 27.5 or more are at high risk");
        }


    }
}

