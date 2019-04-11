using System.Drawing;

namespace FindDifference
{
    static class ColorExtensions
    {
        public static Pixel ToPixel(this Color color)
        {
            return new Pixel(color.A, color.R, color.G, color.B);
        }

        public static Color Backlight(this Color color, int amplitude)
        {
            return Color.FromArgb(color.A + amplitude, color.R, color.G, color.B);
        }
    }
}
