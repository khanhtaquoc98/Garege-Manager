using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara_DTO
{
    public class CTNV_DTO
    {
        private int _IDPhanQuyen;
        private string _ChucVu;

        public int IDPhanQuyen
        {
            get
            {
                return _IDPhanQuyen;
            }
            set
            {
                _IDPhanQuyen = value;
            }
        }

        public string ChucVu
        {
            get
            {
                return _ChucVu;
            }
            set
            {
                _ChucVu = value;
            }
        }

        public CTNV_DTO() { }

        public CTNV_DTO(string SChucVu)
        {
            this.ChucVu = SChucVu;
        }

        public CTNV_DTO(int SIDPhanQuyen, string SChucVu)
        {
            this.IDPhanQuyen = SIDPhanQuyen;
            this.ChucVu = SChucVu;
        }

    }
}
