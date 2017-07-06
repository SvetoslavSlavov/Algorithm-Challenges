using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BigSorting
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] unsorted = new string[n];
            for (int unsorted_i = 0; unsorted_i < n; unsorted_i++)
            {
                unsorted[unsorted_i] = Console.ReadLine();
            }
            Start:
            int left = 0;
            int right = n - 1;

            int i = left;
            int j = right;
            IComparable pivot = unsorted[(left + right) / 2];

            while (i<=j)
            {
                while (unsorted[i].CompareTo(pivot)<0)
                {
                    i++;
                }
                while (unsorted[j].CompareTo(pivot)>0)
                {
                    j--;
                }
                if (i<=j)
                {
                    IComparable tmp = unsorted[i];
                    unsorted[i] = unsorted[j];
                    unsorted[j] = tmp.ToString();
                }
            }
            if (i<right)
            {
                goto Start;
            }
            if (j<left)
            {
                goto Start;
            }

            for (int r = 0; r < n; r++)
            {
                Console.WriteLine(unsorted[r]);
            }
            Console.ReadKey();
        }
    }
}
