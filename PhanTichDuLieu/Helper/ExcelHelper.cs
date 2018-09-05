using System;
using Excel = Microsoft.Office.Interop.Excel;
using System.Windows.Forms;
using System.Data;
namespace PhanTichDuLieu
{
    public class ExcelHelper
    {
        static public void exportDataToExcel(DataGridView myDataGridViewQuantity)
        {
            //bool result = false;
            Excel.Application xlApp = null; //Excel_12 Application 
            Excel.Workbook xlBook = null; // Excel_12 Workbook 
            Excel.Sheets xlSheetsColl = null; // Excel_12 Worksheets collection 
            Excel.Worksheet xlSheet = null; // Excel_12 Worksheet 
            Excel.Range oRange = null; // Cell or Range in worksheet 
            Object missValue = System.Reflection.Missing.Value;
            xlApp = new Excel.Application();
            xlApp.UserControl = true;
            xlBook = xlApp.Workbooks.Add(missValue);
            xlSheetsColl = xlApp.Worksheets;
            xlSheet = (Excel.Worksheet)xlSheetsColl.get_Item("Sheet1");
            xlSheet.Name = "XML123";

            xlApp.Visible = false;


            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "Excel file (*.xls)|*.xls";
            if (f.ShowDialog() == DialogResult.OK)
            {

                //set header
                
                Excel.Range header = xlSheet.get_Range("A1", "CA1");
                header.Select();
                header.HorizontalAlignment = Excel.Constants.xlCenter;
                header.Font.Bold = true;
                header.Font.Size = 10;
                

                // Export titles 
                for (int j = 0; j < myDataGridViewQuantity.Columns.Count; j++)
                {

                    oRange = (Excel.Range)xlSheet.Cells[1, j + 1];

                    oRange.Value2 = myDataGridViewQuantity.Columns[j].HeaderText;

                }
                // Export data 

                for (int i = 0; i < myDataGridViewQuantity.Rows.Count; i++)
                {

                    for (int j = 0; j < myDataGridViewQuantity.Columns.Count; j++)
                    {
                        oRange = (Excel.Range)xlSheet.Cells[i + 2, j + 1];

                        oRange.Value2 = myDataGridViewQuantity[j, i].Value;
                    }
                }

                //autofit size column
                //for (int i = 0; i < myDataGridViewQuantity.Rows.Count; i++)
                  //  ((Excel.Range)xlSheet.Cells[1, i + 1]).EntireColumn.AutoFit();

                //save file
                xlBook.SaveAs(f.FileName, Excel.XlFileFormat.xlWorkbookNormal, missValue, missValue, missValue, missValue, Excel.XlSaveAsAccessMode.xlExclusive, missValue, missValue, missValue, missValue, missValue);
                xlBook.Close(true, missValue, missValue);
                xlApp.Quit();
                releaseObject(xlSheet);
                releaseObject(xlBook);
                releaseObject(xlApp);
                MessageBox.Show("Đã xuất xong dữ liệu: \n" + f.FileName);
                //result = true;
            }
            //return result;
        }
        static public void releaseObject(object obj)
        {
            try
            {
                System.Runtime.InteropServices.Marshal.ReleaseComObject(obj);
                obj = null;
            }
            catch (Exception ex)
            {
                obj = null;
                MessageBox.Show("Lỗi: " + ex.ToString());
                throw new Exception("Exception Occured while releasing object " + ex.ToString());
            }
            finally
            {
                GC.Collect();
            }
        }

        public static DataTable getExcelFile(string _strFileName)
        {
            Excel.Application xlApp = new Excel.Application();
            Excel.Workbook xlWorkbook = xlApp.Workbooks.Open(_strFileName);
            Excel._Worksheet xlWorksheet = xlWorkbook.Sheets[1];
            Excel.Range xlRange = xlWorksheet.UsedRange;

            int rowCount = xlRange.Rows.Count;
            int colCount = xlRange.Columns.Count;
            DataTable dt = new DataTable("CSKCB");
            dt.Columns.Add("Mã CSKCB", typeof(string));
            dt.Columns.Add("Tên CSKCB", typeof(string));

            for (int i = 1; i <= rowCount; i++)
            {
                if (xlRange.Cells[i, 2].Value2 != null && xlRange.Cells[i, 3].Value2 != null)
                {
                    DataRow row = dt.NewRow();
                    row["Mã CSKCB"] = xlRange.Cells[i, 2].Value2.ToString();
                    row["Tên CSKCB"] = xlRange.Cells[i, 3].Value2.ToString();
                    dt.Rows.Add(row);
                }
            }

            //cleanup
            GC.Collect();
            GC.WaitForPendingFinalizers();
            xlWorkbook.Close();

            //quit and release
            xlApp.Quit();
            return dt;
        }
    }
} 

