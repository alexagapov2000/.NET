using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gomoku
{
    public partial class Field
    {
        public delegate void SetNormalImage();
        public static SetNormalImage set_normal_image;
        void setNormalImage()
        {
            var part = Controls[names[names.Count - 1]] as Part;
            if (part.sign == "X")
            {
                part.BackgroundImage = Gomoku.Properties.Resources.Gomoku_X;
            }
            else
            {
                part.BackgroundImage = Gomoku.Properties.Resources.Gomoku_O;
            }
        }

        public delegate void DrawComplete();
        public static DrawComplete draw_complete;
        private void drawComplete()
        {
            foreach (XY_Int xy in fin_coords)
            {
                var part = Controls[Form1.toStr(xy)] as Part;
                if (part.sign == "X")
                {
                    part.BackgroundImage = Gomoku.Properties.Resources.Gomoku_X_complete;
                }
                else
                {
                    part.BackgroundImage = Gomoku.Properties.Resources.Gomoku_O_complete;
                }
            }
        }
    }
}
