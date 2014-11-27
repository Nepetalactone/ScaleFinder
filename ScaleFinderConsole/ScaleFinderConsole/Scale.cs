using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaleFinderConsole
{
    class Scale : NoteSet
    {
        public Scale(String pattern):base(pattern)
        {
        }
        public bool IsChordInScale(Chord chord)
        {
            foreach (Tone tone in chord.Notes)
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
