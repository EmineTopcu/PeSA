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

        static public List<string> ShiftPeptides(List<string> peptidesToShift, char keyAA,
            int pepsize, int midpoint, out List<string> replacements)
        {
            List<string> peptidesShifted = new();
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
