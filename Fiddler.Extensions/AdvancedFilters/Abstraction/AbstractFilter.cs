using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiddler.Extensions
{
    /// <summary>
    /// The user control designer page cannnot load if it is inherited from abstract page. Hence pre-processor directives are added to trick the designer that it is not inherited from abstract class. 
    /// <seealso cref="https://www.codeproject.com/Articles/22788/Inheriting-a-Form-from-an-Abstract-Class-and-Makin"/>
    /// </summary>
#if DESIGNER
    internal class AbstractFilter : UserControl
    {
        public AbstractFilter() : this(string.Empty, string.Empty)
        {

        }
        public AbstractFilter(string filterName, string filterDescription)
        {
            FilterName = filterName;
            FilterDescription = filterDescription;
        }
        public virtual string FilterName { get; protected set; }

        public virtual string FilterDescription { get; protected set; }

        public virtual List<SessionStates> FilterTypesSupported { get; }

        public virtual void Apply(Session oSession) { throw new NotImplementedException(); }

        protected ToolTip ToolTipControl = new ToolTip();
    }
#else
    internal abstract class AbstractFilter : UserControl
    {
        public AbstractFilter() : this(string.Empty, string.Empty)
        {

        }

        public AbstractFilter(string filterName, string filterDescription)
        {
            this.FilterName = filterName;
            this.FilterDescription = filterDescription;
        }

        public abstract string FilterName { get; protected set; }

        public abstract string FilterDescription { get; protected set; }

        public abstract List<SessionStates> FilterTypesSupported { get; }

        public abstract void Apply(Session oSession);

        protected ToolTip ToolTipControl = new ToolTip();
    }
#endif
}
