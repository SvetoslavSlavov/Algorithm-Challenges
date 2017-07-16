using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HashTableTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, double> studentmarks = new Dictionary<string, double>();

            studentmarks.Add("Pesho", 6);
            studentmarks.Add("Vlado", 2);
            studentmarks.Add("Rado", 4.50);
            studentmarks.Add("Ilian", 3.34);
            studentmarks.Add("Jivko", 5.70);

            // Acquire keys and sort them.
            var list = studentmarks.Keys.ToList();
            list.Sort();

            // Loop through keys.
            foreach (var key in list)
            {
                Console.WriteLine("{0}: {1}", key, studentmarks[key]);
            }

            if (studentmarks.ContainsKey("Rado"))
            {
                double value = studentmarks["Rado"];
                Console.WriteLine(value);
            }

            Console.ReadKey();
        }
    }
}
