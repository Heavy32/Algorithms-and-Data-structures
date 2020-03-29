using NUnit.Framework;
using AlgoritmsAndDatastructures;
using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace AlgoritmsAndDatastructures.Tests
{
    [TestFixture()]
    public class ResizedArrayTests
    {
        static int maxValue = 50000000;

        ResizedArray array = new ResizedArray();

        [Test()]
        public void PushTest()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            for (int i = 0; i < 50000000; i++)
            {
                array.Push(i.ToString());
            }
            stopwatch.Stop();
            TestContext.WriteLine("ResizedArray Push costs: " + stopwatch.ElapsedMilliseconds.ToString() + " ms");
        }
    }
}