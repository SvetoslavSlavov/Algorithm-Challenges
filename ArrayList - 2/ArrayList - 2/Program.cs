using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList___2
{
    class Program
    {
        static void Main(string[] args)
        {
            CustomArrayList arrlist = new CustomArrayList();
            arrlist.Append(15);
            arrlist.Append(5);
            arrlist.Append(25);
            arrlist.Append(12);
            arrlist.Append(32);
            arrlist.Append(23);
            arrlist.Append(9);

            arrlist.Set(0, 1);

            for (int i = 0; i < arrlist.Size(); i++)
            {
                Console.Write(arrlist.Get(i)+" ");
            }
            Console.ReadKey();
        }
    }
}
