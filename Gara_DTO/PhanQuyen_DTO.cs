using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara_DTO
{
    public class PhanQuyen_DTO
    {
        private int _IDPhanQuyen;
        private string _Chuc;
        private string _LuongCung;

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

        public string Chuc
        {
            get
            {
                return _Chuc;
            }
            set
            {
                _Chuc = value;
            }
        }

        public string LuongCung
        {
            get
            {
                return _LuongCung;
            }
            set
            {
                _LuongCung = value;
            }
        }

        public PhanQuyen_DTO() { }

        public PhanQuyen_DTO(string SChuc, string SLuongCung)
        {
            this.LuongCung = SLuongCung;
            this.Chuc = SChuc;
        }
    }
}
