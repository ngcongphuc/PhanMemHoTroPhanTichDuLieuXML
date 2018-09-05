using System.Data.SQLite;
using System.Data;
using System.Windows.Forms;

namespace PhanTichDuLieu
{
    class SQLiteHelper
    {
        static public SQLiteConnection conn;
        static public SQLiteCommand cmd;
        static public SQLiteDataAdapter adapter;
        //static public SQLiteConnection conn = new SQLiteConnection();
        //static public SQLiteCommand cmd = new SQLiteCommand();
        //static public SQLiteDataAdapter adapter = new SQLiteDataAdapter();

        static public void setConnString(string _connString)
        {

            conn = new SQLiteConnection();
            cmd = new SQLiteCommand();
            adapter = new SQLiteDataAdapter();
            conn.ConnectionString = "Data Source =" + _connString;
            conn.Open();
        }
        static public DataTable loadDatafromDB(string _queryString)
        {
            DataTable dt = new DataTable();
            try
            {
                cmd.Connection = conn;
                adapter.SelectCommand = cmd;
                cmd.CommandText = _queryString;
                
                dt.Rows.Clear();
                adapter.Fill(dt);
                return dt;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
                return dt;
            }
            finally
            {
                conn.Close();
                cmd.Cancel();
                cmd.Dispose();
                adapter.Dispose();
            }
        }

        static public bool executeNonQuery(string _queryString)
        {
            try
            {
                cmd.Connection = conn;
                adapter.SelectCommand = cmd;
                cmd.CommandText = _queryString;

                cmd.ExecuteNonQuery();
                return true;
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
                return false;
            }
            finally
            {
            }

        }
    }
}
