using System.Data.SqlClient;
using System.Data;
using System.Data.SQLite;
using System.Windows;
using System.Windows.Forms;

namespace PhanTichDuLieu
{
    class DBUtils
    {
        public static SqlConnection GetDBConnection()
        {

            string datasource = @"IT\SQLEXPRESS";
            string database = "XML_Q1_2018";
            string username = "sa";
            string password = "sa";

            string _strFileName = System.IO.Directory.GetCurrentDirectory() + @"\SqlConnection.txt";

            string[] lines = System.IO.File.ReadAllLines(_strFileName);

            datasource = lines[0].Split('=')[1].ToString().Trim();
            database = lines[1].Split('=')[1].ToString().Trim();
            username = lines[2].Split('=')[1].ToString().Trim();
            password = lines[3].Split('=')[1].ToString().Trim();


            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }

        public static SqlConnection GetDBConnection(string datasource, string database, string username, string password)
        {
            return DBSQLServerUtils.GetDBConnection(datasource, database, username, password);
        }

        public static DataTable GetDBTable(string query, SqlConnection conn)
        {
            DataTable dt = new DataTable();
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            da.SelectCommand.CommandTimeout = 300000;
            da.Fill(dt);
            return dt;
        }

        public static int ExecuteNonQuery(string query, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand(query, conn);
            int effRows = cmd.ExecuteNonQuery();
            return effRows;
        }

