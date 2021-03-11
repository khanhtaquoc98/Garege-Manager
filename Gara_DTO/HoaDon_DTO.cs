using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara_DTO
{
    public class HoaDon_DTO
    {
        private int _MAKH;
        private int _MANV;
        private int _MANVTV;
        private int _MANVKT;
        private string _TONGGIA;
        private string _NGSUA;
        private string _NGHD;

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

        public int MANVTV
        {
            get
            {
                return _MANVTV;
            }
            set
            {
                _MANVTV = value;
            }
        }

        public int MANVKT
        {
            get
            {
                return _MANVKT;
            }
            set
            {
                _MANVKT = value;
            }
        }

        public string TONGGIA
        {
            get
            {
                return _TONGGIA;
            }
            set
            {
                _TONGGIA = value;
            }
        }

        public string NGSUA
        {
            get
            {
                return _NGSUA;
            }
            set
            {
                _NGSUA = value;
            }
        }

        public string NGHD
        {
            get
            {
                return _NGHD;
            }
            set
            {
                _NGHD = value;
            }
        }


        public HoaDon_DTO() { }

        public HoaDon_DTO(int SMAKH, int SMANV, int SMANVTV, int SMANVKT, string STONGGIA, string SNGSUA, string SNGHD)
        {
            this.MAKH = SMAKH;
            this.MANV = SMANV;
            this.MANVTV = SMANVTV;
            this.MANVKT = SMANVKT;
            this.TONGGIA = STONGGIA;
            this.NGSUA = SNGSUA;
            this.NGHD = SNGHD;
        }
    }
}
