using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {

            string val1 = "abbbbbbbbccccccccd";
            Console.WriteLine(val1.Length);
            if (val1.Length > 4)
            {
                while (val1[0].Equals(val1[1]))
                {
                    val1 = val1.Remove(0, 1);
                }
                while (val1[val1.Length - 1].Equals(val1[val1.Length - 2]))
                {
                    val1 = val1.Remove(val1.Length - 1, 1);
                }
                while (val1[2].Equals(val1[(val1.Length - 1) - 2]))
                {
                    val1 = val1.Remove((val1.Length - 1) - 2, 1);
                }
            }
            else
            {
                val1 = "Empty String";
            }
            Console.WriteLine(val1);
            Console.WriteLine(val1.Length);
            Console.ReadLine();
        }
    }
}
