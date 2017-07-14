using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList___1
{
    class CustomArrayList
    {
        // Hard coded need fix
        private int[] items = new int[8];
        private int size = 0;


        public int Size()
        {
            return this.size;
        }
        // Gets the item 
        public int Get(int index)
        {
            if (index < 0 || index >= size)
            {
                throw new IndexOutOfRangeException(index.ToString());
            }
            return items[index];
        }
        // Index and item to add
        //public void Set(int index, int item)
        //{
        //    if (index < 0 || index >= size)
        //    {
        //        throw new IndexOutOfRangeException(index.ToString());
        //    }
        //    items[index] = item;
        //}
        // Add the element to the end of the list
        public void Append(int item)
        {
            EnsureExtraCapacity();
            items[size] = item;
            size++;
        }
        private void EnsureExtraCapacity()
        {
            if (size==items.Length)
            {
                // twice the size of the items array
                int[] copy = new int[size * 2];
                // Copies the elements into new array
                Array.Copy(items,0, copy,0, size);
                // items should point to copy 
                items = copy;
            }
        }
        
    }
}
