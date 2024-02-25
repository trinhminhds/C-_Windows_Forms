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
        public DataTable getAllNhanVien()
        {
            DataTable dataTable = new DataTable();
            string query = "SELECT * FROM NHANVIEN";
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
        /// Thêm dữ liệu vào bảng nhân viên trong database
        /// </summary>
        /// <param name="nhanVien"></param>
        /// <returns></returns>
        public bool insert(NhanVien nhanVien)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "INSERT INTO NHANVIEN VALUES (@MANV,@HOTEN,@GT,@NGSINH,@LUONG,@MAPH,@SDT,@NGAYBC)";
            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MANV", SqlDbType.NVarChar).Value = nhanVien.Manv;
                sqlCommand.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = nhanVien.Name;
                sqlCommand.Parameters.Add("@GT", SqlDbType.NVarChar).Value = nhanVien.Gt;
                sqlCommand.Parameters.Add("@NGSINH", SqlDbType.DateTime).Value = nhanVien.NgaySinh.ToLongDateString();
                sqlCommand.Parameters.Add("@LUONG", SqlDbType.Int).Value = nhanVien.Luong;
                sqlCommand.Parameters.Add("@MAPH", SqlDbType.NVarChar).Value = nhanVien.Maph;
                sqlCommand.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = nhanVien.Sdt;
                sqlCommand.Parameters.Add("@NGAYBC", SqlDbType.DateTime).Value = nhanVien.NgayBC.ToShortDateString();
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
        /// Sửa thông tin trong bảng nhân viên database
        /// </summary>
        /// <param name="nhanVien"></param>
        /// <returns></returns>
        public bool update(NhanVien nhanVien)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "UPDATE NHANVIEN SET HOTEN = @HOTEN, GT = @GT, LUONG = @LUONG, MAPH = @MAPH, SDT = @SDT WHERE MANV = @MANV"; 

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MANV", SqlDbType.NVarChar).Value = nhanVien.Manv;// lấy dữ liệu từ các nhập để thêm vào database
                sqlCommand.Parameters.Add("@HOTEN", SqlDbType.NVarChar).Value = nhanVien.Name;
                sqlCommand.Parameters.Add("@GT", SqlDbType.NVarChar).Value = nhanVien.Gt;
                sqlCommand.Parameters.Add("@NGSINH", SqlDbType.DateTime).Value = nhanVien.NgaySinh.ToLongDateString();
                sqlCommand.Parameters.Add("@LUONG", SqlDbType.Int).Value = nhanVien.Luong;
                sqlCommand.Parameters.Add("@MAPH", SqlDbType.NVarChar).Value = nhanVien.Maph;
                sqlCommand.Parameters.Add("@SDT", SqlDbType.NVarChar).Value = nhanVien.Sdt;
                sqlCommand.Parameters.Add("@NGAYBC", SqlDbType.DateTime).Value = nhanVien.NgayBC.ToShortDateString();
                sqlCommand.ExecuteNonQuery();
            }
            catch(Exception ex)
            {
                MessageBox.Show("Loi: " + ex.Message);

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
        public bool delete(string id)
        {
            SqlConnection sqlConnection = Connection.getConnection();
            string query = "DELETE FROM NHANVIEN WHERE MANV = @MANV";

            try
            {
                sqlConnection.Open();
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.Add("@MANV", SqlDbType.NVarChar).Value = id;
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
