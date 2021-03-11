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
    public partial class PhieuDichVu : Form
    {

        private string _sql;
        SanPham_BUS sp_BUS = new SanPham_BUS();

        public string sql
        {
            get { return _sql; }
            set { _sql = value; }
        }

        public PhieuDichVu()
        {
            InitializeComponent();
        }

        private void PhieuDichVu_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            RpDichVu Kho = new RpDichVu();
            dt = sp_BUS.Display(sql);

            Kho.SetDataSource(dt);
            crystalReportViewer1.ReportSource = Kho;
            crystalReportViewer1.Refresh();
        }
    }
}
