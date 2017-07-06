using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubleSort
{
    class Program
    {
        static void BubleSort(int[] data)
        {
            int i;
            int j;
            int N = data.Length;

            for (j = N-1; j > 0; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (data[i]>data[i+1])
                    {
                        // Sorting
                        int temporaty = data[i];
                        data[i] = data[i + 1];
                        data[i + 1] = temporaty;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());

            int[] ar = new int[size];
            string elements = Console.ReadLine();
            string[] split_ar = elements.Split(' ');

            for (int i = 0; i < size; i++)
            {
                ar[i] = Convert.ToInt32(split_ar[i]);
            }
            BubleSort(ar);

            for (int i = 0; i < size; i++)
            {
                Console.Write(ar[i] + " ");
            }

            Console.ReadKey();
        }
    }
}
