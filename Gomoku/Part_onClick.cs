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
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            if (!uses)
            {
                uses = true;
                sign = Field.current_player;
                setImage();
                if (Field.names.Count != 0)
                {
                    Field.set_normal_image();
                }
                Field.names.Add(Name);
                BorderStyle = BorderStyle.Fixed3D;
                if (Field.if_five(Name))
                {
                    Field.draw_complete();
                    MessageBox.Show(string.Format("{0} WIN!", sign));
                    Form1.clear();
                }
                Field.changeCurrentPlayer();
            }
        }
    }
}
