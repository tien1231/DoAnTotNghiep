using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BUS;
using DTO;
using System.Diagnostics;
using System.IO;


namespace DoAnCShap
{
    public partial class Frm_NhanVien : Form
    {
        public Frm_NhanVien()
        {
            InitializeComponent();
            Display();
            hienthichucvu();
        }

        String DuongDanFolderHinh = @"C:\Users\Nguyen Khanh\source\repos\DATN\DoAnCShap\bin\Debug\Image";
        MD5 md = MD5.Create();
        NhanVien_BUS bus = new NhanVien_BUS();
        ChucVu_BUS buss = new ChucVu_BUS();
        NhanVien nv = new NhanVien();
        string PassW = "";
        int flag = 0;

        public void xulytextbox(Boolean b1, Boolean b2)
        {
            txtMaNV.Enabled = b1;
            cboChucVu.Enabled = b1;
            txtUserName.Enabled = b1;
            txtPassWord.Enabled = b1;
            txtTenNV.Enabled = b1;
            radioButtonNam.Enabled = b1;
            radioButtonNu.Enabled = b1;
            txtEmail.Enabled = b1;
            txtSDT.Enabled = b1;
            txtCMND.Enabled = b1;
            txtDiaChi.Enabled = b1;
        }

        public void Clear()
        {
            pictureBox1.Controls.Clear();
            txtMaNV.Clear();
            cboChucVu.ResetText();
            txtUserName.Clear();
            txtPassWord.Clear();
            txtTenNV.Clear();
            txtEmail.Clear();
            txtSDT.Clear();
            txtCMND.Clear();
            txtDiaChi.Clear();
            erroMes.Clear();
        }
        public void xulychucnang(Boolean b1, Boolean b2, Boolean b3)
        {
            btnThem.Enabled = b1;
            btnXoa.Enabled = b3;
            btnLuu.Enabled = b2;
            btnHuy.Enabled = b2;
        }

        public string PhatSinhMaNv(DataTable d)
        {
            int sodong = d.Rows.Count;
            string macuoi;
            if (sodong > 9)
                macuoi = d.Rows[sodong - 1]["MaNV"].ToString().Substring(2, 2);
            else
                macuoi = d.Rows[sodong - 1]["MaNV"].ToString().Substring(3, 1);
            return (int.Parse(macuoi) + 1).ToString();
        }
        void Display()
        {
            dataGridViewNhanVien.DataSource = bus.GetData("");

        }

        public void HienThiSearch(string Condition)
        {
            dataGridViewNhanVien.DataSource = bus.GetTimKiem("" + Condition);
        }
        public void hienthichucvu()
        {
            cboChucVu.DataSource = buss.GetChucVu("");
            cboChucVu.DisplayMember = "TenCV";
            cboChucVu.ValueMember = "MaCV";
        }

        //string hash = "X2";
        public void MaHoa()
        {
            byte[] inputstr = System.Text.Encoding.ASCII.GetBytes(txtPassWord.Text);
            byte[] hask = md.ComputeHash(inputstr);
            StringBuilder sb = new StringBuilder();
            for (int i = 0; i < hask.Length; i++)
            {
                sb.Append(hask[i].ToString("X2"));
            }
            txtPassWord.Text = sb.ToString();

        }
        string hash = "f0xle@rn";//Create a hash key
        public void MaHoa1()
        {
            byte[] data = UTF8Encoding.UTF8.GetBytes(txtPassWord.Text);
            using (MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider())
            {
                byte[] keys = md5.ComputeHash(UTF8Encoding.UTF8.GetBytes(hash));//Get hash key
                //Encrypt data by hash key
                using (TripleDESCryptoServiceProvider tripDes = new TripleDESCryptoServiceProvider() { Key = keys, Mode = CipherMode.ECB, Padding = PaddingMode.PKCS7 })
                {
                    ICryptoTransform transform = tripDes.CreateEncryptor();
                    byte[] results = transform.TransformFinalBlock(data, 0, data.Length);
                    txtPassWord.Text = Convert.ToBase64String(results, 0, results.Length);
                }
            }
        }
        String TenHinh = "";
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            pictureBox1.Controls.Clear();
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Select a Image";
            opFile.Filter = "Files|*.jpg;*.jpeg;*.png;....";

