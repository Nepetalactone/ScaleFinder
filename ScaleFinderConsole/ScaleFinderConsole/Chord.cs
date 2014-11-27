using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaleFinderConsole
{
    class Chord
    {
        public short[] Intervals { get; private set; }
        private Note _rootNote;

        public Note RootNote
        {
            get { return _rootNote; }
            set
            {
                _rootNote = value;
                GetNotesFromIntervals();
            }
        }

        public List<Note> Notes { get; private set; }

        public String  Name { get; private set; }

        public Chord(short[] intervals, String name)
        {
            Intervals = intervals;
            Name = name;
        }

        private void GetNotesFromIntervals()
        {
            Notes = new List<Note>();
            Notes.Add(RootNote);
            short curTone = (short)RootNote;

            foreach (short interval in Intervals)
            {
                curTone += interval;
                if (curTone >= 12)
                {
                    curTone -= 12;
                }

                Notes.Add((Note)curTone);
                curTone = (short)RootNote;
            }
        }
    }
}
