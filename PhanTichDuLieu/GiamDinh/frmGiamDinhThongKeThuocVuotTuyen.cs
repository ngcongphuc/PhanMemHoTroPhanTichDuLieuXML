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
    public partial class frmGiamDinhThongKeThuocVuotTuyen : DevExpress.XtraEditors.XtraForm
    {
        public frmGiamDinhThongKeThuocVuotTuyen()
        {
            InitializeComponent();

        }
        private void FormDVKTCoDieuKien_Load(object sender, EventArgs e)
        {
            khoiTaoCauTruyVan_lookUpEdit();
        }

        #region Khởi Tạo
        public void khoiTaoCauTruyVan_lookUpEdit()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                string query = "SELECT MaDieuKien as 'Mã Câu Truy Vấn', TenDieuKien as 'Tên Câu Truy Vấn', DieuKien as 'Câu Truy Vấn SQL' FROM dmQueryThuocVuotTuyen";
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
            f.FileName = "PhanTichThuocVuotTuyen_" + DateTime.Now.Second.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();

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

            if (this.lookUpEditCauTruyVan.EditValue.ToString() != "Tên Câu Truy Vấn")
            {
                //Code

                string _CauTruyVan = this.lookUpEditCauTruyVan.EditValue.ToString();

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
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            this.xuatExcel();
        }
        #endregion
    }
}