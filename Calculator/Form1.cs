using System;
using System.Linq;
using System.Windows.Forms;

namespace LabaForms1
{
    public partial class Form1 : Form
    {
        readonly string digits = "0123456789";
        double Number { get { return double.Parse(numberAsString); } }
        string numberAsString = "0";

        double Buff { get { return double.Parse(buff); } }
        string buff = null;
        bool ContainsDot { get { return numberAsString.Contains(','); } }
        Func<double, double, double> currentOperation;

        public Form1()
        {
            InitializeComponent();
            //Controls.Add(new ButtonWithoutFocus());
        }

        private void Form1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (digits.Contains(e.KeyChar))
            {
                numberAsString += char.ConvertFromUtf32(e.KeyChar);
                if (numberAsString.Substring(0, 2) != "0,")
                    numberAsString = numberAsString.TrimStart('0');
            }
            else if (!ContainsDot && e.KeyChar == ',')
                numberAsString += ",";
            Label.Text = numberAsString;
        }

        private void Round_MouseDown(object sender, MouseEventArgs e)
        {
            numberAsString = Math.Round(Number).ToString();
            Label.Text = numberAsString;
        }

        private void Floor_MouseDown(object sender, MouseEventArgs e)
        {
            numberAsString = Math.Floor(Number).ToString();
            Label.Text = numberAsString;
        }

        private void BackspaceOperation()
        {
            var isMinus = numberAsString[0] == '-' ? 1 : 0;
            var n = numberAsString.Length;
            if (n == 1 + isMinus)
            {
                numberAsString = "0";
                Label.Text = numberAsString;
                return;
            }
            numberAsString = numberAsString.Substring(0, n - 1);
            Label.Text = numberAsString;
        }

        private void Backspace_MouseDown(object sender, MouseEventArgs e) { BackspaceOperation(); }

        private void Operation(Func<double, double, double> func)
        {
            if (buff == null)
                buff = numberAsString;
            else
                buff = func(Buff, Number).ToString();
            numberAsString = "0";
            Label.Text = numberAsString;
            currentOperation = func;
        }

        private void Plus_MouseDown(object sender, MouseEventArgs e) { Operation((x, y) => x + y); }
        private void Minus_MouseDown(object sender, MouseEventArgs e) { Operation((x, y) => x - y); }
        private void Multiply_MouseDown(object sender, MouseEventArgs e) { Operation((x, y) => x * y); }
        private void Divide_MouseDown(object sender, MouseEventArgs e) { Operation((x, y) => x / y); }

        private void EqualsOperation()
        {
            Operation(currentOperation);
            numberAsString = buff;
            buff = null;
            Label.Text = numberAsString;
        }
        private void Equals_MouseDown(object sender, MouseEventArgs e) { EqualsOperation(); }

        private void SetNumber(double value)
        {
            numberAsString = value.ToString();
            Label.Text = numberAsString;
        }

        private void Sin_MouseDown(object sender, MouseEventArgs e) { SetNumber(Math.Sin(Number)); }
        private void Cos_MouseDown(object sender, MouseEventArgs e) { SetNumber(Math.Cos(Number)); }
        private void Tg_MouseDown(object sender, MouseEventArgs e) { SetNumber(Math.Tan(Number)); }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
                EqualsOperation();
            else if (e.KeyCode == Keys.Back)
                BackspaceOperation();
            else if (e.KeyCode == Keys.Add)
                Operation((x, y) => x + y);
            else if (e.KeyCode == Keys.Subtract)
                Operation((x, y) => x - y);
            else if (e.KeyCode == Keys.Multiply)
                Operation((x, y) => x * y);
            else if (e.KeyCode == Keys.Divide)
                Operation((x, y) => x / y);
            else if (e.KeyCode == Keys.S)
                SetNumber(Math.Sin(Number));
            else if (e.KeyCode == Keys.C)
                SetNumber(Math.Cos(Number));
            else if (e.KeyCode == Keys.T)
                SetNumber(Math.Tan(Number));
        }
    }
}
