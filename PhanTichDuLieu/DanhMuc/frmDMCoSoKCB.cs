using System;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Threading.Tasks;
using System.Data;
using System.Data.OleDb;

namespace PhanTichDuLieu
{
    public partial class frmDMCoSoKCB : DevExpress.XtraEditors.XtraForm
    {

        private List<string> _FileNames = new List<string>();
        private List<string> _SafeFileNames = new List<string>();
        public frmDMCoSoKCB()
        {
            InitializeComponent();
        }
        private void frmDMCoSoKCB_Load(object sender, EventArgs e)
        {
            this.gridViewMain.OptionsBehavior.ReadOnly = true; //Chỉ đọc
            this.tbSTT.ReadOnly = true;
            this.btnLuu.Visible = false;
            khoiTaoDanhMuc();
        }

        public void khoiTaoDanhMuc()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                string query = "SELECT MaCSKCB as 'Mã CSKCB', TenCSKCB as 'Tên CSKCB' FROM DanhMucCoSoKCB";

                DataTable dt = DBUtils.GetDBTable(query, conn);
                DataColumn Col = dt.Columns.Add("STT");

                Col.SetOrdinal(0);
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    dt.Rows[i]["STT"] = i + 1;
                }

                this.gridControlMain.DataSource = dt;

                this.gridViewMain.Columns[0].BestFit();
                this.gridViewMain.Columns[1].BestFit();
                this.gridViewMain.Columns[2].Width = 800;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
        }

        private void gridControlMain_DoubleClick(object sender, EventArgs e)
        {
            hienThiDuLieuLenTextBox();
        }

        private void gridControlMain_Click(object sender, EventArgs e)
        {
            hienThiDuLieuLenTextBox();
        }

        private void hienThiDuLieuLenTextBox()
        {
            foreach (int i in gridViewMain.GetSelectedRows())
            {
                DataRow row = gridViewMain.GetDataRow(i);

                this.tbSTT.Text = row[0].ToString();
                this.tbMaCSKCB.Text = row[1].ToString();
                this.tbTenCSKCB.Text = row[2].ToString();
            }

            this.btnXoa.Visible = true;
            this.btnSua.Visible = true;
            this.btnLuu.Visible = false;
        }

        private void anTextBox()
        {
            this.tbMaCSKCB.ReadOnly = true;
            this.tbTenCSKCB.ReadOnly = true;
        }

        private void hienTextBox()
        {
            this.tbMaCSKCB.ReadOnly = false;
            this.tbTenCSKCB.ReadOnly = false;
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            this.hienTextBox();
            this.xoaTextBox();
            this.btnXoa.Visible = false;
            this.btnSua.Visible = false;
            this.btnLuu.Visible = true;
        }

        private void xoaTextBox()
        {
            this.tbSTT.Text = "";
            this.tbMaCSKCB.Text = "";
            this.tbTenCSKCB.Text = "";
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string MaCSKCB = this.tbMaCSKCB.Text;
            string TenCSKCB = this.tbTenCSKCB.Text;

            if (MaCSKCB != null && TenCSKCB != null)
            {
                string query = "DELETE FROM DanhMucCoSoKCB WHERE MaCSKCB = '" + MaCSKCB + "'";

                SqlConnection conn = DBUtils.GetDBConnection();
                conn.Open();
                try
                {
                    if (DBUtils.ExecuteNonQuery(query, conn) == 1)
                    {
                        MessageBox.Show("Xóa Điều Kiện " + MaCSKCB + " Thành Công");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.ToString());
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();

                }
            }
            this.xoaTextBox();
            khoiTaoDanhMuc();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string MaCSKCB = this.tbMaCSKCB.Text;
            string TenCSKCB = this.tbTenCSKCB.Text;

            MaCSKCB = MaCSKCB.Replace("'", "''");
            TenCSKCB = TenCSKCB.Replace("'", "''");

            if (MaCSKCB != null && TenCSKCB != null)
            {
                string query = "UPDATE DanhMucCoSoKCB SET MaCSKCB = N'" + MaCSKCB + "', TenCSKCB = N'" + TenCSKCB + "' WHERE MaCSKCB ='" + MaCSKCB + "'";

                SqlConnection conn = DBUtils.GetDBConnection();
                conn.Open();
                try
                {
                    if (DBUtils.ExecuteNonQuery(query, conn) == 1)
                    {
                        MessageBox.Show("Đã Sửa Điều Kiện " + MaCSKCB);
                    }
                    else
                    {
                        MessageBox.Show("Mã Điều Kiện Không Được Thay Đổi");
                    }
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.ToString());
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }
            }
            khoiTaoDanhMuc();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string MaCSKCB = this.tbMaCSKCB.Text;
            string TenCSKCB = this.tbTenCSKCB.Text;
            MaCSKCB = MaCSKCB.Replace("'", "''");
            TenCSKCB = TenCSKCB.Replace("'", "''");

            if (MaCSKCB != null && TenCSKCB != null)
            {
                if (!this.kiemTraCoMaCSKCB(MaCSKCB))
                {
                    string query = "INSERT INTO DanhMucCoSoKCB(MaCSKCB, TenCSKCB) VALUES(N'" + MaCSKCB + "', N'" + TenCSKCB + "')";

                    SqlConnection conn = DBUtils.GetDBConnection();
                    conn.Open();
                    try
                    {
                        if (DBUtils.ExecuteNonQuery(query, conn) == 1)
                        {
                            MessageBox.Show("Thêm Điều Kiện Thành Công");
                        }
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.ToString());
                    }
                    finally
                    {
                        conn.Close();
                        conn.Dispose();
                    }
                }
                else
                {
                    MessageBox.Show("Trùng Mã Điều Kiện");
                }
            }
            //anTextBox();
            khoiTaoDanhMuc();
            this.btnXoa.Visible = true;
            this.btnSua.Visible = true;
        }

        private bool kiemTraCoMaCSKCB(string _MaCSKCB)
        {

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                string query = "SELECT MaCSKCB FROM DanhMucCoSoKCB WHERE MaCSKCB = '" + _MaCSKCB + "'";
                DataTable dt = DBUtils.GetDBTable(query, conn);
                if (dt.Rows.Count > 0)
                    return true;
                else
                    return false;
            }
            catch (SqlException ex)
            {
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }
            return false;
        }

        private void btnImportCSKCB_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Excel File (*.xls, *.xlsx)|*.xls; *.xlsx|All Files (*.*)|*.*";

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                _FileNames.Clear();
                _SafeFileNames.Clear();
                _FileNames.Add(dlg.FileName);
                _SafeFileNames.Add(dlg.SafeFileName);
                MessageBox.Show("Chờ thông báo quá trình ghi dữ liệu!");
                themVaoCSDLCoSoKCB_BULKCOPY();
                khoiTaoDanhMuc();
            }

        }

        public void taoTable_dmCSKCB(string _tenTable)
        {
            string tenTable = _tenTable;

            string query = "CREATE TABLE " + tenTable
                + "(MACSKCB nvarchar(50), "
                + "TENCSKCB nvarchar(800));";

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                if (DBUtils.ExecuteNonQuery(query, conn) > 0)
                {
                    //MessageBox.Show("Tạo Table Thành Công");
                }
            }
            catch
            {
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

        }

        #region Function DM CSKCB
        private void themVaoCSDLCoSoKCB_BULKCOPY()
        {
            string _FileName = _FileNames[0];

            string tenTable = "DanhMucCoSoKCB";
            SqlConnection conn = DBUtils.GetDBConnection();

            conn.Open();
            string query = "DBCC DROPCLEANBUFFERS";
            DBUtils.ExecuteNonQuery(query, conn);
            query = "DBCC FREEPROCCACHE";
            DBUtils.ExecuteNonQuery(query, conn);

            //Xóa table nếu tồn tại
            query = "begin try drop table " + tenTable + " end try begin catch end catch";
            DBUtils.ExecuteNonQuery(query, conn);

            //Tạo table
            taoTable_dmCSKCB(tenTable);

            try
            {
                string constr = "";
                if (System.IO.Path.GetExtension(_FileName).ToUpper() == ".XLS")
                {
                    constr = string.Format(@"Provider=Microsoft.Jet.OLEDB.4.0;Data Source={0};Extended Properties=""Excel 8.0;IMEX=1;HDR=YES;""", _FileName);

                }
                else
                {
                    constr = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0;IMEX=1;HDR=YES;""", _FileName);
                }
                constr = string.Format(@"Provider=Microsoft.ACE.OLEDB.12.0;Data Source={0};Extended Properties=""Excel 12.0;IMEX=1;HDR=YES;""", _FileName);

                OleDbConnection Econ = new OleDbConnection(constr);
                string Query = string.Format("Select [MACSKCB], [TENCSKCB] FROM [{0}]", "Sheet1$");
                OleDbCommand Ecom = new OleDbCommand(Query, Econ);
                Econ.Open();

                DataSet ds = new DataSet();
                OleDbDataAdapter oda = new OleDbDataAdapter(Query, Econ);
                Econ.Close();
                oda.Fill(ds);
                DataTable Exceldt = ds.Tables[0];

                Exceldt.AcceptChanges();

                SqlBulkCopy objbulk = new SqlBulkCopy(conn);
                objbulk.DestinationTableName = tenTable;

                //Mapping Table column    
                objbulk.ColumnMappings.Add("[MACSKCB]", "MACSKCB");
                objbulk.ColumnMappings.Add("[TENCSKCB]", "TENCSKCB");

                objbulk.WriteToServer(Exceldt);
                MessageBox.Show("Ghi thành công danh mục Cơ sở Khám chữa bệnh!", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch
            {
                MessageBox.Show(string.Format("Dữ liệu không đúng định dạng!"), "Không Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        #endregion

    }
}