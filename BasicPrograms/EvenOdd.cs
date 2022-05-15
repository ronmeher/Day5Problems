using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class EvenOdd
    {
        public void CheckNumber(int number)
        {
            if(number%2 == 0)
            {
                Console.WriteLine($"Entered number {number} is Even number");
            }
            else
            {
                Console.WriteLine($"Entered number {number} is Odd number");
            }
            Console.ReadLine();
        }
    }
}
