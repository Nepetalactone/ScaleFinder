﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScaleFinderConsole
{
    public class ScaleFinderController
    {
        private readonly Scale[] _scales;
        private readonly Chord[] _chords;

        public ScaleFinderController()
        {
            _scales = new Scale[]{
                new Scale("101011010101", "Major"),
                new Scale("101101011010", "Natural Minor"),
                new Scale("101101011001", "Harmonic Minor"),
                new Scale("101101010101", "Melodic Minor"),
                new Scale("101001010100", "Pentatonic Major"),
                new Scale("100101010010", "PentatonicMinor"),
                new Scale("100101110010", "Pentatonic Blues"),
                new Scale("101001010010", "Pentatonic Neutral"),
                new Scale("101011010101", "Ionian"),
                new Scale("101101011010", "Aeolian"),
                new Scale("101101010110", "Dorian"),
                new Scale("101011010110", "Mixolydian"),
                new Scale("110101011010", "Phrygian"),
                new Scale("101010110101", "Lydian"),
                new Scale("110101101010", "Locrian"),
                new Scale("110110110110", "Dim Half"),
                new Scale("101101101101", "Dim Whole"),
                new Scale("101010101010", "Whole"),
                new Scale("100110011001", "Augmented"),
                new Scale("101100110110", "Romanian Minor"),
                new Scale("110011011010", "Spanish Gypsy"),
                new Scale("100101110010", "Blues"),
                new Scale("101010010100", "Diatonic"),
                new Scale("110011011001", "Double Harmonic"),
                new Scale("110111101010", "Eight Tone Spanish"),
                new Scale("110010101011", "Enigmatic"),
                new Scale("101010101110", "Leading Whole Tone"),
                new Scale("101010101101", "Lydian Augmented"),
                new Scale("110101010101", "Neopolitan Major"),
                new Scale("110101011010", "Neopolitan Minor"),
                new Scale("110100100011", "Pelog"),
                new Scale("101010100110", "Prometheus"),
                new Scale("110010100110", "Prometheus Neopolitan"),
                new Scale("110011001100", "Six Tone Symmetrical"),
                new Scale("110110101010", "Super Locrian"),
                new Scale("101010111010", "Lydian Minor"),
                new Scale("101100111010", "Lydian Diminished"),
                new Scale("101110111101", "Nine Tone"),
                new Scale("101101101101", "Auxiliary Diminished"),
                new Scale("101010101010", "Auxiliary Augmented"),
                new Scale("110110110110", "Auxiliary Diminished"),
                new Scale("101011101010", "Major Locrian"),
                new Scale("101010110110", "Overtone"),
                new Scale("110110101010", "Diminished Whole Tone"),
                new Scale("101101011010", "Pure Minor"),
                new Scale("101001010110", "Dominant 7th")
            };

            _chords = new Chord[]{
                new Chord("10001001", "Major", "Maj"),
                new Chord("10010001", "Minor", "Min"),
                new Chord("100010001", "Augmented", "Aug"),
                new Chord("1001001", "Diminished", "Dim"),
                new Chord("10100001", "Suspended Second", "Sus2"),
                new Chord("10000101", "Suspended Fourth", "Sus4"),
                new Chord("1000100101", "Sixth", "6"),
                new Chord("1001000101", "Minor Sixth", "min6"),
                new Chord("10001001001", "Seventh", "7"),
                new Chord("100010010001", "Major Seventh", "maj7"),
                new Chord("10010001001", "Minor Seventh", "min7"),
                new Chord("100100010001", "Minor Major Seventh", "minMaj7"),
                new Chord("1001001001", "Diminished Seventh", "dim7"),
                new Chord("10010010001", "Half Diminished", "min7b5"),
                new Chord("10001010001", "Seventh Diminished Fifth", "7b5"),
                new Chord("10001000101", "Seventh Augmented Fifth", "7#5"),
                new Chord("100010100001", "Major Seventh Diminished Fifth", "maj7b5"),
                new Chord("100010001001", "Major Seventh Augmented Fifth", "maj7#5"),
                new Chord("10000101001", "Seventh Suspended Fourth", "7Sus4"),
                new Chord("10000100101", "Seventh Suspended Fourth Augmented Fifth", "7sus4#5")
            };
        }

        public String[] GetScaleNames()
        {
            List<String> scaleNameList = new List<string>();
            foreach (Scale scale in _scales)
            {
                scaleNameList.Add(scale.Name);
            }
            return scaleNameList.ToArray();
        }

        public String[] GetPossibleChordsInScale(String scaleName, String keyString)
        {
            List<String> possibleChords = new List<string>();
            Scale scale = (from tempScale in _scales
                        where tempScale.Name.Equals(scaleName)
                        select tempScale).FirstOrDefault();

            Note key;
            Enum.TryParse(keyString, out key);
            scale.Key = key;

            foreach (Chord chord in _chords)
            {
                if (scale.IsChordInScale(chord))
                {
                    possibleChords.Add(chord.ShortName);
                }
            }
            return possibleChords.ToArray();
        }

        public String[] GetChordNotes(String chordName)
        {
            List<String> noteList = new List<string>();
            Chord chord = (from tempChord in _chords
                where tempChord.Name.Equals(chordName)
                select tempChord).FirstOrDefault();

            foreach (Note note in chord.Notes)
            {
                noteList.Add(note.ToStringManual());
            }

            return noteList.ToArray();
        }

        public String[] GetNotes()
        {
            List<String> noteList = new List<string>();
            foreach (Note note in Enum.GetValues(typeof (Note)))
            {
                noteList.Add(note.ToStringManual());
            }
            return noteList.ToArray();
        }

        public String[] GetScaleNotes(String scaleName, String keyString)
        {

            keyString = keyString.Replace("#", "Sharp");

            List<String> noteList = new List<string>();
            Scale scale = (from tempScale in _scales
                where tempScale.Name.Equals(scaleName)
                select tempScale).FirstOrDefault();

            Note key;
            Enum.TryParse(keyString, out key);
            scale.Key = key;

            foreach (Note note in scale.Notes)
            {
                noteList.Add(note.ToStringManual());
            }
            return noteList.ToArray();
        }
    }
}
