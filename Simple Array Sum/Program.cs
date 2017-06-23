using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
class Program
{
    /// <summary>
    ////Given an array of  integers, can you find the sum of its elements?

    ////Input Format

    //// The first line contains an integer, , denoting the size of the array.
    ////The second line contains  space-separated integers representing the array's elements.

    //// Output Format

    ////Print the sum of the array's elements as a single integer.

    ////Sample Input

    //// 6
    //// 1 2 3 4 10 11
    //// Sample Output

    //// 31
    static int simpleArraySum(int n, int[] ar)
    {
        int index = 0;
        int value = 0;
        while (n > index)
        {
            value = value + ar[index];
            index++;
        }
        return value;
    }

    static void Main(String[] args)
    {
        int n = Convert.ToInt32(Console.ReadLine());
        string[] ar_temp = Console.ReadLine().Split(' ');
        int[] ar = Array.ConvertAll(ar_temp, Int32.Parse);
        int result = simpleArraySum(n, ar);
        Console.WriteLine(result);
        Console.ReadKey();
    }
}