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
using Microsoft.Reporting.WinForms;

namespace DoAnCShap
{
    public partial class Frm_BaoHanh : Form
    {
        public Frm_BaoHanh()
        {
            InitializeComponent();
        }
        PhieuBaoHanh_BUS bus = new PhieuBaoHanh_BUS();
        PhieuBaoHanh pbh = new PhieuBaoHanh();
        CT_PhieuBaoHanh ctpbh = new CT_PhieuBaoHanh();
        ReportDataSource rs = new ReportDataSource();
        int flag = 0;
        bool addnew = false;
        Frm_Setting frm_Setting = new Frm_Setting();
        BanHang_BUS banhang = new BanHang_BUS();
        KhachHang_BUS kh = new KhachHang_BUS();

        public void XuLyChucNang(Boolean b1, Boolean b2, Boolean b3, Boolean b4)
        {
            btnThem.Enabled = b1;
            btnHuy.Enabled = b2;
            btnThemSP.Enabled = b4;
            btnLuu.Enabled = b2;
            btnXoa.Enabled = b2;
            btnIn.Enabled = b3;
        }

        public void XuLyTexBox(Boolean b1)
        {
            txtMaPhieu.Enabled = b1;
            comboBoxNV.Enabled = b1;
            cboKhachHang.Enabled = b1;
            dateTimePickerNgaLap.Enabled = b1;
            dateTimePickerNgayLayHang.Enabled = b1;
            comboBoxlK.Enabled = b1;
            txtSL.Enabled = b1;
            txtGhiChu.Enabled = b1;
        }
        public void ClearTextBox()
        {
            txtsdtkh.ResetText();
            txtMaPhieu.ResetText();
            txtGhiChu.ResetText();
            txtSL.ResetText();
        }

        public void HienThiNhanVien(string labelHienTenDN)
        {
            comboBoxNV.DataSource = bus.GetNhanVien("Select MaNV,TenNV From NhanVien Where UserName=N'" + labelHienTenDN + "'");
            comboBoxNV.DisplayMember = "TenNV";
            comboBoxNV.ValueMember = "MaNV";
        }

        public void HienThiDSPhieu()
        {
            dataGridViewPBH.DataSource = bus.GetPBH("");
        }

        public void HienThiLK()
        {
            comboBoxlK.DataSource = bus.GetDSLK("");
            comboBoxlK.DisplayMember = "TenLK";
            comboBoxlK.ValueMember = "MaLK";
        }

        public void HienThiDSKH()
        {
            cboKhachHang.DataSource = bus.DanhSachKH("");
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.ValueMember = "MaKH";
        }

        public void HienThiCTPhieuBaoHanh()
        {
            dataGridViewCTPBH.DataSource = bus.HienThiCTPhieu("");
        }
        public void HienThiCTPhieu()
        {
            dataGridViewCTPBH.DataSource = bus.LoadCT_PhieuTheoMa("select LK.TenLK,CT.SoLuong,CT.GhiChu From CT_PhieuBaoHanh CT , LinhKien LK Where LK.MaLK=CT.MaLK and MaPBH=N'" + txtMaPhieu.Text + "' and CT.TrangThai=N'1' ");
        }

        public void TimKiemKH(string condition)
        {
            cboKhachHang.DataSource = kh.GetSearch("select MaKH,TenKH from KhachHang Where DienThoai like N'%" + condition + "%' ");
            cboKhachHang.DisplayMember = "TenKH";
            cboKhachHang.ValueMember = "MaKH";
        }