        public static int ExecuteNonQueryStoredProcedure_xml123(string nameStoredProcedure, DataTable dt, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand(nameStoredProcedure, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            SqlParameter tvparam = cmd.Parameters.AddWithValue("@xml123", dt);
            tvparam.SqlDbType = SqlDbType.Structured;
            int effRows = cmd.ExecuteNonQuery();


            cmd.Cancel();
            cmd.Dispose();
            return effRows;
        }
        public static void ExecuteNonQuery_VIPPRO(string nameTable, SqlConnection conn, string nameFile)
        {

            string myconnection = "Data Source =" + nameFile;
            SQLiteConnection mysqliteconn = new SQLiteConnection(myconnection);
            SQLiteDataReader mysqlitereader;
            SQLiteCommand SelectCommand = new SQLiteCommand("SELECT ID, XML1_ID, Ky_QT, CoSoKCB_ID, Ma_CSKCB, Ma_LK, MA_BN, Ho_Ten, Ngay_Sinh, Gioi_Tinh, Ma_The, Ma_DKBD, GT_The_Tu, GT_The_Den, Mien_Cung_CT, Ngay_Vao, Ngay_Ra, So_Ngay_DTri, Ma_LyDo_VVien, Ma_Benh, Ma_BenhKhac, Muc_Huong_XML1, T_TongChi, T_BNTT, T_BHTT, T_BNCCT, T_XN, T_CDHA, T_Thuoc, T_Mau, T_TTPT, T_VTYT, T_DVKT_TyLe, T_Thuoc_TyLe, T_VTYT_TyLe, T_Kham, T_Giuong, T_VChuyen, T_NgoaiDS, T_NguonKhac, Ma_Loai_KCB, ID_CP, Loai_CP, Ma_CP, Ma_Vat_Tu, Ma_Nhom, Ten_CP, DVT, So_Dang_Ky, Ham_Luong, Duong_Dung, So_Luong, So_Luong_BV, Don_Gia, Don_Gia_BV, Thanh_Tien, TyLe_TT, Ngay_YL, Ngay_KQ, T_NguonKhac_DTL, T_BNTT_DTL, T_BHTT_DTL, T_BNCCT_DTL, T_NgoaiDS_DTL, Muc_Huong_DTL, TT_Thau, Pham_Vi, Ma_Giuong, T_TranTT, Goi_VTYT, Ten_Vat_Tu, Ten_Khoa, Ma_Khoa, Ma_Khoa_XML1, Ten_Khoa_XML1, Ten_Benh, Ma_Bac_Si, Ma_Tinh, Ma_Tinh_The FROM xml123", mysqliteconn);
            mysqliteconn.Open();
            mysqlitereader = SelectCommand.ExecuteReader();

            SqlBulkCopy bulkCopy = new SqlBulkCopy(conn);
            bulkCopy.DestinationTableName = nameTable;
            try
            {
                //bulkCopy.
                bulkCopy.WriteToServer(mysqlitereader);
                bulkCopy.Close();
                //bulkCopy.BatchSize
            }
            catch
            {
                MessageBox.Show("Khong the sao chep du lieu giua 2 bang");
            }

            
        }

        public static int ExecuteNonQueryStoredProcedure_DULIEUXML123(string nameStoredProcedure, SqlConnection conn, string nameFile)
        {

            string myconnection = "Data Source =" + nameFile;
            SQLiteConnection mysqliteconn = new SQLiteConnection(myconnection);
            SQLiteDataReader mysqlitereader;
            SQLiteCommand SelectCommand = new SQLiteCommand("SELECT ID, XML1_ID, Ky_QT, CoSoKCB_ID, Ma_CSKCB, Ma_LK, MA_BN, Ho_Ten, Ngay_Sinh, Gioi_Tinh, Ma_The, Ma_DKBD, GT_The_Tu, GT_The_Den, Mien_Cung_CT, Ngay_Vao, Ngay_Ra, So_Ngay_DTri, Ma_LyDo_VVien, Ma_Benh, Ma_BenhKhac, Muc_Huong_XML1, T_TongChi, T_BNTT, T_BHTT, T_BNCCT, T_XN, T_CDHA, T_Thuoc, T_Mau, T_TTPT, T_VTYT, T_DVKT_TyLe, T_Thuoc_TyLe, T_VTYT_TyLe, T_Kham, T_Giuong, T_VChuyen, T_NgoaiDS, T_NguonKhac, Ma_Loai_KCB, ID_CP, Loai_CP, Ma_CP, Ma_Vat_Tu, Ma_Nhom, Ten_CP, DVT, So_Dang_Ky, Ham_Luong, Duong_Dung, So_Luong, So_Luong_BV, Don_Gia, Don_Gia_BV, Thanh_Tien, TyLe_TT, Ngay_YL, Ngay_KQ, T_NguonKhac_DTL, T_BNTT_DTL, T_BHTT_DTL, T_BNCCT_DTL, T_NgoaiDS_DTL, Muc_Huong_DTL, TT_Thau, Pham_Vi, Ma_Giuong, T_TranTT, Goi_VTYT, Ten_Vat_Tu, Ten_Khoa, Ma_Khoa, Ma_Khoa_XML1, Ten_Khoa_XML1, Ten_Benh, Ma_Bac_Si, Ma_Tinh, Ma_Tinh_The FROM xml123", mysqliteconn);

            int effRows = 0;
            mysqliteconn.Open();

            mysqlitereader = SelectCommand.ExecuteReader();


            if (mysqlitereader.HasRows)
            {
                while (mysqlitereader.Read()) //returing false 
                {
                    //MessageBox.Show(mysqlitereader.GetValue(0).ToString());
                    SqlCommand cmd = new SqlCommand(nameStoredProcedure, conn);
                    cmd.CommandType = CommandType.StoredProcedure;

                    cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(0).ToString();
                    cmd.Parameters.Add("@XML1_ID", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(1).ToString();
                    cmd.Parameters.Add("@Ky_QT", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(2).ToString();
                    cmd.Parameters.Add("@CoSoKCB_ID", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(3).ToString();
                    cmd.Parameters.Add("@Ma_CSKCB", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(4).ToString();
                    cmd.Parameters.Add("@Ma_LK", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(5).ToString();
                    cmd.Parameters.Add("@MA_BN", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(6).ToString();
                    cmd.Parameters.Add("@Ho_Ten", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(7).ToString();
                    cmd.Parameters.Add("@Ngay_Sinh", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(8).ToString();
                    cmd.Parameters.Add("@Gioi_Tinh", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(9).ToString();
                    cmd.Parameters.Add("@Ma_The", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(10).ToString();
                    cmd.Parameters.Add("@Ma_DKBD", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(11).ToString();
                    cmd.Parameters.Add("@Ngay_Vao", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(12).ToString();
                    cmd.Parameters.Add("@Ngay_Ra", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(13).ToString();
                    cmd.Parameters.Add("@So_Ngay_DTri", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(14).ToString();
                    cmd.Parameters.Add("@Ma_LyDo_VVien", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(15).ToString();
                    cmd.Parameters.Add("@Ma_Benh", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(16).ToString();
                    cmd.Parameters.Add("@Ma_BenhKhac", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(17).ToString();
                    cmd.Parameters.Add("@T_TongChi", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(18).ToString();
                    cmd.Parameters.Add("@T_BNTT", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(19).ToString();
                    cmd.Parameters.Add("@T_BHTT", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(20).ToString();
                    cmd.Parameters.Add("@T_XN", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(21).ToString();
                    cmd.Parameters.Add("@T_CDHA", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(22).ToString();
                    cmd.Parameters.Add("@T_Thuoc", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(23).ToString();
                    cmd.Parameters.Add("@T_Mau", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(24).ToString();
                    cmd.Parameters.Add("@T_TTPT", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(25).ToString();
                    cmd.Parameters.Add("@T_VTYT", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(26).ToString();
                    cmd.Parameters.Add("@T_DVKT_TyLe", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(27).ToString();
                    cmd.Parameters.Add("@T_Thuoc_TyLe", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(28).ToString();
                    cmd.Parameters.Add("@T_VTYT_TyLe", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(29).ToString();
                    cmd.Parameters.Add("@T_Kham", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(30).ToString();
                    cmd.Parameters.Add("@T_Giuong", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(31).ToString();
                    cmd.Parameters.Add("@T_VChuyen", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(32).ToString();
                    cmd.Parameters.Add("@T_NgoaiDS", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(33).ToString();
                    cmd.Parameters.Add("@T_NguonKhac", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(34).ToString();
                    cmd.Parameters.Add("@Ma_Loai_KCB", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(35).ToString();
                    cmd.Parameters.Add("@ID_CP", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(36).ToString();
                    cmd.Parameters.Add("@Loai_CP", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(37).ToString();
                    cmd.Parameters.Add("@Ma_CP", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(38).ToString();
                    cmd.Parameters.Add("@Ma_Vat_Tu", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(39).ToString();
                    cmd.Parameters.Add("@Ma_Nhom", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(40).ToString();
                    cmd.Parameters.Add("@Ten_CP", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(41).ToString();
                    cmd.Parameters.Add("@DVT", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(42).ToString();
                    cmd.Parameters.Add("@So_Dang_Ky", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(43).ToString();
                    cmd.Parameters.Add("@Ham_Luong", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(44).ToString();
                    cmd.Parameters.Add("@Duong_Dung", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(45).ToString();
                    cmd.Parameters.Add("@So_Luong", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(46).ToString();
                    cmd.Parameters.Add("@So_Luong_BV", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(47).ToString();
                    cmd.Parameters.Add("@Don_Gia", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(48).ToString();
                    cmd.Parameters.Add("@Don_Gia_BV", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(49).ToString();
                    cmd.Parameters.Add("@Thanh_Tien", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(50).ToString();
                    cmd.Parameters.Add("@TyLe_TT", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(51).ToString();
                    cmd.Parameters.Add("@Ngay_YL", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(52).ToString();
                    cmd.Parameters.Add("@Ten_Khoa", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(53).ToString();
                    cmd.Parameters.Add("@Ma_Khoa", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(54).ToString();
                    cmd.Parameters.Add("@Ma_Khoa_XML1", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(55).ToString();
                    cmd.Parameters.Add("@Ten_Khoa_XML1", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(56).ToString();
                    cmd.Parameters.Add("@Ten_Benh", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(57).ToString();
                    cmd.Parameters.Add("@Ma_Bac_Si", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(58).ToString();
                    cmd.Parameters.Add("@Ma_Tinh", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(59).ToString();
                    cmd.Parameters.Add("@Ma_Tinh_The", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(60).ToString();
                    cmd.Parameters.Add("@GT_The_Tu", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(61).ToString();
                    cmd.Parameters.Add("@GT_The_Den", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(62).ToString();
                    cmd.Parameters.Add("@Mien_Cung_CT", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(63).ToString();
                    cmd.Parameters.Add("@Muc_Huong_XML1", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(64).ToString();
                    cmd.Parameters.Add("@T_BNCCT", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(65).ToString();
                    cmd.Parameters.Add("@Ngay_KQ", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(66).ToString();
                    cmd.Parameters.Add("@T_NguonKhac_DTL", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(67).ToString();
                    cmd.Parameters.Add("@T_BNTT_DTL", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(68).ToString();
                    cmd.Parameters.Add("@T_BHTT_DTL", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(69).ToString();
                    cmd.Parameters.Add("@T_BNCCT_DTL", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(70).ToString();
                    cmd.Parameters.Add("@T_NgoaiDS_DTL", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(71).ToString();
                    cmd.Parameters.Add("@Muc_Huong_DTL", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(72).ToString();
                    cmd.Parameters.Add("@TT_Thau", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(73).ToString();
                    cmd.Parameters.Add("@Pham_Vi", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(74).ToString();
                    cmd.Parameters.Add("@Ma_Giuong", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(75).ToString();
                    cmd.Parameters.Add("@T_TranTT", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(76).ToString();
                    cmd.Parameters.Add("@Goi_VTYT", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(77).ToString();
                    cmd.Parameters.Add("@Ten_Vat_Tu", SqlDbType.NVarChar).Value = mysqlitereader.GetValue(78).ToString();




                    effRows = cmd.ExecuteNonQuery();

                    //cmd.Cancel();
                    //cmd.Dispose();
                }
                return effRows;
            }
            return effRows;

            ///////////////////////


        }
        public static int ExecuteNonQueryStoredProcedure_xml123_2(string nameStoredProcedure, DataRow row, SqlConnection conn)
        {
            SqlCommand cmd = new SqlCommand(nameStoredProcedure, conn);
            cmd.CommandType = CommandType.StoredProcedure;

            cmd.Parameters.Add("@ID", SqlDbType.NVarChar).Value = row[0].ToString();
            cmd.Parameters.Add("@XML1_ID", SqlDbType.NVarChar).Value = row[1].ToString();
            cmd.Parameters.Add("@Ky_QT", SqlDbType.NVarChar).Value = row[2].ToString();
            cmd.Parameters.Add("@CoSoKCB_ID", SqlDbType.NVarChar).Value = row[3].ToString();
            cmd.Parameters.Add("@Ma_CSKCB", SqlDbType.NVarChar).Value = row[4].ToString();
            cmd.Parameters.Add("@Ma_LK", SqlDbType.NVarChar).Value = row[5].ToString();
            cmd.Parameters.Add("@MA_BN", SqlDbType.NVarChar).Value = row[6].ToString();
            cmd.Parameters.Add("@Ho_Ten", SqlDbType.NVarChar).Value = row[7].ToString();
            cmd.Parameters.Add("@Ngay_Sinh", SqlDbType.NVarChar).Value = row[8].ToString();
            cmd.Parameters.Add("@Gioi_Tinh", SqlDbType.NVarChar).Value = row[9].ToString();
            cmd.Parameters.Add("@Ma_The", SqlDbType.NVarChar).Value = row[10].ToString();
            cmd.Parameters.Add("@Ma_DKBD", SqlDbType.NVarChar).Value = row[11].ToString();
            cmd.Parameters.Add("@Ngay_Vao", SqlDbType.NVarChar).Value = row[12].ToString();
            cmd.Parameters.Add("@Ngay_Ra", SqlDbType.NVarChar).Value = row[13].ToString();
            cmd.Parameters.Add("@So_Ngay_DTri", SqlDbType.NVarChar).Value = row[14].ToString();
            cmd.Parameters.Add("@Ma_LyDo_VVien", SqlDbType.NVarChar).Value = row[15].ToString();
            cmd.Parameters.Add("@Ma_Benh", SqlDbType.NVarChar).Value = row[16].ToString();
            cmd.Parameters.Add("@Ma_BenhKhac", SqlDbType.NVarChar).Value = row[17].ToString();
            cmd.Parameters.Add("@T_TongChi", SqlDbType.NVarChar).Value = row[18].ToString();
            cmd.Parameters.Add("@T_BNTT", SqlDbType.NVarChar).Value = row[19].ToString();
            cmd.Parameters.Add("@T_BHTT", SqlDbType.NVarChar).Value = row[20].ToString();
            cmd.Parameters.Add("@T_XN", SqlDbType.NVarChar).Value = row[21].ToString();
            cmd.Parameters.Add("@T_CDHA", SqlDbType.NVarChar).Value = row[22].ToString();
            cmd.Parameters.Add("@T_Thuoc", SqlDbType.NVarChar).Value = row[23].ToString();
            cmd.Parameters.Add("@T_Mau", SqlDbType.NVarChar).Value = row[24].ToString();
            cmd.Parameters.Add("@T_TTPT", SqlDbType.NVarChar).Value = row[25].ToString();
            cmd.Parameters.Add("@T_VTYT", SqlDbType.NVarChar).Value = row[26].ToString();
            cmd.Parameters.Add("@T_DVKT_TyLe", SqlDbType.NVarChar).Value = row[27].ToString();
            cmd.Parameters.Add("@T_Thuoc_TyLe", SqlDbType.NVarChar).Value = row[28].ToString();
            cmd.Parameters.Add("@T_VTYT_TyLe", SqlDbType.NVarChar).Value = row[29].ToString();
            cmd.Parameters.Add("@T_Kham", SqlDbType.NVarChar).Value = row[30].ToString();
            cmd.Parameters.Add("@T_Giuong", SqlDbType.NVarChar).Value = row[31].ToString();
            cmd.Parameters.Add("@T_VChuyen", SqlDbType.NVarChar).Value = row[32].ToString();
            cmd.Parameters.Add("@T_NgoaiDS", SqlDbType.NVarChar).Value = row[33].ToString();
            cmd.Parameters.Add("@T_NguonKhac", SqlDbType.NVarChar).Value = row[34].ToString();
            cmd.Parameters.Add("@Ma_Loai_KCB", SqlDbType.NVarChar).Value = row[35].ToString();
            cmd.Parameters.Add("@ID_CP", SqlDbType.NVarChar).Value = row[36].ToString();
            cmd.Parameters.Add("@Loai_CP", SqlDbType.NVarChar).Value = row[37].ToString();
            cmd.Parameters.Add("@Ma_CP", SqlDbType.NVarChar).Value = row[38].ToString();
            cmd.Parameters.Add("@Ma_Vat_Tu", SqlDbType.NVarChar).Value = row[39].ToString();
            cmd.Parameters.Add("@Ma_Nhom", SqlDbType.NVarChar).Value = row[40].ToString();
            cmd.Parameters.Add("@Ten_CP", SqlDbType.NVarChar).Value = row[41].ToString();
            cmd.Parameters.Add("@DVT", SqlDbType.NVarChar).Value = row[42].ToString();
            cmd.Parameters.Add("@So_Dang_Ky", SqlDbType.NVarChar).Value = row[43].ToString();
            cmd.Parameters.Add("@Ham_Luong", SqlDbType.NVarChar).Value = row[44].ToString();
            cmd.Parameters.Add("@Duong_Dung", SqlDbType.NVarChar).Value = row[45].ToString();
            cmd.Parameters.Add("@So_Luong", SqlDbType.NVarChar).Value = row[46].ToString();
            cmd.Parameters.Add("@So_Luong_BV", SqlDbType.NVarChar).Value = row[47].ToString();
            cmd.Parameters.Add("@Don_Gia", SqlDbType.NVarChar).Value = row[48].ToString();
            cmd.Parameters.Add("@Don_Gia_BV", SqlDbType.NVarChar).Value = row[49].ToString();
            cmd.Parameters.Add("@Thanh_Tien", SqlDbType.NVarChar).Value = row[50].ToString();
            cmd.Parameters.Add("@TyLe_TT", SqlDbType.NVarChar).Value = row[51].ToString();
            cmd.Parameters.Add("@Ngay_YL", SqlDbType.NVarChar).Value = row[52].ToString();
            cmd.Parameters.Add("@Ten_Khoa", SqlDbType.NVarChar).Value = row[53].ToString();
            cmd.Parameters.Add("@Ma_Khoa", SqlDbType.NVarChar).Value = row[54].ToString();
            cmd.Parameters.Add("@Ma_Khoa_XML1", SqlDbType.NVarChar).Value = row[55].ToString();
            cmd.Parameters.Add("@Ten_Khoa_XML1", SqlDbType.NVarChar).Value = row[56].ToString();
            cmd.Parameters.Add("@Ten_Benh", SqlDbType.NVarChar).Value = row[57].ToString();
            cmd.Parameters.Add("@Ma_Bac_Si", SqlDbType.NVarChar).Value = row[58].ToString();
            cmd.Parameters.Add("@Ma_Tinh", SqlDbType.NVarChar).Value = row[59].ToString();
            cmd.Parameters.Add("@Ma_Tinh_The", SqlDbType.NVarChar).Value = row[60].ToString();
            cmd.Parameters.Add("@GT_The_Tu", SqlDbType.NVarChar).Value = row[61].ToString();
            cmd.Parameters.Add("@GT_The_Den", SqlDbType.NVarChar).Value = row[62].ToString();
            cmd.Parameters.Add("@Mien_Cung_CT", SqlDbType.NVarChar).Value = row[63].ToString();
            cmd.Parameters.Add("@Muc_Huong_XML1", SqlDbType.NVarChar).Value = row[64].ToString();
            cmd.Parameters.Add("@T_BNCCT", SqlDbType.NVarChar).Value = row[65].ToString();
            cmd.Parameters.Add("@Ngay_KQ", SqlDbType.NVarChar).Value = row[66].ToString();
            cmd.Parameters.Add("@T_NguonKhac_DTL", SqlDbType.NVarChar).Value = row[67].ToString();
            cmd.Parameters.Add("@T_BNTT_DTL", SqlDbType.NVarChar).Value = row[68].ToString();
            cmd.Parameters.Add("@T_BHTT_DTL", SqlDbType.NVarChar).Value = row[69].ToString();
            cmd.Parameters.Add("@T_BNCCT_DTL", SqlDbType.NVarChar).Value = row[70].ToString();
            cmd.Parameters.Add("@T_NgoaiDS_DTL", SqlDbType.NVarChar).Value = row[71].ToString();
            cmd.Parameters.Add("@Muc_Huong_DTL", SqlDbType.NVarChar).Value = row[72].ToString();
            cmd.Parameters.Add("@TT_Thau", SqlDbType.NVarChar).Value = row[73].ToString();
            cmd.Parameters.Add("@Pham_Vi", SqlDbType.NVarChar).Value = row[74].ToString();
            cmd.Parameters.Add("@Ma_Giuong", SqlDbType.NVarChar).Value = row[75].ToString();
            cmd.Parameters.Add("@T_TranTT", SqlDbType.NVarChar).Value = row[76].ToString();
            cmd.Parameters.Add("@Goi_VTYT", SqlDbType.NVarChar).Value = row[77].ToString();
            cmd.Parameters.Add("@Ten_Vat_Tu", SqlDbType.NVarChar).Value = row[78].ToString();




            int effRows = cmd.ExecuteNonQuery();


            cmd.Cancel();
            cmd.Dispose();
            return effRows;
        }
    }
}
