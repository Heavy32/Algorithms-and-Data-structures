using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms_and_Data_structures
{
    class ResizedArray
    {
        string[] s;
        int N;
        public ResizedArray()
        { 
            s = new string[1];
        }
        public void Push(string item)
        {
            if (N == s.Length) 
                Resize(2 * s.Length);
            s[N++] = item;
        }
        private void Resize(int capacity)
        {
            string[] copy = new string[capacity];
            for (int i = 0; i < N; i++)
                copy[i] = s[i];
            s = copy;
        }
    }
}
