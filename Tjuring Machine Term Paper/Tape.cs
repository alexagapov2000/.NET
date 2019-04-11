using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace Tjuring_Machine_Term_Paper
{
    public partial class Tape : SelectablePanel
    {
        public delegate void SelectDelegate();
        public static SelectDelegate SelectStatic;

        #region change_pointer_on_click
        public delegate void ChangePointerOnClickDelegate(Cell cell);
        public static ChangePointerOnClickDelegate ChangePointerOnClickStatic;
        public void ChangePointerOnClick(Cell cell)
        {
            var currentNode = Cells.First;
            while (true)
                if (currentNode.Value == cell)
                {
                    Pointer = currentNode;
                    return;
                }
                else
                    currentNode = currentNode.Next;
        }
        #endregion

        public LinkedList<Cell> Cells { get; set; }

        #region pointer
        private LinkedListNode<Cell> pointer;
        public LinkedListNode<Cell> Pointer
        {
            get { return pointer; }
            set
            {
                if (pointer != null)
                    pointer.Value.BackColor = Color.White;
                pointer = value;
                if (pointer != null)
                    pointer.Value.BackColor = Color.LightSkyBlue;
            }
        }
        #endregion

        #region regex
        private Regex Regex;
        private Regex InitializeRegex()
        {
            var state = "(q[a-zA-Z0-9]+)";
            var letter = "([a-zA-Z0-9#])";
            var arrow = "(->)";
            var direction = "([RLSrls])";
            return new Regex("^([ ]*)" +
                state + "([ ]+)" + letter + "([ ]*)" +
                arrow + "([ ]*)" +
                state + "([ ]+)" + letter + "([ ]*)" + direction + "([ ]*)$");
        }
        #endregion

        public Tape(int width, int height = 72, int cellsCount = 20)
        {
            Size = new Size(width, height);
            BorderStyle = BorderStyle.FixedSingle;
            Cells = new LinkedList<Cell>();
            Anchor = AnchorStyles.Left | AnchorStyles.Right | AnchorStyles.Top;
            for (int i = 0; i < cellsCount / 2; i++)
                AddCell(Direction.Left);
            Pointer = Cells.Last;
            for (int i = 0; i < cellsCount / 2; i++)
                AddCell(Direction.Right);
            Regex = InitializeRegex();
            CurrentState = "q1";
            MoveStatic = MoveTape;
            SelectStatic = Select;
            ChangePointerOnClickStatic = ChangePointerOnClick;
        }

        public LinkedListNode<Cell> AddCell(Direction direction)
        {
            var offset = (int)direction * Size.Height;
            var prevCell = direction == Direction.Left ? Cells.First : Cells.Last;
            var prevCellLocation = prevCell?.Value.Location;
            var cell = new Cell(Size.Height, (prevCellLocation ?? 0) + offset);
            Controls.Add(cell);
            if (direction == Direction.Left)
            {
                Cells.AddFirst(cell);
                return Cells.First;
            }
            else
            {
                Cells.AddLast(cell);
                return Cells.Last;
            }
        }

        public bool IsCenteredPointer { get; set; }
        public void ChangePointer(Direction? direction)
        {
            if (direction == null)
                return;
            var nextPointer = direction == Direction.Left ? Pointer.Previous : Pointer.Next;
            if (nextPointer == null)
                nextPointer = AddCell(direction.Value);
            Pointer = nextPointer;
            if (IsCenteredPointer)
                MoveTape(-Pointer.Value.ImaginaryLocation + Size.Width / 2);
        }

        protected override void OnKeyDown(KeyEventArgs args)
        {
            base.OnKeyDown(args);
            switch (args.KeyCode)
            {
                case Keys.Back:
                    Pointer.Value.Letter = '#';
                    ChangePointer(Direction.Left); return;
                case Keys.Left:
                    ChangePointer(Direction.Left); return;
                case Keys.Right:
                    ChangePointer(Direction.Right); return;
                case Keys.Enter:
                    MoveTape(-Pointer.Value.ImaginaryLocation + Size.Width / 2);
                    IsCenteredPointer = !IsCenteredPointer; return;
                case Keys.Space:
                    Pointer.Value.Letter = '#';
                    ChangePointer(Direction.Right); return;
            }
            var letter = (char)args.KeyValue;
            if (char.IsLetter(letter) && !args.Shift)
                letter = (char)(letter - 'A' + 'a');
            if (char.IsLetter(letter) || char.IsDigit(letter))
            {
                Pointer.Value.Letter = letter;
                ChangePointer(Direction.Right);
            }
        }

        #region register_commands
        public SortedDictionary<PreviousSetting, NewSetting> Commands { get; set; }

        private void AddNewCommand(Match match)
        {
            var previousSetting = new PreviousSetting(
                    match.Groups[2].Value,
                    match.Groups[4].Value[0]);
            var newSetting = new NewSetting(
                match.Groups[8].Value,
                match.Groups[10].Value[0],
                match.Groups[12].Value[0]);
            Commands[previousSetting] = newSetting;
        }

        private bool WrongCommandMessage(string message)
        {
            MessageBox.Show(message);
            Commands = null;
            return false;
        }

        public bool RegisterCommands(string[] commandsStrings)
        {
            commandsStrings = commandsStrings.Where(x => !string.IsNullOrEmpty(x)).ToArray();
            Commands = new SortedDictionary<PreviousSetting, NewSetting>();
            for (int i = 0; i < commandsStrings.Length; i++)
            {
                var match = Regex.Match(commandsStrings[i]);
                if (!match.Success)
                    return WrongCommandMessage($"Illegal input in line {i}, commands are not saved!");
                AddNewCommand(match);
            }
            if (Commands == null || Commands.Count == 0)
                return WrongCommandMessage("Commands list is empty!");
            if (!Commands.Any(x => x.Value.State == "q0"))
                return WrongCommandMessage("There is no state 'q0', Commands are not saved!");
            return Commands != null;
        }
        #endregion

        #region handling
        public string CurrentState { get; set; }
        public void OneStep(string[] commandsStrings, bool isSuccessMessage = true)
        {
            if (Commands == null)
                if (!RegisterCommands(commandsStrings))
                    return;
            if (CurrentState == "q0")
            {
                if (isSuccessMessage)
                    MessageBox.Show("Program succesfully ended!");
                CurrentState = "q1";
                return;
            }
            var previousSetting = new PreviousSetting(CurrentState, Pointer.Value.Letter);
            if (!Commands.ContainsKey(previousSetting))
            {
                MessageBox.Show($"There is no commands for set ({CurrentState}, {pointer.Value.Letter})");
                CurrentState = "q1";
                return;
            }
            var newSetting = Commands[previousSetting];
            CurrentState = newSetting.State;
            Pointer.Value.Letter = newSetting.Letter;
            ChangePointer(newSetting.Way);
        }

        public void Total(string[] commandsStrings)
        {
            IsCenteredPointer = false;
            if (Commands == null)
                if (!RegisterCommands(commandsStrings))
                    return;
            while (
                Commands.ContainsKey(new PreviousSetting(CurrentState, Pointer.Value.Letter)) &&
                CurrentState != "q0")
                OneStep(commandsStrings);
            OneStep(commandsStrings, false);
        }
        #endregion

        #region get_current_unary_number_as_decimal
        private LinkedListNode<Cell> GetFirstDigitOfNumber(LinkedListNode<Cell> current)
        {
            if (current.Value.Letter != '#')
                while (current.Previous != null && current.Previous.Value.Letter != '#')
                    current = current.Previous;
            else
                current = current.Next;
            return current;
        }

        public int? UnaryNumberUnderPointer()
        {
            var firstCell = GetFirstDigitOfNumber(Pointer);
            var number = GetNumber(firstCell);
            if (number.Any(x => x != '1'))
                return null;
            else
                return number.Sum(x => int.Parse(x.ToString()));
        }

        public IEnumerable<char> GetNumber(LinkedListNode<Cell> current)
        {
            while (current != null && current.Value.Letter != '#')
            {
                yield return current.Value.Letter;
                current = current.Next;
            }
        }
        #endregion
    }
}