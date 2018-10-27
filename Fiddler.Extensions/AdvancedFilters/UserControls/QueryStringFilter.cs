using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace Fiddler.Extensions
{
    internal partial class QueryStringFilter : AbstractFilter
    {
        public override List<FilterType> FilterTypesSupported => new List<FilterType>();

        public override string FilterName { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }
        public override string FilterDescription { get => throw new NotImplementedException(); protected set => throw new NotImplementedException(); }

        public QueryStringFilter(string filterName, string filterDescription) : base(filterName, filterDescription)
        {
            InitializeComponent();
            singleFilterGroup.Text = filterName;
            singleFilterGroup.AccessibleDescription = filterDescription;
            SearchConditionRichTextBox.GotFocus += SearchConditionRichTextBox_GotFocus;
            SearchConditionRichTextBox.LostFocus += SearchConditionRichTextBox_LostFocus;
            SearchConditionRichTextBox.LostFocus<RichTextBox>();
            SearchConditionsListBox.EnabledChanged += SearchConditionsListBox_EnabledChanged;
        }

        private void SearchConditionsListBox_EnabledChanged(object sender, EventArgs e)
        {
            var searchConditionListBox = sender as ListBox;
            if (searchConditionListBox.Enabled)
            {
                searchConditionListBox.BackColor = Color.White;
            }
            else
            {
                searchConditionListBox.BackColor = Color.WhiteSmoke;
            }
        }

        private void SearchConditionRichTextBox_LostFocus(object sender, EventArgs e)
        {
            var searchConditionRichTextBox = sender as RichTextBox;
            if (!searchConditionRichTextBox.Focused)
            {
                searchConditionRichTextBox.LostFocus<RichTextBox>();
            }
        }

        private void SearchConditionRichTextBox_GotFocus(object sender, EventArgs e)
        {
            var searchConditionRichTextBox = sender as RichTextBox;
            searchConditionRichTextBox.GotFocus<RichTextBox>();
        }

        private void AddSearchConditionButton_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrEmpty(SearchConditionRichTextBox.Text) && !SearchConditionsListBox.Items.Contains(SearchConditionRichTextBox.Text))
            {
                if (!SearchConditionRichTextBox.Text.Equals(ControlExtensions.DefaultFieldValue))
                {
                    SearchConditionsListBox.Items.Add(SearchConditionRichTextBox.Text);
                }
                SearchConditionRichTextBox.Text = string.Empty;
                SearchConditionRichTextBox.LostFocus<RichTextBox>();
            }
        }

        private void RemoveSearchConditionButton_Click(object sender, EventArgs e)
        {
            RemoveSelectedItems();
        }

        private void RemoveSelectedItems()
        {
            for (int i = SearchConditionsListBox.Items.Count - 1; i >= 0; --i)
            {
                var currentItem = SearchConditionsListBox.Items[i];
                if (SearchConditionsListBox.SelectedItems.Contains(currentItem))
                {
                    SearchConditionsListBox.Items.Remove(currentItem);
                }
            }
        }

        private void SearchConditionRichTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == '\r')
            {
                AddSearchConditionButton_Click(this, e);
            }
        }

        private void SearchConditionRichTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            var searchConditionRichTextBox = sender as RichTextBox;
            if (searchConditionRichTextBox.Text.Equals(ControlExtensions.DefaultFieldValue))
            {
                searchConditionRichTextBox.GotFocus<RichTextBox>();
            }
        }

        private void SearchConditionsListBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            RemoveSelectedItems();
        }

        public override void Apply(Session oSession)
        {
            throw new NotImplementedException();
        }
    }
}
