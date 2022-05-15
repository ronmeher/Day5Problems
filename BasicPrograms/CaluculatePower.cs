using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class CaluculatePower
    {
        public void CalculatePower(int num,int pow)
        {
            int temp1 = num, temp2 = pow;
            int value = 1;
            while(pow != 0)
            {
                value = value * num;
                pow--;
            }
            Console.WriteLine($"The {temp1} power {temp2} is :  {value} ");
            Console.ReadLine();
        }
    }
}
