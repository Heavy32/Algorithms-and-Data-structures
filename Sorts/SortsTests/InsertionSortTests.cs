using NUnit.Framework;
using Sorts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Sorts.Tests
{
    [TestFixture()]
    public class InsertionSortTests
    {
        public int[] MakeRandomArray(int size)
        {
            int[] array = new int[size];
            var rand = new Random();

            for (int i = 0; i < size; i++)
            {
                array[i] = rand.Next(Int32.MinValue, Int32.MaxValue);
            }

            return array;
        }
        [Test()]
        public void InsertionSort50000Test()
        {
            int value = 50000; // 1.7 sec
            var array = MakeRandomArray(value);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            InsertionSort sort = new InsertionSort(array, array.Length);
            stopwatch.Stop();
            TestContext.WriteLine("Insertion sort costs: " + stopwatch.ElapsedMilliseconds + " ms");         
        }

        [Test()]
        public void InsertionSort100000Test()
        {
            int value = 100000; // 6.8 sec
            var array = MakeRandomArray(value);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            InsertionSort sort = new InsertionSort(array, array.Length);
            stopwatch.Stop();
            TestContext.WriteLine("Insertion sort costs: " + stopwatch.ElapsedMilliseconds + " ms");
        }

        [Test()]
        public void InsertionSort150000Test()
        {
            int value = 150000; // 15.4 sec
            var array = MakeRandomArray(value);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            InsertionSort sort = new InsertionSort(array, array.Length);
            stopwatch.Stop();
            TestContext.WriteLine("Insertion sort costs: " + stopwatch.ElapsedMilliseconds + " ms");
        }

        [Test()]
        public void InsertionSort200000Test()
        {
            int value = 200000; // 27.4 sec
            var array = MakeRandomArray(value);
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            InsertionSort sort = new InsertionSort(array, array.Length);
            stopwatch.Stop();
            TestContext.WriteLine("Insertion sort costs: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}