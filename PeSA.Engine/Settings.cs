using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeSA.Engine
{
    public class Settings
    {
        //MotifSettings
        public Dictionary<char, Color> AminoAcidMotifColors;
        public int MotifWidth, MotifHeight;
        public int MotifMaxAAPerColumn = 10;
        public double MotifThreshold = 0.1;

        //PeptideArraySettings
        public int PeptideArrayColumns, PeptideArrayRows;
        public bool PeptideArrayRowsFirst;

        //PermutationArraySettings
        public bool WildTypeYAxisTopToBottom = true;

        public Color GetColorOfAminoAcid(char aa)
        {
            if (AminoAcidMotifColors.ContainsKey(aa))
                return AminoAcidMotifColors[aa];
            return Color.Black;
        }
        public void SetDefaultColors()
        {
            this.AminoAcidMotifColors = new Dictionary<char, Color>() {
                    {'A', Color.Fuchsia },
                    {'R',Color.Green },
                    {'N', Color.FromArgb(128,255,255) },
                    {'D', Color.Red },
                    {'C', Color.Black },
                    {'E', Color.Red },
                    {'Q', Color.FromArgb(128,255,255) },
                    {'G', Color.Black },
                    {'H', Color.Green },
                    //{'O', Color.Green },
                    {'I', Color.Fuchsia },
                    {'L', Color.Fuchsia },
                    {'K', Color.Green },
                    {'M', Color.Fuchsia },
                    {'F', Color.Fuchsia },
                    {'P', Color.Black },
                    //{'U', Color.Green },
                    {'S', Color.FromArgb(128,255,255) },
                    {'T', Color.FromArgb(128,255,255) },
                    {'W', Color.Fuchsia },
                    {'Y', Color.FromArgb(128,255,255) },//Fuchsia },
                    {'V', Color.Fuchsia },
                    {'X', Color.Black }
                };
        }
        public static Settings Load(string name)
        {
            Settings settings = null;
            try
            {
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "/PeSA";
                if (Directory.Exists(folder) && File.Exists(folder + "/" + name))
                {
                    settings = JsonConvert.DeserializeObject<Settings>(File.ReadAllText(folder + "/" + name));
                }
                else
                {
                    settings = new Settings();
                    settings.MotifHeight = 200;
                    settings.MotifWidth = 800;
                    settings.SetDefaultColors();
                    settings.PeptideArrayColumns = 30;
                    settings.PeptideArrayRows = 20;
                    settings.PeptideArrayRowsFirst = true;

                    string json = JsonConvert.SerializeObject(settings);

                    Directory.CreateDirectory(folder);
                    File.WriteAllText(folder + "/" + name, json);
                }
                return settings;
            }
            catch
            {
                if (settings == null)
                {
                    settings = new Settings();
                    settings.MotifHeight = 200;
                    settings.MotifWidth = 800;
                    settings.SetDefaultColors();
                    settings.PeptideArrayColumns = 30;
                    settings.PeptideArrayRows = 20;
                    settings.PeptideArrayRowsFirst = true;
                }
                return settings;
            }
        }

        public bool Save(string name)
        {
            try
            {
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "/PeSA";
                if (Directory.Exists(folder) && File.Exists(folder + "/" + name))
                {
                    string json = JsonConvert.SerializeObject(this);
                    File.WriteAllText(folder + "/" + name, json);
                }
                return true;
            }
            catch { return false; }
        }
    }

}
