using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{
    class DynamicLinkedList
    {
        public class Node
        {
            public Node next;
            public object data;
        }
        public class LinkedList
        {
            private Node head;
            public void printAllNode()
            {
                Node current = head;
                while (current != null)
                {
                    Console.WriteLine(current.data);
                    current = current.next;
                }
            }
            public void AddFirst(Object data)
            {
                Node toAdd = new Node();

                toAdd.data = data;
                toAdd.next = head;

                head = toAdd;
            }
            public void AddLast(Object data)
            {
                if (head==null)
                {
                    head = new Node();

                    head.data = data;
                    head.next = null;
                }
                else
                {
                    Node toAdd = new Node();
                    toAdd.data = data;

                    Node current = head;
                    while (current.next!=null)
                    {
                        current = current.next;
                    }
                    current.next = toAdd;
                }
            }
        }
    }
}
