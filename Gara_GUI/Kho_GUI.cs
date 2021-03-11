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
    public partial class Kho_GUI : UserControl
    {
        private static Kho_GUI _instance;
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

        public static Kho_GUI Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new Kho_GUI();
                return _instance;
            }
        }

        public Kho_GUI()
        {
            InitializeComponent();
        }

        public void Kho_GUI_Load(object sender, EventArgs e)
        {

            if (nv_BUS.getIDPQ(_Ten) != 1)
            {
                bunifuFlatButton2.Enabled = false;
                btnXoa.Enabled = false;
                btnSua.Enabled = false;
            }
            else
            {
                bunifuFlatButton2.Enabled = true;
                btnXoa.Enabled = true;
                btnSua.Enabled = true;
            }


            tblSP = sp_BUS.Display("SELECT * FROM SANPHAM WHERE LOAI = N'Phụ tùng'");
            DataGridSanPham.DataSource = tblSP;
            DataGridSanPham.AllowUserToAddRows = false;
      
        }

        private void DataGridSanPham_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index == -1) index = 0;

            DataGridViewRow selectRow = DataGridSanPham.Rows[index];
            txtID.Text = selectRow.Cells["MASP"].Value.ToString();
            txtTen.Text = selectRow.Cells["SPTEN"].Value.ToString();
            txtSL.Text = selectRow.Cells["SOLUONG"].Value.ToString();
            txtDonVi.Text = selectRow.Cells["DONVI"].Value.ToString();
            txtGiaBan.Text = selectRow.Cells["GIABAN"].Value.ToString();
            txtGiaNhap.Text = selectRow.Cells["GIANHAP"].Value.ToString();         
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
                if (sp_BUS.Delete(int.Parse(txtID.Text)))
                {
                    MessageBox.Show("Xoá thành công!");
                    Kho_GUI_Load(sender, e);
                }
                else
                    MessageBox.Show("Xoá thất bại!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu!");
            }
        }

        private void btnSua_Click(object sender, EventArgs e)
        {
            if (txtID.Text != "")
            {
               SanPham_DTO kh_DTO = new SanPham_DTO(int.Parse(txtID.Text),txtTen.Text, int.Parse(txtSL.Text),
                     txtGiaNhap.Text, txtGiaBan.Text,txtDonVi.Text,  "Phụ tùng");
              
                    if (sp_BUS.Update(kh_DTO))
                    {
                        MessageBox.Show("Sửa thành công!");
                        Kho_GUI_Load(sender, e);
                    }
                    else
                        MessageBox.Show("Sửa thất bại!");          
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu!");
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            PhieuKho_GUI PK = new PhieuKho_GUI();
            PK.sql = "SELECT * FROM SANPHAM WHERE LOAI = N'Phụ tùng' AND TENSP LIKE N'%" + txtTimTen.Text + "%'";         
            PK.Show();
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
                SanPham_DTO kh_DTO = new SanPham_DTO(txtTen.Text, 0,
                      txtGiaNhap.Text, txtGiaBan.Text, txtDonVi.Text, "Phụ tùng");

                if (sp_BUS.Insert(kh_DTO))
                {
                    MessageBox.Show("Thêm thành công!");
                    Kho_GUI_Load(sender, e);
                }
                else
                    MessageBox.Show("Thêm thất bại!");
            }

        private void btnThem_Click(object sender, EventArgs e)
        {
            NhapHang_GUI NH = new NhapHang_GUI();
            NH.TENNV = _Ten;
            NH.Show();           
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            Kho_GUI_Load(sender, e);
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tblSP = sp_BUS.Display("SELECT * FROM SANPHAM WHERE LOAI = N'Phụ tùng' AND TENSP LIKE N'%" + txtTimTen.Text + "%'");
            DataGridSanPham.DataSource = tblSP;
            DataGridSanPham.AllowUserToAddRows = false;

            if (tblSP.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy", "Thông Báo");
            }
        }
    }
}
