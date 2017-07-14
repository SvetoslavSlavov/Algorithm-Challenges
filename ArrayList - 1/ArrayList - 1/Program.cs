using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList___1
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 20, 10, 5, 2, 1 };
            CustomArrayList ArrayList1 = new CustomArrayList();


            ArrayList1.Append(10);
            ArrayList1.Append(29);
            ArrayList1.Append(2);
            ArrayList1.Append(1);
            ArrayList1.Append(20);
            for (int i = 0; i < ArrayList1.Size(); i++)
            {
                Console.Write(ArrayList1.Get(i)+" ");
            }
            Console.ReadKey();
        }
    }
}
