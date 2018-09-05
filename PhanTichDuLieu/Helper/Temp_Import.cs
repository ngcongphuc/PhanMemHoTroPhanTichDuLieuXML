using System;
using System.Data;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Threading.Tasks;

namespace PhanTichDuLieu
{
    public partial class Temp_Import : DevExpress.XtraEditors.XtraForm
    {
        private List<string> _FileNames = new List<string>();
        private List<string> _SafeFileNames = new List<string>();

        #region Khởi tạo Database
        public void taoTable(string maCSKCB)
        {
            string tenProcedure = "Insert_xml123_" + maCSKCB;
            string tenTable = "xml123_" + maCSKCB;
            string tenType = "udt_xml123_" + maCSKCB;

            string query = "CREATE TABLE " + tenTable + "(ID nvarchar(MAX),XML1_ID nvarchar(MAX),Ky_QT nvarchar(MAX),CoSoKCB_ID nvarchar(MAX),Ma_CSKCB nvarchar(MAX),"
             + "Ma_LK nvarchar(MAX),MA_BN nvarchar(MAX),Ho_Ten nvarchar(MAX),Ngay_Sinh nvarchar(MAX),Gioi_Tinh nvarchar(MAX),Ma_The nvarchar(MAX),Ma_DKBD nvarchar(MAX),Ngay_Vao nvarchar(MAX),"
             + "Ngay_Ra nvarchar(MAX),So_Ngay_DTri nvarchar(MAX),Ma_LyDo_VVien nvarchar(MAX),Ma_Benh nvarchar(MAX),Ma_BenhKhac nvarchar(MAX),T_TongChi nvarchar(MAX),T_BNTT nvarchar(MAX),T_BHTT nvarchar(MAX),"
             + "T_XN nvarchar(MAX),T_CDHA nvarchar(MAX), T_Thuoc nvarchar(MAX),T_Mau nvarchar(MAX),T_TTPT nvarchar(MAX),T_VTYT nvarchar(MAX),T_DVKT_TyLe nvarchar(MAX),T_Thuoc_TyLe nvarchar(MAX),T_VTYT_TyLe nvarchar(MAX),"
             + "T_Kham nvarchar(MAX),T_Giuong nvarchar(MAX),T_VChuyen nvarchar(MAX),T_NgoaiDS nvarchar(MAX),T_NguonKhac nvarchar(MAX),Ma_Loai_KCB nvarchar(MAX),ID_CP nvarchar(MAX),Loai_CP nvarchar(MAX),Ma_CP nvarchar(MAX),"
             + "Ma_Vat_Tu nvarchar(MAX),Ma_Nhom nvarchar(MAX),Ten_CP nvarchar(MAX),DVT nvarchar(MAX),So_Dang_Ky nvarchar(MAX),Ham_Luong nvarchar(MAX),Duong_Dung nvarchar(MAX),So_Luong nvarchar(MAX),"
             + "So_Luong_BV nvarchar(MAX),Don_Gia nvarchar(MAX),Don_Gia_BV nvarchar(MAX),Thanh_Tien nvarchar(MAX),TyLe_TT nvarchar(MAX),Ngay_YL nvarchar(MAX),Ten_Khoa nvarchar(MAX),"
             + "Ma_Khoa nvarchar(MAX),Ma_Khoa_XML1 nvarchar(MAX),Ten_Khoa_XML1 nvarchar(MAX),Ten_Benh nvarchar(MAX),Ma_Bac_Si nvarchar(MAX),Ma_Tinh nvarchar(MAX),Ma_Tinh_The nvarchar(MAX),GT_The_Tu nvarchar(MAX),"
             + "GT_The_Den nvarchar(MAX),Mien_Cung_CT nvarchar(MAX),Muc_Huong_XML1 nvarchar(MAX),T_BNCCT nvarchar(MAX),Ngay_KQ nvarchar(MAX),T_NguonKhac_DTL nvarchar(MAX),T_BNTT_DTL nvarchar(MAX),"
             + "T_BHTT_DTL nvarchar(MAX),T_BNCCT_DTL nvarchar(MAX),T_NgoaiDS_DTL nvarchar(MAX),Muc_Huong_DTL nvarchar(MAX),TT_Thau nvarchar(MAX),Pham_Vi nvarchar(MAX),Ma_Giuong nvarchar(MAX),"
             + "T_TranTT nvarchar(MAX),Goi_VTYT nvarchar(MAX),Ten_Vat_Tu nvarchar(MAX));";

            query = "CREATE TABLE " + tenTable + "(ID nvarchar(MAX),XML1_ID nvarchar(MAX),Ky_QT nvarchar(MAX),CoSoKCB_ID nvarchar(MAX),Ma_CSKCB nvarchar(MAX),"
             + "Ma_LK nvarchar(MAX),MA_BN nvarchar(MAX),Ho_Ten nvarchar(MAX),Ngay_Sinh nvarchar(MAX),Gioi_Tinh nvarchar(MAX),Ma_The nvarchar(MAX),Ma_DKBD nvarchar(MAX),"
             + "GT_The_Tu nvarchar(MAX),GT_The_Den nvarchar(MAX),Mien_Cung_CT nvarchar(MAX),Ngay_Vao nvarchar(MAX),Ngay_Ra nvarchar(MAX),So_Ngay_DTri nvarchar(MAX),Ma_LyDo_VVien nvarchar(MAX),Ma_Benh nvarchar(MAX),Ma_BenhKhac nvarchar(MAX),Muc_Huong_XML1 nvarchar(MAX),T_TongChi nvarchar(MAX),T_BNTT nvarchar(MAX),T_BHTT nvarchar(MAX),T_BNCCT nvarchar(MAX),"
             + "T_XN nvarchar(MAX),T_CDHA nvarchar(MAX), T_Thuoc nvarchar(MAX),T_Mau nvarchar(MAX),T_TTPT nvarchar(MAX),T_VTYT nvarchar(MAX),T_DVKT_TyLe nvarchar(MAX),T_Thuoc_TyLe nvarchar(MAX),T_VTYT_TyLe nvarchar(MAX),"
             + "T_Kham nvarchar(MAX),T_Giuong nvarchar(MAX),T_VChuyen nvarchar(MAX),T_NgoaiDS nvarchar(MAX),T_NguonKhac nvarchar(MAX),Ma_Loai_KCB nvarchar(MAX),ID_CP nvarchar(MAX),Loai_CP nvarchar(MAX),Ma_CP nvarchar(MAX),"
             + "Ma_Vat_Tu nvarchar(MAX),Ma_Nhom nvarchar(MAX),Ten_CP nvarchar(MAX),DVT nvarchar(MAX),So_Dang_Ky nvarchar(MAX),Ham_Luong nvarchar(MAX),Duong_Dung nvarchar(MAX),So_Luong nvarchar(MAX),"
             + "So_Luong_BV nvarchar(MAX),Don_Gia nvarchar(MAX),Don_Gia_BV nvarchar(MAX),Thanh_Tien nvarchar(MAX),TyLe_TT nvarchar(MAX),Ngay_YL nvarchar(MAX),"
             + "Ngay_KQ nvarchar(MAX),T_NguonKhac_DTL nvarchar(MAX),T_BNTT_DTL nvarchar(MAX),"
             + "T_BHTT_DTL nvarchar(MAX),T_BNCCT_DTL nvarchar(MAX),T_NgoaiDS_DTL nvarchar(MAX),Muc_Huong_DTL nvarchar(MAX),TT_Thau nvarchar(MAX),Pham_Vi nvarchar(MAX),Ma_Giuong nvarchar(MAX),"
             + "T_TranTT nvarchar(MAX),Goi_VTYT nvarchar(MAX),Ten_Vat_Tu nvarchar(MAX),"
             + "Ten_Khoa nvarchar(MAX),Ma_Khoa nvarchar(MAX),Ma_Khoa_XML1 nvarchar(MAX),Ten_Khoa_XML1 nvarchar(MAX),Ten_Benh nvarchar(MAX),Ma_Bac_Si nvarchar(MAX),Ma_Tinh nvarchar(MAX),Ma_Tinh_The nvarchar(MAX))";




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

        public void taoTable_2(string maCSKCB)
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
             + "Ten_Khoa nvarchar(100),Ma_Khoa nvarchar(20),Ma_Khoa_XML1 nvarchar(20),Ten_Khoa_XML1 nvarchar(300),Ten_Benh nvarchar(300),Ma_Bac_Si nvarchar(20),Ma_Tinh nvarchar(5),Ma_Tinh_The nvarchar(5))";




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

        public void taoType(string maCSKCB)
        {

            string tenProcedure = "Insert_xml123_" + maCSKCB;
            string tenTable = "xml123_" + maCSKCB;
            string tenType = "udt_xml123_" + maCSKCB;

            string query = "CREATE TYPE " + tenType + " AS TABLE([ID] nvarchar(MAX) NULL,[XML1_ID] nvarchar(MAX) NULL,[Ky_QT] nvarchar(MAX) NULL,[CoSoKCB_ID] nvarchar(MAX)  NULL,[Ma_CSKCB] nvarchar(MAX) NULL,"
             + "[Ma_LK] nvarchar(MAX) NULL,[MA_BN] nvarchar(MAX) NULL,[Ho_Ten] nvarchar(MAX) NULL,[Ngay_Sinh] nvarchar(MAX) NULL,[Gioi_Tinh] nvarchar(MAX) NULL,[Ma_The] nvarchar(MAX) NULL,[Ma_DKBD] nvarchar(MAX) NULL,[Ngay_Vao] nvarchar(MAX) NULL,"
             + "[Ngay_Ra] nvarchar(MAX) NULL,[So_Ngay_DTri] nvarchar(MAX) NULL,[Ma_LyDo_VVien] nvarchar(MAX) NULL,[Ma_Benh] nvarchar(MAX) NULL,[Ma_BenhKhac] nvarchar(MAX) NULL,[T_TongChi] nvarchar(MAX) NULL,[T_BNTT] nvarchar(MAX) NULL,[T_BHTT] nvarchar(MAX) NULL,"
             + "[T_XN] nvarchar(MAX) NULL,[T_CDHA] nvarchar(MAX) NULL,[T_Thuoc] nvarchar(MAX) NULL,[T_Mau] nvarchar(MAX) NULL,[T_TTPT] nvarchar(MAX) NULL,[T_VTYT] nvarchar(MAX) NULL,[T_DVKT_TyLe] nvarchar(MAX) NULL, [T_Thuoc_TyLe] nvarchar(MAX) NULL,[T_VTYT_TyLe] nvarchar(MAX) NULL,"
             + "[T_Kham] nvarchar(MAX) NULL,[T_Giuong] nvarchar(MAX) NULL,[T_VChuyen] nvarchar(MAX) NULL,[T_NgoaiDS] nvarchar(MAX) NULL,[T_NguonKhac] nvarchar(MAX) NULL, [Ma_Loai_KCB] nvarchar(MAX) NULL,[ID_CP] nvarchar(MAX) NULL,[Loai_CP] nvarchar(MAX) NULL,[Ma_CP] nvarchar(MAX) NULL,"
             + "[Ma_Vat_Tu] nvarchar(MAX) NULL, [Ma_Nhom] nvarchar(MAX) NULL,[Ten_CP] nvarchar(MAX) NULL,[DVT] nvarchar(MAX) NULL,[So_Dang_Ky] nvarchar(MAX) NULL, [Ham_Luong] nvarchar(MAX) NULL,[Duong_Dung] nvarchar(MAX) NULL,[So_Luong] nvarchar(MAX) NULL,"
             + "[So_Luong_BV] nvarchar(MAX) NULL,[Don_Gia] nvarchar(MAX) NULL,[Don_Gia_BV] nvarchar(MAX) NULL,[Thanh_Tien] nvarchar(MAX) NULL,[TyLe_TT] nvarchar(MAX) NULL,[Ngay_YL] nvarchar(MAX) NULL,[Ten_Khoa] nvarchar(MAX) NULL,"
             + "[Ma_Khoa] nvarchar(MAX) NULL,[Ma_Khoa_XML1] nvarchar(MAX) NULL,[Ten_Khoa_XML1] nvarchar(MAX) NULL,[Ten_Benh] nvarchar(MAX) NULL,[Ma_Bac_Si] nvarchar(MAX) NULL,[Ma_Tinh] nvarchar(MAX) NULL,[Ma_Tinh_The] nvarchar(MAX) NULL,[GT_The_Tu] nvarchar(MAX) NULL,"
             + "[GT_The_Den] nvarchar(MAX) NULL,[Mien_Cung_CT] nvarchar(MAX) NULL,[Muc_Huong_XML1] nvarchar(MAX) NULL,[T_BNCCT] nvarchar(MAX) NULL, [Ngay_KQ] nvarchar(MAX) NULL, [T_NguonKhac_DTL] nvarchar(MAX) NULL,"
             + "[T_BNTT_DTL] nvarchar(MAX) NULL,[T_BHTT_DTL] nvarchar(MAX) NULL,[T_BNCCT_DTL] nvarchar(MAX) NULL,[T_NgoaiDS_DTL] nvarchar(MAX) NULL,[Muc_Huong_DTL] nvarchar(MAX) NULL,[TT_Thau] nvarchar(MAX) NULL,[Pham_Vi] nvarchar(MAX) NULL,[Ma_Giuong] nvarchar(MAX) NULL,"
             + "[T_TranTT] nvarchar(MAX) NULL,[Goi_VTYT] nvarchar(MAX) NULL,[Ten_Vat_Tu] nvarchar(MAX) NULL)";

            query = "CREATE TYPE " + tenType + " AS TABLE([ID] nvarchar(MAX) NULL,[XML1_ID] nvarchar(MAX) NULL,[Ky_QT] nvarchar(MAX) NULL,[CoSoKCB_ID] nvarchar(MAX)  NULL,[Ma_CSKCB] nvarchar(MAX) NULL,"
             + "[Ma_LK] nvarchar(MAX) NULL,[MA_BN] nvarchar(MAX) NULL,[Ho_Ten] nvarchar(MAX) NULL,[Ngay_Sinh] nvarchar(MAX) NULL,[Gioi_Tinh] nvarchar(MAX) NULL,[Ma_The] nvarchar(MAX) NULL,[Ma_DKBD] nvarchar(MAX) NULL,[GT_The_Tu] nvarchar(MAX) NULL,[GT_The_Den] nvarchar(MAX) NULL,[Mien_Cung_CT] nvarchar(MAX) NULL,"
             + "[Ngay_Vao] nvarchar(MAX) NULL, [Ngay_Ra] nvarchar(MAX) NULL,[So_Ngay_DTri] nvarchar(MAX) NULL,[Ma_LyDo_VVien] nvarchar(MAX) NULL,[Ma_Benh] nvarchar(MAX) NULL,[Ma_BenhKhac] nvarchar(MAX) NULL,[Muc_Huong_XML1] nvarchar(MAX) NULL,[T_TongChi] nvarchar(MAX) NULL,[T_BNTT] nvarchar(MAX) NULL,[T_BHTT] nvarchar(MAX) NULL,[T_BNCCT] nvarchar(MAX) NULL,"
             + "[T_XN] nvarchar(MAX) NULL,[T_CDHA] nvarchar(MAX) NULL,[T_Thuoc] nvarchar(MAX) NULL,[T_Mau] nvarchar(MAX) NULL,[T_TTPT] nvarchar(MAX) NULL,[T_VTYT] nvarchar(MAX) NULL,[T_DVKT_TyLe] nvarchar(MAX) NULL, [T_Thuoc_TyLe] nvarchar(MAX) NULL,[T_VTYT_TyLe] nvarchar(MAX) NULL,"
             + "[T_Kham] nvarchar(MAX) NULL,[T_Giuong] nvarchar(MAX) NULL,[T_VChuyen] nvarchar(MAX) NULL,[T_NgoaiDS] nvarchar(MAX) NULL,[T_NguonKhac] nvarchar(MAX) NULL, [Ma_Loai_KCB] nvarchar(MAX) NULL,[ID_CP] nvarchar(MAX) NULL,[Loai_CP] nvarchar(MAX) NULL,[Ma_CP] nvarchar(MAX) NULL,"
             + "[Ma_Vat_Tu] nvarchar(MAX) NULL, [Ma_Nhom] nvarchar(MAX) NULL,[Ten_CP] nvarchar(MAX) NULL,[DVT] nvarchar(MAX) NULL,[So_Dang_Ky] nvarchar(MAX) NULL, [Ham_Luong] nvarchar(MAX) NULL,[Duong_Dung] nvarchar(MAX) NULL,[So_Luong] nvarchar(MAX) NULL,"
             + "[So_Luong_BV] nvarchar(MAX) NULL,[Don_Gia] nvarchar(MAX) NULL,[Don_Gia_BV] nvarchar(MAX) NULL,[Thanh_Tien] nvarchar(MAX) NULL,[TyLe_TT] nvarchar(MAX) NULL,[Ngay_YL] nvarchar(MAX) NULL,"
             + "[Ngay_KQ] nvarchar(MAX) NULL, [T_NguonKhac_DTL] nvarchar(MAX) NULL,"
             + "[T_BNTT_DTL] nvarchar(MAX) NULL,[T_BHTT_DTL] nvarchar(MAX) NULL,[T_BNCCT_DTL] nvarchar(MAX) NULL,[T_NgoaiDS_DTL] nvarchar(MAX) NULL,[Muc_Huong_DTL] nvarchar(MAX) NULL,[TT_Thau] nvarchar(MAX) NULL,[Pham_Vi] nvarchar(MAX) NULL,[Ma_Giuong] nvarchar(MAX) NULL,"
             + "[T_TranTT] nvarchar(MAX) NULL,[Goi_VTYT] nvarchar(MAX) NULL,[Ten_Vat_Tu] nvarchar(MAX) NULL,"
             + "[Ten_Khoa] nvarchar(MAX) NULL,[Ma_Khoa] nvarchar(MAX) NULL,[Ma_Khoa_XML1] nvarchar(MAX) NULL,[Ten_Khoa_XML1] nvarchar(MAX) NULL,[Ten_Benh] nvarchar(MAX) NULL,[Ma_Bac_Si] nvarchar(MAX) NULL,[Ma_Tinh] nvarchar(MAX) NULL,[Ma_Tinh_The] nvarchar(MAX) NULL)";


            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                if (DBUtils.ExecuteNonQuery(query, conn) > 0)
                {
                    //MessageBox.Show("Tạo Type Thành Công");
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
        }

        public void taoProcedure_2(string maCSKCB)
        {

            string tenProcedure = "Insert_xml123_" + maCSKCB;
            string tenTable = "xml123_" + maCSKCB;
            string tenType = "udt_xml123_" + maCSKCB;

            string query = "CREATE PROCEDURE " + tenProcedure + " "
                + "@ID nvarchar(MAX)='',@XML1_ID nvarchar(MAX)='',@Ky_QT nvarchar(MAX)='',@CoSoKCB_ID nvarchar(MAX) ='',@Ma_CSKCB nvarchar(MAX)='',"
                + "@Ma_LK nvarchar(MAX)='',@MA_BN nvarchar(MAX)='',@Ho_Ten nvarchar(MAX)='',@Ngay_Sinh nvarchar(MAX)='',@Gioi_Tinh nvarchar(MAX)='',@Ma_The nvarchar(MAX)='',@Ma_DKBD nvarchar(MAX)='',@Ngay_Vao nvarchar(MAX)='',"
                + "@Ngay_Ra nvarchar(MAX)='',@So_Ngay_DTri nvarchar(MAX)='',@Ma_LyDo_VVien nvarchar(MAX)='',@Ma_Benh nvarchar(MAX)='',@Ma_BenhKhac nvarchar(MAX)='',@T_TongChi nvarchar(MAX)='',@T_BNTT nvarchar(MAX)='',@T_BHTT nvarchar(MAX)='',"
                + "@T_XN nvarchar(MAX)='',@T_CDHA nvarchar(MAX)='',@T_Thuoc nvarchar(MAX)='',@T_Mau nvarchar(MAX)='',@T_TTPT nvarchar(MAX)='',@T_VTYT nvarchar(MAX)='',@T_DVKT_TyLe nvarchar(MAX)='', @T_Thuoc_TyLe nvarchar(MAX)='',@T_VTYT_TyLe nvarchar(MAX)='',"
                + "@T_Kham nvarchar(MAX)='',@T_Giuong nvarchar(MAX)='',@T_VChuyen nvarchar(MAX)='',@T_NgoaiDS nvarchar(MAX)='',@T_NguonKhac nvarchar(MAX)='', @Ma_Loai_KCB nvarchar(MAX)='',@ID_CP nvarchar(MAX)='',@Loai_CP nvarchar(MAX)='',@Ma_CP nvarchar(MAX)='',"
                + "@Ma_Vat_Tu nvarchar(MAX)='', @Ma_Nhom nvarchar(MAX)='',@Ten_CP nvarchar(MAX)='',@DVT nvarchar(MAX)='',@So_Dang_Ky nvarchar(MAX)='', @Ham_Luong nvarchar(MAX)='',@Duong_Dung nvarchar(MAX)='',@So_Luong nvarchar(MAX)='',"
                + "@So_Luong_BV nvarchar(MAX)='',@Don_Gia nvarchar(MAX)='',@Don_Gia_BV nvarchar(MAX)='',@Thanh_Tien nvarchar(MAX)='',@TyLe_TT nvarchar(MAX)='',@Ngay_YL nvarchar(MAX)='',@Ten_Khoa nvarchar(MAX)='',"
                + "@Ma_Khoa nvarchar(MAX)='',@Ma_Khoa_XML1 nvarchar(MAX)='',@Ten_Khoa_XML1 nvarchar(MAX)='',@Ten_Benh nvarchar(MAX)='',@Ma_Bac_Si nvarchar(MAX)='',@Ma_Tinh nvarchar(MAX)='',@Ma_Tinh_The nvarchar(MAX)='',@GT_The_Tu nvarchar(MAX)='',"
                + "@GT_The_Den nvarchar(MAX)='',@Mien_Cung_CT nvarchar(MAX)='',@Muc_Huong_XML1 nvarchar(MAX)='',@T_BNCCT nvarchar(MAX)='', @Ngay_KQ nvarchar(MAX)='', @T_NguonKhac_DTL nvarchar(MAX)='',"
                + "@T_BNTT_DTL nvarchar(MAX)='',@T_BHTT_DTL nvarchar(MAX)='',@T_BNCCT_DTL nvarchar(MAX)='',@T_NgoaiDS_DTL nvarchar(MAX)='',@Muc_Huong_DTL nvarchar(MAX)='',@TT_Thau nvarchar(MAX)='',@Pham_Vi nvarchar(MAX)='',@Ma_Giuong nvarchar(MAX)='',"
                + "@T_TranTT nvarchar(MAX)='',@Goi_VTYT nvarchar(MAX)='',@Ten_Vat_Tu nvarchar(MAX)='' "
                + "AS "
                + "SET NOCOUNT ON "
                + "INSERT INTO " + tenTable + " "
                + "(ID, XML1_ID, Ky_QT, CoSoKCB_ID, Ma_CSKCB, Ma_LK, MA_BN, Ho_Ten, Ngay_Sinh, Gioi_Tinh, Ma_The, Ma_DKBD, GT_The_Tu, GT_The_Den, Mien_Cung_CT, Ngay_Vao, Ngay_Ra, So_Ngay_DTri, Ma_LyDo_VVien, Ma_Benh, Ma_BenhKhac, Muc_Huong_XML1, T_TongChi, T_BNTT, T_BHTT, T_BNCCT, T_XN, T_CDHA, T_Thuoc, T_Mau, T_TTPT, T_VTYT, T_DVKT_TyLe, T_Thuoc_TyLe, T_VTYT_TyLe, T_Kham, T_Giuong, T_VChuyen, T_NgoaiDS, T_NguonKhac, Ma_Loai_KCB, ID_CP, Loai_CP, Ma_CP, Ma_Vat_Tu, Ma_Nhom, Ten_CP, DVT, So_Dang_Ky, Ham_Luong, Duong_Dung, So_Luong, So_Luong_BV, Don_Gia, Don_Gia_BV, Thanh_Tien, TyLe_TT, Ngay_YL, Ngay_KQ, T_NguonKhac_DTL, T_BNTT_DTL, T_BHTT_DTL, T_BNCCT_DTL, T_NgoaiDS_DTL, Muc_Huong_DTL, TT_Thau, Pham_Vi, Ma_Giuong, T_TranTT, Goi_VTYT, Ten_Vat_Tu, Ten_Khoa, Ma_Khoa, Ma_Khoa_XML1, Ten_Khoa_XML1, Ten_Benh, Ma_Bac_Si, Ma_Tinh, Ma_Tinh_The) "
                + "VALUES "
                + "(@ID, @XML1_ID, @Ky_QT, @CoSoKCB_ID, @Ma_CSKCB, @Ma_LK, @MA_BN, @Ho_Ten, @Ngay_Sinh, @Gioi_Tinh, @Ma_The, @Ma_DKBD, @GT_The_Tu, @GT_The_Den, @Mien_Cung_CT, @Ngay_Vao, @Ngay_Ra, @So_Ngay_DTri, @Ma_LyDo_VVien, @Ma_Benh, @Ma_BenhKhac, @Muc_Huong_XML1, @T_TongChi, @T_BNTT, @T_BHTT, @T_BNCCT, @T_XN, @T_CDHA, @T_Thuoc, @T_Mau, @T_TTPT, @T_VTYT, @T_DVKT_TyLe, @T_Thuoc_TyLe, @T_VTYT_TyLe, @T_Kham, @T_Giuong, @T_VChuyen, @T_NgoaiDS, @T_NguonKhac, @Ma_Loai_KCB, @ID_CP, @Loai_CP, @Ma_CP, @Ma_Vat_Tu, @Ma_Nhom, @Ten_CP, @DVT, @So_Dang_Ky, @Ham_Luong, @Duong_Dung, @So_Luong, @So_Luong_BV, @Don_Gia, @Don_Gia_BV, @Thanh_Tien, @TyLe_TT, @Ngay_YL, @Ngay_KQ, @T_NguonKhac_DTL, @T_BNTT_DTL, @T_BHTT_DTL, @T_BNCCT_DTL, @T_NgoaiDS_DTL, @Muc_Huong_DTL, @TT_Thau, @Pham_Vi, @Ma_Giuong, @T_TranTT, @Goi_VTYT, @Ten_Vat_Tu, @Ten_Khoa, @Ma_Khoa, @Ma_Khoa_XML1, @Ten_Khoa_XML1, @Ten_Benh, @Ma_Bac_Si, @Ma_Tinh, @Ma_Tinh_The) ";


            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                if (DBUtils.ExecuteNonQuery(query, conn) > 0)
                {
                    //MessageBox.Show("Tạo Procedure Thành Công");
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
        }

        public void taoProcedure(string maCSKCB)
        {
            string tenProcedure = "Insert_xml123_" + maCSKCB;
            string tenTable = "xml123_" + maCSKCB;
            string tenType = "udt_xml123_" + maCSKCB;

            string query = "CREATE PROCEDURE " + tenProcedure + " "
            + "@xml123 " + tenType + " READONLY "
            + "AS "
            + "BEGIN "
            + "INSERT INTO " + tenTable + " "
            + "(ID, XML1_ID, Ky_QT, CoSoKCB_ID, Ma_CSKCB, Ma_LK, MA_BN, Ho_Ten, Ngay_Sinh, Gioi_Tinh, Ma_The, Ma_DKBD, GT_The_Tu, GT_The_Den, Mien_Cung_CT, Ngay_Vao, Ngay_Ra, So_Ngay_DTri, Ma_LyDo_VVien, Ma_Benh, Ma_BenhKhac, Muc_Huong_XML1, T_TongChi, T_BNTT, T_BHTT, T_BNCCT, T_XN, T_CDHA, T_Thuoc, T_Mau, T_TTPT, T_VTYT, T_DVKT_TyLe, T_Thuoc_TyLe, T_VTYT_TyLe, T_Kham, T_Giuong, T_VChuyen, T_NgoaiDS, T_NguonKhac, Ma_Loai_KCB, ID_CP, Loai_CP, Ma_CP, Ma_Vat_Tu, Ma_Nhom, Ten_CP, DVT, So_Dang_Ky, Ham_Luong, Duong_Dung, So_Luong, So_Luong_BV, Don_Gia, Don_Gia_BV, Thanh_Tien, TyLe_TT, Ngay_YL, Ngay_KQ, T_NguonKhac_DTL, T_BNTT_DTL, T_BHTT_DTL, T_BNCCT_DTL, T_NgoaiDS_DTL, Muc_Huong_DTL, TT_Thau, Pham_Vi, Ma_Giuong, T_TranTT, Goi_VTYT, Ten_Vat_Tu, Ten_Khoa, Ma_Khoa, Ma_Khoa_XML1, Ten_Khoa_XML1, Ten_Benh, Ma_Bac_Si, Ma_Tinh, Ma_Tinh_The) "
            + "SELECT ID, XML1_ID, Ky_QT, CoSoKCB_ID, Ma_CSKCB, Ma_LK, MA_BN, Ho_Ten, Ngay_Sinh, Gioi_Tinh, Ma_The, Ma_DKBD, GT_The_Tu, GT_The_Den, Mien_Cung_CT, Ngay_Vao, Ngay_Ra, So_Ngay_DTri, Ma_LyDo_VVien, Ma_Benh, Ma_BenhKhac, Muc_Huong_XML1, T_TongChi, T_BNTT, T_BHTT, T_BNCCT, T_XN, T_CDHA, T_Thuoc, T_Mau, T_TTPT, T_VTYT, T_DVKT_TyLe, T_Thuoc_TyLe, T_VTYT_TyLe, T_Kham, T_Giuong, T_VChuyen, T_NgoaiDS, T_NguonKhac, Ma_Loai_KCB, ID_CP, Loai_CP, Ma_CP, Ma_Vat_Tu, Ma_Nhom, Ten_CP, DVT, So_Dang_Ky, Ham_Luong, Duong_Dung, So_Luong, So_Luong_BV, Don_Gia, Don_Gia_BV, Thanh_Tien, TyLe_TT, Ngay_YL, Ngay_KQ, T_NguonKhac_DTL, T_BNTT_DTL, T_BHTT_DTL, T_BNCCT_DTL, T_NgoaiDS_DTL, Muc_Huong_DTL, TT_Thau, Pham_Vi, Ma_Giuong, T_TranTT, Goi_VTYT, Ten_Vat_Tu, Ten_Khoa, Ma_Khoa, Ma_Khoa_XML1, Ten_Khoa_XML1, Ten_Benh, Ma_Bac_Si, Ma_Tinh, Ma_Tinh_The "
            + "FROM @xml123 "
            + "END";


            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {
                if (DBUtils.ExecuteNonQuery(query, conn) > 0)
                {
                    ///MessageBox.Show("Tạo Procedure Thành Công");
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
        }

        private void khoitaoCSDL(string _MaCSKCB)
        {
            taoTable(_MaCSKCB);
            taoType(_MaCSKCB);
            taoProcedure(_MaCSKCB);
        }

        private void khoitaoCSDL_2(string _MaCSKCB)
        {
            taoTable(_MaCSKCB);
            //taoType(_MaCSKCB);
            taoProcedure_2(_MaCSKCB);
        }

        private void khoitaoCSDL_3(string _MaCSKCB)
        {
            taoTable_2(_MaCSKCB);
        }
        #endregion
        private void btnChonDuLieu_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQLite File (*.db)|*.db|All Files (*.*)|*.*";
            dlg.Multiselect = true; //Chỗ này nè

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                foreach (string str in dlg.FileNames)
                {
                    _FileNames.Add(str);
                }
                foreach (string str in dlg.SafeFileNames)
                {

                    _SafeFileNames.Add(str);
                }
            }

            using (frmWaitForm frm = new frmWaitForm(themVaoCSDLxml123))
            {

                frm.ShowDialog(this);
                MessageBox.Show("Thêm Dữ Liệu Thành Công");
            }

            using (frmWaitForm frm = new frmWaitForm(themVaoBangxml123))
            {

                frm.ShowDialog(this);
            }



        }

        private void themVaoCSDLxml123()
        {
            for (int i = 0; i < _FileNames.Count; i++)
            {
                bool flag = true;
                string _FileName = _FileNames[i];
                string _SafeFileName = _SafeFileNames[i];

                SQLiteHelper.setConnString(_FileName);

                //DataTable dt = SQLiteHelper.loadDatafromDB("Select * From xml123");
                DataTable dt = SQLiteHelper.loadDatafromDB("SELECT ID, XML1_ID, Ky_QT, CoSoKCB_ID, Ma_CSKCB, Ma_LK, MA_BN, Ho_Ten, Ngay_Sinh, Gioi_Tinh, Ma_The, Ma_DKBD, GT_The_Tu, GT_The_Den, Mien_Cung_CT, Ngay_Vao, Ngay_Ra, So_Ngay_DTri, Ma_LyDo_VVien, Ma_Benh, Ma_BenhKhac, Muc_Huong_XML1, T_TongChi, T_BNTT, T_BHTT, T_BNCCT, T_XN, T_CDHA, T_Thuoc, T_Mau, T_TTPT, T_VTYT, T_DVKT_TyLe, T_Thuoc_TyLe, T_VTYT_TyLe, T_Kham, T_Giuong, T_VChuyen, T_NgoaiDS, T_NguonKhac, Ma_Loai_KCB, ID_CP, Loai_CP, Ma_CP, Ma_Vat_Tu, Ma_Nhom, Ten_CP, DVT, So_Dang_Ky, Ham_Luong, Duong_Dung, So_Luong, So_Luong_BV, Don_Gia, Don_Gia_BV, Thanh_Tien, TyLe_TT, Ngay_YL, Ngay_KQ, T_NguonKhac_DTL, T_BNTT_DTL, T_BHTT_DTL, T_BNCCT_DTL, T_NgoaiDS_DTL, Muc_Huong_DTL, TT_Thau, Pham_Vi, Ma_Giuong, T_TranTT, Goi_VTYT, Ten_Vat_Tu, Ten_Khoa, Ma_Khoa, Ma_Khoa_XML1, Ten_Khoa_XML1, Ten_Benh, Ma_Bac_Si, Ma_Tinh, Ma_Tinh_The FROM xml123");

                string _MaCSKCB = (_SafeFileName.Split('.'))[0].ToString().Trim();
                khoitaoCSDL(_MaCSKCB);

                string tenProcedure = "Insert_xml123_" + _MaCSKCB;
                string tenTable = "xml123_" + _MaCSKCB;
                string tenType = "udt_xml123_" + _MaCSKCB;

                SqlConnection conn = DBUtils.GetDBConnection();
                conn.Open();
                try
                {
                    if (DBUtils.ExecuteNonQueryStoredProcedure_xml123(tenProcedure, dt, conn) > 0)
                    {
                        //MessageBox.Show("Tạo Table Thành Công");
                    }
                }
                catch (SqlException ex)
                {
                    //MessageBox.Show("Error: " + ex.ToString());
                    flag = false;
                }
                finally
                {
                    conn.Close();
                    conn.Dispose();
                }

                if (!flag)
                {
                    MessageBox.Show("CSKCB " + _MaCSKCB + " đã có trong CSDL");
                }

            }
        }

        private void themVaoBangxml123()
        {
            ////////////////////////////////////////////////////////////////////////////////
            SqlConnection conn = DBUtils.GetDBConnection();
            conn.Open();
            try
            {

                List<string> _dm_xml123 = new List<string>();
                List<string> _dm_schema_table = new List<string>();


                string query = "SELECT MaCSKCB FROM dmxml123";
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
                    bool flag = false;
                    for (int j = 0; j < _dm_xml123.Count; j++)
                    {
                        if (_dm_schema_table[i].ToString() == _dm_xml123[j].ToString())
                            flag = true;
                    }

                    if (!flag)
                    {
                        //Chưa có, cần thêm vào table dmxml123
                        string maCSKCB = _dm_schema_table[i].ToString();
                        maCSKCB = maCSKCB.Split('_')[1].ToString();

                        query = "INSERT INTO dmxml123(MaCSKCB, TenCSKCB) VALUES('" + maCSKCB + "','Tên CSKCB')";
                        DBUtils.ExecuteNonQuery(query, conn);

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

        }

        private void frmImportDuLieu_Load(object sender, EventArgs e)
        {
            //this.lbLuuY.Text = "Dữ liệu đưa vào phải đúng định dạng SQLite, tên tập tin trùng với tên CSKCB";
        }

        private void btnTEST_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQLite File (*.db)|*.db|All Files (*.*)|*.*";
            dlg.Multiselect = true; //Chỗ này nè

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                foreach (string str in dlg.FileNames)
                {
                    _FileNames.Add(str);
                }
                foreach (string str in dlg.SafeFileNames)
                {

                    _SafeFileNames.Add(str);
                }
            }

            //themVaoCSDLxml123_test();


            using (frmWaitForm frm = new frmWaitForm(themVaoCSDLxml123_2))
            {

                frm.ShowDialog(this);
                MessageBox.Show("Thêm Dữ Liệu Thành Công");
            }


            using (frmWaitForm frm = new frmWaitForm(themVaoBangxml123))
            {

                frm.ShowDialog(this);
            }

        }

        private void btnTEST2_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQLite File (*.db)|*.db|All Files (*.*)|*.*";
            dlg.Multiselect = true; //Chỗ này nè

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                foreach (string str in dlg.FileNames)
                {
                    _FileNames.Add(str);
                }
                foreach (string str in dlg.SafeFileNames)
                {

                    _SafeFileNames.Add(str);
                }
            }

            //themVaoCSDLxml123_test();


            using (frmWaitForm frm = new frmWaitForm(themVaoCSDLxml123_3))
            {

                frm.ShowDialog(this);
                MessageBox.Show("Thêm Dữ Liệu Thành Công");
            }

            /*
            using (frmWaitForm frm = new frmWaitForm(themVaoBangxml123))
            {

                frm.ShowDialog(this);
            }*/

        }

        private void themVaoCSDLxml123_2()
        {
            for (int i = 0; i < _FileNames.Count; i++)
            {
                string _FileName = _FileNames[i];
                string _SafeFileName = _SafeFileNames[i];

                SQLiteHelper.setConnString(_FileName);
                int _tongSoDong = int.Parse(SQLiteHelper.loadDatafromDB("SELECT COUNT(ID) FROM xml123").Rows[0][0].ToString());
                //MessageBox.Show(_tongSoDong.ToString());

                string _MaCSKCB = (_SafeFileName.Split('.'))[0].ToString().Trim();

                /////
                //khoitaoCSDL_2(_MaCSKCB);
                khoitaoCSDL(_MaCSKCB);

                string tenProcedure = "Insert_xml123_" + _MaCSKCB;
                string tenTable = "xml123_" + _MaCSKCB;
                string tenType = "udt_xml123_" + _MaCSKCB;


                for (int j = 0; j < _tongSoDong; j = j + 100000)
                {

                    int _start = j;
                    int _end = 100000;

                    if ((j + 100000) > _tongSoDong)
                    {
                        _start = j;
                        _end = _tongSoDong - j;
                    }

                    SQLiteHelper.setConnString(_FileName);


                    DataTable dt = SQLiteHelper.loadDatafromDB("SELECT ID, XML1_ID, Ky_QT, CoSoKCB_ID, Ma_CSKCB, Ma_LK, MA_BN, Ho_Ten, Ngay_Sinh, Gioi_Tinh, Ma_The, Ma_DKBD, GT_The_Tu, GT_The_Den, Mien_Cung_CT, Ngay_Vao, Ngay_Ra, So_Ngay_DTri, Ma_LyDo_VVien, Ma_Benh, Ma_BenhKhac, Muc_Huong_XML1, T_TongChi, T_BNTT, T_BHTT, T_BNCCT, T_XN, T_CDHA, T_Thuoc, T_Mau, T_TTPT, T_VTYT, T_DVKT_TyLe, T_Thuoc_TyLe, T_VTYT_TyLe, T_Kham, T_Giuong, T_VChuyen, T_NgoaiDS, T_NguonKhac, Ma_Loai_KCB, ID_CP, Loai_CP, Ma_CP, Ma_Vat_Tu, Ma_Nhom, Ten_CP, DVT, So_Dang_Ky, Ham_Luong, Duong_Dung, So_Luong, So_Luong_BV, Don_Gia, Don_Gia_BV, Thanh_Tien, TyLe_TT, Ngay_YL, Ngay_KQ, T_NguonKhac_DTL, T_BNTT_DTL, T_BHTT_DTL, T_BNCCT_DTL, T_NgoaiDS_DTL, Muc_Huong_DTL, TT_Thau, Pham_Vi, Ma_Giuong, T_TranTT, Goi_VTYT, Ten_Vat_Tu, Ten_Khoa, Ma_Khoa, Ma_Khoa_XML1, Ten_Khoa_XML1, Ten_Benh, Ma_Bac_Si, Ma_Tinh, Ma_Tinh_The FROM xml123 LIMIT " + _start + ", " + _end);
                    SqlConnection conn = DBUtils.GetDBConnection();

                    //MessageBox.Show("j:" + _start.ToString() + "_end:" + _end.ToString() + "_sodong: " + dt.Rows.Count.ToString());

                    conn.Open();
                    try
                    {
                        DBUtils.ExecuteNonQueryStoredProcedure_xml123(tenProcedure, dt, conn);
                        //DBUtils.ExecuteNonQuery("DBCC FREEPROCCACHE", conn);
                        /*

                        for (int k = 0; k < dt.Rows.Count; k++)
                        {
                            DBUtils.ExecuteNonQueryStoredProcedure_xml123_2(tenProcedure, dt.Rows[k], conn);
                        }*/

                        conn.Close();
                        conn.Dispose();
                        dt.Clear();
                        dt.Dispose();
                    }
                    catch (SqlException ex)
                    {
                        MessageBox.Show("Error: " + ex.ToString());
                    }
                    finally
                    {
                        //MessageBox.Show("Release done");
                        //conn.Close();
                        //conn.Dispose();
                        //dt.Clear();
                        //dt.Dispose();
                    }


                }


                /*
                int _start = 0;
                int _end = 100000;
                SQLiteHelper.setConnString(_FileName);


                DataTable dt = SQLiteHelper.loadDatafromDB("SELECT ID, XML1_ID, Ky_QT, CoSoKCB_ID, Ma_CSKCB, Ma_LK, MA_BN, Ho_Ten, Ngay_Sinh, Gioi_Tinh, Ma_The, Ma_DKBD, GT_The_Tu, GT_The_Den, Mien_Cung_CT, Ngay_Vao, Ngay_Ra, So_Ngay_DTri, Ma_LyDo_VVien, Ma_Benh, Ma_BenhKhac, Muc_Huong_XML1, T_TongChi, T_BNTT, T_BHTT, T_BNCCT, T_XN, T_CDHA, T_Thuoc, T_Mau, T_TTPT, T_VTYT, T_DVKT_TyLe, T_Thuoc_TyLe, T_VTYT_TyLe, T_Kham, T_Giuong, T_VChuyen, T_NgoaiDS, T_NguonKhac, Ma_Loai_KCB, ID_CP, Loai_CP, Ma_CP, Ma_Vat_Tu, Ma_Nhom, Ten_CP, DVT, So_Dang_Ky, Ham_Luong, Duong_Dung, So_Luong, So_Luong_BV, Don_Gia, Don_Gia_BV, Thanh_Tien, TyLe_TT, Ngay_YL, Ngay_KQ, T_NguonKhac_DTL, T_BNTT_DTL, T_BHTT_DTL, T_BNCCT_DTL, T_NgoaiDS_DTL, Muc_Huong_DTL, TT_Thau, Pham_Vi, Ma_Giuong, T_TranTT, Goi_VTYT, Ten_Vat_Tu, Ten_Khoa, Ma_Khoa, Ma_Khoa_XML1, Ten_Khoa_XML1, Ten_Benh, Ma_Bac_Si, Ma_Tinh, Ma_Tinh_The FROM xml123 LIMIT " + _start + ", " + _end);
                

                
                    SqlConnection conn = DBUtils.GetDBConnection();
                    conn.Open();
                try
                {

                    for (int j = 0; j < dt.Rows.Count; j++)
                    {
                        DBUtils.ExecuteNonQueryStoredProcedure_xml123_2(tenProcedure, dt.Rows[j], conn);
                    }
                    conn.Close();
                    conn.Dispose();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.ToString());
                }
                finally
                {
                }

    */


                MessageBox.Show("xong");

            }
        }

        private void themVaoCSDLxml123_3()
        {
            for (int i = 0; i < _FileNames.Count; i++)
            {
                string _FileName = _FileNames[i];
                string _SafeFileName = _SafeFileNames[i];



                string _MaCSKCB = (_SafeFileName.Split('.'))[0].ToString().Trim();

                /////
                khoitaoCSDL_2(_MaCSKCB);


                //khoitaoCSDL(_MaCSKCB);

                string tenProcedure = "Insert_xml123_" + _MaCSKCB;
                string tenTable = "xml123_" + _MaCSKCB;
                string tenType = "udt_xml123_" + _MaCSKCB;

                SqlConnection conn = DBUtils.GetDBConnection();


                conn.Open();
                try
                {
                    DBUtils.ExecuteNonQueryStoredProcedure_DULIEUXML123(tenProcedure, conn, _FileName);
                    conn.Close();
                    conn.Dispose();
                }
                catch (SqlException ex)
                {
                    MessageBox.Show("Error: " + ex.ToString());
                }
                finally
                {
                    MessageBox.Show("Release done");
                    conn.Close();
                    conn.Dispose();
                }


            }
            MessageBox.Show("xong");

        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQLite File (*.db)|*.db|All Files (*.*)|*.*";
            dlg.Multiselect = true; //Chỗ này nè

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                foreach (string str in dlg.FileNames)
                {
                    _FileNames.Add(str);
                }
                foreach (string str in dlg.SafeFileNames)
                {

                    _SafeFileNames.Add(str);
                }
            }


            /*using (frmWaitForm frm = new frmWaitForm(themVaoCSDLxml123_VIPRO))
            {

                frm.ShowDialog(this);
                MessageBox.Show("Thêm Dữ Liệu Thành Công");
            }*/

            themVaoCSDLxml123_BULKCOPY();

        }

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

