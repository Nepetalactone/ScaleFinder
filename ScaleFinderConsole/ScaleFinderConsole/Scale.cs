using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaleFinderConsole
{
    class Scale
    {
        public short[] Intervals { get; private set; }
        private Note _key;
        public Note Key
        {
            get { return _key; }
            set
            {
                _key = value;
                GetNotesFromIntervals();
            }
        }

        public List<Note> Notes { get; private set; }

        public String Name { get; private set; }

        public Scale(short[] intervals, String name)
        {
            Intervals = intervals;
            Name = name;
            Notes = new List<Note>();
            GetNotesFromIntervals();
        }

        private void GetNotesFromIntervals()
        {
            Notes.Add(Key);
            short curTone = (short) Key;

            foreach (short interval in Intervals)
            {
                curTone += interval;
                if (curTone >= 12)
                {
                    curTone -= 12;
                }

                Notes.Add((Note)curTone);
            }
        }

        public bool IsChordInScale(Chord chord)
        {
            foreach (Note tone in chord.Notes)
            {
                if (!Notes.Contains(tone))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
