using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiddler.Extensions
{
    class RequestMethodFilter : AbstractFilter
    {
        private static FilterType[] filterTypes = new FilterType[] { FilterType.BeforeRequest };
        public override string FilterName => "Request Method Filter";
        public override FilterType[] FilterTypesSupported { get => filterTypes; }

        public override string FilterDescription => "This method filters the request method mentioned";

        public override void Apply(Session oSession)
        {
            throw new NotImplementedException();
        }
    }
}
