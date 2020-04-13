using NUnit.Framework;
using SortsTests;
using System.Diagnostics;

namespace Sorts.Tests
{
    [TestFixture()]
    public class SelectionSortTests
    {
        [Test]
        public void SelectionSort1000ArrayElementsFromFile()
        {
            var array = ArraysForSortTests.Get1000ArrayElementsFromFile();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            SelectionSort sort = new SelectionSort(array);
            stopwatch.Stop();
            TestContext.WriteLine("Selection sort costs: " + stopwatch.ElapsedMilliseconds + " ms");
        }

        [Test]
        public void SelectionSort5000ArrayElementsFromFile()
        {
            var array = ArraysForSortTests.Get50ArrayElements();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            SelectionSort sort = new SelectionSort(array);
            stopwatch.Stop();
            TestContext.WriteLine("Selection sort costs: " + stopwatch.ElapsedMilliseconds + " ms");
        }
    }
}