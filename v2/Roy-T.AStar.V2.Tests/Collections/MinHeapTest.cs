﻿using NUnit.Framework;

namespace Roy_T.AStar.V2.Tests.Collections
{
    public sealed class MinHeapTest
    {
        [Test]
        public void ShouldSort__ReserveSortedInput()
        {
            var heap = new MinHeap<MinHeapNode>();

            heap.Insert(new MinHeapNode(null, null, null, Duration.FromSeconds(0), Duration.FromSeconds(5)));
            heap.Insert(new MinHeapNode(null, null, null, Duration.FromSeconds(0), Duration.FromSeconds(4)));
            heap.Insert(new MinHeapNode(null, null, null, Duration.FromSeconds(0), Duration.FromSeconds(3)));
            heap.Insert(new MinHeapNode(null, null, null, Duration.FromSeconds(0), Duration.FromSeconds(2)));
            heap.Insert(new MinHeapNode(null, null, null, Duration.FromSeconds(0), Duration.FromSeconds(1)));

            Assert.That(heap.Peek().ExpectedTotalTime.Seconds, Is.EqualTo(1));
            Assert.That(heap.Extract().ExpectedTotalTime.Seconds, Is.EqualTo(1));

            Assert.That(heap.Peek().ExpectedTotalTime.Seconds, Is.EqualTo(2));
            Assert.That(heap.Extract().ExpectedTotalTime.Seconds, Is.EqualTo(2));

            Assert.That(heap.Peek().ExpectedTotalTime.Seconds, Is.EqualTo(3));
            Assert.That(heap.Extract().ExpectedTotalTime.Seconds, Is.EqualTo(3));

            Assert.That(heap.Peek().ExpectedTotalTime.Seconds, Is.EqualTo(4));
            Assert.That(heap.Extract().ExpectedTotalTime.Seconds, Is.EqualTo(4));

            Assert.That(heap.Peek().ExpectedTotalTime.Seconds, Is.EqualTo(5));
            Assert.That(heap.Extract().ExpectedTotalTime.Seconds, Is.EqualTo(5));
        }

        [Test]
        public void ShouldSort__SortedInput()
        {
            var heap = new MinHeap<MinHeapNode>();
            heap.Insert(new MinHeapNode(null, null, null, Duration.FromSeconds(0), Duration.FromSeconds(1)));
            heap.Insert(new MinHeapNode(null, null, null, Duration.FromSeconds(0), Duration.FromSeconds(2)));
            heap.Insert(new MinHeapNode(null, null, null, Duration.FromSeconds(0), Duration.FromSeconds(3)));
            heap.Insert(new MinHeapNode(null, null, null, Duration.FromSeconds(0), Duration.FromSeconds(4)));
            heap.Insert(new MinHeapNode(null, null, null, Duration.FromSeconds(0), Duration.FromSeconds(5)));

            Assert.That(heap.Peek().ExpectedTotalTime.Seconds, Is.EqualTo(1));
            Assert.That(heap.Extract().ExpectedTotalTime.Seconds, Is.EqualTo(1));

            Assert.That(heap.Peek().ExpectedTotalTime.Seconds, Is.EqualTo(2));
            Assert.That(heap.Extract().ExpectedTotalTime.Seconds, Is.EqualTo(2));

            Assert.That(heap.Peek().ExpectedTotalTime.Seconds, Is.EqualTo(3));
            Assert.That(heap.Extract().ExpectedTotalTime.Seconds, Is.EqualTo(3));

            Assert.That(heap.Peek().ExpectedTotalTime.Seconds, Is.EqualTo(4));
            Assert.That(heap.Extract().ExpectedTotalTime.Seconds, Is.EqualTo(4));

            Assert.That(heap.Peek().ExpectedTotalTime.Seconds, Is.EqualTo(5));
            Assert.That(heap.Extract().ExpectedTotalTime.Seconds, Is.EqualTo(5));
        }

        [Test]
        public void ShouldSort__UnsortedInput()
        {
            var heap = new MinHeap<MinHeapNode>();
            heap.Insert(new MinHeapNode(null, null, null, Duration.FromSeconds(0), Duration.FromSeconds(3)));
            heap.Insert(new MinHeapNode(null, null, null, Duration.FromSeconds(0), Duration.FromSeconds(2)));
            heap.Insert(new MinHeapNode(null, null, null, Duration.FromSeconds(0), Duration.FromSeconds(1)));
            heap.Insert(new MinHeapNode(null, null, null, Duration.FromSeconds(0), Duration.FromSeconds(5)));
            heap.Insert(new MinHeapNode(null, null, null, Duration.FromSeconds(0), Duration.FromSeconds(4)));

            Assert.That(heap.Peek().ExpectedTotalTime.Seconds, Is.EqualTo(1));
            Assert.That(heap.Extract().ExpectedTotalTime.Seconds, Is.EqualTo(1));

            Assert.That(heap.Peek().ExpectedTotalTime.Seconds, Is.EqualTo(2));
            Assert.That(heap.Extract().ExpectedTotalTime.Seconds, Is.EqualTo(2));

            Assert.That(heap.Peek().ExpectedTotalTime.Seconds, Is.EqualTo(3));
            Assert.That(heap.Extract().ExpectedTotalTime.Seconds, Is.EqualTo(3));

            Assert.That(heap.Peek().ExpectedTotalTime.Seconds, Is.EqualTo(4));
            Assert.That(heap.Extract().ExpectedTotalTime.Seconds, Is.EqualTo(4));

            Assert.That(heap.Peek().ExpectedTotalTime.Seconds, Is.EqualTo(5));
            Assert.That(heap.Extract().ExpectedTotalTime.Seconds, Is.EqualTo(5));
        }
    }
}
