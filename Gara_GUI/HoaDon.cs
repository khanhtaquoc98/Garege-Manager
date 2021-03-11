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

namespace Gara_GUI
{
  
    public partial class HoaDon : Form
    {
       int _IDHD;
        HoaDon_BUS hd_BUS = new HoaDon_BUS();
        public int IDHD
        {
            get { return _IDHD; }
            set { _IDHD = value; }
        }

        public HoaDon()
        {
            InitializeComponent();
        }

        private void HoaDon_Load(object sender, EventArgs e)
        {
            int id = IDHD;
            DataTable dt = new DataTable();
            RpHD HD = new RpHD();
            dt = hd_BUS.Display("SELECT HOADON.SOHD,CTHD.MASP,KHACHHANG.HOTEN,NGSUA,BIENSO,SANPHAM.TENSP,SL,DONVI,LOAI,GIACTHD,TongGia,NHANVIEN.HOTEN,MANVTV,MANVKT " +
                                "FROM CTHD, SANPHAM, KHACHHANG, HANGXE, NHANVIEN, HOADON " +
              "WHERE CTHD.SOHD = HOADON.SOHD AND KHACHHANG.MAKH = HOADON.MAKH AND NHANVIEN.MANV = HOADON.MANV " +
             " AND HANGXE.MAHANGXE = KHACHHANG.MAHANGXE AND SANPHAM.MASP = CTHD.MASP AND HOADON.SOHD = " + id);

            HD.SetDataSource(dt);
            crystalReportViewer1.ReportSource = HD;
            crystalReportViewer1.Refresh();
        }
    }
}
