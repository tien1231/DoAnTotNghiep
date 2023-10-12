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
using Microsoft.Reporting.WinForms;
using System.Globalization;

namespace DoAnCShap
{
    public partial class Frm_BanHan : Form
    {
        public Frm_BanHan()
        {
            InitializeComponent();

        }
        KhachHang_BUS kh = new KhachHang_BUS();
        KhachHang ThemKH = new KhachHang();
        BanHang_BUS bus = new BanHang_BUS();
        HoaDonBanHang hdbh = new HoaDonBanHang();
        LinhKien lk = new LinhKien();
        CT_HoaDonBanHang cthdbh = new CT_HoaDonBanHang();
        Frm_Setting frm_Setting = new Frm_Setting();
        string MaLK = "";
        ReportDataSource rs = new ReportDataSource();
        public void HienThiSanPham()
        {
            comboBoxSP.DataSource = bus.GetData("");
            comboBoxSP.DisplayMember = "TenLK";
            comboBoxSP.ValueMember = "MaLK";
        }

        public void HienThiNhanVien(string labelHienTenDN)
        {
            comboBoxNV.DataSource = bus.GetNhanVien("Select MaNV,TenNV From NhanVien Where UserName=N'" + labelHienTenDN + "'");
            comboBoxNV.DisplayMember = "TenNV";
            comboBoxNV.ValueMember = "MaNV";
        }

        public void HienThiTimKiem(string condition)
        {
            comboBoxSP.DataSource = bus.GetTimKiem("select TenLK,MaLK From LinhKien Where TenLK Like N'%" + condition + "%'");
            comboBoxSP.DisplayMember = "TenLK";
            comboBoxSP.ValueMember = "MaLK";
        }

        public void HienThiDSSTheoMaSP(string condition)
        {
            dataGridViewHDBH.DataSource = bus.GetHienThiDSSpTheoMa("select LK.TenLK,CT.SoLuong,CT.DonGia,KhuyenMai,ThanhTien From CT_HoaDonBanHang CT, LinhKien LK Where LK.MaLK=CT.MaLK and MaHDBH=N'" + condition + "'");
        }
        public void XuLyChucNang(Boolean b1, Boolean b2)
        {
            btnThemHD.Enabled = b1;
            btnThenKH.Enabled = b2;
            btnChonMua.Enabled = b2;
            btnLuuHd.Enabled = b2;
            btnHuy.Enabled = b2;
            btnTimKH.Enabled = b2;
        }

        public void XuLyTextBox(Boolean b1, Boolean b2)
        {
            txtMaHD.Enabled = b2;
            comboBoxNV.Enabled = b2;
            txtMaKH.Enabled = b2;
            NumreicSL.Enabled = b2;
            txtKhuyenMai.Enabled = b2;
            txtDonGia.Enabled = b2;
            comboBoxSP.Enabled = b2;
            txtTenkH.Enabled = b2;
            txtDiaChi.Enabled = b2;
            txtSDT.Enabled = b2;
            dateTimePickerNgayLap.Enabled = b2;
            panelGioiTinh.Enabled = b2;

        }
        public void ClearTextBox()
        {
            txtMaHD.ResetText();
            comboBoxNV.ResetText();
            comboBoxSP.ResetText();
            txtSDT.ResetText();
            txtMaKH.ResetText();
            txtTenkH.ResetText();
            txtDiaChi.ResetText();
            txtDonGia.ResetText();
            txtKhuyenMai.ResetText();
            labelThanhTien.ResetText();
            txtTongThanhT.ResetText();
            txtTienKhachDua.ResetText();
            txtTienThua.ResetText();
            dataGridViewHDBH.Rows.Clear();
            dataGridViewHDBH.Refresh();
            errorMes.Clear();
        }

        public void XoaTextBoXSP()
        {
            comboBoxSP.ResetText();
            txtDonGia.ResetText();
            txtKhuyenMai.ResetText();
            labelThanhTien.ResetText();
        }

        public void KhoaTextKH(Boolean b1)
        {
            txtMaKH.Enabled = b1;
            txtSDT.Enabled = b1;
            txtDiaChi.Enabled = b1;
            txtTenkH.Enabled = b1;
        }

