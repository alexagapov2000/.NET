using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gomoku
{
    public partial class Form1
    {
        public static string toStr(int i, int j)
        {
            return string.Format("{0}_{1}", i, j);
        }

        public static string toStr(XY_Int xy)
        {
            return toStr(xy.x, xy.y);
        }
    }
}
