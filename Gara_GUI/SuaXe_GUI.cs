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
    public partial class SuaXe_GUI : UserControl
    {
        NhanVien_BUS nv_BUS = new NhanVien_BUS();
        KhachHang_BUS kh_BUS = new KhachHang_BUS();
        HoaDon_BUS hd_BUS = new HoaDon_BUS();
        CTHD_BUS cthd_BUS = new CTHD_BUS();
        SanPham_BUS sp_BUS = new SanPham_BUS();

        DataTable tblHD = new DataTable();
        DataTable tblNVTV = new DataTable();
        DataTable tblNVKT = new DataTable();
        DataTable tblSP = new DataTable();
        DataTable tblCTHD = new DataTable();

        private static SuaXe_GUI _instance;
        private string _txtIDKH;
        private string _txtTenKhachHang;
        private string _txtBienSo;
        private string _txtSDT;
        private string _txtLoaiXe;
        private string _txtSoKM;
        private string _txtSoKhung;
        private string _txtDiaChi;
        private string _txtTenNV;

        public static SuaXe_GUI Instance
        {
            get
            {
                if (_instance == null)
                    _instance = new SuaXe_GUI();
                return _instance;
            }
        }

        public string IDKH
        {
            get { return _txtIDKH; }
            set { _txtIDKH = value; }
        }
        public string TKH
        {
            get { return _txtTenKhachHang; }
            set { _txtTenKhachHang = value; }
        }
        public string BS
        {
            get { return _txtBienSo; }
            set { _txtBienSo = value; }
        }
        public string SDT
        {
            get { return _txtSDT; }
            set { _txtSDT = value; }
        }
        public string LX
        {
            get { return _txtLoaiXe; }
            set { _txtLoaiXe = value; }
        }
        public string KM
        {
            get { return _txtSoKM; }
            set { _txtSoKM = value; }
        }
        public string SK
        {
            get { return _txtSoKhung; }
            set { _txtSoKhung = value; }
        }
        public string DC
        {
            get { return _txtDiaChi; }
            set { _txtDiaChi = value; }
        }

        public string TenNV
        {
            get { return _txtTenNV; }
            set { _txtTenNV = value; }
        }

        public SuaXe_GUI()
        {
            InitializeComponent();         
        }

        public void SuaXe_GUI_Load(object sender, EventArgs e)
        {
            tblHD = kh_BUS.Display("SELECT SOHD,NGSUA,NGHD,HOADON.TongGia,KHACHHANG.HOTEN,TENHANGXE,KHACHHANG.SODT,KHACHHANG.DIACHI,BIENSO,SOKM,SOKHUNG, MANVKT, MANVTV " +
                "FROM HOADON, KHACHHANG, HANGXE, NHANVIEN " +
                "WHERE HOADON.MAKH = KHACHHANG.MAKH AND  KHACHHANG.MAHANGXE = HANGXE.MAHANGXE AND HOADON.MANVTV = NHANVIEN.MANV AND HOADON.NGHD IS NULL");
            DataGridHD.DataSource = tblHD;
            DataGridHD.AllowUserToAddRows = false;

            if (DataGridHD.RowCount != 0)
            {
                DataGridHD.CurrentCell = DataGridHD[0, DataGridHD.RowCount - 1];
                txtIDHD.Text = DataGridHD.CurrentRow.Cells["IDHD"].Value.ToString();
            }
            else
                txtIDHD.Text = "1";

            txtIDKH.Text = _txtIDKH;
            txtTenKhachHang.Text = _txtTenKhachHang;
            txtBienSo.Text = _txtBienSo;
            txtSDT.Text = _txtBienSo;
            txtLoaiXe.Text = _txtLoaiXe;
            txtSoKM.Text = _txtSoKM;
            txtSoKhung.Text = _txtSoKhung;
            txtDiaChi.Text = _txtDiaChi;
            txtNgaySua.Value = DateTime.Now;

            tblNVTV = nv_BUS.Display("SELECT HOTEN FROM NHANVIEN,CTNV WHERE CTNV.IDPHANQUYEN = NHANVIEN.IDPHANQUYEN AND CTNV.CHUC = 'NVTV'");
            txtNVTV.DataSource = tblNVTV;
            txtNVTV.DisplayMember = "HOTEN";
            txtNVTV.ValueMember = "HOTEN";

            tblNVKT = nv_BUS.Display("SELECT HOTEN FROM NHANVIEN,CTNV WHERE CTNV.IDPHANQUYEN = NHANVIEN.IDPHANQUYEN AND CTNV.CHUC = 'NVKT'");
            txtNVKT.DataSource = tblNVKT;
            txtNVKT.DisplayMember = "HOTEN";
            txtNVKT.ValueMember = "HOTEN";
            loadSP();

            
            if (txtTenKhachHang.Text != "")
            {
                btnGhiPhieu.Enabled = true;
                btnXoaHD.Enabled = true;
            }                
        }

        private void DataGridHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            btnXoaHD.Enabled = true;
            btnThemLinhKien.Enabled = true;
            btnXuat.Enabled = true;
            btnGhiPhieu.Enabled = true;

            int index = e.RowIndex;
            if (index == -1) index = 0;
           
            btnGhiPhieu.Enabled = false;
            DataGridViewRow selectRowKhachHang = DataGridHD.Rows[index];     
            txtIDHD.Text = selectRowKhachHang.Cells["IDHD"].Value.ToString();
            txtTenKhachHang.Text = selectRowKhachHang.Cells["HOTEN"].Value.ToString();
            txtSDT.Text = selectRowKhachHang.Cells["SODT"].Value.ToString();
            txtBienSo.Text = selectRowKhachHang.Cells["BIENSO"].Value.ToString();
            txtSoKM.Text = selectRowKhachHang.Cells["SOKM"].Value.ToString();
            txtIDKH.Text = kh_BUS.getIDKH(txtBienSo.Text).ToString();
            txtDiaChi.Text = selectRowKhachHang.Cells["DIACHI"].Value.ToString();
            txtLoaiXe.Text = selectRowKhachHang.Cells["HANGXE"].Value.ToString();
            txtNgaySua.Value = DateTime.Parse(selectRowKhachHang.Cells["NGSUA"].Value.ToString());
            txtNVTV.Text = nv_BUS.getTenNV(selectRowKhachHang.Cells["NVTV"].Value.ToString());
            txtNVKT.Text = nv_BUS.getTenNV(selectRowKhachHang.Cells["NVKT"].Value.ToString());
            loadCTHD();

        }

        private void btnGhiPhieu_Click(object sender, EventArgs e)
        {   
            if(txtIDKH.Text == "" || txtTenKhachHang.Text == "")
            {
                MessageBox.Show("Vui lòng chọn lại khách hàng hoặc thêm khách hàng mới!");
                SuaXe_GUI.Instance.SendToBack();
                QLKhachHang_GUI.Instance.BringToFront();              
            } else
            {
                int IDKH = int.Parse(txtIDKH.Text);
                int MANVTV = nv_BUS.getMANV(txtNVTV.Text);
                int MANVKT = nv_BUS.getMANV(txtNVKT.Text);
                int MANV = nv_BUS.getMANV(_txtTenNV);
                string NgSua = txtNgaySua.Value.Date.ToString("yyyy/MM/dd");

                HoaDon_DTO hd_DTO = new HoaDon_DTO(IDKH, MANV, MANVTV, MANVKT, null, NgSua, null);

                if (hd_BUS.Insert(hd_DTO))
                {
                    MessageBox.Show("Thêm thành công!");
                    btnThemLinhKien.Enabled = true;
                    btnXuat.Enabled = true;
                    SuaXe_GUI_Load(sender, e);
                }
                else
                    MessageBox.Show("Thêm thất bại!");
            }
         
        }

        private void loadSP()
        {
            tblSP = sp_BUS.Display("SELECT * FROM SANPHAM ORDER BY LOAI ");

            txtTenSanPham.DataSource = tblSP;
            txtTenSanPham.DisplayMember = "TENSP";
            txtTenSanPham.ValueMember = "TENSP";

            txtGiaBan.DataSource = tblSP;
            txtGiaBan.DisplayMember = "GiaBan";
            txtGiaBan.ValueMember = "GiaBan";

            txtDonVi.DataSource = tblSP;
            txtDonVi.DisplayMember = "DonVi";
            txtDonVi.ValueMember = "DonVi";

            txtLoai.DataSource = tblSP;
            txtLoai.DisplayMember = "Loai";
            txtLoai.ValueMember = "Loai";

            txtTonKho.DataSource = tblSP;
            txtTonKho.DisplayMember = "SoLuong";
            txtTonKho.ValueMember = "SoLuong";

        }

        private void txtSoLuong_ValueChanged(object sender, EventArgs e)
        {
                double ThanhTien = (double)txtSoLuong.Value * double.Parse(txtGiaBan.Text);
                txtThanhTien.Text = ThanhTien.ToString();                    
        }

        private void loadCTHD()
        {
            tblCTHD = hd_BUS.Display("SELECT TENSP,SL,DONVI,LOAI,GIACTHD FROM CTHD,SANPHAM WHERE CTHD.MASP = SANPHAM.MASP AND CTHD.SOHD =" + int.Parse(txtIDHD.Text));
            DataGridCTHD.DataSource = tblCTHD;
            DataGridCTHD.AllowUserToAddRows = false;

            decimal tonggia = cthd_BUS.TongGia(int.Parse(txtIDHD.Text));
            txtTongTien.Text = tonggia.ToString();
        }

        private void btnThemLinhKien_Click(object sender, EventArgs e)
        {
            int MASP = sp_BUS.getMASP(txtTenSanPham.Text);
            int MAHD = int.Parse(txtIDHD.Text);
            int SL = int.Parse(txtSoLuong.Text);

            decimal Gia = decimal.Parse(txtThanhTien.Text);

            int _SL = cthd_BUS.GetSL(MAHD, MASP) + SL;
            decimal _GiaTien = cthd_BUS.GetTien(MAHD, MASP) + Gia;

            CTHD_DTO cthd_DTO = new CTHD_DTO(MAHD, MASP, SL, Gia);

            if(txtLoai.Text != "Phụ tùng")
            {
                if (cthd_BUS.Insert(cthd_DTO))
                {
                    loadCTHD();
                    loadSP();
                }
                else
                {
                    if (cthd_BUS.Update(MAHD, MASP, _SL, _GiaTien))
                    {
                        loadCTHD();
                        loadSP();
                    }
                    else MessageBox.Show("Thêm thất bại!");
                }
            } else
            {
                int SLKho = int.Parse(txtTonKho.Text);
                if (SL <= SLKho)
                {
                    if (cthd_BUS.Insert(cthd_DTO))
                    {
                        loadCTHD();
                        UpdateSLKho(MASP, -SL);
                        loadSP();
                    }
                    else
                    {
                        if (cthd_BUS.Update(MAHD, MASP, _SL, _GiaTien))
                        {
                            loadCTHD();
                            UpdateSLKho(MASP, -SL);
                            loadSP();
                        }
                        else MessageBox.Show("Thêm thất bại!");
                    }
                }
                else MessageBox.Show("Không đủ hàng trong kho!");
            }     
        
        }

        private void txtTenSanPham_TextChanged(object sender, EventArgs e)
        {
            txtSoLuong.Value = 0;
        }

        private void btnDeleteCTHD_Click(object sender, EventArgs e)
        {

            int SL = int.Parse(txtSoLuong.Text);
            int MASP = sp_BUS.getMASP(txtTenSanPham.Text);
            int MAHD = int.Parse(txtIDHD.Text);
            if (txtLoai.Text != "Phụ tùng")
            {
                if (cthd_BUS.Delete(MAHD, MASP))
                {
                    loadCTHD();
                    loadSP();
                    btnDeleteCTHD.Enabled = false;
                }
                else
                    MessageBox.Show("Xoá thất bại!");
            }
            else
            {
                int SLKho = int.Parse(txtTonKho.Text);
                if (cthd_BUS.Delete(MAHD, MASP))
                {
                    loadCTHD();
                    UpdateSLKho(MASP, +SL);
                    loadSP();
                    btnDeleteCTHD.Enabled = false;
                }
                else
                    MessageBox.Show("Xoá thất bại!");
            }
                
        }

        private void DataGridCTHD_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int index = e.RowIndex;
            if (index == -1) index = 0;

            DataGridViewRow selectRowCTHD = DataGridCTHD.Rows[index];
            txtTenSanPham.Text = selectRowCTHD.Cells["DV"].Value.ToString();
            txtSoLuong.Value = decimal.Parse(selectRowCTHD.Cells["SL"].Value.ToString());
            txtDonVi.Text = selectRowCTHD.Cells["DONVI"].Value.ToString();
            txtLoai.Text = selectRowCTHD.Cells["LOAI"].Value.ToString();
            txtThanhTien.Text = selectRowCTHD.Cells["Gia"].Value.ToString();
            btnDeleteCTHD.Enabled = true;
        }

        private void UpdateSLKho(int MASP, int SL)
        {
            sp_BUS.UpdateSL(MASP,SL);
        }

        private void btnXoaHD_Click(object sender, EventArgs e)
        {
            int MAHD = int.Parse(txtIDHD.Text);
            if (hd_BUS.Delete(MAHD))
            {
                SuaXe_GUI_Load(sender, e);
                MessageBox.Show("Xoá thành công!");
            }
            else
                MessageBox.Show("Xoá thất bại!");
        }

        private void btnXuat_Click(object sender, EventArgs e)
        {
            int MAHD = int.Parse(txtIDHD.Text);
            string NgXuat = DateTime.Now.ToString("yyyy/MM/dd");
            string TongTien = txtTongTien.Text;
           

            if (comboBox2.Text == "Báo giá")
            {
                if (hd_BUS.UpdateTongTien(MAHD, TongTien))
                {
                    SuaXe_GUI_Load(sender, e);
                    BaoGia BG = new BaoGia();
                    BG.IDHD = MAHD;
                    BG.Show();
                }
                else
                     MessageBox.Show("Xảy ra lỗi vui lòng kiểm tra lại!");
            }

            if (comboBox2.Text == "Hoá đơn")
            {
                if (hd_BUS.UpdateNgayHD(MAHD, NgXuat))
                {
                    SuaXe_GUI_Load(sender, e);
                    HoaDon HD = new HoaDon();
                    HD.IDHD = MAHD;
                    HD.Show();
                }
                else
                    MessageBox.Show("Xảy ra lỗi vui lòng kiểm tra lại!");

            }
        }

        private void btnTimKiem_Click(object sender, EventArgs e)
        {
            tblHD = kh_BUS.Display("SELECT SOHD,NGSUA,NGHD,HOADON.TongGia,KHACHHANG.HOTEN,TENHANGXE,KHACHHANG.SODT,KHACHHANG.DIACHI,BIENSO,SOKM,SOKHUNG, MANVKT, MANVTV " +
               "FROM HOADON, KHACHHANG, HANGXE, NHANVIEN " +
               "WHERE HOADON.MAKH = KHACHHANG.MAKH AND  KHACHHANG.MAHANGXE = HANGXE.MAHANGXE AND HOADON.MANVTV = NHANVIEN.MANV AND HOADON.NGHD IS NULL " +
               "AND KHACHHANG.HOTEN LIKE N'%" + txtTimTen.Text + "%' AND BIENSO LIKE '%" + txtTimBienSo.Text + "%' AND KHACHHANG.SODT LIKE '%" + txtTimSDT.Text + "%' "+
               "ORDER BY SOHD ASC");
            DataGridHD.DataSource = tblHD;
            DataGridHD.AllowUserToAddRows = false;

            if (tblHD.Rows.Count == 0)
            {
                MessageBox.Show("Không tìm thấy", "Thông Báo");
            }
        }

        private void bunifuFlatButton1_Click(object sender, EventArgs e)
        {
            SuaXe_GUI_Load(sender, e);
        }

        private void btnTroLai_Click(object sender, EventArgs e)
        {
            SuaXe_GUI.Instance.SendToBack();
            QLKhachHang_GUI.Instance.BringToFront();
        }
    }
}
