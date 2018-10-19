using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fiddler.Extensions
{
    internal abstract class AbstractFilter
    {
        public abstract string FilterName { get; }

        public abstract string FilterDescription { get; }

        public abstract FilterType[] FilterTypesSupported { get; }

        public abstract void Apply(Session oSession);
    }
}
