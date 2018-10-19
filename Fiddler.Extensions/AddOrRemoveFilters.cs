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
    internal partial class AddOrRemoveFilters : UserControl
    {
        public AddOrRemoveFilters(AbstractFilter filter)
        {
            InitializeComponent();
            singleFilterGroup.Text = filter.FilterName;
            singleFilterGroup.AccessibleDescription = filter.FilterDescription;
        }
    }
}
