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
        public Tone Key { get; private set; }

        private readonly List<Tone> _notes; 

        public Scale(short[] intervals, Tone key)
        {
            Intervals = intervals;
            Key = key;
            _notes = new List<Tone>();
            GetNotesFromIntervals();
        }

        private void GetNotesFromIntervals()
        {
            _notes.Add(Key);
            short curTone = (short) Key;

            foreach (short interval in Intervals)
            {
                curTone += interval;
                if (curTone >= 12)
                {
                    curTone -= 12;
                }

                _notes.Add((Tone)curTone);
            }
        }

        public bool IsChordInScale(Chord chord)
        {
            foreach (Tone tone in chord.Notes)
            {
                if (!_notes.Contains(tone))
                {
                    return false;
                }
            }

            return true;
        }
    }
}
