#pragma warning disable CA1416 
//FUTURE:
//System.Drawing can be replaced by SixLabors/ImageSharp with modifications for cross platform application

using PeSA.Engine.Helpers;
using System.Drawing;
using System.Reflection;

namespace PeSA.Engine
{
    public class Settings
    {
        static private Dictionary<char, Bitmap> PositiveImages;
        static private Dictionary<char, Bitmap> NegativeImages;
        private static Dictionary<char, Color> DefaultAminoAcidMotifColors;
        //ColorMatrixSettings - set as private for now; not editable
        private Dictionary<string, ColorMatrixTheme> ColorMatrixThemes;

        //MotifSettings
        public Dictionary<char, Color> AminoAcidMotifColors { get; set; }
        public int MotifWidth { get; set; }
        public int MotifHeight { get; set; }
        public int MotifMaxAAPerColumn { get; set; } = 10;
        public double MotifThreshold { get; set; } = 0.1;

        //PeptideArraySettings
        public int PeptideArrayColumns { get; set; } 
        public int PeptideArrayRows { get; set; }
        public bool PeptideArrayRowsFirst { get; set; }

        //PermutationArraySettings
        public bool WildTypeYAxisTopToBottom { get; set; } = true;

        public Settings()
        {
            DefaultAminoAcidMotifColors = new Dictionary<char, Color>() {
                    {'A', Color.Fuchsia },
                    {'R',Color.Green },
                    {'N', Color.FromArgb(128,255,255) },
                    {'D', Color.Red },
                    {'C', Color.Black },
                    {'E', Color.Red },
                    {'Q', Color.FromArgb(128,255,255) },
                    {'G', Color.Black },
                    {'H', Color.Green },
                    {'O', Color.Green },
                    {'I', Color.Fuchsia },
                    {'L', Color.Fuchsia },
                    {'K', Color.Green },
                    {'M', Color.Fuchsia },
                    {'F', Color.Fuchsia },
                    {'P', Color.Black },
                    {'U', Color.Green },
                    {'S', Color.FromArgb(128,255,255) },
                    {'T', Color.FromArgb(128,255,255) },
                    {'W', Color.Fuchsia },
                    {'Y', Color.FromArgb(128,255,255) },//Fuchsia },
                    {'V', Color.Fuchsia },
                    {'X', Color.Black }
                };
            AminoAcidMotifColors = new Dictionary<char, Color>(DefaultAminoAcidMotifColors);
        }
        public Color GetColorOfAminoAcid(char aa)
        {
            if (AminoAcidMotifColors.TryGetValue(aa, out Color value))
                return value;
            if (DefaultAminoAcidMotifColors.TryGetValue(aa, out Color value2))
                return value2;
            return Color.Black;
        }
        public void SetDefaultColors()
        {
            AminoAcidMotifColors = DefaultAminoAcidMotifColors;
        }

        public List<char> AminoAcidExcludeList;

        private void SetDefaultColorMatrixThemes()
        {
            ColorMatrixThemes = new Dictionary<string, ColorMatrixTheme>();

            ColorMatrixTheme theme = new()
            {
                ThemeName = "Grayscale"
            };
            theme.BackgroundColor = theme.StartColor = Color.White;
            theme.FontColor = theme.EndColor = Color.Black;
            theme.Dia = 20;
            theme.Flip = false;
            ColorMatrixThemes.Add(theme.ThemeName, theme);

            theme = new ColorMatrixTheme
            {
                ThemeName = "Blue-Red scale",
                BackgroundColor = Color.Black,
                StartColor = Color.Blue,
                EndColor = Color.Red,
                FontColor = Color.White,
                Dia = 20,
                Flip = true
            };
            ColorMatrixThemes.Add(theme.ThemeName, theme);

            theme = new ColorMatrixTheme
            {
                ThemeName = "Custom",
                BackgroundColor = Color.Black,
                StartColor = Color.LightGreen,
                EndColor = Color.Red,
                FontColor = Color.White,
                Dia = 20,
                Flip = false
            };
            ColorMatrixThemes.Add(theme.ThemeName, theme);
        }
        public ColorMatrixTheme GetMatrixTheme(bool color)
        {
            if (color)
                return ColorMatrixThemes["Blue-Red scale"];
            return ColorMatrixThemes["Grayscale"];
        }

