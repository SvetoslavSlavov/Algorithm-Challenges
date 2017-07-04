using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperReducedStringAnotherTry
{
    class Program
    {
        //static string super_reduced_string(string val1)
        //{
        //}
        static void Main(string[] args)
        {
            string s = Console.ReadLine();
            string val = "";
            for (int i = 0; i < s.Length; i++)
            {
                char c = s[i];
                if (val.Length>0&&val[val.Length-1]==c)
                {
                    val = val.Substring(0, val.Length - 1);
                }
                else
                {
                    val += c;
                }
            }
            Console.WriteLine(string.IsNullOrEmpty(val) ?"Empty String":val);
            Console.ReadKey();
        }
    }
}
