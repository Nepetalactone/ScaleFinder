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
            Scale MajorScale = new Scale("101011010101");
            Scale NaturalMinorScale = new Scale("101101011010");
            Scale HarmonicMinorScale = new Scale("101101011001");
            Scale MelodicMinorScale = new Scale("101101010101");
            Scale PentatonicMajorScale = new Scale("101001010100");
            Scale PentatonicMinorScale = new Scale("100101010010");
            Scale PentatonicBluesScale = new Scale("100101110010");
            Scale PentatonicNeutralScale = new Scale("101001010010");
            Scale IonianScale = new Scale("101011010101");
            Scale AeolianScale = new Scale("101101011010");
            Scale DorianScale = new Scale("101101010110");
            Scale MixolydianScale = new Scale("101011010110");
            Scale PhrygianScale = new Scale("110101011010");
            Scale LydianScale = new Scale("101010110101");
            Scale LocrianScale = new Scale("110101101010");
            Scale DimHalfScale = new Scale("110110110110");
            Scale DimWholeScale = new Scale("101101101101");
            Scale WholeScale = new Scale("101010101010");
            Scale AugmentedScale = new Scale("100110011001");
            Scale RoumanianMinorScale = new Scale("101100110110");
            Scale SpanishGypsyScale = new Scale("110011011010");
            Scale BluesScale = new Scale("100101110010");
            Scale DiatonicScale = new Scale("101010010100");
            Scale DoubleHarmonicScale = new Scale("110011011001");
            Scale EightToneSpanishScale = new Scale("110111101010");
            Scale EnigmaticScale = new Scale("110010101011");
            Scale LeadingWholeToneScale = new Scale("101010101110");
            Scale LydianAugmentedScale = new Scale("101010101101");
            Scale NeoploitanMajorScale = new Scale("110101010101");
            Scale NeopolitanMinorScale = new Scale("110101011010");
            Scale PelogScale = new Scale("110100100011");
            Scale PrometheusScale = new Scale("101010100110");
            Scale PrometheusNeopolitanScale = new Scale("110010100110");
            Scale SixToneSymmetricalScale = new Scale("110011001100");
            Scale SuperLocrianScale = new Scale("110110101010");
            Scale LydianMinorScale = new Scale("101010111010");
            Scale LydianDiminishedScale = new Scale("101100111010");
            Scale NineToneScale = new Scale("101110111101");
            Scale AuxiliaryDiminishedScale = new Scale("101101101101");
            Scale AuxiliaryAugmentedScale = new Scale("101010101010");
            Scale AuxiliaryDiminishedBluesScale = new Scale("110110110110");
            Scale MajorLocrianScale = new Scale("101011101010");
            Scale OvertoneScale = new Scale("101010110110");
            Scale DiminishedWholeToneScale = new Scale("110110101010");
            Scale PureMinorScale = new Scale("101101011010");
            Scale Dominant7thScale = new Scale("101001010110");

            Chord MajorChord = new Chord("10001001");
            Chord MinorChord = new Chord("10010001");
            Chord AugmentedChord = new Chord("100010001");
            Chord DiminishedChord = new Chord("1001001");
            Chord SuspendedChord = new Chord("10100001");
            Chord SuspendedFourthChord = new Chord("10000101");
            Chord SixthChord = new Chord("1000100101");
            Chord MinorSixthChord = new Chord("1001000101");
            Chord SeventhChord = new Chord("10001001001");
            Chord MajorSeventhChord = new Chord("100010010001");
            Chord MinorSeventhChord = new Chord("10010001001");
            Chord MinorMajorSeventhChord = new Chord("100100010001");
            Chord DiminishedSeventhChord = new Chord("1001001001");
            Chord HalfDiminishedChord = new Chord("10010010001");
            Chord SeventhDiminishedFifthChord = new Chord("10001010001");
            Chord SeventhAugmentedFifthChord = new Chord("10001000101");
            Chord MajorSeventhDiminishedFifthChord = new Chord("100010100001");
            Chord MajorSeventhAugmentedFifthChord = new Chord("100010001001");
            Chord SeventhSuspendedFourthChord = new Chord("10000101001");
            Chord SeventhSuspendedFourthAugmentedFifthChord = new Chord("10000100101");

            Console.WriteLine(MajorScale.IsChordInScale(MajorChord));
            MajorChord.Key = Tone.CSharp;
            Console.WriteLine(MajorScale.IsChordInScale(MajorChord));
            Console.ReadKey();
        }
    }
}
