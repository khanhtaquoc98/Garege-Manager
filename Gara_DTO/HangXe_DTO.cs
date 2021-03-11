using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara_DTO
{
    public class HangXe_DTO
    {
        private string _TENHANGXE;
        private int _MAHANGXE;

        public string TENHANGXE
        {
            get
            {
                return _TENHANGXE;
            }
            set
            {
                _TENHANGXE = value;
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

        public HangXe_DTO() { }

        public HangXe_DTO(string STENHANGXE)
        {
            this.TENHANGXE = STENHANGXE;
        }

        public HangXe_DTO(int SMAHANGXE, string STENHANGXE)
        {
            this.MAHANGXE = SMAHANGXE;
            this.TENHANGXE = STENHANGXE;
        }
    }
}
