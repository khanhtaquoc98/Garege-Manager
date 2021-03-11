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
    public class Login_DAL: DBConnection
    {    
        public bool CheckLogin(Login_DTO lg)
        {
            try
            {
                con.Open();

                string SQL = string.Format("Select COUNT(TaiKhoan) FROM DangNhap WHERE TaiKhoan = N'" + lg.TaiKhoan + 
                    "' AND MatKhau = N'" + lg.MatKhau + "';");

                SqlCommand cmd = new SqlCommand(SQL, con);
                if ((int)cmd.ExecuteScalar() > 0)
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

        public string getTen(string TenDangNhap)
        {
            string ten;
            try
            {
                con.Open();

                string SQL = string.Format("SELECT NHANVIEN.HOTEN FROM DANGNHAP,NHANVIEN WHERE NHANVIEN.MANV = DangNhap.MANV AND TaiKhoan = N'" + TenDangNhap + "'");

                SqlCommand cmd = new SqlCommand(SQL, con);
                ten = (string)cmd.ExecuteScalar();              
                    return ten;

            }

            catch (Exception e)
            { }

            finally
            {
                con.Close();
            }

            return null;
        }

        public bool Delete(int MANV)
        {
            try
            {
                con.Open();
                string SQL = "DELETE FROM DangNhap WHERE MANV =" + MANV;

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

        public bool Update(Login_DTO sp)
        {
            try
            {
                con.Open();

                string SQL = string.Format("UPDATE DangNhap SET TaiKhoan =N'" + sp.TaiKhoan + "', MatKhau =N'" + sp.MatKhau + "' WHERE MANV =" + sp.MANV);
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

        public bool Insert(Login_DTO sp)
        {
            try
            {
                con.Open();

                string SQL = string.Format("INSERT INTO DangNhap VALUES (N'" + sp.TaiKhoan + "', N'" + sp.MatKhau + "'," + sp.MANV + ")");
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
