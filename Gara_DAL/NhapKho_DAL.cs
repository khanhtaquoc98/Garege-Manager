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
    public class NhapKho_DAL: DBConnection
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

        public bool Insert(NhapKho_DTO NK)
        {
            try
            {
                con.Open();
                string SQL = "INSERT INTO NHAPKHO VALUES ('"+ NK.NGAYNHAP +"'," + NK.MASP + "," + NK.NGNHAP + "," + NK.SLNHAP + "," + NK.GIANHAP + ")";
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

        public bool UpdateSLNK(NhapKho_DTO NK)
        {
            try
            {
                con.Open();
                string SQL = "UPDATE NHAPKHO SET SLNHAP= SLNHAP + " + NK.SLNHAP + ",GIANHAP = GIANHAP + " + NK.GIANHAP 
                    + "WHERE MASP =" + NK.MASP + " AND NGAYNHAP ='" + NK.NGAYNHAP 
                    + "' AND NGNHAP =" + NK.NGNHAP;

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

        public bool CheckSPNhap(int MASP, string NgayNhap, int NgNhap)
        {
            int i;
            try
            {
                con.Open();
                string SQL = "SELECT COUNT(MASP) FROM NHAPKHO "
                    + "WHERE NHAPKHO.MASP =" + MASP + " AND NGAYNHAP ='" + NgayNhap + "' AND NGNHAP =" + NgNhap;

                SqlCommand cmd = new SqlCommand(SQL, con);
                i = (int)cmd.ExecuteScalar();
                if(i == 1)
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
