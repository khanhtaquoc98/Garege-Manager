using Gara_BUS;
using Gara_DTO;
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
    public partial class QLXe_GUI : Form
    {
        HangXe_BUS hx_BUS = new HangXe_BUS();
        DataTable tblXe = new DataTable();

        public QLXe_GUI()
        {
            InitializeComponent();
        }

        private void QLXe_GUI_Load(object sender, EventArgs e)
        {
            tblXe = hx_BUS.Display("SELECT * FROM HANGXE ORDER BY TENHANGXE ");
            DataGridSanPham.DataSource = tblXe;
            DataGridSanPham.AllowUserToAddRows = false;

        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tblXe = hx_BUS.Display("SELECT * FROM HANGXE WHERE TENHANGXE LIKE N'%" + txtTimXe.Text + "%' ORDER BY TENHANGXE");
            DataGridSanPham.DataSource = tblXe;
            DataGridSanPham.AllowUserToAddRows = false;

            if (tblXe.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy!", "Thông Báo");
            }
        }

        private void btnReload_Click(object sender, EventArgs e)
        {
            QLXe_GUI_Load(sender, e);
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            HangXe_DTO kh_DTO = new HangXe_DTO(txtTenXe.Text);

            if (hx_BUS.Insert(kh_DTO))
            {
                MessageBox.Show("Thêm thành công!");
                QLXe_GUI_Load(sender, e);
            }
            else
                MessageBox.Show("Thêm thất bại!");
        }

        private void btnXoa_Click(object sender, EventArgs e)
        {
            if (txtMaXe.Text != "")
            {
                if (hx_BUS.Delete(int.Parse(txtMaXe.Text)))
                {
                    MessageBox.Show("Xoá thành công!");
                    QLXe_GUI_Load(sender, e);
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
            if (txtMaXe.Text != "")
            {
                HangXe_DTO kh_DTO = new HangXe_DTO(int.Parse(txtMaXe.Text), txtTenXe.Text);

                if (hx_BUS.Update(kh_DTO))
                {
                    MessageBox.Show("Sửa thành công!");
                    QLXe_GUI_Load(sender, e);
                }
                else
                    MessageBox.Show("Sửa thất bại!");
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
            txtMaXe.Text = selectRow.Cells["MAXE"].Value.ToString();
            txtTenXe.Text = selectRow.Cells["TENXE"].Value.ToString();           
        }
    }
}
