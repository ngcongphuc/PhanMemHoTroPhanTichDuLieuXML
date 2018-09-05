using System;
using System.IO;
using System.Linq;
using System.Net.NetworkInformation;
using System.Security.Cryptography;
using System.Text;

namespace PhanTichDuLieu.Helper
{
    class LicenceHelper
    {
        static public string GetMd5Hash(MD5 md5Hash, string input)
        {
            byte[] data = md5Hash.ComputeHash(Encoding.UTF8.GetBytes(input));
            StringBuilder sBuilder = new StringBuilder();
            for (int i = 0; i < data.Length; i++)
            {
                sBuilder.Append(data[i].ToString("x2"));
            }

            return sBuilder.ToString();
        }

        static public bool VerifyMd5Hash(MD5 md5Hash, string input, string hash)
        {
            string hashOfInput = GetMd5Hash(md5Hash, input);

            StringComparer comparer = StringComparer.OrdinalIgnoreCase;

            if (0 == comparer.Compare(hashOfInput, hash))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        public bool CheckLicense(string code)
        {
            if (code != "doconvit")
                return false;
            string _strFileName = Directory.GetCurrentDirectory() + @"\key.txt";
            string[] lines = File.ReadAllLines(_strFileName);
            string _licence = lines[0].ToString().Trim();

            String MAC = NetworkInterface
            .GetAllNetworkInterfaces()
            .Where(nic => nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)
            .Select(nic => nic.GetPhysicalAddress().ToString())
            .FirstOrDefault();

            string tenMayTinh = Environment.MachineName.ToString();
            string heDieuHanh = Environment.OSVersion.ToString();


            string _key = "v1n2" + tenMayTinh + "_7ncp9." + heDieuHanh;

            using (MD5 md5Hash = MD5.Create())
            {
                string hash = LicenceHelper.GetMd5Hash(md5Hash, _key);
                hash = LicenceHelper.GetMd5Hash(md5Hash, hash + "!_");

                if (_licence == hash)
                    return true;
                else
                    return false;
            }
        }
        public string GetLicense(string key, string code)
        {
            if (code != "doconvit")
                return "đồ con vịt";
            using (MD5 md5Hash = MD5.Create())
            {
                string hash = LicenceHelper.GetMd5Hash(md5Hash, key);
                hash = LicenceHelper.GetMd5Hash(md5Hash, hash + "_");
                hash = LicenceHelper.GetMd5Hash(md5Hash, "." + hash + ",");
                return hash;
            }
        }

        public void GetLicense(string code)
        {
            if (code != "doconvit")
                return;
            String MAC = NetworkInterface
            .GetAllNetworkInterfaces()
            .Where(nic => nic.OperationalStatus == OperationalStatus.Up && nic.NetworkInterfaceType != NetworkInterfaceType.Loopback)
            .Select(nic => nic.GetPhysicalAddress().ToString())
            .FirstOrDefault();

            string tenMayTinh = Environment.MachineName.ToString();
            string heDieuHanh = Environment.OSVersion.ToString();


            string _key = "v1n2" + tenMayTinh + "_7ncp9." + heDieuHanh;

            using (MD5 md5Hash = MD5.Create())
            {
                string hash = LicenceHelper.GetMd5Hash(md5Hash, _key);
                hash = LicenceHelper.GetMd5Hash(md5Hash, hash + "!_");

                string[] lines = { hash };
                string _strFileName = Directory.GetCurrentDirectory() + @"\key.txt";
                System.IO.File.WriteAllLines(_strFileName, lines);
            }
        }
    }
}
