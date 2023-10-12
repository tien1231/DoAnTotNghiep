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
    public partial class Frm_NhaCungCap : Form
    {
        public Frm_NhaCungCap()
        {
            InitializeComponent();
            Display();
        }
        NhaCungCap_BUS bus = new NhaCungCap_BUS();
        NhaCungCap ncc = new NhaCungCap();
        int flag = 0;

        public void XuLyChucNang(Boolean b1, Boolean b2, Boolean b3)
        {
            btnAdd.Enabled = b1;
            btnDelete.Enabled = b3;
            btnCancel.Enabled = b2;
            btnSave.Enabled = b2;
        }

        public void XuLyTexBox(Boolean b1, Boolean b2)
        {
            //txtMaNCC.ReadOnly = b2;
            txtMaNCC.Enabled = b2;
            txtEmail.Enabled = b2;
            txtDiaChi.Enabled = b2;
            txtDienThoai.Enabled = b2;
            txtTenNCC.Enabled = b2;
        }

        void Display()
        {
            dataGridViewNhaCungCap.DataSource = bus.GetData("");
        }

        public string PhatSinhMaNCC(DataTable d)
        {
            int sodong = d.Rows.Count;
            string macuoi;
            if (sodong > 9)
                macuoi = d.Rows[sodong - 1]["MaNCC"].ToString().Substring(3, 2);
            else
                macuoi = d.Rows[sodong - 1]["MaNCC"].ToString().Substring(4, 1);
            return (int.Parse(macuoi) + 1).ToString();
        }

        public void HienThiSearch(string condition)
        {
            dataGridViewNhaCungCap.DataSource = bus.GetSearch("" + condition);
        }
        public void ClearTextBox()
        {
            txtTenNCC.Clear();
            txtMaNCC.Clear();
            txtDiaChi.Clear();
            txtDienThoai.Clear();
            txtEmail.Clear();
            errorMes.Clear();
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNCC.Text == "")
                {
                    MessageBox.Show("Vui lòng chọn Nhà Cung Cấp cần xóa", "Thông báo !");
                    return;
                }
                ncc.MaNCC = txtMaNCC.Text;
                bus.DeleteData(ncc);
                ClearTextBox();
                Display();
                MessageBox.Show("Xóa Thành Công");

            }
            catch
            {
                MessageBox.Show("Không thể xóa !");
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            XuLyChucNang(false, true, false);
            ClearTextBox();
            if ((bus.PhatSinhMa("")).Rows.Count == 0)
            {
                txtMaNCC.Text = "NCC00";
            }
            else
            {
                if (int.Parse(PhatSinhMaNCC(bus.PhatSinhMa(""))) < 10)
                    txtMaNCC.Text = "NCC0" + PhatSinhMaNCC(bus.PhatSinhMa(""));
                else
                    txtMaNCC.Text = "NCC" + PhatSinhMaNCC(bus.PhatSinhMa(""));
            }
            flag = 1;
            XuLyTexBox(false, true);
        }

        public void HienThiNCC_TXT(int vitri, DataTable d)
        {
            try
            {
                txtMaNCC.Text = d.Rows[vitri]["MaNCC"].ToString();
                txtTenNCC.Text = d.Rows[vitri]["TenNCC"].ToString();
                txtDiaChi.Text = d.Rows[vitri]["DiaChi"].ToString();
                txtDienThoai.Text = d.Rows[vitri]["DienThoai"].ToString();
                txtEmail.Text = d.Rows[vitri]["Email"].ToString();
            }
            catch
            {

            }
        }
        //hien du lieu tu datatable len button
        private void dataGridViewNhaCungCap_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            flag = 2;
            //int vitri = dataGridViewNhaCungCap.CurrentCell.RowIndex;
            //HienThiNCC_TXT(vitri, bus.GetData(""));
            try
            {
                DataGridViewRow row = dataGridViewNhaCungCap.Rows[e.RowIndex];
                txtMaNCC.Text = row.Cells["MaNCC"].Value.ToString();
                txtTenNCC.Text = row.Cells["TenNCC"].Value.ToString();
                txtDiaChi.Text = row.Cells["DiaChi"].Value.ToString();
                txtDienThoai.Text = row.Cells["DienThoai"].Value.ToString();
                txtEmail.Text = row.Cells["Email"].Value.ToString();
            }
            catch
            {

            }
            XuLyChucNang(true, true, true);
            XuLyTexBox(false, true);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                if (txtMaNCC.Text == "")
                {
                    MessageBox.Show("Vui lòng nhấp chọn bên dưới !", "Thông báo !");
                    return;
                }

                btnSave.Enabled = true;
                btnCancel.Enabled = true;
                Display();
            }
            catch { }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (flag == 1)
            {
                try
                {
                    if (txtMaNCC.Text == "")
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(txtMaNCC, "? MaNCC");
                        return;
                    }
                    if (txtTenNCC.Text == "")
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(txtTenNCC, "? TenNCC");
                        return;
                    }
                    if (txtDienThoai.Text == "")
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(txtDienThoai, "? Điện Thoại");
                        return;
                    }
                    if (txtDienThoai.Text.Length < 10 || txtDienThoai.Text.Length > 13)
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(txtDienThoai, "Số điện thoại không đúng");
                        return;
                    }
                    for (int i = 0; i < dataGridViewNhaCungCap.Rows.Count - 0; i++)
                    {
                        if (txtTenNCC.Text.ToLower() == dataGridViewNhaCungCap.Rows[i].Cells["TenNCC"].Value.ToString().ToLower())
                        {
                            errorMes.BlinkRate = 100;
                            errorMes.SetError(txtTenNCC, "Đã Tồn Tại");
                            return;
                        }
                        if (txtDienThoai.Text.ToLower() == dataGridViewNhaCungCap.Rows[i].Cells["DienThoai"].Value.ToString().ToLower())
                        {
                            errorMes.BlinkRate = 100;
                            errorMes.SetError(txtDienThoai, "Đã Tồn Tại");
                            return;
                        }
                        if (txtEmail.Text.ToLower() == dataGridViewNhaCungCap.Rows[i].Cells["Email"].Value.ToString().ToLower())
                        {
                            errorMes.BlinkRate = 100;
                            errorMes.SetError(txtEmail, "Đã Tồn Tại");
                            return;
                        }
                    }
                    if (txtDiaChi.Text == "")
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(txtDiaChi, "? Địa chỉ");
                        return;
                    }

                    if (txtEmail.Text == "")
                    {
                        errorMes.BlinkRate = 100;
                        errorMes.SetError(txtEmail, "? Email");
                        return;
                    }
                    else
                    {
                        ncc.MaNCC = txtMaNCC.Text;
                        ncc.TenNCC = txtTenNCC.Text;
                        if (txtEmail.Text.Contains("@"))
                        {
                            ncc.Email = txtEmail.Text;
                        }
                        else
                        {
                            errorMes.BlinkRate = 100;
                            errorMes.SetError(txtEmail, "Email phải có @");
                            return;
                        }
                        ncc.DienThoai = txtDienThoai.Text;
                        ncc.DiaChi = txtDiaChi.Text;
                        ncc.TrangThai = "1";
                        bus.AddData(ncc);
                        MessageBox.Show("Thành Công");
                        ClearTextBox();
                        XuLyChucNang(true, false, false);
                        XuLyTexBox(true, false);
                    }
                }
                catch
                {
                    MessageBox.Show("Không thể thêm mới được !");
                    return;
                }
            }
            if (flag == 2)
            {
                if (txtMaNCC.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtMaNCC, "? MaNCC");
                    return;
                }
                if (txtTenNCC.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtTenNCC, "? TenNCC");
                    return;
                }
                if (txtDienThoai.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtDienThoai, "? Điện Thoại");
                    return;
                }
                if (txtDienThoai.Text.Length < 10 || txtDienThoai.Text.Length > 13)
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtDienThoai, "Số điện thoại không đúng");
                    return;
                }
                if (txtDiaChi.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtDiaChi, "? Địa chỉ");
                    return;
                }

                if (txtEmail.Text == "")
                {
                    errorMes.BlinkRate = 100;
                    errorMes.SetError(txtEmail, "? Email");
                    return;
                }
                else
                {
                    ncc.MaNCC = txtMaNCC.Text;
                    int vitri = dataGridViewNhaCungCap.CurrentCell.RowIndex;
                    if (dataGridViewNhaCungCap.Rows.Count > 0)
                    {
                        if (txtTenNCC.Text.ToLower() == dataGridViewNhaCungCap.Rows[vitri].Cells["TenNCC"].Value.ToString().ToLower())
                        {
                            // Bỏ Qua
                        }
                        else
                        {
                            for (int i = 0; i < dataGridViewNhaCungCap.Rows.Count - 0; i++)
                            {
                                if (txtTenNCC.Text.ToLower() == dataGridViewNhaCungCap.Rows[i].Cells["TenNCC"].Value.ToString().ToLower())
                                {
                                    errorMes.BlinkRate = 100;
                                    errorMes.SetError(txtTenNCC, "Đã tồn tại");
                                    return;
                                }
                            }
                        }
                        if (txtDienThoai.Text == dataGridViewNhaCungCap.Rows[vitri].Cells["DienThoai"].Value.ToString())
                        {
                            // Bỏ Qua
                        }
                        else
                        {
                            for (int i = 0; i < dataGridViewNhaCungCap.Rows.Count - 0; i++)
                            {
                                if (txtDienThoai.Text == dataGridViewNhaCungCap.Rows[i].Cells["DienThoai"].Value.ToString())
                                {
                                    errorMes.BlinkRate = 100;
                                    errorMes.SetError(txtDienThoai, "Đã tồn tại");
                                    return;
                                }
                            }
                        }
                        if (txtEmail.Text.ToLower() == dataGridViewNhaCungCap.Rows[vitri].Cells["Email"].Value.ToString().ToLower())
                        {
                            // Bỏ Qua
                        }
                        else
                        {
                            for (int i = 0; i < dataGridViewNhaCungCap.Rows.Count - 0; i++)
                            {
                                if (txtEmail.Text == dataGridViewNhaCungCap.Rows[i].Cells["Email"].Value.ToString())
                                {
                                    errorMes.BlinkRate = 100;
                                    errorMes.SetError(txtEmail, "Đã tồn tại");
                                    return;
                                }
                            }
                        }
                    }
                    ncc.TenNCC = txtTenNCC.Text;
                    ncc.DienThoai = txtDienThoai.Text;
                    ncc.Email = txtEmail.Text;
                    ncc.DiaChi = txtDiaChi.Text;
                    ncc.TrangThai = "1";
                    bus.EditData(ncc);
                    ClearTextBox();
                    XuLyChucNang(true, false, false);
                }
            }
            Display();
        }

        private void btnCapNhat_Click(object sender, EventArgs e)
        {

            Display();
        }

        private void Frm_NhaCungCap_Load(object sender, EventArgs e)
        {
            XuLyChucNang(true, false, false);
            XuLyTexBox(true, false);
        }
        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            string condition = txtSearch.Text;
            HienThiSearch(condition);
        }

        private void btnTHoat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtTenNCC_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (char.IsLetter(e.KeyChar) == false && char.IsControl(e.KeyChar) == false && char.IsDigit(e.KeyChar))
            //{
            //    e.Handled = true;
            //}
        }

        private void txtDienThoai_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsNumber(e.KeyChar) == false && char.IsControl(e.KeyChar) == false)
            {
                e.Handled = true;
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult KQ = MessageBox.Show("Bạn có muốn hủy hay không ?", "Thông Báo", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
            if (KQ == DialogResult.OK)
            {
                XuLyChucNang(true, false, false);
            }
        }

        private void dataGridViewNhaCungCap_DoubleClick(object sender, EventArgs e)
        {
            XuLyChucNang(false, true, true);
            XuLyTexBox(false, true);
        }


        private void dataGridViewNhaCungCap_RowPostPaint_1(object sender, DataGridViewRowPostPaintEventArgs e)
        {
            dataGridViewNhaCungCap.Rows[e.RowIndex].Cells[0].Value = (e.RowIndex + 1).ToString();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnXuat_Click(object sender, EventArgs e)
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
                    for (int i = 0; i < dataGridViewNhaCungCap.Columns.Count; i++)
                    {
                        worksheet.Cells[1, i + 1] = dataGridViewNhaCungCap.Columns[i].HeaderText;
                    }
                    for (int i = 0; i < dataGridViewNhaCungCap.Rows.Count; i++)
                    {
                        for (int j = 0; j < dataGridViewNhaCungCap.Columns.Count; j++)
                        {
                            if (dataGridViewNhaCungCap.Rows[i].Cells[j].Value != null)
                            {
                                worksheet.Cells[i + 2, j + 1] = dataGridViewNhaCungCap.Rows[i].Cells[j].Value.ToString();
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
            catch (Exception ex) { MessageBox.Show(ex.Message.ToString()); }
        }
    }
}
