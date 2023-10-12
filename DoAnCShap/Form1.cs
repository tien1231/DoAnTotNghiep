using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
namespace DoAnCShap
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            hideSubMenu();

        }

        Login_BUS bus = new Login_BUS();



        private void btnExit_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thoát Hay Không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
            {
                //Do something here if OK was clicked.
                Application.Exit();
            }
        }
        private void hideSubMenu()
        {

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        public Form activeForm = null;

        public void openChildForm(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelChildForm.Controls.Add(childForm);
            panelChildForm.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void btn_TaiKhoan_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_LaylaiPass());
            lbl_HienThiForm.Text = "Danh Sách Tài Khoản";
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if (PhanQuyen(15))
            {
                openChildForm(new Frm_NhanVien());
                lbl_HienThiForm.Text = "Quản Lý Nhân Viên";
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Truy Cập", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }


        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            if (PhanQuyen(16))
            {
                openChildForm(new Frm_KH());
                lbl_HienThiForm.Text = "Quản Lý Khách Hàng";
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Truy Cập", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLinhKien_Click(object sender, EventArgs e)
        {
            if (PhanQuyen(17))
            {
                openChildForm(new Frm_SanPham());
                lbl_HienThiForm.Text = "Quản Lý Linh Kiện";
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Truy Cập", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNCC_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_NhaCungCap());
            lbl_HienThiForm.Text = "Quản Lý Nhà Cung Cấp";
        }

        private void btnPhieuNhap_Click(object sender, EventArgs e)
        {
            if (PhanQuyen(21))
            {
                openChildForm(new Frm_HoaDonNhap());
                lbl_HienThiForm.Text = "Nhập Hàng";
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Truy Cập", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void pictureBoxLogin_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            // login.TopLevel = false;
            // panelChildForm.Controls.Add(login);
            // login.Dock = DockStyle.None;
            login.BringToFront();
            login.ShowDialog();
        }

        private void btnHoaDon_Click(object sender, EventArgs e)
        {
            if (PhanQuyen(25))
            {
                openChildForm(new Frm_HoaDonBanHang());
                lbl_HienThiForm.Text = "Quản Lý Hóa Đơn Bán";
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Truy Cập", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void panelChildForm_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnBaoHanh_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //if (activeForm != null) activeForm.Close();
            //Form1 frm1 = new Form1();
            //frm1.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_Alert());
            lbl_HienThiForm.Text = "Tra Cứu Tổng Hợp";
        }


        public static string UserName = "";
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

        public bool PhanQuyen(int col)
        {
            bool KiemTra = false;
            for (int i = 0; i < bus.GetLogin1(Login.TenTaiKhoan).Rows.Count; i++)
            {
                if (bus.GetLogin1(Login.TenTaiKhoan).Rows[i][col].ToString() == "True")
                    return KiemTra = true;
            }

            return KiemTra;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            lbl_HienThiForm.Text = "Trang Chủ";
            //Login frmDN = new Login();
            //frmDN.ShowDialog();
            //if (Login.IsClose) this.Close();
            if (PhanQuyen(15)) btnNhanVien.Enabled = true; else btnNhanVien.Visible = false;
            if (PhanQuyen(16)) btnKhachHang.Enabled = true; else btnKhachHang.Visible = false;
            if (PhanQuyen(17)) btnLinhKien.Enabled = true; else btnLinhKien.Visible = false;
            if (PhanQuyen(18)) btnBanHang.Enabled = true; else btnBanHang.Visible = false;
            if (PhanQuyen(19)) btnNhaCungCap.Enabled = true; else btnNhaCungCap.Visible = false;
            if (PhanQuyen(20)) btnLoaiLK.Enabled = true; else btnLoaiLK.Visible = false;
            if (PhanQuyen(21)) btnPhieuNhap.Enabled = true; else btnPhieuNhap.Visible = false;
            if (PhanQuyen(22)) btnBaohanh.Enabled = true; else btnBaohanh.Visible = false;
            if (PhanQuyen(23)) btnPhanQuyen.Enabled = true; else btnPhanQuyen.Visible = false;
            if (PhanQuyen(24)) btnThongKe.Enabled = true; else btnThongKe.Visible = false;
            if (PhanQuyen(25)) btnHoaDon.Enabled = true; else btnHoaDon.Visible = false;
            if (PhanQuyen(26)) btnSetting.Enabled = true; else btnSetting.Visible = false;
            labelHienThiTenDangNhap.Text = Login.TenTaiKhoan;
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btn_HoaDonBan_Click(object sender, EventArgs e)
        {
            if (PhanQuyen(25))
            {
                openChildForm(new Frm_HoaDonBanHang());
                lbl_HienThiForm.Text = "Hóa Đơn Bán Hàng";
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Truy Cập", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void iconBtn_TaiKhoan_Click(object sender, EventArgs e)
        {
            openChildForm(new Frm_LaylaiPass());
            lbl_HienThiForm.Text = "Danh Sách Tài Khoản";
        }

        private void iconBtn_Close_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Bạn Có Muốn Thoát Hay Không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK)
            {
                //Do something here if OK was clicked.
                Application.Exit();
            }
        }

        private void iconBtnThuNho_Click(object sender, EventArgs e)
        {
            if (panelSideMenu.Width == 60)
            {
                panelSideMenu.Width = 229;
                btnNhanVien.Text = "Quản lý nhân viên";
                btnKhachHang.Text = "Quản lý khách hàng";
                btnHoaDon.Text = "Quản lý hóa đơn bán";
                btnPhieuNhap.Text = "Nhập hàng";
                btnLinhKien.Text = "Linh kiện";
                btnLoaiLK.Text = "Loại linh kiện";
                btnNhaCungCap.Text = "Nhà cung cấp";
                btnBanHang.Text = "Bán hàng";
                btnBaohanh.Text = "Bảo hành";
                btnThongKe.Text = "Thống kê";
                btnProfile.Text = "Thông tin cá nhân";
                btnSetting.Text = "Setting";
                btnPhanQuyen.Text = "Phân quyền";
            }
            else
            {
                panelSideMenu.Width = 60;
                btnNhanVien.Text = "";
                btnKhachHang.Text = "";
                btnHoaDon.Text = "";
                btnPhieuNhap.Text = "";
                btnLinhKien.Text = "";
                btnLoaiLK.Text = "";
                btnNhaCungCap.Text = "";
                btnBanHang.Text = "";
                btnBaohanh.Text = "";
                btnThongKe.Text = "";
                btnProfile.Text = "";
                btnSetting.Text = "";
                btnPhanQuyen.Text = "";
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có muốn đăng xuất hay không ?", "Thông Báo !", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (KQ == DialogResult.Yes)
            {
                this.Close();
                Login lg = new Login();
                lg.Show();
            }
            else
            {

            }

        }


        private void btnNhaCungCap_Click(object sender, EventArgs e)
        {
            if (PhanQuyen(19))
            {
                lbl_HienThiForm.Text = "Nhà Cung Cấp";
                openChildForm(new Frm_NhaCungCap());
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Truy Cập", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBanHang_Click(object sender, EventArgs e)
        {
            if (PhanQuyen(18))
            {
                lbl_HienThiForm.Text = "Bán Hàng";
                openChildForm(new Frm_BanHan());
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Truy Cập", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnBaohanh_Click_1(object sender, EventArgs e)
        {
            if (PhanQuyen(22))
            {
                lbl_HienThiForm.Text = "Bảo Hành";
                openChildForm(new Frm_BaoHanh());
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Truy Cập", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnThongKe_Click_1(object sender, EventArgs e)
        {
            if (PhanQuyen(24))
            {
                lbl_HienThiForm.Text = "Thống Kê";
                openChildForm(new Frm_ThongKe());
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Truy Cập", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnPhanQuyen_Click_1(object sender, EventArgs e)
        {
            if (PhanQuyen(23))
            {
                lbl_HienThiForm.Text = "Phân Quyền Tài Khoản";
                openChildForm(new Frm_ChucVu());
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Truy Cập", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLoaiLK_Click(object sender, EventArgs e)
        {
            if (PhanQuyen(20))
            {
                lbl_HienThiForm.Text = "Loại Linh Kiện";
                openChildForm(new Frm_LLinhKien());
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Truy Cập", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnNhaSanXuat_Click(object sender, EventArgs e)
        {
            lbl_HienThiForm.Text = "Nhà Sản Xuất";
            openChildForm(new Frm_NSX());
        }

        public static string SetValueForText1 = "";

        private void labelHienThiTenDangNhap_Click(object sender, EventArgs e)
        {
            lbl_HienThiForm.Text = "Thông Tin Cá Nhân";
            openChildForm(new Frm_ThongTinNhanVien());
        }

        private void btnSetting_Click_1(object sender, EventArgs e)
        {
            if (PhanQuyen(26))
            {
                lbl_HienThiForm.Text = "Setting";
                openChildForm(new Frm_Setting());
            }
            else
            {
                MessageBox.Show("Bạn Không Có Quyền Truy Cập", "Cảnh Báo", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public void UpdateFormColor()
        {
            this.BackColor = Color.YellowGreen;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            timer1.Enabled = false;
            string day = DateTime.Today.ToString("dddd");
            string year = DateTime.Now.Year.ToString("0000");
            string month = DateTime.Now.Month.ToString("00");
            string date = DateTime.Now.Day.ToString("00");
            string hour = DateTime.Now.Hour.ToString("00");
            string minute = DateTime.Now.Minute.ToString("00");
            string second = DateTime.Now.Second.ToString("00");
            string month2;
            string day2;

            switch (month)
            {
                case "01":
                    month2 = "Tháng 1";
                    break;
                case "02":
                    month2 = "Tháng 2";
                    break;
                case "03":
                    month2 = "Tháng 3";
                    break;
                case "04":
                    month2 = "Tháng 4";
                    break;
                case "05":
                    month2 = "Tháng 5";
                    break;
                case "06":
                    month2 = "Tháng 6";
                    break;
                case "07":
                    month2 = "Tháng 7";
                    break;
                case "08":
                    month2 = "Tháng 8";
                    break;
                case "09":
                    month2 = "Tháng 9";
                    break;
                case "10":
                    month2 = "Tháng 10";
                    break;
                case "11":
                    month2 = "Tháng 11";
                    break;
                case "12":
                    month2 = "Tháng 12";
                    break;
                default:
                    month2 = "UnKnown";
                    break;
            }

            switch (day)
            {
                case "Sun":
                    day2 = "Chủ Nhật";
                    break;
                case "Mon":
                    day2 = "Thứ 2";
                    break;
                case "Tue":
                    day2 = "Thứ 3";
                    break;
                case "Wed":
                    day2 = "Thứ 4";
                    break;
                case "Thu":
                    day2 = "Thứ 5";
                    break;
                case "Fri":
                    day2 = "Thứ 6";
                    break;
                case "Sat":
                    day2 = "Thứ 7";
                    break;
                case "Sunday":
                    day2 = "Chủ Nhật";
                    break;
                case "Monday":
                    day2 = "Thứ 2";
                    break;
                case "Tuesday":
                    day2 = "Thứ 3";
                    break;
                case "Wednesday":
                    day2 = "Thứ 4";
                    break;
                case "Thursday":
                    day2 = "Thứ 5";
                    break;
                case "Friday":
                    day2 = "Thứ 6";
                    break;
                case "Saturday":
                    day2 = "Thứ 7";
                    break;
                //I'm Use Jakarta Timezone, change this case from your Timezone
                case "Minggu":
                    day2 = "Chủ Nhật";
                    break;
                case "Senin":
                    day2 = "Thứ 2";
                    break;
                case "Selasa":
                    day2 = "Thứ 3";
                    break;
                case "Rabu":
                    day2 = "Thứ 4";
                    break;
                case "Kamis":
                    day2 = "Thứ 5";
                    break;
                case "Jum'at":
                    day2 = "Thứ 6";
                    break;
                case "Jumat":
                    day2 = "Thứ 7";
                    break;
                case "Sabtu":
                    day2 = "Chủ Nhật";
                    break;
                default:
                    day2 = "UnKnown";
                    break;
            }
            labeldateTime.Text = day2 + " , " + date + " " + month2 + " " + year + "  " + hour + ":" + minute + ":" + second;
            labeldateTime.Update();
            timer1.Enabled = true;
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            lbl_HienThiForm.Text = "Thông Tin Cá Nhân";
            openChildForm(new Frm_ThongTinNhanVien());
        }

        private void label11_Click(object sender, EventArgs e)
        {

        }
    }
}
