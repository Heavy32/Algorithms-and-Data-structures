using NUnit.Framework;
using AlgoritmsAndDatastructures;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace AlgoritmsAndDatastructures.Tests
{
    [TestFixture()]
    public class StackTests
    {
        static int maxValue = 50000000;

        Stack<string> stack = new Stack<string>();

        private void StackFilling()
        {
            for (int i = 0; i < maxValue; i++)
            {
                stack.Push(i.ToString());
            }
        }

        [Test()]
        public void IsEmptyTest()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stack.IsEmpty();
            stopwatch.Stop();
            TestContext.WriteLine("FixedCapacityStackOfStrings isEmpty costs: " + stopwatch.ElapsedMilliseconds.ToString() + " ms");
        }

        [Test()]
        public void pushTest()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            StackFilling();
            stopwatch.Stop();
            TestContext.WriteLine("FixedCapacityStackOfStrings push costs: " + stopwatch.ElapsedMilliseconds.ToString() + " ms");
        }

        [Test()]
        public void popTest()
        {
            StackFilling();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < maxValue; i++)
            {
                stack.Pop();
            }
            stopwatch.Stop();
            TestContext.WriteLine("FixedCapacityStackOfStrings pop costs: " + stopwatch.ElapsedMilliseconds.ToString() + " ms");
        }
    }
}