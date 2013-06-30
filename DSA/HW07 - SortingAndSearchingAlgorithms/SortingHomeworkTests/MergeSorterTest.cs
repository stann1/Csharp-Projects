using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using SortingHomework;

namespace SortingHomeworkTests
{
    [TestClass]
    public class MergeSorterTest
    {
        [TestMethod]
        public void TestSort_WithDiverseArrayElements()
        {
            var collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });
            collection.Sort(new MergeSorter<int>());

            int[] actual = new int[collection.Items.Count];
            collection.Items.CopyTo(actual, 0);

            int[] expected = new int[] { 0, 11, 22, 33, 101, 101 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSort_WithEqualButUnsortedCollection()
        {
            var collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });

            int[] actual = new int[collection.Items.Count];
            collection.Items.CopyTo(actual, 0);

            int[] expected = new int[] { 0, 11, 22, 33, 101, 101 };

            CollectionAssert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void TestSort_WithOneRepeatingElementMissing()
        {
            var collection = new SortableCollection<int>(new[] { 22, 11, 101, 33, 0, 101 });
            collection.Sort(new MergeSorter<int>());

            int[] actual = new int[collection.Items.Count];
            collection.Items.CopyTo(actual, 0);

            int[] expected = new int[] { 0, 11, 22, 33, 101 };

            CollectionAssert.AreNotEqual(expected, actual);
        }

        [TestMethod]
        public void TestSort_WithNegativeValues()
        {
            var collection = new SortableCollection<int>(new[] { -22, -11, -101, -33, -0, -101 });
            collection.Sort(new MergeSorter<int>());

            int[] actual = new int[collection.Items.Count];
            collection.Items.CopyTo(actual, 0);

            int[] expected = new int[] { -101, -101, -33, -22, -11, 0 };

            CollectionAssert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void TestSort_WithMostlyEqualElements()
        {
            var collection = new SortableCollection<string>(new string[] { "a", "a", "a", "aa", "a" });
            collection.Sort(new MergeSorter<string>());

            string[] actual = new string[collection.Items.Count];
            collection.Items.CopyTo(actual, 0);

            string[] expected = new string[] { "a", "a", "a", "a", "aa" };

            CollectionAssert.AreEqual(expected, actual);
        }
    }
}
