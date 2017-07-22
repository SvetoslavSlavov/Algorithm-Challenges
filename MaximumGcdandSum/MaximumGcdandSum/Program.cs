using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaximumGcdandSum
{
    class Program
    {
        static int MaximumSum(int[] arr1, int[] arr2)
        {
            int sum = 0;
            Array.Sort(arr1);
            Array.Sort(arr2);
            Array.Reverse(arr1);
            Array.Reverse(arr2);
            for (int i = 0; i < arr1.Length; i++)
            {
                for (int j = 0; j < arr2.Length; j++)
                {
                    if (arr1[i]/arr2[j]==1)
                    {
                        sum = arr1[i] + arr2[j];
                        return sum;
                    }
                }
            }
            return sum;
        }
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] arr1 = new int[size];
            int[] arr2 = new int[size];
            string[] elements1 = Console.ReadLine().Split(' ');
            string[] elements2 = Console.ReadLine().Split(' ');

            for (int i = 0; i < size; i++)
            {
                arr1[i] = int.Parse(elements1[i]);
                arr2[i] = int.Parse(elements2[i]);
            }
            Console.WriteLine(MaximumSum(arr1,arr2));

            Console.ReadKey();
        }
    }
}
