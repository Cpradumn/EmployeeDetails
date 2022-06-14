using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmployeeDetails
{
    public class Date
    {
        // Auto implemented Property
        // Property internally creates a variable store & reterive data from it

        /*
        private int day, year;
        private string month;

        // sysntax of property

        public int Day
        {
            get { return day; }
            set { day = value; } // value is keyword
        }
        public int Year
        {
            get { return year; }
            set { year = value; }
        }
        public string Month
        {
            get { return month; }
            set { month = value; }
        }
        */
        public int Day { get; set; }
        public string Month { get; set; }

        public int Year { get; set; }

        
    }
}
