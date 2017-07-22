using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            //CustomArrayList arrlist1 = new CustomArrayList();
            //arrlist1.Append(21);
            //arrlist1.Append(43);
            //arrlist1.Append(56);
            //arrlist1.Append(89);
            //arrlist1.Append(90);
            //arrlist1.Append(200);
            //arrlist1.Append(21);
            //arrlist1.Append(43);
            //arrlist1.Append(56);
            //arrlist1.Append(89);
            //arrlist1.Append(90);
            //arrlist1.Append(200);
            //arrlist1.Set(5, 201);
            //for (int i = 0; i < arrlist1.size; i++)
            //{
            //    Console.Write(arrlist1.Get(i)+" ");
            //}
            Console.WriteLine("Add First:");

            DynamicLinkedList.LinkedList myList1 = new DynamicLinkedList.LinkedList();

            myList1.AddFirst(1);
            myList1.AddFirst(2);
            myList1.AddFirst(3);
            myList1.printAllNode();
            Console.WriteLine();

            Console.WriteLine("Add Last:");
            DynamicLinkedList.LinkedList myList2 = new DynamicLinkedList.LinkedList();

            myList2.AddLast("Hello");
            myList2.AddLast("Magical");
            myList2.AddLast("World");
            myList2.printAllNode();

            Console.ReadKey();
        }
    }
}
