using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiddler.Extensions
{
    public static class ControlExtensions
    {
        public const string DefaultFieldValue = "Accepts REGEX: or EXACT:";
        public static void GotFocus<T>(this T sender) where T : Control
        {
            if (sender.Text == DefaultFieldValue)
            {
                sender.Text = string.Empty;
                sender.ForeColor = Color.Black;
            }
        }

        public static void LostFocus<T>(this T sender) where T : Control
        {
            if (string.IsNullOrEmpty(sender.Text))
            {
                sender.Text = DefaultFieldValue;
                sender.ForeColor = Color.Gray;
            }
        }
    }
}
