using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara_DTO
{
    public class NhapKho_DTO
    {
        private int _MANHAPKHO;
        private string _NGAYNHAP;
        private int _MASP;
        private int _SLNHAP;
        private int _NGNHAP;
        private string _GIANHAP;

        public int MANHAPKHO
        {
            get
            {
                return _MANHAPKHO;
            }
            set
            {
                _MANHAPKHO = value;
            }
        }

        public int MASP
        {
            get
            {
                return _MASP;
            }
            set
            {
                _MASP = value;
            }
        }


        public int NGNHAP
        {
            get
            {
                return _NGNHAP;
            }
            set
            {
                _NGNHAP = value;
            }
        }

        public int SLNHAP
        {
            get
            {
                return _SLNHAP;
            }
            set
            {
                _SLNHAP = value;
            }
        }

        public string NGAYNHAP
        {
            get
            {
                return _NGAYNHAP;
            }
            set
            {
                _NGAYNHAP = value;
            }
        }

        public string GIANHAP
        {
            get
            {
                return _GIANHAP;
            }
            set
            {
                _GIANHAP = value;
            }
        }

        public NhapKho_DTO() { }

        public NhapKho_DTO(string SNgayNhap, int SMaSP,int SNGNHAP, int SSLNhap, string SGiaNhap)
        {
            this.NGAYNHAP = SNgayNhap;
            this.MASP = SMaSP;
            this.NGNHAP = SNGNHAP;
            this.SLNHAP = SSLNhap;
            this.GIANHAP = SGiaNhap;
        }

    }
}
