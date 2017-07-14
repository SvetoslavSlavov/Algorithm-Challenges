using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLeftRotation
{
    class CustomArrayList
    {
        private int[] items = new int[8];
        private int size = 0;

        public int Size()
        {
            return size;
        }
        public int Get(int index)
        {
            if (index<0&&index>=size)
            {
                throw new StackOverflowException(items.ToString());
            }
            return items[index];
        }
        public void Set(int index,int item)
        {
            items[index] = item;
        }
        public void Append(int item)
        {
            Resize();
            items[size] = item;
            size++;
        }
        public void Resize()
        {
            if (size==items.Length)
            {
                int[] copy = new int[size * 2];
                Array.Copy(items, 0, copy, 0, size);
                items = copy;
            }
        }
    }
}
