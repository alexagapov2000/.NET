using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Tjuring_Machine_Term_Paper
{
    public partial class HelpForm : Form
    {
        public HelpForm()
        {
            InitializeComponent();
            Tips.Text =
                "В левом нижнем углу программы находится поле ввода, куда можно записать команды для машины Тьюринга\n" +
                "Команды выглядят следующим образом:\n" +
                "q[буквы и цифры] [буква алфавита] -> q[буквы и цифры] [буква алфавита] [направление]\n" +
                "Например: qMyState1 # -> qMyState2 0 R\n" +
                "Эта инструкция означает, что если машина находится в состоянии qMyState1\n" +
                "и указывает на пробел (#), то она перейдет в состояние qMyState2, вместо пробела запишет 0 и перейдет\n" +
                "на одну ячейку вправо." +
                "Для перемещения указателя нужно использовать буквы r (R), l (L), s (S)\n" +
                "Если не будет указано никакой буквы, регистрация команд завершится аварийно\n";
            Width = Tips.Width + 36;
        }

        private void OKButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