        public static Settings Load(string name)
        {
            Settings settings = null;
            try
            {
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "/PeSA";
                if (Directory.Exists(folder) && File.Exists(folder + "/" + name))
                {
                    settings = (Settings)JsonUtil.ReadFromJson(File.ReadAllText(folder + "/" + name), typeof(Settings));
                    if (settings.ColorMatrixThemes == null)
                        settings.SetDefaultColorMatrixThemes();
                    if (settings.MotifWidth <= 0)
                        settings.MotifWidth = 200;
                    if (settings.MotifHeight <= 0)
                        settings.MotifHeight = 800;
                    if (settings.PeptideArrayColumns <= 0)
                        settings.PeptideArrayColumns = 30;
                    if (settings.PeptideArrayRows <= 0)
                        settings.PeptideArrayRows = 20;
                }
                else
                {
                    settings = new Settings
                    {
                        MotifHeight = 200,
                        MotifWidth = 800
                    };
                    settings.SetDefaultColors();
                    settings.SetDefaultColorMatrixThemes();
                    settings.PeptideArrayColumns = 30;
                    settings.PeptideArrayRows = 20;
                    settings.PeptideArrayRowsFirst = true;

                    string json = JsonUtil.ToJson(settings);

                    Directory.CreateDirectory(folder);
                    File.WriteAllText(folder + "/" + name, json);
                }
                return settings;
            }
            catch
            {
                if (settings == null)
                {
                    settings = new Settings
                    {
                        MotifHeight = 200,
                        MotifWidth = 800
                    };
                    settings.SetDefaultColors();
                    settings.SetDefaultColorMatrixThemes();
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
                GeneratePositiveImageResources(true);//to update the colored images
                string folder = Environment.GetFolderPath(Environment.SpecialFolder.CommonApplicationData) + "/PeSA";
                if (Directory.Exists(folder) && File.Exists(folder + "/" + name))
                {
                    string json = JsonUtil.ToJson(this);
                    File.WriteAllText(folder + "/" + name, json);
                }
                return true;
            }
            catch { return false; }
        }

        private static void SetImage(Dictionary<char, Bitmap> dict, char c, Bitmap bmp)
        {
            if (dict.ContainsKey(c))
                dict[c] = bmp;
            else dict.Add(c, bmp);
        }
        private static void GenerateImageResourcesOfAminoAcid(char aa, string filename, bool pos, Color color)
        {
            try
            {
                Assembly assembly = Assembly.GetExecutingAssembly();
                if (!filename.StartsWith("PeSA"))
                    filename = "PeSA.Engine.Resources." + filename;
                Stream stream = assembly.GetManifestResourceStream(filename);
                if (stream == null)
                    return;
                Image image = Image.FromStream(stream);
                System.Drawing.Imaging.ImageAttributes imageAttributes = new();
                int width = image.Width;
                int height = image.Height;
                System.Drawing.Imaging.ColorMap colorMap = new()
                {
                    OldColor = Color.Black,
                    NewColor = color
                };

                System.Drawing.Imaging.ColorMap[] remapTable = { colorMap };

                imageAttributes.SetRemapTable(remapTable, System.Drawing.Imaging.ColorAdjustType.Bitmap);

                Bitmap bmp = new(width, height);
                using var gr = Graphics.FromImage(bmp);
                gr.DrawImage(image, new Rectangle(0, 0, width, height), 0, 0, width, height, GraphicsUnit.Pixel,
               imageAttributes);
                if (pos)
                    SetImage(PositiveImages, aa, bmp);
                else
                    SetImage(NegativeImages, aa, bmp);
            }
            catch (Exception) { }
        }
        public static Bitmap GetAminoAcidImage(char c, bool pos)
        {
            if (PositiveImages == null || PositiveImages.Count == 0)
            {
                Settings settings = Load("default.settings");
                settings.GenerateImageResources();
            }
            if (!PositiveImages.TryGetValue(c, out Bitmap value))
                return null;
            if (pos)
                return value;
            else
                return NegativeImages[c];
        }

        public void GeneratePositiveImageResources(bool enforce)
        {
            if (!enforce && PositiveImages != null && PositiveImages.Count != 0)
                return;
            PositiveImages = new Dictionary<char, Bitmap>();
            for (char c = 'A'; c <= 'Z'; c++)
            {
                GenerateImageResourcesOfAminoAcid(c, "Image" + c + ".png", true, GetColorOfAminoAcid(c));
            }
        }
        public static void GenerateNegativeImageResources()
        {
            if (NegativeImages != null && NegativeImages.Count != 0)
                return;
            NegativeImages = new Dictionary<char, Bitmap>();
            for (char c = 'A'; c <= 'Z'; c++)
            {
                GenerateImageResourcesOfAminoAcid(c, "Image" + c + ".png", false, Common.ColorNegative);
            }
        }
        public void GenerateImageResources()
        {
            if (Settings.PositiveImages == null || Settings.PositiveImages.Count == 0)
                GeneratePositiveImageResources(false);
            if (Settings.NegativeImages == null || Settings.NegativeImages.Count == 0)
                GenerateNegativeImageResources();
        }

    }

}
