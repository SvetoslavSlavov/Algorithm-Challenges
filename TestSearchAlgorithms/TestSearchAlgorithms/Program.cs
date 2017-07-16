using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSearchAlgorithms
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 20, 1, 2, 12 };

            // Buble Sort
            //for (int j = arr.Length-1; j > 0; j--)
            //{
            //    for (int i = 0; i < j; i++)
            //    {
            //        if (arr[i]>arr[i+1])
            //        {
            //            int tmp = arr[i];
            //            arr[i] = arr[i + 1];
            //            arr[i + 1] = tmp;
            //        }
            //    }
            //}

            // Inserion Sort
            //for (int j = 1; j < arr.Length; j++)
            //{
            //    for (int i = j; i > 0 && arr[i-1] > arr[i]; i--)
            //    {
            //        int tmp = arr[i];
            //        arr[i] = arr[i - 1];
            //        arr[i - 1] = tmp;
            //    }
            //}

            CustomArrayList ArrList = new CustomArrayList();
            ArrList.Append(22);//0
            ArrList.Append(10);//1
            ArrList.Append(22);//2
            ArrList.Append(80);//3
            ArrList.Append(43);//4
            ArrList.Append(22);//5
            ArrList.Append(10);//6
            ArrList.Append(22);//7
            ArrList.Append(80);//8
            ArrList.Append(43);//9

            for (int i = 0; i < ArrList.Size(); i++)
            {
                Console.Write(ArrList.Get(i)+" ");
            }
            Console.WriteLine();
            for (int i = 0; i < arr.Length; i++)
            {
                Console.Write(arr[i]+" ");
            }
            Console.ReadKey();

        }
    }
}
