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
    public class SanPham_BUS
    {
        SanPham_DAL sp_dal = new SanPham_DAL();

        public DataTable Display(string sql)
        {
            return sp_dal.Display(sql);
        }

        public int getMASP(string TenSP)
        {
            return sp_dal.getMASP(TenSP);
        }

        public bool UpdateSL(int MASP, int SL)
        {
            return sp_dal.UpdateSL(MASP, SL);
        }

        public bool Delete(int MASP)
        {
            return sp_dal.Delete(MASP);
        }

        public bool Update(SanPham_DTO SP)
        {
            return sp_dal.Update(SP);
        }

        public bool Insert(SanPham_DTO sp)
        {
            return sp_dal.Insert(sp);
        }

        public bool CheckTonTai(int MASP, string TenSP)
        {
            return sp_dal.CheckTonTai(MASP, TenSP);
        }

        public int getSLSP(int MASP)
        {
            return sp_dal.getSLSP(MASP);
        }

        public decimal getGiaNhapSP(int MASP)
        {
            return sp_dal.getGiaNhapSP(MASP);
        }

        public bool InsertDV(SanPham_DTO sp)
        {
            return sp_dal.InsertDV(sp);
        }

        public bool UpdateDV(SanPham_DTO sp)
        {
            return sp_dal.UpdateDV(sp);
        }
    }
}
