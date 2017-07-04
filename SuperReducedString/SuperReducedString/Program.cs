using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperReducedString
{
    
    class Program
    {
        static string super_reduced_string(string val1)
        {
            if (val1.Length>4)
            {
                while (val1[0].Equals(val1[1]))
                {
                    val1 = val1.Remove(0, 1);
                }
                while (val1[val1.Length - 1].Equals(val1[val1.Length - 2]))
                {
                    val1 = val1.Remove(val1.Length - 2, 1);
                }
                while (val1[2].Equals(val1[(val1.Length - 1) - 1]))
                {
                    val1 = val1.Remove((val1.Length - 1) - 1, 1);
                }
            }
            else
            {
                val1 = "Empty String";
            }
            return val1;
        }

        static void Main(String[] args)
        {
            string s = Console.ReadLine();
            string result = super_reduced_string(s);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
