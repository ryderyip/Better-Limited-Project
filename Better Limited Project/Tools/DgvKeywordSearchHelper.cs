using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Better_Limited_Project.Tools
{
    /// <summary>
    /// A helper class providing basic data grid view searching functionality.  
    /// </summary>
    public class DgvKeywordSearchHelper
    {
        private DataTable _table = null!;
        private DataGridView _dataGridView = null!;
        private TextBox _searchTextBox = null!;
        private string _columnName = null!;

        /// <param name="table">The table to search in</param>
        /// <param name="dataGridView">The data grid view to display the search results</param>
        /// <param name="searchTextBox">The text box where search keywords will be typed in</param>
        /// <param name="columnName">Name of the column to search in</param>
        public void Activate(DataTable table, DataGridView dataGridView, TextBox searchTextBox, string columnName)
        {
            _table = table;
            _dataGridView = dataGridView;
            _searchTextBox = searchTextBox;
            _columnName = columnName;
            if (searchTextBox == null)
                throw new NullReferenceException("Text box object is null. " +
                    "Please only activate after initializing the form components.");
            searchTextBox.TextChanged += SearchTextBoxOnTextChanged;
        }

        private void SearchTextBoxOnTextChanged(object sender, EventArgs e)
        {
            if (!IsColumnNameExistInTable(_columnName))
                throw new ArgumentException($"The column name {_columnName} does not exist in the given table.");

            var rows = SearchForRows().ToArray();
            
            _dataGridView.DataSource = rows.Any() ? 
                rows.CopyToDataTable() : _table.Clone();
        }
        
        private bool IsColumnNameExistInTable(string columnName)
        {
            foreach (DataColumn column in _table.Columns)
                if (column.ColumnName == columnName)
                    return true;
            return false;
        }

        private IEnumerable<DataRow> SearchForRows()
        {
            string keywords = _searchTextBox.Text;

            if (!IsAlphaNumeric(keywords))
                return _table.AsEnumerable()
                    .Where(row => row.Field<string>(_columnName).Contains(keywords));

            return _table.AsEnumerable()
                .Where(row => row.Field<string>(_columnName).ToLower().Contains(keywords.ToLower()));
        }

        private bool IsAlphaNumeric(string stringToCheck)
        {
            return Regex.IsMatch(stringToCheck, "^[a-zA-Z0-9_]*$");
        }
    }
}