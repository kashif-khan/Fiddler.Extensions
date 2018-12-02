using Fiddler.Extensions.AdvancedFilters.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiddler.Extensions
{
    internal partial class QueryStringGridFilterUserControl : AbstractFilter
    {
        public override string FilterName { get; protected set; }
        public override string FilterDescription { get; protected set; }

        public override List<SessionStates> FilterTypesSupported => new List<SessionStates>();

        public QueryStringGridFilterUserControl() : this(string.Empty, string.Empty)
        {

        }

        public QueryStringGridFilterUserControl(string filterName, string filterDescription) : base(filterName, filterDescription)
        {
            InitializeComponent();
            singleFilterGroup.Text = filterName;
            singleFilterGroup.AccessibleDescription = filterDescription;
            searchConditionTextBox.GotFocus += searchConditionTextBox_GotFocus;
            searchConditionTextBox.LostFocus += searchConditionTextBox_LostFocus;
            searchConditionTextBox.LostFocus<TextBox>();
            searchConditionTextBox.EnabledChanged += searchConditionTextBox_EnabledChanged;
        }

        private void searchConditionTextBox_EnabledChanged(object sender, EventArgs e)
        {
            var searchConditionDataGridView = sender as TextBox;
            if (searchConditionDataGridView.Enabled)
            {
                searchConditionDataGridView.BackColor = Color.White;
            }
            else
            {
                searchConditionDataGridView.BackColor = Color.WhiteSmoke;
            }
        }

        private void searchConditionTextBox_LostFocus(object sender, EventArgs e)
        {
            var searchConditionTextBox = sender as TextBox;
            if (!searchConditionTextBox.Focused)
            {
                searchConditionTextBox.LostFocus<TextBox>();
            }
        }

        private void searchConditionTextBox_GotFocus(object sender, EventArgs e)
        {
            var searchConditionTextBox = sender as TextBox;
            searchConditionTextBox.GotFocus<TextBox>();
        }

        private void RemoveSearchConditionButton_Click(object sender, EventArgs e)
        {
            RemoveSelectedItems();
        }

        private void RemoveSelectedItems()
        {
            for (int i = searchConditionDataGrid.Rows.Count - 1; i >= 0; --i)
            {
                var currentItem = searchConditionDataGrid.Rows[i];
                if (searchConditionDataGrid.Rows.Contains(currentItem))
                {
                    searchConditionDataGrid.Rows.Remove(currentItem);
                }
            }
        }

        private void searchConditionTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                e.Handled = true;
                if (!searchConditionDataGrid.Contains(searchConditionTextBox.Text, Columns.FilterCondition))
                {
                    searchConditionDataGrid.Rows.Add(true, searchConditionTextBox.Text);
                }
                searchConditionTextBox.Clear();
            }
        }

        private void searchConditionTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            var searchConditionTextBox = sender as TextBox;
            if (searchConditionTextBox.Text.Equals(ControlExtensions.DefaultFieldValue))
            {
                searchConditionTextBox.GotFocus<TextBox>();
            }
        }

        private void searchConditionDataGrid_KeyPress(object sender, KeyPressEventArgs e)
        {
            RemoveSelectedItems();
        }

        public override void Apply(Session oSession)
        {
        }

        private void searchConditionTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        protected static class Columns
        {
            public static string FilterCondition = nameof(FilterCondition);
            public static string ConditionType = nameof(ConditionType);
        }

        private void searchConditionDataGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 1)
            {
                e.Value = "CONTAINS";
            }
        }
    }
}
