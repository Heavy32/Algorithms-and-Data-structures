using NUnit.Framework;
using SortsTests;
using System;
using System.Diagnostics;

namespace Sorts.Tests
{
    [TestFixture()]
    public class ShellSortTests
    {
        [Test]
        public void ShellSort1000RandomElementsFromFile()
        {
            var array = ArraysForSortTests.Get1000ArrayElementsFromFile();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            ShellSort sort = new ShellSort(array);
            stopwatch.Stop();
            TestContext.WriteLine("Shell Sort costs: " + stopwatch.ElapsedMilliseconds + " ms");
        }

        [Test]
        public void ShellSort50RandomElements()
        {
            var array = ArraysForSortTests.Get50ArrayElements();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            InsertionSort sort = new InsertionSort(array);
            stopwatch.Stop();
            TestContext.WriteLine("Shell Sort costs: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}