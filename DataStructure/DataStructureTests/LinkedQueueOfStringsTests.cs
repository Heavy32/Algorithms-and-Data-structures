using NUnit.Framework;
using System.Diagnostics;

namespace AlgoritmsAndDatastructures.Tests
{
    [TestFixture()]
    public class LinkedQueueOfStringsTests
    {
        static int maxValue = 50000000;

        LinkedQueueOfStrings queue = new LinkedQueueOfStrings();

        private void QueueFilling()
        {
            for (int i = 0; i < maxValue; i++)
            {
                queue.Enqueue(i.ToString());
            }
        }

        private void QueueDeque()
        {
            for (int i = 0; i < maxValue; i++)
            {
                queue.Dequeue();
            }
        }

        [Test]
        public void IsEmptyTest()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            queue.IsEmpty();
            stopwatch.Stop();
            TestContext.WriteLine("LinkedQueueOfStrings isEmpty costs: " + stopwatch.ElapsedMilliseconds.ToString() + " ms");
        }

        [Test()]
        public void EnqueueTest()
        {
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            QueueFilling();
            stopwatch.Stop();
            TestContext.WriteLine("LinkedQueueOfStrings Enqueue costs: " + stopwatch.ElapsedMilliseconds.ToString() + " ms");
        }

        [Test()]
        public void DequeueTest()
        {
            QueueFilling();
            Stopwatch stopwatch = new Stopwatch();
            stopwatch.Start();
            QueueDeque();
            stopwatch.Stop();
            TestContext.WriteLine("LinkedQueueOfStrings Dequeue costs: " + stopwatch.ElapsedMilliseconds.ToString() + " ms");
        }
    }
}