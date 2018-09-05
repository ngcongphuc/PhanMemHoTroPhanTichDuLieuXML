using System;
using System.Data;
using System.IO;
using System.Windows.Forms;
namespace PhanTichDuLieu
{
    public partial class frmChiaDuLieuSQLite : Form
    {
        public frmChiaDuLieuSQLite()
        {
            //TRUNCATE TABLE
            InitializeComponent();
            this.lbFooter.Text = "Design by Nguyễn Công Phúc, @123 | Mail: ngcongphuc@gmail.com | 01688.248.266 | BHXH Đăk Nông";
            this.WindowState = FormWindowState.Maximized;
            this.tbFileMain.Enabled = false;
            this.lbFileMain.Text = "Dòng Dữ Liệu: 0";
            this.lbLuuY.Text = "Chú ý: Dữ liệu chuẩn SQLite đưa vào bắt buộc phải chứa bảng có tên 'xml123'";
        }
        
        static public string _fileNameMain_Old = "";
        static public string _fileNameMain_New = "";
        DataTable dtMain = null;

        public void khoiTaoKhoangThoiGianTruyVan()
        {
            string _month = DateTime.Now.Month.ToString();
            if (DateTime.Now.Month < 10)
            {
                _month = "0" + _month;
            }
            this.tbThoiGianKetThuc.Text = DateTime.Now.Year.ToString() + _month;
            this.tbThoiGianBatDau.Text = ((int)DateTime.Now.Year - 1).ToString() + _month;

        }

        private void btlLoadFileMain_Click(object sender, EventArgs e)
        {
            this.gridControlMain.DataSource = null;
            OpenFileDialog dlg = new OpenFileDialog();

            dlg.Filter = "SQLite File (*.db)|*.db|All Files (*.*)|*.*";

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                _fileNameMain_Old = dlg.FileName;
                string temp = _fileNameMain_Old;
                _fileNameMain_New = temp.Split('.')[0].ToString() + "_splited.db";
                this.tbFileMain.Text = _fileNameMain_New;
                using (frmWaitForm frm = new frmWaitForm(saoChepDuLieu))
                {
                    frm.ShowDialog(this);
                    MessageBox.Show("Đã tải xong dữ liệu");
                }

            }
        }

        void saoChepDuLieu()
        {
            File.Copy(_fileNameMain_Old, _fileNameMain_New);
        }

        private void btnSplit_Click(object sender, EventArgs e)
        {
            using (frmWaitForm frm = new frmWaitForm(tachDuLieu))
            {
                frm.ShowDialog(this);
                MessageBox.Show("Đã xử lý xong dữ liệu");
            }
        }



        public int i = 2;

        private void timerlbFooter_Tick(object sender, EventArgs e)
        {
            this.lbFooter.Left += i;
            if (this.lbFooter.Left >= this.Width - this.lbFooter.Width || this.lbFooter.Left <= 0)
                i = -i;
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {
            using (frmWaitForm frm = new frmWaitForm(hienThiDuLieu))
            {
                frm.ShowDialog(this);
                this.gridControlMain.DataSource = this.dtMain;
                this.lbFileMain.Text = "Dòng Dữ Liệu: " + this.dtMain.Rows.Count.ToString();
                MessageBox.Show("Tải xong dữ liệu: " + this.dtMain.Rows.Count.ToString() + " Dòng");
            }


        }
        

        void hienThiDuLieu()
        {
            SQLiteHelper.setConnString(_fileNameMain_New);
            this.dtMain = SQLiteHelper.loadDatafromDB("SELECT KY_QT, MA_CSKCB,HO_TEN,MA_THE,NGAY_SINH,GIOI_TINH,MA_DKBD,NGAY_VAO,NGAY_RA,MA_BENH,MA_BENHKHAC,TEN_BENH, T_TONGCHI,T_BNTT,T_bhtt FROM xml123");

        }
        void tachDuLieu()
        {
            string query = "DELETE FROM xml123 WHERE KY_QT NOT BETWEEN '" + this.tbThoiGianBatDau.Text + "' AND '" + this.tbThoiGianKetThuc.Text + "'";

            SQLiteHelper.setConnString(_fileNameMain_New);
            SQLiteHelper.executeNonQuery(query);

            query = "VACUUM";
            SQLiteHelper.executeNonQuery(query);

            /*string SQL = @"ATTACH '" + _fileNameMain_New + "' AS TOMERGE";

            SQLiteHelper.setConnString(_fileNameMain_New);
            SQLiteHelper.cmd.Connection = SQLiteHelper.conn;
            SQLiteHelper.adapter.SelectCommand = SQLiteHelper.cmd;
            SQLiteHelper.cmd.CommandText = SQL;
            int retval = 0;
            try
            {
                retval = SQLiteHelper.cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
            }

            SQL = "TRUNCATE TABLE xml123";
            SQLiteHelper.cmd.CommandText = SQL;

            retval = 0;
            try
            {
                retval = SQLiteHelper.cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
            }

            /*
            string a = "(SELECT * FROM TOMERGE.xml123 WHERE KY_QT BETWEEN '" + this.tbThoiGianBatDau.Text + "' AND '" + this.tbThoiGianKetThuc.Text + "') as test";
            SQL = "INSERT INTO xml123 SELECT * FROM " + a;
            SQLiteHelper.cmd.CommandText = SQL;
            retval = 0;
            try
            {
                retval = SQLiteHelper.cmd.ExecuteNonQuery();
            }
            catch (SQLiteException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                SQLiteHelper.conn.Close();
                SQLiteHelper.cmd.Cancel();
                SQLiteHelper.cmd.Dispose();
                SQLiteHelper.adapter.Dispose();
            }
            */
        }

        private void frmChiaDuLieuSQLite_Load(object sender, EventArgs e)
        {
            khoiTaoKhoangThoiGianTruyVan();
        }
    }
}
