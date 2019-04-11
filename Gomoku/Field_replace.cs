using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomoku
{
    public partial class Field
    {
        public static int x, y;
        public delegate void Replace();
        public static Replace replace;
        void _replace()
        {
            Location = new Point(Location.X + Cursor.Position.X - Field.x, Location.Y + Cursor.Position.Y - Field.y);
        }
    }
}
