using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLeft_Rotation
{
    class CustomArray
    {
        private int[] items = new int[8];
        private int size = 0;

        public int Get(int index)
        {
            if (index>=size || index<0)
            {
                throw new IndexOutOfRangeException(index.ToString());
            }
            return items[index];
        }
        public void Set(int item,int index)
        {
            if (index >= size || index < 0)
            {
                throw new IndexOutOfRangeException(index.ToString());
            }
            items[index] = item;
        }
        public int Append(int item)
        {
            EnsureExtraArray();
            items[size] = item;
            size++;
            return item;
        }
        public void EnsureExtraArray()
        {
            if (items.Length==size)
            {
                int[] copy = new int[size * 2];
                Array.Copy(items, 0, copy, 0, size);
                items = copy;
            }
        }
        public int Size()
        {
            return size;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            //string[] tokens_n = Console.ReadLine().Split(' ');
            //int n = Convert.ToInt32(tokens_n[0]);
            //int k = Convert.ToInt32(tokens_n[1]);
            //string[] a_temp = Console.ReadLine().Split(' ');
            //int[] a = Array.ConvertAll(a_temp, Int32.Parse);
            
            //string[] values = Console.ReadLine().Split(' ');
            //int n = int.Parse(values[0]);
            //int k = int.Parse(values[1]);
            //string[] arr = Console.ReadLine().Split(' ');
            //int[] a = Array.ConvertAll(arr, Int32.Parse);

            CustomArray arr1 = new CustomArray();
            arr1.Append(2);
            arr1.Append(3);
            arr1.Append(4);
            arr1.Append(4);
            arr1.Append(12);

            for (int i = 0; i < arr1.Size(); i++)
            {
                Console.Write(arr1.Get(i)+" ");
            }
            Console.ReadKey();
        }
        
        }
    }

