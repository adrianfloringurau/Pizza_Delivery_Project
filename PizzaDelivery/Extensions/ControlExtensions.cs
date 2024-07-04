using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PizzaDelivery.Extensions
{
    public static class ControlExtensions
    {
        public static void Disable(this Control control, Control focusTarget)
        {
            if (focusTarget != null)
            {
                control.TabStop = false;
                control.Cursor = focusTarget.Cursor;
                control.Enter += delegate { focusTarget.Focus(); };
            }
        }
    }
}
