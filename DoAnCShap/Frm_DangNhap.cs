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

namespace DoAnCShap
{
    public partial class Frm_DangNhap : Form
    {
        public Frm_DangNhap()
        {
            InitializeComponent();
        }
        private static bool _exiting;

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

        private void btnThoat_Click(object sender, EventArgs e)
        {
            if (!_exiting && MessageBox.Show("Are you sure want to exit?",
                         "My First Application",
                          MessageBoxButtons.OKCancel,
                          MessageBoxIcon.Information) == DialogResult.OK)
            {
                _exiting = true;
                // this.Close(); // you don't need that, it's already closing
                Environment.Exit(1);
            }
        }

        public static string SetValueForText1 = "";
        private void btnDangNhap_Click(object sender, EventArgs e)
        {
            String username = txtTenDN.Text;
            String password = CreateMd5(txtMatKhau.Text);
            //MaHoa();
            SqlConnection sql = new SqlConnection(@"Data Source=DESKTOP-L3VUEAK; Initial Catalog =PM_BanLinhKienPC;Integrated Security = True");
            string query = "Select * From NhanVien Where UserName =N'" + username + "' and PassWord=N'" + password + "' and TrangThai=N'Mới'";
            SqlDataAdapter sda = new SqlDataAdapter(query, sql);
            DataTable dt = new DataTable();
            sda.Fill(dt);
            if (dt.Rows.Count == 1)
            {
                MessageBox.Show("Đăng Nhập Thành Công");
                {

                    Form1 f = new Form1();
                    SetValueForText1 = username;
                    f.ShowDialog();
                }
            }
            else
            {
                MessageBox.Show("Fail Username and PassWord !");
            }
        }
    }
}
