using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class LeapYear
    {
        public void CheckYear(int year)
        {
            if ((year % 4 == 0 && year % 100 != 0) || year % 400 == 0)
            {
                Console.WriteLine($"Enter year {year} is LEAP YEAR ");

            }
            else
            {
                Console.WriteLine($"Enter year {year} is NOT LEAP YEAR");
            }
            Console.ReadLine();
        }
    }
}
