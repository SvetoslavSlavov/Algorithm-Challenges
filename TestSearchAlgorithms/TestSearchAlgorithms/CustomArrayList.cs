using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestSearchAlgorithms
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
            if (index >= size && index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            return items[index];
        }
        public void Set(int index,int item)
        {
            if (index >= items.Length && index < 0)
            {
                throw new IndexOutOfRangeException();
            }
            items[index] = item;
        }
        public void Append(int item)
        {
            MakeLarger();
            items[size] = item;
            size++;
        }
        public void MakeLarger()
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
