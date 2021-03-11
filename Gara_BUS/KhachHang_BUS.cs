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
    public class KhachHang_BUS
    {
        KhachHang_DAL kh_dal = new KhachHang_DAL();

        public DataTable Display(string sql)
        {
            return kh_dal.Display(sql);
        }

        public bool Insert(KhachHang_DTO kh)
        {
            return kh_dal.Insert(kh);
        }

        public bool Delete(int kh)
        {
            return kh_dal.Delete(kh);
        }

        public bool Update(KhachHang_DTO kh)
        {
            return kh_dal.Update(kh);
        }

        public int getIDKH(string BienSo)
        {
            return kh_dal.getIDKH(BienSo);
        }

        public bool CheckTonTai(KhachHang_DTO kh)
        {
            return kh_dal.CheckTonTai(kh);
        }

        public bool CheckIDKH(string IDKH)
        {
            return kh_dal.CheckIDKH(IDKH);
        }
    }
}
