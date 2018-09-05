using System;
using System.Net.Mail;
using System.Net;
using System.Diagnostics;
using Microsoft.Win32;
using System.Net.NetworkInformation;
using System.Linq;

namespace MyFunctionDLL
{
    public class MailHelper
    {
        static string _subject = "";
        static string _body = "";
        static bool _flag = false;

        static private void initString()
        {
            ////////////////////////////////////////
            string ngayHienTai = "Ngày " + DateTime.Now.Day.ToString() + ", tháng " + DateTime.Now.Month.ToString() + ", năm " + DateTime.Now.Year.ToString();
            string gioHienTai = DateTime.Now.Hour.ToString() + " giờ, " + DateTime.Now.Minute.ToString() + " phút, " + DateTime.Now.Second.ToString() + " giây";
            string tenMayTinh = Environment.MachineName.ToString();
            string heDieuHanh = Environment.OSVersion.ToString();
            System.OperatingSystem os = Environment.OSVersion;
            string congNgheNen = os.Platform.ToString();
            RegistryKey rk = Registry.LocalMachine;
            rk = rk.OpenSubKey("HARDWARE\\DESCRIPTION\\System\\CentralProcessor\\0");
            string boViXuLy = rk.GetValue("ProcessorNameString").ToString();
            System.Diagnostics.Process p = Process.GetCurrentProcess();

            //IP
            String strHostName = Dns.GetHostName();

            // Find host by name
            IPHostEntry iphostentry = Dns.GetHostByName(strHostName);
            // Enumerate IP addresses\
            string IP = "";
            foreach (IPAddress ipaddress in iphostentry.AddressList)
            {
                IP = ipaddress.ToString();
            }

            String MAC = NetworkInterface
            .GetAllNetworkInterfaces()
            .Where(nic => nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)
            .Select(nic => nic.GetPhysicalAddress().ToString())
            .FirstOrDefault();


            string externalip = new WebClient().DownloadString("http://icanhazip.com");
            externalip = externalip.Trim();
            _subject = "Phần Mềm_" + externalip + "_" + IP + "_" + tenMayTinh + "_" + MAC;

            _body = "Public IP: " + externalip + "\n" +
                            "Local IP: " + IP + "\n" +
                            "MAC: " + MAC + "\n" +
                            "Ngày hiện hại: " + ngayHienTai + "\n" +
                            "Giờ hiện tại: " + gioHienTai + "\n" +
                            "Tên máy tính: " + tenMayTinh + "\n" +
                            "Hệ điều hành: " + heDieuHanh + "\n" +
                            "Vi xử lý: " + boViXuLy + "\n";
        }

        public void sendMail()
        {
            initString();
            sendMail1();
            if (!_flag)
            {
                sendMail2();
            }
            if (!_flag)
            {
                sendMail3();
            }
        }
        public void sendMail_licence()
        {
            initString();
            sendMail1();
            if (!_flag)
            {
                sendMail2();
            }
            if (!_flag)
            {
                sendMail3();
            }
        }
         private void sendMail1()
        {
            try
            {
                SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                mailclient.EnableSsl = true;
                mailclient.Credentials = new NetworkCredential("ngcongphuc@gmail.com", "Nguoitoieu....");

                MailMessage message = new MailMessage("ngcongphuc@gmail.com", "generalentertainmentvn@gmail.com");
                message.CC.Add("hnkien1981@gmail.com");

                message.Subject = _subject;
                message.Body = _body;

                mailclient.Send(message);
                _flag = true;
            }
            catch
            {
            }
        }

        static private void sendMail2()
        {
            try
            {
                SmtpClient mailclient = new SmtpClient("smtp.gmail.com", 587);
                mailclient.EnableSsl = true;
                mailclient.Credentials = new NetworkCredential("generalentertainmentvn@gmail.com", "CongphuC");

                MailMessage message = new MailMessage("generalentertainmentvn@gmail.com", "generalentertainmentvn@gmail.com");
                message.CC.Add("hnkien1981@gmail.com");

                message.Subject = _subject;
                message.Body = _body;

                mailclient.Send(message);
                _flag = true;
                //MessageBox.Show("Mail đã được gửi đi", "Thành công", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch
            {
            }
        }

        static private void sendMail3()
        {
            try
            {
                SmtpClient mailclient = new SmtpClient("smtp.mail.yahoo.com", 587);
                mailclient.EnableSsl = true;
                mailclient.Credentials = new NetworkCredential("ngcongphuc@yahoo.com.vn", "CongphuC9x");

                MailMessage message = new MailMessage("ngcongphuc@yahoo.com.vn", "generalentertainmentvn@gmail.com");
                message.CC.Add("hnkien1981@gmail.com");

                message.Subject = _subject;
                message.Body = _body;

                mailclient.Send(message);
                _flag = true;
            }
            catch
            {
            }
        }
    }
}
