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

    public partial class QLNV_GUI : UserControl
    {
        private static QLNV_GUI _instance;
        private string _Ten;
        CTNV_BUS ctnv_BUS = new CTNV_BUS();
        NhanVien_BUS nv_BUS = new NhanVien_BUS();
        Login_BUS lg_BUS = new Login_BUS();
        DataTable tblChucVu = new DataTable();
        DataTable tblTK = new DataTable();
        DataTable tblNV = new DataTable();

        public string Ten
        {
            get { return _Ten; }
            set { _Ten = value; }
        }

        public static QLNV_GUI Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new QLNV_GUI();
                return _instance;
            }
        }

        public QLNV_GUI()
        {
            InitializeComponent();
        }

        private void QLNV_GUI_Load(object sender, EventArgs e)
        {
            LoadNV();
            LoadChucVu();
            LoadTaiKhoan();
            LoadLuong();
        }

        private void LoadNV()
        {
            tblNV = nv_BUS.Display("SELECT MANV,HOTEN,SODT,DIACHI,NGVL,Chuc FROM NhanVien,CTNV WHERE NhanVien.IDPhanQuyen = CTNV.IDPhanQuyen AND CTNV.IDPhanQuyen!=1 ORDER BY Chuc");
            DataNV.DataSource = tblNV;
            DataNV.AllowUserToAddRows = false;

            txtChucVuNV.DataSource = nv_BUS.Display("SELECT DISTINCT Chuc FROM CTNV WHERE CTNV.IDPhanQuyen!=1");
            txtChucVuNV.DisplayMember = "Chuc";
            txtChucVuNV.ValueMember = "Chuc";

            txtTimCV.DataSource = nv_BUS.Display("SELECT DISTINCT Chuc FROM CTNV WHERE CTNV.IDPhanQuyen!=1");
            txtTimCV.DisplayMember = "Chuc";
            txtTimCV.ValueMember = "Chuc";

     
        }

        private void LoadTaiKhoan()
        {
            tblTK = ctnv_BUS.Display("SELECT DANGNHAP.MANV,HOTEN,TaiKhoan,MatKhau FROM DANGNHAP,NHANVIEN WHERE DangNhap.MANV = NHANVIEN.MANV");
            DataTaiKhoan.DataSource = tblTK;
            DataTaiKhoan.AllowUserToAddRows = false;
        }


        private void LoadLuong()
        {
           
        }

        private void LoadChucVu()
        {
            tblChucVu = ctnv_BUS.Display("SELECT * FROM CTNV WHERE IDPHANQUYEN != 1");
            DataChuc.DataSource = tblChucVu;
            DataChuc.AllowUserToAddRows = false;
        }



        private void DataChuc_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index == -1) index = 0;

            DataGridViewRow selectRow = DataChuc.Rows[index];
            txtIDChucVu.Text = selectRow.Cells["ID"].Value.ToString();
            txtTenChucVu.Text = selectRow.Cells["Chuc"].Value.ToString();
        }

        private void btnThemCV_Click(object sender, EventArgs e)
        {
            CTNV_DTO kh_DTO = new CTNV_DTO(txtTenChucVu.Text);

            if (ctnv_BUS.Insert(kh_DTO))
            {
                MessageBox.Show("Thêm thành công!");
                LoadChucVu();
            }
            else
                MessageBox.Show("Thêm thất bại!");
        }

        private void btnXoaCV_Click(object sender, EventArgs e)
        {
            if (txtIDChucVu.Text != "")
            {
                if (ctnv_BUS.Delete(int.Parse(txtIDChucVu.Text)))
                {
                    MessageBox.Show("Xoá thành công!");
                    LoadChucVu();
                }
                else
                    MessageBox.Show("Xoá thất bại!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu!");
            }
        }

        private void btnSuaCV_Click(object sender, EventArgs e)
        {
            if (txtIDChucVu.Text != "")
            {
                CTNV_DTO kh_DTO = new CTNV_DTO(int.Parse(txtIDChucVu.Text), txtTenChucVu.Text);
                if (ctnv_BUS.Update(kh_DTO))
                {
                    MessageBox.Show("Sửa thành công!");
                    LoadChucVu();
                }
                else
                    MessageBox.Show("Sửa thất bại!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu!");
            }
        }

        private void btnTimKiemChucVu_Click(object sender, EventArgs e)
        {
            tblChucVu = ctnv_BUS.Display("SELECT * FROM CTNV WHERE IDPHANQUYEN != 1 AND Chuc LIKE N'%" + txtTimTenChucVu.Text + "%'");
            DataChuc.DataSource = tblChucVu;
            DataChuc.AllowUserToAddRows = false;

            if (tblChucVu.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy", "Thông Báo");
            }
        }

        private void btnReloadChucVu_Click(object sender, EventArgs e)
        {
            LoadChucVu();
        }

        private void BTNThemNV_Click(object sender, EventArgs e)
        {
            int IDPQ = ctnv_BUS.GetIDPQ(txtChucVuNV.Text);
            string NGVL = DateTime.Now.ToString("yyyy/MM/dd");

            NhanVien_DTO kh_DTO = new NhanVien_DTO(IDPQ, txtTenNV.Text, txtSDTNV.Text,txtDCNV.Text,NGVL);
            if (nv_BUS.Insert(kh_DTO))
            {
                if(IDPQ <= 2)
                {
                    int manv = nv_BUS.getMANV(kh_DTO.HOTEN);
                    Login_DTO lg_DTO = new Login_DTO(kh_DTO.HOTEN, "1", manv);
                    if(lg_BUS.Insert(lg_DTO))
                    {
                        MessageBox.Show("Thêm thành công!");
                        LoadNV();
                        LoadTaiKhoan();
                    } else
                        MessageBox.Show("Thêm thất bại!");
                } else
                {
                    MessageBox.Show("Thêm thành công!");
                    LoadNV();
                }                
            }
            else
                MessageBox.Show("Thêm thất bại!");

        }

        private void btnXoaNV_Click(object sender, EventArgs e)
        {
            int IDPQ = ctnv_BUS.GetIDPQ(txtChucVuNV.Text);

            if (txtIDNV.Text != "")
            {
                if(IDPQ <=2)
                {
                    if (lg_BUS.Delete(int.Parse(txtIDNV.Text)))
                    {
                        LoadTaiKhoan();
                        if (nv_BUS.Delete(int.Parse(txtIDNV.Text)))
                        {
                            MessageBox.Show("Xoá thành công!");
                            LoadNV();
                        }
                        else
                            MessageBox.Show("Xoá thất bại 2!");
                    }
                    else
                        MessageBox.Show("Xoá thất bại 1!");
                }
                 else
                {
                    if (nv_BUS.Delete(int.Parse(txtIDNV.Text)))
                    {
                        MessageBox.Show("Xoá thành công!");
                        LoadNV();
                    }
                    else
                        MessageBox.Show("Xoá thất bại 2!");
                }
               
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu!");
            }
        }

        private void btnSuaNV_Click(object sender, EventArgs e)
        {
            int IDPQ = ctnv_BUS.GetIDPQ(txtChucVuNV.Text);
            string NGVL = DateTime.Now.ToString("yyyy/MM/dd");
            int IDPQtrc = nv_BUS.getIDPQIDNV(int.Parse(txtIDNV.Text));

            if (txtIDNV.Text != "")
            {
                NhanVien_DTO kh_DTO = new NhanVien_DTO(int.Parse(txtIDNV.Text), IDPQ, txtTenNV.Text, txtSDTNV.Text, txtDCNV.Text, NGVL);

                if (IDPQ == IDPQtrc)
                {
                    if (nv_BUS.Update(kh_DTO))
                    {
                        MessageBox.Show("Sửa thành công!");
                        LoadNV();
                        LoadTaiKhoan();
                    }
                    else MessageBox.Show("Sửa thất bại!");
                }
                else
                {
                    if (IDPQtrc == 2)
                    {
                        if (nv_BUS.Update(kh_DTO))
                        {
                            if (lg_BUS.Delete(int.Parse(txtIDNV.Text)))
                            {
                                MessageBox.Show("Sửa thành công!");
                                LoadNV();
                                LoadTaiKhoan();
                            }
                            else
                                MessageBox.Show("Sửa thất bại!");
                        }
                        else MessageBox.Show("Sửa thất bại!");
                    }
                    else
                    {
                        if (nv_BUS.Update(kh_DTO))
                        {
                            Login_DTO lg_DTO = new Login_DTO(kh_DTO.HOTEN, "1", kh_DTO.MANV);
                            if (lg_BUS.Insert(lg_DTO))
                            {
                                MessageBox.Show("Sửa thành công!");
                                LoadNV();
                                LoadTaiKhoan();
                            }
                            else
                                MessageBox.Show("Sửa thất bại!");
                        }
                        else MessageBox.Show("Sửa thất bại!");
                    }
                }
            }
            else
                MessageBox.Show("Vui lòng chọn dữ liệu!");

        }

        private void DataNV_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index == -1) index = 0;

            DataGridViewRow selectRow = DataNV.Rows[index];
            txtIDNV.Text = selectRow.Cells["MANV"].Value.ToString();
            txtTenNV.Text = selectRow.Cells["HoTen"].Value.ToString();
            txtSDTNV.Text = selectRow.Cells["SODT"].Value.ToString();
            txtDCNV.Text = selectRow.Cells["DIACHI"].Value.ToString();
            txtChucVuNV.Text = selectRow.Cells["CHUCVU"].Value.ToString();

        }

        private void btnTimKiemNV_Click(object sender, EventArgs e)
        {
            tblNV = nv_BUS.Display("SELECT MANV,HOTEN,SODT,DIACHI,NGVL,Chuc FROM NhanVien,CTNV WHERE NhanVien.IDPhanQuyen = CTNV.IDPhanQuyen AND CTNV.IDPhanQuyen!=1 " +
                "AND HOTEN LIKE N'%" + txtTimTenNV.Text + "%' AND Chuc LIKE N'%" + txtTimCV.Text + "%'");
            DataNV.DataSource = tblNV;
            DataNV.AllowUserToAddRows = false;

            if (tblNV.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy", "Thông Báo");
            }
        }

        private void btnReloadNV_Click(object sender, EventArgs e)
        {
            LoadNV();
        }

        private void btnSuaTK_Click(object sender, EventArgs e)
        {
            if (txtIDNVTK.Text != "")
            {
                Login_DTO lg_DTO = new Login_DTO(txtTK.Text, txtMK.Text, int.Parse(txtIDNVTK.Text));
                if (lg_BUS.Update(lg_DTO))
                {
                    MessageBox.Show("Sửa thành công!");
                    LoadTaiKhoan();
                }
                else
                    MessageBox.Show("Sửa thất bại!");
            }
            else
            {
                MessageBox.Show("Vui lòng chọn dữ liệu!");
            }
        }
       

        private void btnTimKiemTK_Click(object sender, EventArgs e)
        {
            tblTK = nv_BUS.Display("SELECT DANGNHAP.MANV,HOTEN,TaiKhoan,MatKhau FROM DANGNHAP,NHANVIEN WHERE DangNhap.MANV = NHANVIEN.MANV AND HOTEN LIKE N'%" + txtTimTenNVTK.Text + "%'");
            DataTaiKhoan.DataSource = tblTK;
            DataTaiKhoan.AllowUserToAddRows = false;

            if (tblTK.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy", "Thông Báo");
            }
        }

        private void btnReloadTK_Click(object sender, EventArgs e)
        {
            LoadTaiKhoan();
        }

        private void DataTaiKhoan_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index == -1) index = 0;

            DataGridViewRow selectRow = DataTaiKhoan.Rows[index];
            txtIDNVTK.Text = selectRow.Cells["SMANV"].Value.ToString();
            txtTenNVTK.Text = selectRow.Cells["SHoTen"].Value.ToString();
            txtTK.Text = selectRow.Cells["TaiKhoan"].Value.ToString();
            txtMK.Text = selectRow.Cells["MatKhau"].Value.ToString();

        }
    }
}