            //string appPath = Path.GetDirectoryName(Application.ExecutablePath) + @"\Image\"; // <---
            //if (Directory.Exists(appPath) == false)                                              // <---
            //{                                                                                    // <---
            //    Directory.CreateDirectory(appPath);                                              // <---
            //}                                                                                    // <---

            //if (opFile.ShowDialog() == DialogResult.OK)
            //{
            //    try
            //    {
            //        string iName = opFile.SafeFileName;   // <---
            //        string filepath = opFile.FileName;    // <---
            //        File.Copy(filepath, appPath + iName); // <---
            //        pictureBox1.Image = new Bitmap(opFile.OpenFile());
            //        TenHinh = iName;
            //    }
            //    catch (Exception exp)
            //    {
            //        //MessageBox.Show("Ảnh đã tồn tại !" + exp.Message);
            //        MessageBox.Show("Ảnh đã tồn tại !");
            //    }
            //}
            //else
            //{
            //    opFile.Dispose();
            //}
            if (opFile.ShowDialog() == DialogResult.OK)
            {
                TenHinh = opFile.FileName;
                pictureBox1.Image = new Bitmap(opFile.FileName);
                pictureBox1.ImageLocation = opFile.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }

        }

        public void LuuAnh()
        {
            try
            {
                File.Copy(TenHinh, Application.StartupPath + @"\Image\" + Path.GetFileName(pictureBox1.ImageLocation));
            }
            catch
            {

            }
        }

        public void XoaAnh()
        {
            File.Delete(@"C:\Users\Nguyen Khanh\source\repos\DATN\DoAnCShap\bin\Debug\Image\" + TenHinh);
        }


        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void Frm_NhanVien_Load(object sender, EventArgs e)
        {
            xulytextbox(false, true);
            xulychucnang(true, false, false);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            xulytextbox(true, false);
            Clear();
            xulychucnang(false, true, false);
            if (bus.PhatSinhMa("").Rows.Count == 0)
            {
                txtMaNV.Text = "NV00";
            }
            else
            {
                if (int.Parse(PhatSinhMaNv(bus.PhatSinhMa(""))) < 10)
                    txtMaNV.Text = "NV0" + PhatSinhMaNv(bus.PhatSinhMa(""));
                else
                    txtMaNV.Text = "NV" + PhatSinhMaNv(bus.PhatSinhMa(""));
            }

        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                if (cboChucVu.Text == "")
                {
                    erroMes.BlinkRate = 100;
                    erroMes.SetError(cboChucVu, "Chưa chọn chức vụ");
                    return;
                }
                if (txtTenNV.Text == "")
                {
                    erroMes.BlinkRate = 100;
                    erroMes.SetError(txtTenNV, "? Tên nhân viên");
                    return;
                }
                if (txtSDT.Text == "")
                {
                    erroMes.BlinkRate = 100;
                    erroMes.SetError(txtSDT, "? SDT");
                    return;
                }
                if (txtSDT.Text.Length < 10 || txtSDT.Text.Length > 12)
                {
                    erroMes.BlinkRate = 100;
                    erroMes.SetError(txtSDT, "Số điện thoại không đúng");
                    return;
                }
                for (int i = 0; i < dataGridViewNhanVien.Rows.Count - 0; i++)
                {
                    if (txtSDT.Text == dataGridViewNhanVien.Rows[i].Cells["DienThoai"].Value.ToString())
                    {
                        erroMes.BlinkRate = 100;
                        erroMes.SetError(txtSDT, "Đã tồn tại");
                        return;
                    }
                    if (txtCMND.Text == dataGridViewNhanVien.Rows[i].Cells["CMND"].Value.ToString())
                    {
                        erroMes.BlinkRate = 100;
                        erroMes.SetError(txtCMND, "Đã tồn tại");
                        return;
                    }
                    if (txtUserName.Text.ToLower() == dataGridViewNhanVien.Rows[i].Cells["UserName"].Value.ToString().ToLower())
                    {
                        erroMes.BlinkRate = 100;
                        erroMes.SetError(txtUserName, "Đã tồn tại");
                        return;
                    }
                }
                if (txtCMND.Text == "")
                {
                    erroMes.BlinkRate = 100;
                    erroMes.SetError(txtCMND, "? CMND");
                    return;
                }
                if (txtCMND.Text.Length < 10)
                {
                    erroMes.BlinkRate = 100;
                    erroMes.SetError(txtCMND, "? CMND");
                    return;
                }
                if (txtDiaChi.Text == "")
                {
                    erroMes.BlinkRate = 100;
                    erroMes.SetError(txtDiaChi, "? Địa chỉ");
                    return;
                }

                if (txtUserName.Text == "")
                {
                    erroMes.BlinkRate = 100;
                    erroMes.SetError(txtUserName, "? UserName");
                    return;
                }
                if (txtPassWord.Text == "")
                {
                    erroMes.BlinkRate = 100;
                    erroMes.SetError(txtPassWord, "? PassWord");
                    return;
                }

                else
                {
                    MaHoa();
                    nv.MaNV = txtMaNV.Text;
                    nv.MaCV = cboChucVu.SelectedValue.ToString();
                    nv.TenNV = txtTenNV.Text;
                    if (radioButtonNam.Checked == true)
                    {
                        nv.GioiTinh = radioButtonNam.Text;
                    }
                    else
                    {
                        nv.GioiTinh = radioButtonNu.Text;
                    }
                    if (txtEmail.Text == "")
                    {
                        nv.Email = "Không";
                    }
                    else
                    {
                        if (txtEmail.Text.Contains("@"))
                        {
                            nv.Email = txtEmail.Text;
                        }
                        else
                        {
                            erroMes.BlinkRate = 100;
                            erroMes.SetError(txtEmail, "Emal phải có @");
                            return;
                        }
                    }
                    nv.NgaySinh = dateTirmNgaySinh.Value.Date;
                    nv.DienThoai = txtSDT.Text;
                    nv.CMND = txtCMND.Text;
                    nv.DiaChi = txtDiaChi.Text;
                    if (Path.GetFileName(pictureBox1.ImageLocation) == null)
                    {
                        nv.HinhAnh = "Không";
                    }
                    else
                    {
                        nv.HinhAnh = Path.GetFileName(pictureBox1.ImageLocation);
                        LuuAnh();
                    }
                    nv.UserName = txtUserName.Text;
                    nv.PassWord = txtPassWord.Text;
                    nv.TrangThai = "1";
                    bus.AddData(nv);
                    MessageBox.Show("Thêm Nhân Viên Thành Công");
                    Clear();
                    xulytextbox(false, true);
                    xulychucnang(true, false, false);
                }
            }
            if (flag == 2)
            {
                if (cboChucVu.Text == "")
                {
                    erroMes.BlinkRate = 100;
                    erroMes.SetError(cboChucVu, "Chưa chọn chức vụ");
                    return;
                }
                if (txtTenNV.Text == "")
                {
                    erroMes.BlinkRate = 100;
                    erroMes.SetError(txtTenNV, "? Tên nhân viên");
                    return;
                }
                if (txtSDT.Text == "")
                {
                    erroMes.BlinkRate = 100;
                    erroMes.SetError(txtSDT, "? SDT");
                    return;
                }
                if (txtSDT.Text.Length < 10 || txtSDT.Text.Length > 13)
                {
                    erroMes.BlinkRate = 100;
                    erroMes.SetError(txtSDT, "Số điện thoại không đúng");
                    return;
                }
                if (txtCMND.Text == "")
                {
                    erroMes.BlinkRate = 100;
                    erroMes.SetError(txtCMND, "? CMND");
                    return;
                }
                if (txtCMND.Text.Length < 9)
                {
                    erroMes.BlinkRate = 100;
                    erroMes.SetError(txtCMND, "? CMND");
                    return;
                }
                if (txtDiaChi.Text == "")
                {
                    erroMes.BlinkRate = 100;
                    erroMes.SetError(txtDiaChi, "? Địa chỉ");
                    return;
                }

                if (txtUserName.Text == "")
                {
                    erroMes.BlinkRate = 100;
                    erroMes.SetError(txtUserName, "? UserName");
                    return;
                }

                else
                {
                    int KiemTra = 0;
                    nv.MaNV = txtMaNV.Text;
                    nv.MaCV = cboChucVu.SelectedValue.ToString();
                    nv.TenNV = txtTenNV.Text;
                    if (radioButtonNam.Checked == true)
                    {
                        nv.GioiTinh = radioButtonNam.Text;
                    }
                    else
                    {
                        nv.GioiTinh = radioButtonNu.Text;
                    }
                    int vitri = dataGridViewNhanVien.CurrentCell.RowIndex;
                    if (dataGridViewNhanVien.Rows.Count > 0)
                    {
                        if (txtSDT.Text == dataGridViewNhanVien.Rows[vitri].Cells["DienThoai"].Value.ToString())
                        {
                            // Bỏ Qua
                        }
                        else
                        {
                            for (int i = 0; i < dataGridViewNhanVien.Rows.Count - 0; i++)
                            {
                                if (txtSDT.Text == dataGridViewNhanVien.Rows[i].Cells["DienThoai"].Value.ToString())
                                {
                                    erroMes.BlinkRate = 100;
                                    erroMes.SetError(txtSDT, "Đã tồn tại");
                                    return;
                                }
                            }
                        }
                        if (txtEmail.Text == dataGridViewNhanVien.Rows[vitri].Cells["Email"].Value.ToString())
                        {
                            // bỏ qua
                        }
                        else
                        {
                            for (int i = 0; i < dataGridViewNhanVien.Rows.Count - 0; i++)
                            {
                                if (txtEmail.Text == dataGridViewNhanVien.Rows[i].Cells["Email"].Value.ToString())
                                {
                                    erroMes.BlinkRate = 100;
                                    erroMes.SetError(txtEmail, "Đã tồn tại");
                                    return;
                                }
                            }
                        }
                        if (txtCMND.Text == dataGridViewNhanVien.Rows[vitri].Cells["CMND"].Value.ToString())
                        {
                            // bỏ qua
                        }
                        else
                        {
                            for (int i = 0; i < dataGridViewNhanVien.Rows.Count - 0; i++)
                            {
                                if (txtCMND.Text == dataGridViewNhanVien.Rows[i].Cells["CMND"].Value.ToString())
                                {
                                    erroMes.BlinkRate = 100;
                                    erroMes.SetError(txtCMND, "Đã tồn tại");
                                    return;
                                }
                            }
                        }
                        if (txtUserName.Text == dataGridViewNhanVien.Rows[vitri].Cells["UserName"].Value.ToString())
                        {
                            // bỏ qua
                        }
                        else
                        {
                            for (int i = 0; i < dataGridViewNhanVien.Rows.Count - 0; i++)
                            {
                                if (txtUserName.Text == dataGridViewNhanVien.Rows[i].Cells["UserName"].Value.ToString())
                                {
                                    erroMes.BlinkRate = 100;
                                    erroMes.SetError(txtUserName, "Đã tồn tại");
                                    return;
                                }
                            }
                        }
                    }
                    if (dataGridViewNhanVien.Rows.Count > 0)
                    {
                        if (TenHinh == dataGridViewNhanVien.Rows[vitri].Cells["HinhAnh"].Value.ToString())
                        {
                            KiemTra = 1;
                        }
                        else
                        {
                            for (int i = 0; i < dataGridViewNhanVien.Rows.Count - 0; i++)
                            {
                                if (TenHinh == dataGridViewNhanVien.Rows[i].Cells["HinhAnh"].Value.ToString())
                                {
                                    //MessageBox.Show(TenHinh);
                                    return;
                                }
                            }
                        }
                    }
                    nv.DienThoai = txtSDT.Text;
                    nv.UserName = txtUserName.Text;
                    nv.Email = txtEmail.Text;
                    nv.NgaySinh = dateTirmNgaySinh.Value.Date;
                    nv.CMND = txtCMND.Text;
                    nv.DiaChi = txtDiaChi.Text;
                    if (KiemTra == 1)
                    {
                        nv.HinhAnh = TenHinh;
                    }
                    else
                    {
                        nv.HinhAnh = Path.GetFileName(pictureBox1.ImageLocation);
                        LuuAnh();
                    }
                    //nv.UserName = txtUserName.Text;
                    if (txtPassWord.Text == "")
                    {
                        nv.PassWord = PassW;
                    }
                    else
                    {
                        MaHoa();
                        nv.PassWord = txtPassWord.Text;
                    }
                    nv.TrangThai = "1";
                    bus.EditData(nv);
                    //MessageBox.Show("Cập Nhật Nhân Viên Thành Công");
                    Clear();
                    xulychucnang(true, false, false);
                }
            }

            Display();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            Display();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void HienThiNhanVien_TXT(int vitri, DataTable d)
        {
            try
            {
                txtMaNV.Text = d.Rows[vitri]["MaNV"].ToString();
                cboChucVu.Text = d.Rows[vitri]["TenCV"].ToString();
                txtTenNV.Text = d.Rows[vitri]["TenNV"].ToString();
                txtEmail.Text = d.Rows[vitri]["Email"].ToString();
                dateTirmNgaySinh.Text = d.Rows[vitri]["NgaySinh"].ToString();
                txtSDT.Text = d.Rows[vitri]["DienThoai"].ToString();
                txtCMND.Text = d.Rows[vitri]["CMND"].ToString();
                txtDiaChi.Text = d.Rows[vitri]["DiaChi"].ToString();
                string[] b = d.Rows[vitri]["HinhAnh"].ToString().Split(';');
                pictureBox1.Controls.Clear();
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
                        Size s = new Size(166, 153);
                        p.Size = s;
                        p.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Controls.Add(p);
                        Bitmap a = new Bitmap(DuongDanFolderHinh + "\\" + b[i]);
                        p.Image = a;
                        TenHinh = b[i];
                    }
                }
                catch
                {

                }
                txtUserName.Text = d.Rows[vitri]["UserName"].ToString();
                PassW = d.Rows[vitri]["PassWord"].ToString();
                string t = d.Rows[vitri]["GioiTinh"].ToString();
                if (t == "Nam")
                    radioButtonNam.Checked = true;
                else
                    radioButtonNu.Checked = true;
            }
            catch
            {

            }
        }

