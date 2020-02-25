using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms_and_Data_structures
{
    public class Stack<Item>
    {
        private Node first = null;
        public class Node
        {
            public Item item;
            public Node next;
        }

        public bool IsEmpty() =>
            first == null; 
        public void Push(Item item)
        {
            Node oldfirst = first;
            first = new Node();
            first.item = item;
            first.next = oldfirst;
        }
        public Item Pop()
        {
            Item item = first.item;
            first = first.next;
            return item;
        }
    }
}
