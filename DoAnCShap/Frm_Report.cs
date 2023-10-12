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
    public partial class Frm_Report : Form
    {
        public Frm_Report()
        {
            InitializeComponent();
        }

        private void Frm_Report_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'PM_BanLinhKienPCDataSet.LinhKien' table. You can move, or remove it, as needed.
            this.LinhKienTableAdapter.Fill(this.PM_BanLinhKienPCDataSet.LinhKien);

            this.reportViewer2.RefreshReport();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
