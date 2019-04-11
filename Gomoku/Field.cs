using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Security.Cryptography;
using System.Security.Policy;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Gomoku
{
    public partial class Field : Panel
    {
        private int n, m;
        private List<XY_Int> fin_coords = new List<XY_Int>();
        public static List<string> names = new List<string>();
        public Field(int n, int m)
        {
            this.n = n;
            this.m = m;
            Width = Form1.size * m;
            Height = Form1.size * n;
            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    Controls.Add(new Part(i, j));
                }
            }

            Name = "field";

            map["diag"] = new XY_Int(1, 1);
            map["hor"] = new XY_Int(0, 1);
            map["diag_in"] = new XY_Int(-1, 1);
            map["ver"] = new XY_Int(1, 0);

            if_five = ifFive;
            set_normal_image = setNormalImage;
            back_step = backStep;
            draw_complete = drawComplete;
            replace = _replace;
        }
    }
}