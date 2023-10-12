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

namespace DoAnCShap
{
    public partial class Frm_SanPham : Form
    {
        public Frm_SanPham()
        {
            InitializeComponent();
        }

        LinhKien_BUS bus = new LinhKien_BUS();
        LinhKien lk = new LinhKien();
        NhaSanXuat_BUS nsx = new NhaSanXuat_BUS();
        NhaCungCap_BUS ncc = new NhaCungCap_BUS();
        LoaiLinhKien_BUS llk = new LoaiLinhKien_BUS();
        int flag = 0;
        string TenHinh = "";
        public String DuongDanFolderHinh = @"C:\Users\Nguyen Khanh\source\repos\DATN\DoAnCShap\bin\Debug\ImageLK";
        public void DisPlay()
        {
            dataGridViewLK.DataSource = bus.GetData("");
        }

        public void HienThiTimKiem(string condition)
        {
            dataGridViewLK.DataSource = bus.GetSearch("" + condition);
        }
        public void HienThiNSX()
        {
            comboBoxNCC.DataSource = nsx.GetData("");
            comboBoxNCC.DisplayMember = "TenNSX";
            comboBoxNCC.ValueMember = "MaNSX";
        }

        public void HienThiNhaCungCap()
        {
            comboBoxNCC.DataSource = ncc.GetData("");
            comboBoxNCC.DisplayMember = "TenNCC";
            comboBoxNCC.ValueMember = "MaNCC";
        }
        public void HienThiLoaiLK()
        {
            cboMaLoai.DataSource = llk.GetData("");
            cboMaLoai.DisplayMember = "TenLLK";
            cboMaLoai.ValueMember = "MaLLK";
        }
        public void xulychucnang(Boolean b1, Boolean b2, Boolean b3)
        {
            btnThem.Enabled = b1;
            btnXoa.Enabled = b3;
            btnLuu.Enabled = b2;
            btnHuy.Enabled = b2;
        }


        public void XuLyTextBox(Boolean b1, Boolean b2)
        {
            txtMaLinhKien.Enabled = b1;
            txtTenLinhKien.Enabled = b1;
            cboMaLoai.Enabled = b1;
            comboBoxNCC.Enabled = b1;
            txtDonViTinh.Enabled = b1;
            txtSoLuong.Enabled = b1;
            txtDonGia.Enabled = b1;
            txtKhuyenMai.Enabled = b1;
            txtTinhTrang.Enabled = b1;
            comboBoxBaoHanh.Enabled = b1;
            txtXuatXu.Enabled = b1;
        }

        public void Clear()
        {
            pictureBox1.Controls.Clear();
            txtMaLinhKien.Clear();
            txtTenLinhKien.Clear();
            cboMaLoai.ResetText();
            comboBoxNCC.ResetText();
            txtDonViTinh.Clear();
            txtSoLuong.Clear();
            txtDonGia.Clear();
            txtKhuyenMai.Clear();
            txtTinhTrang.Clear();
            txtMaLinhKien.Clear();
            comboBoxBaoHanh.ResetText();
            txtXuatXu.Clear();
            errorMes.Clear();
            pictureBox1.Image = null;
        }

