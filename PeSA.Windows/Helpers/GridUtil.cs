using PeSA.Engine;
using System;
using System.Collections.Generic;
using System.Drawing;
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
        DataGridView dg;
        public int searchLastRow = 0, searchLastCol = 0;
        string searchString = "";
        public bool StringFound = false;

        public GridUtil(DataGridView dgIn)
        {
            dg = dgIn;
        }

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

        private static bool PasteClipboardText(DataGridView dgGrid)
        {
            var dataObject = Clipboard.GetDataObject();
            string stream = (string)dataObject.GetData("Text");
            if (stream == null) return false;
            string[] lines = stream.Split('\n');
            {

                dgGrid.ReadOnly = false;
                dgGrid.RowCount = lines.Count();
                dgGrid.ColumnCount = 1;
                dgGrid.CurrentCell = dgGrid[0, 0];

                dgGrid.SuspendLayout();
                dgGrid.BeginEdit(true);
                int iRow = dgGrid.CurrentCell.RowIndex;
                int iCol = dgGrid.CurrentCell.ColumnIndex;
                DataGridViewCell curCell;

                foreach (string line in lines)
                {
                    string[] cells = line.Split('\t');
                    int i = 0;
                    foreach (string cell in cells)
                    {
                        /*if (cell.Attribute(ns + "Index") != null)
                        {
                            int cellindex = int.Parse(cell.Attribute(ns + "Index").Value);
                            while (cellindex - 1 > i)
                            {
                                curCell = dgGrid[iCol + i, iRow];
                                curCell.Value = Convert.ChangeType("", dgGrid.CurrentCell.ValueType);
                                i++;
                            }
                        }*/
                        if (iCol + i >= dgGrid.ColumnCount)
                            dgGrid.ColumnCount++;
                        if (iCol + i < dgGrid.ColumnCount)
                        {
                            curCell = dgGrid[iCol + i, iRow];
                            var v = dgGrid.Columns[iCol + i].ValueType != null ? Convert.ChangeType(cell, dgGrid.Columns[iCol + i].ValueType) : cell.Trim();
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
            return true;
        }

        private static bool PasteClipboardExcel(DataGridView dgGrid)
        {
            var dataObject = Clipboard.GetDataObject();
            MemoryStream stream = (MemoryStream)dataObject.GetData("XML Spreadsheet");
            if (stream == null) return false;
            using (stream)
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
            return true;
        }

        public static void PasteClipboard(DataGridView dgGrid)
        {
            try
            {
                if (!PasteClipboardExcel(dgGrid))
                    PasteClipboardText(dgGrid);
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
                dg.RowTemplate.Height = 22;
                dg.DefaultCellStyle.Font = new System.Drawing.Font("Courier New", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
                dg.RowHeightChanged += GridRowHeightChanged;
                dg.ColumnWidthChanged += GridColumnWidthChanged;
                dg.DoubleClick += GridDoubleClick;
            }
            catch
            {
            }
        }

        private static void GridDoubleClick(object sender, EventArgs e)
        {
            try
            {
                DataGridView dg = sender as DataGridView;
                if (dg.CurrentCell.RowIndex == 0 && dg.CurrentCell.ColumnIndex == 0)
                    dg.SelectAll();
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

        public void SearchPeptide(bool next)
        {
            try
            {
                if (!next)
                {
                    searchString = Microsoft.VisualBasic.Interaction.InputBox("Search", DefaultResponse: searchString);
                }
                StringFound = false;
                if (searchString.Length > 0)
                {
                    int startrow = next ? searchLastRow : 0;
                    int startcol = next ? searchLastCol + 1 : 0;
                    if (startcol >= dg.ColumnCount)
                    {
                        startrow++;
                        startcol = 0;
                        if (startcol >= dg.RowCount)
                            startcol = 0;
                    }
                    for (int rowind = startrow; rowind < dg.RowCount; rowind++)
                    {
                        for (int colind = startcol; colind < dg.ColumnCount; colind++)
                        {
                            if (dg[colind, rowind].Value == null) continue;
                            if (dg[colind, rowind].Value.ToString().Contains(searchString))
                            {
                                StringFound = true;
                                dg.CurrentCell = dg[colind, rowind];
                                searchLastRow = rowind;
                                searchLastCol = colind;
                                break;
                            }
                        }
                        if (StringFound) break;
                        startcol = 0;
                    }
                    if (next && !StringFound && searchLastRow + searchLastCol > 0) //start from the top
                    {
                        for (int rowind = 0; rowind <= searchLastRow; rowind++)
                        {
                            for (int colind = 0; colind < dg.ColumnCount; colind++)
                            {
                                if (dg[colind, rowind].Value == null) continue;
                                if (rowind == searchLastRow && colind == searchLastCol) break;
                                if (dg[colind, rowind].Value.ToString().Contains(searchString))
                                {
                                    StringFound = true;
                                    dg.CurrentCell = dg[colind, rowind];
                                    searchLastRow = rowind;
                                    searchLastCol = colind;
                                    break;
                                }
                            }
                        }
                    }
                }
            }
            catch
            {
            }
        }
    }
}
