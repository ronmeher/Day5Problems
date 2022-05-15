using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class HarmonicNumber
    {
        //if n=4
        //1+1/2+1/3+1/4
        public void Harmonic(int number)
        {
            double value = 0;
            for(int i = 1; i <= number; i++)
            {
                value = value + (float)1 / i;
            }
            Console.WriteLine($"Harmonic number {value}");
            Console.ReadLine();
        }

    }
}
