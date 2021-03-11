using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Gara_BUS;

namespace Gara_GUI
{
    public partial class QLHoaDon_GUI : UserControl
    {

        HoaDon_BUS hd_BUS = new HoaDon_BUS();
        CTHD_BUS cthd_BUS = new CTHD_BUS();

        private static QLHoaDon_GUI _instance;
        DataTable tblHD = new DataTable();
        DataTable tblCTHD = new DataTable();
        public static QLHoaDon_GUI Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new QLHoaDon_GUI();
                return _instance;
            }
        }

        public QLHoaDon_GUI()
        {
            InitializeComponent();
        }

        private void QLHoaDon_GUI_Load(object sender, EventArgs e)
        {
            tblHD = hd_BUS.Display("SELECT SOHD,NGSUA,NGHD,HOADON.TongGia,KHACHHANG.HOTEN,TENHANGXE,KHACHHANG.SODT,KHACHHANG.DIACHI,BIENSO,SOKM,SOKHUNG, MANVKT, MANVTV " +
               "FROM HOADON, KHACHHANG, HANGXE, NHANVIEN " +
               "WHERE HOADON.MAKH = KHACHHANG.MAKH AND  KHACHHANG.MAHANGXE = HANGXE.MAHANGXE AND HOADON.MANVTV = NHANVIEN.MANV AND HOADON.NGHD IS NOT NULL");
            DataGridHD.DataSource = tblHD;
            DataGridHD.AllowUserToAddRows = false;

            txtNgay1.Value = DateTime.Now;
            txtNgay2.Value = DateTime.Now;
        }

        private void DataGridHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXuat.Enabled = true;
          
            int index = e.RowIndex;
            if (index == -1) index = 0;
            DataGridViewRow selectRowKhachHang = DataGridHD.Rows[index];
            txtIDHD.Text = selectRowKhachHang.Cells["IDHD"].Value.ToString();

            tblCTHD = hd_BUS.Display("SELECT TENSP,SL,DONVI,LOAI,GIACTHD FROM CTHD,SANPHAM WHERE CTHD.MASP = SANPHAM.MASP AND CTHD.SOHD =" + int.Parse(txtIDHD.Text));
            DataGridCTHD.DataSource = tblCTHD;
            DataGridCTHD.AllowUserToAddRows = false;


        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            string Ngay1 = txtNgay1.Value.Date.ToString("yyyy/MM/dd");
            string Ngay2 = txtNgay2.Value.Date.ToString("yyyy/MM/dd");

            tblHD = hd_BUS.Display("SELECT SOHD,NGSUA,NGHD,HOADON.TongGia,KHACHHANG.HOTEN,TENHANGXE,KHACHHANG.SODT,KHACHHANG.DIACHI,BIENSO,SOKM,SOKHUNG, MANVKT, MANVTV " +
               "FROM HOADON, KHACHHANG, HANGXE, NHANVIEN " +
               "WHERE HOADON.MAKH = KHACHHANG.MAKH AND  KHACHHANG.MAHANGXE = HANGXE.MAHANGXE AND HOADON.MANVTV = NHANVIEN.MANV AND HOADON.NGHD IS NOT NULL AND NGHD >= '" +Ngay1+ "' AND NGHD <= '"+ Ngay2 + "' " +
               "AND KHACHHANG.HOTEN LIKE N'%" + txtTimTen.Text + "%' AND BIENSO LIKE '%" + txtTimBienSo.Text + "%' AND KHACHHANG.SODT LIKE '%" + txtTimSDT.Text + "%' " +
               "ORDER BY SOHD ASC");
            DataGridHD.DataSource = tblHD;
            DataGridHD.AllowUserToAddRows = false;

            if (tblHD.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy", "Thông Báo");
            }
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {            
            HoaDon HD = new HoaDon();
            HD.IDHD = int.Parse(txtIDHD.Text);
            HD.Show();
        }
    }
}
