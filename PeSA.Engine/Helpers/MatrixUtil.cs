using System.Text;
using System.Xml.Linq;

namespace PeSA.Engine
{
    public class MatrixUtil
    {
        public static string[,] StripHeaderRowColumns(string[,] data, bool checkNumeric)
        {
            if (data == null) return null;
            //Check column and row headers
            int rowcount = data.GetLength(0);
            int colcount = data.GetLength(1);
            if (rowcount > 1 && colcount > 1)
            {
                int rowheader = 1;
                int colheader = 1;
                for (int i = 0; i < colcount; i++)
                {
                    string s = data[0, i]?.Trim();
                    if (!string.IsNullOrWhiteSpace(s) && !s.Contains("Col") && !s.StartsWith("C") && !s.StartsWith("c") && (!checkNumeric || Int32.TryParse(s,out int dummy)))
                    {
                        colheader = 0;
                        break;
                    }
                }
                for (int i = 0; i < rowcount; i++)
                {
                    string s = data[i, 0]?.Trim();
                    if (!string.IsNullOrWhiteSpace(s) && !s.Contains("Col") && !s.StartsWith("R") && !s.StartsWith("r") && (!checkNumeric || Int32.TryParse(s,out int dummy)))
                    {
                        rowheader = 0;
                        break;
                    }
                }
                if (rowheader + colheader > 0)
                {

                    string[,] data2 = new string[rowcount - colheader, colcount - rowheader];
                    for (int rowind = 0; rowind < rowcount - colheader; rowind++)
                        for (int colind = 0; colind < colcount - rowheader; colind++)
                            data2[rowind, colind] = data[rowind + colheader, colind + rowheader];
                    return data2;
                }
            }
            return data;
        }

        public static double[,] ConvertToNumericMatrix(string[,] data)
        {
            if (data == null) return null;
            int rowCount = data.GetLength(0);
            int colCount = data.GetLength(1);
            double[,] matrix = new double[rowCount, colCount];
            for (int i = 0; i < rowCount; i++)
                for (int j = 0; j < colCount; j++)
                {
                    double d = 0;
                    if (double.TryParse(data[i, j], out d))
                        matrix[i, j] = d;
                }
            return matrix;
        }
        public static double GetMaxValue(double[,] matrix, int rowind = -1, int colind = -1)
        {
            if (matrix == null) return -1;
            if (rowind > matrix.GetLength(0) || colind > matrix.GetLength(1)) return -1;
            int startrow = rowind >= 0 ? rowind : 0;
            int endrow = rowind >= 0 ? rowind : matrix.GetLength(0) - 1;
            int startcol = colind >= 0 ? colind : 0;
            int endcol = colind >= 0 ? colind : matrix.GetLength(1) - 1;
            double maxval = 0;
            for (int i = startrow; i <= endrow; i++)
                for (int j = startcol; j <= endcol; j++)
                    if (matrix[i, j] > maxval)
                        maxval = matrix[i, j];
            return maxval;
        }

        public static string[,] ClipboardToMatrix(MemoryStream stream)
        {
            try
            {
                string[,] matrix = null;
                using (stream)
                {
                    var xml = Encoding.UTF8.GetString(stream.ToArray());
                    xml = xml.Substring(0, xml.Length - 1);
                    XDocument doc = XDocument.Parse(xml);
                    XNamespace ns = "urn:schemas-microsoft-com:office:spreadsheet";
                    var rows = doc.Descendants(ns + "Row");
                    int iRow = 0;
                    int iCol = 0;

                    int maxCol = 0;
                    foreach (XElement row in rows)
                    {
                        var cells = row.Elements(ns + "Cell");
                        int maxColPerRow = cells.Count(); //assuming there will be at least one row with all cells with values
                        if (maxColPerRow > maxCol)
                            maxCol = maxColPerRow;
                    }

                    matrix = new string[rows.Count(), maxCol];
                    foreach (XElement row in rows)
                    {
                        var cells = row.Elements(ns + "Cell");

                        int i = 0;
                        foreach (XElement cell in cells)
                        {
                            string cellValue = cell.Value;
                            if (cell.Attribute(ns + "Index") != null)
                            {
                                int cellindex = int.Parse(cell.Attribute(ns + "Index").Value);
                                while (cellindex - 1 > i)
                                {
                                    matrix[iRow, iCol + i] = "";
                                    i++;
                                }
                            }
                            if (iCol + i > maxCol - 1)
                                break;

                            matrix[iRow, iCol + i] = cellValue;

                            i++;
                        }
                        iRow++;
                    }
                }
                return matrix;
            }
            catch
            { return null; }
        }

    }
}
