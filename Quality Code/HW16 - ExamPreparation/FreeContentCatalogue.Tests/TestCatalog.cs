using System;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FreeContentCatalogue.Tests
{
    [TestClass]
    public class TestCatalog
    {
        [TestMethod]
        public void TestAddContent_WithSingleItem()
        {
            Catalog catalog = new Catalog();
            Content item = new Content(ContentType.Book, new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.AddContent(item);
            Assert.AreEqual(1, catalog.Count);
        }

        [TestMethod]
        public void TestAddContent_WithDuplicateItem()
        {
            Catalog catalog = new Catalog();
            Content firstItem = new Content(ContentType.Book, new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            Content secondItem = new Content(ContentType.Book, new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            catalog.AddContent(firstItem);
            catalog.AddContent(secondItem);
            Assert.AreEqual(2, catalog.Count);
        }

        [TestMethod]
        public void TestAddContent_WithDifferentItemTypes()
        {
            Catalog catalog = new Catalog();
            Content firstItem = new Content(ContentType.Book, new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            Content secondItem = new Content(ContentType.Movie, new string[] { "Rocky", "Sylvester Stalone", "1353151", "http://www.rockymovie.info" });
            Content thirdItem = new Content(ContentType.Song, new string[] { "Master of puppets", "Metallica", "2342332", "http://www.metallica.info" });
            catalog.AddContent(firstItem);
            catalog.AddContent(secondItem);
            catalog.AddContent(thirdItem);
            Assert.AreEqual(3, catalog.Count);
        }

        [TestMethod]
        public void TestAddAndFindItem()
        {
            Catalog catalog = new Catalog();
            Content item = new Content(ContentType.Book, new string[]{"Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info"});
            catalog.AddContent(item);
            var contentList = catalog.GetListContent("Intro C#", 1);
            Assert.AreEqual(1, contentList.Count());
            Assert.AreSame(contentList.ElementAt(0), item);
        }

        [TestMethod]
        public void TestAddAndFindFromMultipleItems()
        {
            Catalog catalog = new Catalog();
            Content firstItem = new Content(ContentType.Book, new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            Content secondItem = new Content(ContentType.Book, new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            Content thirdItem = new Content(ContentType.Song, new string[] { "Master of puppets", "Metallica", "2342332", "http://www.metallica.info" });
            catalog.AddContent(firstItem);
            catalog.AddContent(secondItem);
            catalog.AddContent(thirdItem);

            var contentList = catalog.GetListContent("Intro C#", 3);
            Assert.AreEqual(3, catalog.Count);
            Assert.AreEqual(2, contentList.Count());
            Assert.AreSame(contentList.ElementAt(0), firstItem);
            Assert.AreSame(contentList.ElementAt(1), secondItem);
        }

        [TestMethod]
        public void TestUpdatedContent_WithValidUrl()
        {
            Catalog catalog = new Catalog();
            Content firstItem = new Content(ContentType.Book, new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            Content secondItem = new Content(ContentType.Book, new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            Content thirdItem = new Content(ContentType.Song, new string[] { "Master of puppets", "Metallica", "2342332", "http://www.metallica.info" });
            catalog.AddContent(firstItem);
            catalog.AddContent(secondItem);
            catalog.AddContent(thirdItem);

            var result = catalog.UpdatedContent("http://www.introprogramming.info", "http://www.introprogramming.se");
            Assert.AreEqual(2, result);
        }

        [TestMethod]
        public void TestUpdatedContent_WithNonExistingUrl()
        {
            Catalog catalog = new Catalog();
            Content firstItem = new Content(ContentType.Book, new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            Content secondItem = new Content(ContentType.Book, new string[] { "Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info" });
            Content thirdItem = new Content(ContentType.Song, new string[] { "Master of puppets", "Metallica", "2342332", "http://www.metallica.info" });
            catalog.AddContent(firstItem);
            catalog.AddContent(secondItem);
            catalog.AddContent(thirdItem);

            var result = catalog.UpdatedContent("http://www.introtojava.info", "http://www.introprogramming.se");
            Assert.AreEqual(0, result);
        }
    }
}
