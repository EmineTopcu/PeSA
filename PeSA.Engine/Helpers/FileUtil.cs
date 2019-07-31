using OfficeOpenXml;
using OfficeOpenXml.Style;
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
        private static string[,] ReadArrayFromFile(string fileName)
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
                return data;
            }
            catch
            {
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
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[1];
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
            catch 
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
                data = MatrixUtil.StripHeaderRowColumns(data);

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
                        else if (dMatrix!=null)
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

        private static ExcelWorksheet GetWorksheet(ExcelPackage package, string sheetname)
        {
            try
            {
                ExcelWorksheet worksheet = package.Workbook.Worksheets[sheetname];

                if (worksheet == null)
                    worksheet = package.Workbook.Worksheets.Add(sheetname);
                else
                    worksheet.Cells.Clear();
                return worksheet;
            }
            catch 
            {
                return null;
            }
        }
        private static void WriteToSheetModifiedPeptideList(ExcelPackage package, List<string> peptidelist, double threshold, string wildtypesequence = "")
        {
            ExcelWorksheet worksheet = GetWorksheet(package, "Modified Peptides");

            int rowind = 1;
            worksheet.Cells[rowind, 1].Value = "Threshold:";
            worksheet.Cells[rowind++, 2].Value = threshold;
            if (wildtypesequence != "")
            {
                worksheet.Cells[rowind, 1].Value = "Wildtype Sequence:";
                worksheet.Cells[rowind++, 2].Value = wildtypesequence;
            }

            ListToExcelColumn(worksheet, rowind + 1, 1, "Peptides", peptidelist);
            worksheet.Column(1).AutoFit();
            worksheet.Column(2).AutoFit();
        }

        private static void WriteToSheetMotif(ExcelPackage package, Dictionary<int, Dictionary<char, double>> Weights, double threshold, string wildtypesequence = "")
        {
            ExcelWorksheet worksheet = GetWorksheet(package, "Motif");

            worksheet.Drawings.Clear();

            int rowind = 1;
            worksheet.Cells[rowind, 1].Value = "Threshold:";
            worksheet.Cells[rowind++, 2].Value = threshold;
            if (wildtypesequence != "")
            {
                worksheet.Cells[rowind, 1].Value = "Wildtype Sequence:";
                worksheet.Cells[rowind++, 2].Value = wildtypesequence;
            }

            Settings settings = Settings.Load("default.settings");
            int heightImage = 200;
            int widthImage = 800;
            if (settings != null)
            {
                heightImage = settings.MotifHeight;
                widthImage = settings.MotifWidth;
            }
            Bitmap bmp = Analyzer.CreateMotif(Weights, settings.MotifThreshold, widthImage, heightImage, settings.MotifMaxAAPerColumn);
            if (bmp != null)
            {
                var picture = worksheet.Drawings.AddPicture("Motif", bmp);
                picture.SetPosition(rowind, 0, 1, 0);
            }

            int occupiedRows = (int)Math.Round(heightImage / worksheet.Row(rowind).Height);
            rowind += occupiedRows + 1;

            worksheet.Cells[rowind++, 1].Value = "Motif Data:";
            int startrow = rowind;
            worksheet.Row(startrow).Style.Font.Bold = true;
            worksheet.Row(startrow + 1).Style.Font.Bold = true;
            int colind = 1;
            foreach (int pos in Weights.Keys)
            {
                worksheet.Cells[startrow, colind].Value = "Position: " + (pos + 1).ToString();
                worksheet.Cells[startrow, colind, startrow, colind + 1].Merge = true;
                worksheet.Cells[startrow, colind, startrow, colind + 1].Style.HorizontalAlignment = OfficeOpenXml.Style.ExcelHorizontalAlignment.Center;

                worksheet.Cells[startrow + 1, colind].Value = "Amino-acid";
                worksheet.Cells[startrow + 1, colind + 1].Value = "Percentage";
                Dictionary<char, double> perCol = Weights[pos];
                rowind = startrow + 2;
                foreach (char aa in perCol.Keys)
                {
                    worksheet.Cells[rowind, colind].Value = aa.ToString();
                    worksheet.Cells[rowind, colind + 1].Value = perCol[aa];
                    worksheet.Cells[rowind++, colind + 1].Style.Numberformat.Format = "0.00%";
                }
                worksheet.Column(colind).AutoFit();
                worksheet.Column(colind + 1).AutoFit();
                colind += 2;
            }
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
                    //get the first worksheet in the workbook
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["Arrays"];

                    if (worksheet == null)
                        worksheet = package.Workbook.Worksheets.Add("Arrays");
                    else
                        worksheet.Cells.Clear();

                    int lastrow = MatrixToExcel(worksheet, 1, "Peptide Matrix", PA.PeptideMatrix);
                    if (lastrow < 0) return false;
                    lastrow = MatrixToExcel(worksheet, lastrow + 3, "Binary Matrix", PA.BinaryMatrix);
                    if (lastrow < 0) return false;
                    lastrow = MatrixToExcel(worksheet, lastrow + 3, "Quantification Matrix", PA.QuantificationMatrix);
                    if (lastrow < 0) return false;
                    lastrow = MatrixToExcel(worksheet, lastrow + 3, "Normalized Matrix", PA.NormalizedMatrix);

                    WriteToSheetModifiedPeptideList(package, PA.ModifiedPeptides, PA.Threshold);
                    WriteToSheetMotif(package, Analyzer.GenerateFrequencies(PA.ModifiedPeptides, PA.PeptideLength), PA.Threshold);
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

        public static PermutationArray ReadPermutationArrayQuantificationData(string fileName)
        {
            string[,] data = ReadArrayFromFile(fileName);

            bool permX = false, permY = false;
            PermutationArray.CheckPermutationAxis(data, ref permX, ref permY);
            if (!permX && !permY)
                return null;
            Settings settings = Settings.Load("default.settings");
            PermutationArray PA = new PermutationArray(data, permX, settings.WildTypeYAxisTopToBottom, out string error);
            return PA;
        }

        public static OPALArray ReadOPALArrayQuantificationData(string fileName)
        {

            string[,] data = ReadArrayFromFile(fileName);

            bool permX = false, permY = false;
            OPALArray.CheckPermutationAxis(data, ref permX, ref permY);
            if (!permX && !permY)
                return null;
            OPALArray OA = new OPALArray(data, permX, out string error);
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
                    int pc = package.Workbook.Worksheets.Count();
                    //get the first worksheet in the workbook
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["Arrays"];

                    if (worksheet == null)
                        worksheet = package.Workbook.Worksheets.Add("Arrays");
                    else
                        worksheet.Cells.Clear();

                    List<string> headerrow = new List<string>();
                    List<string> headercolumn = new List<string>();
                    if (PA.PermutationXAxis)
                    {
                        headercolumn = PA.WildTypePeptide.ToCharArray().ToList().ConvertAll(c => c.ToString());
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
                    if (PA.PermutationXAxis)
                        ListToExcelColumn(worksheet, startrow + 1, PA.QuantificationMatrix.GetLength(1) + 2, "Norm By", PA.NormBy.ToList());
                    else
                        ListToExcelRow(worksheet, lastrow + 1, 1, "Norm By", PA.NormBy.ToList());

                    startrow = lastrow + 3;
                    lastrow = MatrixToExcel(worksheet, lastrow + 3, "Normalized Matrix", PA.NormalizedMatrix);
                    ListToExcelRow(worksheet, startrow + 1, 1, "", headerrow);
                    ListToExcelColumn(worksheet, startrow + 1, 1, "", headercolumn);

                    worksheet.Cells[lastrow + 2, 1].Value = "Threshold: ";
                    worksheet.Cells[lastrow + 2, 2].Value = PA.Threshold;

                    WriteToSheetModifiedPeptideList(package, PA.ModifiedPeptides, PA.Threshold, PA.WildTypePeptide);
                    WriteToSheetMotif(package, PA.GenerateWeights(), PA.Threshold, PA.WildTypePeptide);

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
                    int pc = package.Workbook.Worksheets.Count();
                    //get the first worksheet in the workbook
                    ExcelWorksheet worksheet = package.Workbook.Worksheets["Arrays"];

                    if (worksheet == null)
                        worksheet = package.Workbook.Worksheets.Add("Arrays");
                    else
                        worksheet.Cells.Clear();

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

                    startrow = lastrow + 3;
                    lastrow = MatrixToExcel(worksheet, startrow, "Normalized Matrix", OA.NormalizedMatrix);
                    ListToExcelRow(worksheet, startrow + 1, 1, "", headerrow);
                    ListToExcelColumn(worksheet, startrow + 1, 1, "", headercolumn);

                    WriteToSheetMotif(package, OA.GenerateWeights(), OA.Threshold);

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

    }
}
   