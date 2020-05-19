using QuanLyGiaoVien.ClassObject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace QuanLyGiaoVien.ConnectionDatabase
{
    class ConnecCSDL
    {

        

        public static bool conection()
        {
            string connectionString = ConfigurationManager.ConnectionStrings["QLGV"].ConnectionString;

         


                try

                {

                    using (SqlConnection connection = new SqlConnection(connectionString))

                    {

                        connection.Open();

                    }

                    //MessageBox.Show("Mo va dong co so du lieu thanh cong.");

                    return true;

                }

                catch (Exception ex)

                {
                    MessageBox.Show("Loi khi mo  ket noi:" + ex.Message);
                    return false;


                }
          }

        public static List<GiaoVien> readTableData()
        {
            try

            {

                List<GiaoVien> sach = new List<GiaoVien>();

                string connectionString = ConfigurationManager.ConnectionStrings["QLGV"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))

                using (SqlCommand command = new SqlCommand

                       ("SELECT MaGV, HoTen, SoDT, GhiChu , MaDonVi FROM GiaoVien;", connection))

                {

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())

                    {
                        int i = 1;
                        while (reader.Read())

                        {

                            var gv = new GiaoVien();
                            gv.STT = i;
                            gv.MaGV = reader.GetString(0);
                            gv.HoTen = reader.GetString(1);
                            gv.SoDT = reader.GetString(2);
                            gv.GhiChu = reader.GetString(3);
                            gv.MaDonVi = reader.GetString(4);
                            

                            sach.Add(gv);
                            i += 1;
                        }

                    }

                }

                //MessageBox.Show("Mo va dong co so du lieu thanh cong.");

                return sach;

            }

            catch (Exception ex)

            {

                MessageBox.Show("Loi khi mo  ket noi:" + ex.Message);
                return null;

            }
        }

        public static int DeleteData(GiaoVien giaoVien)

        {

            try

            {
                string connectionString =

                      ConfigurationManager.ConnectionStrings["QLGV"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))

                using (SqlCommand command = new SqlCommand("DELETE FROM GiaoVien" +

                       " WHERE MaGV = @MaGV",

                      connection))

                {

                    command.Parameters.Add("MaGV", SqlDbType.Char, 10).Value = giaoVien.MaGV;

                    connection.Open();

                    return command.ExecuteNonQuery();

                }
            }

            catch (Exception ex)

            {

                MessageBox.Show("Loi khi mo  ket noi:" + ex.Message);

                return -1;

            }

        }

        public static List<GiaoVien> readGiaoVienWhere(string condition)
        {

            try

            {

                List<GiaoVien> giaoVien = new List<GiaoVien>();

                string connectionString = ConfigurationManager.ConnectionStrings["QLGV"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))

                using (SqlCommand command = new SqlCommand

                       ("SELECT MaGV, HoTen, SoDT, GhiChu , MaDonVi FROM GiaoVien WHERE MaDonVi = " + "'" + condition + "';" , connection))

                {

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())

                    {
                        int i = 1;
                        while (reader.Read())

                        {

                            var gv = new GiaoVien();
                            gv.STT = i;
                            gv.MaGV = reader.GetString(0);
                            gv.HoTen = reader.GetString(1);
                            gv.SoDT = reader.GetString(2);
                            gv.GhiChu = reader.GetString(3);
                            gv.MaDonVi = reader.GetString(4);


                            giaoVien.Add(gv);
                            i += 1;
                        }

                    }

                }

                //MessageBox.Show("Mo va dong co so du lieu thanh cong.");

                return giaoVien;

            }

            catch (Exception ex)

            {

                MessageBox.Show("Loi khi mo  ket noi:" + ex.Message);
                return null;

            }

        }

        public static List<DonVi> readDonVi(string condition)
        {
            try

            {

                List<DonVi> donVi = new List<DonVi>();

                string connectionString = ConfigurationManager.ConnectionStrings["QLGV"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))

                using (SqlCommand command = new SqlCommand

                       ("SELECT MaDonVi, TenDonVi, MaCoSo FROM DonVi WHERE MaCoSo = " + "'" + condition + "';", connection))

                {

                    connection.Open();

                    using (SqlDataReader reader = command.ExecuteReader())

                    {

                        while (reader.Read())

                        {

                            var dv = new DonVi();

                            dv.MaDonVi = reader.GetString(0);

                            dv.TenDonVi = reader.GetString(1);
                            dv.MaCoSo = reader.GetString(2);

                            donVi.Add(dv);

                        }

                    }

                }

               // MessageBox.Show("Mo va dong co so du lieu thanh cong.");

                return donVi;

            }

            catch (Exception ex)

            {
                
                MessageBox.Show("Loi khi mo  ket noi:" + ex.Message);
                return null;
            }
        }

        public static List<CoSo> readCoso()
        {
            try

            {
                List<CoSo> coSo = new List<CoSo>();

                string connectionString = ConfigurationManager.ConnectionStrings["QLGV"].ConnectionString;

                using (SqlConnection connection = new SqlConnection(connectionString))

                using (SqlCommand command = new SqlCommand

                   ("SELECT MaCoSo, TenCoSo FROM CoSo;", connection))

                {

                connection.Open();

                using (SqlDataReader reader = command.ExecuteReader())

                {

                    while (reader.Read())

                    {

                        var cs = new CoSo();

                        cs.MaCoSo = reader.GetString(0);

                        cs.TenCoSo = reader.GetString(1);
                        

                        coSo.Add(cs);

                    }

                }

            }

             MessageBox.Show("Mo va dong co so du lieu thanh cong.");

            return coSo;

        }

            catch (Exception ex)

            {
                
                MessageBox.Show("Loi khi mo  ket noi:" + ex.Message);
                return null;
            }
        }
    }

 }

