using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace PeSA.Engine
{
    public class SequenceGenerator
    {
        static private bool CheckTemplate(string template)
        {
            //Accepted formats: ABC[DEF]ABC[{DE}{GHI}L][-ABC]
            // (\[-(\[A-Z]*\])  [-ABC]
            // (\[[a-zA-Z]*\])  [AbC]
            // (\[(\{[A-Z]*\}|[a-zA-Z])*\])  [{AB}{CD}E]
            // [a-zA-Z]    ABC
            string regexstring = @"^([a-zA-Z]|(\[[a-zA-Z]*\])|(\[-[A-Z]*\])|\[(\{[A-Z]*\}|[a-zA-Z])*\])*$";
            bool match = Regex.IsMatch(template, regexstring);
            return match;
        }

        static public List<string> Combinations(string input) 
        {
            input = input.Trim();
            if (!CheckTemplate(input))
                return null;
            return GenerateCombinations(input);
        }

        static private List<string> GenerateCombinations(string input)
        {
            int start = input.IndexOf('[');
            if (start < 0) return new List<string>() { input };

            int end = input.IndexOf(']', start + 1);
            if (end < 0) throw new Exception();
            List<string> comb = new List<string>();

            string chars = input.Substring(start + 1, end - start - 1);
            string firstpart = start > 0 ? input.Substring(0, start) : "";
            string lastpart = end < input.Length - 1 ? input.Substring(end + 1) : "";
            if (chars.Substring(0, 1) == "-" || chars == "X") //use all aminoacids except the ones listed - X: use all
            {
                string charstouse = "";
                foreach (AminoAcid aa in AminoAcids.GetAminoAcidList())
                {
                    if (!chars.Contains(aa.Abbrev1))
                        charstouse += aa.Abbrev1;
                }
                chars = charstouse;
            }
            List<string> withinbrackets = new List<string>();
            while (chars != "")
            {
                char c = chars.First();
                if (c == '{')
                {
                    end = chars.IndexOf('}', 1);
                    if (end < 0) throw new Exception();
                    withinbrackets.Add(chars.Substring(1, end - 1));
                    chars = chars.Substring(end + 1);
                    continue;
                }
                withinbrackets.Add(c.ToString());
                chars = chars.Substring(1);
            }
            foreach (string s in withinbrackets)
            {
                string subpart = firstpart + s + lastpart;
                comb.AddRange(GenerateCombinations(subpart));
            }

            return comb;
        }


    }
}
