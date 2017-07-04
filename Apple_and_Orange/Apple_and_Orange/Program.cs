using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Apple_and_Orange
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] tokens_s = Console.ReadLine().Split(' ');
            int s = Convert.ToInt32(tokens_s[0]);
            int t = Convert.ToInt32(tokens_s[1]);
            string[] tokens_a = Console.ReadLine().Split(' ');
            int a = Convert.ToInt32(tokens_a[0]);
            int b = Convert.ToInt32(tokens_a[1]);
            string[] tokens_m = Console.ReadLine().Split(' ');
            int m = Convert.ToInt32(tokens_m[0]);
            int n = Convert.ToInt32(tokens_m[1]);
            string[] apple_temp = Console.ReadLine().Split(' ');
            int[] apple = Array.ConvertAll(apple_temp, Int32.Parse);
            string[] orange_temp = Console.ReadLine().Split(' ');
            int[] orange = Array.ConvertAll(orange_temp, Int32.Parse);

            int value_apple = 0;
            int value_orange = 0;

            int[] apple_position = new int[apple.Length];
            int[] orange_position = new int[orange.Length];

            for (int i = 0; i < apple_position.Length; i++)
            {
                apple_position[i] = a + apple[i];
            }

            for (int i = 0; i < orange_position.Length; i++)
            {
                orange_position[i] = b + orange[i];
            }

            for (int i = 0; i < apple.Length; i++)
            {
                if (s<=apple_position[i] && apple_position[i]<=t)
                {
                    value_apple = value_apple + 1;
                }
            }
            for (int i = 0; i < orange.Length; i++)
            {
                if (s <= orange_position[i] && orange_position[i] <= t)
                {
                    value_orange = value_orange + 1;
                }
            }
            Console.WriteLine(value_apple);
            Console.WriteLine(value_orange);

            Console.ReadKey();
        }
    }
}
