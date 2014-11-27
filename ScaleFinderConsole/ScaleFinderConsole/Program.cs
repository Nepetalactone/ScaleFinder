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
            Scale major = new Scale(new short[]{2,2,1,2,2,2,1}, "Major");
            Chord maj = new Chord(new short[] {4, 7}, "Major");
            Chord sus2 = new Chord(new short[]{2, 7}, "Sus2");

            foreach (Note scaleTone in Enum.GetValues(typeof (Note)))
            {
                major.Key = scaleTone;
                foreach (Note tone in major.Notes)
                {
                    maj.RootNote = tone;
                    Console.WriteLine(maj.RootNote.ToString() + maj.Name + "{0} in {1} {2}",
                        major.IsChordInScale(maj) ? " is" : " is not", major.Key.ToString(), major.Name);
                }
                Console.WriteLine(Environment.NewLine);
            }

            foreach (Note scaleTone in Enum.GetValues(typeof (Note)))
            {
                major.Key = scaleTone;
                foreach (Note tone in major.Notes)
                {
                    sus2.RootNote = tone;
                    Console.WriteLine(sus2.RootNote.ToString() + sus2.Name + "{0} in {1} {2}",
                        major.IsChordInScale(sus2) ? " is" : " is not", major.Key.ToString(), major.Name);

                }
                Console.WriteLine(Environment.NewLine);
            }

            Console.ReadKey();
        }
    }
}
