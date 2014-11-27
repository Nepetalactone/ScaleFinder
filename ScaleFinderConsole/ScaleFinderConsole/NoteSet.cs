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
        private Tone _key;
        public Tone Key
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
        public List<Tone> Notes { get; protected set; }
        public String Name { get; private set; }

        public NoteSet(String pattern, String name)
        {
            Notes = GetNotesFromPattern(pattern);
            Intervals = GetIntervalsFromNotes(Notes);
            Name = name;
        }

        protected List<Tone> GetNotesFromPattern(string pattern)
        {
            int i = 0;
            List<Tone> notes = new List<Tone>();
            foreach (char c in pattern)
            {
                if (c.Equals('1'))
                {
                    Tone x;
                    Enum.TryParse(i.ToString(), out x);
                    notes.Add(x);
                }
                else if (c.Equals('0'))
                { }

                i++;
            }

            return notes;
        }
        protected short[] GetIntervalsFromNotes(List<Tone> notes)
        {
            short i = 1;
            List<short> intervalList = new List<short>();
            foreach (Tone t in Enum.GetValues(typeof(Tone)))
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
        protected List<Tone> GetNotesFromIntervals(short[] intervals)
        {
            List<Tone> notes = new List<Tone>();
            notes.Add(Key);
            short curTone = (short)Key;

            foreach (short interval in intervals)
            {
                curTone += interval;
                if (curTone >= 12)
                {
                    curTone -= 12;
                }

                notes.Add((Tone)curTone);
            }

            return notes;
        }
    }
}
