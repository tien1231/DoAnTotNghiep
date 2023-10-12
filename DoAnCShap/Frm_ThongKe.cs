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
using System.Data.SqlClient;
using System.Windows.Forms.DataVisualization.Charting;
using Microsoft.Reporting.WinForms;

namespace DoAnCShap
{
    public partial class Frm_ThongKe : Form
    {
        public Frm_ThongKe()
        {
            InitializeComponent();
        }

        DoanhThu_BUS bus = new DoanhThu_BUS();
        Frm_SanPham lk = new Frm_SanPham();
        ReportDataSource rs = new ReportDataSource();
        Frm_PrintHD frm = new Frm_PrintHD();
        Frm_Report frm_Report = new Frm_Report();

        public void HienThiDoanhThu()
        {
            // = bus.DoanhThuTatCa("");
        }

        public void HienThiDoanhThuTheoNam(string condition)
        {
            cboDoanhThu.DataSource = bus.DoanThuTheoNam("" + condition);
            cboDoanhThu.DisplayMember = "TT";
        }

        public void HienThiDoanhThuTheoNgay(string condition, string condition1)
        {
            chart1.DataSource = bus.DoanhThuTheoNgay("Select  format(sum([TongTien]),'N0') AS 'Doanh Thu'" +
                " From HoaDonBanHang Where(NgayLapHDBH) BETWEEN '" + condition + "' and '" + condition1 + "' ");

        }

        public void DoanhThuTheoThang(string condition, string condition1)
        {
            cboDoanhThu.DataSource = bus.DoanhThuTheoThang("" + condition, condition1);
            cboDoanhThu.DisplayMember = "TT";
        }

        public void SPBanChayTheoThang(string condition, string condition2)
        {
            dataGridView1.DataSource = bus.SPBanChayTheoThang("" + condition, condition2);
        }

        public void Top3SanPhamBanTrongNam(string condition)
        {
            dataGridView1.DataSource = bus.Top3SanPhamBanTrongNam("" + condition);
        }
        public void Top3SPMuaNhieuTrongThang(string condition, string condition1)
        {
            dataGridView1.DataSource = bus.Top3MuaMonth("" + condition, condition1);
        }

        public void Top3SPMuaNhieuTrongNam(string condition)
        {
            dataGridView1.DataSource = bus.Top3SPMuaYear("" + condition);
        }

        public void Top3HDMuaNhieuTrongThang(string condition)
        {
            dataGridView1.DataSource = bus.Top3HDMuaNhieu("" + condition);
        }

        //public void DoanhthuThang1(string condition)
        //{
        //    chart1.DataSource = bus.DoanhThuThang1("SELECT   format(sum([TongTien]),'N0') AS'Donh Thu'" +
        //        " FROM HoaDonBanHang hd WHERE Month(hd.NgayLapHDBH)=1 and Year(hd.NgayLapHDBH)=" + comboBoxNam.Text + "");
        //}

        public void Khachhangmuanhieutrongthang(string condition, string condition1)
        {
            dataGridView1.DataSource = bus.KhachhangMuaNhieu("" + condition, condition1);
        }

        public void KHMuaNhieuTrongNam(string condition)
        {
            dataGridView1.DataSource = bus.KhachHangMuaNhieuTrongNam("" + condition);
        }

        public void KhoanChiThangNay(string condition, string condition1)
        {
            comboBoxChi.DataSource = bus.KhoanChiTheoThang("" + condition);
            comboBoxChi.DisplayMember = "TT";

            cboDoanhThu.DataSource = bus.DoanhThuTheoThang("" + condition, condition1);
            cboDoanhThu.DisplayMember = "TT";
            try
            {
                decimal LoiNhuan;
                LoiNhuan = decimal.Parse(cboDoanhThu.Text) - decimal.Parse(comboBoxChi.Text);
                comboloinhuan.Text = LoiNhuan.ToString();
                comboloinhuan.Text = string.Format("{0:#,##0}", decimal.Parse(comboloinhuan.Text));
            }
            catch
            {

            }
        }

        public void KhoanChiTheoNam(string condition)
        {
            cboDoanhThu.DataSource = bus.DoanThuTheoNam("" + condition);
            cboDoanhThu.DisplayMember = "TT";

            comboBoxChi.DataSource = bus.ThuChiTheoNam("" + condition);
            comboBoxChi.DisplayMember = "TT";

            try
            {
                decimal LoiNhuan;
                LoiNhuan = decimal.Parse(cboDoanhThu.Text) - decimal.Parse(comboBoxChi.Text);
                comboloinhuan.Text = LoiNhuan.ToString();
                comboloinhuan.Text = string.Format("{0:#,##0}", decimal.Parse(comboloinhuan.Text));
            }
            catch
            {

            }
        }

        public void SanPhamTonKho()
        {
            dataGridView1.DataSource = bus.SanPhamTonKho("");
        }
        public void LoadBieuDo()
        {
            int year = DateTime.Now.Year;
            var chart = chart1.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "{#,###} Đ";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = 1;
            chart.AxisX.Maximum = 12;
            chart.AxisY.Minimum = 0;

            //chart1.ChartAreas[0].AxisX.LabelStyle.Format = "{0:0,}K";
            chart1.DataSource = bus.DoanhThuCacThang();
            chart1.Series["Doanh Thu"].XValueMember = "Thang";
            chart1.Series["Doanh Thu"].YValueMembers = "TongTien";
            chart1.Titles.Add("Doanh Thu Các Tháng Của Năm" + " " + year);
        }


        private void Frm_ThongKe_Load(object sender, EventArgs e)
        {
            Fill_CmbYear();
            LoadBieuDo();
        }


