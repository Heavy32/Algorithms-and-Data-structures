using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms_and_Data_structures
{
    public class LinkedStackOfStrings
    {
        private Node first = null;
        public class Node
        {
            public string item;
            public Node next;
        }

        public bool IsEmpty() =>
           first == null; 
        public void Push(string item)
        {
            Node oldfirst = first;
            first = new Node();
            first.item = item;
            first.next = oldfirst;
        }
        public string Pop()
        {
            string item = first.item;
            first = first.next;
            return item;
        }
    }
}
