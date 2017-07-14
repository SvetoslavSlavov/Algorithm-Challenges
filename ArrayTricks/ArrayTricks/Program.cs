using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayTricks
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 20, 40, 10, 9, 2 };
            int rot = 2;

            // how much index to take
            string left = string.Join(" ", arr.Take(rot).ToArray());
            // when concatinating the strings skip the element part
            string right = string.Join(" ", arr.Skip(rot).ToArray());


            Console.WriteLine(right + ' ' + left);
            Console.ReadKey();  
        }
    }
}
