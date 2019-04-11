using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomoku
{
    public partial class Form1
    {
        public static bool if_R = false;
        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (Field.names.Count != 0 && (int)e.KeyCode == 8)
            {
                Field.back_step();
                Field.changeCurrentPlayer();
            }
            if (e.KeyCode.ToString() == "R")
            {
                if_R = true;
            }

            if (e.KeyCode.ToString() == "F1")
            {
                panel1.Show();
            }
        }
        private void Form1_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode.ToString() == "R")
            {
                if_R = false;
            }

            if (e.KeyCode.ToString() == "F1")
            {
                panel1.Hide();
            }
        }
    }
}
