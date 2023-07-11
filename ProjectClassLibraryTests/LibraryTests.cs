using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;

namespace ProjectClassLibrary.Tests
{
    [TestClass()]
    public class LibraryTests
    {
        [TestMethod()]
        public void TestLibrary()
        {
            //Arrange
            Dictionary<string, string> keyValuePairs = new Dictionary<string, string>();
            keyValuePairs.Add("altitude", "высота");
            Library library = new Library();
            //Act
            library.AddWord("altitude", "высота");
            var check = library.ShowVocabulary();
            Console.WriteLine(keyValuePairs.Keys + " " + keyValuePairs.Values);
            Console.WriteLine(check.Keys + " " + check.Values);
            //Assert
            CollectionAssert.AreEqual(keyValuePairs, check);
        }
    }
}