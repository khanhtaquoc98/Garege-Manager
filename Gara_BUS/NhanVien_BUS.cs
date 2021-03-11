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
    public class NhanVien_BUS
    {
        NhanVien_DAL nv_dal = new NhanVien_DAL();

        public DataTable Display(string sql)
        {
            return nv_dal.Display(sql);
        }

        public string getTenNV(string MANV)
        {
            return nv_dal.getTenNV(MANV);
        }

        public int getMANV(string HOTENNV)
        {
            return nv_dal.getMANV(HOTENNV);
        }

        public int getIDPQ(string HOTENNV)
        {
            return nv_dal.getIDPQ(HOTENNV);
        }

        public int getIDPQIDNV(int MANV)
        {
            return nv_dal.getIDPQIDNV(MANV);
        }


        public bool Insert(NhanVien_DTO kh)
        {
            return nv_dal.Insert(kh);
        }

        public bool Delete(int MANV)
        {
            return nv_dal.Delete(MANV);
        }

        public bool Update(NhanVien_DTO kh)
        {
            return nv_dal.Update(kh);
        }

        public int getIDPQNV(int MANV)
        {
            return nv_dal.getIDPQNV(MANV);
        }
    }
}
