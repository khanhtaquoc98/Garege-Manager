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
    public partial class QLBCDS_GUI : UserControl
    {
        HoaDon_BUS sp_BUS = new HoaDon_BUS();
        private static QLBCDS_GUI _instance;

        public static QLBCDS_GUI Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new QLBCDS_GUI();
                return _instance;
            }
        }

        public QLBCDS_GUI()
        {
            InitializeComponent();
        }

        private void btnxuatthang_Click(object sender, EventArgs e)
        {
            string Thang = txtThang.Value.Date.ToString("MM");
            string Nam = txtThang.Value.Date.ToString("yyyy");
            string sql = "SELECT HOADON.MAKH,SOHD,HOTEN,BIENSO,NGHD,TONGGIA FROM KHACHHANG,HOADON WHERE KHACHHANG.MAKH = HOADON.MAKH AND NGHD IS NOT NULL "
                + " AND YEAR(NGHD) = '" + Nam + "' AND MONTH(NGHD) ='" + Thang + "'";

            DataTable dt = new DataTable();
            RpThang BC = new RpThang();
            dt = sp_BUS.Display(sql);

            BC.SetDataSource(dt);
            crystalReportViewer1.ReportSource = BC;
            crystalReportViewer1.Refresh();
        }

        private void btnxuatnam_Click(object sender, EventArgs e)
        {
            string Nam = txtnam.Value.Date.ToString("yyyy");
            string sql = "SELECT COUNT(SOHD) AS SOHD,FORMAT(NGHD,'MM/yyyy') AS NGHD,SUM(TONGGIA) AS TONGGIA FROM HOADON WHERE NGHD IS NOT NULL "
                + " AND YEAR(NGHD) = '" + Nam + "' GROUP BY FORMAT(NGHD,'MM/yyyy')";

            DataTable dt = new DataTable();
            RpNam BC = new RpNam();
            dt = sp_BUS.Display(sql);

            BC.SetDataSource(dt);
            crystalReportViewer1.ReportSource = BC;
            crystalReportViewer1.Refresh();
        }
    }
}
