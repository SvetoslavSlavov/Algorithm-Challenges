using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BubleExercise
{
    class Program
    {
        static void BubleSort(int[]arr,int left,int right)
        {
            //Input: 3 1 2 Output: 2 1 3
            int i = left;
            int j = right;

            for (;  j> 0; j--)
            {
                for (; i < j; i++)
                {
                    if (arr[i]>arr[i+1])
                    {
                        int tmp = arr[i];
                        arr[i] = arr[j];
                        arr[j] = tmp;
                    }
                }
            }
        }
        static void Main(string[] args)
        {
            int size = Convert.ToInt32(Console.ReadLine());
            int[] ar = new int[size];
            string elements = Console.ReadLine();
            string[] split = elements.Split(' ');

            for (int i = 0; i < size; i++)
            {
                ar[i]=Convert.ToInt32(split[i]);
            }
            BubleSort(ar,0,size-1);
            for (int i = 0; i < size; i++)
            {
                Console.Write(ar[i]+" ");
            }
            
            Console.ReadKey();
        }
    }
}
