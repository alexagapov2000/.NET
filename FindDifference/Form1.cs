using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace FindDifference
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            pictureBox1.Image = Properties.Resources.difference;
            pictureBox2.Image = Properties.Resources.difference2;
            pictureBox3.Image = GetDifference(pictureBox1, pictureBox2);
            //pictureBox3.Refresh();
        }

        public Bitmap GetDifference(PictureBox a, PictureBox b)
        {
            Bitmap result = new Bitmap(a.Image);
            var height = a.Image.Height < b.Image.Height ? a.Image.Height : b.Image.Height;
            var width = a.Image.Width < b.Image.Width ? a.Image.Width : b.Image.Width;

            for (int i = 0; i < height; i++)
                for (int j = 0; j < width; j++)
                {
                    var aPix = (a.Image as Bitmap).GetPixel(j, i);
                    var bPix = (b.Image as Bitmap).GetPixel(j, i);
                    result.SetPixel(j, i, Pixel.Difference(aPix, bPix));
                }
            return result;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            pictureBox3.Image = GetDifference(pictureBox1, pictureBox2);
            pictureBox3.Refresh();
        }

        private void pictureBox3_MouseDown(object sender, MouseEventArgs e)
        {
            var neighbours = new List<Point>();
            var start = pictureBox3.GetPointOfCursor();
            var image = pictureBox3.Image as Bitmap;
            if (image.GetPixel(start) != Color.FromArgb(255, 0, 0, 0))
                GetNeighbours(neighbours, image, start);
            Highlight(neighbours);
            foreach (var p in neighbours)
                (pictureBox3.Image as Bitmap).SetPixel(p, Color.White);
        }

        private void Highlight(List<Point> neighbours)
        {
            for (int i = 0; i < 10; i++)
                ChangeColor(neighbours, -25, pictureBox1, pictureBox2);
            for (int i = 0; i < 10; i++)
                ChangeColor(neighbours, 25, pictureBox1, pictureBox2);
        }

        void ChangeColor(List<Point> points, int amplitude, params PictureBox[] pictures)
        {
            var currentPixel = new Color();
            foreach (var pic in pictures)
                foreach (var p in points)
                {
                    currentPixel = (pic.Image as Bitmap).GetPixel(p);
                    currentPixel = currentPixel.Backlight(amplitude);
                    (pic.Image as Bitmap).SetPixel(p, currentPixel);
                }
            foreach (var pic in pictures)
                pic.Refresh();
        }

        byte Epsilon { get { return (byte)numericUpDown1.Value; } }
        void GetNeighbours(List<Point> neighbours, Bitmap image, Point start)
        {
            var queue = new Queue<Point>();
            queue.Enqueue(start);
            while (queue.Count != 0)
            {
                var current = queue.Dequeue();
                if (current.X >= 0 && current.X < image.Width &&
                    current.Y >= 0 && current.Y < image.Height && !(
                    image.GetPixel(current).R < Epsilon &&
                    image.GetPixel(current).G < Epsilon &&
                    image.GetPixel(current).B < Epsilon))
                {
                    image.SetPixel(current, Color.FromArgb(255, 0, 0, 0));
                    neighbours.Add(current);
                    queue.Enqueue(new Point(current.X + 1, current.Y));
                    queue.Enqueue(new Point(current.X - 1, current.Y));
                    queue.Enqueue(new Point(current.X, current.Y + 1));
                    queue.Enqueue(new Point(current.X, current.Y - 1));
                }
            }
        }

        void ChangeImage(PictureBox pictureBox)
        {
            openFileDialog1.ShowDialog();
            pictureBox.Image = Image.FromFile(openFileDialog1.FileName);
            pictureBox3.Image = GetDifference(pictureBox1, pictureBox2);
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            ChangeImage(pictureBox1);
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            ChangeImage(pictureBox2);
        }
    }
}
