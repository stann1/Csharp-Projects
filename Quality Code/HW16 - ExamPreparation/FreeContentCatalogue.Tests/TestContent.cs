using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FreeContentCatalogue.Tests
{
    [TestClass]
    public class TestContent
    {
        [TestMethod]
        public void TestCompareTo_WithNullContentItem()
        {
            Content item = new Content(ContentType.Book, new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            var result = item.CompareTo(null);
            Assert.AreEqual(1, result);
        }

        [TestMethod]        
        public void TestCompareTo_WithOtherValidContentItem()
        {
            Content item = new Content(ContentType.Book, new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            Content secondItem = new Content(ContentType.Movie, new string[] { "Rocky", "Sylvester Stalone", "1353151", "http://www.rockymovie.info" });
            
            var result = item.CompareTo(secondItem);
            Assert.AreEqual(-1, result);
        }

        [TestMethod]
        [ExpectedException(typeof(NullReferenceException))]
        public void TestCompareTo_WithInvalidContentItem()
        {
            Content item = new Content(ContentType.Book, new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            string[] dummy = new string[] { "some", "invalid", "content", "item" };
            var result = item.CompareTo(dummy);            
        }
    }
}
