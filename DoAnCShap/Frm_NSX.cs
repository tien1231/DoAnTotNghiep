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
    public partial class Frm_NSX : Form
    {
        public Frm_NSX()
        {
            InitializeComponent();
        }
        NhaSanXuat_BUS bus = new NhaSanXuat_BUS();
        NhaSanXuat nsx = new NhaSanXuat();
        int flag = 0;
        public void DisPlay()
        {
            dataGridViewNSX.DataSource = bus.GetData("");
        }

        public void HienThiSearch(string Condition)
        {
            dataGridViewNSX.DataSource = bus.GetTimKiem("Select * From NhaSanXuat Where TenNSX Like N'%"+Condition+"%'");
        }
        public void xulytextbox(Boolean b1, Boolean b2)
        {
            txtMansx.Enabled = b1;
            txtTenNSX.Enabled = b1;
            txtDiaChi.Enabled = b1;
            cboTrangThai.Enabled = b1;
        }

        public void xulychucnang(Boolean b1, Boolean b2, Boolean b3)
        {
            btnThem.Enabled = b1;
            btnXoa.Enabled = b3;
            btnLuu.Enabled = b2;
            btnHuy.Enabled = b2;
        }

        public void Clear()
        {
            txtMansx.Clear();
            txtTenNSX.Clear();
            txtDiaChi.Clear();
            cboTrangThai.Text = "";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            flag = 1;
            xulychucnang(false,true,true);
            xulytextbox(true, false);
            PhatSinhMa();
        }


        public void PhatSinhMa()
        {
            int count = 0;
            count = dataGridViewNSX.Rows.Count;
            string chuoi = "";
            int chuoi2 = 0;
            if (count <= 1)
            {
                txtMansx.Text = "NSX01";
            }
            else
            {
                chuoi = Convert.ToString(dataGridViewNSX.Rows[count - 2].Cells[0].Value);
                chuoi2 = Convert.ToInt32((chuoi.Remove(0, 3)));
                if (chuoi2 + 1 < 10)
                    txtMansx.Text = "NSX0" + (chuoi2 + 1).ToString();
                else if (chuoi2 + 1 < 100)
                    txtMansx.Text = "NSX" + (chuoi2 + 1).ToString();
            }
        }
        private void Frm_NSX_Load(object sender, EventArgs e)
        {
            DisPlay();
            xulychucnang(true, false, false);
            xulytextbox(false, true);
        }

        private void btnLuu_Click(object sender, EventArgs e)
        {
               if(flag==1)
                {
                if (txtMansx.Text != "" && txtTenNSX.Text != "" && txtDiaChi.Text != "")
                {
                    nsx.MaNSX = txtMansx.Text;
                    nsx.TenNSX = txtTenNSX.Text;
                    nsx.DiaChi = txtDiaChi.Text;
                    nsx.TrangThai = cboTrangThai.Text;
                    bus.AddData(nsx);
                    MessageBox.Show("Thêm Nhà Sản Xuất Thành Công");
                    Clear();
                    xulychucnang(true, false, false);
                    xulytextbox(false, true);
                }
                else
                {
                    MessageBox.Show("Fail!");
                }
                }
                if(flag==2)
            {
                nsx.MaNSX = txtMansx.Text;
                nsx.TenNSX = txtTenNSX.Text;
                nsx.DiaChi = txtDiaChi.Text;
                nsx.TrangThai = cboTrangThai.Text;
                bus.EditData(nsx);
                MessageBox.Show("Thành Công");
                Clear();
                xulychucnang(true, false, false);
                xulytextbox(false, true);
            }
            DisPlay();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void dataGridViewNSX_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DataGridViewRow row = dataGridViewNSX.Rows[e.RowIndex];
            txtMansx.Text = row.Cells[0].Value.ToString();
            txtTenNSX.Text = row.Cells[1].Value.ToString();
            txtDiaChi.Text = row.Cells[2].Value.ToString();
            cboTrangThai.Text = row.Cells[3].Value.ToString();
        }

        private void dataGridViewNSX_DoubleClick(object sender, EventArgs e)
        {
            flag = 2;
            xulychucnang(false, true, true);
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            nsx.MaNSX = txtMansx.Text;
            bus.DeleteData(nsx);
            MessageBox.Show("Thanh Cong");
            DisPlay();
            Clear();
            xulychucnang(true, false, false);
            xulytextbox(false, true);
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            String Condition = txtSearch.Text;
            HienThiSearch(Condition);
        }
    }
}
