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
        public int Frmunit { get; set; }

        public int Tounit { get; set; }

        public Double Miles { get; set; }

        public Double Feet { get; set; }

        public Double Metres { get; set; }

        public DistanceUnits DistanceUnits
        {
            get => default;
            set
            {
            }
        }

        public void Run()
        {
            Convertfrm();
            Frmoutput();
            Convertto();
            Tooutput();
            Diffoutputs();
            Calculatefeet();
            OutputConversion();
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
            Frmunit = Convert.ToInt32(value);

            if (Frmunit == 1)
                Console.WriteLine("\nYou have selected Feet\n");

            else if (Frmunit == 2)
                Console.WriteLine("\nYou have selected Metres\n");

            else if (Frmunit == 3)
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
            Tounit = Convert.ToInt32(value);

            if (Tounit == 1)
                Console.WriteLine("\nYou have selected Feet\n");

            else if (Tounit == 2)
                Console.WriteLine("\nYou have selected Metres\n");

            else if (Tounit == 3)
                Console.WriteLine("\nYou have selected Miles\n");

        }

        public void Diffoutputs() 
        {
            if ((Frmunit == 3) & (Tounit == 1))
            {
                Console.WriteLine("Converting Miles to Feet");
                Console.Write("\nEnter distance in Miles > ");
                string value = Console.ReadLine();
                Miles = Convert.ToDouble(value);
            }

            else if ((Frmunit == 1) & (Tounit == 3))
            {
                Console.WriteLine("Converting Feet to Miles");
                Console.Write("\nEnter distance in Feet > ");
                string value = Console.ReadLine();
                Feet = Convert.ToDouble(value);
            }

            else if ((Frmunit == 3) & (Tounit == 2))
            {
                Console.WriteLine("Converting Miles to Metres");
                Console.Write("\nEnter distance in Miles > ");
                string value = Console.ReadLine();
                Miles = Convert.ToDouble(value);
            }

            else if ((Frmunit == 2) & (Tounit == 3))
            {
                Console.WriteLine("Converting Metres to Miles");
                Console.Write("\nEnter distance in Metres > ");
                string value = Console.ReadLine();
                Metres = Convert.ToDouble(value);
            }

            else if ((Frmunit == 2) & (Tounit == 1))
            {
                Console.WriteLine("Converting Metres to Feet");
                Console.Write("\nEnter distance in Metres > ");
                string value = Console.ReadLine();
                Metres = Convert.ToDouble(value);
            }

            else if ((Frmunit == 1) & (Tounit == 2))
            {
                Console.WriteLine("Converting Feet to Metres");
                Console.Write("\nEnter distance in Feet > ");
                string value = Console.ReadLine();
                Feet = Convert.ToDouble(value);
            }
        }

        public void Calculatefeet()
        {
            if ((Frmunit == 3) & (Tounit == 1))
            {
                Feet = Miles * 5280;
            }

            else if ((Frmunit == 1) & (Tounit == 3))
            {
                Miles = Feet / 5280;
            }

            else if ((Frmunit == 3) & (Tounit == 2))
            {
                Metres = Miles * 1609.34;
            }

            else if ((Frmunit == 2) & (Tounit == 3))
            {
                Miles = Metres / 1609.34;
            }

            else if ((Frmunit == 2) & (Tounit == 1))
            {
                Feet = Metres * 3.28084;
            }

            else if ((Frmunit == 1) & (Tounit == 2))
            {
                Metres = Feet / 3.28084;
            }
        }

        private void OutputConversion()
        {
            if ((Frmunit == 3) & (Tounit == 1))
            {
                Console.WriteLine(Miles + " miles is " + Feet + "feet!");
            }

            else if ((Frmunit == 1) & (Tounit == 3))
            {
                Console.WriteLine(Feet + " feet is " + Miles + "miles!");
            }

            else if ((Frmunit == 3) & (Tounit == 2))
            {
                Console.WriteLine(Miles + " miles is " + Metres + "metres!");
            }

            else if ((Frmunit == 2) & (Tounit == 3))
            {
                Console.WriteLine(Metres + " metres is " + Miles + "miles!");
            }

            else if ((Frmunit == 2) & (Tounit == 1))
            {
                Console.WriteLine(Metres + " metres is " + Feet + "feet!");
            }

            else if ((Frmunit == 1) & (Tounit == 2))
            {
                Console.WriteLine(Feet + " feet is " + Metres + "metres!");
            }
        }
    }
}