        public string PhatSinhMaHDBH(DataTable d)
        {
            int sodong = d.Rows.Count;
            string macuoi;
            if (sodong > 9)
                macuoi = d.Rows[sodong - 1]["MaHDBH"].ToString().Substring(3, 2);
            else
                macuoi = d.Rows[sodong - 1]["MaHDBH"].ToString().Substring(4, 1);
            return (int.Parse(macuoi) + 1).ToString();
        }

        public string PhatSinhMaKH(DataTable d)
        {
            int sodong = d.Rows.Count;
            string macuoi;
            if (sodong > 9)
                macuoi = d.Rows[sodong - 1]["MaKH"].ToString().Substring(2, 2);
            else
                macuoi = d.Rows[sodong - 1]["MaKH"].ToString().Substring(3, 1);
            return (int.Parse(macuoi) + 1).ToString();
        }

        private void Frm_BanHang_Load(object sender, EventArgs e)
        {
            HienThiSanPham();

        }

        public static string SetValueForText3 = "";

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int SoLuongTon;
        int SoluongConLai = 0;
        int SoLuongTonNguyen;
        private void comboBoxSP_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable DSSP = bus.GetDSSP("Select * From LinhKien Where TenLK=N'" + comboBoxSP.Text + "'");
                if (DSSP.Rows.Count > 0)
                {
                    if (comboBoxSP.Text == DSSP.Rows[0]["TenLK"].ToString())
                    {
                        if (int.Parse(DSSP.Rows[0]["SoLuongTon"].ToString()) == 0)
                        {
                            MessageBox.Show("Sản Phẩm Này Đã Hết Hàng");
                        }
                        else
                        {
                            txtDonGia.Text = DSSP.Rows[0]["DonGia"].ToString();
                            txtDonGia.Text = string.Format("{0:#,##0}", double.Parse(txtDonGia.Text));
                            txtKhuyenMai.Text = DSSP.Rows[0]["KhuyenMai"].ToString();
                            txtKhuyenMai.Text = string.Format("{0:#,##0}", double.Parse(txtKhuyenMai.Text));
                            NumreicSL.Value = 1;
                            SoLuongTon = int.Parse(DSSP.Rows[0]["SoLuongTon"].ToString());
                            SoLuongTonNguyen = int.Parse(DSSP.Rows[0]["SoLuongTon"].ToString());
                        }
                    }
                }
            }
        }

        private void txtSDT_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                DataTable DSKH = bus.GetDSkH("Select * From KhachHang Where DienThoai=N'" + txtSDT.Text + "'");
                if (DSKH.Rows.Count > 0)
                {
                    if (txtSDT.Text == DSKH.Rows[0]["DienThoai"].ToString())
                    {
                        txtTenkH.Text = DSKH.Rows[0]["TenKH"].ToString();
                        txtDiaChi.Text = DSKH.Rows[0]["DiaChi"].ToString();
                        txtMaKH.Text = DSKH.Rows[0]["MaKH"].ToString();
                    }
                }
            }
        }

        int flag = 0;

        private void btnThemHD_Click(object sender, EventArgs e)
        {
            ClearTextBox();
            KhoaTextKH(true);
            if ((bus.PhatSinhMaHDBH("")).Rows.Count == 0)
            {
                txtMaHD.Text = "HDB00";
            }
            else
            {
                if (int.Parse(PhatSinhMaHDBH(bus.PhatSinhMaHDBH(""))) < 10)
                    txtMaHD.Text = "HDB0" + PhatSinhMaHDBH(bus.PhatSinhMaHDBH(""));
                else
                    txtMaHD.Text = "HDB" + PhatSinhMaHDBH(bus.PhatSinhMaHDBH(""));
            }
            flag = 1;
            XuLyChucNang(false, true);
            XuLyTextBox(false, true);
        }

        public void TongTienSP()
        {
            decimal sum = 0;
            for (int i = 0; i < dataGridViewHDBH.Rows.Count; ++i)
            {
                sum += decimal.Parse(dataGridViewHDBH.Rows[i].Cells["ThanhTien"].Value.ToString());
            }
            txtTongThanhT.Text = sum.ToString();
            txtTongThanhT.Text = string.Format("{0:#,##0}", decimal.Parse(txtTongThanhT.Text));
        }

        private void Add_Datagrid(string tenlk, int soluong, decimal dongia, decimal khuyenmai, decimal thanhtien, int soluongconlai, int soluongnguyen)
        {
            try
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridViewHDBH);
                newRow.Cells[1].Value = tenlk;
                newRow.Cells[2].Value = soluong;
                newRow.Cells[3].Value = dongia;
                newRow.Cells[4].Value = khuyenmai;
                newRow.Cells[5].Value = thanhtien;
                newRow.Cells[6].Value = soluongconlai;
                newRow.Cells[7].Value = soluongnguyen;
                dataGridViewHDBH.Rows.Add(newRow);
            }
            catch
            {

            }
        }

        private void btnChonMua_Click(object sender, EventArgs e)
        {
            if (txtDonGia.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtDonGia, "Đơn Giá Không được để trống");
                return;
            }

            if (txtKhuyenMai.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtKhuyenMai, "Khuyến Mãi Không được để trống");
                return;
            }
            if (((int)NumreicSL.Value) > SoLuongTon)
            {
                MessageBox.Show("Sản Phẩm Này Chỉ Còn " + SoLuongTon);
                return;
            }
            int KiemTra = 0;
            int vitri = 0;
            decimal KM;
            decimal tt = 0;
            tongtien += tt;
            KM = (int.Parse(txtKhuyenMai.Text) * decimal.Parse(txtDonGia.Text) * (((int)NumreicSL.Value)) / 100);
            tt = decimal.Parse(txtDonGia.Text) * (((int)NumreicSL.Value)) - KM;
            SoluongConLai = SoLuongTon - (((int)NumreicSL.Value));
            tongtien += tt;
            labelThanhTien.Text = tt.ToString();
            labelThanhTien.Text = string.Format("{0:#,##0}", decimal.Parse(labelThanhTien.Text));
            for (int i = 0; i < dataGridViewHDBH.Rows.Count - 0; i++)
            {
                if (comboBoxSP.Text == dataGridViewHDBH.Rows[i].Cells["TenLK"].Value.ToString())
                {
                    KiemTra = 1;
                    vitri = i;
                    break;
                }
            }
            if (KiemTra == 1)
            {

                int SL = ((int)NumreicSL.Value) + int.Parse(dataGridViewHDBH.Rows[vitri].Cells["SoLuong"].Value.ToString());
                dataGridViewHDBH.Rows[vitri].Cells["SoLuong"].Value = SL.ToString();
                //decimal KMM = decimal.Parse(dataGridViewHDBH.Rows[vitri].Cells["KhuyenMai"].Value.ToString()) + KM;
                //dataGridViewHDBH.Rows[vitri].Cells["KhuyenMai"].Value = KMM.ToString();
                int SLConLaiMoi = int.Parse(dataGridViewHDBH.Rows[vitri].Cells["SLConLai"].Value.ToString()) - ((int)NumreicSL.Value);
                dataGridViewHDBH.Rows[vitri].Cells["SLConLai"].Value = SLConLaiMoi.ToString();
                decimal ThanhTienMoi = tt + decimal.Parse(dataGridViewHDBH.Rows[vitri].Cells["ThanhTien"].Value.ToString());
                dataGridViewHDBH.Rows[vitri].Cells["ThanhTien"].Value = ThanhTienMoi.ToString();
                dataGridViewHDBH.Rows[vitri].Cells["ThanhTien"].Value = string.Format("{0:#,##0}", decimal.Parse(ThanhTienMoi.ToString()));
            }

            else
            {
                MaLK += comboBoxSP.SelectedValue.ToString() + ";";
                //object[] t = { comboBoxSP.Text, NumreicSL.Value, txtDonGia.Text, txtKhuyenMai.Text, labelThanhTien.Text, SoluongConLai, SoLuongTonNguyen };
                //dataGridViewHDBH.Rows.Add(t);
                Add_Datagrid(comboBoxSP.Text, (((int)NumreicSL.Value)), decimal.Parse(txtDonGia.Text), decimal.Parse(txtKhuyenMai.Text), decimal.Parse(labelThanhTien.Text), SoluongConLai, SoLuongTonNguyen);
            }
            TongTienSP();
            XoaTextBoXSP();
        }

        decimal tongtien = 0;

        public void ThanhTienLinhKien()
        {
            decimal ThanhTien;
            decimal ChietKhau;
            ChietKhau = (int.Parse(txtKhuyenMai.Text) * decimal.Parse(txtDonGia.Text) * (((int)NumreicSL.Value)) / 100);
            ThanhTien = decimal.Parse(txtDonGia.Text) * (((int)NumreicSL.Value)) - ChietKhau;
            labelThanhTien.Text = ThanhTien.ToString();
            labelThanhTien.Text = string.Format("{0:#,##0}", decimal.Parse(labelThanhTien.Text));

        }

        private void btnLuuHd_Click(object sender, EventArgs e)
        {
            if (txtMaHD.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtMaHD, "? Mã Hóa Đơn");
                return;
            }
            if (comboBoxNV.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(comboBoxNV, "? Nhân Viên");
                return;
            }
            if (txtTongThanhT.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtTongThanhT, "? Tổng Thanh Toán");
                return;
            }
            if (txtMaKH.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtMaKH, "? Mã Khách Hàng");
                return;
            }
            if (flag == 1)
            {
                hdbh.MaHDBH = txtMaHD.Text;
                hdbh.MaKH = txtMaKH.Text;
                hdbh.MaNV = comboBoxNV.SelectedValue.ToString();
                hdbh.NgayLapHDBH = dateTimePickerNgayLap.Value;
                hdbh.TongTien = decimal.Parse(txtTongThanhT.Text);
                hdbh.TrangThai = "1";
                bus.AddHoaDon(hdbh);
                string[] b = MaLK.Split(';');
                for (int i = 0; i < dataGridViewHDBH.Rows.Count - 0; i++)
                {
                    string malk = b[i];
                    int soluong = int.Parse(dataGridViewHDBH.Rows[i].Cells["SoLuong"].Value.ToString());
                    decimal dongia = decimal.Parse(dataGridViewHDBH.Rows[i].Cells["DonGia"].Value.ToString());
                    decimal khuyenmai = decimal.Parse(dataGridViewHDBH.Rows[i].Cells["KhuyenMai"].Value.ToString());
                    decimal thanhtien = decimal.Parse(dataGridViewHDBH.Rows[i].Cells["ThanhTien"].Value.ToString());
                    int slconlai = int.Parse(dataGridViewHDBH.Rows[i].Cells["SLConLai"].Value.ToString());
                    cthdbh.MaHDBH = txtMaHD.Text;
                    cthdbh.MaLK = malk;
                    cthdbh.SoLuong = soluong;
                    cthdbh.DonGia = dongia;
                    cthdbh.KhuyenMai = khuyenmai;
                    cthdbh.ThanhTien = thanhtien;
                    cthdbh.TrangThai = "1";
                    lk.MaLK = malk;
                    lk.SoLuongTon = slconlai;
                    bus.CapNhatSLTon(lk);
                    bus.AddCTHD(cthdbh);
                }
                MessageBox.Show("Thanh Toán Thành Công");
                btnInHD.Enabled = true;
                XuLyChucNang(true, false);
            }
        }

        private void btnTimKH_Click(object sender, EventArgs e)
        {
            add = true;
            if (txtSDT.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtSDT, "Vui lòng nhập số điện thoại");
                return;
            }
            if (txtSDT.Text.Length < 9)
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtSDT, "?");
                return;
            }
            else
            {
                DataTable DSKH = bus.GetDSkH("Select * From KhachHang Where DienThoai=N'" + txtSDT.Text + "'");
                if (DSKH.Rows.Count > 0)
                {
                    if (txtSDT.Text == DSKH.Rows[0]["DienThoai"].ToString())
                    {
                        KhoaTextKH(false);
                        txtTenkH.Text = DSKH.Rows[0]["TenKH"].ToString();
                        txtDiaChi.Text = DSKH.Rows[0]["DiaChi"].ToString();
                        txtMaKH.Text = DSKH.Rows[0]["MaKH"].ToString();
                        string t = DSKH.Rows[0]["GioiTinh"].ToString();
                        if (t == "Nam")
                            radioButtonNam.Checked = true;
                        else
                            radioButtonNu.Checked = true;
                    }

                }
                else
                {
                    MessageBox.Show("Không tìm thấy khách hàng");
                    if (kh.PhatSinhMa("").Rows.Count == 0)
                    {
                        txtMaKH.Text = "KH00";
                    }
                    else
                    {
                        if (int.Parse(PhatSinhMaKH(kh.PhatSinhMa(""))) < 10)
                            txtMaKH.Text = "KH0" + PhatSinhMaKH(kh.PhatSinhMa(""));
                        else
                            txtMaKH.Text = "KH" + PhatSinhMaKH(kh.PhatSinhMa(""));
                    }
                }
            }
        }

        bool add;

        private void Frm_BanHan_Load(object sender, EventArgs e)
        {
            btnInHD.Enabled = false;
            HienThiSanPham();
            comboBoxSP.Text = "";
            labelThanhTien.ResetText();
            txtDonGia.ResetText();
            txtKhuyenMai.ResetText();
            string condition = Login.SetValueForText1;
            HienThiNhanVien(condition);
            XuLyChucNang(true, false);
            XuLyTextBox(true, false);
        }

        private void txtTienKhachDua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal TienThua = 0;
                TienThua = decimal.Parse(txtTienKhachDua.Text) - decimal.Parse(txtTongThanhT.Text);
                txtTienThua.Text = TienThua.ToString("0,00");

            }
            catch
            {

            }
        }

        private void btnLuuKH_Click(object sender, EventArgs e)
        {
            int KiemTra;
            int vitri;
            try
            {
                if (txtSDT.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtSDT, "Số điện thoại không được để trống");
                    return;
                }
                if (txtSDT.Text.Length < 10 || txtSDT.Text.Length > 12)
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtSDT, "Số điện thoại không đúng");
                    return;
                }

                if (txtMaKH.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtMaKH, "Mã Khách Hàng Không được để trống");
                    return;
                }
                DataTable DSKH = bus.GetDSkH("Select * From KhachHang Where DienThoai=N'" + txtSDT.Text + "'");
                {
                    if (DSKH.Rows.Count > 0)
                    {
                        if (txtMaKH.Text == DSKH.Rows[0]["MakH"].ToString())
                        {
                            MessageBox.Show("Không thể thêm mới được");
                            return;
                        }
                    }
                }
                if (txtDiaChi.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtDiaChi, "Địa Chỉ Không được để trống");
                    return;
                }
                else
                {
                    ThemKH.MaKH = txtMaKH.Text;
                    ThemKH.TenKH = txtTenkH.Text;
                    if (radioButtonNam.Checked == true)
                    {
                        ThemKH.GioiTinh = radioButtonNam.Text;
                    }
                    else
                    {
                        ThemKH.GioiTinh = radioButtonNu.Text;
                    }
                    if (txtSDT.Text == "")
                    {
                        ThemKH.DienThoai = "Không";
                    }
                    else
                    {
                        ThemKH.DienThoai = txtSDT.Text;
                    }
                    ThemKH.DiaChi = txtDiaChi.Text;
                    ThemKH.TrangThai = "1";
                    kh.AddData(ThemKH);
                    MessageBox.Show("Thêm Khách Hàng Thành Công");
                }
            }
            catch
            {

            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string condition = txtSearch.Text;
            HienThiTimKiem(condition);
        }

        Frm_PrintHD frm_in = new Frm_PrintHD();
        private void btnInHD_Click(object sender, EventArgs e)
        {
            if (txtTienKhachDua.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtTienKhachDua, "Cần Nhập Tiền Khách Đưa");
                return;
            }
            if (txtTienThua.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtTienThua, "");
                return;
            }
            if (decimal.Parse(txtTienKhachDua.Text) < 0)
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtTienKhachDua, "Sai Số");
                return;
            }
            if (decimal.Parse(txtTienThua.Text) < 0)
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtTienThua, "Sai Số");
                return;
            }
            List<CT_HoaDon> lst = new List<CT_HoaDon>();
            lst.Clear();
            for (int i = 0; i < dataGridViewHDBH.Rows.Count - 0; i++)
            {
                CT_HoaDon cT_HoaDon = new CT_HoaDon
                {
                    TenSP = dataGridViewHDBH.Rows[i].Cells["TenLK"].Value.ToString(),
                    SoLuong = int.Parse(dataGridViewHDBH.Rows[i].Cells["SoLuong"].Value.ToString()),
                    DonGia = decimal.Parse(dataGridViewHDBH.Rows[i].Cells["DonGia"].Value.ToString()),
                    KhuyenMai = decimal.Parse(dataGridViewHDBH.Rows[i].Cells["KhuyenMai"].Value.ToString()),
                    ThanhTien = decimal.Parse(dataGridViewHDBH.Rows[i].Cells["ThanhTien"].Value.ToString()),
                    TongThanhToan = decimal.Parse(txtTongThanhT.Text),
                    TenKH = txtTenkH.Text,
                    DienThoai = txtSDT.Text,
                    DiaChi = txtDiaChi.Text,
                    TenNV = comboBoxNV.Text,
                    NgayLap = dateTimePickerNgayLap.Value,
                    TienKhachDua = decimal.Parse(txtTienKhachDua.Text),
                    TienThua = decimal.Parse(txtTienThua.Text),
                    MaHD = txtMaHD.Text,

                };
                lst.Add(cT_HoaDon);
            }
            rs.Name = "DataSet1";
            rs.Value = lst;

            frm_in.reportViewer1.LocalReport.DataSources.Clear();
            frm_in.reportViewer1.LocalReport.DataSources.Add(rs);
            frm_in.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAnCShap.reportbc.rdlc";
            Microsoft.Reporting.WinForms.ReportParameter[] reportParameters = new Microsoft.Reporting.WinForms.ReportParameter[]
            {
                new Microsoft.Reporting.WinForms.ReportParameter("ParameterSDT",frm_Setting.txtSDT.Text,true),
                new Microsoft.Reporting.WinForms.ReportParameter("ParameterWebsite",frm_Setting.txtWebSite.Text,true),
                 new Microsoft.Reporting.WinForms.ReportParameter("ParameterHotLine",frm_Setting.txtHotLine.Text,true),
                  new Microsoft.Reporting.WinForms.ReportParameter("ParameterDiaChi",frm_Setting.txtDiaChi.Text,true),
            };
            frm_in.reportViewer1.LocalReport.SetParameters(reportParameters);
            this.frm_in.reportViewer1.RefreshReport();
            frm_in.ShowDialog();
            XuLyChucNang(true, false);
            btnInHD.Enabled = false;
        }

        private void txtMaHD_KeyDown(object sender, KeyEventArgs e)
        {
            string condition = txtMaHD.Text;
            HienThiDSSTheoMaSP(condition);
        }
        private void dataGridViewHDBH_DoubleClick(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có muốn xóa sản phẩm này không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (KQ == DialogResult.Yes)
            {
                try
                {
                    int rowIndex = dataGridViewHDBH.CurrentCell.RowIndex;
                    dataGridViewHDBH.Rows.RemoveAt(rowIndex);
                    TongTienSP();
                }
                catch
                {

                }
            }
        }

        private void txtSL_KeyPress(object sender, KeyPressEventArgs e)
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

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void comboBoxSP_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }

        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn Có Muốn Hủy Hay Không", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (KQ == DialogResult.Yes)
            {
                ClearTextBox();
                XuLyChucNang(true, false);
                btnInHD.Enabled = false;
            }
        }

        int SLMoi;
        int SLTonKhoMoi;

        private void dataGridViewHDBH_CellValueChanged(object sender, DataGridViewCellEventArgs e)
        {
            decimal ThanhTien;
            if (dataGridViewHDBH.Columns[e.ColumnIndex].Name == "SoLuong")
            {
                for (int i = 0; i < dataGridViewHDBH.Rows.Count - 0; i++)
                {
                    decimal KM = int.Parse(dataGridViewHDBH.Rows[i].Cells["SoLuong"].Value.ToString()) * decimal.Parse(dataGridViewHDBH.Rows[i].Cells["DonGia"].Value.ToString()) * decimal.Parse(dataGridViewHDBH.Rows[i].Cells["KhuyenMai"].Value.ToString()) / 100;
                    ThanhTien = int.Parse(dataGridViewHDBH.Rows[i].Cells["SoLuong"].Value.ToString()) * decimal.Parse(dataGridViewHDBH.Rows[i].Cells["DonGia"].Value.ToString()) - KM;
                    dataGridViewHDBH.Rows[i].Cells["ThanhTien"].Value = string.Format("{0:#,##0}", decimal.Parse(ThanhTien.ToString()));
                    SLTonKhoMoi = int.Parse(dataGridViewHDBH.Rows[i].Cells["SoLuongNguyen"].Value.ToString()) - int.Parse(dataGridViewHDBH.Rows[i].Cells["SoLuong"].Value.ToString());
                    dataGridViewHDBH.Rows[i].Cells["SLConLai"].Value = SLTonKhoMoi.ToString();
                }
                TongTienSP();
            }
        }

        private void txtMaKH_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtTienKhachDua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void txtMaHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void dataGridViewHDBH_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewHDBH.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void txtDonGia_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtKhuyenMai_KeyPress_1(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void comboBoxSP_TextChanged(object sender, EventArgs e)
        {

        }

        private void NumreicSL_MouseUp(object sender, MouseEventArgs e)
        {
            ThanhTienLinhKien();
        }

        private void NumreicSL_MouseDown(object sender, MouseEventArgs e)
        {
            ThanhTienLinhKien();
        }

        private void comboBoxSP_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void comboBoxSP_SelectionChangeCommitted(object sender, EventArgs e)
        {

            DataTable DSSP = bus.LaySP("Select * From LinhKien Where TenLK=N'" + comboBoxSP.Text + "'");
            if (DSSP.Rows.Count > 0)
            {
                if (comboBoxSP.Text == DSSP.Rows[0]["TenLK"].ToString())
                {
                    if (int.Parse(DSSP.Rows[0]["SoLuongTon"].ToString()) == 0)
                    {
                        MessageBox.Show("Sản Phẩm Này Đã Hết Hàng");
                        return;
                    }
                    else
                    {
                        txtDonGia.Text = DSSP.Rows[0]["DonGia"].ToString();
                        txtDonGia.Text = string.Format("{0:#,##0}", double.Parse(txtDonGia.Text));
                        txtKhuyenMai.Text = DSSP.Rows[0]["KhuyenMai"].ToString();
                        txtKhuyenMai.Text = string.Format("{0:#,##0}", double.Parse(txtKhuyenMai.Text));
                        NumreicSL.Value = 1;
                        SoLuongTon = int.Parse(DSSP.Rows[0]["SoLuongTon"].ToString());
                        SoLuongTonNguyen = int.Parse(DSSP.Rows[0]["SoLuongTon"].ToString());
                        ThanhTienLinhKien();
                    }
                }
            }

        }

        private void txtSDT_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
    }

    public class CT_HoaDon
    {
        public string TenSP { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public decimal KhuyenMai { get; set; }
        public decimal ThanhTien { get; set; }
        public decimal TongThanhToan { get; set; }
        public string TenKH { get; set; }
        public string DiaChi { get; set; }
        public string DienThoai { get; set; }
        public string TenNV { get; set; }
        public DateTime NgayLap { get; set; }
        public string MaHD { get; set; }
        public decimal TienKhachDua { get; set; }
        public decimal TienThua { get; set; }
    }
}
