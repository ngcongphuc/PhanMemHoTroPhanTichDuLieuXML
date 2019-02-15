using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraPrinting;
using System.Drawing;
using System.Collections.Generic;

namespace PhanTichDuLieu
{
    public partial class frmGiamDinhChanDoanHinhAnh : DevExpress.XtraEditors.XtraForm
    {
        public frmGiamDinhChanDoanHinhAnh()
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
                string query = "SELECT MaDieuKien as 'Mã Câu Truy Vấn', TenDieuKien as 'Tên Câu Truy Vấn', DieuKien as 'Câu Truy Vấn SQL' FROM DanhMucDieuKienChanDoanHinhAnhNangCao";
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
                MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

            DataRow row = dt.NewRow();
            row["Mã CSKCB"] = "Tất cả CSKCB";
            row["Tên CSKCB"] = "Tất cả CSKCB";
            dt.Rows.Add(row);

            DataColumn Col = dt.Columns.Add("STT");

            Col.SetOrdinal(0);
            for (int i = 0; i < dt.Rows.Count; i++)
            {
                dt.Rows[i]["STT"] = i + 1;
            }

            this.lookUpEditCSKCB.Properties.DataSource = dt;
            this.lookUpEditCSKCB.Properties.DisplayMember = "Tên CSKCB";
            this.lookUpEditCSKCB.Properties.ValueMember = "Mã CSKCB";
            this.lookUpEditCSKCB.EditValue = "Tên CSKCB";
        }
        public void khoiTaoCoSoKCB_lookUpEdit()
        {
            khoiTaodmCSKCB();
        }
        #endregion

        #region Các Hàm Về Xuất Excel
        private void Link_CreateMarginalHeaderArea(object sender, CreateAreaEventArgs e)
        {
            TextBrick brick = e.Graph.DrawString("FILE EXCEL", System.Drawing.Color.DarkBlue, new RectangleF(0, 0, 500, 1200), BorderSide.None);
        }

        private void xuatExcel()
        {
            string ten_cautruyvan = "";
            if (this.lookUpEditCauTruyVan.EditValue.ToString() != "Tên Câu Truy Vấn")
            {
                ten_cautruyvan = this.lookUpEditCauTruyVan.Text.ToString();
            }

            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "Excel file (*.xlsx)|*.xlsx";
            f.FileName = "GiamDinh_ChanDoanHinhAnh_" + ten_cautruyvan + "_" + DateTime.Now.Second.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();

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
                e.SheetName = "Tên Sheet";
            }
        }
        #endregion

        #region Xử Lý Button
        private void btnTruyVan_Click(object sender, EventArgs e)
        {
            if (this.lookUpEditCSKCB.EditValue.ToString() != "Tên CSKCB")
            {
                if (this.lookUpEditCSKCB.Text == "Tất cả CSKCB")
                {
                    string query = "select table_name from information_schema.tables where table_name like '%xml123_%' and table_name not like 'xml123_dtdi'";


                    SqlConnection conn = DBUtils.GetDBConnection();
                    conn.Open();
                    try
                    {
                        DataTable _dt_schema_table = DBUtils.GetDBTable(query, conn);

                        if (_dt_schema_table.Rows.Count > 0)
                        {
                            string temp = "";
                            string temp_cautruyvan = "";
                            if (this.lookUpEditCauTruyVan.EditValue.ToString() != "Tên Câu Truy Vấn")
                            {
                                //Code
                                string _ngayBatDau = this.tbThoiGianBatDau.Text;
                                string _ngayKetThuc = this.tbThoiGianKetThuc.Text;
                                string _CauTruyVan = this.lookUpEditCauTruyVan.EditValue.ToString();
                                _CauTruyVan = _CauTruyVan.Replace("_ngaybatdau_", _ngayBatDau);
                                _CauTruyVan = _CauTruyVan.Replace("_ngayketthuc_", _ngayKetThuc);
                                temp_cautruyvan = _CauTruyVan;
                                temp = temp_cautruyvan.Replace("xml123", _dt_schema_table.Rows[0][0].ToString());

                                if (_dt_schema_table.Rows.Count > 1)
                                {
                                    for (int i = 1; i < _dt_schema_table.Rows.Count; i++)
                                    {
                                        temp_cautruyvan = _CauTruyVan;
                                        string _MaCSKCB = _dt_schema_table.Rows[i][0].ToString();
                                        temp = temp + " UNION ALL " + temp_cautruyvan.Replace("xml123", _MaCSKCB);
                                    }
                                }
                                //MessageBox.Show(temp);

                                DataTable dt = DBUtils.GetDBTable(temp, conn);
                                this.gridControlKetQua.DataSource = dt;
                            }
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
                    string _MaCSKCB = this.lookUpEditCSKCB.EditValue.ToString();
                    _MaCSKCB = "xml123_" + _MaCSKCB;
                    if (this.lookUpEditCauTruyVan.EditValue.ToString() != "Tên Câu Truy Vấn")
                    {
                        //Code
                        string _ngayBatDau = this.tbThoiGianBatDau.Text;
                        string _ngayKetThuc = this.tbThoiGianKetThuc.Text;
                        string _CauTruyVan = this.lookUpEditCauTruyVan.EditValue.ToString();
                        _CauTruyVan = _CauTruyVan.Replace("_ngaybatdau_", _ngayBatDau);
                        _CauTruyVan = _CauTruyVan.Replace("_ngayketthuc_", _ngayKetThuc);
                        _CauTruyVan = _CauTruyVan.Replace("xml123", _MaCSKCB);

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