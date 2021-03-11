using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara_DTO
{
    public class NhanVien_DTO
    {
        private int _MANV;
        private int _IDPQ;
        private string _HOTEN;
        private string _SODT;
        private string _DIACHI;
        private string _NGVL;


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

        public int IDPQ
        {
            get
            {
                return _IDPQ;
            }
            set
            {
                _IDPQ = value;
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

        public string NGVL
        {
            get
            {
                return _NGVL;
            }
            set
            {
                _NGVL = value;
            }
        }

        public NhanVien_DTO() { }

        public NhanVien_DTO(int SIDPQ, string SHOTEN, string SSODT,string SDIACHI, string SNGVL)
        {
            this.IDPQ = SIDPQ;
            this.HOTEN = SHOTEN;
            this.SODT = SSODT;
            this.DIACHI = SDIACHI;
            this.NGVL = NGVL;
        }

        public NhanVien_DTO(int SIDNV, int SIDPQ, string SHOTEN, string SSODT,string SDIACHI, string SNGVL)
        {
            this.MANV = SIDNV;
            this.IDPQ = SIDPQ;
            this.HOTEN = SHOTEN;
            this.SODT = SSODT;
            this.DIACHI = SDIACHI;
            this.NGVL = NGVL;
        }
    }
}
