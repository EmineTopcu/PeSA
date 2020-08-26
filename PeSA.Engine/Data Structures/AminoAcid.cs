using System.Collections.Generic;
using System.Linq;

namespace PeSA.Engine
{
    public class AminoAcidComp : IComparer<AminoAcid>
    {
        public int Compare(AminoAcid x, AminoAcid y)
        {
            if (x.Polarity != y.Polarity)
                return x.NumericPolarity.CompareTo(y.NumericPolarity);
            if (x.Charge != y.Charge)
                return x.NumericCharge.CompareTo(y.NumericCharge);
            return x.Abbrev1.CompareTo(y.Abbrev1);
        }
    }

    public class AminoAcid
    {
        public string Name, Abbrev3, Polarity, Charge;
        public char Abbrev1;
        public double MolecularWeight, ResidueWeight;
        public double? pKa1, pKa2, pKa3, pI;
        public int NumericPolarity
        {
            get
            {
                switch (Polarity)
                {
                    case "acidic polar": return 0;
                    case "basic polar": return 1;
                    case "polar": return 2;
                    case "nonpolar": return 3;
                    default:
                        return 99;
                }
            }
        }
        public int NumericCharge
        {
            get
            {
                switch (Polarity)
                {
                    case "negative": return -1;
                    case "neutral": return 0;
                    case "positive": return 1;
                    default:
                        return 99;
                }
            }
        }
    }

