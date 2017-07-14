using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList___2
{
    class CustomArrayList
    {
        private int[] items = new int[8];
        private int size = 0;

        public int Get(int index)
        {
            if (index<0||index>=size)
            {
                throw new IndexOutOfRangeException(index.ToString());
            }
            return items[index];
        }
        public void Set(int item, int index)
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException(index.ToString());
            }
            items[index] = item;
        }
        public void Append(int item)
        {
            EnsureExtreCapacity();
            items[size] = item;
            size++;
        }
        private void EnsureExtreCapacity()
        {
            if (size==items.Length)
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
}
