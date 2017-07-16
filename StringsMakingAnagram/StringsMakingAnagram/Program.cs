using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StringsMakingAnagram
{
    class Program
    {
        static int NumberNeeded(string first,string second)
        {
            int[] lettercounts = new int[26];
            foreach (char c in first.ToCharArray())
            {
                lettercounts[c - 'a']++;
            }
            foreach (char c in second.ToCharArray())
            {
                lettercounts[c - 'a']--;
            }
            int result = 0;
            foreach (int i in lettercounts)
            {
                result += Math.Abs(i);
            }
            return result;
        }
        static void Main(string[] args)
        {
            string a = Console.ReadLine();
            string b = Console.ReadLine();
            Console.WriteLine(NumberNeeded(a, b));

            Console.ReadKey();
        }
    }
}
