using Fiddler.Extensions.Constants;
using Fiddler.Extensions.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiddler.Extensions
{
    internal class HttpUrlFilter : QueryStringFilterUserControl
    {
        private static List<SessionStates> filterTypes = new List<SessionStates> { SessionStates.AutoTamperRequestBefore };

        private const string filterName = "URL Filter";
        private const string filterDescription = "This method filters the request based on the absolute URL";

        public HttpUrlFilter() : this(filterName, filterDescription)
        {

        }
        public HttpUrlFilter(string filterName, string filterDescription) : base(filterName, filterDescription)
        {
        }

        public override string FilterName => filterName;
        public override string FilterDescription => filterDescription;

        public override List<SessionStates> FilterTypesSupported => filterTypes;

        public override void Apply(Session oSession)
        {
            if (FilterTypesSupported.Contains(oSession.state))
            {
                foreach (string url in SearchConditionsListBox.Items)
                {
                    if (url.OICStartsWith(FiddlerConstantStrings.Regex))
                    {

                    }
                    else if (url.OICStartsWith(FiddlerConstantStrings.Exact))
                    {

                    }
                    else
                    {
                        if ((oSession.fullUrl.Contains(url, StringComparison.InvariantCultureIgnoreCase)))
                            oSession[FiddlerFlags.HideSession] = true.ToString().ToLower();
                    }
                }
            }
        }
    }
}
