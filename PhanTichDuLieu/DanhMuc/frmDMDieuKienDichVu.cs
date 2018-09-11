using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace PhanTichDuLieu
{
    public partial class frmDMDieuKienDichVu : DevExpress.XtraEditors.XtraForm
    {
        public frmDMDieuKienDichVu()
        {
            InitializeComponent();
        }

        private void FormDMDieuKienDichVu_Load(object sender, EventArgs e)
        {
            this.gridViewMain.OptionsBehavior.ReadOnly = true; //Chỉ đọc
            this.tbSTT.ReadOnly = true;
            this.btnLuu.Visible = false;
            khoiTaoDVKTCoDieuKien();
        }

        public void khoiTaoDVKTCoDieuKien()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                string query = "SELECT MaDieuKien as 'Mã Điều Kiện', TenDieuKien as 'Tên Điều Kiện', DieuKien as 'Điều Kiện' FROM DanhMucDieuKienDichVu";

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
                this.gridViewMain.Columns[3].Width = 800;
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
                this.tbMaDieuKien.Text = row[1].ToString();
                this.tbTenDieuKien.Text = row[2].ToString();
                this.tbDieuKien.Text = row[3].ToString();
            }

            this.btnXoa.Visible = true;
            this.btnSua.Visible = true;
            this.btnLuu.Visible = false;
        }

        private void anTextBox()
        {
            this.tbSTT.ReadOnly = true;
            this.tbMaDieuKien.ReadOnly = true;
            this.tbTenDieuKien.ReadOnly = true;
            this.tbDieuKien.ReadOnly = true;
        }

        private void hienTextBox()
        {
            this.tbSTT.ReadOnly = false;
            this.tbMaDieuKien.ReadOnly = false;
            this.tbTenDieuKien.ReadOnly = false;
            this.tbDieuKien.ReadOnly = false;
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
            this.tbMaDieuKien.Text = "";
            this.tbTenDieuKien.Text = "";
            this.tbDieuKien.Text = "";
        }
        private void btnXoa_Click(object sender, EventArgs e)
        {
            string maDieuKien = this.tbMaDieuKien.Text;
            string tenDieuKien = this.tbTenDieuKien.Text;
            string dieuKien = this.tbDieuKien.Text;

            if (maDieuKien != null && tenDieuKien != null && dieuKien != null)
            {
                string query = "DELETE FROM DanhMucDieuKienDichVu WHERE MaDieuKien = '" + maDieuKien + "'";

                SqlConnection conn = DBUtils.GetDBConnection();
                conn.Open();
                try
                {
                    if (DBUtils.ExecuteNonQuery(query, conn) == 1)
                    {
                        MessageBox.Show("Xóa Điều Kiện " + maDieuKien + " Thành Công");
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
            khoiTaoDVKTCoDieuKien();
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            string maDieuKien = this.tbMaDieuKien.Text;
            string tenDieuKien = this.tbTenDieuKien.Text;
            string dieuKien = this.tbDieuKien.Text;

            maDieuKien = maDieuKien.Replace("'", "''");
            tenDieuKien = tenDieuKien.Replace("'", "''");
            dieuKien = dieuKien.Replace("'", "''");

            if (maDieuKien != null && tenDieuKien != null && dieuKien != null)
            {
                string query = "UPDATE DanhMucDieuKienDichVu SET MaDieuKien = N'" + maDieuKien + "', TenDieuKien = N'" + tenDieuKien + "', DieuKien = N'" + dieuKien + "' WHERE MaDieuKien ='" + maDieuKien + "'";

                SqlConnection conn = DBUtils.GetDBConnection();
                conn.Open();
                try
                {
                    if (DBUtils.ExecuteNonQuery(query, conn) == 1)
                    {
                        MessageBox.Show("Đã Sửa Điều Kiện " + maDieuKien);
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
            khoiTaoDVKTCoDieuKien();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            string maDieuKien = this.tbMaDieuKien.Text;
            string tenDieuKien = this.tbTenDieuKien.Text;
            string dieuKien = this.tbDieuKien.Text.Trim().Replace("\n", " ");
            maDieuKien = maDieuKien.Replace("'", "''");
            tenDieuKien = tenDieuKien.Replace("'", "''");
            dieuKien = dieuKien.Replace("'", "''");

            if (maDieuKien != null && tenDieuKien != null && dieuKien != null)
            {
                if (!this.kiemTraCoMaDieuKien(maDieuKien))
                {
                    
                    string query = "INSERT INTO DanhMucDieuKienDichVu(MaDieuKien, TenDieuKien, DieuKien) VALUES(N'" + maDieuKien + "', N'" + tenDieuKien + "', N'" + dieuKien + "')";

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
            khoiTaoDVKTCoDieuKien();
            this.btnXoa.Visible = true;
            this.btnSua.Visible = true;
        }

        private bool kiemTraCoMaDieuKien(string _MaDieuKien)
        {
            
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                string query = "SELECT MaDieuKien FROM DanhMucDieuKienDichVu WHERE MaDieuKien = '" + _MaDieuKien + "'";
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
    }
}