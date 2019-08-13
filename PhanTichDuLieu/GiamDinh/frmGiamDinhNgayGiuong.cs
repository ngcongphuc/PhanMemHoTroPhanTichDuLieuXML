using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraPrinting;
using System.Drawing;
using System.Collections.Generic;
using DevExpress.XtraGrid;

namespace PhanTichDuLieu
{
    public partial class frmGiamDinhNgayGiuong : DevExpress.XtraEditors.XtraForm
    {
        public CompositeLink complinkMain;
        public String[] maDieuKiens;
        public String[] tenDieuKiens;
        public String[] DieuKiens;
        public String[] soLuongSheets;
        public String[] soLuongMaDieuKienSheets;
        public int soluongLookupEdit;
        public DataTable dtBangDieuKien;
        public string tenCSKCB;
        public frmGiamDinhNgayGiuong()
        {

            InitializeComponent();
            soLuongSheets = new string[200];
            soLuongMaDieuKienSheets = new string[200];

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
                string query = "SELECT MaDieuKien as 'Mã Câu Truy Vấn', TenDieuKien as 'Tên Câu Truy Vấn', DieuKien as 'Câu Truy Vấn SQL' FROM DanhMucDieuKienNgayGiuongNangCao";
                DataTable dt = DBUtils.GetDBTable(query, conn);
                dtBangDieuKien = dt;
                soluongLookupEdit = dt.Rows.Count;
                DataRow row = dt.NewRow();
                row["Mã Câu Truy Vấn"] = "Tất cả điều kiện";
                row["Tên Câu Truy Vấn"] = "Tất cả điều kiện";
                row["Câu Truy Vấn SQL"] = "Tất cả điều kiện";

                dt.Rows.Add(row);

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


                //Lấy dmcskcb trong bảng
                string query = "SELECT MaCSKCB, TenCSKCB FROM DanhMucCoSoKCB";
                DataTable _dt_xml123 = DBUtils.GetDBTable(query, conn);
                for (int i = 0; i < _dt_xml123.Rows.Count; i++)
                {
                    _dm_xml123.Add("xml123_" + _dt_xml123.Rows[i][0].ToString());
                }

                //Lấy dmcskcb like xml123 trong csdl
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
        /*
        private void Link_CreateMarginalHeaderArea(object sender, CreateAreaEventArgs e)
        {
            TextBrick brick = e.Graph.DrawString("FILE EXCEL", System.Drawing.Color.DarkBlue, new RectangleF(0, 0, 500, 1200), BorderSide.None);
        }*/

        public int flag_i = 0;
        private void Link_CreateMarginalHeaderArea(object sender, CreateAreaEventArgs e)
        {
            TextBrick brick = e.Graph.DrawString(soLuongSheets[flag_i].ToUpper(), System.Drawing.Color.DarkBlue, new RectangleF(0, 0, 500, 2000), BorderSide.All);
            //TextBrick brick = e.Graph.DrawString(soLuongSheets[flag_i - 1], System.Drawing.Color.DarkBlue, new RectangleF(0, 0, 500, 1200), BorderSide.None);
            flag_i++;
        }

        private void xuatExcel_ToanBoCauLenh()
        {


            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "Excel file (*.xlsx)|*.xlsx";
            f.FileName = tenCSKCB + "_DichVuKyThuat_" + DateTime.Now.Second.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();

            if (f.ShowDialog() == DialogResult.OK)
            {
                //Rename Sheet
                complinkMain.PrintingSystem.XlSheetCreated += PrintingSystem_XlSheetCreated;
                complinkMain.CreatePageForEachLink();
                XlsxExportOptions options = new XlsxExportOptions();
                options.ExportMode = XlsxExportMode.SingleFilePageByPage;
                complinkMain.ExportToXlsx(f.FileName, options);
                flag_i = 0;

                MessageBox.Show("Xuất Excel Thành Công!");
            }
        }

        private void PrintingSystem_XlSheetCreated(object sender, XlSheetCreatedEventArgs e)
        {
            int caseSwitch = e.Index;
            e.SheetName = soLuongMaDieuKienSheets[caseSwitch].ToString();

        }


        private void Link_CreateMarginalHeaderArea_1(object sender, CreateAreaEventArgs e)
        {
            TextBrick brick = e.Graph.DrawString("...", System.Drawing.Color.DarkBlue, new RectangleF(0, 0, 500, 1200), BorderSide.None);
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
            f.FileName = tenCSKCB + "_DichVuKyThuat_" + ten_cautruyvan + "_" + DateTime.Now.Second.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();


            if (f.ShowDialog() == DialogResult.OK)
            {
                CompositeLink complink = new CompositeLink(new PrintingSystem());
                PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
                link.Component = this.gridControlKetQua;
                link.CreateMarginalHeaderArea += new CreateAreaEventHandler(Link_CreateMarginalHeaderArea_1);
                complink.Links.Add(link);


                //Rename Sheet
                complink.PrintingSystem.XlSheetCreated += PrintingSystem_XlSheetCreated_1;
                complink.CreatePageForEachLink();
                XlsxExportOptions options = new XlsxExportOptions();
                options.ExportMode = XlsxExportMode.SingleFilePageByPage;
                complink.ExportToXlsx(f.FileName, options);

                MessageBox.Show("Xuất Excel Thành Công!");
            }
        }

        private void PrintingSystem_XlSheetCreated_1(object sender, XlSheetCreatedEventArgs e)
        {
            //Đổi tên Sheet Excel
            if (e.Index == 0)
            {
                e.SheetName = "Tên Sheet";
            }
        }





        #endregion

        #region Xử Lý Button
        bool flag_excel = false;
        private void btnTruyVan_Click(object sender, EventArgs e)
        {
            tenCSKCB = "";
            complinkMain = new CompositeLink(new PrintingSystem());
            int soluongGridControl = soluongLookupEdit;
            int i_sl = 0;
            GridControl[] gridcontrolTemps = new GridControl[soluongGridControl + 1];
            PrintableComponentLink[] linkTemps = new PrintableComponentLink[soluongGridControl + 1];
            DataTable[] dt_Temps = new DataTable[soluongGridControl + 1];

            int soLuongSheet = 0;

            maDieuKiens = new string[soluongGridControl];
            tenDieuKiens = new string[soluongGridControl];
            DieuKiens = new string[soluongGridControl];


            if (this.lookUpEditCSKCB.EditValue.ToString() != "Tên CSKCB")
            {
                if (this.lookUpEditCSKCB.Text == "Tất cả CSKCB")
                {
                    flag_excel = false;
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
                            if (this.lookUpEditCauTruyVan.EditValue.ToString() != "Tất cả điều kiện")
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

                                DataTable dt_alllll = DBUtils.GetDBTable(temp, conn);
                                this.gridControlKetQua.DataSource = dt_alllll;
                            }
                            else
                                MessageBox.Show("Không được chọn tất cả các điều kiện!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
                else //Từng cơ sở khám chữa bệnh
                {

                    string _MaCSKCB = this.lookUpEditCSKCB.EditValue.ToString();

                    tenCSKCB = _MaCSKCB;
                    _MaCSKCB = "xml123_" + _MaCSKCB;
                    if (this.lookUpEditCauTruyVan.EditValue.ToString() != "Tất cả điều kiện")
                    {
                        flag_excel = false;
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
                    else //Chọn tất cả các câu truy vấn.
                    {
                        flag_excel = true;
                        /*
                         * ****************************************************
                         * ****************************************************
                         * ****************************************************
                         * ****************************************************
                         * ****************************************************
                         * ****************************************************
                         * ****************************************************
                         */

                        //MessageBox.Show(dtBangDieuKien.Rows.Count.ToString());


                        string DieuKien = "";
                        string query = "";
                        for (int j = 0; j < dtBangDieuKien.Rows.Count - 1; j++)
                        {
                            string _ngayBatDau = this.tbThoiGianBatDau.Text;
                            string _ngayKetThuc = this.tbThoiGianKetThuc.Text;
                            string _CauTruyVan = dtBangDieuKien.Rows[j][2].ToString();
                            _CauTruyVan = _CauTruyVan.Replace("_ngaybatdau_", _ngayBatDau);
                            _CauTruyVan = _CauTruyVan.Replace("_ngayketthuc_", _ngayKetThuc);
                            _CauTruyVan = _CauTruyVan.Replace("xml123", _MaCSKCB);

                            query = _CauTruyVan;
                            DieuKien = _CauTruyVan;

                            maDieuKiens[i_sl] = dtBangDieuKien.Rows[j][0].ToString();
                            tenDieuKiens[i_sl] = dtBangDieuKien.Rows[j][1].ToString();

                            //Gridv
                            SqlConnection conn = DBUtils.GetDBConnection();
                            conn.Open();
                            try
                            {
                                dt_Temps[i_sl] = DBUtils.GetDBTable(query, conn);
                                DataColumn Col = dt_Temps[i_sl].Columns.Add("STT");
                                Col.SetOrdinal(0);
                                for (int i = 0; i < dt_Temps[i_sl].Rows.Count; i++)
                                    dt_Temps[i_sl].Rows[i]["STT"] = i + 1;

                                //MessageBox.Show(dt_Temps[i_sl].Rows.Count.ToString());

                                if (dt_Temps[i_sl].Rows.Count > 0)
                                {
                                    gridcontrolTemps[i_sl] = new GridControl();
                                    gridcontrolTemps[i_sl].BindingContext = new System.Windows.Forms.BindingContext();
                                    gridcontrolTemps[i_sl].DataSource = dt_Temps[i_sl];

                                    Form frm = new Form();
                                    frm.Controls.Add(gridcontrolTemps[i_sl]);
                                    gridcontrolTemps[i_sl].ForceInitialize();

                                    linkTemps[i_sl] = new PrintableComponentLink(new PrintingSystem());
                                    linkTemps[i_sl].Component = gridcontrolTemps[i_sl];

                                    //Bảng đổi tên
                                    soLuongSheets[soLuongSheet] = tenDieuKiens[i_sl];
                                    soLuongMaDieuKienSheets[soLuongSheet] = maDieuKiens[i_sl];
                                    soLuongSheet++;
                                    linkTemps[i_sl].CreateMarginalHeaderArea += new CreateAreaEventHandler(Link_CreateMarginalHeaderArea);

                                    complinkMain.Links.Add(linkTemps[i_sl]);

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
                            //KẾT THÚC ĐIỀU KIỆN
                            i_sl++;
                        }

                        MessageBox.Show("Đã khởi tạo xong dữ liệu!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    }
                }
            }
            else
            {
                MessageBox.Show("Chưa chọn Cơ sở khám chữa bệnh!", "Thông báo!", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            if (!flag_excel)
            {

                this.xuatExcel();
            }
            else
            {
                this.xuatExcel_ToanBoCauLenh();
            }
        }
        #endregion

        /*
        public frmGiamDinhNgayGiuong()
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
                string query = "SELECT MaDieuKien as 'Mã Câu Truy Vấn', TenDieuKien as 'Tên Câu Truy Vấn', DieuKien as 'Câu Truy Vấn SQL' FROM DanhMucDieuKienNgayGiuongNangCao";
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
            f.FileName = "GiamDinh_NgayGiuong_" + ten_cautruyvan + "_" + DateTime.Now.Second.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();

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
            else
            {
                MessageBox.Show("Chưa chọn CSKCB");
            }
        }
        private void btnXuatExcel_Click(object sender, EventArgs e)
        {
            this.xuatExcel();
        }
        #endregion*/
    }
}