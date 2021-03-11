using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Gara_DTO;
using System.Data;

namespace Gara_DAL
{
    public class NhanVien_DAL : DBConnection
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

        public string getTenNV(string MANV)
        {
            string TenNV;
            try
            {
                con.Open();
                string SQL = string.Format("SELECT HOTEN FROM NHANVIEN WHERE MANV= '" + MANV + "'");
                SqlCommand cmd = new SqlCommand(SQL, con);
                TenNV = (string)cmd.ExecuteScalar();
                return TenNV;
            }
            catch (Exception e)
            { }

            finally
            {
                con.Close();
            }
            return null;
        }

        public int getMANV(string HOTENNV)
        {
            int manv;
            try
            {
                con.Open();
                string SQL = string.Format("SELECT MANV FROM NHANVIEN WHERE HOTEN=N'" + HOTENNV + "'");
                SqlCommand cmd = new SqlCommand(SQL, con);
                manv = (int)cmd.ExecuteScalar();
                return manv;
            }
            catch (Exception e)
            { }

            finally
            {
                con.Close();
            }
            return -1;
        }

        public int getIDPQ(string HOTENNV)
        {
            int manv;
            try
            {
                con.Open();
                string SQL = string.Format("SELECT IDPhanQuyen FROM NHANVIEN WHERE HOTEN=N'" + HOTENNV + "'");
                SqlCommand cmd = new SqlCommand(SQL, con);
                manv = (int)cmd.ExecuteScalar();
                return manv;
            }
            catch (Exception e)
            { }

            finally
            {
                con.Close();
            }
            return -1;
        }

        public int getIDPQIDNV(int MANV)
        {
            int manv;
            try
            {
                con.Open();
                string SQL = string.Format("SELECT IDPhanQuyen FROM NHANVIEN WHERE MANV = " + MANV);
                SqlCommand cmd = new SqlCommand(SQL, con);
                manv = (int)cmd.ExecuteScalar();
                return manv;
            }
            catch (Exception e)
            { }

            finally
            {
                con.Close();
            }
            return -1;
        }

        public bool Insert(NhanVien_DTO kh)
        {
            try
            {
                con.Open();

                string SQL = "Insert into NHANVIEN values(" + kh.IDPQ + ", N'" + kh.HOTEN + "','" + kh.SODT + "','" + kh.NGVL + "',N'" + kh.DIACHI + "')";
                               
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

        public bool Delete(int MANV)
        {
            try
            {
                con.Open();

                string SQL = string.Format("Delete from NHANVIEN where MANV =" + MANV);
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

        public bool Update(NhanVien_DTO kh)
        {
            try
            {
                con.Open();

                string SQL = string.Format("UPDATE NHANVIEN SET  IDPhanQuyen =" + kh.IDPQ + ", HOTEN = N'" + kh.HOTEN + "', SODT ='" +
                                        kh.SODT + "', NGVL = '" + kh.NGVL + "', DIACHI = N'" + kh.DIACHI + "' WHERE MANV = " + kh.MANV);
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

        public int getIDPQNV(int MANV)
        {
            int manv;
            try
            {
                con.Open();
                string SQL = string.Format("SELECT IDPhanQuyen FROM NHANVIEN WHERE MANV=" + MANV );
                SqlCommand cmd = new SqlCommand(SQL, con);
                manv = (int)cmd.ExecuteScalar();
                return manv;
            }
            catch (Exception e)
            { }

            finally
            {
                con.Close();
            }
            return -1;
        }
    }
}
