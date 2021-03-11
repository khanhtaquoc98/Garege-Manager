using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gara_DTO;
using Gara_BUS;
using System.Globalization;

namespace Gara_GUI
{
    public partial class Home_GUI : Form
    {
        Login_BUS login_BUS = new Login_BUS();
        private string _TenDangNhap;       
        NhanVien_BUS nv = new NhanVien_BUS();
        string Ten;
        int IDPQ;

        public Home_GUI()
        {
            InitializeComponent();
        }

        public Home_GUI(string TenDangNhap): this()
        {
            _TenDangNhap = TenDangNhap;
             Ten = login_BUS.getTen(_TenDangNhap);
            txtTen.Text ="Hi! " + Ten;
        }

        private void btnDVSuaXe_Click(object sender, EventArgs e)
        {
            QLKhachHang_GUI.Instance.TenNV = Ten;
            if (!panelControl.Controls.Contains(QLKhachHang_GUI.Instance))
            {
                panelControl.Controls.Add(QLKhachHang_GUI.Instance);
                QLKhachHang_GUI.Instance.Dock = DockStyle.Fill;
                QLKhachHang_GUI.Instance.BringToFront();
            } else
            {
                QLKhachHang_GUI.Instance.BringToFront();
                QLKhachHang_GUI.Instance.QLKhachHang_DTO_Load(sender, e);
            }
                
        }

        private void btnKho_Click(object sender, EventArgs e)
        {
            Kho_GUI.Instance.Ten = Ten;
            if (!panelControl.Controls.Contains(Kho_GUI.Instance))
            {
                panelControl.Controls.Add(Kho_GUI.Instance);              
                Kho_GUI.Instance.Dock = DockStyle.Fill;
                Kho_GUI.Instance.BringToFront();       
            }
            else
            {               
                Kho_GUI.Instance.BringToFront();
                Kho_GUI.Instance.Kho_GUI_Load(sender, e);
            }
                
        }

        private void Home_GUI_Load(object sender, EventArgs e)
        {
            IDPQ = nv.getIDPQ(Ten);
            if (IDPQ != 1)
            {
                btnKho.Visible = false;
                btnQLHD.Visible = false;
                btnDichVu.Visible = false;
                btnDoanhSo.Visible = false;
                btnNhanVien.Visible = false;
                btnKhachHang.Visible = false;
            }
            else
                btnDVSuaXe.Visible = false;
        }

        private void btnQLHD_Click(object sender, EventArgs e)
        {
            if (!panelControl.Controls.Contains(QLHoaDon_GUI.Instance))
            {
                panelControl.Controls.Add(QLHoaDon_GUI.Instance);
                QLHoaDon_GUI.Instance.Dock = DockStyle.Fill;
                QLHoaDon_GUI.Instance.BringToFront();
            }
            else
            {
                QLHoaDon_GUI.Instance.BringToFront();
            }
        }

        private void btnDichVu_Click(object sender, EventArgs e)
        {
            QLDichVu_GUI.Instance.Ten = Ten;
            if (!panelControl.Controls.Contains(QLDichVu_GUI.Instance))
            {
                panelControl.Controls.Add(QLDichVu_GUI.Instance);
                QLDichVu_GUI.Instance.Dock = DockStyle.Fill;
                QLDichVu_GUI.Instance.BringToFront();
            }
            else
            {
                QLDichVu_GUI.Instance.BringToFront();
                QLDichVu_GUI.Instance.QLDichVu_GUI_Load(sender, e);
            }
        }

        private void btnNhanVien_Click(object sender, EventArgs e)
        {
            if (!panelControl.Controls.Contains(QLNV_GUI.Instance))
            {
                panelControl.Controls.Add(QLNV_GUI.Instance);
                QLNV_GUI.Instance.Dock = DockStyle.Fill;
                QLNV_GUI.Instance.BringToFront();
            }
            else
            {
                QLNV_GUI.Instance.BringToFront();              
            }
        }

        private void btnDoanhSo_Click(object sender, EventArgs e)
        {
            if (!panelControl.Controls.Contains(QLBCDS_GUI.Instance))
            {
                panelControl.Controls.Add(QLBCDS_GUI.Instance);
                QLBCDS_GUI.Instance.Dock = DockStyle.Fill;
                QLBCDS_GUI.Instance.BringToFront();
            }
            else
            {
                QLBCDS_GUI.Instance.BringToFront();
            }
        }

        private void btnKhachHang_Click(object sender, EventArgs e)
        {
            if (!panelControl.Controls.Contains(QLKhachHang2_GUI.Instance))
            {
                panelControl.Controls.Add(QLKhachHang2_GUI.Instance);
                QLKhachHang2_GUI.Instance.Dock = DockStyle.Fill;
                QLKhachHang2_GUI.Instance.BringToFront();
            }
            else
            {
                QLKhachHang2_GUI.Instance.BringToFront();
                QLKhachHang2_GUI.Instance.QLKhachHang2_GUI_Load(sender, e);
            }
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            Login_GUI lg = new Login_GUI();
            this.Hide();
            lg.Show();
        }
    }
}
