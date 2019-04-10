using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gomoku
{
    public partial class Field
    {
        public delegate void BackStep();
        public static BackStep back_step;
        private void backStep()
        {
            string name = names[names.Count - 1];
            names.RemoveAt(names.Count - 1);
            var part = Controls[name] as Part;
            part.clear();
            if (names.Count != 0)
            {
                part = Controls[names[names.Count - 1]] as Part;
                part.setImage();
            }
        }
    }
}
