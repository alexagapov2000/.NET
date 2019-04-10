using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomoku
{
    public partial class Part
    {
        public void clear()
        {
            uses = false;
            sign = "";
            BackgroundImage = null;
            BorderStyle = BorderStyle.FixedSingle;
        }
    }
}
