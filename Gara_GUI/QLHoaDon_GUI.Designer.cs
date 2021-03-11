namespace Gara_GUI
{
    partial class QLHoaDon_GUI
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel1 = new System.Windows.Forms.Panel();
            this.DataGridHD = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.NVKT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NVTV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DIACHI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SoKhung = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOKM = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HANGXE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TongTien = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NGSUA = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.BIENSO = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SODT = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HOTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.IDHD = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label12 = new System.Windows.Forms.Label();
            this.label22 = new System.Windows.Forms.Label();
            this.txtTimTen = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label23 = new System.Windows.Forms.Label();
            this.label24 = new System.Windows.Forms.Label();
            this.txtTimSDT = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label25 = new System.Windows.Forms.Label();
            this.txtTimBienSo = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.QLHoaDonPanel = new System.Windows.Forms.Panel();
            this.btnTimKiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnXuat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.DataGridCTHD = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.DV = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONVI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Loai = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Gia = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtNgay1 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label5 = new System.Windows.Forms.Label();
            this.txtNgay2 = new Bunifu.Framework.UI.BunifuDatepicker();
            this.label3 = new System.Windows.Forms.Label();
            this.txtIDHD = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridHD)).BeginInit();
            this.QLHoaDonPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCTHD)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.QLHoaDonPanel);
            this.panel1.Location = new System.Drawing.Point(-2, -1);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1339, 853);
            this.panel1.TabIndex = 1;
            // 
            // DataGridHD
            // 
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridHD.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridHD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle4.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.IDHD,
            this.HOTEN,
            this.SODT,
            this.BIENSO,
            this.NGSUA,
            this.NGHD,
            this.TongTien,
            this.HANGXE,
            this.SOKM,
            this.SoKhung,
            this.DIACHI,
            this.NVTV,
            this.NVKT});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridHD.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridHD.DoubleBuffered = true;
            this.DataGridHD.EnableHeadersVisualStyles = false;
            this.DataGridHD.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.DataGridHD.HeaderForeColor = System.Drawing.Color.White;
            this.DataGridHD.Location = new System.Drawing.Point(5, 122);
            this.DataGridHD.Name = "DataGridHD";
            this.DataGridHD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridHD.RowHeadersWidth = 25;
            this.DataGridHD.Size = new System.Drawing.Size(700, 726);
            this.DataGridHD.TabIndex = 36;
            this.DataGridHD.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridHD_CellClick);
            // 
            // NVKT
            // 
            this.NVKT.DataPropertyName = "MANVKT";
            this.NVKT.HeaderText = "NVKT";
            this.NVKT.Name = "NVKT";
            // 
            // NVTV
            // 
            this.NVTV.DataPropertyName = "MANVTV";
            this.NVTV.HeaderText = "NVTV";
            this.NVTV.Name = "NVTV";
            // 
            // DIACHI
            // 
            this.DIACHI.DataPropertyName = "DIACHI";
            this.DIACHI.HeaderText = "Địa chỉ";
            this.DIACHI.Name = "DIACHI";
            this.DIACHI.Width = 250;
            // 
            // SoKhung
            // 
            this.SoKhung.DataPropertyName = "SOKHUNG";
            this.SoKhung.HeaderText = "Số khung";
            this.SoKhung.Name = "SoKhung";
            // 
            // SOKM
            // 
            this.SOKM.DataPropertyName = "SOKM";
            this.SOKM.HeaderText = "Số KM";
            this.SOKM.Name = "SOKM";
            // 
            // HANGXE
            // 
            this.HANGXE.DataPropertyName = "TENHANGXE";
            this.HANGXE.HeaderText = "Hãng xe";
            this.HANGXE.Name = "HANGXE";
            // 
            // TongTien
            // 
            this.TongTien.DataPropertyName = "TongGia";
            this.TongTien.HeaderText = "Tổng tiền";
            this.TongTien.Name = "TongTien";
            // 
            // NGHD
            // 
            this.NGHD.DataPropertyName = "NGHD";
            this.NGHD.HeaderText = "Ngày TT";
            this.NGHD.Name = "NGHD";
            // 
            // NGSUA
            // 
            this.NGSUA.DataPropertyName = "NGSUA";
            this.NGSUA.HeaderText = "Ngày sửa";
            this.NGSUA.Name = "NGSUA";
            // 
            // BIENSO
            // 
            this.BIENSO.DataPropertyName = "BIENSO";
            this.BIENSO.HeaderText = "Biển số";
            this.BIENSO.Name = "BIENSO";
            // 
            // SODT
            // 
            this.SODT.DataPropertyName = "SODT";
            this.SODT.HeaderText = "SĐT";
            this.SODT.Name = "SODT";
            // 
            // HOTEN
            // 
            this.HOTEN.DataPropertyName = "HOTEN";
            this.HOTEN.HeaderText = "Tên";
            this.HOTEN.Name = "HOTEN";
            this.HOTEN.Width = 130;
            // 
            // IDHD
            // 
            this.IDHD.DataPropertyName = "SOHD";
            this.IDHD.HeaderText = "IDHD";
            this.IDHD.Name = "IDHD";
            this.IDHD.Width = 50;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Teal;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(18, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(141, 16);
            this.label12.TabIndex = 37;
            this.label12.Text = "Danh sách hoá đơn";
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Teal;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(739, 154);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(33, 17);
            this.label22.TabIndex = 38;
            this.label22.Text = "Tên";
            // 
            // txtTimTen
            // 
            this.txtTimTen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTimTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTimTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimTen.HintForeColor = System.Drawing.Color.Empty;
            this.txtTimTen.HintText = "";
            this.txtTimTen.isPassword = false;
            this.txtTimTen.LineFocusedColor = System.Drawing.Color.Turquoise;
            this.txtTimTen.LineIdleColor = System.Drawing.Color.Teal;
            this.txtTimTen.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtTimTen.LineThickness = 3;
            this.txtTimTen.Location = new System.Drawing.Point(779, 150);
            this.txtTimTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimTen.Name = "txtTimTen";
            this.txtTimTen.Size = new System.Drawing.Size(144, 24);
            this.txtTimTen.TabIndex = 39;
            this.txtTimTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Teal;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(739, 120);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 17);
            this.label23.TabIndex = 40;
            this.label23.Text = "Tìm kiếm:";
            // 
            // label24
            // 
            this.label24.AutoSize = true;
            this.label24.BackColor = System.Drawing.Color.Teal;
            this.label24.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label24.ForeColor = System.Drawing.Color.White;
            this.label24.Location = new System.Drawing.Point(946, 152);
            this.label24.Name = "label24";
            this.label24.Size = new System.Drawing.Size(36, 17);
            this.label24.TabIndex = 41;
            this.label24.Text = "SĐT";
            // 
            // txtTimSDT
            // 
            this.txtTimSDT.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTimSDT.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimSDT.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTimSDT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimSDT.HintForeColor = System.Drawing.Color.Empty;
            this.txtTimSDT.HintText = "";
            this.txtTimSDT.isPassword = false;
            this.txtTimSDT.LineFocusedColor = System.Drawing.Color.Turquoise;
            this.txtTimSDT.LineIdleColor = System.Drawing.Color.Teal;
            this.txtTimSDT.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtTimSDT.LineThickness = 3;
            this.txtTimSDT.Location = new System.Drawing.Point(989, 150);
            this.txtTimSDT.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimSDT.Name = "txtTimSDT";
            this.txtTimSDT.Size = new System.Drawing.Size(127, 24);
            this.txtTimSDT.TabIndex = 42;
            this.txtTimSDT.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label25
            // 
            this.label25.AutoSize = true;
            this.label25.BackColor = System.Drawing.Color.Teal;
            this.label25.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label25.ForeColor = System.Drawing.Color.White;
            this.label25.Location = new System.Drawing.Point(1151, 152);
            this.label25.Name = "label25";
            this.label25.Size = new System.Drawing.Size(55, 17);
            this.label25.TabIndex = 43;
            this.label25.Text = "Biển số";
            // 
            // txtTimBienSo
            // 
            this.txtTimBienSo.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTimBienSo.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimBienSo.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTimBienSo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimBienSo.HintForeColor = System.Drawing.Color.Empty;
            this.txtTimBienSo.HintText = "";
            this.txtTimBienSo.isPassword = false;
            this.txtTimBienSo.LineFocusedColor = System.Drawing.Color.Turquoise;
            this.txtTimBienSo.LineIdleColor = System.Drawing.Color.Teal;
            this.txtTimBienSo.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtTimBienSo.LineThickness = 3;
            this.txtTimBienSo.Location = new System.Drawing.Point(1226, 150);
            this.txtTimBienSo.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimBienSo.Name = "txtTimBienSo";
            this.txtTimBienSo.Size = new System.Drawing.Size(96, 24);
            this.txtTimBienSo.TabIndex = 44;
            this.txtTimBienSo.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // QLHoaDonPanel
            // 
            this.QLHoaDonPanel.Controls.Add(this.txtIDHD);
            this.QLHoaDonPanel.Controls.Add(this.txtNgay2);
            this.QLHoaDonPanel.Controls.Add(this.label3);
            this.QLHoaDonPanel.Controls.Add(this.txtNgay1);
            this.QLHoaDonPanel.Controls.Add(this.label5);
            this.QLHoaDonPanel.Controls.Add(this.label2);
            this.QLHoaDonPanel.Controls.Add(this.label1);
            this.QLHoaDonPanel.Controls.Add(this.DataGridCTHD);
            this.QLHoaDonPanel.Controls.Add(this.btnXuat);
            this.QLHoaDonPanel.Controls.Add(this.btnTimKiem);
            this.QLHoaDonPanel.Controls.Add(this.txtTimBienSo);
            this.QLHoaDonPanel.Controls.Add(this.label25);
            this.QLHoaDonPanel.Controls.Add(this.txtTimSDT);
            this.QLHoaDonPanel.Controls.Add(this.label24);
            this.QLHoaDonPanel.Controls.Add(this.label23);
            this.QLHoaDonPanel.Controls.Add(this.txtTimTen);
            this.QLHoaDonPanel.Controls.Add(this.label22);
            this.QLHoaDonPanel.Controls.Add(this.label12);
            this.QLHoaDonPanel.Controls.Add(this.DataGridHD);
            this.QLHoaDonPanel.Location = new System.Drawing.Point(0, 3);
            this.QLHoaDonPanel.Name = "QLHoaDonPanel";
            this.QLHoaDonPanel.Size = new System.Drawing.Size(1339, 850);
            this.QLHoaDonPanel.TabIndex = 12;
            // 
            // btnTimKiem
            // 
            this.btnTimKiem.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.btnTimKiem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnTimKiem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnTimKiem.BorderRadius = 0;
            this.btnTimKiem.ButtonText = "Tìm kiếm";
            this.btnTimKiem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTimKiem.DisabledColor = System.Drawing.Color.Gray;
            this.btnTimKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTimKiem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnTimKiem.Iconimage = null;
            this.btnTimKiem.Iconimage_right = null;
            this.btnTimKiem.Iconimage_right_Selected = null;
            this.btnTimKiem.Iconimage_Selected = null;
            this.btnTimKiem.IconMarginLeft = 0;
            this.btnTimKiem.IconMarginRight = 0;
            this.btnTimKiem.IconRightVisible = true;
            this.btnTimKiem.IconRightZoom = 0D;
            this.btnTimKiem.IconVisible = true;
            this.btnTimKiem.IconZoom = 90D;
            this.btnTimKiem.IsTab = false;
            this.btnTimKiem.Location = new System.Drawing.Point(910, 231);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnTimKiem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTimKiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimKiem.selected = false;
            this.btnTimKiem.Size = new System.Drawing.Size(84, 33);
            this.btnTimKiem.TabIndex = 45;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimKiem.Textcolor = System.Drawing.Color.White;
            this.btnTimKiem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // btnXuat
            // 
            this.btnXuat.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.btnXuat.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXuat.BorderRadius = 0;
            this.btnXuat.ButtonText = "IN";
            this.btnXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXuat.DisabledColor = System.Drawing.Color.Gray;
            this.btnXuat.Enabled = false;
            this.btnXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXuat.Iconcolor = System.Drawing.Color.Transparent;
            this.btnXuat.Iconimage = null;
            this.btnXuat.Iconimage_right = null;
            this.btnXuat.Iconimage_right_Selected = null;
            this.btnXuat.Iconimage_Selected = null;
            this.btnXuat.IconMarginLeft = 0;
            this.btnXuat.IconMarginRight = 0;
            this.btnXuat.IconRightVisible = true;
            this.btnXuat.IconRightZoom = 0D;
            this.btnXuat.IconVisible = true;
            this.btnXuat.IconZoom = 90D;
            this.btnXuat.IsTab = false;
            this.btnXuat.Location = new System.Drawing.Point(1039, 231);
            this.btnXuat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXuat.Name = "btnXuat";
            this.btnXuat.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnXuat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXuat.OnHoverTextColor = System.Drawing.Color.White;
            this.btnXuat.selected = false;
            this.btnXuat.Size = new System.Drawing.Size(88, 33);
            this.btnXuat.TabIndex = 46;
            this.btnXuat.Text = "IN";
            this.btnXuat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXuat.Textcolor = System.Drawing.Color.White;
            this.btnXuat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXuat.Click += new System.EventHandler(this.btnXuat_Click);
            // 
            // DataGridCTHD
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridCTHD.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridCTHD.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridCTHD.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridCTHD.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridCTHD.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridCTHD.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.DV,
            this.SL,
            this.DONVI,
            this.Loai,
            this.Gia});
            this.DataGridCTHD.DoubleBuffered = true;
            this.DataGridCTHD.EnableHeadersVisualStyles = false;
            this.DataGridCTHD.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.DataGridCTHD.HeaderForeColor = System.Drawing.Color.White;
            this.DataGridCTHD.Location = new System.Drawing.Point(721, 324);
            this.DataGridCTHD.Name = "DataGridCTHD";
            this.DataGridCTHD.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridCTHD.RowHeadersWidth = 25;
            this.DataGridCTHD.Size = new System.Drawing.Size(616, 524);
            this.DataGridCTHD.TabIndex = 47;
            // 
            // DV
            // 
            this.DV.DataPropertyName = "TENSP";
            this.DV.HeaderText = "Dịch vụ ";
            this.DV.Name = "DV";
            this.DV.Width = 200;
            // 
            // SL
            // 
            this.SL.DataPropertyName = "SL";
            this.SL.HeaderText = "Số lượng";
            this.SL.Name = "SL";
            // 
            // DONVI
            // 
            this.DONVI.DataPropertyName = "DONVI";
            this.DONVI.HeaderText = "Đơn vị";
            this.DONVI.Name = "DONVI";
            this.DONVI.Width = 75;
            // 
            // Loai
            // 
            this.Loai.DataPropertyName = "LOAI";
            this.Loai.HeaderText = "Loại";
            this.Loai.Name = "Loai";
            this.Loai.Width = 75;
            // 
            // Gia
            // 
            this.Gia.DataPropertyName = "GIACTHD";
            this.Gia.HeaderText = "Giá";
            this.Gia.Name = "Gia";
            this.Gia.Width = 144;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(739, 294);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(115, 16);
            this.label1.TabIndex = 48;
            this.label1.Text = "Chi tiết hoá đơn";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(555, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(291, 36);
            this.label2.TabIndex = 49;
            this.label2.Text = "Danh sách hoá đơn";
            // 
            // txtNgay1
            // 
            this.txtNgay1.BackColor = System.Drawing.Color.Teal;
            this.txtNgay1.BorderRadius = 0;
            this.txtNgay1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNgay1.ForeColor = System.Drawing.Color.White;
            this.txtNgay1.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgay1.FormatCustom = "dd/MM/yyyy ";
            this.txtNgay1.Location = new System.Drawing.Point(853, 190);
            this.txtNgay1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNgay1.Name = "txtNgay1";
            this.txtNgay1.Size = new System.Drawing.Size(161, 26);
            this.txtNgay1.TabIndex = 51;
            this.txtNgay1.Value = new System.DateTime(2019, 5, 9, 0, 0, 0, 0);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(786, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 17);
            this.label5.TabIndex = 50;
            this.label5.Text = "Từ ngày";
            // 
            // txtNgay2
            // 
            this.txtNgay2.BackColor = System.Drawing.Color.Teal;
            this.txtNgay2.BorderRadius = 0;
            this.txtNgay2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtNgay2.ForeColor = System.Drawing.Color.White;
            this.txtNgay2.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtNgay2.FormatCustom = "dd/MM/yyyy ";
            this.txtNgay2.Location = new System.Drawing.Point(1112, 190);
            this.txtNgay2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.txtNgay2.Name = "txtNgay2";
            this.txtNgay2.Size = new System.Drawing.Size(161, 26);
            this.txtNgay2.TabIndex = 53;
            this.txtNgay2.Value = new System.DateTime(2019, 5, 9, 0, 0, 0, 0);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(1036, 195);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 17);
            this.label3.TabIndex = 52;
            this.label3.Text = "Đến ngày";
            // 
            // txtIDHD
            // 
            this.txtIDHD.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtIDHD.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtIDHD.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtIDHD.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtIDHD.HintForeColor = System.Drawing.Color.Empty;
            this.txtIDHD.HintText = "";
            this.txtIDHD.isPassword = false;
            this.txtIDHD.LineFocusedColor = System.Drawing.Color.Turquoise;
            this.txtIDHD.LineIdleColor = System.Drawing.Color.Teal;
            this.txtIDHD.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtIDHD.LineThickness = 3;
            this.txtIDHD.Location = new System.Drawing.Point(166, 91);
            this.txtIDHD.Margin = new System.Windows.Forms.Padding(4);
            this.txtIDHD.Name = "txtIDHD";
            this.txtIDHD.Size = new System.Drawing.Size(144, 24);
            this.txtIDHD.TabIndex = 54;
            this.txtIDHD.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.txtIDHD.Visible = false;
            // 
            // QLHoaDon_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.panel1);
            this.Name = "QLHoaDon_GUI";
            this.Size = new System.Drawing.Size(1335, 851);
            this.Load += new System.EventHandler(this.QLHoaDon_GUI_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridHD)).EndInit();
            this.QLHoaDonPanel.ResumeLayout(false);
            this.QLHoaDonPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridCTHD)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel QLHoaDonPanel;
        private Bunifu.Framework.UI.BunifuFlatButton btnXuat;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimKiem;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTimBienSo;
        private System.Windows.Forms.Label label25;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTimSDT;
        private System.Windows.Forms.Label label24;
        private System.Windows.Forms.Label label23;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTimTen;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn IDHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn HOTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SODT;
        private System.Windows.Forms.DataGridViewTextBoxColumn BIENSO;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGSUA;
        private System.Windows.Forms.DataGridViewTextBoxColumn NGHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn TongTien;
        private System.Windows.Forms.DataGridViewTextBoxColumn HANGXE;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOKM;
        private System.Windows.Forms.DataGridViewTextBoxColumn SoKhung;
        private System.Windows.Forms.DataGridViewTextBoxColumn DIACHI;
        private System.Windows.Forms.DataGridViewTextBoxColumn NVTV;
        private System.Windows.Forms.DataGridViewTextBoxColumn NVKT;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridCTHD;
        private System.Windows.Forms.DataGridViewTextBoxColumn DV;
        private System.Windows.Forms.DataGridViewTextBoxColumn SL;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONVI;
        private System.Windows.Forms.DataGridViewTextBoxColumn Loai;
        private System.Windows.Forms.DataGridViewTextBoxColumn Gia;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuDatepicker txtNgay1;
        private System.Windows.Forms.Label label5;
        private Bunifu.Framework.UI.BunifuDatepicker txtNgay2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtIDHD;
    }
}
