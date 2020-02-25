using System;
using System.Collections.Generic;
using System.Text;

namespace Algoritms_and_Data_structures
{
    class WeightedQuickUnion
    {
        private int[] id;
        private int[] sz;
        public WeightedQuickUnion(int N) // set id of each object to itself (N array accesses)
        {
            id = new int[N];
            sz = new int[N];
            for (int i = 0; i < N; i++)
            {
                id[i] = i;
                sz[i] = i;
            }
        }
        private int Root(int i) // chase parent pointers until reach root (depth of i array accesses)
        {
            while (i != id[i])
            {
                //id[i] = id[id[i]]; path compression
                i = id[i];
            }
            return i;
        }
        public bool Connected(int p, int q) //check if p and q have same root (depth of p and q array accesses)
        {
            return Root(p) == Root(q);
        }
        public void Union(int p, int q)
        {
            int i = Root(p);
            int j = Root(q);
            if (i == j) return;
            if (sz[i] < sz[j]) { id[i] = j; sz[j] += sz[i]; }
            else { id[j] = i; sz[i] += sz[j]; }
            id[i] = j;
        }
    }


}
