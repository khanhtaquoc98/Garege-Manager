namespace Gara_GUI
{
    partial class QLXe_GUI
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.DataGridSanPham = new Bunifu.Framework.UI.BunifuCustomDataGrid();
            this.MAXE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TENXE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMaXe = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label22 = new System.Windows.Forms.Label();
            this.btnThem = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnXoa = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnSua = new Bunifu.Framework.UI.BunifuFlatButton();
            this.txtTenXe = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTimXe = new Bunifu.Framework.UI.BunifuMaterialTextbox();
            this.label4 = new System.Windows.Forms.Label();
            this.btnReload = new Bunifu.Framework.UI.BunifuFlatButton();
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
            this.MAXE,
            this.TENXE});
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
            this.DataGridSanPham.Location = new System.Drawing.Point(12, 104);
            this.DataGridSanPham.Name = "DataGridSanPham";
            this.DataGridSanPham.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.DataGridSanPham.RowHeadersWidth = 25;
            this.DataGridSanPham.Size = new System.Drawing.Size(326, 450);
            this.DataGridSanPham.TabIndex = 94;
            this.DataGridSanPham.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.DataGridSanPham_CellClick);
            // 
            // MAXE
            // 
            this.MAXE.DataPropertyName = "MAHANGXE";
            this.MAXE.HeaderText = "Mã xe";
            this.MAXE.Name = "MAXE";
            // 
            // TENXE
            // 
            this.TENXE.DataPropertyName = "TENHANGXE";
            this.TENXE.HeaderText = "Tên xe";
            this.TENXE.Name = "TENXE";
            this.TENXE.Width = 200;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Teal;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 22F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(251, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(268, 36);
            this.label7.TabIndex = 95;
            this.label7.Text = "Danh sách loại xe";
            // 
            // txtMaXe
            // 
            this.txtMaXe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtMaXe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtMaXe.Enabled = false;
            this.txtMaXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtMaXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtMaXe.HintForeColor = System.Drawing.Color.Empty;
            this.txtMaXe.HintText = "";
            this.txtMaXe.isPassword = false;
            this.txtMaXe.LineFocusedColor = System.Drawing.Color.Turquoise;
            this.txtMaXe.LineIdleColor = System.Drawing.Color.Teal;
            this.txtMaXe.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtMaXe.LineThickness = 3;
            this.txtMaXe.Location = new System.Drawing.Point(439, 354);
            this.txtMaXe.Margin = new System.Windows.Forms.Padding(4);
            this.txtMaXe.Name = "txtMaXe";
            this.txtMaXe.Size = new System.Drawing.Size(158, 24);
            this.txtMaXe.TabIndex = 97;
            this.txtMaXe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label22
            // 
            this.label22.AutoSize = true;
            this.label22.BackColor = System.Drawing.Color.Teal;
            this.label22.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label22.ForeColor = System.Drawing.Color.White;
            this.label22.Location = new System.Drawing.Point(387, 356);
            this.label22.Name = "label22";
            this.label22.Size = new System.Drawing.Size(45, 17);
            this.label22.TabIndex = 96;
            this.label22.Text = "Mã xe";
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
            this.btnThem.Location = new System.Drawing.Point(352, 465);
            this.btnThem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnThem.Name = "btnThem";
            this.btnThem.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnThem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnThem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnThem.selected = false;
            this.btnThem.Size = new System.Drawing.Size(84, 33);
            this.btnThem.TabIndex = 98;
            this.btnThem.Text = "Thêm";
            this.btnThem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnThem.Textcolor = System.Drawing.Color.White;
            this.btnThem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnThem.Click += new System.EventHandler(this.btnThem_Click);
            // 
            // btnXoa
            // 
            this.btnXoa.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.btnXoa.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnXoa.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnXoa.BorderRadius = 0;
            this.btnXoa.ButtonText = "Xoá";
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
            this.btnXoa.Location = new System.Drawing.Point(454, 465);
            this.btnXoa.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnXoa.Name = "btnXoa";
            this.btnXoa.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnXoa.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnXoa.OnHoverTextColor = System.Drawing.Color.White;
            this.btnXoa.selected = false;
            this.btnXoa.Size = new System.Drawing.Size(84, 33);
            this.btnXoa.TabIndex = 99;
            this.btnXoa.Text = "Xoá";
            this.btnXoa.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnXoa.Textcolor = System.Drawing.Color.White;
            this.btnXoa.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnXoa.Click += new System.EventHandler(this.btnXoa_Click);
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
            this.btnSua.Location = new System.Drawing.Point(559, 465);
            this.btnSua.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnSua.Name = "btnSua";
            this.btnSua.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnSua.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnSua.OnHoverTextColor = System.Drawing.Color.White;
            this.btnSua.selected = false;
            this.btnSua.Size = new System.Drawing.Size(84, 33);
            this.btnSua.TabIndex = 100;
            this.btnSua.Text = "Sửa";
            this.btnSua.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnSua.Textcolor = System.Drawing.Color.White;
            this.btnSua.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnSua.Click += new System.EventHandler(this.btnSua_Click);
            // 
            // txtTenXe
            // 
            this.txtTenXe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTenXe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTenXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTenXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTenXe.HintForeColor = System.Drawing.Color.Empty;
            this.txtTenXe.HintText = "";
            this.txtTenXe.isPassword = false;
            this.txtTenXe.LineFocusedColor = System.Drawing.Color.Turquoise;
            this.txtTenXe.LineIdleColor = System.Drawing.Color.Teal;
            this.txtTenXe.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtTenXe.LineThickness = 3;
            this.txtTenXe.Location = new System.Drawing.Point(439, 412);
            this.txtTenXe.Margin = new System.Windows.Forms.Padding(4);
            this.txtTenXe.Name = "txtTenXe";
            this.txtTenXe.Size = new System.Drawing.Size(158, 24);
            this.txtTenXe.TabIndex = 102;
            this.txtTenXe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(385, 412);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(51, 17);
            this.label1.TabIndex = 101;
            this.label1.Text = "Tên xe";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(450, 318);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(84, 20);
            this.label2.TabIndex = 103;
            this.label2.Text = "Thông tin";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Teal;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(450, 146);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 20);
            this.label3.TabIndex = 104;
            this.label3.Text = "Tìm kiếm";
            // 
            // txtTimXe
            // 
            this.txtTimXe.BackColor = System.Drawing.Color.WhiteSmoke;
            this.txtTimXe.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtTimXe.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.txtTimXe.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.txtTimXe.HintForeColor = System.Drawing.Color.Empty;
            this.txtTimXe.HintText = "";
            this.txtTimXe.isPassword = false;
            this.txtTimXe.LineFocusedColor = System.Drawing.Color.Turquoise;
            this.txtTimXe.LineIdleColor = System.Drawing.Color.Teal;
            this.txtTimXe.LineMouseHoverColor = System.Drawing.Color.Turquoise;
            this.txtTimXe.LineThickness = 3;
            this.txtTimXe.Location = new System.Drawing.Point(439, 183);
            this.txtTimXe.Margin = new System.Windows.Forms.Padding(4);
            this.txtTimXe.Name = "txtTimXe";
            this.txtTimXe.Size = new System.Drawing.Size(158, 24);
            this.txtTimXe.TabIndex = 106;
            this.txtTimXe.TextAlign = System.Windows.Forms.HorizontalAlignment.Left;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Teal;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(385, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 17);
            this.label4.TabIndex = 105;
            this.label4.Text = "Tên xe";
            // 
            // btnReload
            // 
            this.btnReload.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.btnReload.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnReload.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnReload.BorderRadius = 0;
            this.btnReload.ButtonText = "Reload";
            this.btnReload.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnReload.DisabledColor = System.Drawing.Color.Gray;
            this.btnReload.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReload.Iconcolor = System.Drawing.Color.Transparent;
            this.btnReload.Iconimage = null;
            this.btnReload.Iconimage_right = null;
            this.btnReload.Iconimage_right_Selected = null;
            this.btnReload.Iconimage_Selected = null;
            this.btnReload.IconMarginLeft = 0;
            this.btnReload.IconMarginRight = 0;
            this.btnReload.IconRightVisible = true;
            this.btnReload.IconRightZoom = 0D;
            this.btnReload.IconVisible = true;
            this.btnReload.IconZoom = 90D;
            this.btnReload.IsTab = false;
            this.btnReload.Location = new System.Drawing.Point(503, 226);
            this.btnReload.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnReload.Name = "btnReload";
            this.btnReload.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnReload.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnReload.OnHoverTextColor = System.Drawing.Color.White;
            this.btnReload.selected = false;
            this.btnReload.Size = new System.Drawing.Size(84, 33);
            this.btnReload.TabIndex = 108;
            this.btnReload.Text = "Reload";
            this.btnReload.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnReload.Textcolor = System.Drawing.Color.White;
            this.btnReload.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnReload.Click += new System.EventHandler(this.btnReload_Click);
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
            this.btnTimKiem.Location = new System.Drawing.Point(407, 226);
            this.btnTimKiem.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnTimKiem.Name = "btnTimKiem";
            this.btnTimKiem.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnTimKiem.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnTimKiem.OnHoverTextColor = System.Drawing.Color.White;
            this.btnTimKiem.selected = false;
            this.btnTimKiem.Size = new System.Drawing.Size(84, 33);
            this.btnTimKiem.TabIndex = 107;
            this.btnTimKiem.Text = "Tìm kiếm";
            this.btnTimKiem.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnTimKiem.Textcolor = System.Drawing.Color.White;
            this.btnTimKiem.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnTimKiem.Click += new System.EventHandler(this.btnTimKiem_Click);
            // 
            // QLXe_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.ClientSize = new System.Drawing.Size(656, 553);
            this.Controls.Add(this.btnReload);
            this.Controls.Add(this.btnTimKiem);
            this.Controls.Add(this.txtTimXe);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtTenXe);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnSua);
            this.Controls.Add(this.btnXoa);
            this.Controls.Add(this.btnThem);
            this.Controls.Add(this.txtMaXe);
            this.Controls.Add(this.label22);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.DataGridSanPham);
            this.Name = "QLXe_GUI";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loại xe";
            this.Load += new System.EventHandler(this.QLXe_GUI_Load);
            ((System.ComponentModel.ISupportInitialize)(this.DataGridSanPham)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Bunifu.Framework.UI.BunifuCustomDataGrid DataGridSanPham;
        private System.Windows.Forms.DataGridViewTextBoxColumn MAXE;
        private System.Windows.Forms.DataGridViewTextBoxColumn TENXE;
        private System.Windows.Forms.Label label7;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtMaXe;
        private System.Windows.Forms.Label label22;
        private Bunifu.Framework.UI.BunifuFlatButton btnThem;
        private Bunifu.Framework.UI.BunifuFlatButton btnXoa;
        private Bunifu.Framework.UI.BunifuFlatButton btnSua;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTenXe;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private Bunifu.Framework.UI.BunifuMaterialTextbox txtTimXe;
        private System.Windows.Forms.Label label4;
        private Bunifu.Framework.UI.BunifuFlatButton btnReload;
        private Bunifu.Framework.UI.BunifuFlatButton btnTimKiem;
    }
}