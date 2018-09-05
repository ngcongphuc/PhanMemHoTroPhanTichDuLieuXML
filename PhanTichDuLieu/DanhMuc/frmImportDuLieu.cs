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
    public partial class frmImportDuLieu : DevExpress.XtraEditors.XtraForm
    {

        private List<string> _FileNames = new List<string>();
        private List<string> _SafeFileNames = new List<string>();
        public frmImportDuLieu()
        {
            InitializeComponent();
            khoiTaoKhoangThoiGianTruyVan();
        }

        private void frmImportDuLieu_Load(object sender, EventArgs e)
        {
            this.lbLuuY.Text = "Dữ liệu đưa vào phải đúng định dạng";
        }

        #region Khởi tạo Database
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
        public void taoTable_xml123(string maCSKCB)
        {
            string tenProcedure = "Insert_xml123_" + maCSKCB;
            string tenTable = "xml123_" + maCSKCB;
            string tenType = "udt_xml123_" + maCSKCB;

            string query = "";

            query = "CREATE TABLE " + tenTable + "(ID nvarchar(MAX),XML1_ID nvarchar(MAX),Ky_QT nvarchar(MAX),CoSoKCB_ID nvarchar(MAX),Ma_CSKCB nvarchar(MAX),"
             + "Ma_LK nvarchar(MAX),MA_BN nvarchar(MAX),Ho_Ten nvarchar(MAX),Ngay_Sinh nvarchar(MAX),Gioi_Tinh nvarchar(MAX),Ma_The nvarchar(MAX),Ma_DKBD nvarchar(MAX),"
             + "GT_The_Tu nvarchar(MAX),GT_The_Den nvarchar(MAX),Mien_Cung_CT nvarchar(MAX),Ngay_Vao nvarchar(MAX),Ngay_Ra nvarchar(MAX),So_Ngay_DTri nvarchar(MAX),Ma_LyDo_VVien nvarchar(MAX),Ma_Benh nvarchar(MAX),Ma_BenhKhac nvarchar(MAX),Muc_Huong_XML1 nvarchar(MAX),T_TongChi numeric,T_BNTT numeric,T_BHTT numeric,T_BNCCT numeric,"
             + "T_XN numeric,T_CDHA numeric, T_Thuoc numeric,T_Mau numeric,T_TTPT numeric,T_VTYT numeric,T_DVKT_TyLe numeric,T_Thuoc_TyLe numeric,T_VTYT_TyLe numeric,"
             + "T_Kham numeric,T_Giuong numeric,T_VChuyen numeric,T_NgoaiDS numeric,T_NguonKhac numeric,Ma_Loai_KCB nvarchar(MAX),ID_CP nvarchar(MAX),Loai_CP nvarchar(MAX),Ma_CP nvarchar(MAX),"
             + "Ma_Vat_Tu nvarchar(MAX),Ma_Nhom nvarchar(MAX),Ten_CP nvarchar(MAX),DVT nvarchar(MAX),So_Dang_Ky nvarchar(MAX),Ham_Luong nvarchar(MAX),Duong_Dung nvarchar(MAX),So_Luong nvarchar(MAX),"
             + "So_Luong_BV nvarchar(MAX),Don_Gia nvarchar(MAX),Don_Gia_BV nvarchar(MAX),Thanh_Tien nvarchar(MAX),TyLe_TT nvarchar(MAX),Ngay_YL nvarchar(MAX),"
             + "Ngay_KQ nvarchar(MAX),T_NguonKhac_DTL nvarchar(MAX),T_BNTT_DTL numeric"
             + "T_BHTT_DTL numeric,T_BNCCT_DTL numeric,T_NgoaiDS_DTL numeric,Muc_Huong_DTL nvarchar(MAX),TT_Thau numeric,Pham_Vi nvarchar(MAX),Ma_Giuong nvarchar(MAX),"
             + "T_TranTT numeric,Goi_VTYT nvarchar(MAX),Ten_Vat_Tu nvarchar(MAX),"
             + "Ten_Khoa nvarchar(MAX),Ma_Khoa nvarchar(MAX),Ma_Khoa_XML1 nvarchar(MAX),Ten_Khoa_XML1 nvarchar(MAX),Ten_Benh nvarchar(MAX),Ma_Bac_Si nvarchar(MAX),Ma_Tinh nvarchar(MAX),Ma_Tinh_The nvarchar(MAX), Ma_Cha nvarchar(200))";

            query = "CREATE TABLE " + tenTable + "(ID nvarchar(MAX),XML1_ID nvarchar(MAX),Ky_QT nvarchar(MAX),CoSoKCB_ID nvarchar(MAX),Ma_CSKCB nvarchar(MAX),"
             + "Ma_LK nvarchar(MAX),MA_BN nvarchar(MAX),Ho_Ten nvarchar(MAX),Ngay_Sinh nvarchar(MAX),Gioi_Tinh nvarchar(MAX),Ma_The nvarchar(MAX),Ma_DKBD nvarchar(MAX),"
             + "GT_The_Tu nvarchar(MAX),GT_The_Den nvarchar(MAX),Mien_Cung_CT nvarchar(MAX),Ngay_Vao nvarchar(MAX),Ngay_Ra nvarchar(MAX),So_Ngay_DTri nvarchar(MAX),Ma_LyDo_VVien nvarchar(MAX),Ma_Benh nvarchar(MAX),Ma_BenhKhac nvarchar(MAX),Muc_Huong_XML1 nvarchar(MAX),T_TongChi numeric(18,0),T_BNTT numeric(18,0),T_BHTT numeric(18,0),T_BNCCT numeric(18,0),"
             + "T_XN numeric(18,0),T_CDHA numeric(18,0), T_Thuoc numeric(18,0),T_Mau numeric(18,0),T_TTPT numeric(18,0),T_VTYT numeric(18,0),T_DVKT_TyLe numeric(18,0),T_Thuoc_TyLe numeric(18,0),T_VTYT_TyLe numeric(18,0),"
             + "T_Kham numeric(18,0),T_Giuong numeric(18,0),T_VChuyen numeric(18,0),T_NgoaiDS numeric(18,0),T_NguonKhac numeric(18,0),Ma_Loai_KCB nvarchar(MAX),ID_CP nvarchar(MAX),Loai_CP nvarchar(MAX),Ma_CP nvarchar(MAX),"
             + "Ma_Vat_Tu nvarchar(MAX),Ma_Nhom nvarchar(MAX),Ten_CP nvarchar(MAX),DVT nvarchar(MAX),So_Dang_Ky nvarchar(MAX),Ham_Luong nvarchar(MAX),Duong_Dung nvarchar(MAX),So_Luong nvarchar(MAX),"
             + "So_Luong_BV nvarchar(MAX),Don_Gia nvarchar(MAX),Don_Gia_BV nvarchar(MAX),Thanh_Tien nvarchar(MAX),TyLe_TT nvarchar(MAX),Ngay_YL nvarchar(MAX),"
             + "Ngay_KQ nvarchar(MAX),T_NguonKhac_DTL numeric(18,0),T_BNTT_DTL numeric(18,0),"
             + "T_BHTT_DTL numeric(18,0),T_BNCCT_DTL numeric(18,0),T_NgoaiDS_DTL numeric(18,0),Muc_Huong_DTL nvarchar(MAX),TT_Thau nvarchar(MAX),Pham_Vi nvarchar(MAX),Ma_Giuong nvarchar(MAX),"
             + "T_TranTT numeric(18,0),Goi_VTYT nvarchar(MAX),Ten_Vat_Tu nvarchar(MAX),"
             + "Ten_Khoa nvarchar(MAX),Ma_Khoa nvarchar(MAX),Ma_Khoa_XML1 nvarchar(MAX),Ten_Khoa_XML1 nvarchar(MAX),Ten_Benh nvarchar(MAX),Ma_Bac_Si nvarchar(MAX),Ma_Tinh nvarchar(MAX),Ma_Tinh_The nvarchar(MAX), Ma_Cha nvarchar(200))";

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                if (DBUtils.ExecuteNonQuery(query, conn) > 0)
                {
                    //MessageBox.Show("Tạo Table Thành Công");
                }
            }
            catch (SqlException ex)
            {
                // MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

        }

        public void taoTable_xml123_dtdi(string _tenTable)
        {
            string tenTable = _tenTable;
            string query = "";

            query = "CREATE TABLE " + tenTable + "(ID nvarchar(MAX),XML1_ID nvarchar(MAX),Ky_QT nvarchar(MAX),CoSoKCB_ID nvarchar(MAX),Ma_CSKCB nvarchar(MAX),"
             + "Ma_LK nvarchar(MAX),MA_BN nvarchar(MAX),Ho_Ten nvarchar(MAX),Ngay_Sinh nvarchar(MAX),Gioi_Tinh nvarchar(MAX),Ma_The nvarchar(MAX),Ma_DKBD nvarchar(MAX),"
             + "GT_The_Tu nvarchar(MAX),GT_The_Den nvarchar(MAX),Mien_Cung_CT nvarchar(MAX),Ngay_Vao nvarchar(MAX),Ngay_Ra nvarchar(MAX),So_Ngay_DTri nvarchar(MAX),Ma_LyDo_VVien nvarchar(MAX),Ma_Benh nvarchar(MAX),Ma_BenhKhac nvarchar(MAX),Muc_Huong_XML1 nvarchar(MAX),T_TongChi numeric(18,0),T_BNTT numeric(18,0),T_BHTT numeric(18,0),T_BNCCT numeric(18,0),"
             + "T_XN numeric(18,0),T_CDHA numeric(18,0), T_Thuoc numeric(18,0),T_Mau numeric(18,0),T_TTPT numeric(18,0),T_VTYT numeric(18,0),T_DVKT_TyLe numeric(18,0),T_Thuoc_TyLe numeric(18,0),T_VTYT_TyLe numeric(18,0),"
             + "T_Kham numeric(18,0),T_Giuong numeric(18,0),T_VChuyen numeric(18,0),T_NgoaiDS numeric(18,0),T_NguonKhac numeric(18,0),Ma_Loai_KCB nvarchar(MAX),ID_CP nvarchar(MAX),Loai_CP nvarchar(MAX),Ma_CP nvarchar(MAX),"
             + "Ma_Vat_Tu nvarchar(MAX),Ma_Nhom nvarchar(MAX),Ten_CP nvarchar(MAX),DVT nvarchar(MAX),So_Dang_Ky nvarchar(MAX),Ham_Luong nvarchar(MAX),Duong_Dung nvarchar(MAX),So_Luong nvarchar(MAX),"
             + "So_Luong_BV nvarchar(MAX),Don_Gia nvarchar(MAX),Don_Gia_BV nvarchar(MAX),Thanh_Tien nvarchar(MAX),TyLe_TT nvarchar(MAX),Ngay_YL nvarchar(MAX),"
             + "Ngay_KQ nvarchar(MAX),T_NguonKhac_DTL numeric(18,0),T_BNTT_DTL numeric(18,0),"
             + "T_BHTT_DTL numeric(18,0),T_BNCCT_DTL numeric(18,0),T_NgoaiDS_DTL numeric(18,0),Muc_Huong_DTL nvarchar(MAX),TT_Thau nvarchar(MAX),Pham_Vi nvarchar(MAX),Ma_Giuong nvarchar(MAX),"
             + "T_TranTT numeric(18,0),Goi_VTYT nvarchar(MAX),Ten_Vat_Tu nvarchar(MAX),"
             + "Ten_Khoa nvarchar(MAX),Ma_Khoa nvarchar(MAX),Ma_Khoa_XML1 nvarchar(MAX),Ten_Khoa_XML1 nvarchar(MAX),Ten_Benh nvarchar(MAX),Ma_Bac_Si nvarchar(MAX),Ma_Tinh_KCB nvarchar(MAX), Ma_Tinh nvarchar(200))";

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                if (DBUtils.ExecuteNonQuery(query, conn) > 0)
                {
                    //MessageBox.Show("Tạo Table Thành Công");
                }
            }
            catch (SqlException ex)
            {
                // MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

        }
        public void taoTable_xml123_2(string maCSKCB)
        {
            string tenTable = "xml123_" + maCSKCB;

            string query = "";

            query = "CREATE TABLE " + tenTable + "(ID numeric(18,0),XML1_ID numeric(18,0),Ky_QT numeric(10,0),CoSoKCB_ID numeric(18,0),Ma_CSKCB nvarchar(10),"
             + "Ma_LK nvarchar(100),MA_BN nvarchar(100),Ho_Ten nvarchar(1000),Ngay_Sinh nvarchar(15),Gioi_Tinh nvarchar(2),Ma_The nvarchar(20),Ma_DKBD nvarchar(10),"
             + "GT_The_Tu nvarchar(25),GT_The_Den nvarchar(25),Mien_Cung_CT numeric(18,2),Ngay_Vao nvarchar(25),Ngay_Ra nvarchar(25),So_Ngay_DTri numeric(10,0),Ma_LyDo_VVien nvarchar(2),Ma_Benh nvarchar(100),Ma_BenhKhac nvarchar(1000),Muc_Huong_XML1 numeric(18,2),T_TongChi numeric(18,0),T_BNTT numeric(18,0),T_BHTT numeric(18,0),T_BNCCT numeric(18,0),"
             + "T_XN numeric(18,0),T_CDHA numeric(18,0), T_Thuoc numeric(18,0),T_Mau numeric(18,0),T_TTPT numeric(18,0),T_VTYT numeric(18,0),T_DVKT_TyLe numeric(18,0),T_Thuoc_TyLe numeric(18,0),T_VTYT_TyLe numeric(18,0),"
             + "T_Kham numeric(18,0),T_Giuong numeric(18,0),T_VChuyen numeric(18,0),T_NgoaiDS numeric(18,0),T_NguonKhac numeric(18,0),Ma_Loai_KCB nvarchar(2),ID_CP numeric(18,0),Loai_CP nvarchar(10),Ma_CP nvarchar(40),"
             + "Ma_Vat_Tu nvarchar(40),Ma_Nhom nvarchar(3),Ten_CP nvarchar(300),DVT nvarchar(100),So_Dang_Ky nvarchar(100),Ham_Luong nvarchar(100),Duong_Dung nvarchar(100),So_Luong numeric(18,2),"
             + "So_Luong_BV numeric(18,2),Don_Gia numeric(18,2),Don_Gia_BV numeric(18,2),Thanh_Tien numeric(18,2),TyLe_TT numeric(18,2),Ngay_YL nvarchar(25),"
             + "Ngay_KQ nvarchar(25),T_NguonKhac_DTL numeric(18,0),T_BNTT_DTL numeric(18,0),"
             + "T_BHTT_DTL numeric(18,0),T_BNCCT_DTL numeric(18,0),T_NgoaiDS_DTL numeric(18,0),Muc_Huong_DTL numeric(10,0),TT_Thau nvarchar(100),Pham_Vi nvarchar(100),Ma_Giuong nvarchar(50),"
             + "T_TranTT numeric(18,2),Goi_VTYT nvarchar(100),Ten_Vat_Tu nvarchar(300),"
             + "Ten_Khoa nvarchar(100),Ma_Khoa nvarchar(20),Ma_Khoa_XML1 nvarchar(20),Ten_Khoa_XML1 nvarchar(300),Ten_Benh nvarchar(300),Ma_Bac_Si nvarchar(20),Ma_Tinh nvarchar(5),Ma_Tinh_The nvarchar(5), Ma_Cha nvarchar(200))";

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                if (DBUtils.ExecuteNonQuery(query, conn) > 0)
                {
                    MessageBox.Show("Tạo Table Thành Công");
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
        public void taoTable_dmThuocVuotTuyen(string _tenTable)
        {
            string tenTable = _tenTable;

            string query = "CREATE TABLE " + tenTable + "(MA_CP nvarchar(200),TEN_THUOC nvarchar(400),DUONG_DUNG nvarchar(200),MA_DUONG_DUNG nvarchar(100),DANG_DUNG nvarchar(200),TUYEN_4 nvarchar(200));";

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                if (DBUtils.ExecuteNonQuery(query, conn) > 0)
                {
                    //MessageBox.Show("Tạo Table Thành Công");
                }
            }
            catch (SqlException ex)
            {
                // MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

        }
        public void taoTable_dmPhauThuatThuThuat(string _tenTable)
        {
            string tenTable = _tenTable;

            string query = "CREATE TABLE " + tenTable + "(MA_DICH_VU nvarchar(200),MA_43 nvarchar(400),TEN_43 nvarchar(200),MA_37 nvarchar(100),TEN_37 nvarchar(400),GIA_3 nvarchar(400),GIA_7 nvarchar(200),LOAI_TTPT nvarchar(200));";

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                if (DBUtils.ExecuteNonQuery(query, conn) > 0)
                {
                    //MessageBox.Show("Tạo Table Thành Công");
                }
            }
            catch (SqlException ex)
            {
                // MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

        }
        public void taoTable_dmNgay(string _tenTable)
        {
            string tenTable = _tenTable;

            string query = "CREATE TABLE " + tenTable + "(NGAY nvarchar(100));";

            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                if (DBUtils.ExecuteNonQuery(query, conn) > 0)
                {
                    //MessageBox.Show("Tạo Table Thành Công");
                }
            }
            catch (SqlException ex)
            {
                // MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

        }
        public void taoTable_dmMau7980a(string _tenTable)
        {
            string tenTable = _tenTable;

            string query = "CREATE TABLE " + tenTable
                + "(MA_TINH nvarchar(100), "
                + "TEN_TINH nvarchar(200), "
                + "TUYENCMKT nvarchar(400), "
                + "TEN_CSKCB nvarchar(400), "
                + "ID nvarchar(50), "
                + "KY_QT nvarchar(400), "
                + "COSOKCB_ID nvarchar(400), "
                + "MA_LK nvarchar(400), "
                + "MA_CSKCB nvarchar(400), "
                + "MA_BN nvarchar(400), "
                + "HO_TEN nvarchar(400), "
                + "NGAY_SINH nvarchar(400), "
                + "GIOI_TINH nvarchar(1), "
                + "DIA_CHI nvarchar(400), "
                + "MA_THE nvarchar(400), "
                + "MA_TINH_THE nvarchar(400), "
                + "MA_DKBD nvarchar(400), "
                + "MUC_HUONG nvarchar(400), "
                + "GT_THE_TU nvarchar(400), "
                + "GT_THE_DEN nvarchar(400), "
                + "MIEN_CUNG_CT nvarchar(400), "
                + "MA_BENH nvarchar(400), "
                + "TEN_BENH nvarchar(400), "
                + "MA_BENHKHAC nvarchar(400), "
                + "MA_LYDO_VVIEN nvarchar(400), "
                + "MA_NOI_CHUYEN nvarchar(400), "
                + "NGAY_VAO nvarchar(400), "
                + "NGAY_RA nvarchar(400), "
                + "SO_NGAY_DTRI nvarchar(400), "
                + "KET_QUA_DTRI nvarchar(400), "
                + "TINH_TRANG_RV nvarchar(400), "
                + "T_TONGCHI nvarchar(400), "
                + "T_XN nvarchar(400), "
                + "T_CDHA nvarchar(400), "
                + "T_THUOC nvarchar(400), "
                + "T_MAU nvarchar(400), "
                + "T_TTPT nvarchar(400), "
                + "T_VTYT nvarchar(400), "
                + "T_DVKT_TYLE nvarchar(400), "
                + "T_THUOC_TYLE nvarchar(400), "
                + "T_VTYT_TYLE nvarchar(400), "
                + "T_KHAM nvarchar(400), "
                + "T_GIUONG nvarchar(400), "
                + "T_VCHUYEN nvarchar(400), "
                + "T_BNTT nvarchar(400), "
                + "T_BHTT nvarchar(400), "
                + "T_BNCCT nvarchar(400), "
                + "T_NGOAIDS nvarchar(400), "
                + "T_NGUONKHAC nvarchar(400), "
                + "MA_KHOA nvarchar(100), "
                + "NAM_QT nvarchar(50), "
                + "QUY_QT nvarchar(20), "
                + "THANG_QT nvarchar(20), "
                + "MA_KHUVUC nvarchar(20), "
                + "MA_LOAI_KCB nvarchar(20), "
                + "LOAI_BN nvarchar(20), "
                + "LOAI_THE nvarchar(20), "
                + "TRONG_MAU nvarchar(400), "
                + "GIAM_DINH nvarchar(400), "
                + "T_XUATTOAN_TONGCHI nvarchar(400), "
                + "T_XUATTOAN nvarchar(400), "
                + "LYDO_XT nvarchar(100), "
                + "T_DATUYEN nvarchar(400), "
                + "T_VUOTTRAN nvarchar(400), "
                + "NGAY_NHAN nvarchar(400), "
                + "TENKIEUBV nvarchar(400), "
                + "MA_TAI_NAN nvarchar(400), "
                + "NGAY_TTOAN nvarchar(400), "
                + "MA_PTTT_QT nvarchar(400), "
                + "CAN_NANG nvarchar(400));";


            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                if (DBUtils.ExecuteNonQuery(query, conn) > 0)
                {
                    //MessageBox.Show("Tạo Table Thành Công");
                }
            }
            catch (SqlException ex)
            {
                // MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

        }

        public void taoTable_dmMau7980a_dtdi(string _tenTable)
        {
            string tenTable = _tenTable;

            string query = "CREATE TABLE " + tenTable
                + "(MA_TINH_KCB nvarchar(400), "
                + "TEN_TINH_KCB nvarchar(400), "
                + "TUYENCMKT nvarchar(50), "
                + "TEN_CSKCB nvarchar(400), "
                + "ID nvarchar(50), "
                + "KY_QT nvarchar(400), "
                + "COSOKCB_ID nvarchar(400), "
                + "MA_LK nvarchar(400), "
                + "MA_CSKCB nvarchar(400), "
                + "MA_BN nvarchar(400), "
                + "HO_TEN nvarchar(400), "
                + "NGAY_SINH nvarchar(400), "
                + "GIOI_TINH nvarchar(1), "
                + "DIA_CHI nvarchar(400), "
                + "MA_THE nvarchar(400), "
                + "MA_TINH nvarchar(400), "
                + "MA_DKBD nvarchar(400), "
                + "MUC_HUONG nvarchar(400), "
                + "GT_THE_TU nvarchar(400), "
                + "GT_THE_DEN nvarchar(400), "
                + "MIEN_CUNG_CT nvarchar(400), "
                + "MA_BENH nvarchar(400), "
                + "TEN_BENH nvarchar(400), "
                + "MA_BENHKHAC nvarchar(400), "
                + "MA_LYDO_VVIEN nvarchar(400), "
                + "MA_NOI_CHUYEN nvarchar(400), "
                + "NGAY_VAO nvarchar(400), "
                + "NGAY_RA nvarchar(400), "
                + "SO_NGAY_DTRI nvarchar(400), "
                + "KET_QUA_DTRI nvarchar(400), "
                + "TINH_TRANG_RV nvarchar(400), "
                + "T_TONGCHI numeric(18,0), "
                + "T_XN numeric(18,0), "
                + "T_CDHA numeric(18,0), "
                + "T_THUOC numeric(18,0), "
                + "T_MAU numeric(18,0), "
                + "T_TTPT numeric(18,0), "
                + "T_VTYT numeric(18,0), "
                + "T_DVKT_TYLE numeric(18,0), "
                + "T_THUOC_TYLE numeric(18,0), "
                + "T_VTYT_TYLE numeric(18,0), "
                + "T_KHAM numeric(18,0), "
                + "T_GIUONG numeric(18,0), "
                + "T_VCHUYEN numeric(18,0), "
                + "T_BNTT numeric(18,0), "
                + "T_BHTT numeric(18,0), "
                + "T_BNCCT numeric(18,0), "
                + "T_NGOAIDS numeric(18,0), "
                + "T_NGUONKHAC numeric(18,0), "
                + "MA_KHOA nvarchar(100), "
                + "NAM_QT nvarchar(50), "
                + "QUY_QT nvarchar(20), "
                + "THANG_QT nvarchar(20), "
                + "MA_KHUVUC nvarchar(20), "
                + "MA_LOAI_KCB nvarchar(20), "
                + "LOAI_BN nvarchar(20), "
                + "LOAI_THE nvarchar(20), "
                + "TRONG_MAU nvarchar(400), "
                + "GIAM_DINH nvarchar(400), "
                + "T_XUATTOAN_TONGCHI numeric(18,0), "
                + "T_XUATTOAN numeric(18,0), "
                + "LYDO_XT nvarchar(100), "
                + "T_DATUYEN numeric(18,0), "
                + "T_VUOTTRAN numeric(18,0), "
                + "NGAY_NHAN nvarchar(400), "
                + "TENKIEUBV nvarchar(400), "
                + "MA_TAI_NAN nvarchar(400), "
                + "NGAY_TTOAN nvarchar(400), "
                + "MA_PTTT_QT nvarchar(400), "
                + "CAN_NANG nvarchar(400));";


            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                if (DBUtils.ExecuteNonQuery(query, conn) > 0)
                {
                    //MessageBox.Show("Tạo Table Thành Công");
                }
            }
            catch (SqlException ex)
            {
                // MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

        }
        public void taoTable_dmMau21a(string _tenTable)
        {
            string tenTable = _tenTable;

            string query = "CREATE TABLE " + tenTable
                + "(KY_QT nvarchar(50), "
                + "MA_TINH nvarchar(100), "
                + "TEN_TINH nvarchar(400), "
                + "COSOKCB_ID nvarchar(400), "
                + "MA_CSKCB nvarchar(400), "
                + "TEN_CSKCB nvarchar(400), "
                + "F_GROUP nvarchar(400), "
                + "MA_DICH_VU nvarchar(400), "
                + "TEN_DICH_VU nvarchar(400), "
                + "MA_NHOM nvarchar(400), "
                + "DON_GIA nvarchar(400), "
                + "TYLE_TT nvarchar(400), "
                + "SL_NGOAI_TRU nvarchar(400), "
                + "SL_NOI_TRU nvarchar(400), "
                + "SO_LUONG nvarchar(400), "
                + "THANH_TIEN nvarchar(400), "
                + "HANGBENHVIEN nvarchar(400), "
                + "TUYENCMKT nvarchar(400), "
                + "KIEUBV nvarchar(400), "
                + "TENKIEUBV nvarchar(400), "
                + "LOAIBENHVIEN nvarchar(400), "
                + "MA_CHA nvarchar(400), "
                + "TEN_VUNG nvarchar(400), "
                + "ID nvarchar(400));";


            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                if (DBUtils.ExecuteNonQuery(query, conn) > 0)
                {
                    //MessageBox.Show("Tạo Table Thành Công");
                }
            }
            catch (SqlException ex)
            {
                // MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

        }
        public void taoTable_dmMau20a(string _tenTable)
        {
            string tenTable = _tenTable;

            string query = "CREATE TABLE " + tenTable
                + "(KY_QT nvarchar(100), "
                + "MA_TINH nvarchar(400), "
                + "TEN_TINH nvarchar(400), "
                + "COSOKCB_ID nvarchar(400), "
                + "MA_CSKCB nvarchar(400), "
                + "TEN_CSKCB nvarchar(400), "
                + "LOAI nvarchar(400), "
                + "F_GROUP nvarchar(400), "
                + "TEN_HOATCHAT nvarchar(400), "
                + "MA_THUOC nvarchar(400), "
                + "TEN_THUOC nvarchar(400), "
                + "DUONG_DUNG nvarchar(400), "
                + "HAM_LUONG nvarchar(400), "
                + "SO_DANG_KY nvarchar(400), "
                + "MA_NHOM nvarchar(400), "
                + "DON_VI_TINH nvarchar(400), "
                + "SL_NGOAI_TRU nvarchar(400), "
                + "SL_NOI_TRU nvarchar(400), "
                + "SO_LUONG nvarchar(400), "
                + "DON_GIA nvarchar(400), "
                + "TYLE_TT nvarchar(400), "
                + "THANH_TIEN nvarchar(400), "
                + "HANGBENHVIEN nvarchar(400), "
                + "TUYENCMKT nvarchar(400), "
                + "KIEUBV nvarchar(400), "
                + "TENKIEUBV nvarchar(400), "
                + "LOAIBENHVIEN nvarchar(400), "
                + "MA_CHA nvarchar(400), "
                + "id nvarchar(400));";


            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                if (DBUtils.ExecuteNonQuery(query, conn) > 0)
                {
                    //MessageBox.Show("Tạo Table Thành Công");
                }
            }
            catch (SqlException ex)
            {
                // MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

        }
        public void taoTable_dmMau19a(string _tenTable)
        {
            string tenTable = _tenTable;

            string query = "CREATE TABLE " + tenTable
                + "(ID nvarchar(400), "
                + "KY_QT nvarchar(400), "
                + "MA_TINH nvarchar(400), "
                + "TEN_TINH nvarchar(400), "
                + "COSOKCB_ID nvarchar(400), "
                + "MA_CSKCB nvarchar(400), "
                + "TEN_CSKCB nvarchar(400), "
                + "HANGBENHVIEN nvarchar(400), "
                + "TUYENCMKT nvarchar(400), "
                + "KIEUBV nvarchar(400), "
                + "TENKIEUBV nvarchar(400), "
                + "LOAIBENHVIEN nvarchar(400), "
                + "MA_VAT_TU nvarchar(400), "
                + "MA_NHOM nvarchar(400), "
                + "TEN_DICH_VU nvarchar(400), "
                + "TEN_THUONG_MAI nvarchar(400), "
                + "QUYCACH nvarchar(400), "
                + "DONVITINH nvarchar(400), "
                + "SL_NGOAI_TRU nvarchar(400), "
                + "SL_NOI_TRU nvarchar(400), "
                + "SO_LUONG nvarchar(400), "
                + "DON_GIA_BV nvarchar(400), "
                + "DON_GIA_BHYT nvarchar(400), "
                + "TYLE_TT nvarchar(400), "
                + "THANH_TIEN nvarchar(400));";


            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                if (DBUtils.ExecuteNonQuery(query, conn) > 0)
                {
                    //MessageBox.Show("Tạo Table Thành Công");
                }
            }
            catch (SqlException ex)
            {
                // MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

        }
        public void taoTable_dmMau14a(string _tenTable)
        {
            string tenTable = _tenTable;

            string query = "CREATE TABLE " + tenTable
                + "(ID nvarchar(400), "
                + "MA_TINH nvarchar(400), "
                + "TEN_TINH nvarchar(400), "
                + "MA_CSKCB nvarchar(400), "
                + "TEN_CSKCB nvarchar(400), "
                + "COSOKCB_ID nvarchar(400), "
                + "LOAI_KCB nvarchar(400), "
                + "KY_QT nvarchar(400), "
                + "LUOT_DUNG_TUYEN nvarchar(400), "
                + "LUOT_TRAI_TUYEN nvarchar(400), "
                + "LUOT_KCB nvarchar(400), "
                + "T_TONGCHI nvarchar(400), "
                + "T_BHTT nvarchar(400), "
                + "T_BNTT nvarchar(400), "
                + "T_NGUON_KHAC nvarchar(400), "
                + "T_NGOAI_DS nvarchar(400), "
                + "SO_NGAY_DTRI nvarchar(400), "
                + "T_XN nvarchar(400), "
                + "T_CDHA nvarchar(400), "
                + "T_THUOC nvarchar(400), "
                + "T_MAU nvarchar(400), "
                + "T_TTPT nvarchar(400), "
                + "T_VTYT nvarchar(400), "
                + "T_DVKT_TYLE nvarchar(400), "
                + "T_THUOC_TYLE nvarchar(400), "
                + "T_VTYT_TYLE nvarchar(400), "
                + "T_KHAM nvarchar(400), "
                + "T_VCHUYEN nvarchar(400), "
                + "T_GIUONG nvarchar(400), "
                + "QUY_QT nvarchar(400), "
                + "SL_XETNGHIEM nvarchar(400), "
                + "SL_CDHA nvarchar(400), "
                + "SL_THUOC nvarchar(400), "
                + "SL_MAU nvarchar(400), "
                + "SL_TTPT nvarchar(400), "
                + "SL_VTYT nvarchar(400), "
                + "SL_DVKT_TYLE nvarchar(400), "
                + "SL_THUOC_TYLE nvarchar(400), "
                + "SL_VTYT_TYLE nvarchar(400), "
                + "SL_KHAM nvarchar(400), "
                + "SL_GIUONG nvarchar(400), "
                + "SL_VAN_CHUYEN nvarchar(400), "
                + "HANGBV nvarchar(400), "
                + "TUYENBV nvarchar(400), "
                + "LOAIBV nvarchar(400), "
                + "KIEUBV nvarchar(400), "
                + "TENKIEUBV nvarchar(400), "
                + "MA_CHA nvarchar(400), "
                + "LOAIHOPDONG nvarchar(400), "
                + "HANG_DV_TD nvarchar(400), "
                + "HANGTHUOC_TD nvarchar(400), "
                + "HANGVT_TD nvarchar(400), "
                + "TEN_VUNG nvarchar(400));";


            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                if (DBUtils.ExecuteNonQuery(query, conn) > 0)
                {
                    //MessageBox.Show("Tạo Table Thành Công");
                }
            }
            catch (SqlException ex)
            {
                // MessageBox.Show("Error: " + ex.ToString());
            }
            finally
            {
                conn.Close();
                conn.Dispose();
            }

        }
        
        #endregion
        
        #region Function XML123
        private void themVaoCSDLxml123_BULKCOPY()
        {
            for (int i = 0; i < _FileNames.Count; i++)
            {
                string _FileName = _FileNames[i];
                string _SafeFileName = _SafeFileNames[i];

                string _MaCSKCB = (_SafeFileName.Split('.'))[0].ToString().Trim();

                string tenTable = "xml123_" + _MaCSKCB;

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
                taoTable_xml123(_MaCSKCB);

                string myconnection = "Data Source =" + _FileName;
                SQLiteConnection mysqliteconn = new SQLiteConnection(myconnection);
                SQLiteDataReader mysqlitereader;
                SQLiteCommand SelectCommand = new SQLiteCommand("SELECT ID, XML1_ID, Ky_QT, CoSoKCB_ID, Ma_CSKCB, Ma_LK, MA_BN, Ho_Ten, Ngay_Sinh, Gioi_Tinh, Ma_The, Ma_DKBD, GT_The_Tu, GT_The_Den, Mien_Cung_CT, Ngay_Vao, Ngay_Ra, So_Ngay_DTri, Ma_LyDo_VVien, Ma_Benh, Ma_BenhKhac, Muc_Huong_XML1, T_TongChi, T_BNTT, T_BHTT, T_BNCCT, T_XN, T_CDHA, T_Thuoc, T_Mau, T_TTPT, T_VTYT, T_DVKT_TyLe, T_Thuoc_TyLe, T_VTYT_TyLe, T_Kham, T_Giuong, T_VChuyen, T_NgoaiDS, T_NguonKhac, Ma_Loai_KCB, ID_CP, Loai_CP, Ma_CP, Ma_Vat_Tu, Ma_Nhom, Ten_CP, DVT, So_Dang_Ky, Ham_Luong, Duong_Dung, So_Luong, So_Luong_BV, Don_Gia, Don_Gia_BV, Thanh_Tien, TyLe_TT, Ngay_YL, Ngay_KQ, T_NguonKhac_DTL, T_BNTT_DTL, T_BHTT_DTL, T_BNCCT_DTL, T_NgoaiDS_DTL, Muc_Huong_DTL, TT_Thau, Pham_Vi, Ma_Giuong, T_TranTT, Goi_VTYT, Ten_Vat_Tu, Ten_Khoa, Ma_Khoa, Ma_Khoa_XML1, Ten_Khoa_XML1, Ten_Benh, Ma_Bac_Si, Ma_Tinh, Ma_Tinh_The, Ma_Cha FROM xml123", mysqliteconn);
                mysqliteconn.Open();

                mysqlitereader = SelectCommand.ExecuteReader();

                Task.Factory.StartNew(() =>
                {
                    using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(conn))
                    {
                        

                        sqlBulkCopy.NotifyAfter = 5000;
                        sqlBulkCopy.BulkCopyTimeout = 0;

                        //sqlBulkCopy.BatchSize = 200000;

                        sqlBulkCopy.DestinationTableName = tenTable;

                        sqlBulkCopy.WriteToServer(mysqlitereader);

                    }
                }).ContinueWith((t) =>
                {
                    MessageBox.Show("Ghi thành công CSKCB: " + _MaCSKCB);
                }, System.Threading.CancellationToken.None, TaskContinuationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
                
            }
        }
        private void themVaoCSDLxml123_BULKCOPY_KQT()
        {
            for (int i = 0; i < _FileNames.Count; i++)
            {
                string _FileName = _FileNames[i];
                string _SafeFileName = _SafeFileNames[i];

                string _MaCSKCB = (_SafeFileName.Split('.'))[0].ToString().Trim();

                string tenTable = "xml123_" + _MaCSKCB;

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
                taoTable_xml123(_MaCSKCB);

                string myconnection = "Data Source =" + _FileName;
                SQLiteConnection mysqliteconn = new SQLiteConnection(myconnection);
                SQLiteDataReader mysqlitereader;

                string _ngayBatDau = this.tbThoiGianBatDau.Text;
                string _ngayKetThuc = this.tbThoiGianKetThuc.Text;
                string _menhDeWhereKyQuyetToan = "KY_QT BETWEEN " + _ngayBatDau + " AND " + _ngayKetThuc;

                SQLiteCommand SelectCommand = new SQLiteCommand("SELECT ID, XML1_ID, Ky_QT, CoSoKCB_ID, Ma_CSKCB, Ma_LK, MA_BN, Ho_Ten, Ngay_Sinh, Gioi_Tinh, Ma_The, Ma_DKBD, GT_The_Tu, GT_The_Den, Mien_Cung_CT, Ngay_Vao, Ngay_Ra, So_Ngay_DTri, Ma_LyDo_VVien, Ma_Benh, Ma_BenhKhac, Muc_Huong_XML1, T_TongChi, T_BNTT, T_BHTT, T_BNCCT, T_XN, T_CDHA, T_Thuoc, T_Mau, T_TTPT, T_VTYT, T_DVKT_TyLe, T_Thuoc_TyLe, T_VTYT_TyLe, T_Kham, T_Giuong, T_VChuyen, T_NgoaiDS, T_NguonKhac, Ma_Loai_KCB, ID_CP, Loai_CP, Ma_CP, Ma_Vat_Tu, Ma_Nhom, Ten_CP, DVT, So_Dang_Ky, Ham_Luong, Duong_Dung, So_Luong, So_Luong_BV, Don_Gia, Don_Gia_BV, Thanh_Tien, TyLe_TT, Ngay_YL, Ngay_KQ, T_NguonKhac_DTL, T_BNTT_DTL, T_BHTT_DTL, T_BNCCT_DTL, T_NgoaiDS_DTL, Muc_Huong_DTL, TT_Thau, Pham_Vi, Ma_Giuong, T_TranTT, Goi_VTYT, Ten_Vat_Tu, Ten_Khoa, Ma_Khoa, Ma_Khoa_XML1, Ten_Khoa_XML1, Ten_Benh, Ma_Bac_Si, Ma_Tinh, Ma_Tinh_The, Ma_Cha FROM xml123 WHERE " + _menhDeWhereKyQuyetToan, mysqliteconn);
                mysqliteconn.Open();

              
                mysqlitereader = SelectCommand.ExecuteReader();

                Task.Factory.StartNew(() =>
                {
                    using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(conn))
                    {


                        sqlBulkCopy.NotifyAfter = 5000;
                        sqlBulkCopy.BulkCopyTimeout = 0;

                        //sqlBulkCopy.BatchSize = 200000;

                        sqlBulkCopy.DestinationTableName = tenTable;

                        sqlBulkCopy.WriteToServer(mysqlitereader);

                    }
                }).ContinueWith((t) =>
                {
                    MessageBox.Show("Ghi thành công CSKCB: " + _MaCSKCB);
                }, System.Threading.CancellationToken.None, TaskContinuationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
                
            }
        }
        #endregion

        #region Function DM XML123 Đa tuyến đi
        private void themVaoCSDLxml123_dtdi_BULKCOPY()
        {
            for (int i = 0; i < _FileNames.Count; i++)
            {
                string _FileName = _FileNames[i];
                string _SafeFileName = _SafeFileNames[i];

                string tenTable = "xml123_dtdi";

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
                taoTable_xml123_dtdi(tenTable);

                string myconnection = "Data Source =" + _FileName;
                SQLiteConnection mysqliteconn = new SQLiteConnection(myconnection);
                SQLiteDataReader mysqlitereader;
                SQLiteCommand SelectCommand = new SQLiteCommand("SELECT ID, XML1_ID, Ky_QT, CoSoKCB_ID, Ma_CSKCB, Ma_LK, MA_BN, Ho_Ten, Ngay_Sinh, Gioi_Tinh, Ma_The, Ma_DKBD, GT_The_Tu, GT_The_Den, Mien_Cung_CT, Ngay_Vao, Ngay_Ra, So_Ngay_DTri, Ma_LyDo_VVien, Ma_Benh, Ma_BenhKhac, Muc_Huong_XML1, T_TongChi, T_BNTT, T_BHTT, T_BNCCT, T_XN, T_CDHA, T_Thuoc, T_Mau, T_TTPT, T_VTYT, T_DVKT_TyLe, T_Thuoc_TyLe, T_VTYT_TyLe, T_Kham, T_Giuong, T_VChuyen, T_NgoaiDS, T_NguonKhac, Ma_Loai_KCB, ID_CP, Loai_CP, Ma_CP, Ma_Vat_Tu, Ma_Nhom, Ten_CP, DVT, So_Dang_Ky, Ham_Luong, Duong_Dung, So_Luong, So_Luong_BV, Don_Gia, Don_Gia_BV, Thanh_Tien, TyLe_TT, Ngay_YL, Ngay_KQ, T_NguonKhac_DTL, T_BNTT_DTL, T_BHTT_DTL, T_BNCCT_DTL, T_NgoaiDS_DTL, Muc_Huong_DTL, TT_Thau, Pham_Vi, Ma_Giuong, T_TranTT, Goi_VTYT, Ten_Vat_Tu, Ten_Khoa, Ma_Khoa, Ma_Khoa_XML1, Ten_Khoa_XML1, Ten_Benh, Ma_Bac_Si, Ma_Tinh_KCB, Ma_Tinh FROM xml123_dtdi", mysqliteconn);
                mysqliteconn.Open();

                mysqlitereader = SelectCommand.ExecuteReader();

                Task.Factory.StartNew(() =>
                {
                    using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(conn))
                    {


                        sqlBulkCopy.NotifyAfter = 5000;
                        sqlBulkCopy.BulkCopyTimeout = 0;

                        //sqlBulkCopy.BatchSize = 200000;

                        sqlBulkCopy.DestinationTableName = tenTable;

                        sqlBulkCopy.WriteToServer(mysqlitereader);

                    }
                }).ContinueWith((t) =>
                {
                    MessageBox.Show("Ghi thành công bảng: " + tenTable);
                }, System.Threading.CancellationToken.None, TaskContinuationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());

            }
        }
        #endregion

        #region Function DM Mẫu 7980a Đa Tuyến Đi
        private void themVaoCSDLxmlMau7980a_dtdi_BULKCOPY()
        {
            for (int i = 0; i < _FileNames.Count; i++)
            {
                string _FileName = _FileNames[i];

                string tenTable = "bhyt7980a_dtdi";
                string tenTableImport = "bhyt7980a_dtdi";
                string chuoiColumn = "MA_TINH_KCB, TEN_TINH_KCB, TUYENCMKT, TEN_CSKCB, ID, KY_QT, COSOKCB_ID, MA_LK, MA_CSKCB, MA_BN, HO_TEN, NGAY_SINH, GIOI_TINH, DIA_CHI, MA_THE, MA_DKBD, MUC_HUONG, GT_THE_TU, GT_THE_DEN, MIEN_CUNG_CT, MA_BENH, TEN_BENH, MA_BENHKHAC, MA_LYDO_VVIEN, MA_NOI_CHUYEN, NGAY_VAO, NGAY_RA, SO_NGAY_DTRI, KET_QUA_DTRI, TINH_TRANG_RV, T_TONGCHI, T_XN, T_CDHA, T_THUOC, T_MAU, T_TTPT, T_VTYT, T_DVKT_TYLE, T_THUOC_TYLE, T_VTYT_TYLE, T_KHAM, T_GIUONG, T_VCHUYEN, T_BNTT, T_BHTT, T_BNCCT, T_NGOAIDS, T_NGUONKHAC, MA_KHOA, NAM_QT, QUY_QT, THANG_QT, MA_KHUVUC, MA_LOAI_KCB, LOAI_BN, LOAI_THE, TRONG_MAU, GIAM_DINH, T_XUATTOAN_TONGCHI, T_XUATTOAN, LYDO_XT, T_DATUYEN, T_VUOTTRAN, NGAY_NHAN, TENKIEUBV, MA_TAI_NAN, NGAY_TTOAN, MA_PTTT_QT, CAN_NANG";
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
                taoTable_dmMau7980a_dtdi(tenTable);

                string myconnection = "Data Source =" + _FileName;
                SQLiteConnection mysqliteconn = new SQLiteConnection(myconnection);
                SQLiteDataReader mysqlitereader;
                SQLiteCommand SelectCommand = new SQLiteCommand("SELECT " + chuoiColumn + " FROM " + tenTableImport, mysqliteconn);
                mysqliteconn.Open();


                mysqlitereader = SelectCommand.ExecuteReader();


                Task.Factory.StartNew(() =>
                {
                    using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(conn))
                    {


                        sqlBulkCopy.NotifyAfter = 5000;
                        sqlBulkCopy.BulkCopyTimeout = 0;

                        sqlBulkCopy.DestinationTableName = tenTable;

                        sqlBulkCopy.WriteToServer(mysqlitereader);

                    }
                }).ContinueWith((t) =>
                {
                    MessageBox.Show("Ghi thành công bảng danh mục mẫu 7980a!");
                }, System.Threading.CancellationToken.None, TaskContinuationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());

            }
        }
        #endregion

        #region Function DM Thuốc vượt tuyến
        private void themVaoCSDLxmlThuocVuotTuyen_BULKCOPY()
        {
            string _FileName = _FileNames[0];

            string tenTable = "dmthuocvuottuyen";
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
            taoTable_dmThuocVuotTuyen(tenTable);

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
                string Query = string.Format("Select [ma_cp],[ten_thuoc],[duong_dung],[ma_duong_dung],[dang_dung],[tuyen_4] FROM [{0}]", "Sheet1$");
                OleDbCommand Ecom = new OleDbCommand(Query, Econ);
                Econ.Open();

                DataSet ds = new DataSet();
                OleDbDataAdapter oda = new OleDbDataAdapter(Query, Econ);

                oda.Fill(ds);
                DataTable Exceldt = ds.Tables[0];
                Exceldt.AcceptChanges();

                SqlBulkCopy objbulk = new SqlBulkCopy(conn);
                objbulk.DestinationTableName = tenTable;

                //Mapping Table column    
                objbulk.ColumnMappings.Add("[ma_cp]", "MA_CP");
                objbulk.ColumnMappings.Add("[ten_thuoc]", "TEN_THUOC");
                objbulk.ColumnMappings.Add("[duong_dung]", "DUONG_DUNG");
                objbulk.ColumnMappings.Add("[ma_duong_dung]", "MA_DUONG_DUNG");
                objbulk.ColumnMappings.Add("[dang_dung]", "DANG_DUNG");
                objbulk.ColumnMappings.Add("[tuyen_4]", "TUYEN_4");

                objbulk.WriteToServer(Exceldt);
                MessageBox.Show("Ghi thành công bảng danh mục Thuốc vượt tuyến", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);


                Econ.Close();
                Econ.Dispose();
                Ecom.Dispose();
                oda.Dispose();
                objbulk.Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Dữ liệu không đúng định dạng!"), "Không Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        #endregion

        #region Function DM Phẫu thuật thủ thuật
        private void themVaoCSDLxmlPhauThuatThuThuat_BULKCOPY()
        {
            string _FileName = _FileNames[0];

            string tenTable = "dmphauthuatthuthuat";

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
            taoTable_dmPhauThuatThuThuat(tenTable);


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
                string Query = string.Format("Select [MA_DICH_VU],[MA_43],[TEN_43],[MA_37],[TEN_37],[GIA_3],[GIA_7],[LOAI_TTPT] FROM [{0}]", "Sheet1$");
                OleDbCommand Ecom = new OleDbCommand(Query, Econ);
                Econ.Open();

                DataSet ds = new DataSet();
                OleDbDataAdapter oda = new OleDbDataAdapter(Query, Econ);
                
                oda.Fill(ds);

                DataTable Exceldt = ds.Tables[0];
            
                Exceldt.AcceptChanges();

            
                     
                SqlBulkCopy objbulk = new SqlBulkCopy(conn);  
                objbulk.DestinationTableName = tenTable;

                //Mapping Table column    
                objbulk.ColumnMappings.Add("[MA_DICH_VU]", "MA_DICH_VU");
                objbulk.ColumnMappings.Add("[MA_43]", "MA_43");
                objbulk.ColumnMappings.Add("[TEN_43]", "TEN_43");
                objbulk.ColumnMappings.Add("[MA_37]", "MA_37");
                objbulk.ColumnMappings.Add("[TEN_37]", "TEN_37");
                objbulk.ColumnMappings.Add("[GIA_3]", "GIA_3");
                objbulk.ColumnMappings.Add("[GIA_7]", "GIA_7");
                objbulk.ColumnMappings.Add("[LOAI_TTPT]", "LOAI_TTPT");

                objbulk.WriteToServer(Exceldt);
                MessageBox.Show("Ghi thành công bảng danh mục Phẫu thuật thủ thuật", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);

                Econ.Close();
                Econ.Dispose();
                Ecom.Dispose();
                oda.Dispose();
                objbulk.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Dữ liệu không đúng định dạng!"), "Không Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        #endregion

        #region Function DM Ngày
        private void themVaoCSDLxmlNgay_BULKCOPY()
        {
                string _FileName = _FileNames[0];

                string tenTable = "dm_ngay";
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
                taoTable_dmNgay(tenTable);

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
                string Query = string.Format("Select [NGAY] FROM [{0}]", "Sheet1$");
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
                objbulk.ColumnMappings.Add("[NGAY]", "NGAY");

                objbulk.WriteToServer(Exceldt);
                MessageBox.Show("Ghi thành công bảng danh mục Ngày", "Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
            catch (Exception ex)
            {
                MessageBox.Show(string.Format("Dữ liệu không đúng định dạng!"), "Không Thành Công", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }
        #endregion

        #region Function DM Mẫu 7980a
        private void themVaoCSDLxmlMau7980a_BULKCOPY()
        {
            for (int i = 0; i < _FileNames.Count; i++)
            {
                string _FileName = _FileNames[i];

                string tenTable = "bhyt7980a";
                string tenTableImport = "bhyt7980a";
                string chuoiColumn = "MA_TINH_KCB, TEN_TINH_KCB, TUYENCMKT, TEN_CSKCB, ID, KY_QT, COSOKCB_ID, MA_LK, MA_CSKCB, MA_BN, HO_TEN, NGAY_SINH, GIOI_TINH, DIA_CHI, MA_THE, MA_TINH_THE, MA_DKBD, MUC_HUONG, GT_THE_TU, GT_THE_DEN, MIEN_CUNG_CT, MA_BENH, TEN_BENH, MA_BENHKHAC, MA_LYDO_VVIEN, MA_NOI_CHUYEN, NGAY_VAO, NGAY_RA, SO_NGAY_DTRI, KET_QUA_DTRI, TINH_TRANG_RV, T_TONGCHI, T_XN, T_CDHA, T_THUOC, T_MAU, T_TTPT, T_VTYT, T_DVKT_TYLE, T_THUOC_TYLE, T_VTYT_TYLE, T_KHAM, T_GIUONG, T_VCHUYEN, T_BNTT, T_BHTT, T_BNCCT, T_NGOAIDS, T_NGUONKHAC, MA_KHOA, NAM_QT, QUY_QT, THANG_QT, MA_KHUVUC, MA_LOAI_KCB, LOAI_BN, LOAI_THE, TRONG_MAU, GIAM_DINH, T_XUATTOAN_TONGCHI, T_XUATTOAN, LYDO_XT, T_DATUYEN, T_VUOTTRAN, NGAY_NHAN, TENKIEUBV, MA_TAI_NAN, NGAY_TTOAN, MA_PTTT_QT";
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
                taoTable_dmMau7980a(tenTable);

                string myconnection = "Data Source =" + _FileName;
                SQLiteConnection mysqliteconn = new SQLiteConnection(myconnection);
                SQLiteDataReader mysqlitereader;
                SQLiteCommand SelectCommand = new SQLiteCommand("SELECT " + chuoiColumn + " FROM " + tenTableImport, mysqliteconn);
                mysqliteconn.Open();

                
                mysqlitereader = SelectCommand.ExecuteReader();


                Task.Factory.StartNew(() =>
                {
                    using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(conn))
                    {


                        sqlBulkCopy.NotifyAfter = 5000;
                        sqlBulkCopy.BulkCopyTimeout = 0;

                        sqlBulkCopy.DestinationTableName = tenTable;

                        sqlBulkCopy.WriteToServer(mysqlitereader);

                    }
                }).ContinueWith((t) =>
                {
                    MessageBox.Show("Ghi thành công bảng danh mục mẫu 7980a!");
                }, System.Threading.CancellationToken.None, TaskContinuationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
              
            }
        }

        private void themVaoCSDLxmlMau7980a_KQT_BULKCOPY()
        {
            for (int i = 0; i < _FileNames.Count; i++)
            {
                string _FileName = _FileNames[i];

                string tenTable = "bhyt7980a";
                string tenTableImport = "bhyt7980a";
                string chuoiColumn = "MA_TINH, TEN_TINH, TUYENCMKT, TEN_CSKCB, ID, KY_QT, COSOKCB_ID, MA_LK, MA_CSKCB, MA_BN, HO_TEN, NGAY_SINH, GIOI_TINH, DIA_CHI, MA_THE, MA_TINH_THE, MA_DKBD, MUC_HUONG, GT_THE_TU, GT_THE_DEN, MIEN_CUNG_CT, MA_BENH, TEN_BENH, MA_BENHKHAC, MA_LYDO_VVIEN, MA_NOI_CHUYEN, NGAY_VAO, NGAY_RA, SO_NGAY_DTRI, KET_QUA_DTRI, TINH_TRANG_RV, T_TONGCHI, T_XN, T_CDHA, T_THUOC, T_MAU, T_TTPT, T_VTYT, T_DVKT_TYLE, T_THUOC_TYLE, T_VTYT_TYLE, T_KHAM, T_GIUONG, T_VCHUYEN, T_BNTT, T_BHTT, T_BNCCT, T_NGOAIDS, T_NGUONKHAC, MA_KHOA, NAM_QT, QUY_QT, THANG_QT, MA_KHUVUC, MA_LOAI_KCB, LOAI_BN, LOAI_THE, TRONG_MAU, GIAM_DINH, T_XUATTOAN_TONGCHI, T_XUATTOAN, LYDO_XT, T_DATUYEN, T_VUOTTRAN, NGAY_NHAN, TENKIEUBV, MA_TAI_NAN, NGAY_TTOAN, MA_PTTT_QT, CAN_NANG";
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
                taoTable_dmMau7980a(tenTable);

                string myconnection = "Data Source =" + _FileName;
                SQLiteConnection mysqliteconn = new SQLiteConnection(myconnection);
                SQLiteDataReader mysqlitereader;
                
                string _ngayBatDau = this.tbThoiGianBatDau.Text;
                string _ngayKetThuc = this.tbThoiGianKetThuc.Text;
                string _menhDeWhereKyQuyetToan = "KY_QT BETWEEN " + _ngayBatDau + " AND " + _ngayKetThuc;
                SQLiteCommand SelectCommand = new SQLiteCommand("SELECT " + chuoiColumn + " FROM " + tenTableImport + " WHERE " + _menhDeWhereKyQuyetToan, mysqliteconn);

                mysqliteconn.Open();
                
                mysqlitereader = SelectCommand.ExecuteReader();


                Task.Factory.StartNew(() =>
                {
                    using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(conn))
                    {


                        sqlBulkCopy.NotifyAfter = 5000;
                        sqlBulkCopy.BulkCopyTimeout = 0;

                        sqlBulkCopy.DestinationTableName = tenTable;

                        sqlBulkCopy.WriteToServer(mysqlitereader);

                    }
                }).ContinueWith((t) =>
                {
                    MessageBox.Show("Ghi thành công bảng danh mục mẫu 7980a!");
                }, System.Threading.CancellationToken.None, TaskContinuationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
               
            }
        }
        #endregion

        #region Function DM Mẫu 21a
        private void themVaoCSDLxmlMau21a_BULKCOPY()
        {
            for (int i = 0; i < _FileNames.Count; i++)
            {
                string _FileName = _FileNames[i];

                string tenTable = "bhyt21a";
                string tenTableImport = "bhyt21a";
                string chuoiColumn = "KY_QT, "
                            + "MA_TINH, "
                            + "TEN_TINH, "
                            + "COSOKCB_ID, "
                            + "MA_CSKCB, "
                            + "TEN_CSKCB, "
                            + "F_GROUP, "
                            + "MA_DICH_VU, "
                            + "TEN_DICH_VU, "
                            + "MA_NHOM, "
                            + "DON_GIA, "
                            + "TYLE_TT, "
                            + "SL_NGOAI_TRU, "
                            + "SL_NOI_TRU, "
                            + "SO_LUONG, "
                            + "THANH_TIEN, "
                            + "HANGBENHVIEN, "
                            + "TUYENCMKT, "
                            + "KIEUBV, "
                            + "TENKIEUBV, "
                            + "LOAIBENHVIEN, "
                            + "MA_CHA, "
                            + "TEN_VUNG, "
                            + "ID";

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
                taoTable_dmMau21a(tenTable);

                string myconnection = "Data Source =" + _FileName;
                SQLiteConnection mysqliteconn = new SQLiteConnection(myconnection);
                SQLiteDataReader mysqlitereader;
                SQLiteCommand SelectCommand = new SQLiteCommand("SELECT " + chuoiColumn + " FROM " + tenTableImport, mysqliteconn);
                mysqliteconn.Open();
                
                mysqlitereader = SelectCommand.ExecuteReader();


                Task.Factory.StartNew(() =>
                {
                    using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(conn))
                    {


                        sqlBulkCopy.NotifyAfter = 5000;
                        sqlBulkCopy.BulkCopyTimeout = 0;

                        sqlBulkCopy.DestinationTableName = tenTable;

                        sqlBulkCopy.WriteToServer(mysqlitereader);

                    }
                }).ContinueWith((t) =>
                {
                    MessageBox.Show("Ghi thành công bảng danh mục mẫu 21a!");
                }, System.Threading.CancellationToken.None, TaskContinuationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
              
            }
        }

        private void themVaoCSDLxmlMau21a_KQT_BULKCOPY()
        {
            for (int i = 0; i < _FileNames.Count; i++)
            {
                string _FileName = _FileNames[i];

                string tenTable = "bhyt21a";
                string tenTableImport = "bhyt21a";
                string chuoiColumn = "KY_QT, "
                            + "MA_TINH, "
                            + "TEN_TINH, "
                            + "COSOKCB_ID, "
                            + "MA_CSKCB, "
                            + "TEN_CSKCB, "
                            + "F_GROUP, "
                            + "MA_DICH_VU, "
                            + "TEN_DICH_VU, "
                            + "MA_NHOM, "
                            + "DON_GIA, "
                            + "TYLE_TT, "
                            + "SL_NGOAI_TRU, "
                            + "SL_NOI_TRU, "
                            + "SO_LUONG, "
                            + "THANH_TIEN, "
                            + "HANGBENHVIEN, "
                            + "TUYENCMKT, "
                            + "KIEUBV, "
                            + "TENKIEUBV, "
                            + "LOAIBENHVIEN, "
                            + "MA_CHA, "
                            + "TEN_VUNG, "
                            + "ID";

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
                taoTable_dmMau21a(tenTable);

                string myconnection = "Data Source =" + _FileName;
                SQLiteConnection mysqliteconn = new SQLiteConnection(myconnection);
                SQLiteDataReader mysqlitereader;

                string _ngayBatDau = this.tbThoiGianBatDau.Text;
                string _ngayKetThuc = this.tbThoiGianKetThuc.Text;
                string _menhDeWhereKyQuyetToan = "KY_QT BETWEEN " + _ngayBatDau + " AND " + _ngayKetThuc;
                SQLiteCommand SelectCommand = new SQLiteCommand("SELECT " + chuoiColumn + " FROM " + tenTableImport + " WHERE " + _menhDeWhereKyQuyetToan, mysqliteconn);

                mysqliteconn.Open();
                mysqlitereader = SelectCommand.ExecuteReader();


                Task.Factory.StartNew(() =>
                {
                    using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(conn))
                    {


                        sqlBulkCopy.NotifyAfter = 5000;
                        sqlBulkCopy.BulkCopyTimeout = 0;

                        sqlBulkCopy.DestinationTableName = tenTable;

                        sqlBulkCopy.WriteToServer(mysqlitereader);

                    }
                }).ContinueWith((t) =>
                {
                    MessageBox.Show("Ghi thành công bảng danh mục mẫu 21a!");
                }, System.Threading.CancellationToken.None, TaskContinuationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
               
            }
        }
        #endregion

        #region Function DM Mẫu 20a
        private void themVaoCSDLxmlMau20a_BULKCOPY()
        {
            for (int i = 0; i < _FileNames.Count; i++)
            {
                string _FileName = _FileNames[i];

                string tenTable = "bhyt20a";
                string tenTableImport = "bhyt20a";

                string chuoiColumn = "KY_QT, "
                    + "MA_TINH, "
                    + "TEN_TINH, "
                    + "COSOKCB_ID, "
                    + "MA_CSKCB, "
                    + "TEN_CSKCB, "
                    + "LOAI, "
                    + "F_GROUP, "
                    + "TEN_HOATCHAT, "
                    + "MA_THUOC, "
                    + "TEN_THUOC, "
                    + "DUONG_DUNG, "
                    + "HAM_LUONG, "
                    + "SO_DANG_KY, "
                    + "MA_NHOM, "
                    + "DON_VI_TINH, "
                    + "SL_NGOAI_TRU, "
                    + "SL_NOI_TRU, "
                    + "SO_LUONG, "
                    + "DON_GIA, "
                    + "TYLE_TT, "
                    + "THANH_TIEN, "
                    + "HANGBENHVIEN, "
                    + "TUYENCMKT, "
                    + "KIEUBV, "
                    + "TENKIEUBV, "
                    + "LOAIBENHVIEN, "
                    + "MA_CHA, "
                    + "id";

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
                taoTable_dmMau20a(tenTable);

                string myconnection = "Data Source =" + _FileName;
                SQLiteConnection mysqliteconn = new SQLiteConnection(myconnection);
                SQLiteDataReader mysqlitereader;
                SQLiteCommand SelectCommand = new SQLiteCommand("SELECT " + chuoiColumn + " FROM " + tenTableImport, mysqliteconn);
                mysqliteconn.Open();
                mysqlitereader = SelectCommand.ExecuteReader();


                Task.Factory.StartNew(() =>
                {
                    using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(conn))
                    {


                        sqlBulkCopy.NotifyAfter = 5000;
                        sqlBulkCopy.BulkCopyTimeout = 0;

                        sqlBulkCopy.DestinationTableName = tenTable;

                        sqlBulkCopy.WriteToServer(mysqlitereader);

                    }
                }).ContinueWith((t) =>
                {
                    MessageBox.Show("Ghi thành công bảng danh mục mẫu 20a!");
                }, System.Threading.CancellationToken.None, TaskContinuationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
                
            }
        }

        private void themVaoCSDLxmlMau20a_KQT_BULKCOPY()
        {
            for (int i = 0; i < _FileNames.Count; i++)
            {
                string _FileName = _FileNames[i];

                string tenTable = "bhyt20a";
                string tenTableImport = "bhyt20a";

                string chuoiColumn = "KY_QT, "
                    + "MA_TINH, "
                    + "TEN_TINH, "
                    + "COSOKCB_ID, "
                    + "MA_CSKCB, "
                    + "TEN_CSKCB, "
                    + "LOAI, "
                    + "F_GROUP, "
                    + "TEN_HOATCHAT, "
                    + "MA_THUOC, "
                    + "TEN_THUOC, "
                    + "DUONG_DUNG, "
                    + "HAM_LUONG, "
                    + "SO_DANG_KY, "
                    + "MA_NHOM, "
                    + "DON_VI_TINH, "
                    + "SL_NGOAI_TRU, "
                    + "SL_NOI_TRU, "
                    + "SO_LUONG, "
                    + "DON_GIA, "
                    + "TYLE_TT, "
                    + "THANH_TIEN, "
                    + "HANGBENHVIEN, "
                    + "TUYENCMKT, "
                    + "KIEUBV, "
                    + "TENKIEUBV, "
                    + "LOAIBENHVIEN, "
                    + "MA_CHA, "
                    + "ID";

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
                taoTable_dmMau20a(tenTable);

                string myconnection = "Data Source =" + _FileName;
                SQLiteConnection mysqliteconn = new SQLiteConnection(myconnection);
                SQLiteDataReader mysqlitereader;

                string _ngayBatDau = this.tbThoiGianBatDau.Text;
                string _ngayKetThuc = this.tbThoiGianKetThuc.Text;
                string _menhDeWhereKyQuyetToan = "KY_QT BETWEEN " + _ngayBatDau + " AND " + _ngayKetThuc;
                SQLiteCommand SelectCommand = new SQLiteCommand("SELECT " + chuoiColumn + " FROM " + tenTableImport + " WHERE " + _menhDeWhereKyQuyetToan, mysqliteconn);

                mysqliteconn.Open();
                
                mysqlitereader = SelectCommand.ExecuteReader();


                Task.Factory.StartNew(() =>
                {
                    using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(conn))
                    {


                        sqlBulkCopy.NotifyAfter = 5000;
                        sqlBulkCopy.BulkCopyTimeout = 0;

                        sqlBulkCopy.DestinationTableName = tenTable;

                        sqlBulkCopy.WriteToServer(mysqlitereader);

                    }
                }).ContinueWith((t) =>
                {
                    MessageBox.Show("Ghi thành công bảng danh mục mẫu 20a!");
                }, System.Threading.CancellationToken.None, TaskContinuationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
                
            }
        }
        #endregion

        #region Function DM Mẫu 19a
        private void themVaoCSDLxmlMau19a_BULKCOPY()
        {
            for (int i = 0; i < _FileNames.Count; i++)
            {
                string _FileName = _FileNames[i];

                string tenTable = "bhyt19a";
                string tenTableImport = "bhyt19a";
                string chuoiColumn = "id, "
                    + "KY_QT, "
                    + "MA_TINH, "
                    + "TEN_TINH, "
                    + "COSOKCB_ID, "
                    + "MA_CSKCB, "
                    + "TEN_CSKCB, "
                    + "HANGBENHVIEN, "
                    + "TUYENCMKT, "
                    + "KIEUBV, "
                    + "TENKIEUBV, "
                    + "LOAIBENHVIEN, "
                    + "MA_VAT_TU, "
                    + "MA_NHOM, "
                    + "TEN_DICH_VU, "
                    + "TEN_THUONG_MAI, "
                    + "QUYCACH, "
                    + "DONVITINH, "
                    + "SL_NGOAI_TRU, "
                    + "SL_NOI_TRU, "
                    + "SO_LUONG, "
                    + "DON_GIA_BV, "
                    + "DON_GIA_BHYT, "
                    + "TYLE_TT, "
                    + "THANH_TIEN";
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
                taoTable_dmMau19a(tenTable);

                string myconnection = "Data Source =" + _FileName;
                SQLiteConnection mysqliteconn = new SQLiteConnection(myconnection);
                SQLiteDataReader mysqlitereader;
                SQLiteCommand SelectCommand = new SQLiteCommand("SELECT " + chuoiColumn + " FROM " + tenTableImport, mysqliteconn);
                mysqliteconn.Open();
                
                mysqlitereader = SelectCommand.ExecuteReader();
                Task.Factory.StartNew(() =>
                {
                    using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(conn))
                    {


                        sqlBulkCopy.NotifyAfter = 5000;
                        sqlBulkCopy.BulkCopyTimeout = 0;

                        sqlBulkCopy.DestinationTableName = tenTable;

                        sqlBulkCopy.WriteToServer(mysqlitereader);

                    }
                }).ContinueWith((t) =>
                {
                    MessageBox.Show("Ghi thành công bảng danh mục mẫu 19a!");
                }, System.Threading.CancellationToken.None, TaskContinuationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
                
            }
        }

        private void themVaoCSDLxmlMau19a_KQT_BULKCOPY()
        {
            for (int i = 0; i < _FileNames.Count; i++)
            {
                string _FileName = _FileNames[i];

                string tenTable = "bhyt19a";
                string tenTableImport = "bhyt19a";
                string chuoiColumn = "id, "
                    + "KY_QT, "
                    + "MA_TINH, "
                    + "TEN_TINH, "
                    + "COSOKCB_ID, "
                    + "MA_CSKCB, "
                    + "TEN_CSKCB, "
                    + "HANGBENHVIEN, "
                    + "TUYENCMKT, "
                    + "KIEUBV, "
                    + "TENKIEUBV, "
                    + "LOAIBENHVIEN, "
                    + "MA_VAT_TU, "
                    + "MA_NHOM, "
                    + "TEN_DICH_VU, "
                    + "TEN_THUONG_MAI, "
                    + "QUYCACH, "
                    + "DONVITINH, "
                    + "SL_NGOAI_TRU, "
                    + "SL_NOI_TRU, "
                    + "SO_LUONG, "
                    + "DON_GIA_BV, "
                    + "DON_GIA_BHYT, "
                    + "TYLE_TT, "
                    + "THANH_TIEN";
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
                taoTable_dmMau19a(tenTable);

                string myconnection = "Data Source =" + _FileName;
                SQLiteConnection mysqliteconn = new SQLiteConnection(myconnection);
                SQLiteDataReader mysqlitereader;

                string _ngayBatDau = this.tbThoiGianBatDau.Text;
                string _ngayKetThuc = this.tbThoiGianKetThuc.Text;
                string _menhDeWhereKyQuyetToan = "KY_QT BETWEEN " + _ngayBatDau + " AND " + _ngayKetThuc;
                SQLiteCommand SelectCommand = new SQLiteCommand("SELECT " + chuoiColumn + " FROM " + tenTableImport + " WHERE " + _menhDeWhereKyQuyetToan, mysqliteconn);

                mysqliteconn.Open();

               
                mysqlitereader = SelectCommand.ExecuteReader();
                

                Task.Factory.StartNew(() =>
                {
                    using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(conn))
                    {


                        sqlBulkCopy.NotifyAfter = 5000;
                        sqlBulkCopy.BulkCopyTimeout = 0;

                        sqlBulkCopy.DestinationTableName = tenTable;

                        sqlBulkCopy.WriteToServer(mysqlitereader);

                    }
                }).ContinueWith((t) =>
                {
                    MessageBox.Show("Ghi thành công bảng danh mục mẫu 19a!");
                }, System.Threading.CancellationToken.None, TaskContinuationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
               
            }
        }
        #endregion

        #region Function DM Mẫu 14a
        private void themVaoCSDLxmlMau14a_BULKCOPY()
        {
            for (int i = 0; i < _FileNames.Count; i++)
            {
                string _FileName = _FileNames[i];

                string tenTable = "bhyt14a";
                string tenTableImport = "bhyt14a";
                string chuoiColumn = "ID, "
                    + "MA_TINH, "
                    + "TEN_TINH, "
                    + "MA_CSKCB, "
                    + "TEN_CSKCB, "
                    + "COSOKCB_ID, "
                    + "LOAI_KCB, "
                    + "KY_QT, "
                    + "LUOT_DUNG_TUYEN, "
                    + "LUOT_TRAI_TUYEN, "
                    + "LUOT_KCB, "
                    + "T_TONGCHI, "
                    + "T_BHTT, "
                    + "T_BNTT, "
                    + "T_NGUON_KHAC, "
                    + "T_NGOAI_DS, "
                    + "SO_NGAY_DTRI, "
                    + "T_XN, "
                    + "T_CDHA, "
                    + "T_THUOC, "
                    + "T_MAU, "
                    + "T_TTPT, "
                    + "T_VTYT, "
                    + "T_DVKT_TYLE, "
                    + "T_THUOC_TYLE, "
                    + "T_VTYT_TYLE, "
                    + "T_KHAM, "
                    + "T_VCHUYEN, "
                    + "T_GIUONG, "
                    + "QUY_QT, "
                    + "SL_XETNGHIEM, "
                    + "SL_CDHA, "
                    + "SL_THUOC, "
                    + "SL_MAU, "
                    + "SL_TTPT, "
                    + "SL_VTYT, "
                    + "SL_DVKT_TYLE, "
                    + "SL_THUOC_TYLE, "
                    + "SL_VTYT_TYLE, "
                    + "SL_KHAM, "
                    + "SL_GIUONG, "
                    + "SL_VAN_CHUYEN, "
                    + "HANGBV, "
                    + "TUYENBV, "
                    + "LOAIBV, "
                    + "KIEUBV, "
                    + "TENKIEUBV, "
                    + "MA_CHA, "
                    + "LOAIHOPDONG, "
                    + "HANG_DV_TD, "
                    + "HANGTHUOC_TD, "
                    + "HANGVT_TD, "
                    + "TEN_VUNG";

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
                taoTable_dmMau14a(tenTable);

                string myconnection = "Data Source =" + _FileName;
                SQLiteConnection mysqliteconn = new SQLiteConnection(myconnection);
                SQLiteDataReader mysqlitereader;
                SQLiteCommand SelectCommand = new SQLiteCommand("SELECT " + chuoiColumn + " FROM " + tenTableImport, mysqliteconn);
                mysqliteconn.Open();
               
                    mysqlitereader = SelectCommand.ExecuteReader();

                    Task.Factory.StartNew(() =>
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(conn))
                        {


                            sqlBulkCopy.NotifyAfter = 5000;
                            sqlBulkCopy.BulkCopyTimeout = 0;

                            sqlBulkCopy.DestinationTableName = tenTable;

                            sqlBulkCopy.WriteToServer(mysqlitereader);

                        }
                    }).ContinueWith((t) =>
                    {
                        MessageBox.Show("Ghi thành công bảng danh mục mẫu 14a!");
                    }, System.Threading.CancellationToken.None, TaskContinuationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());

               
            }
        }

        private void themVaoCSDLxmlMau14a_KQT_BULKCOPY()
        {
            for (int i = 0; i < _FileNames.Count; i++)
            {
                string _FileName = _FileNames[i];

                string tenTable = "dmmau14a";
                string tenTableImport = "???";
                string chuoiColumn = "ID, "
                    + "MA_TINH, "
                    + "TEN_TINH, "
                    + "MA_CSKCB, "
                    + "TEN_CSKCB, "
                    + "COSOKCB_ID, "
                    + "LOAI_KCB, "
                    + "KY_QT, "
                    + "LUOT_DUNG_TUYEN, "
                    + "LUOT_TRAI_TUYEN, "
                    + "LUOT_KCB, "
                    + "T_TONGCHI, "
                    + "T_BHTT, "
                    + "T_BNTT, "
                    + "T_NGUON_KHAC, "
                    + "T_NGOAI_DS, "
                    + "SO_NGAY_DTRI, "
                    + "T_XN, "
                    + "T_CDHA, "
                    + "T_THUOC, "
                    + "T_MAU, "
                    + "T_TTPT, "
                    + "T_VTYT, "
                    + "T_DVKT_TYLE, "
                    + "T_THUOC_TYLE, "
                    + "T_VTYT_TYLE, "
                    + "T_KHAM, "
                    + "T_VCHUYEN, "
                    + "T_GIUONG, "
                    + "QUY_QT, "
                    + "SL_XETNGHIEM, "
                    + "SL_CDHA, "
                    + "SL_THUOC, "
                    + "SL_MAU, "
                    + "SL_TTPT, "
                    + "SL_VTYT, "
                    + "SL_DVKT_TYLE, "
                    + "SL_THUOC_TYLE, "
                    + "SL_VTYT_TYLE, "
                    + "SL_KHAM, "
                    + "SL_GIUONG, "
                    + "SL_VAN_CHUYEN, "
                    + "HANGBV, "
                    + "TUYENBV, "
                    + "LOAIBV, "
                    + "KIEUBV, "
                    + "TENKIEUBV, "
                    + "MA_CHA, "
                    + "LOAIHOPDONG, "
                    + "HANG_DV_TD, "
                    + "HANGTHUOC_TD, "
                    + "HANGVT_TD, "
                    + "TEN_VUNG";

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
                taoTable_dmMau14a(tenTable);

                string myconnection = "Data Source =" + _FileName;
                SQLiteConnection mysqliteconn = new SQLiteConnection(myconnection);
                SQLiteDataReader mysqlitereader;

                string _ngayBatDau = this.tbThoiGianBatDau.Text;
                string _ngayKetThuc = this.tbThoiGianKetThuc.Text;
                string _menhDeWhereKyQuyetToan = "KY_QT BETWEEN " + _ngayBatDau + " AND " + _ngayKetThuc;
                SQLiteCommand SelectCommand = new SQLiteCommand("SELECT " + chuoiColumn + " FROM " + tenTableImport + " WHERE " + _menhDeWhereKyQuyetToan, mysqliteconn);

                mysqliteconn.Open();
                
                    mysqlitereader = SelectCommand.ExecuteReader();
                    
                    Task.Factory.StartNew(() =>
                    {
                        using (SqlBulkCopy sqlBulkCopy = new SqlBulkCopy(conn))
                        {


                            sqlBulkCopy.NotifyAfter = 5000;
                            sqlBulkCopy.BulkCopyTimeout = 0;

                            sqlBulkCopy.DestinationTableName = tenTable;

                            sqlBulkCopy.WriteToServer(mysqlitereader);

                        }
                    }).ContinueWith((t) =>
                    {
                        MessageBox.Show("Ghi thành công bảng danh mục mẫu 14a!");
                    }, System.Threading.CancellationToken.None, TaskContinuationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());
                
            }
        }
        #endregion

        #region Event Button Click
        private void btnImportXML123_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQLite File (*.db)|*.db|All Files (*.*)|*.*";
            dlg.Multiselect = true; //Chỗ này nè
            _FileNames.Clear();
            _SafeFileNames.Clear();

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                foreach (string str in dlg.FileNames)
                {
                    _FileNames.Add(str);
                }
                foreach (string str in dlg.SafeFileNames)
                {
                    //MessageBox.Show(str.Substring(0, 5));
                    _SafeFileNames.Add(str.Substring(0, 5));
                }


                MessageBox.Show("Chờ thông báo quá trình ghi dữ liệu!");

                themVaoCSDLxml123_BULKCOPY();
            }
        }

        private void btnImportMau14a_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQLite File (*.db)|*.db|All Files (*.*)|*.*";

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                _FileNames.Clear();
                _SafeFileNames.Clear();
                _FileNames.Add(dlg.FileName);
                _SafeFileNames.Add(dlg.SafeFileName);

                MessageBox.Show("Chờ thông báo quá trình ghi dữ liệu!");

                themVaoCSDLxmlMau14a_BULKCOPY();
            }

        }

        private void btnImportMau19a_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQLite File (*.db)|*.db|All Files (*.*)|*.*";

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                _FileNames.Clear();
                _SafeFileNames.Clear();
                _FileNames.Add(dlg.FileName);
                _SafeFileNames.Add(dlg.SafeFileName);
                MessageBox.Show("Chờ thông báo quá trình ghi dữ liệu!");

                themVaoCSDLxmlMau19a_BULKCOPY();
            }
        }

        private void btnImportMau20a_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQLite File (*.db)|*.db|All Files (*.*)|*.*";

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                _FileNames.Clear();
                _SafeFileNames.Clear();
                _FileNames.Add(dlg.FileName);
                _SafeFileNames.Add(dlg.SafeFileName);


                MessageBox.Show("Chờ thông báo quá trình ghi dữ liệu!");

                themVaoCSDLxmlMau20a_BULKCOPY();
            }
        }

        private void btnImportMau21a_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQLite File (*.db)|*.db|All Files (*.*)|*.*";

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                _FileNames.Clear();
                _SafeFileNames.Clear();
                _FileNames.Add(dlg.FileName);
                _SafeFileNames.Add(dlg.SafeFileName);
                
                MessageBox.Show("Chờ thông báo quá trình ghi dữ liệu!");
                themVaoCSDLxmlMau21a_BULKCOPY();
            }
        }

        private void btnImportMau7980a_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQLite File (*.db)|*.db|All Files (*.*)|*.*";

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                _FileNames.Clear();
                _SafeFileNames.Clear();
                _FileNames.Add(dlg.FileName);
                _SafeFileNames.Add(dlg.SafeFileName);

                MessageBox.Show("Chờ thông báo quá trình ghi dữ liệu!");
                themVaoCSDLxmlMau7980a_BULKCOPY();
            }
        }

        private void btnImportDMNgay_Click(object sender, EventArgs e)
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
                themVaoCSDLxmlNgay_BULKCOPY();
            }
        }
        private void btnImportDMPTTT_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Excel File (*.xls, *.xlsx)|*.xls; *.xlsx|All Files (*.*)|*.*";

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                _FileNames.Clear();
                _SafeFileNames.Clear();
                _FileNames.Add(dlg.FileName);
                _SafeFileNames.Add(dlg.SafeFileName);
            }

            MessageBox.Show("Chờ thông báo quá trình ghi dữ liệu!");

            themVaoCSDLxmlPhauThuatThuThuat_BULKCOPY();
        }

        private void btnImportDMThuocVuotTuyen_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "Excel File (*.xls, *.xlsx)|*.xls; *.xlsx|All Files (*.*)|*.*";

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                _FileNames.Clear();
                _SafeFileNames.Clear();
                _FileNames.Add(dlg.FileName);
                _SafeFileNames.Add(dlg.SafeFileName);
            }

            MessageBox.Show("Chờ thông báo quá trình ghi dữ liệu!");

            themVaoCSDLxmlThuocVuotTuyen_BULKCOPY();
        }
        private void btnImportXML123_dtdi_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQLite File (*.db)|*.db|All Files (*.*)|*.*";

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                _FileNames.Clear();
                _SafeFileNames.Clear();
                _FileNames.Add(dlg.FileName);
                _SafeFileNames.Add(dlg.SafeFileName);

                MessageBox.Show("Chờ thông báo quá trình ghi dữ liệu!");
                themVaoCSDLxml123_dtdi_BULKCOPY();
            }
        }

        private void btnImportMau7980a_dtdi_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQLite File (*.db)|*.db|All Files (*.*)|*.*";

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                _FileNames.Clear();
                _SafeFileNames.Clear();
                _FileNames.Add(dlg.FileName);
                _SafeFileNames.Add(dlg.SafeFileName);

                MessageBox.Show("Chờ thông báo quá trình ghi dữ liệu!");
                themVaoCSDLxmlMau7980a_dtdi_BULKCOPY();
            }
        }
        #endregion

        #region Event Button Click KQT
        private void btnImportXML123_KQT_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQLite File (*.db)|*.db|All Files (*.*)|*.*";
            dlg.Multiselect = true; //Chỗ này nè

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                _FileNames.Clear();
                _SafeFileNames.Clear();
                foreach (string str in dlg.FileNames)
                {
                    _FileNames.Add(str);
                }
                foreach (string str in dlg.SafeFileNames)
                {

                    _SafeFileNames.Add(str.Substring(0, 5));
                }



                MessageBox.Show("Chờ thông báo quá trình ghi dữ liệu!");

                themVaoCSDLxml123_BULKCOPY_KQT();
            }
        }

        private void btnImportMau14a_KQT_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQLite File (*.db)|*.db|All Files (*.*)|*.*";

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                _FileNames.Clear();
                _SafeFileNames.Clear();
                _FileNames.Add(dlg.FileName);
                _SafeFileNames.Add(dlg.SafeFileName);


                MessageBox.Show("Chờ thông báo quá trình ghi dữ liệu!");

                themVaoCSDLxmlMau14a_KQT_BULKCOPY();
            }
        }

        private void btnImportMau19a_KQT_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQLite File (*.db)|*.db|All Files (*.*)|*.*";

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                _FileNames.Clear();
                _SafeFileNames.Clear();
                _FileNames.Add(dlg.FileName);
                _SafeFileNames.Add(dlg.SafeFileName);


                MessageBox.Show("Chờ thông báo quá trình ghi dữ liệu!");

                themVaoCSDLxmlMau19a_KQT_BULKCOPY();
            }
        }

        private void btnImportMau20a_KQT_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQLite File (*.db)|*.db|All Files (*.*)|*.*";

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                _FileNames.Clear();
                _SafeFileNames.Clear();
                _FileNames.Add(dlg.FileName);
                _SafeFileNames.Add(dlg.SafeFileName);


                MessageBox.Show("Chờ thông báo quá trình ghi dữ liệu!");

                themVaoCSDLxmlMau20a_KQT_BULKCOPY();
            }
        }

        private void btnImportMau21a_KQT_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQLite File (*.db)|*.db|All Files (*.*)|*.*";

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                _FileNames.Clear();
                _SafeFileNames.Clear();
                _FileNames.Add(dlg.FileName);
                _SafeFileNames.Add(dlg.SafeFileName);


                MessageBox.Show("Chờ thông báo quá trình ghi dữ liệu!");

                themVaoCSDLxmlMau21a_KQT_BULKCOPY();
            }
        }

        private void btnImportMau7980a_KQT_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQLite File (*.db)|*.db|All Files (*.*)|*.*";

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                _FileNames.Clear();
                _SafeFileNames.Clear();
                _FileNames.Add(dlg.FileName);
                _SafeFileNames.Add(dlg.SafeFileName);


                MessageBox.Show("Chờ thông báo quá trình ghi dữ liệu!");

                themVaoCSDLxmlMau7980a_KQT_BULKCOPY();
            }
        }
        #endregion

        
    }
}