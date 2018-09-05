using System;
using System.Data.SQLite;
using System.Data;

namespace PhanTichDuLieu
{
    public partial class frmDanhMucCoSoKCB : DevExpress.XtraEditors.XtraForm
    {
        SQLiteConnection _con = new SQLiteConnection();
        public void createConection()
        {
            string _strConnect = "Data Source=DataConfig/CoSoKCB.db";
            _con.ConnectionString = _strConnect;
            _con.Open();
        }

        
        public void closeConnection()
        {
            _con.Close();
        }
        public frmDanhMucCoSoKCB()
        {
            InitializeComponent();
            this.gbMain.Text = "";
            this.tbID.ReadOnly = true;

            //loadDataToGrid();
        }

        public void createTable()
        {
            string sql = "CREATE TABLE IF NOT EXISTS tbl_cosoKCB (ID INTEGER NOT NULL PRIMARY KEY AUTOINCREMENT, MaCSKCB nvarchar(10), TenCSKCB nvarchar(200))";
            SQLiteConnection.CreateFile("DataConfig/CoSoKCB.db");
            createConection();
            SQLiteCommand command = new SQLiteCommand(sql, _con);
            command.ExecuteNonQuery();
            closeConnection();
        }
        public DataSet loadData()
        {
            DataSet ds = new DataSet();
            createConection();
            SQLiteDataAdapter da = new SQLiteDataAdapter("select ID, MaCSKCB as [Mã CSKCB], TenCSKCB as [Tên CSKCB] from tbl_cosoKCB", _con);

            da.Fill(ds);
            closeConnection();
            return ds;
        }
        
        public void loadDataToGrid()
        {
            DataSet ds = loadData();
            this.gridViewMain.DataSource = ds.Tables[0];

            this.tbID.DataBindings.Clear();
            this.tbMaCSKCB.DataBindings.Clear();
            this.tbTenCSKCB.DataBindings.Clear();


            this.tbID.DataBindings.Add("text", ds.Tables[0], "ID");
            this.tbMaCSKCB.DataBindings.Add("text", ds.Tables[0], "Mã CSKCB");
            this.tbTenCSKCB.DataBindings.Add("text", ds.Tables[0], "Tên CSKCB");
            this.gridViewMain.Refresh();

            this.gridViewMain.Columns[0].Width = 40;
            this.gridViewMain.Columns[1].Width = 100;
            this.gridViewMain.Columns[2].AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.gridViewMain.ReadOnly = true;


        }

        private void btnThemMoi_Click(object sender, EventArgs e)
        {
            this.tbID.Text = "";
            this.tbMaCSKCB.Text = "";
            this.tbTenCSKCB.Text = "";
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maCSKCB = this.tbMaCSKCB.Text;
            string tenCSKCB = this.tbTenCSKCB.Text;

            string strInsert = string.Format("INSERT INTO tbl_cosoKCB(MaCSKCB, TenCSKCB) VALUES('{0}','{1}')", maCSKCB, tenCSKCB);

            createConection();
            SQLiteCommand cmd = new SQLiteCommand(strInsert, _con);
            cmd.ExecuteNonQuery();
            closeConnection();
            
            loadDataToGrid();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {
            string id = this.tbID.Text;
            string maCSKCB = this.tbMaCSKCB.Text;
            string tenCSKCB = this.tbTenCSKCB.Text;

            string strInsert = string.Format("UPDATE tbl_cosoKCB set MaCSKCB='{0}', TenCSKCB='{1}' WHERE ID='{2}'", maCSKCB, tenCSKCB, id);

            createConection();
            SQLiteCommand cmd = new SQLiteCommand(strInsert, _con);
            cmd.ExecuteNonQuery();
            closeConnection();

            loadDataToGrid();
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            string id = this.tbID.Text;

            string strInsert = string.Format("DELETE FROM tbl_cosoKCB where ID='{0}'", id);

            createConection();
            SQLiteCommand cmd = new SQLiteCommand(strInsert, _con);
            cmd.ExecuteNonQuery();
            closeConnection();

            loadDataToGrid();
        }
    }
}