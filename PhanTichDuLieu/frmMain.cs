using System;
using System.IO;
using System.Windows.Forms;
using PhanTichDuLieu.Helper;

namespace PhanTichDuLieu
{
    public partial class frmMain : DevExpress.XtraBars.Ribbon.RibbonForm
    {
        
        public frmMain()
        {
            InitializeComponent();
            this.xtraTabbedMdiManagerMain.MdiParent = this;
            this.WindowState = FormWindowState.Maximized;
            this.lbFooter.Text = "";
            this.Text = "Phần mềm hỗ trợ phân tích dữ liệu XML - Đăk Nông";

            //this.pictureEditMain.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Stretch;
            this.pictureEditMain.Properties.ReadOnly = true;
        }

        private void btnThoat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.Close();
        }

        private void FormMain_Load(object sender, EventArgs e)
        {
            btnThietLapHeThong.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;

            btnGiamDinhXetNghiem.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnThuocCoDieuKien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnDVKTCoDieuKien.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;

            btnThongKe14a.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnThongKe19a.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnThongKe20a.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnThongKe21a.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;
            btnThongKe7980a.RibbonStyle = DevExpress.XtraBars.Ribbon.RibbonItemStyles.Large;

            //Gửi Mail
            
            MyFunctionDLL.MailHelper myMailHelper = new MyFunctionDLL.MailHelper();
            //myMailHelper.sendMail();

            frmThietLapHeThong f = new frmThietLapHeThong();
            f.ShowDialog();

            /*
            frmDMxml123 f = new frmDMxml123();
            f.Text = "Danh Mục Điều Kiện Dịch Vụ Kỹ Thuật";
            f.MdiParent = this;
            f.Show();
            */

            //Hiển thị Footer
            string _strFileName = Directory.GetCurrentDirectory() + @"\SqlConnection.txt";
            string[] lines = File.ReadAllLines(_strFileName);

            string _tenCSDL = lines[1].Split('=')[1].ToString().Trim();
            this.lbFooter.Text = "DataBase: " + _tenCSDL;
            

            LicenceHelper myLicenceHelper = new LicenceHelper();

            if (!myLicenceHelper.CheckLicense("doconvit"))
            {
                MessageBox.Show("Chưa kích hoạt bản quyền!");
                this.Close();
            }

        }

