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
    public partial class SearchFilters : UserControl
    {
        public SearchFilters()
        {
            InitializeComponent();
            LoadFilters();
            EnableDisableFilterSection(EnableFilterCheckbox);
        }

        private void LoadFilters()
        {

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
    }
}
