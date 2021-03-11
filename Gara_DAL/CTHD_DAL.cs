using Gara_DTO;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;

namespace Gara_DAL
{
    public class CTHD_DAL: DBConnection
    {
        public bool Insert(CTHD_DTO cthd)
        {
            try
            {
                con.Open();

                string SQL = "Insert into CTHD values(" + cthd.SOHD + "," + cthd.MASP + ","
                    + cthd.SL + ",'" + cthd.GIA + "')";


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

        public bool Delete(int SOHD, int MASP)
        {
            try
            {
                con.Open();

                string SQL = string.Format("Delete from CTHD WHERE SOHD =" + SOHD + "AND MASP =" + MASP);
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

        public decimal TongGia(int SOHD)
        {
            decimal GIA;
            try
            {
                con.Open();
                string SQL = string.Format("SELECT SUM(GIACTHD) FROM CTHD,SANPHAM WHERE CTHD.MASP = SANPHAM.MASP AND CTHD.SOHD =" + SOHD);
                SqlCommand cmd = new SqlCommand(SQL, con);
                GIA = (decimal)cmd.ExecuteScalar();
                return GIA;
            }
            catch (Exception e)
            { }

            finally
            {
                con.Close();
            }
            return 0;
        }

        public bool Update(int SOHD, int MASP, int SL, decimal Gia)
        {
            try
            {
                con.Open();
                string SQL = "UPDATE CTHD SET SL=" + SL + ",GIACTHD =" + Gia + " WHERE SOHD =" + SOHD + "AND MASP =" + MASP;


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

        public int GetSL(int SOHD, int MASP)
        {
            int SL;
            try
            {
                con.Open();
                string SQL = string.Format("SELECT SL FROM CTHD WHERE SOHD =" + SOHD + "AND MASP =" + MASP);
                SqlCommand cmd = new SqlCommand(SQL, con);
                SL = (int)cmd.ExecuteScalar();
                return SL;
            }
            catch (Exception e)
            { }

            finally
            {
                con.Close();
            }
            return 0;
        }

        public decimal GetTien(int SOHD, int MASP)
        {
            decimal Tien;
            try
            {
                con.Open();
                string SQL = string.Format("SELECT GiaCTHD FROM CTHD WHERE SOHD =" + SOHD + "AND MASP =" + MASP);
                SqlCommand cmd = new SqlCommand(SQL, con);
                Tien = (decimal)cmd.ExecuteScalar();
                return Tien;
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
