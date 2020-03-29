using System;

namespace AlgoritmsAndDatastructures
{
    public class QuickFind
    {
        private int[] id;

        public QuickFind(int arraySize) //set id of each object to itself (N array accesses)
        {
            id = new int[arraySize];
            for (int i = 0; i < arraySize; i++)
                id[i] = i;
        }


        public Boolean Connected(int firstNumber, int secondNumber) => //check whether firstNumber and secondNumber are in the same component (2array accesses)
            id[firstNumber] == id[secondNumber];


        public void Union(int firstNumber, int secondNumber)
        {
            int firstNumberId = id[firstNumber];
            int secondNumberId = id[secondNumber];
            for (int i = 0; i < id.Length; i++) //change all entries with id[firstNumber] to id[secondNumber] (at most 2N + 2 array accesses)
                if (id[i] == firstNumberId)
                    id[i] = secondNumberId;
        }
    }
}
