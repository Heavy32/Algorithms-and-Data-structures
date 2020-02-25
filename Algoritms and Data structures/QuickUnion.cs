using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms_and_Data_structures
{
    class QuickUnion
    {
        private int[] id;
        public QuickUnion(int N) // set id of each object to itself (N array accesses)
        {
            id = new int[N];
            for (int i = 0; i < N; i++) id[i] = i;
        }
        private int Root(int i) // chase parent pointers until reach root (depth of i array accesses)
        {
            while (i != id[i]) i = id[i];
            return i;
        }
        public bool Connected(int p, int q) //check if p and q have same root (depth of p and q array accesses)
        {
            return Root(p) == Root(q);
        }
        public void Union(int p, int q)
        {
            int i = Root(p); //change root of p to point to root of q (depth of p and q array accesses)
            int j = Root(q);
            id[i] = j;
        }
    }
}
