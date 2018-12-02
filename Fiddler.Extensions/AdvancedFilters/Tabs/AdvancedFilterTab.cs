using System.Windows.Forms;

namespace Fiddler.Extensions.UI.Tabs
{
    internal class AdvancedFilterTab : TabPage
    {
        private SearchFiltersContainerUserControl filterContainer;
        public AdvancedFilterTab() : this("Advanced Filter", SessionIcons.FilterAll)
        {
        }

        public AdvancedFilterTab(string text, SessionIcons sessionIcon) : base(text)
        {
            filterContainer = new SearchFiltersContainerUserControl();
            ImageIndex = (int)sessionIcon;
            filterContainer.Dock = DockStyle.Fill;
            Controls.Add(filterContainer);
        }

        public void ApplyActions(Session oSession)
        {
            filterContainer.ApplyFilter(oSession);
        }

        private void InitializeComponent()
        {
            this.SuspendLayout();
            // 
            // AdvancedFilterTab
            // 
            this.AutoScroll = true;
            this.ResumeLayout(false);

        }
    }
}
