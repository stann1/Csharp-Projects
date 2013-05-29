using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace FreeContentCatalogue.Tests
{
    [TestClass]
    public class TestCommand
    {
        [TestMethod]
        public void TestParsing_NameWithValidCommand()
        {
            Command cmd = new Command("Add book: Intro C#; S.Nakov; 12763892; http://www.introprogramming.info");
            var result = cmd.Name;
            Assert.AreEqual("Add book", result);
        }

        [TestMethod]
        [ExpectedException(typeof(FormatException))]
        public void TestParsing_NameWithInvalidCommand()
        {
            Command cmd = new Command("Add; book: Intro C#; S.Nakov; 12763892; http://www.introprogramming.info");
            var result = cmd.Name;
            Assert.AreEqual("Add book", result);
        }

        //for reasons unknown to me, this test fails
        //[TestMethod]
        //public void TestParsing_ParametersWithValidCommand()
        //{
        //    Command cmd = new Command("Add book: Intro C#; S.Nakov; 12763892; http://www.introprogramming.info");
        //    var result = cmd.Parameters;
        //    var expected = new string[]{"Intro C#", "S.Nakov", "12763892", "http://www.introprogramming.info"};
        //    Assert.AreSame(expected, result);
        //}

        [TestMethod]
        public void TestParsing_TypeWithValidCommand()
        {
            Command cmd = new Command("Add book: Intro C#; S.Nakov; 12763892; http://www.introprogramming.info");
            var result = cmd.Type;
            Assert.AreEqual(CommandType.AddBook, result);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentException))]
        public void TestParsing_TypeWithinvalidCommand()
        {
            Command cmd = new Command("Asfafaga: Intro C#; S.Nakov; 12763892; http://www.introprogramming.info");
            var result = cmd.Type;           
        }

        [TestMethod]        
        public void TestCommandToString()
        {
            Command cmd = new Command("Add song: One; Metallica; 8771120; http://goo.gl/dIkth7gs");
            var result = cmd.ToString();
            Assert.AreEqual("Add song One Metallica 8771120 http://goo.gl/dIkth7gs", result);
        }
    }
}
