using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SortingExercise
{
    class Program
    {
        static void QuickSort(int[] arr,int right,int left)
        {
            int i = left;
            int j = right;
            int pivot = arr[j];

            while (i<=j)
            {
                while (arr[i].CompareTo(pivot) < 0)
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
            }
            if (left<j)
            {
                QuickSort(arr, j, left);
            }
            if (i<right)
            {
                QuickSort(arr, right, i);
            }
            
            
        }
        static void BubleSort(int[] arr)
        {
            int i, j;
            for (j = arr.Length-1; 0 < j; j--)
            {
                for (i = 0; i < j; i++)
                {
                    if (arr[i]>arr[i+1])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[i+1];
                        arr[i+1] = tmp;
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
                arr[i] = Convert.ToInt32(split[i]);
            }

            QuickSort(arr,arr.Length-1,0);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.ReadLine();
        }
    }
}
