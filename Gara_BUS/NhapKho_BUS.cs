using Gara_DAL;
using Gara_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara_BUS
{
    public class NhapKho_BUS
    {
        NhapKho_DAL sp_dal = new NhapKho_DAL();

        public DataTable Display(string sql)
        {
            return sp_dal.Display(sql);
        }

        public bool Insert(NhapKho_DTO NK)
        {
            return sp_dal.Insert(NK);
        }

        public bool UpdateSLNK(NhapKho_DTO NK)
        {
            return sp_dal.UpdateSLNK(NK);
        }

        public bool checkSPNhap(int MASP, string NgayNhap, int NgNhap)
        {
            return sp_dal.CheckSPNhap(MASP, NgayNhap , NgNhap);
        }
    }
}
