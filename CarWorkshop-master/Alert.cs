using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CarWorkshop
{
    public static class Alert
    {
        public static void DisplayError(string message)
        {
            MessageBox.Show(message, "Error",
            MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
