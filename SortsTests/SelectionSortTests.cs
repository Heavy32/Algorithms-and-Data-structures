using NUnit.Framework;
using Sorts;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Text;

namespace Sorts.Tests
{
    [TestFixture()]
    public class SelectionSortTests
    {
        [Test]
        public void Sort50000Test()
        {
            int value = 50000; // 3 sec
            SelectionSort sort = new SelectionSort(value);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            sort.Sort();
            stopwatch.Stop();

            TestContext.WriteLine("Selection sort costs: " + stopwatch.ElapsedMilliseconds + " ms");
        }

        [Test]
        public void Sort100000Test()
        {
            int value = 100000; // 13.4 sec
            SelectionSort sort = new SelectionSort(value);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            sort.Sort();
            stopwatch.Stop();

            TestContext.WriteLine("Selection sort costs: " + stopwatch.ElapsedMilliseconds + " ms");
        }

        [Test]
        public void Sort200000Test()
        {
            int value = 200000; // 53.6 sec
            SelectionSort sort = new SelectionSort(value);

            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            sort.Sort();
            stopwatch.Stop();

            TestContext.WriteLine("Selection sort costs: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}