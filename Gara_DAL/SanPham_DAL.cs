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
    public class SanPham_DAL: DBConnection
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

        public int getMASP(string TENSP)
        {
            int manv;
            try
            {
                con.Open();
                string SQL = string.Format("SELECT MASP FROM SANPHAM WHERE TENSP=N'" + TENSP + "'");
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

        public bool UpdateSL(int MASP, int SL)
        {
            try
            {
                con.Open();
                string SQL = "UPDATE SANPHAM SET SOLUONG= SOLUONG + " + SL + " WHERE MASP =" + MASP;

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

        public int getSLSP(int MASP)
        {
            int s;
            try
            {
                con.Open();
                string SQL = string.Format("SELECT SOLUONG FROM SANPHAM WHERE MASP= " + MASP);
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

        public bool Delete(int MASP)
        {
            try
            {
                con.Open();
                string SQL = "DELETE FROM SANPHAM WHERE MASP =" + MASP;

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

        public bool Update(SanPham_DTO sp)
        {
            try
            {
                con.Open();

                string SQL = string.Format("UPDATE SANPHAM SET  TENSP =N'" + sp.TENSP + "', SOLUONG =" + sp.SOLUONG + ", GIANHAP ='" + sp.GIANHAP + "', GIABAN ='" + sp.GIABAN
                                + "', DonVi =N'" + sp.DONVI + "', LOAI= N'" + sp.LOAI + "' WHERE MASP =" + sp.MASP);
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

        public bool Insert(SanPham_DTO sp)
        {
            try
            {
                con.Open();

                string SQL = string.Format("INSERT INTO SANPHAM VALUES (TENSP =N'" + sp.TENSP + "', SOLUONG = 0, GIANHAP ='" + sp.GIANHAP + "', GIABAN ='" + sp.GIABAN
                                + "', DonVi =N'" + sp.DONVI + "', LOAI= N'" + sp.LOAI);
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

        public bool CheckTonTai(int MASP, string TenSP)
        {
            int i = 0;
            try
            {
                con.Open();
                string SQL = "SELECT COUNT(MASP) FROM SANPHAM WHERE MASP =" + MASP + " AND TENSP=N'" + TenSP + "'";

                SqlCommand cmd = new SqlCommand(SQL, con);
                i = (int)cmd.ExecuteScalar();
                if (i == 1)
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

        public decimal getGiaNhapSP(int MASP)
        {
            decimal Gia;
            try
            {
                con.Open();
                string SQL = string.Format("SELECT GIANHAP FROM SANPHAM WHERE MASP= " + MASP);
                SqlCommand cmd = new SqlCommand(SQL, con);
                Gia = (decimal)cmd.ExecuteScalar();
                return Gia;
            }
            catch (Exception e)
            { }

            finally
            {
                con.Close();
            }
            return -1;
        }

        public bool InsertDV(SanPham_DTO sp)
        {
            try
            {
                con.Open();

                string SQL = string.Format("INSERT INTO SANPHAM VALUES (N'" + sp.TENSP + "',null, null, " + sp.GIABAN
                                + ",null, N'" + sp.LOAI + "')");
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

        public bool UpdateDV(SanPham_DTO sp)
        {
            try
            {
                con.Open();

                string SQL = string.Format("UPDATE SANPHAM SET  TENSP = N'" + sp.TENSP + "' , GIABAN =" + sp.GIABAN
                                + ", LOAI = N'" + sp.LOAI + "' WHERE MASP =" + sp.MASP);
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
