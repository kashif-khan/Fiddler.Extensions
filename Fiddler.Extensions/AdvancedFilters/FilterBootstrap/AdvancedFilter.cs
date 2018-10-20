using System;
using System.Windows.Forms;
using Fiddler;
using Fiddler.Extensions.UI.Tabs;

[assembly: RequiredVersion("2.3.5.0")]
namespace Fiddler.Extensions
{
    public class AdvancedFilter : IAutoTamper, IDisposable
    {
        private AdvancedFilterTab advancedFilterTab;
        public void AutoTamperRequestAfter(Session oSession)
        {
        }

        public void AutoTamperRequestBefore(Session oSession)
        {
        }

        public void AutoTamperResponseAfter(Session oSession)
        {
        }

        public void AutoTamperResponseBefore(Session oSession)
        {
        }

        public void Dispose()
        {
            advancedFilterTab.Dispose();
        }

        public void OnBeforeReturningError(Session oSession)
        {
        }

        public void OnBeforeUnload()
        {
        }

        public void OnLoad()
        {
            advancedFilterTab = new AdvancedFilterTab();
            FiddlerApplication.UI.tabsViews.TabPages.Add(advancedFilterTab);
        }
    }
}
