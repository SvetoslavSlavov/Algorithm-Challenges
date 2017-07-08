using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuickSort_2___Sorting
{
    class Program
    {
        static void QuickSort(int[]arr, int left, int right)
        {
            int i = left;
            int j = right;
            int pivot = arr[i];

            

            while (i<=j)
            {
                while (arr[i].CompareTo(pivot)<0)
                {
                    i++;
                }
                while (arr[i].CompareTo(pivot)>0)
                {
                    j--;
                }
                if (i<=j)
                {
                    int tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;
                    for (int p = 0; p < arr.Length; p++)
                    {
                        Console.Write(arr[p] + " ");
                    }
                }
            }
            
            if (left<j)
            {
                QuickSort(arr, left, j);
            }
            if (i<right)
            {
                QuickSort(arr, i, right);
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

            QuickSort(arr, 0, arr.Length - 1);
        }
    }
}
