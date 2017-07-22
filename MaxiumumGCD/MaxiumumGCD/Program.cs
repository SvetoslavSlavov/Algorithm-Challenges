using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Numerics;
namespace MaxiumumGCD
{
    class Program
    {
        static int GcdNumbers(int a, int b)
        {
            return b == 0 ? a : GCD(b, a % b);
        }
        static int GCD(int a, int b)
        {
            int b1 = a;
            int b2 = b;
            int gcd = GcdNumbers(b1,b2);
            return gcd;
        }
        static int MaximumGcd(int[] arr1, int[] arr2)
        {
            Array.Sort(arr1);
            Array.Sort(arr2);
            int temp = 0;
            for (int i = arr1.Length - 1; i >= 0; i--)
            {
                for (int j = arr2.Length - 1; j >= 0; j--)
                {
                    int tempGcd = GCD(arr1[i], arr2[j]);
                    if (tempGcd > temp)
                    {
                        temp = tempGcd;
                    }
                }
            }
            return temp+temp;
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
            Console.WriteLine(MaximumGcd(arr1, arr2));

            Console.ReadKey();
        }
    }
}
