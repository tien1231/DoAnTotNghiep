using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO;
using BUS;
using System.IO;
using System.Security.Cryptography;

namespace DoAnCShap
{
    public partial class Frm_ThongTinNhanVien : Form
    {
        public Frm_ThongTinNhanVien()
        {
            InitializeComponent();
            string condition = Login.SetValueForText1;
            LoadThongnTin(condition);
        }

        NhanVien_BUS bus = new NhanVien_BUS();
        NhanVien nv = new NhanVien();
        String DuongDanFolderHinh = @"C:\Users\Nguyen Khanh\source\repos\DATN\DoAnCShap\bin\Debug\Image";

        public void LoadThongnTin(string username)
        {
            dataGridViewNhanVien.DataSource = bus.LoadThongTin("select MaNV,ChucVu.TenCV,TenNV,GioiTinh,Email,NgaySinh,DienThoai,CMND,DiaChi,HinhAnh,UserName,PassWord,NhanVien.TrangThai From NhanVien,ChucVu where NhanVien.MaCV=ChucVu.MaCV and NhanVien.TrangThai=N'1' and UserName=N'" + username + "'");
        }

        string MatKhau = "";
        string TenHinh = "";

        private void dataGridViewNhanVien_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewNhanVien.SelectedRows)
            {
                txtMaNV.Text = row.Cells["ManV"].Value.ToString();
                txtTenNV.Text = row.Cells["TenNV"].Value.ToString();
                txtChucVu.Text = row.Cells["MaCV"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                txtCMND.Text = row.Cells["CMND"].Value.ToString();
                txtSDT.Text = row.Cells["DienThoai"].Value.ToString();
                string t = row.Cells["GioiTinh"].Value.ToString();
                if (t == "Nam")
                {
                    radioButNam.Checked = true;
                }
                else
                {
                    radioButNu.Checked = true;
                }
                string[] b = row.Cells["HinhAnh"].Value.ToString().Split(';');
                try
                {
                    int n;
                    if (b.Length == 1)
                        n = b.Length;
                    else
                        n = b.Length - 1;
                    for (int i = 0; i < n; i++)
                    {
                        PictureBox p = new PictureBox();
                        Size s = new Size(172, 172);
                        p.Size = s;
                        p.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Controls.Add(p);
                        Bitmap a = new Bitmap(Application.StartupPath + @"\Image\" + b[i]);
                        p.Image = a;
                        //TenHinh = b[i];
                    }
                }
                catch
                {

                }
                txtUserName.Text = row.Cells["UserName"].Value.ToString();
                MatKhau = row.Cells["PassWord"].Value.ToString();
                //...
            }
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
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

        private void btnLuu_Click(object sender, EventArgs e)
        {
            nv.MaNV = txtMaNV.Text;
            nv.TenNV = txtTenNV.Text;
            if (radioButNam.Checked == true)
            {
                nv.GioiTinh = radioButNam.Text;
            }
            else
            {
                nv.GioiTinh = radioButNu.Text;
            }
            nv.NgaySinh = dateTimePickerNgaySinh.Value.Date;
            nv.Email = txtEmail.Text;
            nv.DienThoai = txtSDT.Text;
            nv.UserName = txtUserName.Text;
            nv.CMND = txtCMND.Text;
            nv.DiaChi = txtDiaChi.Text;
            if (txtPassWord.Text == "")
            {
                nv.PassWord = MatKhau;
            }
            else
            {
                string Pas1 = CreateMd5(txtPassWord.Text);
                string Pas2 = CreateMd5(txtRePassWord.Text);
                txtPassWord.Text = Pas1;
                txtRePassWord.Text = Pas2;
                if (Pas1 == Pas2)
                {
                    nv.PassWord = txtPassWord.Text;
                }
                else
                {
                    MessageBox.Show("Lỗi", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            bus.UpateThongTinNV(nv);
            MessageBox.Show("Cập Nhật Thành Công");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtChucVu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtTenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtCMND_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
    }
}
