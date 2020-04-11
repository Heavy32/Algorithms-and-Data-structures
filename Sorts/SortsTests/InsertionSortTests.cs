using NUnit.Framework;
using SortsTests;
using System;
using System.Diagnostics;
using System.IO;
using System.Linq;

namespace Sorts.Tests
{
    [TestFixture]
    public class InsertionSortTests
    {
        [Test]
        public void InsertionSort1000RandomElementsFromFile()
        {
            var array = ArraysForSortTests.Get1000ArrayElementsFromFile();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            InsertionSort sort = new InsertionSort(array);
            stopwatch.Stop();
            TestContext.WriteLine("Insertion sort costs: " + stopwatch.ElapsedMilliseconds + " ms");
        }

        [Test]
        public void InsertionSort50RandomElements()
        {
            var array = ArraysForSortTests.Get50ArrayElements();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            InsertionSort sort = new InsertionSort(array);
            stopwatch.Stop();
            TestContext.WriteLine("Insertion sort costs: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}