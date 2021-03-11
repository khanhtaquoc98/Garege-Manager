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
    public partial class QLKhachHang2_GUI : UserControl
    {
        private static QLKhachHang2_GUI _instance;
        public static QLKhachHang2_GUI Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new QLKhachHang2_GUI();
                return _instance;
            }
        }
        private string _txtTenNV;

        HangXe_BUS hx_BUS = new HangXe_BUS();
        KhachHang_BUS kh_BUS = new KhachHang_BUS();
        DataTable tblKH = new DataTable();
        DataTable tblLX = new DataTable();

        public string TenNV
        {
            get { return _txtTenNV; }
            set { _txtTenNV = value; }
        }


        public QLKhachHang2_GUI()
        {
            InitializeComponent();
        }

        public void QLKhachHang2_GUI_Load(object sender, EventArgs e)
        {
            tblKH = kh_BUS.Display("SELECT KHACHHANG.MAKH,KHACHHANG.HOTEN,BIENSO,KHACHHANG.SODT,TENHANGXE,SOKM,SOKHUNG,KHACHHANG.DIACHI,COUNT(SOHD) AS SOLANSUA, SUM(TONGGIA) AS TONGTIENSUA " +
                "FROM KHACHHANG,HANGXE,HOADON " +
                "WHERE KHACHHANG.MAHANGXE = HANGXE.MAHANGXE AND KHACHHANG.MAKH = HOADON.MAKH " +
                "GROUP BY KHACHHANG.MAKH,KHACHHANG.HOTEN,BIENSO,KHACHHANG.SODT,TENHANGXE,SOKM,SOKHUNG,KHACHHANG.DIACHI ORDER BY MAKH ASC");

            DataGridKhachHang.DataSource = tblKH;
            DataGridKhachHang.AllowUserToAddRows = false;

            tblLX = hx_BUS.Display("SELECT * FROM HANGXE");
            txtLoaiXe.DataSource = tblLX;
            txtLoaiXe.DisplayMember = "TENHANGXE";
            txtLoaiXe.ValueMember = "TENHANGXE";

            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Chưa có khách hàng nào trong danh sách", "Thông Báo");
            }

        }

        private void DataGridKhachHang_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index == -1) index = 0;

            DataGridViewRow selectRowKhachHang = DataGridKhachHang.Rows[index];

            txtIDKH.Text = selectRowKhachHang.Cells["MAKH"].Value.ToString();
            txtTenKhachHang.Text = selectRowKhachHang.Cells["HOTEN"].Value.ToString();
            txtSDT.Text = selectRowKhachHang.Cells["SODT"].Value.ToString();
            txtBienSo.Text = selectRowKhachHang.Cells["BIENSO"].Value.ToString();
            txtSoKM.Text = selectRowKhachHang.Cells["SOKM"].Value.ToString();
            txtSoKhung.Text = DataGridKhachHang.CurrentRow.Cells["SOKHUNG"].Value.ToString();
            txtDiaChi.Text = selectRowKhachHang.Cells["DIACHI"].Value.ToString();
            txtLoaiXe.Text = selectRowKhachHang.Cells["HANGXE"].Value.ToString();
        }

        private void btnThem_Click(object sender, EventArgs e)
        {
            int IDHANGXE = hx_BUS.getMaHangXe(txtLoaiXe.Text);

            if (txtTenKhachHang.Text != "" && txtSDT.Text != "" && txtBienSo.Text != "")
            {
                KhachHang_DTO kh_DTO = new KhachHang_DTO(txtTenKhachHang.Text, txtSDT.Text,
                    txtBienSo.Text, IDHANGXE, txtDiaChi.Text, txtSoKM.Text, txtSoKhung.Text);

                if (kh_BUS.CheckTonTai(kh_DTO))
                {
                    if (kh_BUS.Insert(kh_DTO))
                    {
                        MessageBox.Show("Thêm thành công!");
                        QLKhachHang2_GUI_Load(sender, e);
                    }
                    else
                        MessageBox.Show("Thêm thất bại!");
                }
                else
                    MessageBox.Show("Khách hàng đã có!");
            }
            else
            {
                MessageBox.Show("Dữ liệu còn thiếu vui lòng điền lại!");
            }
        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            QLKhachHang2_GUI_Load(sender, e);
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            int blresult;
            blresult = 0;
            blresult = Convert.ToInt16(MessageBox.Show("Bạn có chắc chắn muốn xóa khách hàng này?", "Xoá khách hàng", MessageBoxButtons.OKCancel, MessageBoxIcon.Exclamation));
            if (blresult == 1)
            {
                if (kh_BUS.Delete(int.Parse(txtIDKH.Text)))
                {
                    MessageBox.Show("Xoá khách hàng thành công!");
                    QLKhachHang2_GUI_Load(sender, e);
                }
                else
                    MessageBox.Show("Xoá khách hàng không thể xoá vì khách hàng này đã có đã hoá đơn!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn lại khách hàng!");
            }
        }

        private void bunifuFlatButton2_Click(object sender, EventArgs e)
        {
            int IDHANGXE = hx_BUS.getMaHangXe(txtLoaiXe.Text);

            if (txtTenKhachHang.Text != "" && txtSDT.Text != "" && txtBienSo.Text != "")
            {
                KhachHang_DTO kh_DTO = new KhachHang_DTO(int.Parse(txtIDKH.Text),txtTenKhachHang.Text, txtSDT.Text,
                    txtBienSo.Text, IDHANGXE, txtDiaChi.Text, txtSoKM.Text, txtSoKhung.Text);

                   if (kh_BUS.Update(kh_DTO))
                    {
                        MessageBox.Show("Sửa thành công!");
                        QLKhachHang2_GUI_Load(sender, e);
                    }
                    else
                        MessageBox.Show("Sửa thất bại!");
            }
            else
            {
                MessageBox.Show("Dữ liệu còn thiếu vui lòng điền lại!");
            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tblKH = kh_BUS.Display("SELECT KHACHHANG.MAKH,KHACHHANG.HOTEN,BIENSO,KHACHHANG.SODT,TENHANGXE,SOKM,SOKHUNG,KHACHHANG.DIACHI,COUNT(SOHD) AS SOLANSUA, SUM(TONGGIA) AS TONGTIENSUA " +
                "FROM KHACHHANG,HANGXE,HOADON " +
                "WHERE KHACHHANG.MAHANGXE = HANGXE.MAHANGXE AND KHACHHANG.MAKH = HOADON.MAKH " 
                + "AND HOTEN LIKE N'%" + txtTimTen.Text + "%' AND BIENSO LIKE '%" + txtTimBienSo.Text + "%' AND SODT LIKE '%" + txtTimSDT.Text + "%' " +
                "GROUP BY KHACHHANG.MAKH,KHACHHANG.HOTEN,BIENSO,KHACHHANG.SODT,TENHANGXE,SOKM,SOKHUNG,KHACHHANG.DIACHI ORDER BY MAKH ASC");
            DataGridKhachHang.DataSource = tblKH;
            DataGridKhachHang.AllowUserToAddRows = false;

            if (tblKH.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy khách hàng", "Thông Báo");
            }
        }
    }
}
