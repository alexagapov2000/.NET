using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gomoku
{
    public partial class Field
    {
        public static string current_player = "X";
        public static void changeCurrentPlayer()
        {
            if (current_player == "X")
            {
                current_player = "O";
            }
            else
            {
                current_player = "X";
            }
        }
    }
}
