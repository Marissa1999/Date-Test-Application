//ID: 1775227
//Name: Marissa Goncalves
//Assignment 1 - Problem 3: DateTest app

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problem03
{
    class Date
    {

        //Initialize the instance variables of the Date class
        private int month;
        private int day;
        private int year;


        //Main constructor for the Date class that takes all inputted values in the parameter
        public Date(int month, int day, int year)
        {
            Month = month;
            Day = day;
            Year = year;
        }


        //Implicit property for the month variable
        public int Month
        {
            get; set;
        }


        //Implicit property for the day variable
        public int Day
        {
            get; set;
        }


        //Implicit property for the year variable
        public int Year
        {
            get; set;
        }


        //Using string interpolation, display the formatted date
        public void DisplayDate()
        {

            Console.WriteLine($"----------------------------------");
            Console.WriteLine($"| Current Date | {Month,2}/{Day,2}/{Year,-10}|");
            Console.WriteLine($"----------------------------------");
            Console.WriteLine();

        }




    }
}
