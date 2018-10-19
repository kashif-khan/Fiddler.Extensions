using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

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
        }

        private void SearchConditionRichTextBox_LostFocus(object sender, EventArgs e)
        {
            var searchCondition = sender as RichTextBox;
            searchCondition.Text = string.Empty;
            searchCondition.ForeColor = Color.Black;
        }

        private void SearchConditionRichTextBox_GotFocus(object sender, EventArgs e)
        {
            var searchCondition = sender as RichTextBox;
            searchCondition.Text = "Accepts REGEX: or EXACT:";
            searchCondition.ForeColor = Color.Gray;
        }
    }
}
