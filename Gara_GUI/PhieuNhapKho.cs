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
    public partial class PhieuNhapKho : Form
    {
        private string _Ngay1;
        private string _Ngay2;
        NhapKho_BUS nk_BUS = new NhapKho_BUS();

        public string Ngay1
        {
            get { return _Ngay1; }
            set { _Ngay1 = value; }
        }

        public string Ngay2
        {
            get { return _Ngay2; }
            set { _Ngay2 = value; }
        }

        public PhieuNhapKho()
        {
            InitializeComponent();
        }


        private void PhieuNhapKho_Load(object sender, EventArgs e)
        {
            string SQL = "SELECT NHAPKHO.MASP,TENSP,SLNHAP, DONVI,NHAPKHO.GIANHAP,NGAYNHAP,HOTEN,NHAPKHO.NGNHAP " +
                " FROM SANPHAM,NHAPKHO,NHANVIEN " +
                " WHERE  NHAPKHO.NGAYNHAP >= '" + _Ngay1 + "' AND NHAPKHO.NGAYNHAP <= '" + _Ngay2 + "' " 
                + "AND NHAPKHO.NGNHAP = NHANVIEN.MANV AND SANPHAM.MASP = NHAPKHO.MASP";

            DataTable dt = new DataTable();
            RpPhieuKho NhapKho = new RpPhieuKho();
            dt = nk_BUS.Display(SQL);

            NhapKho.SetDataSource(dt);
            crystalReportViewer1.ReportSource = NhapKho;
            crystalReportViewer1.Refresh();
        }
    }
}
