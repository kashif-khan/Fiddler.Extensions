using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiddler.Extensions
{
    internal class HttpUrlFilter : QueryStringFilter
    {
        private static List<FilterType> filterTypes = new List<FilterType> { FilterType.BeforeRequest };

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

        public override List<FilterType> FilterTypesSupported => filterTypes;

        public override void Apply(Session oSession)
        {

        }
    }
}
