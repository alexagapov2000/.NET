using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace Tjuring_Machine_Term_Paper
{
    public partial class Tape
    {
        public delegate void MoveMethod(int dx);
        public static MoveMethod MoveStatic;

        public void MoveTape(int dx)
        {
            foreach (var cell in Cells)
                cell.ImaginaryLocation += dx;
            Draw();
        }

        protected override void OnSizeChanged(EventArgs e)
        {
            base.OnSizeChanged(e);
            Draw();
        }

        public void Draw()
        {
            var size = Size.Height;
            var activeCells =
                (Cells ?? new LinkedList<Cell>()).Where(x =>
                    x.InBoundsImaginary(this) ||
                    (x.InBounds(this) && !x.InBoundsImaginary(this)))
                    .ToList();
            foreach (var cell in activeCells)
                cell.Location = cell.ImaginaryLocation;
        }
    }

    public partial class Cell
    {
        private bool IsClicked { get; set; }
        protected override void OnMouseDown(MouseEventArgs e)
        {
            base.OnMouseDown(e);
            IsClicked = true;
            Tape.SelectStatic();
        }
        protected override void OnMouseUp(MouseEventArgs e)
        {
            base.OnMouseUp(e);
            IsClicked = false;
        }
        private Point LastCursorPosition { get; set; }
        protected override void OnMouseMove(MouseEventArgs e)
        {
            base.OnMouseMove(e);
            if (IsClicked)
                Tape.MoveStatic(Cursor.Position.X - LastCursorPosition.X);
            LastCursorPosition = Cursor.Position;
        }
    }
}
