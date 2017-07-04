using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperReducedStringAnother
{
    
    class Program
    {
        static string super_reduced_string(string val1)
        {
            for (int i = 0; i < val1.Length; i++)
            {
                if (val1[i]==val1[i-1])
                {
                    val1 = val1.Substring(0, i - 1) + val1.Substring(i + 1);
                    i = 0;
                }
                if (val1.Length==0)
                {
                    val1 = "Empty String";
                }
            }
            return val1;
        }
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string result = super_reduced_string(s);
            Console.WriteLine(result);
        }
    }
}
