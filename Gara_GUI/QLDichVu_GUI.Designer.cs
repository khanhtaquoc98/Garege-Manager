namespace Gara_GUI
{
    partial class QLDichVu_GUI
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
            this.btnTimKiem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label23 = new System.Windows.Forms.Label();
            this.txtTimTen = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label22 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.btnReset = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnThem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label7 = new System.Windows.Forms.Label();
            this.BtnXuat = new Bunifu.Framework.UI.BunifuFlatButton();
            this.label6 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnSua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnXoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtGiaBan = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtTen = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.txtID = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.DataGridSanPham = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.MASP = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SPTEN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.GIABAN = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.LOAI = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtLoai = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtTimLoai = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnXe = new Bunifu.Framework.UI.BunifuFlatButton();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSanPham)).BeginInit();
            this.SuspendLayout();
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
            this.btnTimKiem.Location = new System.Drawing.Point(1078, 55);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnTimKiem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTimKiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimKiem.selected = false;
            this.btnTimKiem.Size = new System.Drawing.Size(101, 26);
            this.btnTimKiem.TabIndex = 117;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimKiem.Textcolor = System.Drawing.Color.White;
            this.btnTimKiem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.BackColor = System.Drawing.Color.Teal;
            this.label23.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label23.ForeColor = System.Drawing.Color.White;
            this.label23.Location = new System.Drawing.Point(448, 34);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(68, 17);
            this.label23.TabIndex = 116;
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
            this.txtTimTen.Location = new System.Drawing.Point(537, 52);
            this.txtTimTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimTen.Name = "txtTimTen";
            this.txtTimTen.Size = new System.Drawing.Size(205, 29);
            this.txtTimTen.TabIndex = 115;
            this.txtTimTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Teal;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(448, 55);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(82, 17);
            this.label22.TabIndex = 114;
            this.label22.Text = "Tên dịch vụ";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Teal;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(795, 13);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(190, 17);
            this.label12.TabIndex = 113;
            this.label12.Text = "Danh sách các danh mục";
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
            this.btnReset.Location = new System.Drawing.Point(1202, 55);
            this.btnReset.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReset.Name = "btnReset";
            this.btnReset.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnReset.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReset.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReset.selected = false;
            this.btnReset.Size = new System.Drawing.Size(101, 26);
            this.btnReset.TabIndex = 112;
            this.btnReset.Text = "Reload";
            this.btnReset.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReset.Textcolor = System.Drawing.Color.White;
            this.btnReset.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnThem
            // 
            this.btnThem.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.btnThem.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnThem.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnThem.BorderRadius = 0;
            this.btnThem.ButtonText = "Thêm";
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
            this.btnThem.Location = new System.Drawing.Point(40, 506);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnThem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThem.selected = false;
            this.btnThem.Size = new System.Drawing.Size(111, 79);
            this.btnThem.TabIndex = 111;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem.Textcolor = System.Drawing.Color.White;
            this.btnThem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Teal;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(32, 69);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(374, 36);
            this.label7.TabIndex = 110;
            this.label7.Text = "Quản lý dịch vụ sửa chữa";
            // 
            // BtnXuat
            // 
            this.BtnXuat.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.BtnXuat.BackColor = System.Drawing.Color.DarkSlateGray;
            this.BtnXuat.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.BtnXuat.BorderRadius = 0;
            this.BtnXuat.ButtonText = "In bảng dịch vụ sửa xe";
            this.BtnXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnXuat.DisabledColor = System.Drawing.Color.Gray;
            this.BtnXuat.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnXuat.Iconcolor = System.Drawing.Color.Transparent;
            this.BtnXuat.Iconimage = null;
            this.BtnXuat.Iconimage_right = null;
            this.BtnXuat.Iconimage_right_Selected = null;
            this.BtnXuat.Iconimage_Selected = null;
            this.BtnXuat.IconMarginLeft = 0;
            this.BtnXuat.IconMarginRight = 0;
            this.BtnXuat.IconRightVisible = true;
            this.BtnXuat.IconRightZoom = 0D;
            this.BtnXuat.IconVisible = true;
            this.BtnXuat.IconZoom = 90D;
            this.BtnXuat.IsTab = false;
            this.BtnXuat.Location = new System.Drawing.Point(40, 614);
            this.BtnXuat.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.BtnXuat.Name = "BtnXuat";
            this.BtnXuat.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.BtnXuat.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.BtnXuat.OnHoverTextColor = System.Drawing.Color.White;
            this.BtnXuat.selected = false;
            this.BtnXuat.Size = new System.Drawing.Size(349, 79);
            this.BtnXuat.TabIndex = 109;
            this.BtnXuat.Text = "In bảng dịch vụ sửa xe";
            this.BtnXuat.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.BtnXuat.Textcolor = System.Drawing.Color.White;
            this.BtnXuat.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.BtnXuat.Click += new System.EventHandler(this.BtnXuat_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Teal;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(22, 198);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(26, 20);
            this.label6.TabIndex = 108;
            this.label6.Text = "ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(22, 259);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(89, 20);
            this.label3.TabIndex = 107;
            this.label3.Text = "Tên dịch vụ";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(22, 317);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 103;
            this.label1.Text = "Giá bán";
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
            this.btnSua.Location = new System.Drawing.Point(278, 506);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnSua.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSua.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSua.selected = false;
            this.btnSua.Size = new System.Drawing.Size(111, 79);
            this.btnSua.TabIndex = 101;
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
            this.btnXoa.Location = new System.Drawing.Point(159, 506);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnXoa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoa.OnHoverTextColor = System.Drawing.Color.White;
            this.btnXoa.selected = false;
            this.btnXoa.Size = new System.Drawing.Size(111, 79);
            this.btnXoa.TabIndex = 100;
            this.btnXoa.Text = "Xoá ";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoa.Textcolor = System.Drawing.Color.White;
            this.btnXoa.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.txtGiaBan.Location = new System.Drawing.Point(157, 317);
            this.txtGiaBan.Margin = new System.Windows.Forms.Padding(4);
            this.txtGiaBan.Name = "txtGiaBan";
            this.txtGiaBan.Size = new System.Drawing.Size(246, 28);
            this.txtGiaBan.TabIndex = 98;
            this.txtGiaBan.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.txtTen.Location = new System.Drawing.Point(157, 259);
            this.txtTen.Margin = new System.Windows.Forms.Padding(4);
            this.txtTen.Name = "txtTen";
            this.txtTen.Size = new System.Drawing.Size(246, 28);
            this.txtTen.TabIndex = 95;
            this.txtTen.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // txtID
            // 
            this.txtID.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtID.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtID.Enabled = false;
            this.txtID.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtID.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtID.HintForeColor = System.Drawing.Color.Empty;
            this.txtID.HintText = "";
            this.txtID.isPassword = false;
            this.txtID.LineFocusedColor = System.Drawing.Color.Turquoise;
            this.txtID.LineIdleColor = System.Drawing.Color.Teal;
            this.txtID.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtID.LineThickness = 4;
            this.txtID.Location = new System.Drawing.Point(157, 196);
            this.txtID.Margin = new System.Windows.Forms.Padding(4);
            this.txtID.Name = "txtID";
            this.txtID.Size = new System.Drawing.Size(246, 28);
            this.txtID.TabIndex = 94;
            this.txtID.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
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
            this.DataGridSanPham.Location = new System.Drawing.Point(433, 96);
            this.DataGridSanPham.Name = "DataGridSanPham";
            this.DataGridSanPham.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridSanPham.RowHeadersWidth = 25;
            this.DataGridSanPham.Size = new System.Drawing.Size(895, 748);
            this.DataGridSanPham.TabIndex = 93;
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
            this.SPTEN.Width = 400;
            // 
            // GIABAN
            // 
            this.GIABAN.DataPropertyName = "GIABAN";
            this.GIABAN.HeaderText = "Giá";
            this.GIABAN.Name = "GIABAN";
            this.GIABAN.Width = 150;
            // 
            // LOAI
            // 
            this.LOAI.DataPropertyName = "LOAI";
            this.LOAI.HeaderText = "Loại dịch vụ";
            this.LOAI.Name = "LOAI";
            this.LOAI.Width = 250;
            // 
            // txtLoai
            // 
            this.txtLoai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtLoai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtLoai.FormattingEnabled = true;
            this.txtLoai.Location = new System.Drawing.Point(157, 378);
            this.txtLoai.Name = "txtLoai";
            this.txtLoai.Size = new System.Drawing.Size(246, 28);
            this.txtLoai.TabIndex = 119;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Teal;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(26, 384);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 20);
            this.label9.TabIndex = 118;
            this.label9.Text = "Loại dịch vụ";
            // 
            // txtTimLoai
            // 
            this.txtTimLoai.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTimLoai.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.txtTimLoai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.txtTimLoai.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtTimLoai.FormattingEnabled = true;
            this.txtTimLoai.Location = new System.Drawing.Point(862, 52);
            this.txtTimLoai.Name = "txtTimLoai";
            this.txtTimLoai.Size = new System.Drawing.Size(183, 28);
            this.txtTimLoai.TabIndex = 121;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(764, 55);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(92, 20);
            this.label2.TabIndex = 120;
            this.label2.Text = "Loại dịch vụ";
            // 
            // btnXe
            // 
            this.btnXe.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.btnXe.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnXe.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXe.BorderRadius = 0;
            this.btnXe.ButtonText = "Danh sách xe";
            this.btnXe.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnXe.DisabledColor = System.Drawing.Color.Gray;
            this.btnXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXe.Iconcolor = System.Drawing.Color.Transparent;
            this.btnXe.Iconimage = null;
            this.btnXe.Iconimage_right = null;
            this.btnXe.Iconimage_right_Selected = null;
            this.btnXe.Iconimage_Selected = null;
            this.btnXe.IconMarginLeft = 0;
            this.btnXe.IconMarginRight = 0;
            this.btnXe.IconRightVisible = true;
            this.btnXe.IconRightZoom = 0D;
            this.btnXe.IconVisible = true;
            this.btnXe.IconZoom = 90D;
            this.btnXe.IsTab = false;
            this.btnXe.Location = new System.Drawing.Point(40, 719);
            this.btnXe.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXe.Name = "btnXe";
            this.btnXe.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnXe.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXe.OnHoverTextColor = System.Drawing.Color.White;
            this.btnXe.selected = false;
            this.btnXe.Size = new System.Drawing.Size(349, 79);
            this.btnXe.TabIndex = 122;
            this.btnXe.Text = "Danh sách xe";
            this.btnXe.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXe.Textcolor = System.Drawing.Color.White;
            this.btnXe.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXe.Click += new System.EventHandler(this.btnXe_Click);
            // 
            // QLDichVu_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.btnXe);
            this.Controls.Add(this.txtTimLoai);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtLoai);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.label23);
            this.Controls.Add(this.txtTimTen);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.BtnXuat);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.txtGiaBan);
            this.Controls.Add(this.txtTen);
            this.Controls.Add(this.txtID);
            this.Controls.Add(this.DataGridSanPham);
            this.Name = "QLDichVu_GUI";
            this.Size = new System.Drawing.Size(1335, 851);
            this.Load += new System.EventHandler(this.QLDichVu_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuFlatButton btnTimKiem;
        private System.Windows.Forms.Label label23;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTimTen;
        private System.Windows.Forms.Label label22;
        private System.Windows.Forms.Label label12;
        private Bunifu.Framework.UI.BunifuFlatButton btnReset;
        private Bunifu.Framework.UI.BunifuFlatButton btnThem;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuFlatButton BtnXuat;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private Bunifu.Framework.UI.BunifuFlatButton btnSua;
        private Bunifu.Framework.UI.BunifuFlatButton btnXoa;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtGiaBan;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTen;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtID;
        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MASP;
        private System.Windows.Forms.DataGridViewTextBoxColumn SPTEN;
        private System.Windows.Forms.DataGridViewTextBoxColumn GIABAN;
        private System.Windows.Forms.DataGridViewTextBoxColumn LOAI;
        private System.Windows.Forms.ComboBox txtLoai;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.ComboBox txtTimLoai;
        private System.Windows.Forms.Label label2;
        private Bunifu.Framework.UI.BunifuFlatButton btnXe;
    }
}
