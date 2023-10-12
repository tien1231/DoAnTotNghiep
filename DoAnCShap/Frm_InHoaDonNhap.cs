using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DoAnCShap
{
    public partial class Frm_InHoaDonNhap : Form
    {
        public Frm_InHoaDonNhap()
        {
            InitializeComponent();
        }

        private void Frm_InHoaDonNhap_Load(object sender, EventArgs e)
        {

            this.reportViewer2.RefreshReport();
        }
    }
}
