using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PTMAnalysisEngine
{
    partial class Analyzer
    {
        /// <summary>
        /// Dictionary of discrimination factor for each char at every position: D = Avrg(v[i!=j]) / v[i] - 1
        /// </summary>
        /// <param name="PA"></param>
        /// <returns></returns>
        static public Dictionary<int, Dictionary<char, double>> GenerateDiscriminationFactors(PermutationArray PA, out List<char> ExistingAminoAcids)
        {
            ExistingAminoAcids = new List<char>();
            try
            {
                Dictionary<int, double> totalWeightsPerPos;
                Dictionary<int, Dictionary<char, double>> weights;
                int pepsize = PA.ModifiedPeptides[0].Length;

                totalWeightsPerPos = new Dictionary<int, double>();
                weights = new Dictionary<int, Dictionary<char, double>>();
                for (int i = 0; i < pepsize; i++)
                {
                    totalWeightsPerPos.Add(i, 0);
                    weights.Add(i, new Dictionary<char, double>());
                }

                foreach (string s in PA.ModifiedPeptides)
                {
                    for (int i = 0; i < pepsize; i++)
                    {
                        char c = s[i];
                        if (!ExistingAminoAcids.Contains(c))
                            ExistingAminoAcids.Add(c);
                        if (c == PA.WildTypePeptide[i])
                        {
                            if (weights[i].ContainsKey(c))
                                continue; //skip wildtype char if already added
                        }

                        double weight = PA.PeptideWeights[s];
                        totalWeightsPerPos[i] += weight;
                        weights[i].Add(c, weight);
                        break;//there can be one aa change per peptide
                    }
                }
                for (int i = 0; i < pepsize; i++)
                {
                    List<char> charlist = weights[i].Keys.ToList();
                    foreach (char c in charlist)
                    {
                        weights[i][c] /= totalWeightsPerPos[i];
                        /*double curWeight = weights[i][c];
                        double avrRest = (totalWeightsPerPos[i] - curWeight) / (weights[i].Count - 1);
                        if (curWeight == avrRest)
                            weights[i][c] = 1;
                        else 
                            weights[i][c] = curWeight / (curWeight - avrRest); //avrRest / curWeight - 1;*/
                    }
                }
                return weights;
            }
            catch (Exception exc)
            {
                //Logger.Log(LogEntryType.SevereException, exc);
                return null;
            }
        }

    }
}
