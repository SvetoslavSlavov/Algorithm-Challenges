using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EmptyLoop
{
    class Program
    {
        static void Main(string[] args)
        {
            int i= 0;
            int j = 10;

            for (;  i < j; i++)
            {
                Console.WriteLine(i);
            }
            Console.ReadKey();
        }
    }
}
