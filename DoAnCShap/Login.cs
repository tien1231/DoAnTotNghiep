using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace DoAnCShap
{
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        Login_BUS bus = new Login_BUS();
        NhanVien nv = new NhanVien();
        private static bool _exiting;
        MD5 md = MD5.Create();

        public void HienThiCV()
        {
        }
        private void btnThoat_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }


        public void MaHoa()
        {
            byte[] inputstr = System.Text.Encoding.ASCII.GetBytes(txtMatKhau.Text);
            byte[] hask = md.ComputeHash(inputstr);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hask.Length; i++)
            {
                sb.Append(hask[i].ToString("X2"));
            }
            txtMatKhau.Text = sb.ToString();
        }

        public static string CreateMd5(string input)
        {
            MD5 md5 = System.Security.Cryptography.MD5.Create();
            byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
            byte[] hasBytes = md5.ComputeHash(inputBytes);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hasBytes.Length; i++)
            {
                sb.Append(hasBytes[i].ToString("X2"));
            }
            return sb.ToString();
        }

        string hash = "f0xle@rn";//Create a hash key

        public void MaHoaMD5()
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(txtMatKhau.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));//Get hash key
                //Encrypt data by hash key
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    txtMatKhau.Text = Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }
        public static string SetValueForText1 = "";
        public static string SetValueForText2 = "";

        public static string BtnPhanQuyen;
        public static string ID_USER = "";
        public static bool IsClose = false;
        public static bool QLNV;//4
        public static bool QLKH;
        public static bool QLLK;
        public static bool QLLLK;
        public static bool QLBH;
        public static bool BaoHanh;
        public static bool QLNCC;
        public static bool QLNK;
        public static bool PhanQuyenn;
        public static bool ThongKe;
        public static bool HoaDon;
        public static bool Setting;
        public static string TenTaiKhoan = "";//lấy thêm têm tài khoản nhé, 

        public bool PhanQuyen(int col)
        {
            bool KiemTra = false;
            for (int i = 0; i < bus.GetLogin(txtTenDN.Text, CreateMd5(txtMatKhau.Text)).Rows.Count; i++)
            {
                if (bus.GetLogin(txtTenDN.Text, CreateMd5(txtMatKhau.Text)).Rows[i][col].ToString() == "True")
                    return KiemTra = true;
            }
            return KiemTra;
        }

        public bool KiemTraChucVu()
        {
            bool KiemTra = false;
            for (int i = 0; i < bus.GetLogin1(txtTenDN.Text).Rows.Count; i++)
            {
                if (bus.GetLogin1(txtTenDN.Text).Rows[i][1].ToString() == "CV01")
                    return KiemTra = true;
            }
            return KiemTra;
        }
        int demsolanLogin = 0;
        private void btnLogin_Click(object sender, EventArgs e)
        {
            string username = txtTenDN.Text;
            string password = txtMatKhau.Text;

            int count = bus.GetLogin(username, CreateMd5(password)).Rows.Count;
            if (txtTenDN.Text == "")
            {
                labelMessBox.Text = "Tên Đăng Nhập Không Được để trống";
                return;
            }
            if (txtMatKhau.Text == "")
            {
                labelMessBox.Text = "Mật Khẩu Không Được để trống";
                return;
            }
            if (count == 0)
            {
                labelMessBox.Text = "Tên Đăng Nhập Hoặc mật khẩu không đúng";

                if (KiemTraChucVu() == true)
                {
                    demsolanLogin++;
                    if (demsolanLogin == 5)
                    {
                        linklblQuenPass.Visible = true;
                    }
                    else
                    {

                    }

                }
            }
            else
            {
                TenTaiKhoan = bus.GetLogin(username, CreateMd5(password)).Rows[0][10].ToString();
                SetValueForText1 = username;
                Form1 frm1 = new Form1();
                frm1.Show();
                //QLNV = PhanQuyen(15);
                //QLKH = PhanQuyen(16);
                //QLLK = PhanQuyen(17);
                //QLBH = PhanQuyen(18);
                //QLNCC = PhanQuyen(19);
                //QLLLK = PhanQuyen(20);
                //QLNK = PhanQuyen(21);
                //BaoHanh = PhanQuyen(22);
                //PhanQuyenn = PhanQuyen(23);
                //ThongKe = PhanQuyen(24);
                //HoaDon = PhanQuyen(25);
                //Setting = PhanQuyen(26);
                this.Close();
            }

        }

        private void Login_Load(object sender, EventArgs e)
        {
            //HienThiCV();

        }

        private void txtMatKhau_TextChanged(object sender, EventArgs e)
        {

        }

        private void linklblQuenPass_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Close();
            Frm_LaylaiPass frm_LaylaiPass = new Frm_LaylaiPass();
            frm_LaylaiPass.Show();
        }
    }
}
