using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class Swapping
    {
        public void swap(int a,int b)
        {
            Console.WriteLine($"Before swapping a : {a} b : {b}");
            a = a + b;
            b = a - b;
            a = a - b;
            Console.WriteLine($"After swapping a : {a} b : {b}");
            Console.ReadLine();
        }
    }
}
