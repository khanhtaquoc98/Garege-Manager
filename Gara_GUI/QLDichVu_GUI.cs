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
using Gara_DTO;

namespace Gara_GUI
{
    public partial class QLDichVu_GUI : UserControl
    {
        private static QLDichVu_GUI _instance;
        SanPham_BUS sp_BUS = new SanPham_BUS();
        NhanVien_BUS nv_BUS = new NhanVien_BUS();
        DataTable tblSP = new DataTable();
        DataTable tblMuc = new DataTable();
        private string _Ten;

        public string Ten
        {
            get { return _Ten; }
            set { _Ten = value; }
        }

        public static QLDichVu_GUI Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new QLDichVu_GUI();
                return _instance;
            }
        }

        public QLDichVu_GUI()
        {
            InitializeComponent();
        }

        public void QLDichVu_GUI_Load(object sender, EventArgs e)
        {

            tblSP = sp_BUS.Display("SELECT * FROM SANPHAM WHERE LOAI != N'Phụ tùng' ORDER BY LOAI ");
            DataGridSanPham.DataSource = tblSP;
            DataGridSanPham.AllowUserToAddRows = false;


            txtLoai.DataSource = tblSP;
            txtLoai.DisplayMember = "LOAI";
            txtLoai.ValueMember = "LOAI";

            txtTimLoai.DataSource = tblSP;
            txtTimLoai.DisplayMember = "LOAI";
            txtTimLoai.ValueMember = "LOAI";
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            SanPham_DTO kh_DTO = new SanPham_DTO(txtTen.Text, 0,
                      null, txtGiaBan.Text, null, txtLoai.Text);

            if (sp_BUS.InsertDV(kh_DTO))
            {
                MessageBox.Show("Thêm thành công!");
                QLDichVu_GUI_Load(sender, e);
            }
            else
                MessageBox.Show("Thêm thất bại!");
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                SanPham_DTO kh_DTO = new SanPham_DTO(int.Parse(txtID.Text),txtTen.Text, 0,
                     null, txtGiaBan.Text, null, txtLoai.Text);

                if (sp_BUS.UpdateDV(kh_DTO))
                {
                    MessageBox.Show("Sửa thành công!");
                    QLDichVu_GUI_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa thất bại!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu!");
            }
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (sp_BUS.Delete(int.Parse(txtID.Text)))
                {
                    MessageBox.Show("Xoá thành công!");
                    QLDichVu_GUI_Load(sender, e);
                }
                else
                    MessageBox.Show("Xoá thất bại!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu!");
            }
        }

        private void DataGridSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index == -1) index = 0;

            DataGridViewRow selectRow = DataGridSanPham.Rows[index];
            txtID.Text = selectRow.Cells["MASP"].Value.ToString();
            txtTen.Text = selectRow.Cells["SPTEN"].Value.ToString();
            txtGiaBan.Text = selectRow.Cells["GIABAN"].Value.ToString();
            txtLoai.Text = selectRow.Cells["LOAI"].Value.ToString();
        }

        private void BtnXuat_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM SANPHAM WHERE LOAI != N'Phụ tùng' AND TENSP LIKE N'%" + txtTimTen.Text + "%'"; 
            PhieuDichVu pdv = new PhieuDichVu();
            pdv.sql = sql;
            pdv.Show();
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tblSP = sp_BUS.Display("SELECT * FROM SANPHAM WHERE LOAI != N'Phụ tùng' AND TENSP LIKE N'%" + txtTimTen.Text + "%'"
                + " AND LOAI LIKE N'" + txtTimLoai.Text +  "' ORDER BY LOAI");
            DataGridSanPham.DataSource = tblSP;
            DataGridSanPham.AllowUserToAddRows = false;

            if (tblSP.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy khách hàng", "Thông Báo");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            QLDichVu_GUI_Load(sender, e);
        }

        private void btnXe_Click(object sender, EventArgs e)
        {
            QLXe_GUI QLXE = new QLXe_GUI();
            QLXE.Show();
        }
    }
}
