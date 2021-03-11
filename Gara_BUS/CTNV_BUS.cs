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
    public class CTNV_BUS
    {
        CTNV_DAL ctnv_dal = new CTNV_DAL();

        public DataTable Display(string sql)
        {
            return ctnv_dal.Display(sql);
        }

        public bool Insert(CTNV_DTO ctnv)
        {
            return ctnv_dal.Insert(ctnv);
        }

        public bool Delete(int IDPHANQUYEN)
        {
            return ctnv_dal.Delete(IDPHANQUYEN);
        }

        public bool Update(CTNV_DTO ctnv)
        {
            return ctnv_dal.Update(ctnv);
        }

        public int GetIDPQ(string chuc)
        {
            return ctnv_dal.GetIDPQ(chuc);
        }

    }
}
