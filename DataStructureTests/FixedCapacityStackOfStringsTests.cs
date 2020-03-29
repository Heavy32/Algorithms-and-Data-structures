using NUnit.Framework;
using AlgoritmsAndDatastructures;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace AlgoritmsAndDatastructures.Tests
{
    [TestFixture()]
    public class FixedCapacityStackOfStringsTests
    {
        static int maxValue = 50000000;

        FixedCapacityStackOfStrings stack = new FixedCapacityStackOfStrings(maxValue);

        private void StachFilling()
        {
            for (int i = 0; i < maxValue; i++)
            {
                stack.push(i.ToString());
            }
        }

        [Test()]
        public void isEmptyTest()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stack.isEmpty();
            stopwatch.Stop();
            TestContext.WriteLine("FixedCapacityStackOfStrings isEmpty costs: " + stopwatch.ElapsedMilliseconds.ToString() + " ms");
        }

        [Test()]
        public void pushTest()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            StachFilling();
            stopwatch.Stop();
            TestContext.WriteLine("FixedCapacityStackOfStrings push costs: " + stopwatch.ElapsedMilliseconds.ToString() + " ms");
        }

        [Test()]
        public void popTest()
        {
            StachFilling();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < maxValue; i++)
            {
                stack.pop();
            }
            stopwatch.Stop();
            TestContext.WriteLine("FixedCapacityStackOfStrings pop costs: " + stopwatch.ElapsedMilliseconds.ToString() + " ms");
        }
    }
}