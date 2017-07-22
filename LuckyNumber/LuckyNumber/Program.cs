using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LuckyNumber
{
    class Program
    {
        static void DigitCompare(int digit)
        {
            if (digit / 100000 + (digit / 10000 % 10) + (digit / 1000 % 100 % 10) == 
                (digit / 100 % 100 % 10) + (digit / 10 % 100 % 10 % 10) + (digit % 100 % 10 % 10 % 10))
            {
                ++digit;
            }
            while ((digit / 100000) + (digit / 10000 % 10) + (digit / 1000 % 100 % 10) != (digit / 100 % 100 % 10) + (digit / 10 % 100 % 10 % 10) + (digit % 100 % 10 % 10 % 10))
            {
                digit++;
                if (digit / 100000 + (digit / 10000 % 10) + (digit / 1000 % 100 % 10) == (digit / 100 % 100 % 10) + (digit / 10 % 100 % 10 % 10) + (digit % 100 % 10 % 10 % 10))
                {
                    Console.WriteLine(digit);
                    break;
                }
            }
        }
        static void Main(string[] args)
        {
            int digit = int.Parse(Console.ReadLine());
            DigitCompare(digit);
            Console.ReadKey();
        }
    }
}
