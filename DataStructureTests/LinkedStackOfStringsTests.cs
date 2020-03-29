using NUnit.Framework;
using AlgoritmsAndDatastructures;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace AlgoritmsAndDatastructures.Tests
{
    [TestFixture()]
    public class LinkedStackOfStringsTests
    {
        static int maxValue = 50000000;

        LinkedStackOfStrings stack = new LinkedStackOfStrings();

        private void QueueFilling()
        {
            for (int i = 0; i < maxValue; i++)
            {
                stack.Push(i.ToString());
            }
        }

        private void QueueDeque()
        {
            for (int i = 0; i < maxValue; i++)
            {
                stack.Pop();
            }
        }

        [Test]
        public void IsEmptyTest()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            stack.IsEmpty();
            stopwatch.Stop();
            TestContext.WriteLine("LinkedStackOfStrings isEmpty costs: " + stopwatch.ElapsedMilliseconds.ToString() + " ms");
        }

        [Test()]
        public void PushTest()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            QueueFilling();
            stopwatch.Stop();
            TestContext.WriteLine("LinkedStackOfStrings Push costs: " + stopwatch.ElapsedMilliseconds.ToString() + " ms");
        }

        [Test()]
        public void PopTest()
        {
            QueueFilling();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            QueueDeque();
            stopwatch.Stop();
            TestContext.WriteLine("LinkedStackOfStrings Pop costs: " + stopwatch.ElapsedMilliseconds.ToString() + " ms");
        }
    }
}