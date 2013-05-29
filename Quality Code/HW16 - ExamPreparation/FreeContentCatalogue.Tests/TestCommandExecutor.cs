using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Text;

namespace FreeContentCatalogue.Tests
{
    [TestClass]
    public class TestCommandExecutor
    {
        [TestMethod]
        public void TestExecuteCommand_BookItem()
        {
            StringBuilder output = new StringBuilder();
            Catalog catalog = new Catalog();
            ICommandExecutor commandExecutor = new CommandExecutor();
            Command cmd = new Command("Add book: Intro C#; S.Nakov; 12763892; http://www.introprogramming.info");

            commandExecutor.ExecuteCommand(catalog, cmd, output);
            var strResult = output.ToString();
            Assert.AreEqual("Book added\r\n", strResult);
        }

        [TestMethod]
        public void TestExecuteCommand_SongItem()
        {
            StringBuilder output = new StringBuilder();
            Catalog catalog = new Catalog();
            ICommandExecutor commandExecutor = new CommandExecutor();
            Command cmd = new Command("Add song: One; Metallica; 8771120; http://goo.gl/dIkth7gs");

            commandExecutor.ExecuteCommand(catalog, cmd, output);
            var strResult = output.ToString();
            Assert.AreEqual("Song added\r\n", strResult);
        }

        [TestMethod]
        [ExpectedException(typeof(ArgumentOutOfRangeException))]
        public void TestExecuteCommand_UpdateWithInvalidNumberOfParams()
        {
            StringBuilder output = new StringBuilder();
            Catalog catalog = new Catalog();
            ICommandExecutor commandExecutor = new CommandExecutor();
            Command cmd = new Command("Update: http://goo.gl/dIkth7gs; http://goo.gl/dI; http://goo.gl/dI");
            commandExecutor.ExecuteCommand(catalog, cmd, output);
        }
    }
}
