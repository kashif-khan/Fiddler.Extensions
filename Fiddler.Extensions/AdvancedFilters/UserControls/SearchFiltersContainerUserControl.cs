using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Reflection;

namespace Fiddler.Extensions
{
    public partial class SearchFiltersContainerUserControl : UserControl
    {
        public SearchFiltersContainerUserControl()
        {
            InitializeComponent();
            SearchFiltersTextBox.GotFocus += SearchFiltersTextBox_GotFocus;
            SearchFiltersTextBox.LostFocus += SearchFiltersTextBox_LostFocus;
            LoadFilters();
            EnableDisableFilterSection(EnableFilterCheckbox);
            SearchFiltersTextBox.LostFocus<TextBox>();
        }

        private void SearchFiltersTextBox_LostFocus(object sender, EventArgs e)
        {
            var searchCondition = sender as TextBox;
            searchCondition.LostFocus<TextBox>();
        }

        private void SearchFiltersTextBox_GotFocus(object sender, EventArgs e)
        {
            var searchCondition = sender as TextBox;
            searchCondition.GotFocus<TextBox>();
        }

        private void LoadFilters()
        {
            var allTypes = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var type in allTypes)
            {
                if (type.BaseType?.BaseType?.Name == nameof(AbstractFilter))
                {
                    var filter = Activator.CreateInstance(type) as AbstractFilter;
                    filter.Dock = DockStyle.Top;
                    FiltersTableLayout.Controls.Add(filter);
                }
            }
        }

        private void EnableFilterCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            var enableFilterCheckbox = sender as CheckBox;
            EnableDisableFilterSection(enableFilterCheckbox);
        }

        private void EnableDisableFilterSection(CheckBox enableFilterCheckbox)
        {
            SearchFiltersTextBox.Enabled = enableFilterCheckbox.Checked;
            FiltersTableLayout.Enabled = enableFilterCheckbox.Checked;
        }

        private void SearchFiltersTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }
    }
}
