using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Gara_DTO;

namespace Gara_DAL
{
    public class HoaDon_DAL: DBConnection
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

        public bool Insert(HoaDon_DTO hd)
        {
            try
            {
                con.Open();

                string SQL = "Insert into HOADON values('" + hd.NGSUA + "', null," + hd.MAKH + "," + hd.MANV + "," + hd.MANVTV + "," + hd.MANVKT + ",null)";
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

        public bool Delete(int MAHD)
        {
            try
            {
                con.Open();

                string SQL = "Delete from HOADON WHERE SOHD=" + MAHD;
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

        public bool DeleteKH(int MAKH)
        {
            try
            {
                con.Open();

                string SQL = "Delete from HOADON WHERE MAKH=" + MAKH;
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

        public bool UpdateTongTien(int IDHD, string TongTien)
        {
            try
            {
                con.Open();

                string SQL = "UPDATE HOADON set TongGia='" + TongTien + "' WHERE SOHD =" + IDHD;
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

        public bool UpdateNgayHD(int IDHD, string NGHD)
        {
            try
            {
                con.Open();

                string SQL = "UPDATE HOADON set NGHD='" + NGHD + "' WHERE SOHD =" + IDHD;
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