        private void dataGridViewNhanVien_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            //int vitri = dataGridViewNhanVien.CurrentCell.RowIndex;
            //HienThiNhanVien_TXT(vitri, bus.GetData(""));
            xulychucnang(true, true, true);
            xulytextbox(true, false);
            flag = 2;
            try
            {
                DataGridViewRow row = dataGridViewNhanVien.Rows[e.RowIndex];
                txtMaNV.Text = row.Cells["MaNV"].Value.ToString();
                cboChucVu.Text = row.Cells["MaCV"].Value.ToString();
                txtTenNV.Text = row.Cells["TenNV"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
                dateTirmNgaySinh.Text = row.Cells["NgaySinh"].Value.ToString();
                txtSDT.Text = row.Cells["DienThoai"].Value.ToString();
                txtCMND.Text = row.Cells["CMND"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                string[] b = row.Cells["HinhAnh"].Value.ToString().Split(';');
                pictureBox1.Controls.Clear();
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
                        Size s = new Size(166, 153);
                        p.Size = s;
                        p.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Controls.Add(p);
                        Bitmap a = new Bitmap(Application.StartupPath + @"\Image\" + b[i]);
                        p.Image = a;
                        TenHinh = b[i];
                    }
                }
                catch
                {
                    TenHinh = "Không";
                }
                txtUserName.Text = row.Cells["UserName"].Value.ToString();
                PassW = row.Cells["Password"].Value.ToString();
                string t = row.Cells["GioiTinh"].Value.ToString();
                if (t == "Nam")
                    radioButtonNam.Checked = true;
                else
                    radioButtonNu.Checked = true;
            }
            catch
            {

            }
            if (cboChucVu.SelectedValue.ToString() == "CV01")
            {
                btnXoa.Enabled = false;
                cboChucVu.Enabled = false;
            }
            else
            {

            }
        }



