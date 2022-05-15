using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class LargestNumber
    {
        public void Large(int a,int b,int c)
        {
            if ((a > b) && (a > c))
            {
                Console.WriteLine($"The Largest number among {a},{b},{c} is : {a} ");
            }
            else if(b>c)
            {
                Console.WriteLine($"The Largest number among {a},{b},{c} is : {b} ");
            }
            else
            {
                Console.WriteLine($"The Largest number among {a},{b},{c} is : {c} ");
            }
            Console.ReadLine();
        }
    }
}
