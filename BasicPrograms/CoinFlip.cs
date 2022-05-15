using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class CoinFlip
    {
        public void CoinFlips(int n)
        {
            int data = n;
            int heads = 0, tails = 0;
            Random r = new Random();

            for (int i = 1; i <= n; i++)
            {
                double flip = r.NextDouble();
                if (flip <= 0.5)
                {
                    heads++;
                }
                else
                {
                    tails++;
                }
            }
            Console.WriteLine(heads * 100 / n);
            Console.WriteLine(tails * 100 / n);
            Console.ReadLine();
        }
    }
}
