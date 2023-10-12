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
    public partial class Frm_LLinhKien : Form
    {
        public Frm_LLinhKien()
        {
            InitializeComponent();
            Display();
        }

        LoaiLinhKien_BUS bus = new LoaiLinhKien_BUS();
        LoaiLinhKien llk = new LoaiLinhKien();

        QLBLK ql = new QLBLK();
        DataSet ds = new DataSet();
        int flag = 0;
        public void Display()
        {

            dataGridViewKH.DataSource = bus.GetData("");
        }

        public void HienThiSearch(string condition)
        {
            dataGridViewKH.DataSource = bus.GetSearch("" + condition);
        }
        public void xulytextbox(Boolean b1, Boolean b2)
        {
            txtMaLoai.Enabled = b1;
            txtTenLoai.Enabled = b1;


        }

        public void xulychucnang(Boolean b1, Boolean b2, Boolean b3)
        {
            btnThem.Enabled = b1;
            btnXoa.Enabled = b3;
            btnLuu.Enabled = b2;
            btnHuy.Enabled = b2;
        }

        public void clear()
        {
            txtMaLoai.Clear();
            txtTenLoai.Clear();
            errorMes.Clear();
        }

        public string AuToCode(DataTable d)
        {
            int sodong = d.Rows.Count;
            string macuoi;
            if (sodong > 9)
                macuoi = d.Rows[sodong - 1]["MaLLK"].ToString().Substring(3, 2);
            else
                macuoi = d.Rows[sodong - 1]["MaLLk"].ToString().Substring(4, 1);
            return (int.Parse(macuoi) + 1).ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            xulychucnang(false, true, false);
            xulytextbox(true, false);
            clear();
            flag = 1;
            if (bus.LayDuLieu("").Rows.Count == 0)
            {
                txtMaLoai.Text = "LLK00";
            }
            else
            {
                if (int.Parse(AuToCode(bus.LayDuLieu(""))) < 10)
                    txtMaLoai.Text = "LLK0" + AuToCode(bus.LayDuLieu(""));
                else
                    txtMaLoai.Text = "LLK" + AuToCode(bus.LayDuLieu(""));
            }
        }

        private void Frm_LLinhKien_Load(object sender, EventArgs e)
        {
            xulytextbox(false, true);
            xulychucnang(true, false, false);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                string s = txtTenLoai.Text.Trim();

                for (int i = 0; i < dataGridViewKH.Rows.Count - 0; i++)
                {
                    if (txtTenLoai.Text.ToLower() == dataGridViewKH.Rows[i].Cells["TenLLK"].Value.ToString().ToLower())
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(txtTenLoai, "Đã Tồn Tại");
                        return;
                    }
                }
                if (txtTenLoai.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtTenLoai, "?");
                    return;
                }
                else
                {
                    llk.MaLLK = txtMaLoai.Text;
                    llk.TenLLK = txtTenLoai.Text;
                    llk.TrangThai = "1";
                    bus.AddData(llk);
                    xulychucnang(true, false, false);
                    xulytextbox(true, false);
                    clear();
                }

            }
            if (flag == 2)
            {
                if (txtTenLoai.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtTenLoai, "?");
                    return;
                }
                else
                {
                    llk.MaLLK = txtMaLoai.Text;
                    int vitri = dataGridViewKH.CurrentCell.RowIndex;
                    if (dataGridViewKH.Rows.Count > 0)
                    {
                        if (txtTenLoai.Text.ToLower() == dataGridViewKH.Rows[vitri].Cells["TenLLK"].Value.ToString().ToLower())
                        {
                            // Bỏ Qua
                        }
                        else
                        {
                            for (int i = 0; i < dataGridViewKH.Rows.Count - 0; i++)
                            {
                                if (txtTenLoai.Text.ToLower() == dataGridViewKH.Rows[i].Cells["TenLLK"].Value.ToString().ToLower())
                                {
                                    errorMes.BlinkRate = 100;
                                    errorMes.SetError(txtTenLoai, "Đã tồn tại");
                                    return;
                                }
                            }
                        }
                    }
                    llk.TenLLK = txtTenLoai.Text;
                    llk.TrangThai = "1";
                    bus.EditData(llk);
                    clear();
                    xulychucnang(true, false, false);
                    xulytextbox(true, false);
                }
            }
            Display();
        }
        private void btnCapNhat_Click(object sender, EventArgs e)
        {

        }

        private void dataGridViewKH_DoubleClick(object sender, EventArgs e)
        {
            xulytextbox(true, false);
            xulychucnang(false, true, true);
            flag = 2;
        }

        private void dataGridViewKH_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                DataGridViewRow row = dataGridViewKH.Rows[e.RowIndex];
                txtMaLoai.Text = row.Cells["MaLLK"].Value.ToString();
                txtTenLoai.Text = row.Cells["TenLLK"].Value.ToString();
            }
            catch
            {

            }
            xulytextbox(true, false);
            xulychucnang(true, true, true);
            flag = 2;
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có muốn xóa hay không ?", "Thông Báo !!", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (KQ == DialogResult.Yes)
            {
                llk.MaLLK = txtMaLoai.Text;
                bus.DeleteData(llk);
                MessageBox.Show("Xóa Dữ Liệu Thành Công");
                clear();
                xulychucnang(true, false, false);
            }
            Display();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string condition = txtSearch.Text;
            HienThiSearch(condition);
        }

        private void btnHuy_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có muốn hủy hay không ?", "Thông Báo !!", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (KQ == DialogResult.Yes)
            {
                xulychucnang(true, false, false);
                xulytextbox(true, false);
                clear();
            }
            else
            {

            }
        }

        private void txtTenLoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void dataGridViewKH_RowPostPaint(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewKH.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void dataGridViewKH_SelectionChanged(object sender, EventArgs e)
        {
            foreach (DataGridViewRow row in dataGridViewKH.SelectedRows)
            {
                txtMaLoai.Text = row.Cells[1].Value.ToString();
                txtTenLoai.Text = row.Cells[2].Value.ToString();
            }
        }


    }
}
