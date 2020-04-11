using System;

namespace Sorts
{
    public class SelectionSort
    {
        private int[] data;
        private static Random generator = new Random();

        public SelectionSort(int[] array)
        {
            data = array;
            int smallest;
            for (int i = 0; i < data.Length - 1; i++)
            {
                smallest = i;
                for (int index = i + 1; index < data.Length; index++)
                {
                    if (data[index] < data[smallest])
                    {
                        smallest = index;
                    }
                }
                Swap(i, smallest);
            }
        }

        public void Swap(int first, int second)
        {
            int temporary = data[first];
            data[first] = data[second];
            data[second] = temporary;
        }
    }
}
