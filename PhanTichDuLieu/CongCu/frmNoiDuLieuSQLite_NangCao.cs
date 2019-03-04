using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SQLite;

namespace PhanTichDuLieu
{
    public partial class frmNoiDuLieuSQLite_NangCao : DevExpress.XtraEditors.XtraForm
    {
        public frmNoiDuLieuSQLite_NangCao()
        {
            InitializeComponent();
            this.tbFileMain.Enabled = false;

            this.lbTypeData.Text = "Chọn Loại Dữ Liệu";
            this.btlLoadFileMain.Text = "Chọn Dữ Liệu Gốc";
            this.btnClickTest.Text = "Chọn Dữ Liệu Ghép";
            this.btnMerger.Text = "Nối Dữ Liệu";
            this.btnClose.Text = "Thoát";
            this.lbFileMain.Text = "Số dòng: 0";
            this.btnShowHide.Text = "Hiện";

            this.cbbMain.Items.Add("xml123");
            this.cbbMain.Items.Add("bhyt14a");
            this.cbbMain.Items.Add("bhyt19a");
            this.cbbMain.Items.Add("bhyt20a");
            this.cbbMain.Items.Add("bhyt21a");
            this.cbbMain.Items.Add("bhyt7980a");

            this.cbbMain.SelectedItem = "xml123";
        }

        static public string _fileNameMain = "";
        static public List<string> _itemsMain = null;

        SQLiteConnection conn = new SQLiteConnection();
        SQLiteCommand cmd = new SQLiteCommand();
        SQLiteDataAdapter adapter = new SQLiteDataAdapter();
        DataTable dt1 = new DataTable();
        BindingSource bs = new BindingSource();
        DataTable dtMain = null;

        private void btnClickTest_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQLite File (*.db)|*.db|All Files (*.*)|*.*";
            dlg.Multiselect = true; //Chỗ này nè
            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                List<string> _items = new List<string>();
                _itemsMain = new List<string>();
                foreach (string str in dlg.FileNames)
                {
                    _itemsMain.Add(str);
                }
                foreach (string str in dlg.SafeFileNames)
                {

                    _items.Add(str);
                }
                this.lbDanhSachTapTinDB.DataSource = _items;
            }
        }

        private void btnMerger_Click(object sender, EventArgs e)
        {
            string typedata = this.cbbMain.SelectedItem.ToString();
            if (tbFileMain.Text != "" && _itemsMain != null)
            {
                foreach (string _item in _itemsMain)
                {
                    if (_item == this.tbFileMain.Text)
                    {
                        MessageBox.Show("Trung tap tin ghep noi");
                        return;
                    }
                    string SQL = @"ATTACH '" + _item + "' AS TOMERGE";

                    SQLiteHelper.setConnString(_fileNameMain);
                    SQLiteHelper.cmd.Connection = SQLiteHelper.conn;
                    SQLiteHelper.adapter.SelectCommand = SQLiteHelper.cmd;
                    SQLiteHelper.cmd.CommandText = SQL;

                    int retval = 0;
                    try
                    {
                        retval =SQLiteHelper.cmd.ExecuteNonQuery();
                    }
                    catch (SQLiteException ex)
                    {
                        MessageBox.Show("Error: " + ex.ToString());
                    }
                    finally
                    {
                    }

                    SQL = "INSERT INTO " + typedata + " SELECT * FROM TOMERGE." + typedata;
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
                }
                MessageBox.Show("Merger Done!");
            }
            else
            {
                MessageBox.Show("No files selected!");
            }
        }

        private void btlLoadFileMain_Click(object sender, EventArgs e)
        {
            if (this.cbbMain.SelectedItem.ToString() != "")
            {
                //MessageBox.Show(this.cbbMain.SelectedItem.ToString() , "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string typedata = this.cbbMain.SelectedItem.ToString();


                this.gridViewMain.DataSource = null;
                OpenFileDialog dlg = new OpenFileDialog();
                dlg.Filter = "SQLite File (*.db)|*.db|All Files (*.*)|*.*";

                if (dlg.ShowDialog(this) == DialogResult.OK)
                {
                    this.tbFileMain.Text = dlg.FileName;
                    _fileNameMain = dlg.FileName;

                    SQLiteHelper.setConnString(_fileNameMain);
                    this.dtMain = SQLiteHelper.loadDatafromDB("Select * From " + typedata);
                    //this.gridViewMain.DataSource = SQLiteHelper.loadDatafromDB("Select * From xml123");

                    this.lbFileMain.Text = "Số dòng: " + this.dtMain.Rows.Count.ToString();
                    MessageBox.Show("Tải xong dữ liệu: " + this.dtMain.Rows.Count.ToString() + " Dòng");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn loại dữ liệu!", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }
        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnShowHide_Click(object sender, EventArgs e)
        {

            if (btnShowHide.Text == "Hiện")
            {
                this.gridViewMain.DataSource = this.dtMain;
                btnShowHide.Text = "Ẩn";
            }
            else
            {
                this.gridViewMain.DataSource = null;
                this.gridViewMain.Refresh();
                btnShowHide.Text = "Hiện";
            }
        }
    }
}