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

        public Scale(List<Tone> notes, Tone key)
        {
            _notes = notes;
            Key = key;
            GetIntervalsFromNotes();
        }

        public Scale(String pattern)
        {
            _notes = new List<Tone>();
            GetNotesFromPattern(pattern);
            GetIntervalsFromNotes();
        }

        private void GetNotesFromPattern(String pattern)
        {
 	        int i = 0;
            foreach (char c in pattern.Reverse())
            {
                if (c.Equals('1'))
                {
                    Tone x;
                    Enum.TryParse(i.ToString(), out x);
                    _notes.Add(x);
                } else if (c.Equals('0'))
                { }

                i++;
            }
        }

        private void GetIntervalsFromNotes()
        {
            short i = 1;
            List<short> intervalList = new List<short>();
            foreach (Tone t in Enum.GetValues(typeof(Tone)))
            {
                if (_notes.Contains(t))
                {
                    intervalList.Add(i);
                } 
                else
                {
                    i++;
                }
            }
            Intervals = intervalList.ToArray();
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
