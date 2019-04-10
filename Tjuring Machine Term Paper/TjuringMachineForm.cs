using Microsoft.VisualBasic;
using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace Tjuring_Machine_Term_Paper
{
    public partial class TjuringMachineForm : Form
    {
        Tape Tape;
        public TjuringMachineForm()
        {
            InitializeComponent();
            Tape = new Tape(Width - 18, 50, 20);
            Controls.Add(Tape);
            PressEnterTip.Location = new Point(0, Tape.Size.Height);
            UnaryTip.Location = new Point(0, Tape.Size.Height + PressEnterTip.Size.Height);
            Tape.MoveTape(Tape.Pointer.Value.ImaginaryLocation + Tape.Width / 2);
            CheckSavedFiles();
        }

        private void CommandsBox_TextChanged(object sender, EventArgs e)
        {
            Tape.Commands = null;
        }

        private void CheckSavedFiles()
        {
            SavedInstructionsList.Items.Clear();
            var files = Directory.GetFiles(Environment.CurrentDirectory)
                .Where(x => Path.GetExtension(x) == ".txt")
                .Select(Path.GetFileName);
            SavedInstructionsList.Items.AddRange(files.ToArray());
        }

        private void SavedInstructionsList_SelectedIndexChanged(object sender, EventArgs e)
        {
            var selected = SavedInstructionsList.Items[SavedInstructionsList.SelectedIndex]
                as string;
            CommandsBox.Text = File.ReadAllText(selected);
        }

        private void ResetStateButton_Click(object sender, EventArgs e)
        {
            Tape.CurrentState = "q1";
            StateTip.Text = Tape.CurrentState;
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            var name = Interaction.InputBox(
                "Enter name of the file\n" +
                "(without extension .txt)");
            if (name != "")
                using (StreamWriter file = new StreamWriter($"{name}.txt"))
                    file.WriteLine(CommandsBox.Text);
            CheckSavedFiles();
        }

        #region steps
        private void OneStepButton_Click(object sender, EventArgs e)
        {
            Tape.OneStep(CommandsBox.Lines);
            StateTip.Text = Tape?.CurrentState ?? "q1";
        }
        private void TotalButton_Click(object sender, EventArgs e)
        {
            Tape.Total(CommandsBox.Lines);
            StateTip.Text = Tape?.CurrentState ?? "q1";
        }
        #endregion

        private void HelpButton_Click(object sender, EventArgs e)
        {
            new HelpForm().ShowDialog();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            UnaryTip.Text = "Unary on decimal: " + Tape.UnaryNumberUnderPointer().ToString();
        }
    }
}
