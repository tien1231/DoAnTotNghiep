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
    public partial class Frm_HoaDonBanHang : Form
    {
        public Frm_HoaDonBanHang()
        {
            InitializeComponent();
            HienThiHoaDon();
        }
        HoaDon_BUS bus = new HoaDon_BUS();
        HoaDonBanHang hdbh = new HoaDonBanHang();
        CT_HoaDonBanHang cthd = new CT_HoaDonBanHang();
        BanHang_BUS banhang = new BanHang_BUS();
        LinhKien lk = new LinhKien();
        ReportDataSource rs = new ReportDataSource();
        Frm_Setting frm_Setting = new Frm_Setting();

        public void HienThiHoaDon()
        {
            dataGridViewHD.DataSource = bus.GetHoaDon("");
        }


        public void HienThiCTHD_TheoMa()
        {
            dataGridViewCTHD.DataSource = bus.GetCtHoaDon("select LinhKien.TenLK,CT_HoaDonBanHang.SoLuong,CT_HoaDonBanHang.DonGia,KhuyenMai,ThanhTien from CT_HoaDonBanHang ,LinhKien Where LinhKien.MaLK=CT_HoaDonBanHang.MaLK and CT_HoaDonBanHang.MaHDBH=N'" + txtMaHD.Text + "'");
        }

        public void HienThiCTHD_TheoMaHD(string condition)
        {
            dataGridViewCTHD.DataSource = bus.HienThiCTHDTheoMa("select lk.TenLK,ct.SoLuong,ct.DonGia,ct.KhuyenMai,ct.ThanhTien From CT_HoaDonBanHang ct,LinhKien lk where lk.MaLK=ct.MaLK and ct.MaHDBH=N'" + condition + "'");
        }
        public void HienThiNhanVien(string condition)
        {
            comboBoxNhanVien.DataSource = banhang.GetNhanVien("Select MaNV,TenNV From NhanVien Where UserName=N'" + condition + "'");
            comboBoxNhanVien.DisplayMember = "TenNV";
            comboBoxNhanVien.ValueMember = "MaNV";
        }

        public void HienThiKhachHang()
        {
            //comboBoxKH.DataSource = bus.GetKhachHang("");
            //comboBoxKH.DisplayMember = "TenKH";
            //comboBoxKH.ValueMember = "MaKH";
        }

        public void HienThiLinhKien()
        {
            comboBoxLK.DataSource = bus.GetLinhKien("");
            comboBoxLK.DisplayMember = "TenLK";
            comboBoxLK.ValueMember = "MaLK";
        }

        public void HienThiTimKiemHD(string condition)
        {
            dataGridViewHD.DataSource = bus.GetSearch("Select HoaDonBanHang.MaHDBH,TenKH,TennV,HoaDonBanHang.NgayLapHDBH,TongTien From HoaDonBanHang,NhanVien,KhachHang Where NhanVien.MaNV=HoaDonBanHang.MaNV and KhachHang.MaKH=HoaDonBanHang.MaKH and HoaDonBanHang.TrangThai=N'1' and MaHDBH Like N'%" + condition + "%'");
        }

        public void HienThiCTHD()
        {
            dataGridViewCTHD.DataSource = bus.GetCtHoaDon("select LinhKien.MaLK, LinhKien.TenLK,CT_HoaDonBanHang.SoLuong,CT_HoaDonBanHang.DonGia,CT_HoaDonBanHang.KhuyenMai,ThanhTien from CT_HoaDonBanHang ,LinhKien Where LinhKien.MaLK=CT_HoaDonBanHang.MaLK and CT_HoaDonBanHang.MaHDBH=N'" + txtMaHD.Text + "'");
        }
        public void XulyTextBoxCTHD(Boolean b1, Boolean b2)
        {
            comboBoxLK.Enabled = b2;
        }
        public void XuLyTextBoxHD(Boolean b1, Boolean b2)
        {
            txtMaHD.Enabled = b2;
            comboBoxKH.Enabled = b2;
            comboBoxNhanVien.Enabled = b2;
            dateTimePickerNgaylap.Enabled = b2;
        }

        public void ClearTextBoxHD()
        {
            txtMaHD.Controls.Clear();
            comboBoxLK.Controls.Clear();
            comboBoxKH.Controls.Clear();
            comboBoxNhanVien.Controls.Clear();
            labelTongThanhToan.Controls.Clear();
            dateTimePickerNgaylap.Controls.Clear();

        }
        public void ClearTextBoxCTHD()
        {
            txtKhuyenMai.Clear();
            txtThanhTien.Controls.Clear();
            textBoxSL.Clear();
            txtDonGia.Clear();
            txtKhuyenMai.Clear();
        }


        public void XuLyChucNang(Boolean b1, Boolean b2)
        {
            btnEdit.Enabled = b1;
            btnInHD.Enabled = b1;
            btnXoa.Enabled = b1;
        }

        string SdtCuaHang;
        string HotlineCuaHang;
        string Website;
        string DiaChiCuaHang;

        public void HienThiDS_CTHD(int vitri)
        {
            DataTable dt = new DataTable();
            string t = dt.Rows[vitri]["MaHDBH"].ToString();
            dataGridViewCTHD.DataSource = bus.GetCtHoaDon("SoLuong,CT.DonGia,CT.KhuyenMai,CT.ThanhTien,LK.SoLuong from CT_HoaDonBanHang CT ,LinhKien LK Where Lk.MaLK=CT.MaLK and CT.MaHDBH=N'" + t + "'");
        }
        public void ShowCTHD()
        {
            dataGridViewCTHD.DataSource = bus.GetCtHoaDon("select LinhKien.MaLK, LinhKien.TenLK,CT_HoaDonBanHang.SoLuong,CT_HoaDonBanHang.DonGia,CT_HoaDonBanHang.KhuyenMai,ThanhTien from CT_HoaDonBanHang ,LinhKien Where LinhKien.MaLK=CT_HoaDonBanHang.MaLK and CT_HoaDonBanHang.MaHDBH=N'" + txtMaHD.Text + "' and CT_HoaDonBanHang.TrangThai=N'1'");
        }

        int flag = 0;
        public void HienThiHoaDonTextBox(int vitri, DataTable d)
        {
            try
            {
                txtMaHD.Text = d.Rows[vitri]["MaHDBH"].ToString();
                comboBoxKH.Text = d.Rows[vitri]["TenKh"].ToString();
                //comboBoxNhanVien.Text = d.Rows[vitri]["TenNV"].ToString();
                dateTimePickerNgaylap.Text = d.Rows[vitri]["NgayLapHDBH"].ToString();
                labelTongThanhToan.Text = d.Rows[vitri]["TongTien"].ToString();
                labelTongThanhToan.Text = string.Format("{0:#,##0}", double.Parse(labelTongThanhToan.Text));
                ShowCTHD();
            }
            catch
            {

            }
        }

        public void HienThiCTHoaDonTextBox(int vitri, DataTable d)
        {
            try
            {
                comboBoxLK.Text = d.Rows[vitri]["TenLK"].ToString();
                textBoxSL.Text = d.Rows[vitri]["SoLuong"].ToString();
                txtDonGia.Text = d.Rows[vitri]["DonGia"].ToString();
                txtDonGia.Text = string.Format("{0:#,##0}", double.Parse(txtDonGia.Text));
                txtKhuyenMai.Text = d.Rows[vitri]["KhuyenMai"].ToString();
                txtThanhTien.Text = d.Rows[vitri]["ThanhTien"].ToString();
                txtThanhTien.Text = string.Format("{0:#,##0}", double.Parse(txtThanhTien.Text));
            }
            catch
            {

            }
        }

        public void TongTienSP()
        {
            decimal sum = 0;
            for (int i = 0; i < dataGridViewCTHD.Rows.Count; ++i)
            {
                sum += decimal.Parse(dataGridViewCTHD.Rows[i].Cells["ThanhTien"].Value.ToString());
            }
            labelTongThanhToan.Text = sum.ToString();
            labelTongThanhToan.Text = string.Format("{0:#,##0}", decimal.Parse(labelTongThanhToan.Text));
        }



        private void btnThoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Frm_HoaDonBanHang_Load(object sender, EventArgs e)
        {
            HienThiHoaDon();
            HienThiLinhKien();
            string condition = Login.SetValueForText1;
            HienThiNhanVien(condition);
            comboBoxLK.Text = null;
            XuLyChucNang(false, true);
        }

        private void dataGridViewHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                XuLyChucNang(true, true);
                //int vitri = dataGridViewHD.CurrentCell.RowIndex;
                //HienThiHoaDonTextBox(vitri, bus.GetHoaDon(""));
                try
                {
                    DataGridViewRow row = dataGridViewHD.Rows[e.RowIndex];
                    txtMaHD.Text = row.Cells["MaHDBH"].Value.ToString();
                    comboBoxKH.Text = row.Cells["TenKH"].Value.ToString();
                    //comboBoxNhanVien.Text = d.Rows[vitri]["TenNV"].ToString();
                    dateTimePickerNgaylap.Text = row.Cells["NgayLapHDBH"].Value.ToString();
                    labelTongThanhToan.Text = row.Cells["TongT"].Value.ToString();
                    labelTongThanhToan.Text = string.Format("{0:#,##0}", double.Parse(labelTongThanhToan.Text));
                    ShowCTHD();

                }
                catch
                {

                }

                flag = 1;
                DataTable TTKH = bus.LayTTKH("Select * From KhachHang Where TenKH=N'" + comboBoxKH.Text + "'");
                if (comboBoxKH.Text == TTKH.Rows[0]["TenKH"].ToString())
                {
                    TenKhachHang = TTKH.Rows[0]["TenKH"].ToString();
                    DienThoaiKH = TTKH.Rows[0]["DienThoai"].ToString();
                    DiaChiKH = TTKH.Rows[0]["DiaChi"].ToString();
                }
            }
            catch
            {

            }
        }

        string TenKhachHang;
        string DienThoaiKH;
        string DiaChiKH;
        private void dataGridViewCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            XulyTextBoxCTHD(true, false);
            DataGridViewRow row = dataGridViewCTHD.Rows[e.RowIndex];
            comboBoxLK.Text = row.Cells["MaLK"].Value.ToString();
            textBoxSL.Text = row.Cells["SoLuong"].Value.ToString();
            txtDonGia.Text = row.Cells["DonGia"].Value.ToString();
            txtDonGia.Text = string.Format("{0:#,##0}", decimal.Parse(txtDonGia.Text));
            txtKhuyenMai.Text = row.Cells["KhuyenMai"].Value.ToString();
            txtThanhTien.Text = row.Cells["ThanhTien"].Value.ToString();
            txtThanhTien.Text = string.Format("{0:#,##0}", decimal.Parse(txtThanhTien.Text));
        }

        private void dataGridViewHD_DoubleClick(object sender, EventArgs e)
        {
            XuLyChucNang(true, false);
        }

        private void btnChonMua_Click(object sender, EventArgs e)
        {
            flag = 3;
            ClearTextBoxCTHD();
            XuLyChucNang(false, true);
            XulyTextBoxCTHD(false, true);
        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void TongThanhToan()
        {
            decimal TongThanhToan = 0;
            for (int i = 0; i < dataGridViewCTHD.Rows.Count - 0; i++)
            {
                decimal TT = decimal.Parse(dataGridViewCTHD.Rows[i].Cells["ThanhTien"].Value.ToString());
                TongThanhToan += TT;
                labelTongThanhToan.Text = TongThanhToan.ToString();
                labelTongThanhToan.Text = string.Format("{0:#,##0}", decimal.Parse(labelTongThanhToan.Text));
            }
        }

        public void ThanhTienSP()
        {
            decimal ThanhTienSP;
            decimal KM = decimal.Parse(textBoxSL.Text) * decimal.Parse(txtDonGia.Text) * decimal.Parse(txtKhuyenMai.Text) / 100;
            ThanhTienSP = decimal.Parse(txtDonGia.Text) * decimal.Parse(textBoxSL.Text) - KM;
            txtThanhTien.Text = ThanhTienSP.ToString();


        }

        private void textBoxSL_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridViewCTHD_DoubleClick(object sender, EventArgs e)
        {
            XuLyChucNang(true, false);
            flag = 5;
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string condition = txtSearch.Text;
            HienThiTimKiemHD(condition);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có muốn xóa hay không?", "Thông Báo !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (KQ == DialogResult.Yes)
            {
                cthd.MaHDBH = txtMaHD.Text;
                bus.DeleteCTHd(cthd);
                hdbh.MaHDBH = txtMaHD.Text;
                bus.DeleteHoaDon(hdbh);
                MessageBox.Show("Thành Công !");
                ClearTextBoxCTHD();
            }
            HienThiHoaDon();
            //HienThiCTHD();
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            XuLyChucNang(true, false);
            XulyTextBoxCTHD(true, false);
            ClearTextBoxCTHD();
            ClearTextBoxHD();

        }

        private void btnCapNhat_Click_1(object sender, EventArgs e)
        {
            string condition = txtMaHD.Text;

            MessageBox.Show("Seccess !");
            HienThiCTHD_TheoMaHD(condition);

        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaHD.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtMaHD, "? Mã Hóa Đơn");
                    return;
                }
                if (comboBoxKH.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(comboBoxKH, "? Mã Khách Hàng");
                    return;
                }
                if (comboBoxNhanVien.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(comboBoxNhanVien, "? Nhân Viên");
                    return;
                }
                if (labelTongThanhToan.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(labelTongThanhToan, "?  Tổng Tiền");
                    return;
                }
                if (comboBoxLK.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(comboBoxLK, "? Tên Linh Kiện");
                    return;
                }
                if (textBoxSL.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(textBoxSL, "? Số Lượng");
                    return;
                }
                if (int.Parse(textBoxSL.Text) < 1)
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(textBoxSL, "Số lượng phải lớn hơn 1");
                    return;
                }
                if (txtDonGia.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtDonGia, "? Đơn Giá");
                    return;
                }
                if (txtKhuyenMai.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtKhuyenMai, "? Khuyến Mãi");
                    return;
                }
                if (txtThanhTien.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtThanhTien, "? Thành Tiền");
                    return;
                }
                else
                {
                    ThanhTienSP();
                    cthd.MaHDBH = txtMaHD.Text;
                    cthd.MaLK = comboBoxLK.SelectedValue.ToString();
                    cthd.SoLuong = int.Parse(textBoxSL.Text);
                    cthd.DonGia = decimal.Parse(txtDonGia.Text);
                    cthd.KhuyenMai = decimal.Parse(txtKhuyenMai.Text);
                    cthd.ThanhTien = decimal.Parse(txtThanhTien.Text);
                    bus.UpdateCTHoaDon(cthd);
                    HienThiCTHD();
                    TongThanhToan();
                    hdbh.MaHDBH = txtMaHD.Text;
                    hdbh.MaNV = comboBoxNhanVien.SelectedValue.ToString();
                    hdbh.NgayLapHDBH = dateTimePickerNgaylap.Value.Date;
                    hdbh.TongTien = decimal.Parse(labelTongThanhToan.Text);
                    bus.UpdateHoaDon(hdbh);
                }
            }
            catch
            {

            }

            HienThiHoaDon();
        }

        private void textBoxSL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void comboBoxKH_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        private void comboBoxNhanVien_KeyDown(object sender, KeyEventArgs e)
        {
            e.SuppressKeyPress = true;
        }

        public static string SetValueForText1 = "";

        Frm_PrintHD frm_in = new Frm_PrintHD();
        private void btnInHD_Click(object sender, EventArgs e)
        {
            if (txtTienKDua.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtTienKDua, "? Tiền Khách Đưa");
                return;
            }
            if (txtTienThua.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtTienThua, "? Tiền Thừa");
                return;
            }
            if (decimal.Parse(txtTienKDua.Text) < 0)
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtTienKDua, "Sai Số");
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
            for (int i = 0; i < dataGridViewCTHD.Rows.Count - 0; i++)
            {
                CT_HoaDon cT_HoaDon = new CT_HoaDon
                {
                    TenSP = dataGridViewCTHD.Rows[i].Cells["MaLK"].Value.ToString(),
                    SoLuong = int.Parse(dataGridViewCTHD.Rows[i].Cells["SoLuong"].Value.ToString()),
                    DonGia = decimal.Parse(dataGridViewCTHD.Rows[i].Cells["DonGia"].Value.ToString()),
                    KhuyenMai = decimal.Parse(dataGridViewCTHD.Rows[i].Cells["KhuyenMai"].Value.ToString()),
                    ThanhTien = decimal.Parse(dataGridViewCTHD.Rows[i].Cells["ThanhTien"].Value.ToString()),
                    TongThanhToan = decimal.Parse(labelTongThanhToan.Text),
                    TenKH = TenKhachHang,
                    DienThoai = DienThoaiKH,
                    DiaChi = DiaChiKH,
                    TenNV = comboBoxNhanVien.Text,
                    NgayLap = dateTimePickerNgaylap.Value,
                    TienKhachDua = decimal.Parse(txtTienKDua.Text),
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
            txtTienKDua.ResetText();
            txtTienThua.ResetText();
        }

        private void dataGridViewHD_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewHD.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTienKDua_TextChanged(object sender, EventArgs e)
        {
            try
            {
                decimal TienThuaKhach;
                TienThuaKhach = decimal.Parse(txtTienKDua.Text) - decimal.Parse(labelTongThanhToan.Text);
                txtTienThua.Text = TienThuaKhach.ToString();
                txtTienThua.Text = string.Format("{0:#,##0}", decimal.Parse(txtTienThua.Text));
            }
            catch
            {

            }
        }

        private void dataGridViewCTHD_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            decimal ThanhTien;
            if (dataGridViewCTHD.Columns[e.ColumnIndex].Name == "SoLuong")
            {
                for (int i = 0; i < dataGridViewCTHD.Rows.Count - 0; i++)
                {
                    ThanhTien = int.Parse(dataGridViewCTHD.Rows[i].Cells["SoLuong"].Value.ToString()) * decimal.Parse(dataGridViewCTHD.Rows[i].Cells["DonGia"].Value.ToString()) - decimal.Parse(dataGridViewCTHD.Rows[i].Cells["KhuyenMai"].Value.ToString());
                    dataGridViewCTHD.Rows[i].Cells["ThanhTien"].Value = ThanhTien.ToString();
                }
                TongTienSP();
            }
        }

        private void dataGridViewCTHD_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewCTHD.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void btnXuatExel_Click(object sender, EventArgs e)
        {
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
                    for (int i = 0; i < dataGridViewHD.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1] = dataGridViewHD.Columns[i].HeaderText;
                    }
                    for (int i = 0; i < dataGridViewHD.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridViewHD.Columns.Count; j++)
                        {
                            if (dataGridViewHD.Rows[i].Cells[j].Value != null)
                            {
                                worksheet.Cells[i + 2, j + 1] = dataGridViewHD.Rows[i].Cells[j].Value.ToString();
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

        private void txtDonGia_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtKhuyenMai_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtMaHD_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }

        private void txtTienKDua_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }
    }
}
