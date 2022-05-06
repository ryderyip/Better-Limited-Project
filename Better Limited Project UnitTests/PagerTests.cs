using System;
using System.Collections.Generic;
using Better_Limited_Project.Tools;
using NUnit.Framework;

namespace UnitTests
{
    [TestFixture]
    public class Pager
    {
        [Test] 
        public void AddItem_PageSize0_ThrowException()
        {
            int pageSize = 0;
            Pager<string> book;

            var ex = Assert.Throws<ArgumentException>(() => book = new(pageSize));

            string expectedMessage = "Page size cannot be less than or equal to 0";
            Assert.AreEqual(expectedMessage, ex.Message);
        }

        
        [Test] 
        public void GetCurrentPage_PageSize4With6Items_First4Items()
        {
            Pager<string> book = new(4);
            book.AddItem("Paragraph 1");
            book.AddItem("Paragraph 2");
            book.AddItem("Paragraph 3");
            book.AddItem("Paragraph 4");
            book.AddItem("Paragraph 5");
            book.AddItem("Paragraph 6");

            var result = book.GetCurrentPage();
            IEnumerable<string> expected = new[]
            {
                "Paragraph 1",
                "Paragraph 2",
                "Paragraph 3",
                "Paragraph 4"
            };
            
            Assert.AreEqual(expected, result);
        }
        
        [Test]
        public void GetCurrentPage_PageSize4With3Items_First3Items()
        {
            Pager<string> book = new(4);
            book.AddItem("Paragraph 1");
            book.AddItem("Paragraph 2");
            book.AddItem("Paragraph 3");

            var result = book.GetCurrentPage();
            IEnumerable<string> expected = new[]
            {
                "Paragraph 1",
                "Paragraph 2",
                "Paragraph 3"
            };
            
            Assert.AreEqual(expected, result);
        }
        
        [Test]
        public void GetNextPage_PageSize3With7Items_Item4To6()
        {
            Pager<string> book = new(3);
            book.AddItem("Paragraph 1");
            book.AddItem("Paragraph 2");
            book.AddItem("Paragraph 3");
            book.AddItem("Paragraph 4");
            book.AddItem("Paragraph 5");
            book.AddItem("Paragraph 6");
            book.AddItem("Paragraph 7");

            var result = book.GetNextPage();
            IEnumerable<string> expected = new[]
            {
                "Paragraph 4",
                "Paragraph 5",
                "Paragraph 6"
            };
            
            Assert.AreEqual(expected, result);
        }
        
        [Test]
        public void GetNextPage_PageSize4With2Items_Item1And2()
        {
            Pager<string> book = new(4);
            book.AddItem("Paragraph 1");
            book.AddItem("Paragraph 2");

            var result = book.GetNextPage();
            IEnumerable<string> expected = new[]
            {
                "Paragraph 1",
                "Paragraph 2"
            };
            
            Assert.AreEqual(expected, result);
        }
        
        [Test]
        public void GetLastPage_PageSize3With5Items_Item3To5()
        {
            int pageSize = 3;
            Pager<string> book = new(pageSize);
            book.AddItem("Paragraph 1");
            book.AddItem("Paragraph 2");
            book.AddItem("Paragraph 3");
            book.AddItem("Paragraph 4");
            book.AddItem("Paragraph 5");

            var result = book.GetLastPage();
            IEnumerable<string> expected = new[]
            {
                "Paragraph 4",
                "Paragraph 5"
            };
            
            Assert.AreEqual(expected, result);
        }
        
        [Test]
        public void GetPreviousPage_PageSize3With5Items_Item1To3()
        {
            int pageSize = 3;
            Pager<string> book = new(pageSize);
            book.AddItem("Paragraph 1");
            book.AddItem("Paragraph 2");
            book.AddItem("Paragraph 3");
            book.AddItem("Paragraph 4");
            book.AddItem("Paragraph 5");

            var result = book.GetPreviousPage();
            IEnumerable<string> expected = new[]
            {
                "Paragraph 1",
                "Paragraph 2",
                "Paragraph 3"
            };
            
            Assert.AreEqual(expected, result);
        }
        
        [Test]
        public void GetPreviousPage_GetNextPageThenGetPreviousPagePageSize3With5Items_Item1To3()
        {
            int pageSize = 3;
            Pager<string> book = new(pageSize);
            book.AddItem("Paragraph 1");
            book.AddItem("Paragraph 2");
            book.AddItem("Paragraph 3");
            book.AddItem("Paragraph 4");
            book.AddItem("Paragraph 5");

            book.GetNextPage();
            book.GetPreviousPage();
            var result = book.GetPreviousPage();
            IEnumerable<string> expected = new[]
            {
                "Paragraph 1",
                "Paragraph 2",
                "Paragraph 3"
            };
            
            Assert.AreEqual(expected, result);
        }
        
        [Test]
        public void GetFirstPage_GetNextPageThenGetFirstPagePageSize3With1Items_Item1()
        {
            int pageSize = 3;
            Pager<string> book = new(pageSize);
            book.AddItem("Paragraph 1");

            var result = book.GetFirstPage();
            IEnumerable<string> expected = new[]
            {
                "Paragraph 1"
            };
            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void GetFirstPage_GetNextPageThenGetFirstPagePageSize3With5Items_Item1To3()
        {
            int pageSize = 3;
            Pager<string> book = new(pageSize);
            book.AddItem("Paragraph 1");
            book.AddItem("Paragraph 2");
            book.AddItem("Paragraph 3");
            book.AddItem("Paragraph 4");
            book.AddItem("Paragraph 5");

            book.GetNextPage();
            var result = book.GetFirstPage();
            IEnumerable<string> expected = new[]
            {
                "Paragraph 1",
                "Paragraph 2",
                "Paragraph 3"
            };
            
            Assert.AreEqual(expected, result);
        }

        [Test]
        public void HasPage_PageSize3With1Items_True()
        {
            int pageSize = 3;
            Pager<string> book = new(pageSize);
            book.AddItem("Paragraph 1");

            bool result = book.HasPage();
            bool expected = true;
            
            Assert.AreEqual(expected, result);
        }
    }
}