        public string PhatSinhMaSP(DataTable d)
        {
            int sodong = d.Rows.Count;
            string macuoi;
            if (sodong > 9)
                macuoi = d.Rows[sodong - 1]["MaLK"].ToString().Substring(2, 2);
            else
                macuoi = d.Rows[sodong - 1]["MaLK"].ToString().Substring(3, 1);
            return (int.Parse(macuoi) + 1).ToString();
        }
        private void btnChonAnh_Click(object sender, EventArgs e)
        {
            pictureBox1.Controls.Clear();
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
        public void LuuAnh()
        {
            try
            {
                File.Copy(TenHinh, Application.StartupPath + @"\ImageLK\" + Path.GetFileName(pictureBox1.ImageLocation));
            }
            catch
            {

            }
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulychucnang(false, true, false);
            XuLyTextBox(true, false);
            Clear();
            if (bus.PhatSinhMa("").Rows.Count == 0)
            {
                txtMaLinhKien.Text = "LK00";
            }
            else
            {
                if (int.Parse(PhatSinhMaSP(bus.PhatSinhMa(""))) < 10)
                    txtMaLinhKien.Text = "LK0" + PhatSinhMaSP(bus.PhatSinhMa(""));
                else
                    txtMaLinhKien.Text = "LK" + PhatSinhMaSP(bus.PhatSinhMa(""));
            }
            flag = 1;
        }

        private void Frm_SanPham_Load(object sender, EventArgs e)
        {
            xulychucnang(true, false, false);
            XuLyTextBox(false, true);
            HienThiNhaCungCap();
            HienThiLoaiLK();
            DisPlay();
            Clear();
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                if (cboMaLoai.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(cboMaLoai, "? Chưa chọn mã loại");
                    return;
                }

                if (comboBoxNCC.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(comboBoxNCC, "Chưa chọn nhà cung cấp");
                    return;
                }
                if (txtTenLinhKien.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtTenLinhKien, "Tên linh kiện không được để trống");
                    return;
                }
                for (int i = 0; i < dataGridViewLK.Rows.Count - 0; i++)
                {

                    if (txtTenLinhKien.Text.ToLower() == dataGridViewLK.Rows[i].Cells["TenLK"].Value.ToString().ToLower())
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(txtTenLinhKien, "Đã Tồn Tại");
                        return;
                    }
                }
                if (comboBoxBaoHanh.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(comboBoxBaoHanh, "Chưa chọn bảo hành");
                    return;
                }
                if (txtXuatXu.Text == "")
                {
                    errorMes.BlinkRate = 10; ;
                    errorMes.SetError(txtXuatXu, "? Xuất Xứ");
                    return;
                }
                if (txtTinhTrang.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtTinhTrang, "? Tình Trạng");
                    return;
                }
                if (txtDonViTinh.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtDonViTinh, "? Đơn Vị tính");
                    return;
                }
                if (txtDonGia.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtDonGia, "? Đơn Giá");
                    return;
                }
                if (txtSoLuong.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtSoLuong, "? Số Lượng");
                    return;
                }

                else
                {
                    lk.MaLK = txtMaLinhKien.Text;
                    lk.MaLLK = cboMaLoai.SelectedValue.ToString();
                    lk.MaNCC = comboBoxNCC.SelectedValue.ToString();
                    lk.TenLK = txtTenLinhKien.Text;
                    lk.BaoHanh = comboBoxBaoHanh.Text;
                    lk.XuatXu = txtXuatXu.Text;
                    lk.TinhTrang = txtTinhTrang.Text;
                    lk.DonViTinh = txtDonViTinh.Text;
                    lk.DonGia = int.Parse(txtDonGia.Text);
                    lk.SoLuongTon = int.Parse(txtSoLuong.Text);
                    if (txtKhuyenMai.Text == "")
                    {
                        lk.KhuyenMai = 0;
                    }
                    else
                    {
                        lk.KhuyenMai = int.Parse(txtKhuyenMai.Text);
                    }
                    if (pictureBox1.Image == null)
                    {
                        lk.HinhAnh = "Không";
                    }
                    else
                    {
                        lk.HinhAnh = Path.GetFileName(pictureBox1.ImageLocation);
                        LuuAnh();
                    }
                    lk.TrangThai = "1";
                    bus.AddData(lk);
                    MessageBox.Show("Thành Công");
                    xulychucnang(true, false, false);
                    XuLyTextBox(false, true);
                    Clear();
                }
            }
            if (flag == 2)
            {
                if (cboMaLoai.SelectedValue.ToString() == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(cboMaLoai, "? Chưa chọn mã loại");
                    return;
                }

                if (comboBoxNCC.SelectedValue.ToString() == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(comboBoxNCC, "Chưa chọn nhà cung cấp");
                    return;
                }
                if (txtTenLinhKien.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtTenLinhKien, "Tên linh kiện không được để trống");
                    return;
                }
                if (comboBoxBaoHanh.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(comboBoxBaoHanh, "Chưa chọn bảo hành");
                    return;
                }
                if (txtXuatXu.Text == "")
                {
                    errorMes.BlinkRate = 10; ;
                    errorMes.SetError(txtXuatXu, "? Xuất Xứ");
                    return;
                }
                if (txtTinhTrang.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtTinhTrang, "? Tình Trạng");
                    return;
                }
                if (txtDonViTinh.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtDonViTinh, "? Đơn Vị tính");
                    return;
                }
                if (txtDonGia.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtDonGia, "? Đơn Giá");
                    return;
                }
                if (txtSoLuong.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtSoLuong, "? Số Lượng");
                    return;
                }

                else
                {
                    int vitri = dataGridViewLK.CurrentCell.RowIndex;
                    int KiemTra = 0;
                    if (TenHinh == dataGridViewLK.Rows[vitri].Cells["HinhAnh"].Value.ToString())
                    {
                        // Bỏ Qua
                        KiemTra = 1;
                    }
                    lk.MaLK = txtMaLinhKien.Text;
                    lk.MaLLK = cboMaLoai.SelectedValue.ToString();
                    lk.MaNCC = comboBoxNCC.SelectedValue.ToString();
                    if (dataGridViewLK.Rows.Count > 0)
                    {
                        if (txtTenLinhKien.Text.ToLower() == dataGridViewLK.Rows[vitri].Cells["TenLK"].Value.ToString().ToLower())
                        {
                            // Bỏ Qua
                        }
                        else
                        {
                            for (int i = 0; i < dataGridViewLK.Rows.Count - 0; i++)
                            {
                                if (txtTenLinhKien.Text.ToLower() == dataGridViewLK.Rows[i].Cells["TenLK"].Value.ToString().ToLower())
                                {
                                    errorMes.BlinkRate = 100;
                                    errorMes.SetError(txtTenLinhKien, "Đã tồn tại");
                                    return;
                                }
                            }
                        }
                    }
                    lk.TenLK = txtTenLinhKien.Text;
                    lk.BaoHanh = comboBoxBaoHanh.Text;
                    lk.XuatXu = txtXuatXu.Text;
                    lk.TinhTrang = txtTinhTrang.Text;
                    lk.DonViTinh = txtDonViTinh.Text;
                    lk.DonGia = int.Parse(txtDonGia.Text);
                    lk.SoLuongTon = int.Parse(txtSoLuong.Text);
                    lk.KhuyenMai = int.Parse(txtKhuyenMai.Text);
                    if (KiemTra == 1)
                    {
                        lk.HinhAnh = TenHinh;
                    }
                    else
                    {
                        lk.HinhAnh = Path.GetFileName(pictureBox1.ImageLocation);
                        LuuAnh();
                    }
                    lk.TrangThai = "1";
                    bus.EditData(lk);
                    xulychucnang(true, false, false);
                    XuLyTextBox(false, true);
                    Clear();
                }
            }
            DisPlay();
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }
        public void HienThiLK_TXT(int vitri, DataTable d)
        {
            try
            {
                txtMaLinhKien.Text = d.Rows[vitri]["MaLK"].ToString();
                cboMaLoai.Text = d.Rows[vitri]["TenLLK"].ToString();
                comboBoxNCC.Text = d.Rows[vitri]["TenNCC"].ToString();
                txtTenLinhKien.Text = d.Rows[vitri]["TenLK"].ToString();
                comboBoxBaoHanh.Text = d.Rows[vitri]["BaoHanh"].ToString();
                txtXuatXu.Text = d.Rows[vitri]["XuatXu"].ToString();
                txtTinhTrang.Text = d.Rows[vitri]["TinhTrang"].ToString();
                txtDonViTinh.Text = d.Rows[vitri]["DonViTinh"].ToString();
                txtDonGia.Text = d.Rows[vitri]["DonGia"].ToString();
                txtSoLuong.Text = d.Rows[vitri]["SoLuongTon"].ToString();
                txtKhuyenMai.Text = d.Rows[vitri]["KhuyenMai"].ToString();
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
                        Size s = new Size(197, 158);
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
            }
            catch
            {

            }
        }

        private void dataGridViewLK_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            //int vitri = dataGridViewLK.CurrentCell.RowIndex;
            //HienThiLK_TXT(vitri, bus.GetData(""));
            try
            {
                DataGridViewRow row = dataGridViewLK.Rows[e.RowIndex];
                txtMaLinhKien.Text = row.Cells["MaLK"].Value.ToString();
                cboMaLoai.Text = row.Cells["MaLLK"].Value.ToString();
                comboBoxNCC.Text = row.Cells["MaNCC"].Value.ToString();
                txtTenLinhKien.Text = row.Cells["TenLK"].Value.ToString();
                comboBoxBaoHanh.Text = row.Cells["BaoHanh"].Value.ToString();
                txtXuatXu.Text = row.Cells["XuatXu"].Value.ToString(); ;
                txtTinhTrang.Text = row.Cells["TinhTrang"].Value.ToString();
                txtDonViTinh.Text = row.Cells["DonViTinh"].Value.ToString();
                txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
                txtSoLuong.Text = row.Cells["SoLuong"].Value.ToString();
                txtKhuyenMai.Text = row.Cells["KhuyenMai"].Value.ToString();
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
                        Size s = new Size(197, 158);
                        p.Size = s;
                        p.SizeMode = PictureBoxSizeMode.StretchImage;
                        pictureBox1.Controls.Add(p);
                        Bitmap a = new Bitmap(Application.StartupPath + @"\ImageLK\" + b[i]);
                        p.Image = a;
                        TenHinh = b[i];

                    }
                }
                catch
                {

                }
            }
            catch
            {

            }
            XuLyTextBox(true, false);
            xulychucnang(true, true, true);
            flag = 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            try
            {
                lk.MaLK = txtMaLinhKien.Text;
                bus.DeleteData(lk);
                MessageBox.Show("Xóa Linh Kiện Thành Công");
                XuLyTextBox(false, true);
                Clear();
                DisPlay();
            }
            catch
            {

            }
        }

        private void dataGridViewLK_DoubleClick(object sender, EventArgs e)
        {
            flag = 2;
            xulychucnang(false, true, true);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string condition = txtSearch.Text;
            HienThiTimKiem(condition);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có muốn hủy hay không ?", "Thông Báo !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (KQ == DialogResult.Yes)
            {
                xulychucnang(true, false, false);
                XuLyTextBox(false, true);
                Clear();
            }
            else
            {

            }
        }

        private void dataGridViewLK_DoubleClick_1(object sender, EventArgs e)
        {
            //xulychucnang(false, true, true);
            //XuLyTextBox(true, false);
            flag = 2;
        }

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtSoLuong_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void dataGridViewLK_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewLK.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void txtMaLinhKien_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtDonGia_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtSoLuong_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtKhuyenMai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
    }
}
