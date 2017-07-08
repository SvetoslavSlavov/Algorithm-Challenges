using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTest
{
    class Program
    {
        static void QuickSort(int[] arr,int left,int right)
        {
            int i = left;
            int j = right;
            int pivot = arr[(left + right) / 2];

            while (i<=j)
            {
                while (arr[i].CompareTo(pivot)<0)
                {
                    i++;
                }
                while (arr[j].CompareTo(pivot)>0)
                {
                    j--;
                }
                if (i<=j)
                {
                    int tmp = arr[i];
                    arr[i] = arr[j];
                    arr[j] = tmp;

                    i++;
                    j--;
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
        }
        static void InsertionSort(int[] arr)
        {
            for (int j = 1; j < arr.Length; j++)
            {
                Console.WriteLine();
                for (int i = j;i>0 && i < arr.Length; i--)
                {
                    if (arr[i]<arr[i-1])
                    {
                        int tmp = arr[i-1];
                        arr[i-1] = arr[i];
                        arr[i] = tmp;
                    }
                }
            }
        }
        static void BubleSort(int[] arr)
        {
            for (int j = arr.Length-1; 0 < j; j--)
            {
                for (int i = 0; i < j; i++)
                {
                    if (arr[i]>arr[i+1])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[i + 1];
                        arr[i + 1] = tmp;
                    }
                }
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

            // BubleSort(arr);
            // InsertionSort(arr);
            QuickSort(arr, 0, arr.Length - 1);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }

            Console.ReadLine();
        }
    }
}
