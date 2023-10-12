using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

namespace DoAnCShap
{
    public partial class Frm_Setting : Form
    {
        public Frm_Setting()
        {
            InitializeComponent();
        }


        public static string SetValueForText1;
        public static string SetValueForText2;
        public static string SetValueForText3;

        public void Alert(string msg, Frm_Alert.enmType type)
        {
            Frm_Alert frm = new Frm_Alert();
            frm.showAlert(msg, type);
        }

        private void Frm_Setting_Load(object sender, EventArgs e)
        {
            //groupGioiThieu.Visible = false;
            //groupTroGiup.Visible = false;
        }
        private void btnThayDoi_Click(object sender, EventArgs e)
        {

            ColorDialog colDig = new ColorDialog();
            //Form1 form1 = Application.OpenForms.OfType<Form1>().FirstOrDefault();
            if (colDig.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.BackGroundColoPanelTop = colDig.Color;
                Properties.Settings.Default.Save();
                //this.BackColor = colDig.Color;
            }

        }

        private void btnChonFontChu_Click(object sender, EventArgs e)
        {
            FontDialog fontDialog = new FontDialog();
            if (fontDialog.ShowDialog() == DialogResult.OK)
            {
                Properties.Settings.Default.ChangeFont = fontDialog.Font;
                //Properties.Settings.Default.FormsBackgroundColor = fontDialog.Color;
                Properties.Settings.Default.Save();
                //this.BackColor = fontDialog.Color;

            }

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (txtSDT.Text == "")
            {
                errorMes.BlinkRate = 100;
                errorMes.SetError(txtSDT, "? Số Điện Thoại");
                return;
            }
            else
            {
                if (txtSDT.Text != "")
                {
                    Properties.Settings.Default.ChangeThongTIn = txtSDT.Text;
                    Properties.Settings.Default.Save();
                }
                if (txtHotLine.Text != "")
                {
                    Properties.Settings.Default.ChangeHotLine = txtHotLine.Text;
                    Properties.Settings.Default.Save();
                }
                if (txtDiaChi.Text != "")
                {
                    Properties.Settings.Default.ChangeDiaChi = txtDiaChi.Text;
                    Properties.Settings.Default.Save();
                }
                if (txtWebSite.Text != "")
                {
                    Properties.Settings.Default.ChangeWebsite = txtWebSite.Text;
                    Properties.Settings.Default.Save();
                }
                MessageBox.Show("Cập Nhật Thành Công");
            }

        }

        private void btnDong_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnQuyDinh_Click(object sender, EventArgs e)
        {

        }

        string urrl = "https://www.youtube.com/watch?v=9FqaMehDsUc&list=WL&index=1";
        private void button1_Click(object sender, EventArgs e)
        {
            string html = "html head";
            html += " meta content='IE=Edge' http-equiv='X-UA-Compatible'/ ";
            html += " iframe id='video' src= 'https://www.youtube.com/embed/{0}' width='600' height='300' frameborder='0' allowfullscreen  /iframe ";
            html += " /body  /html ";
            this.webBrowser1.DocumentText = string.Format(html, urrl.Split('=')[1]);
        }
    }
}
