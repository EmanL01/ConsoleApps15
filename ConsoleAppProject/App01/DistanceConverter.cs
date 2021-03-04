using System;

namespace ConsoleAppProject.App01
{
    /// <summary>
    /// Takes user input of distance to convert from to and the number of distance and converts it.
    /// </summary>
    /// <author>
    /// Eman Limbu version 0.1
    /// </author>
 
    public class DistanceConverter
    {
        private int frmunit;
        private int tounit;
        private Double miles;
        private Double feet;
        private Double metres;


        public void Run()
        {
            Outputheading();
            Convertfrm();
            Frmoutput();
            Convertto();
            Tooutput();
            Diffoutputs();
            Calculatefeet();
            OutputConversion();
        }

        private void Outputheading()
        {
            Console.WriteLine("-------------------------------");
            Console.WriteLine("\tConvert Distances");
            Console.WriteLine("\tby Eman Limbu");
            Console.WriteLine("-------------------------------");
        }
        private void Convertfrm()
        {
            Console.WriteLine("Select distance unit to convert from >\n");
            Console.WriteLine("1.Feet");
            Console.WriteLine("2.Metres");
            Console.WriteLine("3.Miles");
            Console.Write("\nPlease enter your choice 1, 2 or 3 > ");
        }

        public void Frmoutput()
        {
            string value = Console.ReadLine();
            frmunit = Convert.ToInt32(value);

            if (frmunit == 1)
                Console.WriteLine("\nYou have selected Feet\n");

            else if (frmunit == 2)
                Console.WriteLine("\nYou have selected Metres\n");

            else if (frmunit == 3)
                Console.WriteLine("\nYou have selected Miles\n");
        }

        private void Convertto()
        {
            Console.WriteLine("Select distance unit to convert to >\n");
            Console.WriteLine("1.Feet");
            Console.WriteLine("2.Metres");
            Console.WriteLine("3.Miles");
            Console.Write("\nPlease enter your choice 1, 2 or 3 > ");
        }

        private void Tooutput()
        {
            string value = Console.ReadLine();
            tounit = Convert.ToInt32(value);

            if (tounit == 1)
                Console.WriteLine("\nYou have selected Feet\n");

            else if (tounit == 2)
                Console.WriteLine("\nYou have selected Metres\n");

            else if (tounit == 3)
                Console.WriteLine("\nYou have selected Miles\n");

        }

        private void Diffoutputs()
        {
            if ((frmunit == 3) & (tounit == 1))
            {
                Console.WriteLine("Converting Miles to Feet");
                Console.Write("\nEnter distance in Miles > ");
                string value = Console.ReadLine();
                miles = Convert.ToDouble(value);
            }

            else if ((frmunit == 1) & (tounit == 3))
            {
                Console.WriteLine("Converting Feet to Miles");
                Console.Write("\nEnter distance in Feet > ");
                string value = Console.ReadLine();
                feet = Convert.ToDouble(value);
            }

            else if ((frmunit == 3) & (tounit == 2))
            {
                Console.WriteLine("Converting Miles to Metres");
                Console.Write("\nEnter distance in Miles > ");
                string value = Console.ReadLine();
                miles = Convert.ToDouble(value);
            }

            else if ((frmunit == 2) & (tounit == 3))
            {
                Console.WriteLine("Converting Metres to Miles");
                Console.Write("\nEnter distance in Metres > ");
                string value = Console.ReadLine();
                metres = Convert.ToDouble(value);
            }

            else if ((frmunit == 2) & (tounit == 1))
            {
                Console.WriteLine("Converting Metres to Feet");
                Console.Write("\nEnter distance in Metres > ");
                string value = Console.ReadLine();
                metres = Convert.ToDouble(value);
            }

            else if ((frmunit == 1) & (tounit == 2))
            {
                Console.WriteLine("Converting Feet to Metres");
                Console.Write("\nEnter distance in Feet > ");
                string value = Console.ReadLine();
                feet = Convert.ToDouble(value);
            }
        }

        private void Calculatefeet()
        {
            if ((frmunit == 3) & (tounit == 1))
            {
                feet = miles * 5280;
            }

            else if ((frmunit == 1) & (tounit == 3))
            {
                miles = feet / 5280;
            }

            else if ((frmunit == 3) & (tounit == 2))
            {
                metres = miles * 1609.34;
            }

            else if ((frmunit == 2) & (tounit == 3))
            {
                miles = metres / 1609.34;
            }

            else if ((frmunit == 2) & (tounit == 1))
            {
                feet = metres * 3.28084;
            }

            else if ((frmunit == 1) & (tounit == 2))
            {
                metres = feet / 3.28084;
            }
        }

        private void OutputConversion()
        {
            if ((frmunit == 3) & (tounit == 1))
            {
                Console.WriteLine(miles + " miles is " + feet + "feet!");
            }

            else if ((frmunit == 1) & (tounit == 3))
            {
                Console.WriteLine(feet + " feet is " + miles + "miles!");
            }

            else if ((frmunit == 3) & (tounit == 2))
            {
                Console.WriteLine(miles + " miles is " + metres + "metres!");
            }

            else if ((frmunit == 2) & (tounit == 3))
            {
                Console.WriteLine(metres + " metres is " + miles + "miles!");
            }

            else if ((frmunit == 2) & (tounit == 1))
            {
                Console.WriteLine(metres + " metres is " + feet + "feet!");
            }

            else if ((frmunit == 1) & (tounit == 2))
            {
                Console.WriteLine(feet + " feet is " + metres + "metres!");
            }
        }
    }
}
