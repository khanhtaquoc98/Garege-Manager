using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara_DTO
{
    public class Login_DTO
    {
        private string _TaiKhoan;
        private string _MatKhau;
        private int _MANV;

        public string TaiKhoan
        {
            get
            {
                return _TaiKhoan;
            }
            set
            {
                _TaiKhoan = value;
            }
        }

        public string MatKhau
        {
            get
            {
                return _MatKhau;
            }
            set
            {
                _MatKhau = value;
            }
        }

        public int MANV
        {
            get
            {
                return _MANV;
            }
            set
            {
                _MANV = value;
            }
        }

        public Login_DTO() { }

        public Login_DTO(string STaiKhoan, string SMatKhau)
        {
            this.TaiKhoan = STaiKhoan;
            this.MatKhau = SMatKhau;
        }

        public Login_DTO(string STaiKhoan, string SMatKhau, int SMANV)
        {
            this.TaiKhoan = STaiKhoan;
            this.MatKhau = SMatKhau;
            this.MANV = SMANV;
        }

    }
}
