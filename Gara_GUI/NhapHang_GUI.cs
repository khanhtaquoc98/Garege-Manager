using Gara_BUS;
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

namespace Gara_GUI
{
    public partial class NhapHang_GUI : Form
    {
        SanPham_BUS sp_BUS = new SanPham_BUS();
        NhapKho_BUS nk_BUS = new NhapKho_BUS();
        NhanVien_BUS nv_BUS = new NhanVien_BUS();
        DataTable tblSP = new DataTable();
        DataTable tbl = new DataTable();
        string _TENNV;

        public string TENNV
        {
            get { return _TENNV; }
            set { _TENNV = value; }
        }

        public NhapHang_GUI()
        {
            InitializeComponent();
        }

        public void NhapHang_GUI_Load(object sender, EventArgs e)
        {
            tbl = nk_BUS.Display("SELECT SANPHAM.MASP,TENSP,SLNHAP,DONVI,NHAPKHO.GIANHAP,NGAYNHAP,HOTEN " +
                "FROM SANPHAM,NHAPKHO,NHANVIEN " +
                "WHERE NHAPKHO.NGNHAP = MANV AND SANPHAM.MASP = NHAPKHO.MASP AND NGAYNHAP ='" + DateTime.Now + "'");

            DataGrid.DataSource = tbl;
            DataGrid.AllowUserToAddRows = false;


            tblSP = sp_BUS.Display("SELECT MASP, TENSP, GIANHAP FROM SANPHAM");
            txtID.DataSource = tblSP;
            txtID.DisplayMember = "MASP";
            txtID.ValueMember = "MASP";

            txtTen.DataSource = tblSP;
            txtTen.DisplayMember = "TENSP";
            txtTen.ValueMember = "TENSP";

            txtGiaNhap.DataSource = tblSP;
            txtGiaNhap.DisplayMember = "GIANHAP";
            txtGiaNhap.ValueMember = "GIANHAP";

            txtDay1.Value = txtDay2.Value = txtNgaynhap.Value = DateTime.Now;

        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int MASP = int.Parse(txtID.Text);
            string TenSP = txtTen.Text;
            int SLNHAP = int.Parse(txtSL.Text);
            string NgayNhap = txtNgaynhap.Value.Date.ToString("yyyy/MM/dd");
            string GiaNhap = txtGiaNhap.Text;
            string TongTien = txtTongTien.Text;
            int MANGNHAP = nv_BUS.getMANV(TENNV);

            if (txtNgaynhap.Value <= DateTime.Now)
            {
                if (sp_BUS.CheckTonTai(MASP, TenSP) == false)
                {
                    MessageBox.Show("Vui lòng kiểm tra lại hoặc chưa thêm phụ tùng vào kho!");
                }
                else
                {
                    NhapKho_DTO nk = new NhapKho_DTO(NgayNhap, MASP, MANGNHAP, SLNHAP, TongTien);
                    if (nk_BUS.checkSPNhap(MASP, NgayNhap, MANGNHAP) == true)
                    {
                        if (nk_BUS.UpdateSLNK(nk))
                        {
                            sp_BUS.UpdateSL(nk.MASP, SLNHAP);
                            NhapHang_GUI_Load(sender, e);
                            MessageBox.Show("Cập nhật hàng thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật hàng thất bại!");
                        }

                    }
                    else
                    {
                        if (nk_BUS.Insert(nk))
                        {
                            sp_BUS.UpdateSL(nk.MASP, SLNHAP);
                            NhapHang_GUI_Load(sender, e);
                            MessageBox.Show("Nhập hàng thành công!");
                        }
                        else
                        {
                            MessageBox.Show("Nhập hàng thất bại!");
                        }
                    }
                }
            } else
                 MessageBox.Show("Ngày nhập phải bằng hoặc bé hơn ngày hiện tại!");

          
                          
        }

        private void txtTen_TextChanged(object sender, EventArgs e)
        {
            txtSL.Text = "0";
        }

        private void txtSL_ValueChanged(object sender, EventArgs e)
        {
            decimal TongTien = int.Parse(txtGiaNhap.Text) * txtSL.Value;
            txtTongTien.Text = TongTien.ToString();
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            string Ngay1 = txtDay1.Value.Date.ToString("yyyy/MM/dd");
            string Ngay2 = txtDay2.Value.Date.ToString("yyyy/MM/dd");

            PhieuNhapKho PNK = new PhieuNhapKho();
            PNK.Ngay1 = Ngay1;
            PNK.Ngay2 = Ngay2;
            PNK.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string Ngay1 = txtDay1.Value.Date.ToString("yyyy/MM/dd");
            string Ngay2 = txtDay2.Value.Date.ToString("yyyy/MM/dd");

            string sql = "SELECT NHAPKHO.MASP,TENSP,SLNHAP, DONVI,NHAPKHO.GIANHAP,NGAYNHAP,HOTEN " +
                " FROM SANPHAM,NHAPKHO,NHANVIEN " +
                " WHERE NGNHAP = NHANVIEN.MANV AND SANPHAM.MASP = NHAPKHO.MASP AND NGAYNHAP BETWEEN '" + Ngay1 + "' AND '" + Ngay2 + "'"; 

            tbl = sp_BUS.Display(sql);
            DataGrid.DataSource = tbl;
            DataGrid.AllowUserToAddRows = false;

            if (tbl.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy", "Thông Báo");
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            NhapHang_GUI_Load(sender, e);
        }
    }
}
