using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmsAndDatastructures
{
    public class LinkedQueueOfStrings
    {
        private Node first, last;

        public class Node
        {
            public string item;
            public Node next;
        }

        public bool IsEmpty() =>
            first == null; 

        public void Enqueue(string item)
        {
            Node oldlast = last;
            last = new Node();
            last.item = item;
            last.next = null;
            if (IsEmpty())
                first = last;
            else oldlast.next = last;
        }

        public string Dequeue()
        {
            string item = first.item;
            first = first.next;
            if (IsEmpty())
                last = null;
            return item;
        }
    }
}
