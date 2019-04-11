

using System.Drawing;
using System.Windows.Forms;

namespace FindDifference
{
    public static class PictureBoxExtensions
    {
        public static Point GetPointOfCursor(this PictureBox pictureBox)
        {
            var ratioX = (double)pictureBox.Image.Width / pictureBox.Width;
            var ratioY = (double)pictureBox.Image.Height / pictureBox.Height;
            var result = new Point(
                (int)(pictureBox.PointToClient(Cursor.Position).X * ratioX),
                (int)(pictureBox.PointToClient(Cursor.Position).Y * ratioY));
            return result;
        }
    }
}
