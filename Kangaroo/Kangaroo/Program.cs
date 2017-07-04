using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kangaroo
{
    class Program
    {
        static string kangaroo(int x1, int v1, int x2, int v2)
        {
            // Complete this function
            string result;
            //if ((x2>x1 && v2>v1)||(x1>x2&&v1>v2))
            //{
            //    result = "NO";
            //}
            //else if((x2 > x1 + 5 || v2 > v1 + 5) || (x1 > x2 + 5 || v1 > v2 + 5))
            //{
            //    result = "NO";
            //}
            //x2-x1 % v1-v2 this basically checks if 
            //the diff in the inital lead (x2-x1) can be made 
            if (v1 > v2 && ((x2 - x1) % (v1 - v2) == 0))
            {
                result = "YES";
            }
            else
            {
                result = "NO";
            }
            return result;
        }
        static void Main(string[] args)
        {
            string[] tokens_x1 = Console.ReadLine().Split(' ');
            int x1 = Convert.ToInt32(tokens_x1[0]);
            int v1 = Convert.ToInt32(tokens_x1[1]);
            int x2 = Convert.ToInt32(tokens_x1[2]);
            int v2 = Convert.ToInt32(tokens_x1[3]);
            string result = kangaroo(x1, v1, x2, v2);
            Console.WriteLine(result);
            Console.ReadKey();
        }
    }
}
