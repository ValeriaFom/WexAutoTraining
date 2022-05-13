using Microsoft.VisualStudio.TestTools.UnitTesting;
using Homework5_ClassBook_Homework9_BookCatalog;
using System.Collections.Generic;
using System;

namespace UnitTestsForBookCatalogHW9
{
    [TestClass]
    public class CheckAddBook
    {
        [TestMethod]
        public void CheckUniqueIDPositive() 
        {
            var catalog = new Catalog();
            catalog.AddBook(new Book("Peter Pan",
                    new List<Author>()
                    {
                    new Author("James", "Barrie", new DateTime(1860, 5, 9)),
                    new Author("52", "2782", new DateTime(1861, 4, 9))
                    },
                    new DateTime(1900, 12, 4), 54, 1));
            
            bool result = catalog.IsIDUnique(15);
            Assert.IsTrue(result);
        }

        [TestMethod]
        public void CheckUniqueIDNegative()
        {
            var catalog = new Catalog();
            catalog.AddBook(new Book("Peter Pan",
                    new List<Author>()
                    {
                    new Author("James", "Barrie", new DateTime(1860, 5, 9)),
                    new Author("52", "2782", new DateTime(1861, 4, 9))
                    },
                    new DateTime(1900, 12, 4), 54, 1));

            bool result = catalog.IsIDUnique(1);
            Assert.IsFalse(result);
        }
    }
}
