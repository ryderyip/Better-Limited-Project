using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Better_Limited_Project.Tools
{
    public class Pager<T>
    {
        private class Page : IEnumerable<T>
        {
            private readonly int _pageSize;
            public bool IsFull => _items.Count >= _pageSize;
            private readonly List<T> _items = new();

            public Page(int pageSize)
            {
                _pageSize = pageSize;
            }

            public void AddItem(T item)
            {
                if (IsFull)
                    throw new InvalidOperationException("This page is full");
                _items.Add(item);
            }

            public IEnumerator<T> GetEnumerator()
            {
                return _items.GetEnumerator();
            }

            IEnumerator IEnumerable.GetEnumerator()
            {
                return GetEnumerator();
            }
        }
        
        private readonly LinkedList<Page> _pages = new();
        private readonly int _pageSize;
        private int _pageCount = 0;
        private int currentPageIndex = 0;

        public Pager(int pageSize)
        {
            _pageSize = pageSize;
        }

        public void AddItem(T item)
        {
            if (HasNoPage() || IsLastPageFull())
            {
                var page = new Page(_pageSize);
                page.AddItem(item);
                _pages.AddLast(page);
                _pageCount++;
                return;
            }
                
            _pages.Last!.Value.AddItem(item);
        }

        public IEnumerable<T> GetCurrentPage()
        {
            return _pages.ToArray()[currentPageIndex];
        }

        public IEnumerable<T> GetNextPage()
        {
            if (currentPageIndex == _pageCount - 1)
                return GetCurrentPage();
            return _pages.ToArray()[++currentPageIndex];
        }
        
        public IEnumerable<T> GetPreviousPage()
        {
            if (currentPageIndex == 0)
                return GetCurrentPage();
            return _pages.ToArray()[--currentPageIndex];
        }
        
        private bool HasNoPage()
        {
            return _pages.Last == null;
        }

        private bool IsLastPageFull()
        {
            if (_pages.Last == null)
                throw new InvalidOperationException("The last page is null");
            return _pages.Last.Value.IsFull;
        }

        public int GetPageCount()
        {
            return _pageCount;
        }

        /// <summary>
        /// Get the specified page. Note that the page starts with 1, not 0.
        /// </summary>
        public IEnumerable<T> GetPage(int page)
        {
            return _pages.ToArray()[page - 1];
        }

        public IEnumerable<IEnumerable<T>> GetPages()
        {
            return _pages.ToList();
        }
    }
}