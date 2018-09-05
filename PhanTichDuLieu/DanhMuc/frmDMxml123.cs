using System;
using System.Collections.Generic;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PhanTichDuLieu
{
    public partial class frmDMxml123 : DevExpress.XtraEditors.XtraForm
    {
        public frmDMxml123()
        {

            InitializeComponent();
            khoiTaodmCSKCB();
        }

        public void khoiTaodmCSKCB()
        {
            DataTable dt = new DataTable();
            DataColumn Col1 = dt.Columns.Add("Mã CSKCB");
            DataColumn Col2 = dt.Columns.Add("Tên CSKCB");
            Col1.SetOrdinal(0);
            Col2.SetOrdinal(1);

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                /*Thêm giá trị mới
                dt.Rows.Add(new Object[]{
                "giá trị 1",
                "giá trị 2"
                });
                */

                List<string> _dm_xml123 = new List<string>();
                List<string> _dm_schema_table = new List<string>();


                string query = "SELECT MaCSKCB, TenCSKCB FROM DanhMucCoSoKCB";
                DataTable _dt_xml123 = DBUtils.GetDBTable(query, conn);
                for (int i = 0; i < _dt_xml123.Rows.Count; i++)
                {
                    _dm_xml123.Add("xml123_" + _dt_xml123.Rows[i][0].ToString());
                }


                query = "select table_name from information_schema.tables where table_name like '%xml123_%'";
                DataTable _dt_schema_table = DBUtils.GetDBTable(query, conn);
                for (int i = 0; i < _dt_schema_table.Rows.Count; i++)
                {
                    _dm_schema_table.Add(_dt_schema_table.Rows[i][0].ToString());
                }


                for (int i = 0; i < _dm_schema_table.Count; i++)
                {
                    for (int j = 0; j < _dm_xml123.Count; j++)
                    {
                        if (_dm_schema_table[i].ToString().Trim() == _dm_xml123[j].ToString().Trim())
                        {
                            //Thêm giá trị dòng mới
                            dt.Rows.Add(new Object[]{
                                                    _dt_xml123.Rows[j][0].ToString(),
                                                    _dt_xml123.Rows[j][1].ToString()
                                                    });
                        }
                    }
                }

            }
            catch (SqlException ex)
            {
                //MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

            DataColumn Col = dt.Columns.Add("STT");

            Col.SetOrdinal(0);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["STT"] = i + 1;
            }

            this.gridControlMain.DataSource = dt;
            this.gridViewMain.Columns[0].BestFit();
            this.gridViewMain.Columns[1].BestFit();
            this.gridViewMain.Columns[2].BestFit();
        }

        public void khoiTaodmCSKCB2()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                string query = "SELECT MaCSKCB as 'Mã CSKCB', TenCSKCB as 'Tên CSKCB' FROM dmxml123";

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
                this.gridViewMain.Columns[2].BestFit();
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

                this.lbSTT.Text = row[0].ToString();
                this.lbMaCSKCB.Text = row[1].ToString();
                this.lbTenCSKCB.Text = row[2].ToString();
            }
        }
        
        
        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (this.lbMaCSKCB.Text != null && this.lbTenCSKCB.Text != null)
            {
                string maCSKCB = this.lbMaCSKCB.Text;
                string tenCSKCB = this.lbTenCSKCB.Text;

                SqlConnection conn = DBUtils.GetDBConnection();
                conn.Open();
                try
                {
                    //Xóa dòng trong bảng dmxml123
                    //DBUtils.ExecuteNonQuery(query, conn);
                    //Xóa luôn table xml123_maCSKCB

                    string tenBangCanXoa = "xml123_" + maCSKCB;
                    string query = "DROP TABLE " + tenBangCanXoa;
                    DBUtils.ExecuteNonQuery(query, conn);

                    MessageBox.Show("Xóa CSKCB " + maCSKCB + " Thành Công");

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
                MessageBox.Show("Chưa Chọn Dữ Liệu Cần Xóa!");
            }
            khoiTaodmCSKCB();

            this.lbSTT.Text = "";
            this.lbMaCSKCB.Text = "";
            this.lbTenCSKCB.Text = "";
        }

        private void frmDMxml123_Load(object sender, EventArgs e)
        {
            this.lbSTT.Text = "";
            this.lbMaCSKCB.Text = "";
            this.lbTenCSKCB.Text = "";
        }
    }
}