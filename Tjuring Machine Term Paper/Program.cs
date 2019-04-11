using System;
using System.Windows.Forms;

namespace Tjuring_Machine_Term_Paper
{
    static class Program
    {
        /// <summary>
        /// Главная точка входа для приложения.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new TjuringMachineForm());
        }
    }
}
