using System;
using System.Collections.Generic;
using System.Linq;

namespace Better_Limited_Project.Tools
{
    public class Pager<T>
    {
        private readonly List<T> _dataItems = new();
        private readonly int _pageSize;
        private int _currentPageIndex;

        /// <param name="pageSize">Page size of the pager</param>
        /// <exception cref="ArgumentException">Exception will be thrown if the page size is 0</exception>
        public Pager(int pageSize)
        {
            if (pageSize <= 0)
                throw new ArgumentException("Page size cannot be less than or equal to 0");
            _pageSize = pageSize;
        }

        public Pager(int pageSize, IEnumerable<T> items) : this(pageSize)
        {
            _dataItems = items.ToList();
        }

        /// <summary>
        ///     Adds a generic item to the pager
        /// </summary>
        public void AddItem(T item)
        {
            _dataItems.Add(item);
        }

        /// <summary>
        ///     Get the first page of the pager with the page size of the pager
        /// </summary>
        public IEnumerable<T> GetFirstPage()
        {
            if (_dataItems.Count < _pageSize)
                return _dataItems.GetRange(0, _dataItems.Count);
            return _dataItems.GetRange(0, _pageSize);
        }

        /// <summary>
        ///     Returns the current page with the page size of the pager
        /// </summary>
        public IEnumerable<T> GetCurrentPage()
        {
            return IsAlreadyLastPage()
                ? GetLastPage()
                : _dataItems.GetRange(_currentPageIndex, _pageSize);
        }

        /// <summary>
        ///     Advances to the next page and returns it
        /// </summary>
        public IEnumerable<T> GetNextPage()
        {
            if (IsAlreadyLastPage())
                return GetLastPage();

            _currentPageIndex += _pageSize;
            return GetCurrentPage();
        }

        /// <summary>
        ///     Get the previous page of the pager
        /// </summary>
        public IEnumerable<T> GetPreviousPage()
        {
            if (IsAlreadyFirstPage())
                return GetFirstPage();
            _currentPageIndex -= _pageSize;
            return _dataItems.GetRange(_currentPageIndex, _pageSize);
        }

        /// <summary>
        ///     Get the last page of the pager
        /// </summary>
        public IEnumerable<T> GetLastPage()
        {
            if (_dataItems.Count == 0)
                return Enumerable.Empty<T>();
            var noOfItemsInLastPage = _dataItems.Count % _pageSize == 0 ? _pageSize : _dataItems.Count % _pageSize;
            return _dataItems.GetRange(_dataItems.Count - noOfItemsInLastPage, noOfItemsInLastPage);
        }

        public Pager<T> ApplyFilter(Func<T, bool> condition)
        {
            return new Pager<T>(_pageSize, _dataItems.Where(condition));
        }

        /// <summary>
        ///     Check if the pager contains any pages
        /// </summary>
        public bool HasPage()
        {
            return _dataItems.Count != 0;
        }

        private bool IsAlreadyLastPage()
        {
            var lastPageIndex = _dataItems.Count - 1;
            return lastPageIndex - _currentPageIndex < _pageSize;
        }

        private bool IsAlreadyFirstPage()
        {
            return _currentPageIndex - _pageSize < 0;
        }
    }
}