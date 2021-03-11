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
    public class Login_BUS
    {
        Login_DAL login_dal = new Login_DAL();

        public bool CheckLogin(Login_DTO lg)
        {
            return login_dal.CheckLogin(lg);
        }

        public string getTen(string TenDangNhap)
        {
            return login_dal.getTen(TenDangNhap);
        }

        public bool Delete(int MANV)
        {
            return login_dal.Delete(MANV);
        }

        public bool Update(Login_DTO sp)
        {
            return login_dal.Update(sp);
        }

        public bool Insert(Login_DTO sp)
        {
            return login_dal.Insert(sp);
        }
    }
}
