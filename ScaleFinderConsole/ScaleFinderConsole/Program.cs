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
            Scale MajorScale = new Scale("101011010101", "Major");
            Scale NaturalMinorScale = new Scale("101101011010", "Natural Minor");
            Scale HarmonicMinorScale = new Scale("101101011001", "Harmonic Minor");
            Scale MelodicMinorScale = new Scale("101101010101", "Melodic Minor");
            Scale PentatonicMajorScale = new Scale("101001010100", "Pentatonic Major");
            Scale PentatonicMinorScale = new Scale("100101010010", "PentatonicMinor");
            Scale PentatonicBluesScale = new Scale("100101110010", "Pentatonic Blues");
            Scale PentatonicNeutralScale = new Scale("101001010010", "Pentatonic Neutral");
            Scale IonianScale = new Scale("101011010101", "Ionian");
            Scale AeolianScale = new Scale("101101011010", "Aeolian");
            Scale DorianScale = new Scale("101101010110", "Dorian");
            Scale MixolydianScale = new Scale("101011010110", "Mixolydian");
            Scale PhrygianScale = new Scale("110101011010", "Phrygian");
            Scale LydianScale = new Scale("101010110101", "Lydian");
            Scale LocrianScale = new Scale("110101101010", "Locrian");
            Scale DimHalfScale = new Scale("110110110110", "Dim Half");
            Scale DimWholeScale = new Scale("101101101101", "Dim Whole");
            Scale WholeScale = new Scale("101010101010", "Whole");
            Scale AugmentedScale = new Scale("100110011001", "Augmented");
            Scale RomanianMinorScale = new Scale("101100110110", "Romanian Minor");
            Scale SpanishGypsyScale = new Scale("110011011010", "Spanish Gypsy");
            Scale BluesScale = new Scale("100101110010", "Blues");
            Scale DiatonicScale = new Scale("101010010100", "Diatonic");
            Scale DoubleHarmonicScale = new Scale("110011011001", "Double Harmonic");
            Scale EightToneSpanishScale = new Scale("110111101010", "Eight Tone Spanish");
            Scale EnigmaticScale = new Scale("110010101011", "Enigmatic");
            Scale LeadingWholeToneScale = new Scale("101010101110", "Leading Whole Tone");
            Scale LydianAugmentedScale = new Scale("101010101101", "Lydian Augmented");
            Scale NeopolitanMajorScale = new Scale("110101010101", "Neopolitan Major");
            Scale NeopolitanMinorScale = new Scale("110101011010", "Neopolitan Minor");
            Scale PelogScale = new Scale("110100100011", "Pelog");
            Scale PrometheusScale = new Scale("101010100110", "Prometheus");
            Scale PrometheusNeopolitanScale = new Scale("110010100110", "Prometheus Neopolitan");
            Scale SixToneSymmetricalScale = new Scale("110011001100", "Six Tone Symmetrical");
            Scale SuperLocrianScale = new Scale("110110101010", "Super Locrian");
            Scale LydianMinorScale = new Scale("101010111010", "Lydian Minor");
            Scale LydianDiminishedScale = new Scale("101100111010", "Lydian Diminished");
            Scale NineToneScale = new Scale("101110111101", "Nine Tone");
            Scale AuxiliaryDiminishedScale = new Scale("101101101101", "Auxiliary Diminished");
            Scale AuxiliaryAugmentedScale = new Scale("101010101010", "Auxiliary Augmented");
            Scale AuxiliaryDiminishedBluesScale = new Scale("110110110110", "Auxiliary Diminished");
            Scale MajorLocrianScale = new Scale("101011101010", "Major Locrian");
            Scale OvertoneScale = new Scale("101010110110", "Overtone");
            Scale DiminishedWholeToneScale = new Scale("110110101010", "Diminished Whole Tone");
            Scale PureMinorScale = new Scale("101101011010", "Pure Minor");
            Scale Dominant7thScale = new Scale("101001010110", "Dominant 7th");

            Chord MajorChord = new Chord("10001001", "Major");
            Chord MinorChord = new Chord("10010001", "Minor");
            Chord AugmentedChord = new Chord("100010001", "Augmented");
            Chord DiminishedChord = new Chord("1001001", "Diminished");
            Chord SuspendedChord = new Chord("10100001", "Suspended");
            Chord SuspendedFourthChord = new Chord("10000101", "Suspended");
            Chord SixthChord = new Chord("1000100101", "Sixth");
            Chord MinorSixthChord = new Chord("1001000101", "Minor Sixth");
            Chord SeventhChord = new Chord("10001001001", "Seventh");
            Chord MajorSeventhChord = new Chord("100010010001", "Major Seventh");
            Chord MinorSeventhChord = new Chord("10010001001", "Minor Seventh");
            Chord MinorMajorSeventhChord = new Chord("100100010001", "Minor Major Seventh");
            Chord DiminishedSeventhChord = new Chord("1001001001", "Diminished Seventh");
            Chord HalfDiminishedChord = new Chord("10010010001", "Half Diminished");
            Chord SeventhDiminishedFifthChord = new Chord("10001010001", "Seventh Diminished Fifth");
            Chord SeventhAugmentedFifthChord = new Chord("10001000101", "Seventh Augmented Fifth");
            Chord MajorSeventhDiminishedFifthChord = new Chord("100010100001", "Major Seventh Diminished Fifth");
            Chord MajorSeventhAugmentedFifthChord = new Chord("100010001001", "Major Seventh Augmented Fifth");
            Chord SeventhSuspendedFourthChord = new Chord("10000101001", "Seventh Suspended Fourth");
            Chord SeventhSuspendedFourthAugmentedFifthChord = new Chord("10000100101", "Seventh Suspended Fourth Augmented Fifth");

            Console.WriteLine(MajorScale.IsChordInScale(MajorChord));
            MajorChord.Key = Note.CSharp;
            Console.WriteLine(MajorScale.IsChordInScale(MajorChord));
            Console.ReadKey();
        }
    }
}