        public void HienThiTimKiem(string condition)
        {
            comboBoxlK.DataSource = banhang.GetTimKiem("Select * From LinhKien Where TenLK Like N'%" + condition + "%'");
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ClearTextBoxPBH()
        {
            txtsdtkh.ResetText();
            txtMaPhieu.ResetText();
            dateTimePickerNgaLap.ResetText();
            dateTimePickerNgayLayHang.ResetText();
            comboBoxNV.ResetText();

        }
        public void ClearTextBoxCTPBH()
        {
            comboBoxlK.ResetText();
            txtSL.ResetText();
            txtGhiChu.ResetText();
            errorMes.Clear();
        }
        public void HideDGV(Boolean b1, Boolean b2)
        {
            dataGridViewCTPBH.Visible = b1;
            dataGridView2CTPBH.Visible = b2;
            dataGridViewCTPBH.Rows.Clear();
        }
        private void Frm_BaoHanh_Load(object sender, EventArgs e)
        {
            HienThiDSPhieu();
            ClearTextBoxPBH();
            ClearTextBoxCTPBH();
            HienThiLK();
            HienThiDSKH();
            XuLyChucNang(true, false, false, false);
            string condition = Login.SetValueForText1;
            HienThiNhanVien(condition);
            XuLyTexBox(false);
        }

        public string PhatSinhMaPBH(DataTable d)
        {
            int sodong = d.Rows.Count;
            string macuoi;
            if (sodong > 9)
                macuoi = d.Rows[sodong - 1]["MaPBH"].ToString().Substring(3, 2);
            else
                macuoi = d.Rows[sodong - 1]["MaPBH"].ToString().Substring(4, 1);
            return (int.Parse(macuoi) + 1).ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            ClearTextBoxPBH();
            HideDGV(true, false);
            ClearTextBoxCTPBH();
            flag = 1;
            XuLyChucNang(false, true, false, true);
            XuLyTexBox(true);
            if ((bus.PhatSinhMa("").Rows.Count == 0))
            {
                txtMaPhieu.Text = "PBH00";
            }
            else
            {
                if (int.Parse(PhatSinhMaPBH(bus.PhatSinhMa(""))) < 10)
                { txtMaPhieu.Text = "PBH0" + PhatSinhMaPBH(bus.PhatSinhMa("")); }

                else
                { txtMaPhieu.Text = "PBH" + PhatSinhMaPBH(bus.PhatSinhMa("")); }
            }

        }

        string MaLK = "";

        private void Add_Datagrid(string tenlk, int soluong, string tinhtrang)
        {
            try
            {
                DataGridViewRow newRow = new DataGridViewRow();
                newRow.CreateCells(dataGridViewCTPBH);
                newRow.Cells[1].Value = tenlk;
                newRow.Cells[2].Value = soluong;
                newRow.Cells[3].Value = tinhtrang;
                dataGridViewCTPBH.Rows.Add(newRow);
            }
            catch
            {

            }
        }

        private void btnThemPhieu_Click(object sender, EventArgs e)
        {
            int KiemTra = 0;
            int vitri = 0;
            if (comboBoxlK.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(comboBoxlK, "? Chưa chọn tên linh kiện");
                return;
            }
            if (txtSL.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtSL, "Số lượng không được để trống");
                return;
            }
            if (txtGhiChu.Text == "")
            {
                MessageBox.Show("? Ghi Chú");
                return;
            }
            for (int i = 0; i < dataGridViewCTPBH.Rows.Count - 0; i++)
            {
                if (comboBoxlK.Text == dataGridViewCTPBH.Rows[i].Cells["MaLKK"].Value.ToString())
                {
                    KiemTra = 1;
                    vitri = i;
                    break;
                }
            }
            if (KiemTra == 1)
            {
                int SL = (int.Parse(txtSL.Text) + int.Parse(dataGridViewCTPBH.Rows[vitri].Cells["SoLuong"].Value.ToString()));
                dataGridViewCTPBH.Rows[vitri].Cells["SoLuong"].Value = SL.ToString();
            }
            else
            {
                Add_Datagrid(comboBoxlK.Text, int.Parse(txtSL.Text), txtGhiChu.Text);
            }
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {

                if (txtMaPhieu.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtMaPhieu, "? Mã Phiếu");
                    return;
                }
                if (comboBoxNV.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(comboBoxNV, "? Tên Nhân Viên");
                    return;
                }
                if (comboQuyTrinh.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(comboQuyTrinh, "?");
                    return;
                }
                else
                {
                    if (dataGridViewCTPBH.Rows.Count <= 0)
                    {
                        MessageBox.Show("Bạn chưa thêm chi tiết phiếu bảo hành", "Thông Báo");
                        return;
                    }
                    else
                    {
                        pbh.MaPBH = txtMaPhieu.Text;
                        pbh.MaKH = cboKhachHang.SelectedValue.ToString();
                        pbh.MaNV = comboBoxNV.SelectedValue.ToString();
                        pbh.NgayLap = dateTimePickerNgaLap.Value;
                        pbh.NgayLayHang = dateTimePickerNgayLayHang.Value.Date;
                        pbh.QuyTrinh = comboQuyTrinh.Text;
                        pbh.TrangThai = "1";
                        bus.ThemPBH(pbh);
                        string[] b = MaLK.Split(';');
                        for (int i = 0; i < dataGridViewCTPBH.Rows.Count - 0; i++)
                        {
                            string tenlk = dataGridViewCTPBH.Rows[i].Cells["MaLKK"].Value.ToString();
                            int soluong = int.Parse(dataGridViewCTPBH.Rows[i].Cells["SoLuong"].Value.ToString());
                            string ghichu = dataGridViewCTPBH.Rows[i].Cells["GhiChu"].Value.ToString();
                            ctpbh.MaPBH = txtMaPhieu.Text;
                            ctpbh.TenLK = tenlk;
                            ctpbh.SoLuong = soluong;
                            ctpbh.GhiChu = ghichu;
                            ctpbh.TrangThai = "1";
                            bus.ThemCTPhieuBH(ctpbh);
                            MessageBox.Show("Tạo Phiếu Bảo Hành Thành Công");
                        }
                    }
                    ClearTextBoxPBH();
                    ClearTextBoxCTPBH();
                    HideDGV(true, false);
                    XuLyChucNang(true, false, false, false);
                    XuLyTexBox(false);
                }
            }
            if (flag == 2)
            {
                pbh.MaPBH = txtMaPhieu.Text;
                pbh.QuyTrinh = comboQuyTrinh.Text;
                bus.Update_PBH(pbh);
                HideDGV(true, false);
            }
            if (addnew == true)
            {
                if (txtSL.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtSL, "?");
                    return;
                }
                if (txtGhiChu.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtGhiChu, "?");
                    return;
                }
                else
                {
                    ctpbh.MaPBH = txtMaPhieu.Text;
                    ctpbh.TenLK = comboBoxlK.Text;
                    ctpbh.SoLuong = int.Parse(txtSL.Text);
                    ctpbh.GhiChu = txtGhiChu.Text;
                    bus.Update_CTPBH(ctpbh);
                    pbh.MaPBH = txtMaPhieu.Text;
                    pbh.QuyTrinh = comboQuyTrinh.Text;
                    bus.Update_PBH(pbh);
                    HideDGV(true, false);
                }

            }
            HienThiDSPhieu();
            ClearTextBoxPBH();
            ClearTextBoxCTPBH();
            XuLyChucNang(true, false, false, false);
            XuLyTexBox(false);
        }

        public void HienThiPhieuBHTextBox(int vitri, DataTable d)
        {
            try
            {
                txtMaPhieu.Text = d.Rows[vitri]["MaPBH"].ToString();
                comboBoxNV.Text = d.Rows[vitri]["TenNV"].ToString();
                dateTimePickerNgaLap.Text = d.Rows[vitri]["NgayLapPhieu"].ToString();
                dateTimePickerNgayLayHang.Text = d.Rows[vitri]["NgayLayHang"].ToString();
                comboQuyTrinh.Text = d.Rows[vitri]["QuyTrinh"].ToString();
                dataGridView2CTPBH.DataSource = bus.LoadCT_PhieuTheoMa("select TenLK,SoLuong,GhiChu From CT_PhieuBaoHanh  Where MaPBH=N'" + txtMaPhieu.Text + "'");
            }
            catch
            {

            }
        }
        private void dataGridViewPBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int vitri = dataGridViewPBH.CurrentCell.RowIndex;
            HienThiPhieuBHTextBox(vitri, bus.GetPBH(""));
            XuLyChucNang(true, true, true, false);
            XuLyTexBox(true);
            flag = 2;
            HideDGV(false, true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn Có Muốn Xóa Hay Không", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (KQ == DialogResult.OK)
            {
                ctpbh.MaPBH = txtMaPhieu.Text;
                bus.XoaCTPhieuBaoHanh(ctpbh);
                pbh.MaPBH = txtMaPhieu.Text;
                bus.XoaPhieuBaoHanh(pbh);
                MessageBox.Show("Thành Công");
                HienThiDSPhieu();
                ClearTextBox();
            }
            else
            {

            }
        }

        private void dataGridViewCTPBH_DoubleClick(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có muốn xóa hay không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (KQ == DialogResult.Yes)
            {
                try
                {
                    int rowIndex = dataGridViewCTPBH.CurrentCell.RowIndex;
                    dataGridViewCTPBH.Rows.RemoveAt(rowIndex);
                }
                catch
                {

                }
            }
        }

        private void dataGridViewPBH_DoubleClick(object sender, EventArgs e)
        {

        }

        private void btnXoaCT_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có muốn xóa hay không?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (KQ == DialogResult.OK)
            {
                ctpbh.MaPBH = txtMaPhieu.Text;
                ctpbh.TenLK = comboBoxlK.Text;
                bus.XoaCTPhieuBaoHanh(ctpbh);
                MessageBox.Show("Success");
                dataGridViewCTPBH.DataSource = bus.LoadCT_PhieuTheoMa("select LK.TenLK,CT.SoLuong,CT.GhiChu From CT_PhieuBaoHanh CT , LinhKien LK Where LK.MaLK=CT.MaLK and MaPBH=N'" + txtMaPhieu.Text + "'");
                ClearTextBoxCTPBH();
                XuLyChucNang(true, false, false, false);
                XuLyTexBox(false);
            }
        }

        private void btnTim_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewPBH_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewPBH.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dataGridViewCTPBH_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewCTPBH.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        string SoDienThoai = "";
        private void btnIn_Click(object sender, EventArgs e)
        {

            DataTable TTKH = bus.LayTTKH("Select * From KhachHang Where MaKH=N'" + cboKhachHang.SelectedValue.ToString() + "'");
            if (TTKH.Rows.Count > 0)
            {
                if (cboKhachHang.SelectedValue.ToString() == TTKH.Rows[0]["MaKH"].ToString())
                {
                    SoDienThoai = TTKH.Rows[0]["DienThoai"].ToString();
                }
            }

            List<PbaoHanh> lst = new List<PbaoHanh>();
            lst.Clear();
            for (int i = 0; i < dataGridView2CTPBH.Rows.Count - 0; i++)
            {
                PbaoHanh pbaoHanh = new PbaoHanh
                {
                    MaPhieuBH = txtMaPhieu.Text,
                    TenNV = comboBoxNV.Text,
                    NgayLap = dateTimePickerNgaLap.Text,
                    NgayLay = dateTimePickerNgayLayHang.Text,
                    TenLK = dataGridView2CTPBH.Rows[i].Cells["TenLK1"].Value.ToString(),
                    SoLuong = int.Parse(dataGridView2CTPBH.Rows[i].Cells["SoLuong1"].Value.ToString()),
                    GhiChu = dataGridView2CTPBH.Rows[i].Cells["TinhTrang1"].Value.ToString(),
                    TenKH = cboKhachHang.Text,
                    SDT = SoDienThoai,
                };
                lst.Add(pbaoHanh);
            }
            rs.Name = "DataSet3";
            rs.Value = lst;
            Frm_PrintHD frm_in = new Frm_PrintHD();
            frm_in.reportViewer1.LocalReport.DataSources.Clear();
            frm_in.reportViewer1.LocalReport.DataSources.Add(rs);
            frm_in.reportViewer1.LocalReport.ReportEmbeddedResource = "DoAnCShap.ReportPhieuBaoHanh.rdlc";
            Microsoft.Reporting.WinForms.ReportParameter[] reportParameters = new Microsoft.Reporting.WinForms.ReportParameter[]
           {
                new Microsoft.Reporting.WinForms.ReportParameter("ParameterSDT",frm_Setting.txtSDT.Text,true),
                new Microsoft.Reporting.WinForms.ReportParameter("ParameterWebsite",frm_Setting.txtWebSite.Text,true),
                 new Microsoft.Reporting.WinForms.ReportParameter("ParameterHotline",frm_Setting.txtHotLine.Text,true),
                  new Microsoft.Reporting.WinForms.ReportParameter("ParameterDiaChi",frm_Setting.txtDiaChi.Text,true),
           };
            frm_in.reportViewer1.LocalReport.SetParameters(reportParameters);
            frm_in.ShowDialog();
        }

        public class PbaoHanh
        {
            public string MaPhieuBH { get; set; }
            public string TenKH { get; set; }
            public string SDT { get; set; }
            public string TenNV { get; set; }
            public string NgayLap { get; set; }
            public string NgayLay { get; set; }
            public string TenLK { get; set; }
            public int SoLuong { get; set; }
            public string GhiChu { get; set; }
        }

        private void txtMaHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar >= 'a' && e.KeyChar <= 'z')
                e.KeyChar -= (char)32;
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có muốn hủy hay không", "Thông Bán", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
            if (KQ == DialogResult.OK)
            {
                XuLyChucNang(true, false, false, false);
                ClearTextBoxCTPBH();
                ClearTextBoxPBH();
            }
            else
            {

            }

        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string condition = txtSearch.Text;
            HienThiTimKiem(condition);
        }

        private void txtMaPhieu_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void btntimkiem_Click(object sender, EventArgs e)
        {
            string condition = txtsdtkh.Text;
            TimKiemKH(condition);
        }

        private void dataGridView2CTPBH_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView2CTPBH.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dataGridView2CTPBH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridView2CTPBH.Rows[e.RowIndex];
            comboBoxlK.Text = row.Cells[1].Value.ToString();
            txtSL.Text = row.Cells[2].Value.ToString();
            txtGhiChu.Text = row.Cells[3].Value.ToString();
            addnew = true;
            btnThemSP.Enabled = false;
            XuLyTexBox(true);
            XuLyChucNang(true, true, false, false);
            XuLyTexBox(true);
        }
    }
}
