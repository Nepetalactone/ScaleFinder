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
        
        public Chord(String pattern)
        {
            Notes = new List<Tone>();
            GetNotesFromPattern(pattern);
            GetIntervalsFromNotes();
        }

        private void GetNotesFromPattern(string pattern)
        {
            int i = 0;
            foreach (char c in pattern.Reverse())
            {
                if (c.Equals('1'))
                {
                    Tone x;
                    Enum.TryParse(i.ToString(), out x);
                    Notes.Add(x);
                }
                else if (c.Equals('0'))
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
                if (Notes.Contains(t))
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
