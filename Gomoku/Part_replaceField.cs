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
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (Form1.if_R)
            {
                Field.replace();
            }

            Field.x = Cursor.Position.X;
            Field.y = Cursor.Position.Y;
        }
    }
}
