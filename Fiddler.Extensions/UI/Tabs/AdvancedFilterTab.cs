using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiddler.Extensions.UI.Tabs
{
    internal class AdvancedFilterTab : TabPage
    {
        public AdvancedFilterTab() : this("Advanced Filter")
        {
            ImageIndex = (int)SessionIcons.FilterAll;
        }

        public AdvancedFilterTab(string text) : base(text)
        {
        }
    }
}
