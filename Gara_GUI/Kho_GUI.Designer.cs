namespace Gara_GUI
{
    partial class Kho_GUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridSanPham = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SPTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SOLUONG = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DONVI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIANHAP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIABAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTen = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtGiaNhap = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtGiaBan = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.btnSua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnXoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtDonVi = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.bunifuFlatButton1 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label4 = new System.Windows.Forms.Label();
            this.txtSL = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label7 = new System.Windows.Forms.Label();
            this.bunifuFlatButton2 = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnReset = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label23 = new System.Windows.Forms.Label();
            this.txtTimTen = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label22 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnTimKiem = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSanPham)).BeginInit();
            this.SuspendLayout();
            // 
            // DataGridSanPham
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.DataGridSanPham.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridSanPham.BackgroundColor = System.Drawing.Color.Gainsboro;
            this.DataGridSanPham.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.DataGridSanPham.ColumnHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.SeaGreen;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.Padding = new System.Windows.Forms.Padding(5, 0, 0, 0);
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridSanPham.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridSanPham.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.DataGridSanPham.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.MASP,
            this.SPTEN,
            this.SOLUONG,
            this.DONVI,
            this.GIANHAP,
            this.GIABAN,
            this.LOAI});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Padding = new System.Windows.Forms.Padding(3, 0, 0, 0);
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridSanPham.DefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridSanPham.DoubleBuffered = true;
            this.DataGridSanPham.EnableHeadersVisualStyles = false;
            this.DataGridSanPham.HeaderBgColor = System.Drawing.Color.SeaGreen;
            this.DataGridSanPham.HeaderForeColor = System.Drawing.Color.White;
            this.DataGridSanPham.Location = new System.Drawing.Point(432, 103);
            this.DataGridSanPham.Name = "DataGridSanPham";
            this.DataGridSanPham.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridSanPham.RowHeadersWidth = 25;
            this.DataGridSanPham.Size = new System.Drawing.Size(903, 748);
            this.DataGridSanPham.TabIndex = 59;
            this.DataGridSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridSanPham_CellClick);
            // 
            // MASP
            // 
            this.MASP.DataPropertyName = "MASP";
            this.MASP.HeaderText = "ID";
            this.MASP.Name = "MASP";
            this.MASP.Width = 70;
            // 
            // SPTEN
            // 
            this.SPTEN.DataPropertyName = "TENSP";
            this.SPTEN.HeaderText = "Tên danh mục";
            this.SPTEN.Name = "SPTEN";
            this.SPTEN.Width = 235;
            // 
            // SOLUONG
            // 
            this.SOLUONG.DataPropertyName = "SOLUONG";
            this.SOLUONG.HeaderText = "Số lượng";
            this.SOLUONG.Name = "SOLUONG";
            this.SOLUONG.Width = 114;
            // 
            // DONVI
            // 
            this.DONVI.DataPropertyName = "DONVI";
            this.DONVI.HeaderText = "Đơn vị";
            this.DONVI.Name = "DONVI";
            // 
            // GIANHAP
            // 
            this.GIANHAP.DataPropertyName = "GIANHAP";
            this.GIANHAP.HeaderText = "Giá nhập";
            this.GIANHAP.Name = "GIANHAP";
            this.GIANHAP.Width = 130;
            // 
            // GIABAN
            // 
            this.GIABAN.DataPropertyName = "GIABAN";
            this.GIABAN.HeaderText = "Giá bán";
            this.GIABAN.Name = "GIABAN";
            this.GIABAN.Width = 130;
            // 
            // LOAI
            // 
            this.LOAI.DataPropertyName = "LOAI";
            this.LOAI.HeaderText = "Mục";
            this.LOAI.Name = "LOAI";
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtID.HintForeColor = System.Drawing.Color.Empty;
            this.txtID.HintText = "";
            this.txtID.isPassword = false;
            this.txtID.LineFocusedColor = System.Drawing.Color.Turquoise;
            this.txtID.LineIdleColor = System.Drawing.Color.Teal;
            this.txtID.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtID.LineThickness = 4;
            this.txtID.Location = new System.Drawing.Point(160, 156);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(246, 28);
            this.txtID.TabIndex = 62;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtTen
            // 
            this.txtTen.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTen.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTen.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTen.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTen.HintForeColor = System.Drawing.Color.Empty;
            this.txtTen.HintText = "";
            this.txtTen.isPassword = false;
            this.txtTen.LineFocusedColor = System.Drawing.Color.Turquoise;
            this.txtTen.LineIdleColor = System.Drawing.Color.Teal;
            this.txtTen.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtTen.LineThickness = 4;
            this.txtTen.Location = new System.Drawing.Point(160, 219);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(246, 28);
            this.txtTen.TabIndex = 64;
            this.txtTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtGiaNhap
            // 
            this.txtGiaNhap.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGiaNhap.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGiaNhap.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGiaNhap.HintForeColor = System.Drawing.Color.Empty;
            this.txtGiaNhap.HintText = "";
            this.txtGiaNhap.isPassword = false;
            this.txtGiaNhap.LineFocusedColor = System.Drawing.Color.Turquoise;
            this.txtGiaNhap.LineIdleColor = System.Drawing.Color.Teal;
            this.txtGiaNhap.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtGiaNhap.LineThickness = 4;
            this.txtGiaNhap.Location = new System.Drawing.Point(160, 413);
            this.txtGiaNhap.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaNhap.Name = "txtGiaNhap";
            this.txtGiaNhap.Size = new System.Drawing.Size(246, 28);
            this.txtGiaNhap.TabIndex = 68;
            this.txtGiaNhap.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtGiaBan
            // 
            this.txtGiaBan.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtGiaBan.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtGiaBan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtGiaBan.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtGiaBan.HintForeColor = System.Drawing.Color.Empty;
            this.txtGiaBan.HintText = "";
            this.txtGiaBan.isPassword = false;
            this.txtGiaBan.LineFocusedColor = System.Drawing.Color.Turquoise;
            this.txtGiaBan.LineIdleColor = System.Drawing.Color.Teal;
            this.txtGiaBan.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtGiaBan.LineThickness = 4;
            this.txtGiaBan.Location = new System.Drawing.Point(160, 479);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(246, 28);
            this.txtGiaBan.TabIndex = 70;
            this.txtGiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // btnSua
            // 
            this.btnSua.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.btnSua.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnSua.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnSua.BorderRadius = 0;
            this.btnSua.ButtonText = "Sửa";
            this.btnSua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnSua.DisabledColor = System.Drawing.Color.Gray;
            this.btnSua.Enabled = false;
            this.btnSua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSua.Iconcolor = System.Drawing.Color.Transparent;
            this.btnSua.Iconimage = null;
            this.btnSua.Iconimage_right = null;
            this.btnSua.Iconimage_right_Selected = null;
            this.btnSua.Iconimage_Selected = null;
            this.btnSua.IconMarginLeft = 0;
            this.btnSua.IconMarginRight = 0;
            this.btnSua.IconRightVisible = true;
            this.btnSua.IconRightZoom = 0D;
            this.btnSua.IconVisible = true;
            this.btnSua.IconZoom = 90D;
            this.btnSua.IsTab = false;
            this.btnSua.Location = new System.Drawing.Point(295, 573);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnSua.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSua.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSua.selected = false;
            this.btnSua.Size = new System.Drawing.Size(111, 79);
            this.btnSua.TabIndex = 75;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSua.Textcolor = System.Drawing.Color.White;
            this.btnSua.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.btnXoa.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.BorderRadius = 0;
            this.btnXoa.ButtonText = "Xoá ";
            this.btnXoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXoa.DisabledColor = System.Drawing.Color.Gray;
            this.btnXoa.Enabled = false;
            this.btnXoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXoa.Iconcolor = System.Drawing.Color.Transparent;
            this.btnXoa.Iconimage = null;
            this.btnXoa.Iconimage_right = null;
            this.btnXoa.Iconimage_right_Selected = null;
            this.btnXoa.Iconimage_Selected = null;
            this.btnXoa.IconMarginLeft = 0;
            this.btnXoa.IconMarginRight = 0;
            this.btnXoa.IconRightVisible = true;
            this.btnXoa.IconRightZoom = 0D;
            this.btnXoa.IconVisible = true;
            this.btnXoa.IconZoom = 90D;
            this.btnXoa.IsTab = false;
            this.btnXoa.Location = new System.Drawing.Point(159, 573);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnXoa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoa.OnHoverTextColor = System.Drawing.Color.White;
            this.btnXoa.selected = false;
            this.btnXoa.Size = new System.Drawing.Size(111, 79);
            this.btnXoa.TabIndex = 74;
            this.btnXoa.Text = "Xoá ";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoa.Textcolor = System.Drawing.Color.White;
            this.btnXoa.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
            // 
            // btnThem
            // 
            this.btnThem.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.btnThem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.BorderRadius = 0;
            this.btnThem.ButtonText = "Nhập hàng";
            this.btnThem.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnThem.DisabledColor = System.Drawing.Color.Gray;
            this.btnThem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThem.Iconcolor = System.Drawing.Color.Transparent;
            this.btnThem.Iconimage = null;
            this.btnThem.Iconimage_right = null;
            this.btnThem.Iconimage_right_Selected = null;
            this.btnThem.Iconimage_Selected = null;
            this.btnThem.IconMarginLeft = 0;
            this.btnThem.IconMarginRight = 0;
            this.btnThem.IconRightVisible = true;
            this.btnThem.IconRightZoom = 0D;
            this.btnThem.IconVisible = true;
            this.btnThem.IconZoom = 90D;
            this.btnThem.IsTab = false;
            this.btnThem.Location = new System.Drawing.Point(72, 679);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnThem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThem.selected = false;
            this.btnThem.Size = new System.Drawing.Size(111, 79);
            this.btnThem.TabIndex = 73;
            this.btnThem.Text = "Nhập hàng";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem.Textcolor = System.Drawing.Color.White;
            this.btnThem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // txtDonVi
            // 
            this.txtDonVi.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtDonVi.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtDonVi.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtDonVi.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtDonVi.HintForeColor = System.Drawing.Color.Empty;
            this.txtDonVi.HintText = "";
            this.txtDonVi.isPassword = false;
            this.txtDonVi.LineFocusedColor = System.Drawing.Color.Turquoise;
            this.txtDonVi.LineIdleColor = System.Drawing.Color.Teal;
            this.txtDonVi.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtDonVi.LineThickness = 4;
            this.txtDonVi.Location = new System.Drawing.Point(159, 347);
            this.txtDonVi.Margin = new System.Windows.Forms.Padding(4);
            this.txtDonVi.Name = "txtDonVi";
            this.txtDonVi.Size = new System.Drawing.Size(247, 28);
            this.txtDonVi.TabIndex = 77;
            this.txtDonVi.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(25, 481);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 78;
            this.label1.Text = "Giá bán";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(25, 413);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(74, 20);
            this.label2.TabIndex = 79;
            this.label2.Text = "Giá nhập";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(25, 219);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(110, 20);
            this.label3.TabIndex = 82;
            this.label3.Text = "Tên sản phẩm";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Teal;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(25, 351);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(53, 20);
            this.label5.TabIndex = 80;
            this.label5.Text = "Đơn vị";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Teal;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(25, 158);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 83;
            this.label6.Text = "ID";
            // 
            // bunifuFlatButton1
            // 
            this.bunifuFlatButton1.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuFlatButton1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuFlatButton1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton1.BorderRadius = 0;
            this.bunifuFlatButton1.ButtonText = "In";
            this.bunifuFlatButton1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton1.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bunifuFlatButton1.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton1.Iconimage = null;
            this.bunifuFlatButton1.Iconimage_right = null;
            this.bunifuFlatButton1.Iconimage_right_Selected = null;
            this.bunifuFlatButton1.Iconimage_Selected = null;
            this.bunifuFlatButton1.IconMarginLeft = 0;
            this.bunifuFlatButton1.IconMarginRight = 0;
            this.bunifuFlatButton1.IconRightVisible = true;
            this.bunifuFlatButton1.IconRightZoom = 0D;
            this.bunifuFlatButton1.IconVisible = true;
            this.bunifuFlatButton1.IconZoom = 90D;
            this.bunifuFlatButton1.IsTab = false;
            this.bunifuFlatButton1.Location = new System.Drawing.Point(232, 679);
            this.bunifuFlatButton1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton1.Name = "bunifuFlatButton1";
            this.bunifuFlatButton1.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuFlatButton1.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton1.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton1.selected = false;
            this.bunifuFlatButton1.Size = new System.Drawing.Size(111, 79);
            this.bunifuFlatButton1.TabIndex = 84;
            this.bunifuFlatButton1.Text = "In";
            this.bunifuFlatButton1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton1.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton1.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bunifuFlatButton1.Click += new System.EventHandler(this.bunifuFlatButton1_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(25, 283);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 20);
            this.label4.TabIndex = 81;
            this.label4.Text = "Số lương";
            // 
            // txtSL
            // 
            this.txtSL.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtSL.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSL.Enabled = false;
            this.txtSL.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtSL.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtSL.HintForeColor = System.Drawing.Color.Empty;
            this.txtSL.HintText = "";
            this.txtSL.isPassword = false;
            this.txtSL.LineFocusedColor = System.Drawing.Color.Turquoise;
            this.txtSL.LineIdleColor = System.Drawing.Color.Teal;
            this.txtSL.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtSL.LineThickness = 4;
            this.txtSL.Location = new System.Drawing.Point(160, 283);
            this.txtSL.Margin = new System.Windows.Forms.Padding(4);
            this.txtSL.Name = "txtSL";
            this.txtSL.Size = new System.Drawing.Size(246, 28);
            this.txtSL.TabIndex = 66;
            this.txtSL.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Teal;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(95, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(259, 36);
            this.label7.TabIndex = 85;
            this.label7.Text = "Quản lý phụ tùng";
            // 
            // bunifuFlatButton2
            // 
            this.bunifuFlatButton2.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuFlatButton2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.bunifuFlatButton2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.bunifuFlatButton2.BorderRadius = 0;
            this.bunifuFlatButton2.ButtonText = "Thêm";
            this.bunifuFlatButton2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuFlatButton2.DisabledColor = System.Drawing.Color.Gray;
            this.bunifuFlatButton2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bunifuFlatButton2.Iconcolor = System.Drawing.Color.Transparent;
            this.bunifuFlatButton2.Iconimage = null;
            this.bunifuFlatButton2.Iconimage_right = null;
            this.bunifuFlatButton2.Iconimage_right_Selected = null;
            this.bunifuFlatButton2.Iconimage_Selected = null;
            this.bunifuFlatButton2.IconMarginLeft = 0;
            this.bunifuFlatButton2.IconMarginRight = 0;
            this.bunifuFlatButton2.IconRightVisible = true;
            this.bunifuFlatButton2.IconRightZoom = 0D;
            this.bunifuFlatButton2.IconVisible = true;
            this.bunifuFlatButton2.IconZoom = 90D;
            this.bunifuFlatButton2.IsTab = false;
            this.bunifuFlatButton2.Location = new System.Drawing.Point(24, 573);
            this.bunifuFlatButton2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.bunifuFlatButton2.Name = "bunifuFlatButton2";
            this.bunifuFlatButton2.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.bunifuFlatButton2.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.bunifuFlatButton2.OnHoverTextColor = System.Drawing.Color.White;
            this.bunifuFlatButton2.selected = false;
            this.bunifuFlatButton2.Size = new System.Drawing.Size(111, 79);
            this.bunifuFlatButton2.TabIndex = 86;
            this.bunifuFlatButton2.Text = "Thêm";
            this.bunifuFlatButton2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuFlatButton2.Textcolor = System.Drawing.Color.White;
            this.bunifuFlatButton2.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.bunifuFlatButton2.Click += new System.EventHandler(this.bunifuFlatButton2_Click);
            // 
            // btnReset
            // 
            this.btnReset.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.btnReset.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnReset.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReset.BorderRadius = 0;
            this.btnReset.ButtonText = "Reload";
            this.btnReset.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReset.DisabledColor = System.Drawing.Color.Gray;
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReset.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReset.Iconimage = null;
            this.btnReset.Iconimage_right = null;
            this.btnReset.Iconimage_right_Selected = null;
            this.btnReset.Iconimage_Selected = null;
            this.btnReset.IconMarginLeft = 0;
            this.btnReset.IconMarginRight = 0;
            this.btnReset.IconRightVisible = true;
            this.btnReset.IconRightZoom = 0D;
            this.btnReset.IconVisible = true;
            this.btnReset.IconZoom = 90D;
            this.btnReset.IsTab = false;
            this.btnReset.Location = new System.Drawing.Point(1149, 60);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnReset.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReset.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReset.selected = false;
            this.btnReset.Size = new System.Drawing.Size(101, 26);
            this.btnReset.TabIndex = 87;
            this.btnReset.Text = "Reload";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.Textcolor = System.Drawing.Color.White;
            this.btnReset.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Teal;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(508, 41);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 17);
            this.label23.TabIndex = 91;
            this.label23.Text = "Tìm kiếm:";
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
            this.txtTimTen.Location = new System.Drawing.Point(682, 63);
            this.txtTimTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimTen.Name = "txtTimTen";
            this.txtTimTen.Size = new System.Drawing.Size(278, 21);
            this.txtTimTen.TabIndex = 90;
            this.txtTimTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Teal;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(564, 64);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(99, 17);
            this.label22.TabIndex = 89;
            this.label22.Text = "Tên sản phẩm";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Teal;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(444, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 17);
            this.label12.TabIndex = 88;
            this.label12.Text = "Danh sách các danh mục";
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
            this.btnTimKiem.Location = new System.Drawing.Point(1001, 60);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnTimKiem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTimKiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimKiem.selected = false;
            this.btnTimKiem.Size = new System.Drawing.Size(101, 26);
            this.btnTimKiem.TabIndex = 92;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimKiem.Textcolor = System.Drawing.Color.White;
            this.btnTimKiem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // Kho_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtTimTen);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.bunifuFlatButton2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.bunifuFlatButton1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtDonVi);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtGiaNhap);
            this.Controls.Add(this.txtSL);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.DataGridSanPham);
            this.Name = "Kho_GUI";
            this.Size = new System.Drawing.Size(1335, 851);
            this.Load += new System.EventHandler(this.Kho_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridSanPham;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtID;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTen;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtGiaNhap;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtGiaBan;
        private Bunifu.Framework.UI.BunifuFlatButton btnSua;
        private Bunifu.Framework.UI.BunifuFlatButton btnXoa;
        private Bunifu.Framework.UI.BunifuFlatButton btnThem;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtDonVi;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton1;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtSL;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SPTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn SOLUONG;
        private System.Windows.Forms.DataGridViewTextBoxColumn DONVI;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIANHAP;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIABAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAI;
        private Bunifu.Framework.UI.BunifuFlatButton bunifuFlatButton2;
        private Bunifu.Framework.UI.BunifuFlatButton btnReset;
        private System.Windows.Forms.Label label23;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTimTen;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimKiem;
    }
}
