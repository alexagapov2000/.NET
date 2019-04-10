using System.Drawing;
using System.Windows.Forms;

namespace Tjuring_Machine_Term_Paper
{
    public partial class Cell : Label
    {
        public new int Size
        {
            get { return base.Size.Width; }
            set { base.Size = new Size(value, value); }
        }

        #region location
        public int ImaginaryLocation { get; set; }
        public new int Location
        {
            get { return base.Location.X; }
            set
            {
                ImaginaryLocation = value;
                base.Location = new Point(value, 0);
            }
        }
        public void MatchImaginaryLocation()
        {
            Location = ImaginaryLocation;
        }
        #endregion

        #region letter
        private char letter;
        public char Letter
        {
            get { return letter; }
            set { Text = value.ToString(); letter = value; }
        }
        #endregion

        public Cell(int size = 72, int location = 0)
        {
            BackColor = Color.White;
            Size = size;
            Location = location;
            TextAlign = ContentAlignment.MiddleCenter;
            Font = new Font(FontFamily.GenericSerif, Size / 2);
            BorderStyle = BorderStyle.FixedSingle;
            Letter = '#';
        }

        #region in_bounds
        public bool InBounds(Tape parent)
        {
            return
                Location > -parent.Size.Height &&
                Location < parent.Size.Width;
        }

        public bool InBoundsImaginary(Tape parent)
        {
            return
                ImaginaryLocation > -parent.Size.Height &&
                ImaginaryLocation < parent.Size.Width;
        }
        #endregion

        protected override void OnMouseDoubleClick(MouseEventArgs e)
        {
            base.OnMouseDoubleClick(e);
            Tape.ChangePointerOnClickStatic(this);
        }

        public override string ToString()
        {
            return $"Loc = {Location}; base = {base.Location}; imag = {ImaginaryLocation}";
        }
    }
}
