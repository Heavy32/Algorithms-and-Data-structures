﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Sorts
{
    public class InsertionSort
    {
        public InsertionSort(int[] arr)
        {
            int i, key, j;
            for (i = 1; i < arr.Length; i++)
            {
                key = arr[i];
                j = i - 1;

                while (j >= 0 && arr[j] > key)
                {
                    arr[j + 1] = arr[j];
                    j = j - 1;
                }
                arr[j + 1] = key;
            }
        }
    }
}
