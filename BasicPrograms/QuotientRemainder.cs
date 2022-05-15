using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class QuotientRemainder
    {
        public void Quotient(int divident,int divisor)
        {
            Console.WriteLine($"The Quotient is {divident / divisor}");
        }
        public void Remainder(int divident, int divisor)
        {
            Console.WriteLine($"The Quotient is {divident % divisor}");
        }

    }
}
