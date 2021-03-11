using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;
using Gara_DTO;

namespace Gara_DAL
{
    public class HangXe_DAL: DBConnection
    {
        public int getMaHangXe(string STenHangXe)
        {
            int mahangxe;
            try
            {
                con.Open();
                string SQL = string.Format("SELECT MAHANGXE FROM HANGXE WHERE TENHANGXE= '" + STenHangXe + "'");
                SqlCommand cmd = new SqlCommand(SQL, con);
                mahangxe = (int)cmd.ExecuteScalar();
                return mahangxe;
            }
            catch (Exception e)
            { }

            finally
            {
                con.Close();
            }
            return -1;
        }

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

        public bool Insert(HangXe_DTO hx)
        {
            try
            {
                con.Open();

                string SQL = "Insert into HANGXE values(N'" + hx.TENHANGXE + "');";
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

        public bool Update(HangXe_DTO hx)
        {
            try
            {
                con.Open();

                string SQL = "UPDATE HANGXE SET TENHANGXE = N'" + hx.TENHANGXE + "' WHERE MAHANGXE =" + hx.MAHANGXE;
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

        public bool Delete(int mahx)
        {
            try
            {
                con.Open();

                string SQL = "Delete FROM HANGXE WHERE MAHANGXE =" + mahx;
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
    }
}
