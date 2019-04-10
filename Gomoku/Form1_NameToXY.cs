using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Gomoku
{
    public partial class Form1
    {
        public static void toInt(string a, ref int x, ref int y)
        {
            Regex reg = new Regex("([0-9]+)(_)([0-9]+)");
            Match match = reg.Match(a);
            x = toInt(match.Groups[1].Value);
            y = toInt(match.Groups[3].Value);
        }

        public static int toInt(string a)
        {
            int res = 0;
            int k = 1;
            List<int> digits = new List<int>();
            while (a != "")
            {
                digits.Add(a[0] - '0');
                a = a.Substring(1);
            }
            digits.Reverse();
            foreach (int d in digits)
            {
                res += k * d;
                k *= 10;
            }
            return res;
        }
    }
}
