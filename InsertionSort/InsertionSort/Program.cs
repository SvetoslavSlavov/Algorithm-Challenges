using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSort
{
    class Program
    {
        static void InsertionSort(int[] arr)
        {
            int i, j;
            int N = arr.Length;
            
            for (j = 1; j < N; j++)
            {
                
                for (i=j; i > 0 && arr[i]<arr[i-1]; i--)
                {
                    
                    int tmp = arr[i];
                    arr[i] = arr[i - 1];
                    arr[i - 1] = tmp;
                }
                for (int p = 0; p < arr.Length; p++)
                {
                    Console.Write(arr[p] + " ");
                }
                Console.WriteLine();
            }
            
        }
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[] arr = new int[size];
            string elements = Console.ReadLine();
            string[] split = elements.Split(' ');

            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(split[i]);
            }

            InsertionSort(arr);
            Console.ReadLine();
        }
    }
}
