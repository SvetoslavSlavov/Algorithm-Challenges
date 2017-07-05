using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSortTesting
{
    class Program
    {
        static void partition(int[] ar, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = ar[(right + left) / 2];

            while (i<=j)
            {
                while (ar[i].CompareTo(pivot)<0)
                {
                    i++;
                }
                while (ar[j].CompareTo(pivot)>0)
                {
                    j--;
                }

                if (i<=j)
                {
                    int tmp = ar[i];
                    ar[i] = ar[j];
                    ar[j] = tmp;

                    i++;
                    j--;
                }
            }
            if (left<j)
            {
                partition(ar, left, j);
            }
            if (i<right)
            {
                partition(ar, i, right);
            }

        }
        static void Main(string[] args)
        {
            int _ar_size;
            _ar_size = Convert.ToInt32(Console.ReadLine());
            int[] _ar = new int[_ar_size];
            String elements = Console.ReadLine();
            String[] split_elements = elements.Split(' ');
            for (int _ar_i = 0; _ar_i < _ar_size; _ar_i++)
            {
                _ar[_ar_i] = Convert.ToInt32(split_elements[_ar_i]);
            }
            partition(_ar, 0, _ar.Length - 1);
            for (int i = 0; i < _ar.Length; i++)
            {
                Console.Write(_ar[i]+ " ");
            }
            Console.ReadKey();
        }
    }
}
