using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Motel_booking_system.Helpers
{
    public static class OutputMessage
    {
        public static void ErrorMessage(string message)
        {
            MessageBox.Show(message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        public static void WarningMessage(string message)
        {
            MessageBox.Show(message,"Warning",MessageBoxButtons.OKCancel,MessageBoxIcon.Warning);
        }

    }
}