        private void dataGridViewNhanVien_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có muốn xóa hay không ?", "Thông Báo !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (KQ == DialogResult.Yes)
            {
                if (cboChucVu.SelectedValue.ToString() == "CV01")
                {
                    MessageBox.Show("Không thể xóa");
                    return;
                }
                else
                {
                    nv.MaNV = txtMaNV.Text;
                    bus.DeleteData(nv);
                    MessageBox.Show("Xóa Nhân Viên Thành Công");
                    xulychucnang(true, false, false);
                    Clear();
                    xulytextbox(false, true);
                }
                Display();
            }
            else
            {

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string Condition = txtSearch.Text;
            HienThiSearch(Condition);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có muốn hủy hay không ?", "Thông Báo !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (KQ == DialogResult.Yes)
            {
                Clear();
                xulychucnang(true, false, false);
                xulytextbox(true, false);
                xulytextbox(false, true);
            }
            else
            {

            }
        }

        public static string MD5Hash(string input)
        {
            using (var md5 = new MD5CryptoServiceProvider())
                return string.Concat("0x",
                    BitConverter.ToString(md5.ComputeHash(Encoding.UTF8.GetBytes(input)))
                    .Replace("-", string.Empty).PadRight(62, '0'));
        }

        public void ShowP()
        {
            MD5 hashKey = new MD5CryptoServiceProvider();
            var hashedKey = hashKey.ComputeHash(ASCIIEncoding.ASCII.GetBytes("password"));
        }

