using System.Data;
namespace PhanTichDuLieu
{
    public class TextHelper
    {

        public static DataTable getTextFile(string _strFileName)
        {
            DataTable dt = new DataTable("CSKCB");
            dt.Columns.Add("Mã CSKCB", typeof(string));
            dt.Columns.Add("Tên CSKCB", typeof(string));

            string[] lines = System.IO.File.ReadAllLines(_strFileName);

            foreach (string line in lines)
            {
                string[] arrListLine = line.Split('|');
                if (arrListLine.Length == 2)
                {
                    DataRow row = dt.NewRow();
                    row["Mã CSKCB"] = arrListLine[0].ToString().Trim();
                    row["Tên CSKCB"] = arrListLine[1].ToString().Trim();
                    dt.Rows.Add(row);
                }
            }
            return dt;
        }
    }
} 

