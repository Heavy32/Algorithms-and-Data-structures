using NUnit.Framework;
using Sorts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Sorts.Tests
{
    [TestFixture()]
    public class ShellSortTests
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
        public void ShellSort50000Test()
        {
            int value = 50000; // 17 ms
            var array = MakeRandomArray(value);
            ShellSort sort = new ShellSort();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            sort.ShellSortImplement(array);
            stopwatch.Stop();
            TestContext.WriteLine("Shell sort costs: " + stopwatch.ElapsedMilliseconds + " ms");
        }

        [Test()]
        public void ShellSort100000Test()
        {
            int value = 100000; // 33 ms
            var array = MakeRandomArray(value);
            ShellSort sort = new ShellSort();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            sort.ShellSortImplement(array);
            stopwatch.Stop();
            TestContext.WriteLine("Shell sort costs: " + stopwatch.ElapsedMilliseconds + " ms");
        }

        [Test()]
        public void ShellSort200000Test()
        {
            int value = 200000; // 70 ms
            var array = MakeRandomArray(value);
            ShellSort sort = new ShellSort();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            sort.ShellSortImplement(array);
            stopwatch.Stop();
            TestContext.WriteLine("Shell sort costs: " + stopwatch.ElapsedMilliseconds + " ms");
        }

        [Test()]
        public void ShellSort100000000Test()
        {
            int value = 100000000; // 88 sec
            var array = MakeRandomArray(value);
            ShellSort sort = new ShellSort();

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            sort.ShellSortImplement(array);
            stopwatch.Stop();
            TestContext.WriteLine("Shell sort costs: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}