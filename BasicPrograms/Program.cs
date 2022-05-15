using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BasicPrograms
{
    class Program
    {
        static void Main(string[] args)
        {
            //coin Flip
            Console.Write("Enter number of Times to Flip a Coin :  ");
            int n = Convert.ToInt32(Console.ReadLine());
            CoinFlip p1 = new CoinFlip();
            p1.CoinFlips(n);

            ////Leap Year
            //Console.Write("Enter Year to check wheater it is leap year or Not :  ");
            //int year = Convert.ToInt32(Console.ReadLine());
            //LeapYear p2 = new LeapYear();
            //p2.CheckYear(year);

            ////Power calcation
            //Console.Write("Enter the value: ");
            //int num = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter the power: ");
            //int power = Convert.ToInt32(Console.ReadLine());
            //CaluculatePower p3 = new CaluculatePower();
            //p3.CalculatePower(num, power);

            //Harmonic number
            Console.Write("Enter the number to claculate Harmonic Number :  ");
            int numb = Convert.ToInt32(Console.ReadLine());
            HarmonicNumber p4 = new HarmonicNumber();
            p4.Harmonic(numb);

            ////Prime Factor
            //Console.Write("Enter the number to calculate Factorial:  ");
            //int factor = Convert.ToInt32(Console.ReadLine());
            //Factor p5 = new Factor();
            //p5.Fact(factor);

            ////Compute Quoitent and Remainder
            //Console.Write("Enter Divident:  ");
            //int divident = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter Divisor :  ");
            //int divisor = Convert.ToInt32(Console.ReadLine());
            //QuotientRemainder p6 = new QuotientRemainder();
            //p6.Quotient(divident, divisor);
            //p6.Remainder(divident, divisor);


            ////swapping
            //Console.WriteLine("swapping program");
            //Console.Write("Enter a : ");
            //int a = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter b : ");
            //int b = Convert.ToInt32(Console.ReadLine());
            //Swapping p7 = new Swapping();
            //p7.swap(a, b);


            ////Even Or Odd
            //Console.Write("Enter number to check Even or Odd:  ");
            //int check = Convert.ToInt32(Console.ReadLine());
            //EvenOdd p8 = new EvenOdd();
            //p8.CheckNumber(check);

            ////Check an Alphabet is Vowel or Consonant
            //Console.Write("Enter number to check Vowel or Consonant:  ");
            //char c = Convert.ToChar(Console.ReadLine());
            //VowelConsonant p9 = new VowelConsonant();
            //p9.Check(c);

            ////Find Largest of Three numbers
            //Console.WriteLine("Finding Largest number");
            //Console.Write("Enter a : ");
            //int a1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter b : ");
            //int b1 = Convert.ToInt32(Console.ReadLine());
            //Console.Write("Enter c : ");
            //int c1 = Convert.ToInt32(Console.ReadLine());
            //LargestNumber p10 = new LargestNumber();
            //p10.Large(a1, b1, c1);

        }
    }
}
