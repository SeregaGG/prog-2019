using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace QuickSort.Tests
{
    [TestClass]
    public class QuickSortTests
    {
        public void CheckSort(int[] array)
        {
            for (int i = 0; i < array.Length - 1; i++)
                Assert.IsTrue(array[i] <= array[i + 1]);
        }
        public void CheckThousandSort(int[] array)
        {
            var rnd = new Random();
            for (int i = 0; i < 10; i++)
            {
                int a = rnd.Next(0, 1000);
                int b = rnd.Next(0, 1000);
                if (a >= b)
                    Assert.IsTrue(array[a] >= array[b]);
                if (a <= b)
                    Assert.IsTrue(array[a] <= array[b]);
            }
        }
        [TestMethod]
        public void ThreeElements()
        {
            int[] array = new int[3];
            var rnd = new Random();
            for (var i = 0; i < array.Length; i++)
                array[i] = rnd.Next(-100, 100);
            Sort.QuickSort(array);
            CheckSort(array);
        }
        [TestMethod]
        public void EqualNumber100()
        {
            int[] array = new int[100];
            var rnd = new Random();
            array[0] = rnd.Next(-100, 100);
            for (var i = 1; i < array.Length; i++)
                array[i] = array[0];
            Sort.QuickSort(array);
            CheckSort(array);
        }
        [TestMethod]
        public void OrderedCouple20()
        {
            int[] array = new int[1000];
            var rnd = new Random();
            for (var i = 0; i < array.Length; i++)
                array[i] = rnd.Next(-100, 100);
            Sort.QuickSort(array);
            CheckThousandSort(array);
        }
        [TestMethod]
        public void EmptyArray()
        {
            int[] array = new int[0];
            Sort.QuickSort(array);
            Assert.IsTrue(array.Length == 0);
        }
        [TestMethod]
        public void BillionElements()
        {
            int[] array = new int[200000000];
            var rnd = new Random();
            for (var i = 0; i < array.Length; i++)
                array[i] = rnd.Next(int.MinValue, int.MaxValue);
            Sort.QuickSort(array);
            CheckSort(array);
        }
    }
}
