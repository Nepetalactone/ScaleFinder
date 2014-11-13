using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaleFinderConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            Scale cMajor = new Scale(new short[]{2,2,1,2,2,2,1}, Tone.CNormal);
            Chord eMaj = new Chord(new short[] {4, 7}, Tone.CNormal);
        }
    }
}