    static public class AminoAcids
    {
        static Dictionary<char, AminoAcid> AminoAcidList = new Dictionary<char, AminoAcid>()
            {
                {'A', new AminoAcid {Name="Alanine", Polarity="nonpolar", Charge="neutral", Abbrev1='A', Abbrev3 = "Ala", MolecularWeight=89.10, ResidueWeight = 71.08, pKa1 = 2.34, pKa2=9.69, pKa3=null, pI =6.00 } },//C3H7NO2 	residue: C3H5NO
                {'R', new AminoAcid {Name="Arginine", Polarity="basic polar", Charge="positive", Abbrev1='R', Abbrev3 = "Arg", MolecularWeight=174.20, ResidueWeight = 156.19, pKa1 = 2.17, pKa2=9.04, pKa3=12.48, pI =10.76} },//C6H14N4O2 	C6H12N4O
                {'N', new AminoAcid {Name="Asparagine", Polarity="polar", Charge="neutral", Abbrev1='N', Abbrev3 = "Asn", MolecularWeight=132.12, ResidueWeight = 114.11, pKa1 = 2.02, pKa2=8.80, pKa3=null, pI =5.41} },//C4H8N2O3 	C4H6N2O2
                {'D', new AminoAcid {Name="Aspartic acid", Polarity="acidic polar", Charge="negative", Abbrev1='D', Abbrev3 = "Asp", MolecularWeight=133.11, ResidueWeight = 115.09, pKa1 = 1.88, pKa2=9.60, pKa3=3.65, pI =2.77} },//C4H7NO4 	C4H5NO3 
                {'C', new AminoAcid {Name="Cysteine", Polarity="nonpolar", Charge="neutral", Abbrev1='C', Abbrev3 = "Cys", MolecularWeight=121.16, ResidueWeight = 103.15, pKa1 = 1.96, pKa2=10.28, pKa3=8.18, pI =5.07} },//C3H7NO2S 	C3H5NOS
                {'E', new AminoAcid {Name="Glutamic acid", Polarity="acidic polar", Charge="negative", Abbrev1='E', Abbrev3 = "Glu", MolecularWeight=147.13, ResidueWeight = 129.12, pKa1 = 2.19, pKa2=9.67, pKa3=4.25, pI =3.22} },//C5H9NO4 	C5H7NO3
                {'Q', new AminoAcid {Name="Glutamine", Polarity="polar", Charge="neutral", Abbrev1='Q', Abbrev3 = "Gln", MolecularWeight=146.15, ResidueWeight = 128.13, pKa1 = 2.17, pKa2=9.13, pKa3=null, pI =5.65} },//C5H10N2O3 	C5H8N2O2 
                {'G', new AminoAcid {Name="Glycine", Polarity="nonpolar", Charge="neutral", Abbrev1='G', Abbrev3 = "Gly", MolecularWeight=75.07, ResidueWeight = 57.05, pKa1 = 2.34, pKa2=9.60, pKa3=null, pI =5.97} },//C2H5NO2 	C2H3NO
                {'H', new AminoAcid {Name="Histidine", Polarity="basic polar", Charge="positive", Abbrev1='H', Abbrev3 = "His", MolecularWeight=155.16, ResidueWeight = 137.14, pKa1 = 1.82, pKa2=9.17, pKa3=6.00, pI =7.59} },//C6H9N3O2 	C6H7N3O 
                {'O', new AminoAcid {Name="Hydroxyproline", Polarity="", Charge="", Abbrev1='O', Abbrev3 = "Hyp", MolecularWeight=131.13, ResidueWeight = 113.11, pKa1 =1.82 , pKa2=9.65, pKa3=null, pI =null} },//C5H9NO3 	C5H7NO2
                {'I', new AminoAcid {Name="Isoleucine", Polarity="nonpolar", Charge="neutral", Abbrev1='I', Abbrev3 = "Ile", MolecularWeight=131.18, ResidueWeight = 113.16, pKa1 = 2.36, pKa2=9.60, pKa3=null, pI =6.02} },//C6H13NO2 	C6H11NO
                {'L', new AminoAcid {Name="Leucine", Polarity="nonpolar", Charge="neutral", Abbrev1='L', Abbrev3 = "Leu", MolecularWeight=131.18, ResidueWeight = 113.16, pKa1 =2.36 , pKa2=9.60, pKa3=null, pI =5.98} },//C6H13NO2 	C6H11NO
                {'K', new AminoAcid {Name="Lysine", Polarity="basic polar", Charge="positive", Abbrev1='K', Abbrev3 = "Lys", MolecularWeight=146.19, ResidueWeight = 128.18, pKa1 = 2.18, pKa2=8.95, pKa3=10.53, pI =9.74} },//C6H14N2O2 	C6H12N2O
                {'M', new AminoAcid {Name="Methionine", Polarity="nonpolar", Charge="neutral", Abbrev1='M', Abbrev3 = "Met", MolecularWeight=149.21, ResidueWeight = 131.20, pKa1 = 2.28, pKa2=9.21, pKa3=null, pI =5.74} },//C5H11NO2S 	C5H9NOS
                {'F', new AminoAcid {Name="Phenylalanine", Polarity="nonpolar", Charge="neutral", Abbrev1='F', Abbrev3 = "Phe", MolecularWeight=165.19, ResidueWeight = 147.18, pKa1 = 1.83, pKa2=9.13, pKa3=null, pI =5.48} },//C9H11NO2 	C9H9NO 
                {'P', new AminoAcid {Name="Proline", Polarity="nonpolar", Charge="neutral", Abbrev1='P', Abbrev3 = "Pro", MolecularWeight=115.13, ResidueWeight = 97.12, pKa1 = 1.99, pKa2=10.60, pKa3=null, pI =6.30} },//C5H9NO2 	C5H7NO 
                {'U', new AminoAcid {Name="Pyroglutamatic", Polarity="", Charge="", Abbrev1='U', Abbrev3 = "Glp", MolecularWeight=139.11, ResidueWeight = 121.09, pKa1 = null, pKa2=null, pKa3=null, pI =5.68} },//C5H7NO3 	C5H5NO2
                {'S', new AminoAcid {Name="Serine", Polarity="polar", Charge="neutral", Abbrev1='S', Abbrev3 = "Ser", MolecularWeight=105.09, ResidueWeight = 87.08, pKa1 = 2.21, pKa2=9.15, pKa3=null, pI =5.68} },//C3H7NO3 	C3H5NO2 
                {'T', new AminoAcid {Name="Threonine", Polarity="polar", Charge="neutral", Abbrev1='T', Abbrev3 = "Thr", MolecularWeight=119.12, ResidueWeight = 101.11, pKa1 =2.09 , pKa2=9.10, pKa3=null, pI =5.60} },//C4H9NO3 	C4H7NO2
                {'W', new AminoAcid {Name="Tryptophan", Polarity="nonpolar", Charge="neutral", Abbrev1='W', Abbrev3 = "Trp", MolecularWeight=204.23, ResidueWeight = 186.22, pKa1 = 2.83, pKa2=9.39, pKa3=null, pI =5.89} },//C11H12N2O2 	C11H10N2O
                {'Y', new AminoAcid {Name="Tyrosine", Polarity="polar", Charge="neutral", Abbrev1='Y', Abbrev3 = "Tyr", MolecularWeight=181.19, ResidueWeight = 163.18, pKa1 = 2.20, pKa2=9.11, pKa3=10.07, pI =5.66} },//C9H11NO3 	C9H9NO2
                {'V', new AminoAcid {Name="Valine", Polarity="nonpolar", Charge="neutral", Abbrev1='V', Abbrev3 = "Val", MolecularWeight=117.15, ResidueWeight = 99.13, pKa1 = 2.32, pKa2=9.62, pKa3=null, pI =5.96} }//C5H11NO2 	C5H9NO
            };
        public static bool IsStandardAminoAcid(char c) { return AminoAcidList.ContainsKey(c); }
        public static AminoAcid GetAminoAcid(char c) {
            if (!AminoAcids.IsStandardAminoAcid(c))
                return null;
            return AminoAcidList[c]; }
        public static List<AminoAcid> GetFullAminoAcidList() { return AminoAcidList.Values.ToList(); }
        public static List<AminoAcid> GetAminoAcidList()
        {
            Settings settings = Settings.Load("default.settings");
            if (settings.AminoAcidExcludeList == null || settings.AminoAcidExcludeList.Count == 0)
                return AminoAcidList.Values.ToList();
            return AminoAcidList.Where(aa => !settings.AminoAcidExcludeList.Contains(aa.Key)).Select(aa => aa.Value).ToList();
        }

        public static List<AminoAcid> GetSortedFullAminoAcidList()
        {
            return AminoAcidList.Values.OrderBy(aa => aa.Name).ToList();//, new AminoAcidComp()).ToList();
        }
    }

}

