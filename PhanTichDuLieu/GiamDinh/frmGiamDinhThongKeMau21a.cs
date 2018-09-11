using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraPrinting;
using System.Drawing;

/*
 * MA_CSKCB: _MaCSKCB_
 */

namespace PhanTichDuLieu
{
    public partial class frmGiamDinhThongKeMau21a : DevExpress.XtraEditors.XtraForm
    {
        public frmGiamDinhThongKeMau21a()
        {
            InitializeComponent();

        }
        private void FormDVKTCoDieuKien_Load(object sender, EventArgs e)
        {
            khoiTaoCoSoKCB_lookUpEdit();
            khoiTaoCauTruyVan_lookUpEdit();
            khoiTaoKhoangThoiGianTruyVan();
        }

        #region Khởi Tạo
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
        public void khoiTaoCauTruyVan_lookUpEdit()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                string query = "SELECT MaDieuKien as 'Mã Câu Truy Vấn', TenDieuKien as 'Tên Câu Truy Vấn', DieuKien as 'Câu Truy Vấn SQL' FROM dmQueryMau21a";
                DataTable dt = DBUtils.GetDBTable(query, conn);

                this.lookUpEditCauTruyVan.Properties.DataSource = dt;
                this.lookUpEditCauTruyVan.Properties.DisplayMember = "Tên Câu Truy Vấn";
                this.lookUpEditCauTruyVan.Properties.ValueMember = "Câu Truy Vấn SQL";
                this.lookUpEditCauTruyVan.EditValue = "Tên Câu Truy Vấn";
                this.lookUpEditCauTruyVan.Properties.PopulateColumns();
                this.lookUpEditCauTruyVan.Properties.Columns[2].Visible = false;
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

        private void lookUpEditCSKCB_EditValueChanged(object sender, EventArgs e)
        {
            if (this.lookUpEditCSKCB.ContainsFocus)
            {

            }
        }
        
        public void khoiTaoCoSoKCB_lookUpEdit()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                string query = "SELECT MaCSKCB as 'Mã CSKCB', TenCSKCB as 'Tên CSKCB' FROM DanhMucCoSoKCB";
                DataTable dt = DBUtils.GetDBTable(query, conn);

                this.lookUpEditCSKCB.Properties.DataSource = dt;
                this.lookUpEditCSKCB.Properties.DisplayMember = "Tên CSKCB";
                this.lookUpEditCSKCB.Properties.ValueMember = "Mã CSKCB";
                this.lookUpEditCSKCB.EditValue = "Tên CSKCB";
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
        #endregion

        #region Các Hàm Về Xuất Excel
        private void Link_CreateMarginalHeaderArea(object sender, CreateAreaEventArgs e)
        {
            TextBrick brick = e.Graph.DrawString("FILE EXCEL", System.Drawing.Color.DarkBlue, new RectangleF(0, 0, 500, 1200), BorderSide.None);
        }

        private void xuatExcel()
        {
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "Excel file (*.xlsx)|*.xlsx";
            f.FileName = "PhanTichMau21a_" + DateTime.Now.Second.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();

            if (f.ShowDialog() == DialogResult.OK)
            {
                CompositeLink complink = new CompositeLink(new PrintingSystem());
                PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
                link.Component = this.gridControlKetQua;
                link.CreateMarginalHeaderArea += new CreateAreaEventHandler(Link_CreateMarginalHeaderArea);
                complink.Links.Add(link);


                //Rename Sheet
                complink.PrintingSystem.XlSheetCreated += PrintingSystem_XlSheetCreated;
                complink.CreatePageForEachLink();
                XlsxExportOptions options = new XlsxExportOptions();
                options.ExportMode = XlsxExportMode.SingleFilePageByPage;
                complink.ExportToXlsx(f.FileName, options);

                MessageBox.Show("Xuất Excel Thành Công!");
            }
        }

        private void PrintingSystem_XlSheetCreated(object sender, XlSheetCreatedEventArgs e)
        {
            //Đổi tên Sheet Excel
            if (e.Index == 0)
            {
                e.SheetName = "Sheet";
            }
        }
        #endregion

        #region Xử Lý Button
        private void btnTruyVan_Click(object sender, EventArgs e)
        {
            if (this.lookUpEditCSKCB.EditValue.ToString() != "Tên CSKCB")
            {

                string _MaCSKCB = this.lookUpEditCSKCB.EditValue.ToString();

                if (this.lookUpEditCauTruyVan.EditValue.ToString() != "Tên Câu Truy Vấn")
                {
                    //Code
                    string _ngayBatDau = this.tbThoiGianBatDau.Text;
                    string _ngayKetThuc = this.tbThoiGianKetThuc.Text;
                    string _CauTruyVan = this.lookUpEditCauTruyVan.EditValue.ToString();
                    _CauTruyVan = _CauTruyVan.Replace("_ngaybatdau_", _ngayBatDau);
                    _CauTruyVan = _CauTruyVan.Replace("_ngayketthuc_", _ngayKetThuc);
                    _CauTruyVan = _CauTruyVan.Replace("_MaCSKCB_", _MaCSKCB);

                    SqlConnection conn = DBUtils.GetDBConnection();
                    conn.Open();
                    try
                    {
                        DataTable dt = DBUtils.GetDBTable(_CauTruyVan, conn);
                        this.gridControlKetQua.DataSource = dt;

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
                    MessageBox.Show("Chưa chọn câu truy vấn");
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn CSKCB");
            }
        }
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            this.xuatExcel();
        }
        #endregion
    }
}