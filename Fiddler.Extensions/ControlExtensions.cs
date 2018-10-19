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
        public static void GotFocus<T>(this T sender) where T : Control
        {
            sender.Text = string.Empty;
            sender.ForeColor = Color.Black;
        }

        public static void LostFocus<T>(this T sender) where T : Control
        {
            if (string.IsNullOrEmpty(sender.Text))
            {
                sender.Text = "Accepts REGEX: or EXACT:";
                sender.ForeColor = Color.Gray;
            }
        }
    }
}
