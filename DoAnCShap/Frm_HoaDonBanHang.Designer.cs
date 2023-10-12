namespace DoAnCShap
{
    partial class Frm_HoaDonBanHang
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_HoaDonBanHang));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.dataGridViewHD = new System.Windows.Forms.DataGridView();
            this.STT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaHDBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TenKH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaNV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NgayLapHDBH = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dataGridViewCTHD = new System.Windows.Forms.DataGridView();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaSP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MaLK = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoLuong = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DonGia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.KhuyenMai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ThanhTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label13 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnClose = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnXuatExel = new System.Windows.Forms.Button();
            this.btnInHD = new System.Windows.Forms.Button();
            this.btnXoa = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.errorMes = new System.Windows.Forms.ErrorProvider(this.components);
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBoxKH = new System.Windows.Forms.TextBox();
            this.comboBoxNhanVien = new MetroFramework.Controls.MetroComboBox();
            this.txtTienThua = new System.Windows.Forms.Label();
            this.txtTienKDua = new System.Windows.Forms.TextBox();
            this.labelTongThanhToan = new System.Windows.Forms.Label();
            this.txtMaHD = new System.Windows.Forms.TextBox();
            this.dateTimePickerNgaylap = new System.Windows.Forms.DateTimePicker();
            this.label15 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.comboBoxLK = new MetroFramework.Controls.MetroComboBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.txtThanhTien = new System.Windows.Forms.Label();
            this.txtKhuyenMai = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.textBoxSL = new System.Windows.Forms.TextBox();
            this.txtDonGia = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHD)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTHD)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorMes)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.groupBox1.Controls.Add(this.dataGridViewHD);
            this.groupBox1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(7, 384);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(583, 315);
            this.groupBox1.TabIndex = 25;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Danh Sách Hóa Đơn";
            // 
            // dataGridViewHD
            // 
            this.dataGridViewHD.AllowUserToAddRows = false;
            this.dataGridViewHD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewHD.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.STT,
            this.MaHDBH,
            this.TenKH,
            this.MaNV,
            this.NgayLapHDBH,
            this.TongT});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewHD.DefaultCellStyle = dataGridViewCellStyle3;
            this.dataGridViewHD.Location = new System.Drawing.Point(5, 19);
            this.dataGridViewHD.Name = "dataGridViewHD";
            this.dataGridViewHD.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewHD.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewHD.RowHeadersVisible = false;
            this.dataGridViewHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewHD.Size = new System.Drawing.Size(572, 277);
            this.dataGridViewHD.TabIndex = 0;
            this.dataGridViewHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewHD_CellClick);
            this.dataGridViewHD.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewHD_RowPostPaint);
            this.dataGridViewHD.DoubleClick += new System.EventHandler(this.dataGridViewHD_DoubleClick);
            // 
            // STT
            // 
            this.STT.HeaderText = "STT";
            this.STT.Name = "STT";
            this.STT.ReadOnly = true;
            // 
            // MaHDBH
            // 
            this.MaHDBH.DataPropertyName = "MaHDBH";
            this.MaHDBH.HeaderText = "Mã hóa đơn";
            this.MaHDBH.Name = "MaHDBH";
            this.MaHDBH.ReadOnly = true;
            // 
            // TenKH
            // 
            this.TenKH.DataPropertyName = "TenKH";
            this.TenKH.HeaderText = "Tên khách hàng";
            this.TenKH.Name = "TenKH";
            this.TenKH.ReadOnly = true;
            // 
            // MaNV
            // 
            this.MaNV.DataPropertyName = "TenNV";
            this.MaNV.HeaderText = "Tên nhân viên";
            this.MaNV.Name = "MaNV";
            this.MaNV.ReadOnly = true;
            // 
            // NgayLapHDBH
            // 
            this.NgayLapHDBH.DataPropertyName = "NgayLapHDBH";
            dataGridViewCellStyle1.Format = "dd/MM/yyyy HH:mm:ss";
            this.NgayLapHDBH.DefaultCellStyle = dataGridViewCellStyle1;
            this.NgayLapHDBH.HeaderText = "Ngày lập";
            this.NgayLapHDBH.Name = "NgayLapHDBH";
            this.NgayLapHDBH.ReadOnly = true;
            // 
            // TongT
            // 
            this.TongT.DataPropertyName = "TongTien";
            dataGridViewCellStyle2.Format = "0,00";
            this.TongT.DefaultCellStyle = dataGridViewCellStyle2;
            this.TongT.HeaderText = "Tổng tiền";
            this.TongT.Name = "TongT";
            this.TongT.ReadOnly = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.dataGridViewCTHD);
            this.groupBox2.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.Location = new System.Drawing.Point(596, 384);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(576, 315);
            this.groupBox2.TabIndex = 26;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Danh sách chi tiết hóa đơn";
            // 
            // dataGridViewCTHD
            // 
            this.dataGridViewCTHD.AllowUserToAddRows = false;
            this.dataGridViewCTHD.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridViewCTHD.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewCTHD.BackgroundColor = System.Drawing.Color.White;
            this.dataGridViewCTHD.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Column1,
            this.MaSP,
            this.MaLK,
            this.SoLuong,
            this.DonGia,
            this.KhuyenMai,
            this.ThanhTien});
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dataGridViewCTHD.DefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridViewCTHD.Location = new System.Drawing.Point(6, 20);
            this.dataGridViewCTHD.Name = "dataGridViewCTHD";
            this.dataGridViewCTHD.ReadOnly = true;
            this.dataGridViewCTHD.RowHeadersVisible = false;
            this.dataGridViewCTHD.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewCTHD.Size = new System.Drawing.Size(564, 276);
            this.dataGridViewCTHD.TabIndex = 0;
            this.dataGridViewCTHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCTHD_CellClick);
            this.dataGridViewCTHD.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridViewCTHD_CellEndEdit);
            this.dataGridViewCTHD.RowPostPaint += new System.Windows.Forms.DataGridViewRowPostPaintEventHandler(this.dataGridViewCTHD_RowPostPaint);
            this.dataGridViewCTHD.DoubleClick += new System.EventHandler(this.dataGridViewCTHD_DoubleClick);
            // 
            // Column1
            // 
            this.Column1.HeaderText = "STT";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // MaSP
            // 
            this.MaSP.DataPropertyName = "MaLK";
            this.MaSP.HeaderText = "Mã linh kiện";
            this.MaSP.Name = "MaSP";
            this.MaSP.ReadOnly = true;
            this.MaSP.Visible = false;
            // 
            // MaLK
            // 
            this.MaLK.DataPropertyName = "TenLK";
            this.MaLK.HeaderText = "Tên linh kiện";
            this.MaLK.Name = "MaLK";
            this.MaLK.ReadOnly = true;
            // 
            // SoLuong
            // 
            this.SoLuong.DataPropertyName = "SoLuong";
            this.SoLuong.HeaderText = "Số lượng";
            this.SoLuong.Name = "SoLuong";
            this.SoLuong.ReadOnly = true;
            // 
            // DonGia
            // 
            this.DonGia.DataPropertyName = "DonGia";
            dataGridViewCellStyle5.Format = "0,00";
            this.DonGia.DefaultCellStyle = dataGridViewCellStyle5;
            this.DonGia.HeaderText = "Đơn giá";
            this.DonGia.Name = "DonGia";
            this.DonGia.ReadOnly = true;
            // 
            // KhuyenMai
            // 
            this.KhuyenMai.DataPropertyName = "KhuyenMai";
            this.KhuyenMai.HeaderText = "Chiết khấu";
            this.KhuyenMai.Name = "KhuyenMai";
            this.KhuyenMai.ReadOnly = true;
            // 
            // ThanhTien
            // 
            this.ThanhTien.DataPropertyName = "ThanhTien";
            dataGridViewCellStyle6.Format = "0,00";
            this.ThanhTien.DefaultCellStyle = dataGridViewCellStyle6;
            this.ThanhTien.HeaderText = "Thành tiền";
            this.ThanhTien.Name = "ThanhTien";
            this.ThanhTien.ReadOnly = true;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.panel1.Controls.Add(this.label13);
            this.panel1.Controls.Add(this.txtSearch);
            this.panel1.Controls.Add(this.btnClose);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1184, 43);
            this.panel1.TabIndex = 30;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(281, 12);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(136, 21);
            this.label13.TabIndex = 1;
            this.label13.Text = "Tìm kiếm hóa đơn";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtSearch.Location = new System.Drawing.Point(441, 9);
            this.txtSearch.Multiline = true;
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(324, 27);
            this.txtSearch.TabIndex = 0;
            this.txtSearch.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSearch.TextChanged += new System.EventHandler(this.txtSearch_TextChanged);
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.FlatAppearance.BorderSize = 0;
            this.btnClose.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.Location = new System.Drawing.Point(1114, 3);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(60, 35);
            this.btnClose.TabIndex = 1;
            this.btnClose.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.btnXuatExel);
            this.panel2.Controls.Add(this.btnInHD);
            this.panel2.Controls.Add(this.btnXoa);
            this.panel2.Controls.Add(this.btnEdit);
            this.panel2.Location = new System.Drawing.Point(12, 314);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1160, 61);
            this.panel2.TabIndex = 31;
            // 
            // btnXuatExel
            // 
            this.btnXuatExel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnXuatExel.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXuatExel.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXuatExel.Image = ((System.Drawing.Image)(resources.GetObject("btnXuatExel.Image")));
            this.btnXuatExel.Location = new System.Drawing.Point(1051, 9);
            this.btnXuatExel.Name = "btnXuatExel";
            this.btnXuatExel.Size = new System.Drawing.Size(84, 40);
            this.btnXuatExel.TabIndex = 5;
            this.btnXuatExel.Text = "Xuất";
            this.btnXuatExel.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXuatExel.UseVisualStyleBackColor = true;
            this.btnXuatExel.Click += new System.EventHandler(this.btnXuatExel_Click);
            // 
            // btnInHD
            // 
            this.btnInHD.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnInHD.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnInHD.Image = ((System.Drawing.Image)(resources.GetObject("btnInHD.Image")));
            this.btnInHD.Location = new System.Drawing.Point(722, 9);
            this.btnInHD.Name = "btnInHD";
            this.btnInHD.Size = new System.Drawing.Size(119, 40);
            this.btnInHD.TabIndex = 4;
            this.btnInHD.Text = "In Hóa Đơn";
            this.btnInHD.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnInHD.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnInHD.UseVisualStyleBackColor = true;
            this.btnInHD.Click += new System.EventHandler(this.btnInHD_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnXoa.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnXoa.Image = ((System.Drawing.Image)(resources.GetObject("btnXoa.Image")));
            this.btnXoa.Location = new System.Drawing.Point(352, 9);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Size = new System.Drawing.Size(84, 40);
            this.btnXoa.TabIndex = 0;
            this.btnXoa.Text = "Xóa";
            this.btnXoa.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnXoa.UseVisualStyleBackColor = true;
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEdit.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEdit.Image = ((System.Drawing.Image)(resources.GetObject("btnEdit.Image")));
            this.btnEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEdit.Location = new System.Drawing.Point(13, 9);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(89, 40);
            this.btnEdit.TabIndex = 0;
            this.btnEdit.Text = "Sửa";
            this.btnEdit.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // errorMes
            // 
            this.errorMes.ContainerControl = this;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBoxKH);
            this.groupBox3.Controls.Add(this.comboBoxNhanVien);
            this.groupBox3.Controls.Add(this.txtTienThua);
            this.groupBox3.Controls.Add(this.txtTienKDua);
            this.groupBox3.Controls.Add(this.labelTongThanhToan);
            this.groupBox3.Controls.Add(this.txtMaHD);
            this.groupBox3.Controls.Add(this.dateTimePickerNgaylap);
            this.groupBox3.Controls.Add(this.label15);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label16);
            this.groupBox3.Controls.Add(this.label12);
            this.groupBox3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(12, 52);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(638, 256);
            this.groupBox3.TabIndex = 34;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Thông tin chung";
            // 
            // comboBoxKH
            // 
            this.comboBoxKH.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxKH.Location = new System.Drawing.Point(83, 114);
            this.comboBoxKH.Multiline = true;
            this.comboBoxKH.Name = "comboBoxKH";
            this.comboBoxKH.Size = new System.Drawing.Size(236, 29);
            this.comboBoxKH.TabIndex = 65;
            // 
            // comboBoxNhanVien
            // 
            this.comboBoxNhanVien.FormattingEnabled = true;
            this.comboBoxNhanVien.ItemHeight = 23;
            this.comboBoxNhanVien.Location = new System.Drawing.Point(358, 114);
            this.comboBoxNhanVien.Name = "comboBoxNhanVien";
            this.comboBoxNhanVien.Size = new System.Drawing.Size(224, 29);
            this.comboBoxNhanVien.TabIndex = 64;
            this.comboBoxNhanVien.UseSelectable = true;
            // 
            // txtTienThua
            // 
            this.txtTienThua.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTienThua.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienThua.ForeColor = System.Drawing.Color.Red;
            this.txtTienThua.Location = new System.Drawing.Point(237, 220);
            this.txtTienThua.Name = "txtTienThua";
            this.txtTienThua.Size = new System.Drawing.Size(278, 29);
            this.txtTienThua.TabIndex = 60;
            this.txtTienThua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtTienKDua
            // 
            this.txtTienKDua.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTienKDua.ForeColor = System.Drawing.Color.Red;
            this.txtTienKDua.Location = new System.Drawing.Point(358, 181);
            this.txtTienKDua.Multiline = true;
            this.txtTienKDua.Name = "txtTienKDua";
            this.txtTienKDua.Size = new System.Drawing.Size(224, 29);
            this.txtTienKDua.TabIndex = 59;
            this.txtTienKDua.TextChanged += new System.EventHandler(this.txtTienKDua_TextChanged);
            this.txtTienKDua.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTienKDua_KeyPress);
            // 
            // labelTongThanhToan
            // 
            this.labelTongThanhToan.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.labelTongThanhToan.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTongThanhToan.ForeColor = System.Drawing.Color.Red;
            this.labelTongThanhToan.Location = new System.Drawing.Point(83, 181);
            this.labelTongThanhToan.Name = "labelTongThanhToan";
            this.labelTongThanhToan.Size = new System.Drawing.Size(236, 29);
            this.labelTongThanhToan.TabIndex = 63;
            this.labelTongThanhToan.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtMaHD
            // 
            this.txtMaHD.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtMaHD.Location = new System.Drawing.Point(83, 51);
            this.txtMaHD.Multiline = true;
            this.txtMaHD.Name = "txtMaHD";
            this.txtMaHD.Size = new System.Drawing.Size(236, 29);
            this.txtMaHD.TabIndex = 62;
            this.txtMaHD.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtMaHD_KeyPress);
            // 
            // dateTimePickerNgaylap
            // 
            this.dateTimePickerNgaylap.CustomFormat = "dd/MM/yyyy HH:mm:ss";
            this.dateTimePickerNgaylap.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerNgaylap.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerNgaylap.Location = new System.Drawing.Point(358, 51);
            this.dateTimePickerNgaylap.Name = "dateTimePickerNgaylap";
            this.dateTimePickerNgaylap.Size = new System.Drawing.Size(224, 29);
            this.dateTimePickerNgaylap.TabIndex = 61;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.White;
            this.label15.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(354, 152);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(114, 21);
            this.label15.TabIndex = 57;
            this.label15.Text = "Tiền khách đưa";
            this.label15.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.White;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(79, 151);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(124, 21);
            this.label5.TabIndex = 52;
            this.label5.Text = "Tổng thanh toán";
            this.label5.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.White;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(354, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 21);
            this.label4.TabIndex = 53;
            this.label4.Text = "Ngày lập";
            this.label4.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.White;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(354, 89);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 21);
            this.label3.TabIndex = 54;
            this.label3.Text = "Nhân viên";
            this.label3.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.White;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(91, 21);
            this.label2.TabIndex = 55;
            this.label2.Text = "Khách hàng";
            this.label2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.White;
            this.label16.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(144, 223);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(74, 21);
            this.label16.TabIndex = 58;
            this.label16.Text = "Tiền thừa";
            this.label16.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.White;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(79, 21);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(94, 21);
            this.label12.TabIndex = 56;
            this.label12.Text = "Mã hóa đơn";
            this.label12.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // comboBoxLK
            // 
            this.comboBoxLK.FormattingEnabled = true;
            this.comboBoxLK.ItemHeight = 23;
            this.comboBoxLK.Location = new System.Drawing.Point(151, 28);
            this.comboBoxLK.Name = "comboBoxLK";
            this.comboBoxLK.Size = new System.Drawing.Size(277, 29);
            this.comboBoxLK.TabIndex = 46;
            this.comboBoxLK.UseSelectable = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox4.Controls.Add(this.comboBoxLK);
            this.groupBox4.Controls.Add(this.txtThanhTien);
            this.groupBox4.Controls.Add(this.txtKhuyenMai);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label8);
            this.groupBox4.Controls.Add(this.label14);
            this.groupBox4.Controls.Add(this.textBoxSL);
            this.groupBox4.Controls.Add(this.txtDonGia);
            this.groupBox4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(656, 52);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(516, 256);
            this.groupBox4.TabIndex = 35;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Thông tin sản phẩm";
            // 
            // txtThanhTien
            // 
            this.txtThanhTien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtThanhTien.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtThanhTien.ForeColor = System.Drawing.Color.Red;
            this.txtThanhTien.Location = new System.Drawing.Point(150, 213);
            this.txtThanhTien.Name = "txtThanhTien";
            this.txtThanhTien.Size = new System.Drawing.Size(277, 29);
            this.txtThanhTien.TabIndex = 54;
            this.txtThanhTien.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // txtKhuyenMai
            // 
            this.txtKhuyenMai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtKhuyenMai.Location = new System.Drawing.Point(150, 167);
            this.txtKhuyenMai.Multiline = true;
            this.txtKhuyenMai.Name = "txtKhuyenMai";
            this.txtKhuyenMai.Size = new System.Drawing.Size(277, 29);
            this.txtKhuyenMai.TabIndex = 46;
            this.txtKhuyenMai.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtKhuyenMai_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.White;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(23, 216);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(83, 21);
            this.label11.TabIndex = 49;
            this.label11.Text = "Thành tiền";
            this.label11.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.White;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(24, 168);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(107, 21);
            this.label10.TabIndex = 50;
            this.label10.Text = "Chiết khấu(%)";
            this.label10.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.White;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(25, 123);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 21);
            this.label9.TabIndex = 51;
            this.label9.Text = "Đơn giá";
            this.label9.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.White;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(24, 76);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(73, 21);
            this.label8.TabIndex = 52;
            this.label8.Text = "Số lượng";
            this.label8.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.White;
            this.label14.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(23, 31);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 21);
            this.label14.TabIndex = 53;
            this.label14.Text = "Tên linh kiện";
            this.label14.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            // 
            // textBoxSL
            // 
            this.textBoxSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSL.Location = new System.Drawing.Point(150, 76);
            this.textBoxSL.Multiline = true;
            this.textBoxSL.Name = "textBoxSL";
            this.textBoxSL.Size = new System.Drawing.Size(277, 29);
            this.textBoxSL.TabIndex = 47;
            // 
            // txtDonGia
            // 
            this.txtDonGia.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDonGia.Location = new System.Drawing.Point(150, 122);
            this.txtDonGia.Multiline = true;
            this.txtDonGia.Name = "txtDonGia";
            this.txtDonGia.Size = new System.Drawing.Size(277, 29);
            this.txtDonGia.TabIndex = 48;
            this.txtDonGia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtDonGia_KeyPress);
            // 
            // Frm_HoaDonBanHang
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1184, 711);
            this.ControlBox = false;
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Frm_HoaDonBanHang";
            this.Text = "Frm_HoaDonBanHang";
            this.Load += new System.EventHandler(this.Frm_HoaDonBanHang_Load);
            this.groupBox1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewHD)).EndInit();
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewCTHD)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorMes)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView dataGridViewCTHD;
        public System.Windows.Forms.DataGridView dataGridViewHD;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnClose;
        private System.Windows.Forms.Button btnXoa;
        private System.Windows.Forms.Button btnInHD;
        private System.Windows.Forms.ErrorProvider errorMes;
        private System.Windows.Forms.Button btnXuatExel;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox comboBoxKH;
        private MetroFramework.Controls.MetroComboBox comboBoxNhanVien;
        private System.Windows.Forms.Label txtTienThua;
        private System.Windows.Forms.TextBox txtTienKDua;
        private System.Windows.Forms.Label labelTongThanhToan;
        private System.Windows.Forms.TextBox txtMaHD;
        private System.Windows.Forms.DateTimePicker dateTimePickerNgaylap;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox groupBox4;
        private MetroFramework.Controls.MetroComboBox comboBoxLK;
        private System.Windows.Forms.Label txtThanhTien;
        private System.Windows.Forms.TextBox txtKhuyenMai;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox textBoxSL;
        private System.Windows.Forms.TextBox txtDonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn STT;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaHDBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TenKH;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaNV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NgayLapHDBH;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongT;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaSP;
        private System.Windows.Forms.DataGridViewTextBoxColumn MaLK;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoLuong;
        private System.Windows.Forms.DataGridViewTextBoxColumn DonGia;
        private System.Windows.Forms.DataGridViewTextBoxColumn KhuyenMai;
        private System.Windows.Forms.DataGridViewTextBoxColumn ThanhTien;
    }
}