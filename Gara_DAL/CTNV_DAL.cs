using Gara_DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Gara_DAL
{
    public class CTNV_DAL: DBConnection
    {
        public DataTable Display(string sql)
        {
            DataTable tblLogin = new DataTable();
            SqlDataAdapter adt = new SqlDataAdapter();

            try
            {
                con.Open();
                SqlCommand cmd = new SqlCommand(sql, con);
                adt.SelectCommand = cmd; //Command để thực thi câu lệnh SQL
                adt.Fill(tblLogin);  //Fill vào một biến kiểu Datatable
                return tblLogin;
            }
            catch (Exception e) { }

            finally
            { con.Close(); }

            return null;
        }

        public bool Insert(CTNV_DTO kh)
        {
            try
            {
                con.Open();

                string SQL = "Insert into CTNV values(N'"
                                + kh.ChucVu + "')";
                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception e)
            { }

            finally
            {
                con.Close();
            }

            return false;
        }

        public bool Delete(int IDPHANQUYEN)
        {
            try
            {
                con.Open();

                string SQL = string.Format("Delete from CTNV where IDPHANQUYEN =" + IDPHANQUYEN);
                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception e)
            { }

            finally
            {
                con.Close();
            }

            return false;
        }

        public bool Update(CTNV_DTO kh)
        {
            try
            {
                con.Open();

                string SQL = string.Format("UPDATE CTNV SET  Chuc =N'" + kh.ChucVu  + "' WHERE IDPHANQUYEN = '" + kh.IDPhanQuyen + "'");
                SqlCommand cmd = new SqlCommand(SQL, con);
                if (cmd.ExecuteNonQuery() > 0)
                    return true;
            }

            catch (Exception e)
            { }

            finally
            {
                con.Close();
            }

            return false;
        }

        public int GetIDPQ(string chuc)
        {
            int s;
            try
            {
                con.Open();
                string SQL = string.Format("SELECT IDPhanQuyen FROM CTNV WHERE Chuc=N'" + chuc + "'");
                SqlCommand cmd = new SqlCommand(SQL, con);
                s = (int)cmd.ExecuteScalar();
                return s;
            }
            catch (Exception e)
            { }

            finally
            {
                con.Close();
            }
            return 0;
        }
    }
}
