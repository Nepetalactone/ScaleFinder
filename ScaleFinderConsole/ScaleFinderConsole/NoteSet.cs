using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaleFinderConsole
{
    abstract class NoteSet
    {
        public short[] Intervals { get; protected set; }
        private Note _key;
        public Note Key
        {
            get
            { 
                return _key; 
            }
            set
            {
                _key = value;
                Notes = GetNotesFromIntervals(Intervals);
            }
        }
        public List<Note> Notes { get; protected set; }
        public String Name { get; private set; }

        public NoteSet(String pattern, String name)
        {
            Notes = GetNotesFromPattern(pattern);
            Intervals = GetIntervalsFromNotes(Notes);
            Name = name;
        }

        protected List<Note> GetNotesFromPattern(string pattern)
        {
            int i = 0;
            List<Note> notes = new List<Note>();
            foreach (char c in pattern)
            {
                if (c.Equals('1'))
                {
                    Note x;
                    Enum.TryParse(i.ToString(), out x);
                    notes.Add(x);
                }
                else if (c.Equals('0'))
                { }

                i++;
            }

            return notes;
        }
        protected short[] GetIntervalsFromNotes(List<Note> notes)
        {
            short i = 1;
            List<short> intervalList = new List<short>();
            foreach (Note t in Enum.GetValues(typeof(Note)))
            {
                if (notes.Contains(t))
                {
                    intervalList.Add(i);
                }
                else
                {
                    i++;
                }
            }
            return intervalList.ToArray();
        }
        protected List<Note> GetNotesFromIntervals(short[] intervals)
        {
            List<Note> notes = new List<Note>();
            notes.Add(Key);
            short curNote = (short)Key;

            foreach (short interval in intervals)
            {
                curNote += interval;
                if (curNote >= 12)
                {
                    curNote -= 12;
                }

                notes.Add((Note)curNote);
            }

            return notes;
        }
    }
}
