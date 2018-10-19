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
        private UserControl filterContainer;
        public AdvancedFilterTab() : this("Advanced Filter", SessionIcons.FilterAll)
        {
        }

        public AdvancedFilterTab(string text, SessionIcons sessionIcon) : base(text)
        {
            ImageIndex = (int)sessionIcon;
            filterContainer = new SearchFilters();
            filterContainer.Dock = DockStyle.Fill;
            this.Controls.Add(filterContainer);
        }
    }
}
