
namespace DoAnCShap
{
    partial class Frm_ThongKe
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_ThongKe));
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.comboBoxThang = new MetroFramework.Controls.MetroComboBox();
            this.comboBoxNam = new MetroFramework.Controls.MetroComboBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.radioBKhachmuanhieutrongnam = new System.Windows.Forms.RadioButton();
            this.radioButKhachMuaNhieeu = new System.Windows.Forms.RadioButton();
            this.radioSPHetHang = new System.Windows.Forms.RadioButton();
            this.radioSPTonKho = new System.Windows.Forms.RadioButton();
            this.radioButKhanChiNam = new System.Windows.Forms.RadioButton();
            this.radioButThuChi = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.radioDoanhThuYea = new System.Windows.Forms.RadioButton();
            this.radioTheoThang = new System.Windows.Forms.RadioButton();
            this.radioBanNhieuMonth = new System.Windows.Forms.RadioButton();
            this.radioButMuaYear = new System.Windows.Forms.RadioButton();
            this.radioBanNhieuYear = new System.Windows.Forms.RadioButton();
            this.radioButMuaMonth = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.btnXemDoanhThu = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.chart1 = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.errorMes = new System.Windows.Forms.ErrorProvider(this.components);
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.cboDoanhThu = new System.Windows.Forms.ComboBox();
            this.panel4 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.comboloinhuan = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.comboBoxChi = new System.Windows.Forms.ComboBox();
            this.panel5 = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMes)).BeginInit();
            this.panel4.SuspendLayout();
            this.panel5.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.White;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.comboBoxThang);
            this.panel1.Controls.Add(this.comboBoxNam);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.btnXemDoanhThu);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Location = new System.Drawing.Point(12, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(726, 321);
            this.panel1.TabIndex = 0;
            // 
            // comboBoxThang
            // 
            this.comboBoxThang.FormattingEnabled = true;
            this.comboBoxThang.ItemHeight = 23;
            this.comboBoxThang.Items.AddRange(new object[] {
            "1",
            "2",
            "3",
            "4",
            "5",
            "6",
            "7",
            "8",
            "9",
            "10",
            "11",
            "12"});
            this.comboBoxThang.Location = new System.Drawing.Point(117, 279);
            this.comboBoxThang.Name = "comboBoxThang";
            this.comboBoxThang.Size = new System.Drawing.Size(99, 29);
            this.comboBoxThang.TabIndex = 13;
            this.comboBoxThang.UseSelectable = true;
            // 
            // comboBoxNam
            // 
            this.comboBoxNam.FormattingEnabled = true;
            this.comboBoxNam.ItemHeight = 23;
            this.comboBoxNam.Location = new System.Drawing.Point(294, 280);
            this.comboBoxNam.Name = "comboBoxNam";
            this.comboBoxNam.Size = new System.Drawing.Size(121, 29);
            this.comboBoxNam.TabIndex = 12;
            this.comboBoxNam.UseSelectable = true;
            // 
            // panel2
            // 
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.radioBKhachmuanhieutrongnam);
            this.panel2.Controls.Add(this.radioButKhachMuaNhieeu);
            this.panel2.Controls.Add(this.radioSPHetHang);
            this.panel2.Controls.Add(this.radioSPTonKho);
            this.panel2.Controls.Add(this.radioButKhanChiNam);
            this.panel2.Controls.Add(this.radioButThuChi);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.radioDoanhThuYea);
            this.panel2.Controls.Add(this.radioTheoThang);
            this.panel2.Controls.Add(this.radioBanNhieuMonth);
            this.panel2.Controls.Add(this.radioButMuaYear);
            this.panel2.Controls.Add(this.radioBanNhieuYear);
            this.panel2.Controls.Add(this.radioButMuaMonth);
            this.panel2.Location = new System.Drawing.Point(7, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(716, 266);
            this.panel2.TabIndex = 11;
            // 
            // radioBKhachmuanhieutrongnam
            // 
            this.radioBKhachmuanhieutrongnam.AutoSize = true;
            this.radioBKhachmuanhieutrongnam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBKhachmuanhieutrongnam.Location = new System.Drawing.Point(381, 52);
            this.radioBKhachmuanhieutrongnam.Name = "radioBKhachmuanhieutrongnam";
            this.radioBKhachmuanhieutrongnam.Size = new System.Drawing.Size(264, 25);
            this.radioBKhachmuanhieutrongnam.TabIndex = 12;
            this.radioBKhachmuanhieutrongnam.TabStop = true;
            this.radioBKhachmuanhieutrongnam.Text = "Khách hàng mua nhiều trong năm\r\n";
            this.radioBKhachmuanhieutrongnam.UseVisualStyleBackColor = true;
            // 
            // radioButKhachMuaNhieeu
            // 
            this.radioButKhachMuaNhieeu.AutoSize = true;
            this.radioButKhachMuaNhieeu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButKhachMuaNhieeu.Location = new System.Drawing.Point(381, 10);
            this.radioButKhachMuaNhieeu.Name = "radioButKhachMuaNhieeu";
            this.radioButKhachMuaNhieeu.Size = new System.Drawing.Size(273, 25);
            this.radioButKhachMuaNhieeu.TabIndex = 12;
            this.radioButKhachMuaNhieeu.TabStop = true;
            this.radioButKhachMuaNhieeu.Text = "Khách hàng mua nhiều trong tháng";
            this.radioButKhachMuaNhieeu.UseVisualStyleBackColor = true;
            // 
            // radioSPHetHang
            // 
            this.radioSPHetHang.AutoSize = true;
            this.radioSPHetHang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSPHetHang.Location = new System.Drawing.Point(381, 234);
            this.radioSPHetHang.Name = "radioSPHetHang";
            this.radioSPHetHang.Size = new System.Drawing.Size(191, 25);
            this.radioSPHetHang.TabIndex = 12;
            this.radioSPHetHang.TabStop = true;
            this.radioSPHetHang.Text = "Sản phẩm sắp hết hàng";
            this.radioSPHetHang.UseVisualStyleBackColor = true;
            // 
            // radioSPTonKho
            // 
            this.radioSPTonKho.AutoSize = true;
            this.radioSPTonKho.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioSPTonKho.Location = new System.Drawing.Point(384, 186);
            this.radioSPTonKho.Name = "radioSPTonKho";
            this.radioSPTonKho.Size = new System.Drawing.Size(155, 25);
            this.radioSPTonKho.TabIndex = 12;
            this.radioSPTonKho.TabStop = true;
            this.radioSPTonKho.Text = "Sản phẩm tồn kho";
            this.radioSPTonKho.UseVisualStyleBackColor = true;
            // 
            // radioButKhanChiNam
            // 
            this.radioButKhanChiNam.AutoSize = true;
            this.radioButKhanChiNam.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButKhanChiNam.Location = new System.Drawing.Point(384, 142);
            this.radioButKhanChiNam.Name = "radioButKhanChiNam";
            this.radioButKhanChiNam.Size = new System.Drawing.Size(187, 25);
            this.radioButKhanChiNam.TabIndex = 12;
            this.radioButKhanChiNam.TabStop = true;
            this.radioButKhanChiNam.Text = "Xem thu chi trong năm\r\n";
            this.radioButKhanChiNam.UseVisualStyleBackColor = true;
            // 
            // radioButThuChi
            // 
            this.radioButThuChi.AutoSize = true;
            this.radioButThuChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButThuChi.Location = new System.Drawing.Point(381, 96);
            this.radioButThuChi.Name = "radioButThuChi";
            this.radioButThuChi.Size = new System.Drawing.Size(189, 25);
            this.radioButThuChi.TabIndex = 12;
            this.radioButThuChi.TabStop = true;
            this.radioButThuChi.Text = "Xem thu chi theo tháng";
            this.radioButThuChi.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.label1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.label1.Location = new System.Drawing.Point(340, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(6, 274);
            this.label1.TabIndex = 11;
            // 
            // radioDoanhThuYea
            // 
            this.radioDoanhThuYea.AutoSize = true;
            this.radioDoanhThuYea.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioDoanhThuYea.Location = new System.Drawing.Point(3, 52);
            this.radioDoanhThuYea.Name = "radioDoanhThuYea";
            this.radioDoanhThuYea.Size = new System.Drawing.Size(164, 25);
            this.radioDoanhThuYea.TabIndex = 10;
            this.radioDoanhThuYea.TabStop = true;
            this.radioDoanhThuYea.Text = "Doanh thu của năm";
            this.radioDoanhThuYea.UseVisualStyleBackColor = true;
            // 
            // radioTheoThang
            // 
            this.radioTheoThang.AutoSize = true;
            this.radioTheoThang.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioTheoThang.Location = new System.Drawing.Point(3, 10);
            this.radioTheoThang.Name = "radioTheoThang";
            this.radioTheoThang.Size = new System.Drawing.Size(180, 25);
            this.radioTheoThang.TabIndex = 1;
            this.radioTheoThang.TabStop = true;
            this.radioTheoThang.Text = "Doanh thu theo tháng";
            this.radioTheoThang.UseVisualStyleBackColor = true;
            // 
            // radioBanNhieuMonth
            // 
            this.radioBanNhieuMonth.AutoSize = true;
            this.radioBanNhieuMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBanNhieuMonth.Location = new System.Drawing.Point(3, 96);
            this.radioBanNhieuMonth.Name = "radioBanNhieuMonth";
            this.radioBanNhieuMonth.Size = new System.Drawing.Size(289, 25);
            this.radioBanNhieuMonth.TabIndex = 9;
            this.radioBanNhieuMonth.TabStop = true;
            this.radioBanNhieuMonth.Text = "Top 3 sản phẩm bán nhiều theo tháng";
            this.radioBanNhieuMonth.UseVisualStyleBackColor = true;
            // 
            // radioButMuaYear
            // 
            this.radioButMuaYear.AutoSize = true;
            this.radioButMuaYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButMuaYear.Location = new System.Drawing.Point(3, 234);
            this.radioButMuaYear.Name = "radioButMuaYear";
            this.radioButMuaYear.Size = new System.Drawing.Size(296, 25);
            this.radioButMuaYear.TabIndex = 9;
            this.radioButMuaYear.TabStop = true;
            this.radioButMuaYear.Text = "Top 3 sản phẩm nhập nhiều trong năm\r\n";
            this.radioButMuaYear.UseVisualStyleBackColor = true;
            // 
            // radioBanNhieuYear
            // 
            this.radioBanNhieuYear.AutoSize = true;
            this.radioBanNhieuYear.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioBanNhieuYear.Location = new System.Drawing.Point(3, 142);
            this.radioBanNhieuYear.Name = "radioBanNhieuYear";
            this.radioBanNhieuYear.Size = new System.Drawing.Size(287, 25);
            this.radioBanNhieuYear.TabIndex = 9;
            this.radioBanNhieuYear.TabStop = true;
            this.radioBanNhieuYear.Text = "Top 3 sản phẩm bán nhiều trong năm";
            this.radioBanNhieuYear.UseVisualStyleBackColor = true;
            // 
            // radioButMuaMonth
            // 
            this.radioButMuaMonth.AutoSize = true;
            this.radioButMuaMonth.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radioButMuaMonth.Location = new System.Drawing.Point(3, 188);
            this.radioButMuaMonth.Name = "radioButMuaMonth";
            this.radioButMuaMonth.Size = new System.Drawing.Size(298, 25);
            this.radioButMuaMonth.TabIndex = 9;
            this.radioButMuaMonth.TabStop = true;
            this.radioButMuaMonth.Text = "Top 3 sản phẩm nhập nhiều theo tháng";
            this.radioButMuaMonth.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(57, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(53, 21);
            this.label3.TabIndex = 3;
            this.label3.Text = "Tháng";
            // 
            // btnXemDoanhThu
            // 
            this.btnXemDoanhThu.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXemDoanhThu.Image = ((System.Drawing.Image)(resources.GetObject("btnXemDoanhThu.Image")));
            this.btnXemDoanhThu.Location = new System.Drawing.Point(581, 274);
            this.btnXemDoanhThu.Name = "btnXemDoanhThu";
            this.btnXemDoanhThu.Size = new System.Drawing.Size(91, 41);
            this.btnXemDoanhThu.TabIndex = 6;
            this.btnXemDoanhThu.Text = "Xem";
            this.btnXemDoanhThu.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXemDoanhThu.UseVisualStyleBackColor = true;
            this.btnXemDoanhThu.Click += new System.EventHandler(this.btnXemDoanhThu_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(244, 283);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(44, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Năm";
            // 
            // chart1
            // 
            this.chart1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.chart1.BackColor = System.Drawing.Color.Transparent;
            chartArea1.Name = "ChartArea1";
            this.chart1.ChartAreas.Add(chartArea1);
            legend1.Name = "Legend1";
            this.chart1.Legends.Add(legend1);
            this.chart1.Location = new System.Drawing.Point(12, 376);
            this.chart1.Name = "chart1";
            this.chart1.Palette = System.Windows.Forms.DataVisualization.Charting.ChartColorPalette.EarthTones;
            series1.ChartArea = "ChartArea1";
            series1.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            series1.Legend = "Legend1";
            series1.Name = "Doanh Thu";
            series1.YValuesPerPoint = 4;
            this.chart1.Series.Add(series1);
            this.chart1.Size = new System.Drawing.Size(1160, 323);
            this.chart1.TabIndex = 4;
            this.chart1.Text = "chart1";
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.White;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1});
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridView1.DefaultCellStyle = dataGridViewCellStyle1;
            this.dataGridView1.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dataGridView1.Location = new System.Drawing.Point(744, 49);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersVisible = false;
            this.dataGridView1.Size = new System.Drawing.Size(428, 172);
            this.dataGridView1.TabIndex = 5;
            this.dataGridView1.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridView1_RowPostPaint);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            // 
            // errorMes
            // 
            this.errorMes.ContainerControl = this;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(309, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 24);
            this.label5.TabIndex = 47;
            this.label5.Text = "Đ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(13, 65);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(86, 21);
            this.label4.TabIndex = 46;
            this.label4.Text = "Doanh Thu";
            // 
            // cboDoanhThu
            // 
            this.cboDoanhThu.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.cboDoanhThu.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboDoanhThu.ForeColor = System.Drawing.Color.Red;
            this.cboDoanhThu.FormattingEnabled = true;
            this.cboDoanhThu.Location = new System.Drawing.Point(117, 60);
            this.cboDoanhThu.Name = "cboDoanhThu";
            this.cboDoanhThu.Size = new System.Drawing.Size(175, 28);
            this.cboDoanhThu.TabIndex = 45;
            this.cboDoanhThu.SelectedIndexChanged += new System.EventHandler(this.cboDoanhThu_SelectedIndexChanged);
            // 
            // panel4
            // 
            this.panel4.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.panel4.BackColor = System.Drawing.Color.White;
            this.panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel4.Controls.Add(this.label9);
            this.panel4.Controls.Add(this.label5);
            this.panel4.Controls.Add(this.label6);
            this.panel4.Controls.Add(this.label8);
            this.panel4.Controls.Add(this.label4);
            this.panel4.Controls.Add(this.comboloinhuan);
            this.panel4.Controls.Add(this.cboDoanhThu);
            this.panel4.Controls.Add(this.label7);
            this.panel4.Controls.Add(this.comboBoxChi);
            this.panel4.Location = new System.Drawing.Point(744, 227);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(428, 143);
            this.panel4.TabIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(309, 106);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(23, 24);
            this.label9.TabIndex = 47;
            this.label9.Text = "Đ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(309, 15);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(23, 24);
            this.label6.TabIndex = 47;
            this.label6.Text = "Đ";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(13, 110);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(83, 21);
            this.label8.TabIndex = 46;
            this.label8.Text = "Lợi Nhuận";
            // 
            // comboloinhuan
            // 
            this.comboloinhuan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboloinhuan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboloinhuan.ForeColor = System.Drawing.Color.Red;
            this.comboloinhuan.FormattingEnabled = true;
            this.comboloinhuan.Location = new System.Drawing.Point(117, 102);
            this.comboloinhuan.Name = "comboloinhuan";
            this.comboloinhuan.Size = new System.Drawing.Size(175, 28);
            this.comboloinhuan.TabIndex = 45;
            this.comboloinhuan.SelectedIndexChanged += new System.EventHandler(this.cboDoanhThu_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(13, 17);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(81, 21);
            this.label7.TabIndex = 46;
            this.label7.Text = "Khoản Chi";
            // 
            // comboBoxChi
            // 
            this.comboBoxChi.DropDownStyle = System.Windows.Forms.ComboBoxStyle.Simple;
            this.comboBoxChi.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxChi.ForeColor = System.Drawing.Color.Red;
            this.comboBoxChi.FormattingEnabled = true;
            this.comboBoxChi.Location = new System.Drawing.Point(117, 12);
            this.comboBoxChi.Name = "comboBoxChi";
            this.comboBoxChi.Size = new System.Drawing.Size(175, 28);
            this.comboBoxChi.TabIndex = 45;
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel5.Controls.Add(this.btnClose);
            this.panel5.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel5.Location = new System.Drawing.Point(0, 0);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1184, 43);
            this.panel5.TabIndex = 23;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1115, 5);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 35);
            this.btnClose.TabIndex = 0;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // Frm_ThongKe
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.Controls.Add(this.panel5);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.chart1);
            this.Controls.Add(this.panel1);
            this.Name = "Frm_ThongKe";
            this.Text = "Frm_ThongKe";
            this.Load += new System.EventHandler(this.Frm_ThongKe_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.chart1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorMes)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panel5.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.RadioButton radioTheoThang;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnXemDoanhThu;
        private System.Windows.Forms.DataVisualization.Charting.Chart chart1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.RadioButton radioBanNhieuMonth;
        private System.Windows.Forms.RadioButton radioDoanhThuYea;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.RadioButton radioBanNhieuYear;
        private System.Windows.Forms.RadioButton radioButMuaMonth;
        private System.Windows.Forms.RadioButton radioButMuaYear;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorMes;
        private System.Windows.Forms.RadioButton radioButThuChi;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboDoanhThu;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton radioButKhachMuaNhieeu;
        private System.Windows.Forms.RadioButton radioBKhachmuanhieutrongnam;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox comboBoxChi;
        private System.Windows.Forms.RadioButton radioButKhanChiNam;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button btnClose;
        private MetroFramework.Controls.MetroComboBox comboBoxNam;
        private MetroFramework.Controls.MetroComboBox comboBoxThang;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox comboloinhuan;
        private System.Windows.Forms.RadioButton radioSPTonKho;
        private System.Windows.Forms.RadioButton radioSPHetHang;
    }
}