                query = "begin try drop table " + tenTable + " end try begin catch end catch";
                DBUtils.ExecuteNonQuery(query, conn);

                //Tạo table
                taoTable(_MaCSKCB);

                string myconnection = "Data Source =" + _FileName;
                SQLiteConnection mysqliteconn = new SQLiteConnection(myconnection);
                SQLiteDataReader mysqlitereader;
                SQLiteCommand SelectCommand = new SQLiteCommand("SELECT ID, XML1_ID, Ky_QT, CoSoKCB_ID, Ma_CSKCB, Ma_LK, MA_BN, Ho_Ten, Ngay_Sinh, Gioi_Tinh, Ma_The, Ma_DKBD, GT_The_Tu, GT_The_Den, Mien_Cung_CT, Ngay_Vao, Ngay_Ra, So_Ngay_DTri, Ma_LyDo_VVien, Ma_Benh, Ma_BenhKhac, Muc_Huong_XML1, T_TongChi, T_BNTT, T_BHTT, T_BNCCT, T_XN, T_CDHA, T_Thuoc, T_Mau, T_TTPT, T_VTYT, T_DVKT_TyLe, T_Thuoc_TyLe, T_VTYT_TyLe, T_Kham, T_Giuong, T_VChuyen, T_NgoaiDS, T_NguonKhac, Ma_Loai_KCB, ID_CP, Loai_CP, Ma_CP, Ma_Vat_Tu, Ma_Nhom, Ten_CP, DVT, So_Dang_Ky, Ham_Luong, Duong_Dung, So_Luong, So_Luong_BV, Don_Gia, Don_Gia_BV, Thanh_Tien, TyLe_TT, Ngay_YL, Ngay_KQ, T_NguonKhac_DTL, T_BNTT_DTL, T_BHTT_DTL, T_BNCCT_DTL, T_NgoaiDS_DTL, Muc_Huong_DTL, TT_Thau, Pham_Vi, Ma_Giuong, T_TranTT, Goi_VTYT, Ten_Vat_Tu, Ten_Khoa, Ma_Khoa, Ma_Khoa_XML1, Ten_Khoa_XML1, Ten_Benh, Ma_Bac_Si, Ma_Tinh, Ma_Tinh_The FROM xml123", mysqliteconn);
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
                    MessageBox.Show("Ghi thành công CSKCB: " + tenTable);
                }, System.Threading.CancellationToken.None, TaskContinuationOptions.None, TaskScheduler.FromCurrentSynchronizationContext());

            }
        }

        private void btnImportXML123_Click(object sender, EventArgs e)
        {
            OpenFileDialog dlg = new OpenFileDialog();
            dlg.Filter = "SQLite File (*.db)|*.db|All Files (*.*)|*.*";
            dlg.Multiselect = true; //Chỗ này nè

            if (dlg.ShowDialog(this) == DialogResult.OK)
            {
                foreach (string str in dlg.FileNames)
                {
                    _FileNames.Add(str);
                }
                foreach (string str in dlg.SafeFileNames)
                {

                    _SafeFileNames.Add(str);
                }
            }


            /*using (frmWaitForm frm = new frmWaitForm(themVaoCSDLxml123_VIPRO))
            {

                frm.ShowDialog(this);
                MessageBox.Show("Thêm Dữ Liệu Thành Công");
            }*/

            themVaoCSDLxml123_BULKCOPY();
        }
    }
}
