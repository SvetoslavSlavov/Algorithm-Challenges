using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLeftRotation
{
    class Program
    {
        static string Rotation(int root,int[] arr)
        {
            string left = string.Join(
                " ", arr.Take(root).ToArray());

            string right = string.Join(
                " ", arr.Skip(root).ToArray());
            return right + " " + left;
        }
        static void Main(string[] args)
        {
            string[] tokens_n = Console.ReadLine().Split(' ');
            int n = Convert.ToInt32(tokens_n[0]);
            int k = Convert.ToInt32(tokens_n[1]);
            string[] a_temp = Console.ReadLine().Split(' ');
            int[] a = Array.ConvertAll(a_temp, Int32.Parse);

            // rotate and return as string
            string result = Rotation(k, a);
            // print result        
            Console.WriteLine(result);

            Console.ReadKey();
        }
    }
}
