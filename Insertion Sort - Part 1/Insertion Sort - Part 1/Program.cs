using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Insertion_Sort___Part_1
{
    class Program
    {
        static void BubleSort(int[] arr)
        {
            for (int j = arr.Length-1; 0 < j; j--)
            {
                for (int i = 0; i < arr.Length; i++)
                {
                    Console.Write(arr[i]);
                }
                Console.WriteLine();
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
            BubleSort(arr);

            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.ReadKey();
        }
    }
}
