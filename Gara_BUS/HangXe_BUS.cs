using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gara_DAL;
using Gara_DTO;
using System.Data;

namespace Gara_BUS
{
    public class HangXe_BUS
    {
        HangXe_DAL hx_dal = new HangXe_DAL();

        public int getMaHangXe(string TenHangXe)
        {
            return hx_dal.getMaHangXe(TenHangXe);
        }

        public DataTable Display(string sql)
        {
            return hx_dal.Display(sql);
        }

        public bool Insert(HangXe_DTO hx)
        {
            return hx_dal.Insert(hx);
        }

        public bool Update(HangXe_DTO hx)
        {
            return hx_dal.Update(hx);
        }

        public bool Delete(int MAHX)
        {
            return hx_dal.Delete(MAHX);
        }

    }
}
