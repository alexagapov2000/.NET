using System;
using System.Drawing;

namespace FindDifference
{
    struct Pixel
    {
        byte A, R, G, B;
        public Pixel(byte a, byte r, byte g, byte b)
        {
            A = a;
            R = r;
            G = g;
            B = b;
        }

        public static Pixel Difference(Pixel a, Pixel b)
        {
            /*
            var result = 0;
            result += Math.Min(Math.Abs(a.R - b.R), Math.Abs(b.R - a.R));
            result += Math.Min(Math.Abs(a.G - b.G), Math.Abs(b.G - a.G));
            result += Math.Min(Math.Abs(a.B - b.B), Math.Abs(b.B - a.B));
            return result;
            */
            return new Pixel
            {
                A = 255,
                R = (byte)(Math.Max(a.R, b.R) - Math.Min(a.R, b.R)),
                G = (byte)(Math.Max(a.G, b.G) - Math.Min(a.G, b.G)),
                B = (byte)(Math.Max(a.B, b.B) - Math.Min(a.B, b.B))
            };
        }

        public static Color Difference(Color a, Color b)
        {
            return Difference(a.ToPixel(), b.ToPixel()).ToColor();
        }

        public Color ToColor()
        {
            return Color.FromArgb(A, R, G, B);
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}, {3}", A, R, G, B);
        }
    }
}
