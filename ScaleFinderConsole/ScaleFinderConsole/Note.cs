using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaleFinderConsole
{
    public enum Note
    {
        C = 0, 
        CSharp = 1, 
        D = 2, 
        DSharp = 3, 
        E = 4, 
        F = 5, 
        FSharp = 6, 
        G = 7,
        GSharp = 8, 
        A = 9, 
        ASharp = 10, 
        B = 11
    }

    public static class Extensions
    {
        public static String ToStringManual(this Note note)
        {
            switch (note)
            {
                case Note.A:
                    return "A";
                case Note.ASharp:
                    return "A#";
                case Note.B:
                    return "B";
                case Note.C:
                    return "C";
                case Note.CSharp:
                    return "C#";
                case Note.D:
                    return "D";
                case Note.DSharp:
                    return "D#";
                case Note.E:
                    return "E";
                case Note.F:
                    return "F";
                case Note.FSharp:
                    return "F#";
                case Note.G:
                    return "G";
                case Note.GSharp:
                    return "G#";
                default:
                    return "ERROR";
            }
        }
    }
}
