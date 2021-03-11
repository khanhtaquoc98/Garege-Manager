using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara_DTO
{
    public class CTHD_DTO
    {
        private int _SOHD;
        private int _MASP;
        private int  _SL;
        private decimal _GIA;

        public int SOHD
        {
            get
            {
                return _SOHD;
            }
            set
            {
                _SOHD = value;
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

        public int SL
        {
            get
            {
                return _SL;
            }
            set
            {
                _SL = value;
            }
        }

        public decimal GIA
        {
            get
            {
                return _GIA;
            }
            set
            {
                _GIA = value;
            }
        }

        public CTHD_DTO() { }

        public CTHD_DTO(int SSOHD, int SMASP, int SSL, decimal SGIA)
        {
            this.SOHD = SSOHD;
            this.MASP = SMASP;
            this.SL = SSL;
            this.GIA = SGIA;
        }

    }
}
