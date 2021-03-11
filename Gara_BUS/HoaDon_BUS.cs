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
    public class HoaDon_BUS
    {
        HoaDon_DAL hd_dal = new HoaDon_DAL();

        public DataTable Display(string sql)
        {
            return hd_dal.Display(sql);
        }

        public bool Insert(HoaDon_DTO hd)
        {
            return hd_dal.Insert(hd);
        }
        
        public bool Delete(int IDHD)
        {
            return hd_dal.Delete(IDHD);
        }

        public bool DeleteKH(int MAKH)
        {
            return hd_dal.DeleteKH(MAKH);
        }

        public bool UpdateTongTien(int IDHD, string TongTien)
        {
            return hd_dal.UpdateTongTien(IDHD, TongTien);
        }

        public bool UpdateNgayHD(int IDHD, string NGHD)
        {
            return hd_dal.UpdateNgayHD(IDHD, NGHD);
        }

    }
}
