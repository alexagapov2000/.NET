using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Microsoft.Win32;

namespace Gomoku
{
    public partial class Part : Panel
    {
        private bool uses = false;
        public string sign = "";
        public Part(int i, int j)
        {
            int size = Form1.size;
            Width = Height = size;
            BorderStyle = BorderStyle.FixedSingle;
            Location = new Point(j * size - j, i * size - i);
            Name = string.Format("{0}_{1}", i, j);
            BackColor = Color.AntiqueWhite;
        }

        public Part(Point point)
        {
            int size = Form1.size;
            Width = Height = size;
            BorderStyle = BorderStyle.FixedSingle;
            Location = point;
            BackColor = Color.AntiqueWhite;
        }
    }
}
