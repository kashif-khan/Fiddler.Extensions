using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Linq;

namespace Fiddler.Extensions
{
    internal partial class SearchableFilter : UserControl
    {
        public SearchableFilter(AbstractFilter filter)
        {
            InitializeComponent();
            singleFilterGroup.Text = filter.FilterName;
            singleFilterGroup.AccessibleDescription = filter.FilterDescription;
            SearchConditionRichTextBox.GotFocus += SearchConditionRichTextBox_GotFocus;
            SearchConditionRichTextBox.LostFocus += SearchConditionRichTextBox_LostFocus;
            SearchConditionRichTextBox.LostFocus<RichTextBox>();
        }

        private void SearchConditionRichTextBox_LostFocus(object sender, EventArgs e)
        {
            var searchCondition = sender as RichTextBox;
            searchCondition.LostFocus<RichTextBox>();
        }

        private void SearchConditionRichTextBox_GotFocus(object sender, EventArgs e)
        {
            var searchCondition = sender as RichTextBox;
            searchCondition.GotFocus<RichTextBox>();
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
            for (int i = SearchConditionsListBox.Items.Count - 1; i >= 0; --i)
            {
                var currentItem = SearchConditionsListBox.Items[i];
                if (SearchConditionsListBox.SelectedItems.Contains(currentItem))
                {
                    SearchConditionsListBox.Items.Remove(currentItem);
                }
            }
        }
    }
}
