using System;
using System.Diagnostics;
using System.Windows.Forms;
using Fiddler;
using Fiddler.Extensions.UI.Tabs;

[assembly: RequiredVersion("2.3.5.0")]
namespace Fiddler.Extensions
{
    public class AdvancedExtensionBootstrap : IAutoTamper, IDisposable
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
#if DEBUG
            Debugger.Launch();
#endif
            try
            {
                advancedFilterTab = new AdvancedFilterTab();
                FiddlerApplication.UI.tabsViews.TabPages.Add(advancedFilterTab);
            }
            catch (Exception ex)
            {
                FiddlerObject.log("Error loading the " + this.advancedFilterTab.GetType().FullName);
                FiddlerObject.log(ex.Message);
                FiddlerObject.log(ex.StackTrace);
            }
        }
    }
}
