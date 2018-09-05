using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using DevExpress.XtraPrintingLinks;
using DevExpress.XtraPrinting;
using System.Drawing;
using DevExpress.XtraGrid;
using System.Collections.Generic;

namespace PhanTichDuLieu
{
    public partial class frmThuocCoDieuKien : DevExpress.XtraEditors.XtraForm
    {
        public CompositeLink complinkMain;
        public String[] maDieuKiens;
        public String[] tenDieuKiens;
        public String[] DieuKiens;
        public String[] soLuongSheets;
        public String[] soLuongMaDieuKienSheets;
        public frmThuocCoDieuKien()
        {
            InitializeComponent();
            soLuongSheets = new string[200];
            soLuongMaDieuKienSheets = new string[200];
        }
        private void FormDVKTCoDieuKien_Load(object sender, EventArgs e)
        {
            //khoiTaoCoSoKCB_GridControl();
            khoiTaoKhoangThoiGianTruyVan();
            khoiTaoCoSoKCB_lookUpEdit();
            khoiTaoDVKTCoDieuKien();
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
        public void khoiTaoDVKTCoDieuKien()
        {
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                string query = "SELECT MaDieuKien as 'Mã Điều Kiện', TenDieuKien as 'Tên Điều Kiện', DieuKien as 'Điều Kiện' FROM DanhMucDieuKienThuoc";
                DataTable dt = DBUtils.GetDBTable(query, conn);
                this.gridControlDieuKien.DataSource = dt;
                this.gridViewDieuKien.Columns[2].Visible = false;
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

            this.lookUpEditCSKCB.Properties.DataSource = dt;
            this.lookUpEditCSKCB.Properties.DisplayMember = "Tên CSKCB";
            this.lookUpEditCSKCB.Properties.ValueMember = "Mã CSKCB";
            this.lookUpEditCSKCB.EditValue = "Tên CSKCB";
        }
        public void khoiTaoCoSoKCB_lookUpEdit()
        {
            khoiTaodmCSKCB();
            /*
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                string query = "SELECT MaCSKCB as 'Mã CSKCB', TenCSKCB as 'Tên CSKCB' FROM dmxml123";
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

            */
        }
        
        #endregion

        #region Hàm Truy Vấn Chính
        private void truyVanTheoCSKCBVoiCacDieuKien(string _MaCSKCB)
        {
            string MaCSKCB = _MaCSKCB;
            complinkMain = new CompositeLink(new PrintingSystem());

            int soluongGridControl = this.gridViewDieuKien.GetSelectedRows().Length;

            int i_sl = 0;
            GridControl[] gridcontrolTemps = new GridControl[soluongGridControl + 1];
            PrintableComponentLink[] linkTemps = new PrintableComponentLink[soluongGridControl + 1];
            DataTable[] dt_Temps = new DataTable[soluongGridControl + 1];

            maDieuKiens = new string[soluongGridControl];
            tenDieuKiens = new string[soluongGridControl];
            DieuKiens = new string[soluongGridControl];
            string _ngayBatDau = this.tbThoiGianBatDau.Text;
            string _ngayKetThuc = this.tbThoiGianKetThuc.Text;
            string _menhDeWhereKyQuyetToan = "KY_QT BETWEEN " + _ngayBatDau + " AND " + _ngayKetThuc;
            _menhDeWhereKyQuyetToan = " AND (" + _menhDeWhereKyQuyetToan + ")";


            string queryTongHopTatCaCacDieuKien = "";
            int soLuongSheet = 0;

            if (this.gridViewDieuKien.GetSelectedRows().Length > 0)
            {
                string DieuKien = "";

                //////////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////////
                //Query Tổng hợp tất cả các điều kiện 
                //SHEET 1 trong EXCEL xuất ra

                //Truy Vấn Theo GridControl
                /*foreach (int i in this.gridViewCSKCB.GetSelectedRows())
                {
                    
                    string MaCSKCB = this.gridViewCSKCB.GetDataRow(i)["Mã CSKCB"].ToString();
                }*/
                //Truy Vấn Theo Look Up Edit
                queryTongHopTatCaCacDieuKien = traVeChuoiCacDieuKienDuocChonTheoMaCSKCB(MaCSKCB);

                //string queryTemp = "SELECT HO_TEN as 'Họ tên',MA_THE as 'Mã thẻ',NGAY_SINH as 'Ngày sinh',(CASE WHEN GIOI_TINH = '1' THEN 'Nam' ELSE 'Nu' END) as 'Giới tính',MA_DKBD as 'Mã ĐKBĐ',NGAY_VAO as 'Ngày vào',NGAY_RA as 'Ngày ra',MA_BENH as 'Mã bệnh',MA_BENHKHAC as 'Mã bệnh khác',TEN_BENH as 'Tên bệnh',ma_cp as 'Mã CP',TEN_CP as 'Tên CP',SO_LUONG_BV as 'Số lượng',don_gia as 'Đơn giá', thanh_tien as 'Thành tiền',NGAY_YL as 'Ngày y lệnh'";
                string queryTemp = "SELECT HO_TEN as 'Họ tên',MA_THE as 'Mã thẻ',NGAY_SINH as 'Ngày sinh',(CASE WHEN GIOI_TINH = '1' THEN 'Nam' ELSE 'Nu' END) as 'Giới tính',MA_DKBD as 'Mã ĐKBĐ',NGAY_VAO as 'Ngày vào',NGAY_RA as 'Ngày ra',MA_BENH as 'Mã bệnh',MA_BENHKHAC as 'Mã bệnh khác',TEN_BENH as 'Tên bệnh'";
                for (int j = 0; j < maDieuKiens.Length; j++)
                {
                    //queryTemp = queryTemp + ", SUM(" + '"' + maDieuKiens[j] + '"' + ") as " + "'" + maDieuKiens[j] + "'";
                    queryTemp = queryTemp + ",( CASE WHEN SUM(" + '"' + maDieuKiens[j] + '"' + ") >= 1 THEN 'x' ELSE '' END) as " + "'" + maDieuKiens[j] + "'";

                    //(CASE WHEN GIOI_TINH = '1' THEN 'Nam' ELSE 'Nu' END) as 'Giới tính'

                }

                //queryTongHopTatCaCacDieuKien = queryTemp + " FROM " + "(" + queryTongHopTatCaCacDieuKien + ")" + " as test GROUP BY HO_TEN,MA_THE,NGAY_SINH,GIOI_TINH,MA_DKBD,NGAY_VAO,NGAY_RA,MA_BENH,MA_BENHKHAC,TEN_BENH,ma_cp,TEN_CP,SO_LUONG_BV,don_gia, thanh_tien,NGAY_YL";

                queryTongHopTatCaCacDieuKien = queryTemp + " FROM " + "(" + queryTongHopTatCaCacDieuKien + ")" + " as test GROUP BY HO_TEN,MA_THE,NGAY_SINH,GIOI_TINH,MA_DKBD,NGAY_VAO,NGAY_RA,MA_BENH,MA_BENHKHAC,TEN_BENH";

                SqlConnection conn = DBUtils.GetDBConnection();
                conn.Open();
                try
                {
                    dt_Temps[soluongGridControl] = DBUtils.GetDBTable(queryTongHopTatCaCacDieuKien, conn);
                    DataColumn Col = dt_Temps[soluongGridControl].Columns.Add("STT");
                    Col.SetOrdinal(0);
                    for (int i = 0; i < dt_Temps[soluongGridControl].Rows.Count; i++)
                        dt_Temps[soluongGridControl].Rows[i]["STT"] = i + 1;

                    if (dt_Temps[soluongGridControl].Rows.Count > 0)
                    {
                        gridcontrolTemps[soluongGridControl] = new GridControl();
                        gridcontrolTemps[soluongGridControl].BindingContext = new System.Windows.Forms.BindingContext();
                        gridcontrolTemps[soluongGridControl].DataSource = dt_Temps[soluongGridControl];

                        //Hiển thị gridcontrol
                        this.gridViewKetQua.Columns.Clear();
                        this.gridControlKetQua.DataSource = gridcontrolTemps[soluongGridControl].DataSource; ;
                        this.gridControlKetQua.Refresh();

                        Form frm = new Form();
                        frm.Controls.Add(gridcontrolTemps[soluongGridControl]);
                        gridcontrolTemps[soluongGridControl].ForceInitialize();



                        linkTemps[soluongGridControl] = new PrintableComponentLink(new PrintingSystem());
                        linkTemps[soluongGridControl].Component = gridcontrolTemps[soluongGridControl];
                        linkTemps[soluongGridControl].CreateMarginalHeaderArea += new CreateAreaEventHandler(Link_CreateMarginalHeaderArea);


                        complinkMain.Links.Add(linkTemps[soluongGridControl]);
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
                //////////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////////
                //////////////////////////////////////////////////////////////////////////////////////////////////////////



                /////////////////////////////////////////////
                string query = "";
                foreach (int j in this.gridViewDieuKien.GetSelectedRows())
                {
                    //BẮT ĐẦU ĐIỀU KIỆN
                    DieuKien = this.gridViewDieuKien.GetDataRow(j)["Điều Kiện"].ToString() + _menhDeWhereKyQuyetToan;

                    maDieuKiens[i_sl] = this.gridViewDieuKien.GetDataRow(j)["Mã Điều Kiện"].ToString();
                    tenDieuKiens[i_sl] = this.gridViewDieuKien.GetDataRow(j)["Tên Điều Kiện"].ToString();


                    /*Truy vấn theo nhiều Cơ sở khám chữa bệnh + Grid Control
                    query = "";
                    if (this.gridViewCSKCB.GetSelectedRows().Length > 0)
                    {
                        bool flag_MaCSKCB = true;
                        //MessageBox.Show("Sl CSKCB: " + this.gridViewCSKCB.GetSelectedRows().Length.ToString());
                        foreach (int i in this.gridViewCSKCB.GetSelectedRows())
                        {
                            string MaCSKCB = this.gridViewCSKCB.GetDataRow(i)["Mã CSKCB"].ToString();
                            //query = "(SELECT HO_TEN as 'Họ tên',MA_THE as 'Mã thẻ',NGAY_SINH as 'Ngày sinh',(CASE WHEN GIOI_TINH='1' THEN 'Nam' ELSE 'Nu' END) as 'Giới tính',MA_DKBD as 'Mã ĐKBĐ',NGAY_VAO as 'Ngày vào',NGAY_RA as 'Ngày ra',MA_BENH as 'Mã bệnh',MA_BENHKHAC as 'Mã bệnh khác',TEN_BENH as 'Tên bệnh',ma_cp as 'Mã CP',TEN_CP as 'Tên CP',SO_LUONG_BV as 'Số lượng',don_gia as 'Đơn giá', thanh_tien as 'Thành tiền',NGAY_YL as 'Ngày y lệnh' FROM xml123_" + MaCSKCB + " WHERE " + DieuKien + ")";
                            if (flag_MaCSKCB)
                            {
                                flag_MaCSKCB = false;
                                query = "(SELECT HO_TEN as 'Họ tên',MA_THE as 'Mã thẻ',NGAY_SINH as 'Ngày sinh',(CASE WHEN GIOI_TINH='1' THEN 'Nam' ELSE 'Nu' END) as 'Giới tính',MA_DKBD as 'Mã ĐKBĐ',NGAY_VAO as 'Ngày vào',NGAY_RA as 'Ngày ra',MA_BENH as 'Mã bệnh',MA_BENHKHAC as 'Mã bệnh khác',TEN_BENH as 'Tên bệnh',ma_cp as 'Mã CP',TEN_CP as 'Tên CP',SO_LUONG_BV as 'Số lượng',don_gia as 'Đơn giá', thanh_tien as 'Thành tiền',NGAY_YL as 'Ngày y lệnh' FROM xml123_" + MaCSKCB + " WHERE " + DieuKien + ")";

                            }
                            else
                            {
                                query = query + " UNION (SELECT HO_TEN as 'Họ tên',MA_THE as 'Mã thẻ',NGAY_SINH as 'Ngày sinh',(CASE WHEN GIOI_TINH='1' THEN 'Nam' ELSE 'Nu' END) as 'Giới tính',MA_DKBD as 'Mã ĐKBĐ',NGAY_VAO as 'Ngày vào',NGAY_RA as 'Ngày ra',MA_BENH as 'Mã bệnh',MA_BENHKHAC as 'Mã bệnh khác',TEN_BENH as 'Tên bệnh',ma_cp as 'Mã CP',TEN_CP as 'Tên CP',SO_LUONG_BV as 'Số lượng',don_gia as 'Đơn giá', thanh_tien as 'Thành tiền',NGAY_YL as 'Ngày y lệnh' FROM xml123_" + MaCSKCB + " WHERE " + DieuKien + ")";
                            }
                        }


                    }
                    else
                    {
                        MessageBox.Show("Chưa Chọn Cơ Sở KCB");
                    }
                    */////////////////////////////////////////////////////////////////////////////////////////////////

                    /*Truy vấn theo 1 Cơ sở khám chữa bệnh + Look Up Edit*/
                    query = "(SELECT HO_TEN as 'Họ tên',MA_THE as 'Mã thẻ',NGAY_SINH as 'Ngày sinh',(CASE WHEN GIOI_TINH='1' THEN 'Nam' ELSE 'Nu' END) as 'Giới tính',MA_DKBD as 'Mã ĐKBĐ',NGAY_VAO as 'Ngày vào',NGAY_RA as 'Ngày ra',MA_BENH as 'Mã bệnh',MA_BENHKHAC as 'Mã bệnh khác',TEN_BENH as 'Tên bệnh',ma_cp as 'Mã CP',TEN_CP as 'Tên CP',SO_LUONG_BV as 'Số lượng',don_gia as 'Đơn giá', thanh_tien as 'Thành tiền',NGAY_YL as 'Ngày y lệnh' FROM xml123_" + MaCSKCB + " WHERE " + DieuKien + ")";
                    //////////////////////////////////////////////////////////////////////////////////////////////////

                    //Gridv
                    conn = DBUtils.GetDBConnection();
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

            }//END
            MessageBox.Show("Truy vấn xong!");
        }


        private string traVeChuoiCacDieuKienDuocChonTheoMaCSKCB(string _MaCSKCB)
        {
            string giaTriTraVeChuoiCacDieuKienDuocChonTheoMaCSKCB = "";
            int soluongGridControl = this.gridViewDieuKien.GetSelectedRows().Length;
            maDieuKiens = new string[soluongGridControl];
            tenDieuKiens = new string[soluongGridControl];
            DieuKiens = new string[soluongGridControl];
            string MaCSKCB = _MaCSKCB;

            string _ngayBatDau = this.tbThoiGianBatDau.Text;
            string _ngayKetThuc = this.tbThoiGianKetThuc.Text;
            string _menhDeWhereKyQuyetToan = "KY_QT BETWEEN " + _ngayBatDau + " AND " + _ngayKetThuc;
            _menhDeWhereKyQuyetToan = " AND (" + _menhDeWhereKyQuyetToan + ")";

            //Khởi tạo mảng các giá trị Mã Điều Kiện, Điều Kiện, Tên Điều Kiện
            if (this.gridViewDieuKien.GetSelectedRows().Length > 0)
            {
                string DieuKien = "";
                int i_sl = 0;
                foreach (int j in this.gridViewDieuKien.GetSelectedRows())
                {

                    DieuKien = this.gridViewDieuKien.GetDataRow(j)["Điều Kiện"].ToString() + _menhDeWhereKyQuyetToan;
                    maDieuKiens[i_sl] = this.gridViewDieuKien.GetDataRow(j)["Mã Điều Kiện"].ToString();
                    tenDieuKiens[i_sl] = this.gridViewDieuKien.GetDataRow(j)["Tên Điều Kiện"].ToString();
                    DieuKiens[i_sl] = DieuKien;
                    i_sl++;
                }
            }


            bool flag_init = true;
            for (int i = 0; i < DieuKiens.Length; i++)
            {
                string chuoiCotDuocThemVaoBang = "";
                for (int j = 0; j < maDieuKiens.Length; j++)
                {
                    int stt = 1;
                    if (j == i)
                        stt = 1;
                    else
                        stt = 0;

                    if (j != (maDieuKiens.Length - 1))
                    {
                        chuoiCotDuocThemVaoBang += @"" + stt + "" + " as '" + maDieuKiens[j] + "', ";
                    }
                    else
                    {
                        chuoiCotDuocThemVaoBang += @"" + stt + "" + " as '" + maDieuKiens[j] + "' ";
                    }
                }

                //Nối các cột được thêm vào theo từng điều kiện
                if (flag_init) //Nếu là điều kiện đầu tiên
                {
                    flag_init = false;
                    giaTriTraVeChuoiCacDieuKienDuocChonTheoMaCSKCB = giaTriTraVeChuoiCacDieuKienDuocChonTheoMaCSKCB + "SELECT HO_TEN,MA_THE,NGAY_SINH,GIOI_TINH,MA_DKBD,NGAY_VAO,NGAY_RA,MA_BENH,MA_BENHKHAC,TEN_BENH,ma_cp,TEN_CP,SO_LUONG_BV,don_gia, thanh_tien,NGAY_YL, "
                                        + chuoiCotDuocThemVaoBang
                                        + "FROM xml123_" + MaCSKCB + " WHERE " + DieuKiens[i];

                }
                else //Điều kiện thứ 2 trở đi
                {
                    giaTriTraVeChuoiCacDieuKienDuocChonTheoMaCSKCB = giaTriTraVeChuoiCacDieuKienDuocChonTheoMaCSKCB + " UNION ALL SELECT HO_TEN,MA_THE,NGAY_SINH,GIOI_TINH,MA_DKBD,NGAY_VAO,NGAY_RA,MA_BENH,MA_BENHKHAC,TEN_BENH,ma_cp,TEN_CP,SO_LUONG_BV,don_gia, thanh_tien,NGAY_YL, "
                                        + chuoiCotDuocThemVaoBang
                                        + "FROM xml123_" + MaCSKCB + " WHERE " + DieuKiens[i];

                }
            }
            return giaTriTraVeChuoiCacDieuKienDuocChonTheoMaCSKCB;
        }
        #endregion

        #region Các Hàm Về Xuất Excel
        public int flag_i = 0;
        private void Link_CreateMarginalHeaderArea(object sender, CreateAreaEventArgs e)
        {
            if (flag_i == 0)
            {
                TextBrick brick = e.Graph.DrawString("TỔNG HỢP TẤT CẢ CÁC ĐIỀU KIỆN", System.Drawing.Color.DarkBlue, new RectangleF(0, 0, 500, 1200), BorderSide.None);
                flag_i++;

            }
            else
            {
                TextBrick brick = e.Graph.DrawString(soLuongSheets[flag_i - 1], System.Drawing.Color.DarkBlue, new RectangleF(0, 0, 500, 1200), BorderSide.None);
                //TextBrick brick = e.Graph.DrawString(soLuongSheets[flag_i - 1], System.Drawing.Color.DarkBlue, new RectangleF(0, 0, 500, 1200), BorderSide.None);
                flag_i++;
            }
        }

        private void xuatExcel()
        {
            SaveFileDialog f = new SaveFileDialog();
            f.Filter = "Excel file (*.xlsx)|*.xlsx";
            f.FileName = "Thuoc_" + DateTime.Now.Second.ToString() + DateTime.Now.Minute.ToString() + DateTime.Now.Hour.ToString() + DateTime.Now.Day.ToString() + DateTime.Now.Month.ToString() + DateTime.Now.Year.ToString();

            if (f.ShowDialog() == DialogResult.OK)
            {
                /*
                CompositeLink complink = new CompositeLink(new PrintingSystem());
                PrintableComponentLink link = new PrintableComponentLink(new PrintingSystem());
                link.Component = this.gridControlCSKCB;
                link.CreateMarginalHeaderArea += new CreateAreaEventHandler(Link_CreateMarginalHeaderArea);
                complink.Links.Add(link);
                */

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
            //Đổi tên Sheet Excel
            if (e.Index == 0)
            {
                e.SheetName = "TỔNG HỢP";
            }
            else
            {

                int caseSwitch = e.Index;
                e.SheetName = soLuongMaDieuKienSheets[caseSwitch - 1].ToString();
            }
        }
        #endregion

        #region Xử Lý Button
        private void btnTruyVan_Click(object sender, EventArgs e)
        {
            if (this.lookUpEditCSKCB.EditValue.ToString() != "Tên CSKCB")
            {

                string _MaCSKCB = this.lookUpEditCSKCB.EditValue.ToString();
                truyVanTheoCSKCBVoiCacDieuKien(_MaCSKCB);
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