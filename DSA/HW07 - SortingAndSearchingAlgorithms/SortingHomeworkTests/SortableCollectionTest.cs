using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingHomework;

namespace SortingHomeworkTests
{
    [TestClass]
    public class SortableCollectionTest
    {
        [TestMethod]
        public void TestLinearSearch_WithExistingItem()
        {
            var collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });

            var result = collection.LinearSearch(11);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestLinearSearch_WithNonExistingItem()
        {
            var collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });

            var result = collection.LinearSearch(12);
            Assert.AreNotEqual(true, result);
        }

        [TestMethod]
        public void TestLinearSearch_WithMatchingItemOfDifferentType()
        {
            var collection = new SortableCollection<double>(new[] { 22d, 11.0d, 101d, 33d, 0d, 101d });

            var result = collection.LinearSearch(11u);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestBinarySearch_WithExistingItem()
        {
            var collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });

            var result = collection.LinearSearch(101);
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void TestBinarySearch_WithNonExistingItem()
        {
            var collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });

            var result = collection.LinearSearch(-11);
            Assert.AreNotEqual(true, result);
        }
    }
}
