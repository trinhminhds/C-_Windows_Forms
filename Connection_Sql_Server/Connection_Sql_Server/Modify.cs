using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connection_Sql_Server
{
    class Modify
    {
        SqlDataAdapter dataAdapter;
        SqlCommand sqlCommand; 

        public Modify() 
        { 
        }

        public DataTable getAllSinhVien()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT Masv,HoTen,NgaySinh,MaKhoa FROM SinhVien";
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query, sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }



        /// <summary>
        /// Thêm dữ liệu vào bảng nhân viên trong database
        /// </summary>
        /// <param name="sinhVien"></param>
        /// <returns></returns>
        public bool insert_add(SinhVien sinhVien)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "INSERT INTO SinhVien (MaSV,HoTen,NgaySinh,MaKhoa)" +
                " VALUES (@MaSV,@HoTen,@NgaySinh,@MaKhoa)";
            try
            {
                sqlConnection.Open(); 
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@Masv", SqlDbType.VarChar).Value = sinhVien.Masv;
                sqlCommand.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = sinhVien.HoTen;
                sqlCommand.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = sinhVien.NgaySinh.ToLongDateString();
                sqlCommand.Parameters.Add("@MaKhoa", SqlDbType.NVarChar).Value = sinhVien.MaKhoa;
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }


        public bool update_add(SinhVien sinhVien)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "UPDATE SinhVien SET HoTen = @HoTen, NgaySinh = @NgaySinh, MaKhoa = @MaKhoa WHERE Masv = @MaSV";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@Masv", SqlDbType.VarChar).Value = sinhVien.Masv;
                sqlCommand.Parameters.Add("@HoTen", SqlDbType.NVarChar).Value = sinhVien.HoTen;
                sqlCommand.Parameters.Add("@NgaySinh", SqlDbType.DateTime).Value = sinhVien.NgaySinh.ToLongDateString();
                sqlCommand.Parameters.Add("@MaKhoa", SqlDbType.NVarChar).Value = sinhVien.MaKhoa;
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally
            {
                sqlConnection.Close();
            }
            return true;
        }

        public bool delete_add(string id)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "DELETE FROM SinhVien WHERE Masv = @Masv";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@Masv", SqlDbType.NVarChar).Value = id;
                sqlCommand.ExecuteNonQuery();
            }
            catch
            {
                return false;

            }
            finally
            {
                sqlConnection.Close();
            }
            return true;

        }





    }
}
