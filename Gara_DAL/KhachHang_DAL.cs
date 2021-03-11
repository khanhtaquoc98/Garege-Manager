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
    public class KhachHang_DAL: DBConnection
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

        public bool Insert(KhachHang_DTO kh)
        {
            try
            {
                con.Open();

                string SQL = "Insert into KHACHHANG values(N'"
                                + kh.HOTEN + "'," + kh.MAHANGXE + ",'" + kh.SODT + "','" + kh.BIENSO
                                + "',N'" + kh.DIACHI + "','" + kh.SOKM + "','" + kh.SOKHUNG + "');";
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

        public bool Delete(int MAKH)
        {
            try
            {
                con.Open();

                string SQL = string.Format("Delete from KHACHHANG where MAKH =" + MAKH);
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

        public bool Update(KhachHang_DTO kh)
        {
            try
            {
                con.Open();

                string SQL = string.Format("UPDATE KHACHHANG SET HOTEN =N'" + kh.HOTEN + "', MAHANGXE =" + kh.MAHANGXE + ", SODT ='" + kh.SODT + "', BIENSO ='" + kh.BIENSO
                                + "', DIACHI ='" + kh.DIACHI + "', SOKM= '" + kh.SOKM + "', SOKHUNG ='" + kh.SOKHUNG+ "' WHERE MAKH = " + kh.MAKH);
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

        public int getIDKH(string BIENSO)
        {
            int IDKH;
            try
            {
                con.Open();
                string SQL = string.Format("SELECT MAKH FROM KHACHHANG WHERE BIENSO='" +BIENSO +"'");
                SqlCommand cmd = new SqlCommand(SQL, con);
                IDKH = (int)cmd.ExecuteScalar();
                return IDKH;
            }
            catch (Exception e)
            { }

            finally
            {
                con.Close();
            }
            return -1;
        }

        public bool CheckTonTai(KhachHang_DTO kh)
        {
            try
            {
                con.Open();

                string SQL = string.Format("SELECT COUNT(BIENSO) FROM KHACHHANG WHERE BIENSO ='" 
                                           + kh.BIENSO + "'");
                SqlCommand cmd = new SqlCommand(SQL, con);
                int count = (int)cmd.ExecuteScalar();
                if (count == 0)
                    return true;
                else return false;
            }

            catch (Exception e)
            { }

            finally
            {
                con.Close();
            }

            return false;
        }

        public bool CheckIDKH(string IDKH)
        {
            try
            {
                con.Open();

                string SQL = string.Format("SELECT COUNT(MAKH) FROM KHACHHANG WHERE MAKH='" + IDKH +"'");
                SqlCommand cmd = new SqlCommand(SQL, con);
                int count = (int)cmd.ExecuteScalar();
                if (count == 0)
                    return true;
                else return false;
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