        private void btnXemDoanhThu_Click(object sender, EventArgs e)
        {

            if (radioTheoThang.Checked == true)
            {
                string condition = comboBoxThang.Text;
                string condition1 = comboBoxNam.Text;
                DoanhThuTheoThang(condition, condition1);
            }
            if (radioBanNhieuMonth.Checked == true)
            {
                string condition1 = comboBoxThang.Text;
                string condition2 = comboBoxNam.Text;
                SPBanChayTheoThang(condition1, condition2);
            }
            if (radioDoanhThuYea.Checked == true)
            {
                string condition2 = comboBoxNam.Text;
                HienThiDoanhThuTheoNam(condition2);
            }
            if (radioBanNhieuYear.Checked == true)
            {
                string condition2 = comboBoxNam.Text;
                Top3SanPhamBanTrongNam(condition2);
            }
            if (radioButMuaYear.Checked == true)
            {
                string condition = comboBoxNam.Text;
                Top3SPMuaNhieuTrongNam(condition);
            }
            if (radioButMuaMonth.Checked == true)
            {
                string condition = comboBoxThang.Text;
                string condition1 = comboBoxNam.Text;
                Top3SPMuaNhieuTrongThang(condition, condition1);
            }
            if (radioButKhachMuaNhieeu.Checked == true)
            {
                string condition = comboBoxThang.Text;
                string condition1 = comboBoxNam.Text;
                Khachhangmuanhieutrongthang(condition, condition1);
            }
            if (radioBKhachmuanhieutrongnam.Checked == true)
            {
                string condition = comboBoxNam.Text;
                KHMuaNhieuTrongNam(condition);
            }
            if (radioButThuChi.Checked == true)
            {
                string condition = comboBoxThang.Text;
                string condition1 = comboBoxNam.Text;
                KhoanChiThangNay(condition, condition1);
            }
            if (radioButKhanChiNam.Checked == true)
            {
                string condition = comboBoxNam.Text;
                KhoanChiTheoNam(condition);
            }

            if (radioSPTonKho.Checked == true)
            {
                SanPhamTonKho();
            }
            if (radioSPHetHang.Checked == true)
            {
                //Khai báo chế độ xử lý báo cáo, trong trường hợp này lấy báo cáo ở local
                frm_Report.reportViewer2.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;
                //Đường dẫn báo cáo
                frm_Report.reportViewer2.LocalReport.ReportPath = "TKSPHetHang.rdlc";
                //Nếu có dữ liệu
                if (bus.SanPhamHetHang("").Rows.Count > 0)
                {
                    //Tạo nguồn dữ liệu cho báo cáo
                    ReportDataSource rds = new ReportDataSource();
                    rds.Name = "DataSet5";
                    rds.Value = bus.SanPhamHetHang("");
                    //Xóa dữ liệu của báo cáo cũ trong trường hợp người dùng thực hiện câu truy vấn khác
                    frm_Report.reportViewer2.LocalReport.DataSources.Clear();
                    //Add dữ liệu vào báo cáo
                    frm_Report.reportViewer2.LocalReport.DataSources.Add(rds);
                    //Refresh lại báo cáo
                    frm_Report.reportViewer2.RefreshReport();
                    frm_Report.ShowDialog();
                }
            }

        }

        private void fillChart()
        {
            float x1 = 34;
            float x2 = 24;
            float x3 = 31;
            float x4 = 20;
            float x5 = 14;
            float x6 = 10;
            float x7 = 36;
            float x8 = 9;
            float x9 = 18;
            float x10 = 28;
            float x11 = 44;
            float x12 = 48;

            var chart = chart1.ChartAreas[0];
            chart.AxisX.IntervalType = DateTimeIntervalType.Number;

            chart.AxisX.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.Format = "";
            chart.AxisY.LabelStyle.IsEndLabelVisible = true;

            chart.AxisX.Minimum = 1;
            chart.AxisX.Maximum = 12;
            chart.AxisY.Minimum = 0;
            chart.AxisY.Maximum = 50;
            chart.AxisX.Interval = 1;
            chart.AxisY.Interval = 5;

            chart1.Series.Add("Doanh Thu");
            chart1.Series["Doanh Thu"].ChartType = SeriesChartType.Line;
            chart1.Series[0].IsVisibleInLegend = false;

            chart1.Series["Doanh Thu"].Points.AddXY(1, x1);
            chart1.Series["Doanh Thu"].Points.AddXY(2, x2);
            chart1.Series["Doanh Thu"].Points.AddXY(3, x3);
            chart1.Series["Doanh Thu"].Points.AddXY(4, x4);
            chart1.Series["Doanh Thu"].Points.AddXY(5, x5);
            chart1.Series["Doanh Thu"].Points.AddXY(6, x6);
            chart1.Series["Doanh Thu"].Points.AddXY(7, x7);
            chart1.Series["Doanh Thu"].Points.AddXY(8, x8);
            chart1.Series["Doanh Thu"].Points.AddXY(9, x9);
            chart1.Series["Doanh Thu"].Points.AddXY(10, x10);
            chart1.Series["Doanh Thu"].Points.AddXY(11, x11);
            chart1.Series["Doanh Thu"].Points.AddXY(12, x12);
        }

        private void dataGridView1_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridView1.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void Fill_CmbYear()
        {
            try
            {
                comboBoxNam.Items.Clear();
                comboBoxNam.Items.Add("Select");
                for (int i = DateTime.Now.Year - 1; i < DateTime.Now.Year + 1; i++)
                {
                    comboBoxNam.Items.Add(i);
                }
                //comboBoxNam.Text = DateTime.Now.Year.ToString();
            }
            catch
            {

            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void cboDoanhThu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
