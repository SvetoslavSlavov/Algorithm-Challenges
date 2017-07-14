using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArraysLeft_Rotation
{
    class CustomArrayList
    {
        private int[] items = new int[8];
        private int size = 0;

        public int Get(int index)
        {
            if (index<0&&index>=items.Length)
            {
                throw new StackOverflowException(index.ToString());
            }
            return items[index];
        }
        public void Set(int index,int item)
        {
            if (index < 0 && index >= items.Length)
            {
                throw new StackOverflowException(index.ToString());
            }
            items[index] = item;
        }
        public int Size()
        {
            return size;
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
