using System;


namespace ConsoleAppProject.App03
{
    /// <summary>
    /// Grade A is First Class   : 70 - 100
    /// Grade B is Upper Second  : 60 - 69
    /// Grade C is Lower Second  : 50 - 59
    /// Grade D is Third Class   : 40 - 49
    /// Grade F is Fail          :  0 - 39
    /// </summary>
    public class Grades
    {
        private int markinput;
        private int[] marks;
        private string[] students;

        public void Run()
        {
            Displayheading();
            Markinput();
            Displayresult();
            MinMaxandMean();
        }

        private void Displayheading()
        {
            Console.WriteLine("-----------------------------------");
            Console.WriteLine("\tStudent Marks");
            Console.WriteLine("\tby Eman Limbu");
            Console.WriteLine("-----------------------------------");
        }

        private void Markinput()
        {

            marks = new int[10];
            students = new string[] {"Billy Davis", "Hussain Mohammed", "Sonny Wuwong", "Alex Benson", "Kofi Baynes",
            "Harry Locksmith", "Harvey smith", "Bilaal Hussien", "Candice Leigh", "Jayden Parker"};

            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Please enter the marks for the students\t" + students[i] + ">");
                string mark = Console.ReadLine();
                markinput = Convert.ToInt32(mark);

                marks[i] = markinput;
            }

        }

        private string Calculategrade(int marks)
        {
            if (marks >= 0 && marks <= 39)
            {
                return "F";
            }

            else if (marks >= 40 && marks <= 49)
            {
                return "D";
            }

            else if (marks >= 50 && marks <= 59)
            {
                return "C";
            }

            else if (marks >= 60 && marks <= 69)
            {
                return "B";
            }

            {
                return "A";
            }
        }


        private void Displayresult()
        {
            for (int i = 0; i < students.Length; i++)
            {
                Console.WriteLine("Name:" + students[i] + "\t Mark:" + marks[i] + "\t Grade:" + Calculategrade(marks[i]));
            }
        }

        private void MinMaxandMean()
        {
            int min = marks[0];
            int max = marks[0];

            int amountofnum = 10;
            double mean = 0;

            for (int i = 0; i < marks.Length; i++)
            {
                if (min > marks[i])
                {
                    min = marks[i];
                }

                if (max < marks[i])
                {
                    max = marks[i];
                }

                mean += marks[i];

            }

            Console.ForegroundColor = ConsoleColor.Green;

            Console.WriteLine("\nMinimum Mark:" + min + "\nMaximum Mark:" + max + "\nMean Mark:" + mean / amountofnum);
        }

    }
}
