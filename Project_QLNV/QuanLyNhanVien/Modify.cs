using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace QuanLyNhanVien
{
    class Modify
    {
        SqlDataAdapter dataAdapter;
        SqlCommand sqlCommand;

        public Modify() 
        {
        }

        /// <summary>
        /// In danh sách nhân viên vào bảng thông tin trong cửa sổ FormHome
        /// </summary>
        /// <returns></returns>
        public DataTable getAllNhanVien_add()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT manhanvien,ho,ten,ngaysinh,gioitinh,diachi,sodienthoai,chucvu FROM nhanvien";
            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                sqlConnection.Open();
                dataAdapter = new SqlDataAdapter(query,sqlConnection);
                dataAdapter.Fill(dataTable);
                sqlConnection.Close();
            }
            return dataTable;
        }


        /// <summary>
        /// In danh sách nhân viên vào bảng thông tin trong cửa sổ FormHome
        /// </summary>
        /// <returns></returns>
        public DataTable getAllNhanVien_salary()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT manhanvien,ho,ten,luong,chucvu FROM nhanvien";
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
        /// <param name="nhanVien"></param>
        /// <returns></returns>
        public bool insert_add(NhanVien_add nhanVien_add)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "INSERT INTO nhanvien (manhanvien,ho,ten,ngaysinh,gioitinh,diachi,sodienthoai,chucvu)" +
                " VALUES (@manhanvien,@ho,@ten,@ngaysinh,@gioitinh,@diachi,@sodienthoai,@chucvu)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@manhanvien", SqlDbType.VarChar).Value = nhanVien_add.Manv;
                sqlCommand.Parameters.Add("@ho", SqlDbType.NVarChar).Value = nhanVien_add.Ho;
                sqlCommand.Parameters.Add("@ten", SqlDbType.NVarChar).Value = nhanVien_add.Ten;
                sqlCommand.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = nhanVien_add.NgaySinh.ToLongDateString();
                sqlCommand.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = nhanVien_add.GioiTinh;
                sqlCommand.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = nhanVien_add.Diachi;
                sqlCommand.Parameters.Add("@sodienthoai", SqlDbType.Char).Value = nhanVien_add.Sdt;
                sqlCommand.Parameters.Add("@chucvu", SqlDbType.NVarChar).Value = nhanVien_add.Chucvu;
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            finally 
            { 
                sqlConnection.Close();
            }
            return true;
        }

        /// <summary>
        /// Sửa thông tin trong bảng nhân viên database
        /// </summary>
        /// <param name="nhanVien"></param>
        /// <returns></returns>
        public bool update_add(NhanVien_add nhanVien_add)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "UPDATE nhanvien SET ho = @ho,ten = @ten, ngaysinh = @ngaysinh,gioitinh = @gioitinh,diachi = @diachi,sodienthoai = @sodienthoai,chucvu = @chucvu " +
                "WHERE manhanvien = @manhanvien"; 

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@manhanvien", SqlDbType.VarChar).Value = nhanVien_add.Manv;
                sqlCommand.Parameters.Add("@ho", SqlDbType.NVarChar).Value = nhanVien_add.Ho;
                sqlCommand.Parameters.Add("@ten", SqlDbType.NVarChar).Value = nhanVien_add.Ten;
                sqlCommand.Parameters.Add("@ngaysinh", SqlDbType.DateTime).Value = nhanVien_add.NgaySinh.ToLongDateString();
                sqlCommand.Parameters.Add("@gioitinh", SqlDbType.NVarChar).Value = nhanVien_add.GioiTinh;
                sqlCommand.Parameters.Add("@diachi", SqlDbType.NVarChar).Value = nhanVien_add.Diachi;
                sqlCommand.Parameters.Add("@sodienthoai", SqlDbType.NVarChar).Value = nhanVien_add.Sdt;
                sqlCommand.Parameters.Add("@chucvu", SqlDbType.NVarChar).Value = nhanVien_add.Chucvu;
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);

            }
            finally
            {
                sqlConnection.Close();
            }
            return true;

        }

        /// <summary>
        /// Sửa thông tin trong bảng nhân viên database
        /// </summary>
        /// <param name="nhanVien"></param>
        /// <returns></returns>
        public bool update_salary(NhanVien_salary nhanVien_salary)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "UPDATE NHANVIEN SET ho = @ho,ten = @ten,luong =@luong,chucvu =@chucvu " +
                "WHERE manhanvien = @manhanvien";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@manhanvien", SqlDbType.VarChar).Value = nhanVien_salary.Manv;
                sqlCommand.Parameters.Add("@ho", SqlDbType.NVarChar).Value = nhanVien_salary.Ho;
                sqlCommand.Parameters.Add("@ten", SqlDbType.NVarChar).Value = nhanVien_salary.Ten;
                sqlCommand.Parameters.Add("@luong", SqlDbType.Int).Value = nhanVien_salary.Luong;
                sqlCommand.Parameters.Add("@chucvu", SqlDbType.NVarChar).Value = nhanVien_salary.Chucvu;
                sqlCommand.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);

            }
            finally
            {
                sqlConnection.Close();
            }
            return true;

        }

        /// <summary>
        /// Xóa thông tin nhân viên trong database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool delete_add(string id)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "DELETE FROM nhanvien WHERE manhanvien = @manhanvien";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@manhanvien", SqlDbType.NVarChar).Value = id;
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


        /// <summary>
        /// Xóa thông tin nhân viên trong database
        /// </summary>
        /// <param name="id"></param>
        /// <returns></returns>
        public bool delete_salary(string id)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "DELETE FROM nhanvien WHERE manhanvien = @manhanvien";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@manhanvien", SqlDbType.VarChar).Value = id;
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
