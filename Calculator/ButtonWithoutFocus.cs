using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LabaForms1
{
    public class ButtonWithoutFocus : Button
    {
        public ButtonWithoutFocus() : base()
        {
            SetStyle(ControlStyles.Selectable, false);
            Size = new System.Drawing.Size(100, 100);
        }
    }
}
