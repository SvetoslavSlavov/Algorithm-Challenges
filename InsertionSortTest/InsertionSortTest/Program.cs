using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InsertionSortTest
{
    class Program
    {
        static void InsertionSort(int[] arr)
        {
            for (int j = 1; j < arr.Length; j++)
            {
                for (int i = j; i>0&&arr[i] < arr[i-1]; i--)
                {
                    int tmp = arr[i];
                    arr[i] = arr[i-1];
                    arr[i-1] = tmp;
                }
            }
        }
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            int[]arr= new int [size];
            string elements = Console.ReadLine();
            string[] split = elements.Split(' ');

            for (int i = 0; i < size; i++)
            {
                arr[i] = int.Parse(split[i]);
            }

            InsertionSort(arr);

            for (int i = 0; i < size; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.ReadLine();
        }
    }
}
