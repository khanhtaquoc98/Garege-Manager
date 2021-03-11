namespace Gara_GUI
{
    partial class QLBCDS_GUI
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
            this.label7 = new System.Windows.Forms.Label();
            this.txtThang = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtnam = new System.Windows.Forms.DateTimePicker();
            this.btnxuatthang = new Bunifu.Framework.UI.BunifuFlatButton();
            this.btnxuatnam = new Bunifu.Framework.UI.BunifuFlatButton();
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.SuspendLayout();
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Teal;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 35F, System.Drawing.FontStyle.Bold);
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(454, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(414, 54);
            this.label7.TabIndex = 111;
            this.label7.Text = "Báo cáo doanh số";
            // 
            // txtThang
            // 
            this.txtThang.CustomFormat = "MM/yyyy";
            this.txtThang.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtThang.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtThang.Location = new System.Drawing.Point(293, 111);
            this.txtThang.Name = "txtThang";
            this.txtThang.ShowUpDown = true;
            this.txtThang.Size = new System.Drawing.Size(106, 26);
            this.txtThang.TabIndex = 138;
            this.txtThang.Value = new System.DateTime(2019, 6, 7, 0, 0, 0, 0);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Teal;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(274, 92);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 16);
            this.label1.TabIndex = 139;
            this.label1.Text = "Báo cáo theo tháng";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Teal;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(919, 92);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 16);
            this.label2.TabIndex = 141;
            this.label2.Text = "Báo cáo theo năm";
            // 
            // txtnam
            // 
            this.txtnam.CustomFormat = "yyyy";
            this.txtnam.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.txtnam.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.txtnam.Location = new System.Drawing.Point(935, 111);
            this.txtnam.Name = "txtnam";
            this.txtnam.ShowUpDown = true;
            this.txtnam.Size = new System.Drawing.Size(106, 26);
            this.txtnam.TabIndex = 140;
            this.txtnam.Value = new System.DateTime(2019, 6, 7, 0, 0, 0, 0);
            // 
            // btnxuatthang
            // 
            this.btnxuatthang.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.btnxuatthang.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnxuatthang.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnxuatthang.BorderRadius = 0;
            this.btnxuatthang.ButtonText = "Xuất";
            this.btnxuatthang.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxuatthang.DisabledColor = System.Drawing.Color.Gray;
            this.btnxuatthang.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnxuatthang.Iconcolor = System.Drawing.Color.Transparent;
            this.btnxuatthang.Iconimage = null;
            this.btnxuatthang.Iconimage_right = null;
            this.btnxuatthang.Iconimage_right_Selected = null;
            this.btnxuatthang.Iconimage_Selected = null;
            this.btnxuatthang.IconMarginLeft = 0;
            this.btnxuatthang.IconMarginRight = 0;
            this.btnxuatthang.IconRightVisible = true;
            this.btnxuatthang.IconRightZoom = 0D;
            this.btnxuatthang.IconVisible = true;
            this.btnxuatthang.IconZoom = 90D;
            this.btnxuatthang.IsTab = false;
            this.btnxuatthang.Location = new System.Drawing.Point(185, 111);
            this.btnxuatthang.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnxuatthang.Name = "btnxuatthang";
            this.btnxuatthang.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnxuatthang.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnxuatthang.OnHoverTextColor = System.Drawing.Color.White;
            this.btnxuatthang.selected = false;
            this.btnxuatthang.Size = new System.Drawing.Size(84, 26);
            this.btnxuatthang.TabIndex = 142;
            this.btnxuatthang.Text = "Xuất";
            this.btnxuatthang.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnxuatthang.Textcolor = System.Drawing.Color.White;
            this.btnxuatthang.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnxuatthang.Click += new System.EventHandler(this.btnxuatthang_Click);
            // 
            // btnxuatnam
            // 
            this.btnxuatnam.Activecolor = System.Drawing.Color.DarkSlateGray;
            this.btnxuatnam.BackColor = System.Drawing.Color.DarkSlateGray;
            this.btnxuatnam.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.btnxuatnam.BorderRadius = 0;
            this.btnxuatnam.ButtonText = "Xuất";
            this.btnxuatnam.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnxuatnam.DisabledColor = System.Drawing.Color.Gray;
            this.btnxuatnam.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnxuatnam.Iconcolor = System.Drawing.Color.Transparent;
            this.btnxuatnam.Iconimage = null;
            this.btnxuatnam.Iconimage_right = null;
            this.btnxuatnam.Iconimage_right_Selected = null;
            this.btnxuatnam.Iconimage_Selected = null;
            this.btnxuatnam.IconMarginLeft = 0;
            this.btnxuatnam.IconMarginRight = 0;
            this.btnxuatnam.IconRightVisible = true;
            this.btnxuatnam.IconRightZoom = 0D;
            this.btnxuatnam.IconVisible = true;
            this.btnxuatnam.IconZoom = 90D;
            this.btnxuatnam.IsTab = false;
            this.btnxuatnam.Location = new System.Drawing.Point(1064, 111);
            this.btnxuatnam.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnxuatnam.Name = "btnxuatnam";
            this.btnxuatnam.Normalcolor = System.Drawing.Color.DarkSlateGray;
            this.btnxuatnam.OnHovercolor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnxuatnam.OnHoverTextColor = System.Drawing.Color.White;
            this.btnxuatnam.selected = false;
            this.btnxuatnam.Size = new System.Drawing.Size(84, 26);
            this.btnxuatnam.TabIndex = 143;
            this.btnxuatnam.Text = "Xuất";
            this.btnxuatnam.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnxuatnam.Textcolor = System.Drawing.Color.White;
            this.btnxuatnam.TextFont = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.btnxuatnam.Click += new System.EventHandler(this.btnxuatnam_Click);
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(0, 156);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1335, 695);
            this.crystalReportViewer1.TabIndex = 144;
            // 
            // QLBCDS_GUI
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Teal;
            this.Controls.Add(this.crystalReportViewer1);
            this.Controls.Add(this.btnxuatnam);
            this.Controls.Add(this.btnxuatthang);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtnam);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtThang);
            this.Controls.Add(this.label7);
            this.Name = "QLBCDS_GUI";
            this.Size = new System.Drawing.Size(1335, 851);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.DateTimePicker txtThang;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker txtnam;
        private Bunifu.Framework.UI.BunifuFlatButton btnxuatthang;
        private Bunifu.Framework.UI.BunifuFlatButton btnxuatnam;
        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
    }
}
