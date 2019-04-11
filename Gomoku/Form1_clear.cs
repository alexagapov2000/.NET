using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gomoku
{
    public partial class Form1
    {
        public delegate void Clear();
        public static Clear clear;
        void _clear()
        {
            Controls["field"].Dispose();
            Controls.Add(new Field(21, 40));
            Field.current_player = "O";
            Field.names.Clear();
        }
    }
}
