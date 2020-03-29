using System;
using System.Collections.Generic;
using System.Text;

namespace AlgoritmsAndDatastructures
{
    public class FixedCapacityStackOfStrings
    {
        private string[] s;
        private int N = 0;

        public FixedCapacityStackOfStrings(int capacity)
        {
            s = new string[capacity];
        }

        public bool isEmpty() =>
           N == 0; 

        public void push(string item)
        {
            s[N++] = item;
        }

        public string pop() =>
           s[--N]; 
    }
}
