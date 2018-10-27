using Fiddler;
using Fiddler.Extensions.UI.Tabs;
using System;
using System.Diagnostics;
using System.Windows.Forms;

[assembly: RequiredVersion("2.3.5.0")]
namespace Fiddler.Extensions
{
    public class AdvancedExtensionBootstrap : IAutoTamper, IDisposable
    {
        private AdvancedFilterTab advancedSearchFilterTab;
        public void AutoTamperRequestAfter(Session oSession)
        {
            advancedSearchFilterTab?.ApplyActions(oSession);
        }

        public void AutoTamperRequestBefore(Session oSession)
        {
            advancedSearchFilterTab?.ApplyActions(oSession);
        }

        public void AutoTamperResponseAfter(Session oSession)
        {
            advancedSearchFilterTab?.ApplyActions(oSession);
        }

        public void AutoTamperResponseBefore(Session oSession)
        {
            advancedSearchFilterTab?.ApplyActions(oSession);
        }

        public void Dispose()
        {
            advancedSearchFilterTab.Dispose();
        }

        public void OnBeforeReturningError(Session oSession)
        {
        }

        public void OnBeforeUnload()
        {
        }

        public void OnLoad()
        {
#if DEBUG
            Debugger.Launch();
#endif
            try
            {
                advancedSearchFilterTab = new AdvancedFilterTab();
                FiddlerApplication.UI.tabsViews.TabPages.Add(advancedSearchFilterTab);
            }
            catch (Exception ex)
            {
                FiddlerObject.log("Error loading the " + advancedSearchFilterTab.GetType().FullName);
                FiddlerObject.log(ex.Message);
                FiddlerObject.log(ex.StackTrace);
            }
        }
    }
}