        private void btnShowPass_Click(object sender, EventArgs e)
        {

        }

        private void txtTenNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            OpenFileDialog opFile = new OpenFileDialog();
            opFile.Title = "Select a Image";
            opFile.Filter = "Files|*.jpg;*.jpeg;*.png;....";
            if (opFile.ShowDialog() == DialogResult.OK)
            {
                TenHinh = opFile.FileName;
                pictureBox1.Image = new Bitmap(opFile.FileName);
                pictureBox1.ImageLocation = opFile.FileName;
                pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            }
        }

        private void dataGridViewNhanVien_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewNhanVien.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }


        private void copyAlltoClipboard()
        {
            dataGridViewNhanVien.SelectAll();
            DataObject dataObj = dataGridViewNhanVien.GetClipboardContent();
            if (dataObj != null)
                Clipboard.SetDataObject(dataObj);
        }


        private void btnXuat_Click(object sender, EventArgs e)
        {
            //if (dataGridViewNhanVien.Rows.Count > 0)
            //{
            //    Microsoft.Office.Interop.Excel.Application excelAp = new Microsoft.Office.Interop.Excel.Application();
            //    excelAp.Application.Workbooks.Add(Type.Missing);
            //    // Lưu trữ phần header
            //    for (int i = 1; i < dataGridViewNhanVien.Rows.Count + 7; i++)
            //    {
            //        excelAp.Cells[1, i] = dataGridViewNhanVien.Columns[i - 1].HeaderText;

            //    }
            //    // Lưu trữ hàng và cột vào excel
            //    for (int i = 0; i < dataGridViewNhanVien.Rows.Count; i++)
            //    {
            //        for (int j = 0; j < dataGridViewNhanVien.Rows.Count + 6; j++)
            //        {
            //            excelAp.Cells[i + 2, j + 1] = dataGridViewNhanVien.Rows[i].Cells[j].Value.ToString();

            //        }
            //    }
            //    excelAp.Columns.AutoFit();
            //    excelAp.Visible = true;
            //}
            try
            {
                Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
                Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
                Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
                app.Visible = true;
                worksheet = workbook.Sheets["Sheet1"];
                worksheet = workbook.ActiveSheet;
                worksheet.Name = "Records";

                try
                {
                    for (int i = 0; i < dataGridViewNhanVien.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1] = dataGridViewNhanVien.Columns[i].HeaderText;
                    }
                    for (int i = 0; i < dataGridViewNhanVien.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridViewNhanVien.Columns.Count; j++)
                        {
                            if (dataGridViewNhanVien.Rows[i].Cells[j].Value != null)
                            {
                                worksheet.Cells[i + 2, j + 1] = dataGridViewNhanVien.Rows[i].Cells[j].Value.ToString();
                            }
                            else
                            {
                                worksheet.Cells[i + 2, j + 1] = "";
                            }
                        }
                    }

                    //Getting the location and file name of the excel to save from user. 
                    SaveFileDialog saveDialog = new SaveFileDialog();
                    saveDialog.Filter = "Excel files (*.xlsx)|*.xlsx|All files (*.*)|*.*";
                    saveDialog.FilterIndex = 2;

                    if (saveDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        workbook.SaveAs(saveDialog.FileName);
                        MessageBox.Show("Thành Công", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (System.Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }

                finally
                {
                    app.Quit();
                    workbook = null;
                    worksheet = null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void txtMaNV_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSDT_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
    }
}
