using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara_DTO
{
    public class SanPham_DTO
    {
        private int _MASP;
        private string _TENSP;
        private int    _SOLUONG;
        private string _GIANHAP;
        private string _GIABAN;
        private string _DONVI;
        private string _LOAI;

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

        public string TENSP
        {
            get
            {
                return _TENSP;
            }
            set
            {
                _TENSP = value;
            }
        }

        public int SOLUONG
        {
            get
            {
                return _SOLUONG;
            }
            set
            {
                _SOLUONG = value;
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

        public string GIABAN
        {
            get
            {
                return _GIABAN;
            }
            set
            {
                _GIABAN = value;
            }
        }

        public string DONVI
        {
            get
            {
                return _DONVI;
            }
            set
            {
                _DONVI = value;
            }
        }

        public string LOAI
        {
            get
            {
                return _LOAI;
            }
            set
            {
                _LOAI = value;
            }
        }

        public SanPham_DTO() { }

        public SanPham_DTO( string STENSP, int SSOLUONG,
          string SGIANHAP, string SGIABAN, string SDONVI, string SLOAI)
        {
            this.TENSP = STENSP;
            this.SOLUONG = SSOLUONG;
            this.GIABAN = SGIABAN;
            this.GIANHAP = SGIANHAP;
            this.DONVI = SDONVI;
            this.LOAI = SLOAI;
        }

        public SanPham_DTO(int MASP, string STENSP, int SSOLUONG, 
            string SGIANHAP, string SGIABAN, string SDONVI, string SLOAI)
        {
            this.MASP = MASP;
            this.TENSP = STENSP;
            this.SOLUONG = SSOLUONG;
            this.GIABAN = SGIABAN;
            this.GIANHAP = SGIANHAP;
            this.DONVI = SDONVI;
            this.LOAI = SLOAI;
        }
    }
}
