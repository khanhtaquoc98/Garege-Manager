using Gara_DAL;
using Gara_DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara_BUS
{
    public class CTHD_BUS
    {
        CTHD_DAL cthd_dal = new CTHD_DAL();

        public bool Insert(CTHD_DTO cthd)
        {
            return cthd_dal.Insert(cthd);
        }

        public bool Delete(int MAHD, int MASP)
        {
            return cthd_dal.Delete(MAHD, MASP);
        }

        public decimal TongGia(int SOHD)
        {
            return cthd_dal.TongGia(SOHD);
        }

        public bool Update(int MAHD, int MASP, int SL, decimal Gia)
        {
            return cthd_dal.Update(MAHD, MASP, SL, Gia);
        }

        public int GetSL(int MAHD, int MASP)
        {
            return cthd_dal.GetSL(MAHD, MASP);
        }

        public decimal GetTien(int MAHD, int MASP)
        {
            return cthd_dal.GetTien(MAHD, MASP);
        }
    }
}
