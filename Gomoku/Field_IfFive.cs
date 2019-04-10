using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gomoku
{
    public partial class Field
    {
        public delegate bool IfFive(string name);
        public static IfFive if_five;
        SortedDictionary<string, XY_Int> map = new SortedDictionary<string, XY_Int>();
        bool ifFive(string name)
        {
            foreach (var Var in map)
            {
                XY_Int xy = Var.Value;
                if (linearIfFive(name, xy.x, xy.y))
                {
                    return true;
                }
            }
            return false;
        }

        bool linearIfFive(string name, int dx, int dy)
        {
            fin_coords.Clear();
            int combo = 1;
            var part = Controls[name] as Part;
            string sign = part.sign;
            int i_name = 0;
            int j_name = 0;
            Form1.toInt(name, ref i_name, ref j_name);
            fin_coords.Add(new XY_Int(i_name, j_name));

            string name_tmp;
            var part_tmp = Controls[0] as Part;

            for (int i = -1; i <= 1; i += 2)
            {
                Form1.toInt(name, ref i_name, ref j_name);
                i_name += (dx * i);
                j_name += (dy * i);
                name_tmp = Form1.toStr(i_name, j_name);
                part_tmp = Controls[name_tmp] as Part;
                fin_coords.Add(new XY_Int(i_name, j_name));
                while (part_tmp != null && sign == part_tmp.sign)
                {
                    combo++;
                    i_name += (dx * i);
                    j_name += (dy * i);
                    name_tmp = Form1.toStr(i_name, j_name);
                    part_tmp = Controls[name_tmp] as Part;
                    fin_coords.Add(new XY_Int(i_name, j_name));
                }
                fin_coords.RemoveAt(fin_coords.Count - 1);
            }

            Form1.toInt(name, ref i_name, ref j_name);
            fin_coords.Add(new XY_Int(i_name, j_name));
            return combo >= 5;
        }
    }
}
