using System;
using NUnit.Framework;
using AlgoritmsAndDatastructures;
using System.Diagnostics;


namespace FindTests
{
    public class Tests
    {
        static int maxValue = 50000000;
        QuickFind quickFind = new QuickFind(maxValue);
        [Test]
        public void QuickFindMaxValueUnion()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            quickFind.Union(0, maxValue - 1);
            stopwatch.Stop();
            TestContext.WriteLine("QuickFind union costs: " + stopwatch.ElapsedMilliseconds.ToString() + " ms");
        }

        [Test]
        public void QuickFindMaxValueConntected()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            quickFind.Connected(0, maxValue - 1);
            stopwatch.Stop();
            TestContext.WriteLine("QuickFind connected costs: " + stopwatch.ElapsedMilliseconds.ToString() + " ms");
        }


        QuickUnion quickUnion = new QuickUnion(maxValue);

        [Test]
        public void QuickUnionMaxValueUnion()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            quickUnion.Union(0, maxValue - 1);
            stopwatch.Stop();
            TestContext.WriteLine("QuickFind union costs: " + stopwatch.ElapsedMilliseconds.ToString() + " ms");
        }

        [Test]
        public void QuickUnionMaxValueConntected()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            quickUnion.Connected(0, maxValue - 1);
            stopwatch.Stop();
            TestContext.WriteLine("QuickFind connected costs: " + stopwatch.ElapsedMilliseconds.ToString() + " ms");
        }

        WeightedQuickUnion weightedQuickUnion = new WeightedQuickUnion(maxValue);

        [Test]
        public void WeightedQuickUnionMaxValueUnion()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            weightedQuickUnion.Union(0, maxValue - 1);
            stopwatch.Stop();
            TestContext.WriteLine("WeightedQuickUnion union costs: " + stopwatch.ElapsedMilliseconds.ToString() + " ms");
        }

        [Test]
        public void WeightedQuickUnionMaxValueConntected()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            weightedQuickUnion.Connected(0, maxValue - 1);
            stopwatch.Stop();
            TestContext.WriteLine("WeightedQuickUnion connected costs: " + stopwatch.ElapsedMilliseconds.ToString() + " ms");
        }
    }
}