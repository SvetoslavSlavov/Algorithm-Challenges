using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HashTablesRansomNote
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_m = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            string[] magazine = Console.ReadLine().Split(' ');
            string[] ransom = Console.ReadLine().Split(' ');

            SortedDictionary<int, string> magazineNote = new SortedDictionary<int, string>();
            for (int i = 0; i < m; i++)
            {
                magazineNote.Add(i, magazine[i]);
            }

            SortedDictionary<int, string> kidnapperNote = new SortedDictionary<int, string>();
            for (int i = 0; i < n; i++)
            {
                kidnapperNote.Add(i, ransom[i]);
                //if (kidnapperNote.ContainsValue(kidnapperNote[i])==magazineNote.ContainsValue(magazineNote[i]))
                //{
                //    Console.WriteLine("YES");
                //    break;
                //} 
                //else
                //{
                //    Console.WriteLine("NO");
                //    break;
                //}
                
            }

            ////for (int i = 0; i < m && i < n; i++)
            ////{
            ////    if (kidnapperNote.ContainsValue(kidnapperNote[i]) ==
            ////        magazineNote.ContainsValue(magazineNote[i]) &&
            ////        kidnapperNote[i].Count() <= magazineNote[i].Count())
            ////    {
            ////        bool flag = kidnapperNote[i].Count() <= magazineNote[i].Count();
            ////        if (flag==true&&kidnapperNote[i].Count()==n)
            ////        {
            ////            Console.WriteLine("YES");
            ////        }

            ////    }
            ////    else
            ////    {
            ////        Console.WriteLine("NO");
            ////    }
            //}

            for (int i = 0; i < ransom.Length; i++)
            {
                if (magazineNote.ContainsValue(kidnapperNote[i]))
                {
                    Console.WriteLine("YES");
                }
            }
            Console.ReadKey();
        }
    }
}
