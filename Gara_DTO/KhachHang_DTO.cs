using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara_DTO
{
    public class KhachHang_DTO
    {
        private int _MAKH;
        private string _HOTEN;
        private string _SODT;
        private string _BIENSO;
        private int _MAHANGXE;
        private string _DIACHI;
        private string _SOKM;
        private string _SOKHUNG;

        public int MAKH
        {
            get
            {
                return _MAKH;
            }
            set
            {
                _MAKH = value;
            }
        }

        public string HOTEN
        {
            get
            {
                return _HOTEN;
            }
            set
            {
                _HOTEN = value;
            }
        }

        public string SODT
        {
            get
            {
                return _SODT;
            }
            set
            {
                _SODT = value;
            }
        }

        public string BIENSO
        {
            get
            {
                return _BIENSO;
            }
            set
            {
                _BIENSO = value;
            }
        }

        public int MAHANGXE
        {
            get
            {
                return _MAHANGXE;
            }
            set
            {
                _MAHANGXE = value;
            }
        }

        public string DIACHI
        {
            get
            {
                return _DIACHI;
            }
            set
            {
                _DIACHI = value;
            }
        }

        public string SOKM
        {
            get
            {
                return _SOKM;
            }
            set
            {
                _SOKM = value;
            }
        }

        public string SOKHUNG
        {
            get
            {
                return _SOKHUNG;
            }
            set
            {
                _SOKHUNG = value;
            }
        }

        public KhachHang_DTO() { }

        public KhachHang_DTO(string SHoTen, string SSoDT, string SBienSo, int SMaHangXe, string SDiaChi, string SSoKM, string SSoKhung)
        {
            this.HOTEN = SHoTen;
            this.SODT = SSoDT;
            this.BIENSO = SBienSo;
            this.MAHANGXE = SMaHangXe;
            this.DIACHI = SDiaChi;
            this.SOKM = SSoKM;
            this._SOKHUNG = SSoKhung;
        }

        public KhachHang_DTO(int ID, string SHoTen, string SSoDT, string SBienSo, int SMaHangXe, string SDiaChi, string SSoKM, string SSoKhung)
        {
            this.MAKH = ID;
            this.HOTEN = SHoTen;
            this.SODT = SSoDT;
            this.BIENSO = SBienSo;
            this.MAHANGXE = SMaHangXe;
            this.DIACHI = SDiaChi;
            this.SOKM = SSoKM;
            this._SOKHUNG = SSoKhung;
        }
    }
}
