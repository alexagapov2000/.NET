using System.Drawing;

namespace FindDifference
{
    static class BitmapExtensions
    {
        public static Color GetPixel(this Bitmap bitmap, Point point)
        {
            return bitmap.GetPixel(point.X, point.Y);
        }

        public static void SetPixel(this Bitmap bitmap, Point point, Color color)
        {
            bitmap.SetPixel(point.X, point.Y, color);
        }
    }
}
