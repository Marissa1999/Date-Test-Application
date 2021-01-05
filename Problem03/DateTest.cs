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
    class DateTest
    {
        static void Main(string[] args)
        {

            //Create new objects that take up different values
            Date one = new Date(9, 23, 1000);
            Date two = new Date(12, 5, 2019);
            Date three = new Date(11, 23, 983);
            Date four = new Date(2, 12, 34);
            Date five = new Date(10, 3, 5);
            Date six = new Date(5, 8, 1967);
            Date seven = new Date(-2, 34, 199);
            Date eight = new Date(12, -3, -204);
            Date nine = new Date(9, 3, -13);
            Date ten = new Date(10, 8, -4);


            //Call the method in order to print the date table
            one.DisplayDate();
            two.DisplayDate();
            three.DisplayDate();
            four.DisplayDate();
            five.DisplayDate();
            six.DisplayDate();
            seven.DisplayDate();
            eight.DisplayDate();
            nine.DisplayDate();
            ten.DisplayDate();





        }
    }
}
