using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;
using PhanTichDuLieu.Helper;

namespace PhanTichDuLieu
{
    public partial class frmThietLapHeThong : DevExpress.XtraEditors.XtraForm
    {
        bool flag = false;
        public frmThietLapHeThong()
        {
            
            InitializeComponent();

            this.KeyPreview = true;
            this.tbTaiKhoanDangNhap.PasswordChar = '\u25CF';
            this.tbMatKhauDangNhap.PasswordChar = '\u25CF';

            string _strFileName = Directory.GetCurrentDirectory() + @"\SqlConnection.txt";

            string[] lines = File.ReadAllLines(_strFileName);

            this.tbTenSQLServer.Text = lines[0].Split('=')[1].ToString().Trim();
            this.tbTenCoSoDuLieu.Text = lines[1].Split('=')[1].ToString().Trim();
            this.tbTaiKhoanDangNhap.Text = lines[2].Split('=')[1].ToString().Trim();
            this.tbMatKhauDangNhap.Text = lines[3].Split('=')[1].ToString().Trim();
            this.btnLuuKetNoi.Hide();
        }

        private void btnKiemTraKetNoi_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection(this.tbTenSQLServer.Text, this.tbTenCoSoDuLieu.Text, this.tbTaiKhoanDangNhap.Text, this.tbMatKhauDangNhap.Text);

            try
            {
                conn.Open();
                MessageBox.Show("Kết Nối Thành Công");
                flag = true;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Lỗi Kết Nối: " + ex.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

            if(flag)
            {
                this.btnLuuKetNoi.Show();
                this.btnKiemTraKetNoi.Hide();
            }
        }

        private void btnLuuKetNoi_Click(object sender, EventArgs e)
        {
            string _strFileName = System.IO.Directory.GetCurrentDirectory() + @"\SqlConnection.txt";

            if (File.Exists(_strFileName))
            {
                string a = "datasource = " + this.tbTenSQLServer.Text;
                string b = "database = " + this.tbTenCoSoDuLieu.Text;
                string c = "username = " + this.tbTaiKhoanDangNhap.Text;
                string d = "password = " + this.tbMatKhauDangNhap.Text;
                string[] createText = { a, b, c, d };
                File.WriteAllLines(_strFileName, createText);
                //MessageBox.Show("Lưu Thành Công");
                this.Close();
            }
        }

        private void frmThietLapHeThong_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Control)
            {
                if (e.Control && e.Alt && e.Shift && e.KeyCode == Keys.P)
                {
                    LicenceHelper myLicenceHelper = new LicenceHelper();

                    frmInputBox inputbox = new frmInputBox();
                    inputbox._nameForm = "";
                    inputbox._messageShow = "Key";
                    inputbox.set();
                    inputbox.ShowDialog();
                    string key = inputbox._result;

                    string r = "2dab18f6aa55589be27a2fe657fac1b2";
                    if (myLicenceHelper.GetLicense(key, "doconvit") == r)
                    {
                        myLicenceHelper.GetLicense("doconvit");
                        MessageBox.Show("Kích hoạt bản quyền thành công");
                    }
                    else
                    {
                        MessageBox.Show("Kích hoạt bản quyền thất bại");
                    }
                }

                if (e.Control && e.Shift && e.KeyCode == Keys.R)
                {
                    frmInitDatabase myform = new frmInitDatabase();
                    myform._nameForm = "Tạo cơ sở dữ liệu mới";
                    myform._messageShow = "Nhập tên CSDL muốn khởi tạo: ";
                    myform.set();
                    myform.ShowDialog();
                    string nameDatabase = myform._result;
                    this.initDatabase(nameDatabase);
                }
            }

            if(e.KeyCode == Keys.Escape)
            {
                this.Close();
            }
        }

        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void initDatabase(string nameDatabase)
        {
            SqlConnection conn_MAIN = DBUtils.GetDBConnection_Master("master");
            try
            {

                conn_MAIN.Open();
                
                string str = "CREATE DATABASE " + nameDatabase;
                DBUtils.ExecuteNonQuery(str, conn_MAIN);
                MessageBox.Show("Đã tạo thành công Database tên: " + nameDatabase + ", đang tiến hành khởi tạo dữ liệu.", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
                MessageBox.Show("Không khởi tạo được Database, vui lòng kiểm tra lại", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conn_MAIN.Close();
            }

            SqlConnection conn = DBUtils.GetDBConnection_Master(nameDatabase);
            try
            {

                conn.Open();
                
                string _strFileName = Directory.GetCurrentDirectory() + @"\Co So Du Lieu\script.sql";
                string script = File.ReadAllText(_strFileName);
                script = script.Replace("CoSoDuLieu2018_NguyenCongPhuc", nameDatabase);

                IEnumerable<string> commandStrings = Regex.Split(script, @"^\s*GO\s*$", RegexOptions.Multiline | RegexOptions.IgnoreCase);
                foreach (string commandString in commandStrings)
                {
                    if (commandString.Trim() != "")
                    {
                        new SqlCommand(commandString, conn).ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Đã khởi tạo xong dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                this.tbTenCoSoDuLieu.Text = nameDatabase;

            }
            catch
            {
                MessageBox.Show("Không khởi tạo được Database, vui lòng kiểm tra lại", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }
            finally
            {
                conn.Close();
            }
        }

        private void btnTesst_Click(object sender, EventArgs e)
        {
            SqlConnection conn = DBUtils.GetDBConnection_Master("master");
            try
            {

                conn.Open();

                string str = "CREATE DATABASE MyDatabase ON PRIMARY " +
                        "(NAME = MyDatabase_Data, " +
                        "FILENAME = 'D:\\MyDatabaseData.mdf', " +
                        "SIZE = 2MB, MAXSIZE = 10MB, FILEGROWTH = 10%) " +
                        "LOG ON (NAME = MyDatabase_Log, " +
                        "FILENAME = 'D:\\MyDatabaseLog.ldf', " +
                        "SIZE = 1MB, " +
                        "MAXSIZE = 5MB, " +
                        "FILEGROWTH = 10%)";
                str = "CREATE DATABASE MyDatabase";
                DBUtils.ExecuteNonQuery(str, conn);
            }
            catch
            {
                MessageBox.Show("Không khởi tạo được CSDL");
            }
            finally
            {
                conn.Close();
            }
        }
    }
}