using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RansomNoteRegex
{
    class Program
    {
        static string checkwords(string[] magazine, string[] ransom)
        {
            Array.Sort(magazine);
            Array.Sort(ransom);


            // Converting array to List
            List<string> magList = magazine.ToList();

            //foreach (var s in ranList)
            foreach (string rans in ransom)
            {
                if (!magList.Remove(rans))
                {
                    return "False";
                }
            }
            return "True";
        }
        static void Main(string[] args)
        {
            string[] tokens_m = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            string[] magazine = Console.ReadLine().Split(' ');
            string[] ransom = Console.ReadLine().Split(' ');
            Console.WriteLine("{0}", checkwords(magazine, ransom));
            Console.ReadKey();
        }
    }
}
