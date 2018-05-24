using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Security.Cryptography;
using System.IO;
using System.Text.RegularExpressions;
using System.Globalization;
using System.Threading;
//using System.Drawing;
using System.Net.NetworkInformation;
using System.Net;
using System.Net.Sockets;
using System.Management;
using System.Drawing;
using System.Windows.Forms;
//CreateTimes : 17/03/2016 16:50:39.PM

namespace Bitas
{
	public class Multi
	{		
        //Dinh dang ngay
		public bool FormatDatetime()
		{
			try
			{
				System.Globalization.CultureInfo culture = new System.Globalization.CultureInfo("en-US", true);
				DateTimeFormatInfo dfi = (DateTimeFormatInfo)culture.DateTimeFormat.Clone();
				dfi.ShortDatePattern = "dd/MM/yyyy";
				dfi.LongDatePattern = "dd/MM/yyyy HH:mm:ss tt";
				culture.NumberFormat.NumberDecimalSeparator = ".";
				culture.DateTimeFormat = dfi;
				System.Windows.Forms.Application.CurrentCulture = culture;
				return true;
			}
			catch(Exception ex)
			{
                MessageBox.Show("Không thể định dạng được ngày tháng năm.\r\n" + ex.Message,"Thông báo",MessageBoxButtons.OK, MessageBoxIcon.Error);
				return false;
			}
		}
        //Tinh so ngay trong thang
		public double GetNuminMonth(int thanghientai)
		{
			DateTime time = new DateTime();
			if (thanghientai == 12)
			{
				time = new DateTime(DateTime.Today.Year + 1, 1, 1);
			}
			else
			{
				time = new DateTime(DateTime.Today.Year, thanghientai + 1, 1);
			}
			DateTime time2 = new DateTime(DateTime.Today.Year, thanghientai, 1);
			TimeSpan span = (TimeSpan)(time - time2);
			return span.TotalDays;            
		}
        //Doc so thanh chu
		public string ConvertNumTostring(decimal number)
		{
			string s = number.ToString("#");
			string[] so = new string[] { "không", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
			string[] hang = new string[] { "", "ngàn", "triệu", "tỷ" };
			int i, j, donvi, chuc, tram;
			string str = " ";
			bool booAm = false;
			decimal decS = 0;
			try
			{
				decS = Convert.ToDecimal(s.ToString());
			}
			catch
			{
			}
			if (decS < 0)
			{
				decS = -decS;
				s = decS.ToString();
				booAm = true;
			}
			i = s.Length;
			if (i == 0)
				str = so[0] + str;
			else
			{
				j = 0;
				while (i > 0)
				{
					donvi = Convert.ToInt32(s.Substring(i - 1, 1));
					i--;
					if (i > 0)
						chuc = Convert.ToInt32(s.Substring(i - 1, 1));
					else
						chuc = -1;
					i--;
					if (i > 0)
						tram = Convert.ToInt32(s.Substring(i - 1, 1));
					else
						tram = -1;
					i--;
					if ((donvi > 0) || (chuc > 0) || (tram > 0) || (j == 3))
						str = hang[j] + str;
					j++;
					if (j > 3) j = 1;
					if ((donvi == 1) && (chuc > 1))
						str = "một" + str;
					else
					{
						if ((donvi == 5) && (chuc > 0))
							str = "lăm " + str;
						else if (donvi > 0)
							str = so[donvi] + " " + str;
					}
					if (chuc < 0)
						break;
					else
					{
						if ((chuc == 0) && (donvi > 0)) str = "lẻ " + str;
						if (chuc == 1) str = " mười " + str;
						if (chuc > 1) str = so[chuc] + " mươi " + str;
					}
					if (tram < 0) break;
					else
					{
						if ((tram > 0) || (chuc > 0) || (donvi > 0)) str = so[tram] + " trăm " + str;
					}
					str = " " + str;
				}
			}
			if (booAm) str = "Âm " + str;
			return VietHoa(str + "đồng.");
		}
        //Viet hoa ky tu dau
		public static string VietHoa(string s)
		{
			if (String.IsNullOrEmpty(s))
				return s;
			string result = "";
			string[] words = s.Split(' ');
			foreach (string word in words)
			{
				if (word.Trim() != "")
				{
					if (word.Length > 1)
						result += word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower() + " ";
					else
						result += word.ToUpper() + " ";
				}
			}
			return result.Trim();
		}
		//Ghi file
        public void WriteLine(string text, string path)
        {
            using (StreamWriter writer = new StreamWriter(path))
            {
                writer.Flush();
                writer.WriteLine(text);
            }
        }
        //Doc file 
        public string ReadLine(string path)
        {
            using (StreamReader reader = new StreamReader(path))
            {
                return reader.ReadLine();
            }
        }
        //Ma hoa
        public string EncryptBase64(string str)
        { 
            var bytes = Encoding.UTF8.GetBytes(str);
            var base64 = Convert.ToBase64String(bytes);
            return base64;
        }
        //Giai ma
        public string DecryptBase64(string str)
        {
            var base64 = str;
            var data = Convert.FromBase64String(base64);
            var text = Encoding.UTF8.GetString(data);
            return text;
        }
        //Lay IP may
        public string GetIPAddress()
        {
            IPHostEntry host;
            string localIP = "";
            host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (IPAddress ip in host.AddressList)
            {
                localIP = ip.ToString();
                string[] temp = localIP.Split('.');
                if (ip.AddressFamily == AddressFamily.InterNetwork && temp[0] == "192")
                    break;
                else
                    localIP = null;
            }
            return localIP;
        }
        public string GetMacAddress()
        {
            ManagementClass mc = new ManagementClass("Win32_NetworkAdapterConfiguration");
            ManagementObjectCollection moc = mc.GetInstances();
            string MACAddress = String.Empty;
            foreach (ManagementObject mo in moc)
            {
                if (MACAddress == String.Empty)
                {
                    if ((bool)mo["IPEnabled"] == true) MACAddress = mo["MacAddress"].ToString();
                }
                mo.Dispose();
            }
            return MACAddress;
        }
        //Chuyen chuoi ky tu co dau thanh khong dau
        public string ConvertToUnsign(string str)
        {
            string strFormD = str.Normalize(NormalizationForm.FormD);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < strFormD.Length; i++)
            {
                System.Globalization.UnicodeCategory uc =
                System.Globalization.CharUnicodeInfo.GetUnicodeCategory(strFormD[i]);
                if (uc != System.Globalization.UnicodeCategory.NonSpacingMark)
                {
                    sb.Append(strFormD[i]);
                }
            }
            sb = sb.Replace('Đ', 'D');
            sb = sb.Replace('đ', 'd');
            return (sb.ToString().Normalize(NormalizationForm.FormD).ToUpper().Replace(" ", ""));
        }
        //Tao chu hoa ky tu dau
        public string UpperOne(string s)
        {
            if (String.IsNullOrEmpty(s))
                return s;
            string result = "";
            string[] words = s.Split(' ');
            foreach (string word in words)
            {
                if (word.Trim() != "")
                {
                    if (word.Length > 1)
                        result += word.Substring(0, 1).ToUpper() + word.Substring(1).ToLower() + " ";
                    else
                        result += word.ToUpper() + " ";
                }
            }
            return result.Trim();
        }
        //Chuyen doi kich thuot anh
        public Image ScaleImage(Image image, int maxWidth, int maxHeight)
        {
            var ratioX = (double)maxWidth / image.Width;
            var ratioY = (double)maxHeight / image.Height;
            var ratio = Math.Min(ratioX, ratioY);

            var newWidth = (int)(image.Width * ratio);
            var newHeight = (int)(image.Height * ratio);

            var newImage = new Bitmap(newWidth, newHeight);

            using (var graphics = Graphics.FromImage(newImage))
                graphics.DrawImage(image, 0, 0, newWidth, newHeight);

            return newImage;
        }
	}
}

