using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fiddler.Extensions.AdvancedFilters.Extensions
{
    public static class DataGridViewExtensions
    {
        public static bool Contains(this DataGridView theDataGrid, string valueToMatch, string searchColumn)
        {
            foreach (DataGridViewRow eachRow in theDataGrid.Rows)
            {
                var cellValue = eachRow.Cells[searchColumn].Value?.ToString();
                if (cellValue != null && cellValue.Contains(valueToMatch))
                {
                    return true;
                }
            }
            return false;
        }
    }
}
