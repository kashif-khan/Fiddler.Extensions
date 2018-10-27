using Fiddler.Extensions.Extensions;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiddler.Extensions
{
    public partial class SearchFiltersContainerUserControl : UserControl
    {
        private List<AbstractFilter> filtersCollection = new List<AbstractFilter>();
        public SearchFiltersContainerUserControl()
        {
            InitializeComponent();
            SearchFiltersTextBox.GotFocus += SearchFiltersTextBox_GotFocus;
            SearchFiltersTextBox.LostFocus += SearchFiltersTextBox_LostFocus;
            AddFilters();
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

        private void AddFilters()
        {
            LoadAllFilters();
            FiltersTableLayout.Controls.AddRange(filtersCollection.ToArray<UserControl>());
        }

        private void LoadAllFilters()
        {
            var allTypes = Assembly.GetExecutingAssembly().GetTypes();
            foreach (var type in allTypes)
            {
                if (type.BaseType?.BaseType?.Name == nameof(AbstractFilter))
                {
                    var filter = Activator.CreateInstance(type) as AbstractFilter;
                    filter.Dock = DockStyle.Top;
                    filtersCollection.Add(filter);
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

        private void SearchFiltersTextBox_KeyUp(object sender, KeyEventArgs e)
        {
            if (SearchFiltersTextBox.Text.IsNotNullOrEmpty())
            {
                FiltersTableLayout.Controls.Clear();
                FiltersTableLayout.Controls.AddRange(filtersCollection.Where(x => x.FilterName.Contains(SearchFiltersTextBox.Text, StringComparison.InvariantCultureIgnoreCase)).ToArray<UserControl>());
            }
            else
            {
                FiltersTableLayout.Controls.AddRange(filtersCollection.ToArray<UserControl>());
            }
        }
    }
}
