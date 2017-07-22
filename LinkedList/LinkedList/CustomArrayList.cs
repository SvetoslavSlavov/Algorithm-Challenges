using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class CustomArrayList
    {
        public int[] items = new int[8];
        public int size = 0;

        public int Size()
        {
            return size;
        }
        public int Get(int index)
        {
            if (index==items.Length||index<0)
            {
                throw new IndexOutOfRangeException();
            }
            return items[index];
        }
        public void Set(int index,int item)
        {
            if (index == items.Length || index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            items[index] = item;
        }
        public void Append(int item)
        {
            CheckSize();
            items[size] = item;
            size++;
        }
        public void CheckSize()
        {
            if (items.Length==size)
            {
                int[] copy = new int[items.Length*2];
                Array.Copy(items, 0, copy, 0,items.Length);
                items = copy;
            }
        }
    }
}
