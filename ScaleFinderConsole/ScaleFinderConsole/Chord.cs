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
        public Tone Key { get; set; }

        public List<Tone> Notes { get; private set; }

        public Chord(short[] intervals, Tone key)
        {
            Intervals = intervals;
            Key = key;
            Notes = new List<Tone>();
        }

        private void GetNotesFromIntervals()
        {
            Notes.Add(Key);
            short curTone = (short)Key;

            foreach (short interval in Intervals)
            {
                curTone += interval;
                if (curTone >= 12)
                {
                    curTone -= 12;
                }

                Notes.Add((Tone)curTone);
            }
        }
    }
}
