using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gomoku
{
    public partial class Part
    {
        public void setImage()
        {
            if (sign == "X")
            {
                BackgroundImage = Gomoku.Properties.Resources.Gomoku_X_last;
            }
            else
            {
                BackgroundImage = Gomoku.Properties.Resources.Gomoku_O_last;
            }
        }
    }
}
