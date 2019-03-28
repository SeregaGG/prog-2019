using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HashTable.Tests
{
    [TestClass]
    public class HashTableTests
    {
        [TestMethod]
        public void AddSearch3Elements()
        {
            var HashTable = new HashTable(3);
            for (int i = 0; i < 3; i++)
            {
                HashTable.PutPair(i, i);
            }
            for (int i = 0; i < 3; i++)
            {
                Assert.AreEqual(i, HashTable.GetValueByKey(i));
            }
        }

        [TestMethod]
        public void AddTwice()
        {
            var HashTable = new HashTable(2);
            HashTable.PutPair(0, 235);
            HashTable.PutPair(0, 523);
            Assert.AreEqual(523, HashTable.GetValueByKey(0));
        }

        [TestMethod]
        public void Add10000SearchOne()
        {
            var HashTable = new HashTable(10000);
            for (int i = 0; i < 10000; i++)
            {
                HashTable.PutPair(i, i);
            }
            Assert.AreEqual(42, HashTable.GetValueByKey(42));
        }

        [TestMethod]
        public void Add10000SearchNull()
        {
            var HashTable = new HashTable(10000);
            for (int i = 0; i < 10000; i++)
            {
                HashTable.PutPair(i, i);
            }
            for (int j = 10000; j < 11000; j++)
            {
                Assert.AreEqual(null, HashTable.GetValueByKey(j));
            }
        }
    }
}
