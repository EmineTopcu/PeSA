using OfficeOpenXml;
using OfficeOpenXml.Style;
using PeSA.Engine.Data_Structures;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PeSA.Engine
{
    public class FileUtil
    {
        public static string ImageToBase64(System.Drawing.Image image)
        {
            using (MemoryStream m = new MemoryStream())
            {
                image.Save(m, image.RawFormat);
                byte[] imageBytes = m.ToArray();
                string base64String = Convert.ToBase64String(imageBytes);
                return base64String;
            }
        }
        public static System.Drawing.Image Base64ToImage(string base64String)
        {
            byte[] imageBytes = Convert.FromBase64String(base64String);
            MemoryStream ms = new MemoryStream(imageBytes, 0, imageBytes.Length);
            ms.Write(imageBytes, 0, imageBytes.Length);
            System.Drawing.Image image = System.Drawing.Image.FromStream(ms, true);
            return image;
        }

        private static string[,] ReadArrayFromFile(string fileName, out bool wtStripped)
        {
            try
            {
                FileInfo existingFile = new FileInfo(fileName);
                string[,] data = null;
                if (existingFile.Extension.StartsWith(".xls"))
                {
                    data = ReadArrayFromExcel(existingFile);
                }
                else if (existingFile.Extension.StartsWith(".csv"))
                {
                    data = ReadArrayFromCSV(existingFile);
                }
                data = MatrixUtil.StripWildTypeRowColumns(data, out wtStripped);
                return data;
            }
            catch
            {
                wtStripped = false;
                return null;
            }
        }
        private static string[,] ReadArrayFromExcel(FileInfo existingFile)
        {
            try
            {
                string[,] data;
                using (ExcelPackage package = new ExcelPackage(existingFile))
                {
                    //get the first worksheet in the workbook
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    int colCount = worksheet.Dimension.End.Column;  //get Column Count
                    int rowCount = worksheet.Dimension.End.Row;     //get row count
                    data = new string[rowCount, colCount];
                    for (int row = 1; row <= rowCount; row++)
                    {
                        for (int col = 1; col <= colCount; col++)
                        {
                            data[row - 1, col - 1] = worksheet.Cells[row, col].Value?.ToString().Trim();
                        }
                    }
                }
                return data;
            }
            catch (Exception exc)
            {
                return null;
            }
        }

        private static string[,] ReadArrayFromCSV(FileInfo existingFile)
        {
            string[,] data;
            List<string> lines = null;
            lines = System.IO.File.ReadAllLines(existingFile.FullName).ToList();
            string[] values = lines[0].Split(',');
            int colCount = values.Count();
            int rowCount = lines.Count();
            data = new string[rowCount, colCount];
            int row = 0;
            foreach (string line in lines)
            {
                values = line.Split(',');
                int col = 0;
                foreach (string value in values)
                {
                    data[row, col] = value;
                    col++;
                }
                row++;
            }
            return data;
        }

        private static List<string> ReadListFromText(FileInfo existingFile)
        {
            List<string> lines = System.IO.File.ReadAllLines(existingFile.FullName).ToList();
            return lines;
        }

        public static List<string> ReadPeptideList(string fileName)
        {
            FileInfo existingFile = new FileInfo(fileName);

            if (existingFile.Extension.StartsWith(".txt"))
            {
                return ReadListFromText(existingFile);
            }

            string[,] data = null;
            if (existingFile.Extension.StartsWith(".xls"))
            {
                data = ReadArrayFromExcel(existingFile);
            }
            else if (existingFile.Extension.StartsWith(".csv"))
            {
                data = ReadArrayFromCSV(existingFile);
            }

            List<string> peptideList = new List<string>();
            int colind = 0;
            for (int rowind = 0; rowind < data.GetLength(0); rowind++)
                //Read only the first column for (int colind = 0; colind < data.GetLength(1); colind++)
                peptideList.Add(data[rowind, colind]);
            return peptideList;
        }

        public static List<Protein> ReadProtein(string fileName)
        {            
            FileInfo existingFile = new FileInfo(fileName);

            List<Protein> proteins = Protein.GenerateProteins(string.Join("\r\n", System.IO.File.ReadAllLines(existingFile.FullName)));

            return proteins;
        }

        public static string[,] ReadPeptideMatrix(string fileName)
        {
            FileInfo existingFile = new FileInfo(fileName);

            string[,] data = null;
            if (existingFile.Extension.StartsWith(".xls"))
            {
                data = ReadArrayFromExcel(existingFile);
            }
            else if (existingFile.Extension.StartsWith(".csv"))
            {
                data = ReadArrayFromCSV(existingFile);
            }
            if (data != null)
                data = MatrixUtil.StripHeaderRowColumns(data, true);

            return data;
        }

        public static bool ReadQuantificationData(string fileName, PeptideArray PA, bool headersExist)
        {
            try
            {
                FileInfo existingFile = new FileInfo(fileName);
                string[,] data = null;
                if (existingFile.Extension.StartsWith(".xls"))
                {
                    data = ReadArrayFromExcel(existingFile);
                }
                else if (existingFile.Extension.StartsWith(".csv"))
                {
                    data = ReadArrayFromCSV(existingFile);
                }

                PA.SetQuantificationMatrix(data, headersExist);
                return true;
            }
            catch
            {
                return false;
            }
        }

        public static int ListToExcelColumn(ExcelWorksheet worksheet, int startrow, int colind, string caption, List<string> list)
        {
            try
            {
                worksheet.Cells[startrow++, colind].Value = caption;
                foreach (string s in list)
                    worksheet.Cells[startrow++, colind].Value = s;
                return startrow;
            }
            catch
            {
                return -1;
            }
        }

        public static int ListToExcelRow(ExcelWorksheet worksheet, int rowind, int startcol, string caption, List<string> list)
        {
            try
            {
                worksheet.Cells[rowind, startcol++].Value = caption;
                foreach (string s in list)
                    worksheet.Cells[rowind, startcol++].Value = s;
                return startcol;
            }
            catch
            {
                return -1;
            }
        }

        public static int ListToExcelColumn(ExcelWorksheet worksheet, int startrow, int colind, string caption, List<double> list)
        {
            try
            {
                worksheet.Cells[startrow++, colind].Value = caption;
                foreach (double d in list)
                    worksheet.Cells[startrow++, colind].Value = d;
                return startrow;
            }
            catch
            {
                return -1;
            }
        }

        public static int ListToExcelRow(ExcelWorksheet worksheet, int rowind, int startcol, string caption, List<double> list)
        {
            try
            {
                worksheet.Cells[rowind, startcol++].Value = caption;
                foreach (double d in list)
                    worksheet.Cells[rowind, startcol++].Value = d;
                return startcol;
            }
            catch
            {
                return -1;
            }
        }
        public static int MatrixToExcel(ExcelWorksheet worksheet, int startrow, string caption, object matrix)
        {
            try
            {
                string[,] sMatrix = matrix as string[,];
                double[,] dMatrix = matrix as double[,];
                int[,] iMatrix = matrix as int[,];

                if (sMatrix == null && dMatrix == null && iMatrix == null) return -1;

                worksheet.Cells[startrow++, 1].Value = caption;
                int colCount = sMatrix?.GetLength(1) ?? dMatrix?.GetLength(1) ?? iMatrix.GetLength(1);
                int rowCount = sMatrix?.GetLength(0) ?? dMatrix?.GetLength(0) ?? iMatrix.GetLength(0);

                for (int colind = 1; colind <= colCount; colind++)
                    worksheet.Cells[startrow, colind + 1].Value = "C" + colind.ToString();
                for (int rowind = 1; rowind <= rowCount; rowind++)
                {
                    worksheet.Cells[rowind + startrow, 1].Value = "R" + rowind.ToString();
                    for (int colind = 1; colind <= colCount; colind++)
                    {
                        if (sMatrix != null)
                            worksheet.Cells[rowind + startrow, colind + 1].Value = sMatrix[rowind - 1, colind - 1];
                        else if (dMatrix != null)
                            worksheet.Cells[rowind + startrow, colind + 1].Value = dMatrix[rowind - 1, colind - 1];
                        else
                            worksheet.Cells[rowind + startrow, colind + 1].Value = iMatrix[rowind - 1, colind - 1];
                    }
                }
                return rowCount + startrow;
            }
            catch
            {
                return -1;
            }
        }

        private static ExcelWorksheet GetWorksheetBlank(ExcelPackage package, string sheetname)
        {
            try
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[sheetname];

                if (worksheet != null)
                    package.Workbook.Worksheets.Delete(worksheet);
                worksheet = package.Workbook.Worksheets.Add(sheetname);
                return worksheet;
            }
            catch
            {
                return null;
            }

        }
        private static ExcelWorksheet GetWorksheetKeepData(ExcelPackage package, string sheetname)
        {
            try
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[sheetname];

                if (worksheet == null)
                    worksheet = package.Workbook.Worksheets.Add(sheetname);
                return worksheet;
            }
            catch
            {
                return null;
            }
        }

        private static void WriteToSheetValidator(ExcelPackage package, MotifValidator validator)
        {
            ExcelWorksheet worksheet = GetWorksheetBlank(package, "Motif Validation Sequence");
            int rowind = 1;

            if (validator.PositiveSpecificity > 0)
            {
                worksheet.Cells[rowind, 1].Value = "Positive Specificity";
                worksheet.Cells[rowind++, 2].Value = validator.PositiveSpecificity;
            }
            if (validator.NegativeSpecificity > 0)
            {
                worksheet.Cells[rowind, 1].Value = "Negative Specificity";
                worksheet.Cells[rowind++, 2].Value = validator.NegativeSpecificity;
            }

            int startrow = rowind;
            worksheet.Cells[rowind++, 1].Value = "Positive Motif only";
            worksheet.Cells[rowind, 1].Value = "Count:";
            worksheet.Cells[rowind++, 2].Value = validator.PositiveSequenceList.Count();
            rowind = ListToExcelColumn(worksheet, rowind, 2, "Sequence", validator.PositiveSequenceList);

            rowind = startrow;
            worksheet.Cells[rowind++, 4].Value = "Including Negative Motif";
            worksheet.Cells[rowind, 4].Value = "Count:";
            worksheet.Cells[rowind++, 5].Value = validator.NegativeSequenceList.Count();
            rowind = ListToExcelColumn(worksheet, rowind, 5, "Sequence", validator.NegativeSequenceList);

            worksheet.Column(2).AutoFit();
            worksheet.Column(5).AutoFit();
        }
        private static void WriteToSheetScoreList(ExcelPackage package, Scorer scorer)
        {
            ExcelWorksheet worksheet = GetWorksheetBlank(package, "Scores");
            int rowind = 1;

            if (scorer.PosMatchCutoff > 0)
            {
                worksheet.Cells[rowind, 1].Value = "Positive Match Cutoff";
                worksheet.Cells[rowind++, 2].Value = scorer.PosMatchCutoff;
            }
            if (scorer.NegMatchCutoff < 20)
            {
                worksheet.Cells[rowind, 1].Value = "Negative Match Cutoff";
                worksheet.Cells[rowind++, 2].Value = scorer.NegMatchCutoff;
            }
            if (scorer.UserEnteredPosThreshold != null)
            {
                worksheet.Cells[rowind, 1].Value = "Scorer Positive Threshold";
                worksheet.Cells[rowind++, 2].Value = scorer.UserEnteredPosThreshold;
            }
            if (scorer.UserEnteredNegThreshold != null)
            {
                worksheet.Cells[rowind, 1].Value = "Scorer Negative Threshold";
                worksheet.Cells[rowind++, 2].Value = scorer.UserEnteredNegThreshold;
            }
            if (scorer.KeyPosition >= 0)
            {
                worksheet.Cells[rowind, 1].Value = "Key Position";
                worksheet.Cells[rowind++, 2].Value = scorer.KeyPosition;
                worksheet.Cells[rowind, 1].Value = "Key Amino Acid";
                worksheet.Cells[rowind++, 2].Value = scorer.KeyChar.ToString();
            }

            rowind++;
            worksheet.Cells[rowind, 1, rowind, 8].Style.Border.Bottom.Style = ExcelBorderStyle.Medium;
            worksheet.Cells[rowind, 1].Value = "Protein/Peptide";
            worksheet.Cells[rowind, 2].Value = "Start Position";
            worksheet.Cells[rowind, 3].Value = "Segment";
            worksheet.Cells[rowind, 4].Value = "Pos Match";
            worksheet.Cells[rowind, 5].Value = "Neg Match";
            worksheet.Cells[rowind, 6].Value = "Match";
            worksheet.Cells[rowind, 7].Value = "Weight Score";
            worksheet.Cells[rowind++, 8].Value = "Priority Score";

            foreach (Score s in scorer.ScoreList)
            {
                worksheet.Cells[rowind, 1].Value = s.Peptide;
                worksheet.Cells[rowind, 2].Value = s.StartPos;
                worksheet.Cells[rowind, 3].Value = s.Segment;
                worksheet.Cells[rowind, 4].Value = s.posMatch;
                worksheet.Cells[rowind, 5].Value = s.negMatch;
                worksheet.Cells[rowind, 6].Value = s.posMatch - s.negMatch;
                worksheet.Cells[rowind, 7].Value = s.weightedMatch;
                worksheet.Cells[rowind++, 8].Value = s.priorityMatch;
            }

            for (int i = 1; i <= 8; i++)
                worksheet.Column(i).AutoFit();
        }

        private static void WriteToSheetWeighedPeptideList(ExcelPackage package, Dictionary<string, double> peptidelist,
            double positiveThreshold, double negativeThreshold, string wildtypesequence = "")
        {
            ExcelWorksheet worksheet = GetWorksheetBlank(package, "Peptide Weights");

            int rowind = 1;
            worksheet.Cells[rowind, 1].Value = "Positive Threshold:";
            worksheet.Cells[rowind++, 2].Value = positiveThreshold;
            worksheet.Cells[rowind, 1].Value = "Negative Threshold:";
            worksheet.Cells[rowind++, 2].Value = negativeThreshold;
            if (wildtypesequence != "")
            {
                worksheet.Cells[rowind, 1].Value = "Wildtype Sequence:";
                worksheet.Cells[rowind++, 2].Value = wildtypesequence;
            }

            ListToExcelColumn(worksheet, rowind + 1, 1, "Peptide", peptidelist.Keys.ToList());
            ListToExcelColumn(worksheet, rowind + 1, 2, "Weight", peptidelist.Values.ToList());
            ListToExcelColumn(worksheet, rowind + 1, 3, "Result", peptidelist.Values.Select(v => v >= positiveThreshold ? "Pos" : v < negativeThreshold ? "Neg" : "").ToList());

            worksheet.Column(1).AutoFit();
            worksheet.Column(2).AutoFit();
        }


        private static void DumpMotifData(ExcelWorksheet worksheet, ref int rowind,
            Dictionary<int, Dictionary<char, double>> WeightColumns, Dictionary<int, Dictionary<char, double>> ScaledColumns)
        {
            worksheet.Cells[rowind++, 1].Value = "Motif Data:";
            int startrow = rowind;
            worksheet.Row(startrow).Style.Font.Bold = true;
            worksheet.Row(startrow + 1).Style.Font.Bold = true;
            int colind = 1;
            int lastrow = rowind;
            int colInc = WeightColumns != null ? 2 : 1;
            foreach (int pos in ScaledColumns.Keys)
            {
                worksheet.Cells[startrow, colind].Value = "Position: " + (pos + 1).ToString();
                worksheet.Cells[startrow, colind, startrow, colind + colInc].Merge = true;

                worksheet.Cells[startrow + 1, colind].Value = "Amino-acid";
                worksheet.Cells[startrow + 1, colind + 1].Value = "Percentage";
                if (WeightColumns != null)
                    worksheet.Cells[startrow + 1, colind + 2].Value = "Weight";
                Dictionary<char, double> perCol = ScaledColumns[pos];
                Dictionary<char, double> weightCol = WeightColumns?[pos];
                rowind = startrow + 2;
                foreach (char aa in perCol.Keys)
                {
                    worksheet.Cells[rowind, colind].Value = aa.ToString();
                    worksheet.Cells[rowind, colind + 1].Value = perCol[aa];
                    worksheet.Cells[rowind, colind + 1].Style.Numberformat.Format = "0.00%";
                    if (WeightColumns != null)
                    {
                        worksheet.Cells[rowind, colind + 2].Value = weightCol[aa];
                        worksheet.Cells[rowind, colind + 2].Style.Numberformat.Format = "0.00";
                    }
                    if (lastrow < rowind)
                        lastrow = rowind;
                    rowind++;
                }
                worksheet.Column(colind).AutoFit();
                worksheet.Column(colind + 1).AutoFit();
                if (WeightColumns != null)
                    worksheet.Column(colind + 2).AutoFit();
                worksheet.Cells[startrow, colind, rowind - 1, colind].Style.Border.Left.Style = ExcelBorderStyle.Medium;
                worksheet.Cells[startrow, colind + colInc, rowind - 1, colind + colInc].Style.Border.Right.Style = ExcelBorderStyle.Medium;
                worksheet.Cells[startrow, colind, rowind - 1, colind + colInc].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;
                colind += colInc + 1;
            }
            if (rowind < lastrow)
                rowind = lastrow;

        }

        private static void WriteToSheetMotif(ExcelPackage package, Motif motif)
        {
            ExcelWorksheet worksheet = GetWorksheetBlank(package, "Motif");

            worksheet.Drawings.Clear();

            Settings settings = Settings.Load("default.settings");
            int heightImage = 200;
            int widthImage = 800;
            if (settings != null)
            {
                heightImage = settings.MotifHeight;
                widthImage = settings.MotifWidth;
            }

            int rowind = 1;
            worksheet.Cells[rowind, 1].Value = "Positive Threshold:";
            worksheet.Cells[rowind++, 2].Value = motif.PositiveThreshold;
            if (motif.WildTypePeptide != "")
            {
                worksheet.Cells[rowind, 1].Value = "Wildtype Sequence:";
                worksheet.Cells[rowind++, 2].Value = motif.WildTypePeptide;
            }

            Bitmap bmp = motif.GetPositiveMotif(widthImage, heightImage);
            if (bmp != null)
            {
                var picture = worksheet.Drawings.AddPicture("Positive Motif", bmp);
                picture.SetPosition(rowind, 0, 1, 0);
            }

            int occupiedRows = (int)Math.Round(heightImage / worksheet.Row(rowind).Height);
            rowind += occupiedRows + 1;

            Dictionary<int, Dictionary<char, double>> scaledcolumns = motif.GetScaledColumns(motif.PositiveColumns);
            DumpMotifData(worksheet, ref rowind, motif.PositiveColumns, scaledcolumns);

            rowind += 2;

            worksheet.Cells[rowind, 1].Value = "Negative Threshold:";
            worksheet.Cells[rowind++, 2].Value = motif.NegativeThreshold;

            bmp = motif.GetNegativeMotif(widthImage, heightImage);
            if (bmp != null)
            {
                var picture = worksheet.Drawings.AddPicture("Negative Motif", bmp);
                picture.SetPosition(rowind, 0, 1, 0);
            }

            occupiedRows = (int)Math.Round(heightImage / worksheet.Row(rowind).Height);
            rowind += occupiedRows + 1;

            scaledcolumns = motif.GetScaledColumns(motif.NegativeColumns);
            DumpMotifData(worksheet, ref rowind, motif.NegativeColumns, scaledcolumns);

            rowind += 2;

            worksheet.Cells[rowind++, 1].Value = "Bar Chart:";
            bmp = motif.GetBarChart(widthImage / 2);
            if (bmp != null)
            {
                var picture = worksheet.Drawings.AddPicture("Bar Chart", bmp);
                picture.SetPosition(rowind, 0, 1, 0);
            }

            occupiedRows = (int)Math.Round(heightImage / worksheet.Row(rowind).Height);
            rowind += occupiedRows + 1;
        }

        private static void WriteToSheetFrequencyMotif(ExcelPackage package, Motif motif, string title, ref int rowind, bool clear = true)
        {
            ExcelWorksheet worksheet =
                clear ? GetWorksheetBlank(package, "Motif") : GetWorksheetKeepData(package, "Motif");

            if (clear)
                worksheet.Drawings.Clear();

            worksheet.Cells[rowind, 1].Value = "Frequency Threshold:";
            worksheet.Cells[rowind++, 2].Value = motif.PositiveThreshold;

            Settings settings = Settings.Load("default.settings");
            int heightImage = 200;
            int widthImage = 800;
            if (settings != null)
            {
                heightImage = settings.MotifHeight;
                widthImage = settings.MotifWidth;
            }
            Bitmap bmp = motif.GetFrequencyMotif(widthImage, heightImage);
            if (bmp != null)
            {
                var picture = worksheet.Drawings.AddPicture(title, bmp);
                picture.SetPosition(rowind, 0, 1, 0);
            }
            int occupiedRows = (int)Math.Round(heightImage / worksheet.Row(rowind).Height);
            rowind += occupiedRows + 1;
            DumpMotifData(worksheet, ref rowind, null, motif.Frequencies);


        }

        private static bool WriteToSheetReferenceInfo(ExcelPackage package, BaseArray array)
        {
            try
            {
                ExcelWorksheet worksheet = GetWorksheetBlank(package, "ReferenceInfo");

                worksheet.Drawings.Clear();

                worksheet.Cells[1, 1].Value = "Notes:";
                worksheet.Cells[1, 2].Value = array.Notes;

                Settings settings = Settings.Load("default.settings");
                int heightImage = 200;
                int widthImage = 800;
                if (settings != null)
                {
                    heightImage = settings.MotifHeight;
                    widthImage = settings.MotifWidth;
                }
                var picture = worksheet.Drawings.AddPicture("Reference Image", FileUtil.Base64ToImage(array.ImageStr));
                picture.SetPosition(3, 0, 1, 0);
                return true;
            }
            catch { return false; }
        }

        public static bool ExportPeptideArrayToExcel(string fileName, PeptideArray PA, bool overwrite, out string errormsg)
        {
            try
            {
                errormsg = "";
                FileInfo existingFile = new FileInfo(fileName);
                if (existingFile.Exists && !overwrite)
                    return false;
                using (ExcelPackage package = new ExcelPackage(existingFile))
                {
                    if (existingFile.Exists)
                    {
                        while (package.Workbook.Worksheets.Count > 0)
                            package.Workbook.Worksheets.Delete(1);
                    }
                    ExcelWorksheet worksheet = GetWorksheetBlank(package, "Arrays");

                    int lastrow = MatrixToExcel(worksheet, 1, "Peptide Matrix", PA.PeptideMatrix);
                    if (lastrow < 0) return false;
                    lastrow = MatrixToExcel(worksheet, lastrow + 3, "Binary Matrix", PA.BinaryMatrix);
                    if (lastrow < 0) return false;
                    lastrow = MatrixToExcel(worksheet, lastrow + 3, "Quantification Matrix", PA.QuantificationMatrix);
                    if (lastrow < 0) return false;

                    worksheet.Cells[++lastrow, 1].Value = "Norm By:";
                    worksheet.Cells[lastrow, 2].Value = PA.NormalizationValue;
                    lastrow = MatrixToExcel(worksheet, lastrow + 3, "Normalized Matrix", PA.NormalizedMatrix);

                    WriteToSheetWeighedPeptideList(package, PA.NormalizedPeptideWeights, PA.PositiveThreshold, PA.NegativeThreshold);

                    if (PA.KeyPosition != null && PA.KeyAA != ' ')
                    {
                        int rowind = 1;
                        List<string> mainList = PA.ModifiedPeptides.Where(s => s[(int)PA.KeyPosition - 1] == PA.KeyAA).ToList();
                        List<string> shiftedList = Analyzer.ShiftPeptides(PA.ModifiedPeptides.Where(s => s[(int)PA.KeyPosition - 1] != PA.KeyAA).ToList(), PA.KeyAA, PA.PeptideLength, (int)PA.KeyPosition - 1,
                            out List<string> replacements);
                        Motif motif = new Motif(mainList, PA.PeptideLength);
                        motif.FreqThreshold = PA.FrequencyThreshold;

                        WriteToSheetFrequencyMotif(package, motif, "Motif", ref rowind);
                        rowind++;

                        motif = new Motif(shiftedList, PA.PeptideLength);
                        motif.FreqThreshold = PA.FrequencyThreshold;
                        WriteToSheetFrequencyMotif(package, motif, "Shifted Motif", ref rowind, false);
                    }
                    else
                    {
                        Motif motif = new Motif(PA.ModifiedPeptides, PA.PeptideLength);
                        motif.FreqThreshold = PA.FrequencyThreshold;

                        int rowind = 1;
                        WriteToSheetFrequencyMotif(package, motif, "Motif", ref rowind);
                    }

                    WriteToSheetReferenceInfo(package, PA);

                    try
                    {
                        package.Save();
                    }
                    catch
                    {
                        errormsg = "There is a problem with saving the export file. Please make sure the file is not open and you have writing rights to the specific folder.";
                        return false;
                    }
                }

                return true;

            }
            catch
            {
                errormsg = "There is a problem with creating the export file. Please try again.";
                return false;
            }
        }

        public static PermutationArray ReadPermutationArrayQuantificationData(string fileName, out List<string> warnings, out string error)
        {
            warnings = new();
            error = "";

            string[,] data = ReadArrayFromFile(fileName, out bool wtStripped);

            bool permX = false, permY = false;
            PermutationArray.CheckPermutationAxis(data, ref permX, ref permY);
            if (!permX && !permY)
                return null;
            Settings settings = Settings.Load("default.settings");
            if (wtStripped)
                warnings.Add("Wildtype row/column is currently not handled in PeSA and is removed from the array.");
            PermutationArray PA = new(data, permX, settings.WildTypeYAxisTopToBottom, ref warnings, out error);
            return PA;
        }

        public static OPALArray ReadOPALArrayQuantificationData(string fileName, out List<string> warnings, out string error)
        {
            warnings = new();
            error = "";

            string[,] data = ReadArrayFromFile(fileName, out bool wtStripped);

            bool permX = false, permY = false;
            OPALArray.CheckPermutationAxis(data, ref permX, ref permY);
            if (!permX && !permY)
                return null;
            Settings settings = Settings.Load("default.settings");
            if (wtStripped)
                warnings.Add("Wildtype row/column is currently not handled in PeSA and is removed from the array.");
            OPALArray OA = new(data, permX, settings.WildTypeYAxisTopToBottom, out error);
            return OA;
        }

        public static bool ExportPermutationArrayToExcel(string fileName, PermutationArray PA, bool overwrite, out string errormsg)
        {
            try
            {
                errormsg = "";
                FileInfo existingFile = new FileInfo(fileName);
                if (existingFile.Exists && !overwrite)
                    return false;
                using (ExcelPackage package = new ExcelPackage(existingFile))
                {
                    if (existingFile.Exists)
                    {
                        while (package.Workbook.Worksheets.Count > 0)
                            package.Workbook.Worksheets.Delete(1);
                    }
                    ExcelWorksheet worksheet = GetWorksheetBlank(package, "Arrays");

                    List<string> headerrow = new List<string>();
                    List<string> headercolumn = new List<string>();
                    if (PA.PermutationXAxis)
                    {
                        headercolumn = PA.WildTypePeptide.ToCharArray().ToList().ConvertAll(c => c.ToString());
                        if (!PA.WildTypeYAxisTopToBottom)
                            headercolumn.Reverse();
                        headerrow = PA.Permutation.ToList().ConvertAll(c => c.ToString());
                    }
                    else
                    {
                        headerrow = PA.WildTypePeptide.ToCharArray().ToList().ConvertAll(c => c.ToString());
                        headercolumn = PA.Permutation.ToList().ConvertAll(c => c.ToString());
                    }

                    int startrow = 2;
                    int lastrow = MatrixToExcel(worksheet, 1, "Peptide Matrix", PA.PeptideMatrix);
                    if (lastrow < 0) return false;
                    ListToExcelRow(worksheet, startrow, 1, "", headerrow);
                    ListToExcelColumn(worksheet, startrow, 1, "", headercolumn);


                    startrow = lastrow + 3;
                    lastrow = MatrixToExcel(worksheet, lastrow + 3, "Quantification Matrix", PA.QuantificationMatrix);
                    if (lastrow < 0) return false;
                    ListToExcelRow(worksheet, startrow + 1, 1, "", headerrow);
                    ListToExcelColumn(worksheet, startrow + 1, 1, "", headercolumn);
                    //put the normalization values
                    if (PA.NormMode == NormalizationMode.Mean)
                    {
                        worksheet.Cells[++lastrow, 1].Value = "Norm By:";
                        worksheet.Cells[lastrow, 2].Value = PA.NormalizationValue;
                    }
                    else if (PA.PermutationXAxis)
                        ListToExcelColumn(worksheet, startrow + 1, PA.QuantificationMatrix.GetLength(1) + 2, "Norm By", PA.NormBy.ToList());
                    else
                        ListToExcelRow(worksheet, lastrow + 1, 1, "Norm By", PA.NormBy.ToList());

                    startrow = lastrow + 3;
                    lastrow = MatrixToExcel(worksheet, lastrow + 3, "Normalized Matrix", PA.NormalizedMatrix);
                    ListToExcelRow(worksheet, startrow + 1, 1, "", headerrow);
                    ListToExcelColumn(worksheet, startrow + 1, 1, "", headercolumn);

                    worksheet.Cells[lastrow + 2, 1].Value = "Positive Threshold: ";
                    worksheet.Cells[lastrow + 2, 2].Value = PA.GetPositiveThreshold();

                    worksheet.Cells[lastrow + 3, 1].Value = "Negative Threshold: ";
                    worksheet.Cells[lastrow + 3, 2].Value = PA.GetNegativeThreshold();

                    WriteToSheetWeighedPeptideList(package, PA.NormalizedPeptideWeights, PA.GetPositiveThreshold(), PA.GetNegativeThreshold(), PA.WildTypePeptide);
                    WriteToSheetMotif(package, new Motif(PA));
                    WriteToSheetReferenceInfo(package, PA);
                    try
                    {
                        package.Save();
                    }
                    catch
                    {
                        errormsg = "There is a problem with saving the export file. Please make sure the file is not open and you have writing rights to the specific folder.";
                        return false;
                    }
                }

                return true;

            }
            catch
            {
                errormsg = "There is a problem with creating the export file. Please try again.";
                return false;
            }
        }

        public static bool ExportOPALArrayToExcel(string fileName, OPALArray OA, bool overwrite, out string errormsg)
        {
            try
            {
                errormsg = "";
                FileInfo existingFile = new FileInfo(fileName);
                if (existingFile.Exists && !overwrite)
                    return false;
                using (ExcelPackage package = new ExcelPackage(existingFile))
                {
                    if (existingFile.Exists)
                    {
                        while (package.Workbook.Worksheets.Count > 0)
                            package.Workbook.Worksheets.Delete(1);
                    }
                    ExcelWorksheet worksheet = GetWorksheetBlank(package, "Arrays");

                    List<string> headerrow = new List<string>();
                    List<string> headercolumn = new List<string>();
                    if (OA.PermutationXAxis)
                    {
                        headercolumn = OA.PositionCaptions.ToList().ConvertAll(c => c.ToString());
                        headerrow = OA.Permutation.ToList().ConvertAll(c => c.ToString());
                    }
                    else
                    {
                        headerrow = OA.PositionCaptions.ToList().ConvertAll(c => c.ToString());
                        headercolumn = OA.Permutation.ToList().ConvertAll(c => c.ToString());
                    }

                    int startrow = 1;
                    int lastrow = MatrixToExcel(worksheet, startrow, "Quantification Matrix", OA.QuantificationMatrix);
                    if (lastrow < 0) return false;
                    ListToExcelRow(worksheet, startrow + 1, 1, "", headerrow);
                    ListToExcelColumn(worksheet, startrow + 1, 1, "", headercolumn);

                    //put the normalization values
                    if (OA.NormMode == NormalizationMode.Max)
                    {
                        worksheet.Cells[++lastrow, 1].Value = "Norm By:";
                        worksheet.Cells[lastrow, 2].Value = OA.NormalizationValue;
                    }
                    else if (OA.PermutationXAxis)
                        ListToExcelColumn(worksheet, startrow + 1, OA.QuantificationMatrix.GetLength(1) + 2, "Norm By", OA.NormBy.ToList());
                    else
                        ListToExcelRow(worksheet, lastrow + 1, 1, "Norm By", OA.NormBy.ToList());

                    startrow = lastrow + 3;
                    lastrow = MatrixToExcel(worksheet, startrow, "Normalized Matrix", OA.NormalizedMatrix);

                    ListToExcelRow(worksheet, startrow + 1, 1, "", headerrow);
                    ListToExcelColumn(worksheet, startrow + 1, 1, "", headercolumn);

                    WriteToSheetMotif(package, new Motif(OA));
                    WriteToSheetReferenceInfo(package, OA);
                    try
                    {
                        package.Save();
                    }
                    catch
                    {
                        errormsg = "There is a problem with saving the export file. Please make sure the file is not open and you have writing rights to the specific folder.";
                        return false;
                    }
                }

                return true;

            }
            catch
            {
                errormsg = "There is a problem with creating the export file. Please try again.";
                return false;
            }
        }

        public static bool ExportScoresToExcel(string fileName, Scorer scorer, bool overwrite, out string errormsg)
        {
            try
            {
                errormsg = "";
                FileInfo existingFile = new FileInfo(fileName);
                if (existingFile.Exists && !overwrite)
                    return false;
                using (ExcelPackage package = new ExcelPackage(existingFile))
                {
                    if (existingFile.Exists)
                    {
                        while (package.Workbook.Worksheets.Count > 0)
                            package.Workbook.Worksheets.Delete(1);
                    }
                    WriteToSheetScoreList(package, scorer);
                    WriteToSheetMotif(package, scorer.Motif);

                    try
                    {
                        package.Save();
                    }
                    catch
                    {
                        errormsg = "There is a problem with saving the export file. Please make sure the file is not open and you have writing rights to the specific folder.";
                        return false;
                    }
                }
            }
            catch
            {
                errormsg = "There is a problem with creating the export file. Please try again.";
                return false;
            }
            return true;
        }

        public static bool ExportMotifValidatorToExcel(string fileName, MotifValidator validator, bool overwrite, out string errormsg)
        {
            try
            {
                errormsg = "";
                FileInfo existingFile = new FileInfo(fileName);
                if (existingFile.Exists && !overwrite)
                    return false;
                using (ExcelPackage package = new ExcelPackage(existingFile))
                {
                    if (existingFile.Exists)
                    {
                        while (package.Workbook.Worksheets.Count > 0)
                            package.Workbook.Worksheets.Delete(1);
                    }
                    WriteToSheetValidator(package, validator);
                    WriteToSheetMotif(package, validator.Motif);

                    try
                    {
                        package.Save();
                    }
                    catch
                    {
                        errormsg = "There is a problem with saving the export file. Please make sure the file is not open and you have writing rights to the specific folder.";
                        return false;
                    }
                }
            }
            catch
            {
                errormsg = "There is a problem with creating the export file. Please try again.";
                return false;
            }
            return true;
        }
    }
}
   