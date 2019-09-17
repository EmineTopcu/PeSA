using PeSA.Engine;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PeSA.Engine
{
    public partial class Analyzer
    {
        public const string ProgramName = "PeSA";

        /// <summary>
        /// Dictionary of frequency for each char at every position
        /// </summary>
        /// <param name="peptides"></param>
        /// <returns></returns>
        static public Dictionary<int, Dictionary<char, double>> GenerateFrequencies(List<string> peptides, int pepsize)
        {
            try
            {
                Dictionary<int, Dictionary<char, int>> frequencies;
                Dictionary<int, Dictionary<char, double>> weights;

                int setsize = peptides.Count();
                frequencies = new Dictionary<int, Dictionary<char, int>>();
                weights = new Dictionary<int, Dictionary<char, double>>();
                for (int i = 0; i < pepsize; i++)
                {
                    frequencies.Add(i, new Dictionary<char, int>());
                    weights.Add(i, new Dictionary<char, double>());
                }

                foreach (string s in peptides)
                {
                    int len = Math.Min(pepsize, s.Length);
                    for (int i = 0; i < len; i++)
                    {
                        char c = s[i];
                        if (frequencies[i].ContainsKey(c))
                            frequencies[i][c] += 1;
                        else frequencies[i].Add(c, 1);
                    }
                }
                for (int i = 0; i < pepsize; i++)
                {
                    foreach (char c in frequencies[i].Keys)
                        weights[i].Add(c, (double)frequencies[i][c] / setsize);
                }
                return weights;
            }
            catch 
            {
                return null;
            }
        } 
 
        static public List<string> ShiftPeptides(List<string> peptidesToShift, char keyAA, 
            int pepsize, int midpoint, out List<string> replacements)
        {
            List<string> peptidesShifted = new List<string>();
            replacements = new List<string>();
            int maxshift = pepsize - 1 - midpoint;
            if (midpoint > maxshift)
                maxshift = midpoint;
            foreach (string s in peptidesToShift)
            {
                string s2 = s;
                for (int i = 1; i <= maxshift; i++)
                {
                    if (midpoint - i >= 0 && s[midpoint - i] == keyAA)
                    {
                        for (int j = 0; j < i; j++) s2 = "X" + s2;
                        s2 = s2.Substring(0, pepsize);
                        peptidesShifted.Add(s2);
                        replacements.Add(s + " replaced by " + s2);
                        break;
                    }
                    if (midpoint + i < pepsize && s[midpoint + i] == keyAA)
                    {
                        for (int j = 0; j < i; j++) s2 += "X";
                        s2 = s2.Substring(i, pepsize);
                        peptidesShifted.Add(s2);
                        replacements.Add(s + " replaced by " + s2);
                        break;
                    }
                }
                if (s2 == s)
                    replacements.Add("No replacement for " + s);
                
            }
            return peptidesShifted;
        }

        static public Bitmap CreateMotif(Dictionary<int, Dictionary<char, double>> Weights, 
            double threshold = 0, int widthImage = 800, int heightImage = 200, int maxAAperCol = 20)
        {
            Motif mf = new Motif(Weights);
            if (threshold < 0)
                threshold = 0;

            Bitmap bm = mf.Render(widthImage, heightImage, threshold: threshold, maxAAperCol: maxAAperCol);
            return bm;
        }

        static public Bitmap CreateMotif(List<string> peptides, int pepsize,
            double threshold = 0, int widthImage = 800, int heightImage = 200)
        {
            Dictionary<int, Dictionary<char, double>> Weights = GenerateFrequencies(peptides, pepsize);
            return CreateMotif(Weights, threshold, widthImage, heightImage);
        }


        static public Bitmap CreateMotif(PermutationArray PA)
        {
            Settings settings = Settings.Load("default.settings");
            int heightImage = settings.MotifHeight;
            int widthImage = settings.MotifWidth;
            int maxAAperCol = settings.MotifMaxAAPerColumn;
            return CreateMotif(PA, widthImage, heightImage, maxAAperCol);
        }

        static public Bitmap CreateMotif(PermutationArray PA,
            int widthImage = 800, int heightImage = 200, int maxAAperCol = 10)
        {

            Dictionary<int, Dictionary<char, double>> weights = PA.GenerateWeights();
            return CreateMotif(weights, 0, widthImage, heightImage, maxAAperCol);
        }

        static public Bitmap CreateMotif(OPALArray OA)
        {
            Settings settings = Settings.Load("default.settings");
            int heightImage = 200;
            int widthImage = 800;
            int maxAAperCol = 10;
            if (settings != null)
            {
                heightImage = settings.MotifHeight;
                widthImage = settings.MotifWidth;
                maxAAperCol = settings.MotifMaxAAPerColumn;
            }
            return CreateMotif(OA, widthImage, heightImage, maxAAperCol);
        }

        static public Bitmap CreateMotif(OPALArray OA,
            int widthImage = 800, int heightImage = 200, int maxAAperCol = 10)
        {

            Dictionary<int, Dictionary<char, double>> weights = OA.GenerateWeights();
            return CreateMotif(weights, 0, widthImage, heightImage, maxAAperCol);
        }

        static public bool CheckPeptideList(List<string> peptides, int length, out List<string> warnings, out List<string> errors)
        {
            warnings = new List<string>();
            errors = new List<string>();
            bool ret = true;
            try
            {
                foreach (string p in peptides)
                {
                    if (Regex.Matches(p, @"[a-zA-Z]").Count < p.Length)
                        errors.Add("Invalid characters in " + p);
                    else
                    {
                        if (p.Length < length)
                            warnings.Add("Length inconsistency in " + p);
                        foreach (char c in p.Substring(0, Math.Min(p.Length, length)))
                            if (!AminoAcids.IsStandardAminoAcid(c))
                            {
                                warnings.Add("Non-standard amino acid in " + p);
                                break;
                            }
                    }
                }
                return ret;
            }
            catch (Exception exc)
            {
                errors.Add("Unhandled exception: " + exc.Message);
                return false;
            }
        }



    }
}
