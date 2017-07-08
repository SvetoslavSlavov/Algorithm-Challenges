using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace birthdayCakeCandles
{
    class Program
    {
        
        static void Main(string[] args)
        {
            int n = Convert.ToInt32(Console.ReadLine());
            string[] ar_temp = Console.ReadLine().Split(' ');
            int[] height = Array.ConvertAll(ar_temp, Int32.Parse);
            int tallest = 0;
            int frequency = 0;

            for (int i = 0; i < n; i++)
            {
                // height[i] = int.Parse(Console.ReadLine());

                if (height[i]>tallest)
                {
                    tallest = height[i];
                    frequency = 1;
                }
                else if (height[i]==tallest)
                {
                    frequency++;
                }
            }
            Console.WriteLine(frequency);
            Console.ReadLine();
        }
    }
}
