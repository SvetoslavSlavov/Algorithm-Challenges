using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace A_Very_Big_Sum
{
    /// <summary>
    /// You are given an array of integers of size . You need to print the sum of the elements in the array, keeping in mind that some of those integers may be quite large.

    //// Input Format

    //// The first line of the input consists of an integer.The next line contains space-separated integers contained in the array.

    //// Output Format

    //// Print a single value equal to the sum of the elements in the array.

    //// Constraints


    //// Sample Input

    //// 5
    //// 1000000001 1000000002 1000000003 1000000004 1000000005
    //// Output

    //// 5000000015
    //// Note:

    //// The range of the 32-bit integer is .
    //// When we add several integer values, the resulting sum might exceed the above range. You might need to use long long int in C/C++ or long data type in Java to store such sums.
    /// </summary>
    class Program
    {
        static long aVeryBigSum(int n, long[] ar)
        {
            long value = 0;
            // Complete this function
            for (int i = 0; i < ar.Length; i++)
            {
                value += ar[i];
            }
            return value;
        }

        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            long[] ar = Array.ConvertAll(ar_temp, Int64.Parse);
            long result = aVeryBigSum(n, ar);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
