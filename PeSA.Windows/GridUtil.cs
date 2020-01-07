using PeSA.Engine;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Linq;

namespace PeSA.Windows
{
    public class GridUtil
    {
        public static void LoadNumericMatrixToGrid(DataGridView dg, double[,] numericMatrix, int headerRow = 0, int headerColumn = 0)
        {
            int rowCount = numericMatrix.GetLength(0);
            int colCount = numericMatrix.GetLength(1);
            dg.RowCount = rowCount + headerRow;
            dg.ColumnCount = colCount + headerColumn;
            for (int i = 0; i < rowCount; i++)
                for (int j = 0; j < colCount; j++)
                {
                    dg[j + headerColumn, i + headerRow].Value = numericMatrix[i, j];
                }
        }

        public static void LoadStringMatrixToGrid(DataGridView dg, string[,] textMatrix, int headerRow = 0, int headerColumn = 0)
        {
            //done on pase or load file textMatrix = MatrixUtil.StripHeaderRowColumns(textMatrix);
            int rowCount = textMatrix.GetLength(0);
            int colCount = textMatrix.GetLength(1);
            dg.RowCount = rowCount + headerRow;
            dg.ColumnCount = colCount + headerColumn;
            for (int i = 0; i < rowCount; i++)
                for (int j = 0; j < colCount; j++)
                {
                    dg[j + headerColumn, i + headerRow].Value = textMatrix[i, j];
                }
        }

        public static void PasteClipboard(DataGridView dgGrid)
        {
            try
            {
                var dataObject = Clipboard.GetDataObject();
                using (var stream = (MemoryStream)dataObject.GetData("XML Spreadsheet"))
                {
                    var xml = Encoding.UTF8.GetString(stream.ToArray());
                    xml = xml.Substring(0, xml.Length - 1);
                    XDocument doc = XDocument.Parse(xml);
                    XNamespace ns = "urn:schemas-microsoft-com:office:spreadsheet";
                    var rows = doc.Descendants(ns + "Row");
                    dgGrid.ReadOnly = false;
                    dgGrid.RowCount = rows.Count();
                    dgGrid.ColumnCount = 1;
                    dgGrid.CurrentCell = dgGrid[0, 0];

                    dgGrid.SuspendLayout();
                    dgGrid.BeginEdit(true);
                    int iRow = dgGrid.CurrentCell.RowIndex;
                    int iCol = dgGrid.CurrentCell.ColumnIndex;
                    DataGridViewCell curCell;

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
                                    curCell = dgGrid[iCol + i, iRow];
                                    curCell.Value = Convert.ChangeType("", dgGrid.CurrentCell.ValueType);
                                    i++;
                                }
                            }
                            if (iCol + i >= dgGrid.ColumnCount)
                                dgGrid.ColumnCount++;
                            if (iCol + i < dgGrid.ColumnCount)
                            {
                                curCell = dgGrid[iCol + i, iRow];
                                var v = dgGrid.Columns[iCol + i].ValueType != null ? Convert.ChangeType(cellValue, dgGrid.Columns[iCol + i].ValueType) : cellValue;
                                if (!string.IsNullOrEmpty(dgGrid.Columns[iCol + i].DefaultCellStyle?.Format))
                                    curCell.Value = string.Format("{0:" + dgGrid.Columns[iCol + i].DefaultCellStyle.Format + "}", v);
                                else
                                    curCell.Value = v;
                            }

                            i++;
                        }
                        iRow++;
                    }
                }
                dgGrid.Rows[0].DefaultCellStyle = dgGrid.ColumnHeadersDefaultCellStyle;
                dgGrid.Columns[0].DefaultCellStyle = dgGrid.ColumnHeadersDefaultCellStyle;
            }
            catch (Exception exc)
            {
                MessageBox.Show("The data you pasted is not formatted correctly: " + exc.Message, Analyzer.ProgramName);
            }
            finally
            {
                dgGrid.ReadOnly = true;
                dgGrid.EndEdit();
                dgGrid.ResumeLayout();
            }
        }

        public static void FormatGrid(DataGridView dg)
        {
            try
            {
                dg.DefaultCellStyle.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dg.RowHeightChanged += GridRowHeightChanged;
                dg.ColumnWidthChanged += GridColumnWidthChanged;
            }
            catch
            {
            }
        }

        static bool skipColWidthChange = false;
        private static void GridColumnWidthChanged(object sender, DataGridViewColumnEventArgs e)
        {
            if (skipColWidthChange) return;
            try
            {
                skipColWidthChange = true;
                DataGridView dg = sender as DataGridView;
                int width = e.Column.Width;
                if (dg.SelectedColumns.Count > 0)
                    foreach (DataGridViewColumn col in dg.SelectedColumns)
                        col.Width = width;
                else if (dg.SelectedCells.Count > 0)
                {
                    List<int> colList = new List<int>();
                    foreach (DataGridViewCell cell in dg.SelectedCells)
                    {
                        if (!colList.Contains(cell.ColumnIndex))
                            colList.Add(cell.ColumnIndex);
                    }
                    foreach (int colind in colList)
                        dg.Columns[colind].Width = width;
                }

            }
            catch
            {
            }
            finally
            {
                skipColWidthChange = false;
            }
        }

        static bool skipRowHeightChange = false;
        private static void GridRowHeightChanged(object sender, DataGridViewRowEventArgs e)
        {
            if (skipRowHeightChange) return;
            try
            {
                skipRowHeightChange = true;
                DataGridView dg = sender as DataGridView;
                int height = e.Row.Height;
                if (dg.SelectedRows.Count > 0)
                    foreach (DataGridViewRow row in dg.SelectedRows)
                        row.Height = height;
                else if (dg.SelectedCells.Count > 0)
                {
                    List<int> rowList = new List<int>();
                    foreach (DataGridViewCell cell in dg.SelectedCells)
                    {
                        if (!rowList.Contains(cell.RowIndex))
                            rowList.Add(cell.RowIndex);
                    }
                    foreach (int rowind in rowList)
                        dg.Rows[rowind].Height = height;
                }
            }
            catch
            {
            }
            finally
            {
                skipRowHeightChange = false;
            }
        }
    }
}
