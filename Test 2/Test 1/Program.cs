using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Salary s1 = new Salary();
            s1.AnnualSalary = 80000;
            Console.WriteLine($"Your salary is set at {s1.AnnualSalary}");
            Console.WriteLine($"Your salary per week is ${Math.Round (s1.DisplaySalary(),2)}");
            Console.WriteLine("");
            Console.WriteLine("");
           
            Console.WriteLine("I will calculate your wages");
            Console.Write("Enter the numbers of hour worked: ");
            int hour = int.Parse(Console.ReadLine());
            Wages w1 = new Wages();
            w1.NumHour = 33.72;
            Console.WriteLine($"Your wages per week is ${w1.DisplayWages()}");
        }
        class Salary
        {
            private double annualsalary;
            private double weeklysalary;
            public double AnnualSalary
            {
                get { return annualsalary; }
                set { annualsalary = value; }
            }
            public double WeeklySalary
            {
                get { return weeklysalary; }
                set { weeklysalary = value; }
            }

            public Salary ()
            {
                WeeklySalary = DisplaySalary();

              
            }
            public double DisplaySalary ()
            {
                return (annualsalary * 7) / 365;
            }

        }
        class Wages
        {
            double numhour;
            double weeklywages;
            public double NumHour
            {
                get { return numhour; }
                set { numhour = value; }
            }
            public double WeeklyWages
            {
                get { return weeklywages; }
                set { weeklywages = value; }
            }
            public Wages ()
            {
                WeeklyWages = DisplayWages();
            }
            public double DisplayWages()
            {
                return numhour * 7;
            }
        }
    }
}
