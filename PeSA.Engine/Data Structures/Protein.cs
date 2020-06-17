using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Permissions;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace PeSA.Engine.Data_Structures
{
    //FASTA format
    //   >P01013 GENE X PROTEIN (OVALBUMIN-RELATED)
    //       QIKDLLVSSSTDLDTTLVLVNAIYFKGMWKTAFNAEDTREMPFHVTKQESKPVQMMCMNNSFNVATLPAE
    //       KMKILELPFASGDLSMLVLLPDEVSDLERIEKTINFEKLTEWTNPNTMEKRRVKVYLPQMKIEEKYNLTS
    //       VLMALGMTDLFIPSANLTGISSAESLKISQAVHGAFMELSEDGIEMAGSTGVIEDIKHSPESEQFRADHP
    //       FLFLIKHNPTNTIVYFGRYWSP

    //         1 qikdllvsss tdldttlvlv naiyfkgmwk tafnaedtre mpfhvtkqes kpvqmmcmnn
    //        61 sfnvatlpae kmkilelpfa sgdlsmlvll pdevsdleri ektinfeklt ewtnpntmek
    //       121 rrvkvylpqm kieekynlts vlmalgmtdl fipsanltgi ssaeslkisq avhgafmels
    //       181 edgiemagst gviedikhsp eseqfradhp flflikhnpt ntivyfgryw sp
    public class Protein
    {
        private int startPos = -1;
        private string parseError;
        public string Caption { get; set; }
        public string RawSequence { get; set; }
        public string AASequence { get; set; }
        /// <summary>
        /// One indexed - as read from user entry
        /// </summary>
        public int StartPos { get { return startPos; } }
        public string ParseError { get { return parseError; } }
        public Protein(string rawSequence)
        {
            RawSequence = rawSequence.Trim();
            string[] lines = Regex.Split(RawSequence, "\r\n|\r|\n");
            if (lines.Count() == 0)
            {
                parseError = "Empty string";
                return;
            }
            SetSequence(lines.ToList());
        }
        public Protein(List<string> rawSequenceLines)
        {
            RawSequence = string.Join("\r\n", rawSequenceLines).Trim();
            SetSequence(rawSequenceLines);
        }

        private void SetSequence(List<string> rawSequenceLines)
        {
            int ind = 0;
            if (rawSequenceLines[0].StartsWith(">"))
            {
                Caption = rawSequenceLines[0].Substring(1);
                ind++;
            }
            for (int iter = ind; iter < rawSequenceLines.Count(); iter++)
            {
                string line = rawSequenceLines[iter].Trim();
                if (line.StartsWith(">")) //another protein sequence
                    break;
                if (string.IsNullOrWhiteSpace(line)) 
                    continue;

                if (!Regex.IsMatch(line, @"^\d+[a-zA-Z\s]+") && !Regex.IsMatch(line, @"^[a-zA-Z\s]+")) //wrong format
                {
                    parseError = "Wrong format: " + line;
                    return;
                }
                //parse for the numeric value if exists
                if (Regex.IsMatch(line, @"^\d+[a-zA-Z\s]+"))
                {
                    string numString = Regex.Match(line, @"\d+").Value;
                    if (startPos < 0)
                        startPos = int.Parse(numString);
                    line = line.Replace(numString, "").Trim();
                }
                AASequence += Regex.Replace(line, @"\s+", "");
            }
            parseError = "";
            if (startPos < 0) startPos = 1;
        }

        public static List<Protein> GenerateProteins(string fullText)
        {
            List<string> lines = Regex.Split(fullText, "\r\n|\r|\n").ToList();
            List<Protein> proteins = new List<Protein>();
            List<string> curLines = new List<string>();
            foreach (string line in lines)
            {
                if (line.Trim().StartsWith(">")) //new protein sequence
                {
                    if (curLines.Count() != 0) //not first sequence
                    {
                        Protein p = new Protein(curLines);
                        proteins.Add(p);
                        curLines.Clear();
                    }
                }
                curLines.Add(line.Trim());
            }
            if (curLines.Count() != 0)
            {
                Protein p = new Protein(curLines);
                proteins.Add(p);
                curLines.Clear();
            }

            return proteins;
        }
    }
}
