using System;

namespace Tjuring_Machine_Term_Paper
{
    public class PreviousSetting : IComparable<PreviousSetting>
    {
        public string State { get; private set; }
        public char Letter { get; private set; }

        public PreviousSetting(string state, char letter)
        {
            State = state;
            Letter = letter;
        }

        public int CompareTo(PreviousSetting other)
        {
            var first = this.State + this.Letter;
            var second = other.State + other.Letter;
            return first.CompareTo(second);
        }
    }

    public class NewSetting
    {
        public string State { get; private set; }
        public char Letter { get; private set; }
        public Direction? Way { get; private set; }

        public NewSetting(string state, char letter, Direction? way = null)
        {
            State = state;
            Letter = letter;
            Way = way;
        }

        public NewSetting(string state, char letter, char way = 'S')
            : this(state, letter, null)
        {
            if (way == 'l' || way == 'L')
                Way = Direction.Left;
            else if (way == 'r' || way == 'R')
                Way = Direction.Right;
        }
    }
}