        private void btnNoiDuLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmNoiDuLieuSQLite f = new frmNoiDuLieuSQLite();
            f.Text = "Nối dữ liệu SQLite";
            f.MdiParent = this;
            f.Show();
        }

        private void btnGioiThieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmGioiThieu f = new frmGioiThieu();
            f.ShowDialog();
        }
        private void btnThietLapHeThong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            frmThietLapHeThong f = new frmThietLapHeThong();
            f.ShowDialog();
        }

        private void btnThuocCoDieuKien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmThuocCoDieuKienNangCao f = new frmThuocCoDieuKienNangCao();
            f.Text = "Truy Vấn Thuốc Theo Điều Kiện";
            f.MdiParent = this;
            f.Show();
        }

        private void btnDVKTCoDieuKien_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmDVKTCoDieuKienNangCao f = new frmDVKTCoDieuKienNangCao();
            f.Text = "Truy Vấn Dịch Vụ Kỹ Thuật Theo Điều Kiện";
            f.MdiParent = this;
            f.Show();
        }

        private void btnGiamDinhXetNghiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmGiamDinhXetNghiem f = new frmGiamDinhXetNghiem();
            f.Text = "Truy Vấn Xét Nghiệm Theo Điều Kiện";
            f.MdiParent = this;
            f.Show();
        }

        private void btnGiamDinhChanDoanHinhAnh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmGiamDinhChanDoanHinhAnh f = new frmGiamDinhChanDoanHinhAnh();
            f.Text = "Truy Vấn Chẩn Đoán Hình Ảnh Theo Điều Kiện";
            f.MdiParent = this;
            f.Show();
        }

        private void btnGiamDinhNgayGiuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmGiamDinhNgayGiuong f = new frmGiamDinhNgayGiuong();
            f.Text = "Truy Vấn Ngày Giường Theo Điều Kiện";
            f.MdiParent = this;
            f.Show();
        }


        private void btnDMDieuKienThuoc_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmDMDieuKienThuoc f = new frmDMDieuKienThuoc();
            f.Text = "Danh Mục Điều Kiện Thuốc";
            f.MdiParent = this;
            f.Show();
        }

        private void btnDMDieuKienDichVu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmDMDieuKienDichVu f = new frmDMDieuKienDichVu();
            f.Text = "Danh Mục Điều Kiện Dịch Vụ Kỹ Thuật";
            f.MdiParent = this;
            f.Show();
        }

        private void btnQuanTriNguoiDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            MessageBox.Show("Chức năng chưa hoàn thiện! Mời sử dụng chức năng khác!");
        }

        private void btnImportDuLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmImportDuLieu f = new frmImportDuLieu();
            f.Text = "Import Dữ Liệu";
            f.MdiParent = this;
            f.Show();
        }

        private void btnDMXML123_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();

            frmDMxml123 f = new frmDMxml123();
            f.Text = "Danh mục Cơ Sở Khám Chữa Bệnh XML123";
            f.MdiParent = this;
            f.Show();
        }

        private void btnDMMau7980_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmDMMau7980a f = new frmDMMau7980a();
            f.Text = "Danh mục điều kiện mẫu 7980a";
            f.MdiParent = this;
            f.Show();
        }

        private void btnDMMau19_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmDMMau19a f = new frmDMMau19a();
            f.Text = "Danh mục điều kiện mẫu 19a";
            f.MdiParent = this;
            f.Show();
        }

        private void btnDMMau20_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmDMMau20a f = new frmDMMau20a();
            f.Text = "Danh mục điều kiện mẫu 20a";
            f.MdiParent = this;
            f.Show();
        }

        private void btnDMMau21_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmDMMau21a f = new frmDMMau21a();
            f.Text = "Danh mục điều kiện mẫu 21a";
            f.MdiParent = this;
            f.Show();
        }

        private void btnChiaDuLieu_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmChiaDuLieuSQLite f = new frmChiaDuLieuSQLite();
            f.Text = "Chia dữ liệu SQLite";
            f.MdiParent = this;
            f.Show();
        }

        private void btnDMCSKCB_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmDMCoSoKCB f = new frmDMCoSoKCB();
            f.Text = "Danh mục Cơ Sở KCB";
            f.MdiParent = this;
            f.Show();
        }

        private void btnThuocCoDieuKienNangCao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmThuocCoDieuKienNangCao f = new frmThuocCoDieuKienNangCao();
            f.Text = "Truy vấn thuốc nâng cao";
            f.MdiParent = this;
            f.Show();
        }

        private void btnDVKTCoDieuKienNangCao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            this.pictureEditMain.Hide();
            frmDVKTCoDieuKienNangCao f = new frmDVKTCoDieuKienNangCao();
            f.Text = "Truy vấn dịch vụ kỹ thuật nâng cao";
            f.MdiParent = this;
            f.Show();
        }

        private void btnDMDieuKienThuocNangCao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            this.pictureEditMain.Hide();
            frmDMDieuKienThuocNangCao f = new frmDMDieuKienThuocNangCao();
            f.Text = "Danh mục thuốc nâng cao";
            f.MdiParent = this;
            f.Show();
        }

        private void btnDMDieuKienDichVuNangCao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmDMDieuKienDichVuNangCao f = new frmDMDieuKienDichVuNangCao();
            f.Text = "Danh mục dịch vụ kỹ thuật nâng cao";
            f.MdiParent = this;
            f.Show();
        }


        private void btnDMDieuKienXetNghiem_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmDMDieuKienXetNghiemNangCao f = new frmDMDieuKienXetNghiemNangCao();
            f.Text = "Danh Mục Điều Kiện Xét Nghiệm";
            f.MdiParent = this;
            f.Show();
        }

        private void btnDMDieuKienChanDoanHinhAnh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmDMDieuKienChanDoanHinhAnhNangCao f = new frmDMDieuKienChanDoanHinhAnhNangCao();
            f.Text = "Danh Mục Điều Kiện Chẩn Đoán Hình Ảnh";
            f.MdiParent = this;
            f.Show();
        }

        private void btnDMDieuKienNgayGiuong_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmDMDieuKienNgayGiuongNangCao f = new frmDMDieuKienNgayGiuongNangCao();
            f.Text = "Danh Mục Điều Kiện Ngày Giường";
            f.MdiParent = this;
            f.Show();
        }

        private void btnNoiDuLieu_KQT_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmNoiDuLieuSQLite_KQT f = new frmNoiDuLieuSQLite_KQT();
            f.Text = "Nối dữ liệu SQLite Theo Kỳ QT";
            f.MdiParent = this;
            f.Show();
        }

        private void btnDMMau14_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmDMMau14a f = new frmDMMau14a();
            f.Text = "Danh mục điều kiện mẫu 14a";
            f.MdiParent = this;
            f.Show();
        }

        private void btnDMNgay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmDMNgay f = new frmDMNgay();
            f.Text = "Danh mục điều kiện ngày";
            f.MdiParent = this;
            f.Show();
        }

        private void btnDMPhauThuatThuThuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmDMPhauThuatThuThuat f = new frmDMPhauThuatThuThuat();
            f.Text = "Danh mục điều kiện phẫu thuật thủ thuật";
            f.MdiParent = this;
            f.Show();
        }

        private void btnDMThuocVuotTuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmDMThuocVuotTuyen f = new frmDMThuocVuotTuyen();
            f.Text = "Danh mục điều kiện thuốc vượt tuyến";
            f.MdiParent = this;
            f.Show();
        }

        private void btnTaiLieuThamKhao_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmTaiLieuThamKhao f = new frmTaiLieuThamKhao();
            f.Text = "Tài Liệu Tham Khảo";
            f.MdiParent = this;
            f.Show();
        }

        private void btnThongKe14a_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmGiamDinhThongKeMau14a f = new frmGiamDinhThongKeMau14a();
            f.Text = "Thống kê mẫu 14a";
            f.MdiParent = this;
            f.Show();
        }

        private void btnThongKe19a_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmGiamDinhThongKeMau19a f = new frmGiamDinhThongKeMau19a();
            f.Text = "Thống kê mẫu 19a";
            f.MdiParent = this;
            f.Show();
        }

        private void btnThongKe20a_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            this.pictureEditMain.Hide();
            frmGiamDinhThongKeMau20a f = new frmGiamDinhThongKeMau20a();
            f.Text = "Thống kê mẫu 20a";
            f.MdiParent = this;
            f.Show();
        }

        private void btnThongKe21a_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmGiamDinhThongKeMau21a f = new frmGiamDinhThongKeMau21a();
            f.Text = "Thống kê mẫu 21a";
            f.MdiParent = this;
            f.Show();
        }

        private void btnThongKe7980a_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmGiamDinhThongKeMau7980a f = new frmGiamDinhThongKeMau7980a();
            f.Text = "Thống kê mẫu 7980a";
            f.MdiParent = this;
            f.Show();
        }

        private void btnThongKeNgay_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmGiamDinhThongKeNgay f = new frmGiamDinhThongKeNgay();
            f.Text = "Thống kê ngày";
            f.MdiParent = this;
            f.Show();
        }

        private void btnThongKePhauThuatThuThuat_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmGiamDinhThongKePhauThuatThuThuat f = new frmGiamDinhThongKePhauThuatThuThuat();
            f.Text = "Thống kê phẫu thuật thủ thuật";
            f.MdiParent = this;
            f.Show();
        }

        private void btnThongKeThuocVuotTuyen_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmGiamDinhThongKeThuocVuotTuyen f = new frmGiamDinhThongKeThuocVuotTuyen();
            f.Text = "Thống kê thuốc vượt tuyến";
            f.MdiParent = this;
            f.Show();
        }

        private void btnHuongDanSuDung_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmHuongDanSuDung f = new frmHuongDanSuDung();
            f.Text = "Hướng dẫn sử dụng";
            f.MdiParent = this;
            f.Show();
        }

        private void btnChiaDuLieu_7980a_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmChiaDuLieuSQLite_7980a f = new frmChiaDuLieuSQLite_7980a();
            f.Text = "Chia dữ liệu SQLite 7980a";
            f.MdiParent = this;
            f.Show();
        }

        private void timerMain_Tick(object sender, EventArgs e)
        {
            if(this.MdiChildren.Length == 0)
            {
                this.pictureEditMain.Show();
            }
        }

        private void btnGiamDinhQuyTac3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmGiamDinhDieuKien3 f = new frmGiamDinhDieuKien3();
            f.Text = "Giám định";
            f.MdiParent = this;
            f.Show();
        }

        private void btnDMQuyTac3_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmDMDieuKien3 f = new frmDMDieuKien3();
            f.Text = "Danh mục";
            f.MdiParent = this;
            f.Show();

        }

        private void bntGiamDinhSoSanhQuy_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmGiamDinhSoSanhKyQT f = new frmGiamDinhSoSanhKyQT();
            f.Text = "Giám Định So Sánh";
            f.MdiParent = this;
            f.Show();
        }

        private void btnDMQuyTacSoSanh_ItemClick(object sender, DevExpress.XtraBars.ItemClickEventArgs e)
        {
            this.pictureEditMain.Hide();
            frmDMDieuKienSoSanh f = new frmDMDieuKienSoSanh();
            f.Text = "Danh mục So Sánh";
            f.MdiParent = this;
            f.Show();
        }
    }
}
