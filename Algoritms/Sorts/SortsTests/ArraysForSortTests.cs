using System;
using System.Linq;
using System.IO;

namespace SortsTests
{
    public static class ArraysForSortTests
    {
        public static int[] Get1000ArrayElementsFromFile() =>
            File.OpenText("1000RandomElements.txt").ReadLine().Split(' ').Select(x => Convert.ToInt32(x)).ToArray();
    
        public static int[] Get50ArrayElements() =>
            new int[] {5, 4, 7, 1, 67, 345, 23, 45, 87, 54,
                       0, 78, 56, 65, 567, 7567, 11234, 4563, -3456, -111,
                       -54657, -7567389, 75734893, 7658, -91123, 981827, -912345, -776454, 1123123, -234234234,
                       9, 23421346, -234523, -45674, -12341234, -9376576, -7458348, -734756, 191, -7656893,
                       3456, 111233, -192837, -3945, 902349, -111230, 9549, -134865, 9012378, -3};
    }
}
