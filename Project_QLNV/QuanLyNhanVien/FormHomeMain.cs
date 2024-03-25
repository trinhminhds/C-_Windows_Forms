using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class FormHomeMain : UserControl
    {
        public FormHomeMain()
        {
            InitializeComponent();

            tongNhanVien();
            doTuoiTrungBinhCuaCongTy();
            tongLuongCuaCongTy();
        }

        /// <summary>
        /// Làm mới dữ liệu cập nhật dữ liệu liên tục
        /// </summary>
        public void RefreshData()
        {
            if (InvokeRequired)
            {
                Invoke((MethodInvoker)RefreshData);
                return;
            }

            tongNhanVien();
            doTuoiTrungBinhCuaCongTy();
            tongLuongCuaCongTy();
        }



        SqlCommand sqlCommand;
        /// <summary>
        /// Đếm tổng nhân viên có trong công ty hiện lên các lable 
        /// </summary>
        public void tongNhanVien()
        {
            SqlConnection sqlConnection = Connection.getConnection();

            try
            {
                sqlConnection.Open();

                string query = "SELECT COUNT(*) FROM nhanvien";

                using (sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.Read())
                    {
                        int count = Convert.ToInt32(sqlDataReader[0]);
                        home_tongNhanVien.Text = count.ToString();
                    }
                }
               
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        /// <summary>
        /// Đếm tổng nhân viên từng bộ phận có trong công ty hiện lên các lable 
        /// </summary>
        /// <param name="chucVu"></param>
        /// <returns></returns>
        public int tongNhanVienBoPhan(string chucVu)
        {
            int count = 0;

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                string query = "SELECT COUNT(*) FROM nhanvien WHERE chucvu = @chucvu";
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@chucvu", chucVu);
                try
                {
                    sqlConnection.Open();
                    count = (int)sqlCommand.ExecuteScalar();

                    home_tongNhanVienBoPhan.Text = count.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return count;
           
        }

        /// <summary>
        /// Tính độ tuổi trung bình trong công ty hiện lên các lable 
        /// </summary>
        public void doTuoiTrungBinhCuaCongTy()
        {
            SqlConnection sqlConnection = Connection.getConnection();

            try
            {
                sqlConnection.Open();

                string query = "SELECT AVG((YEAR(GETDATE()) - YEAR(ngaysinh))) AS dotuoi FROM nhanvien";

                using (sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.Read())
                    {
                        int count = Convert.ToInt32(sqlDataReader[0]);
                        home_doTuoiTrungBinh.Text = count.ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        /// <summary>
        /// Tính tổng lương nhân viên có trong công ty hiện lên các lable 
        /// </summary>
        public void tongLuongCuaCongTy()
        {
            SqlConnection sqlConnection = Connection.getConnection();

            try
            {
                sqlConnection.Open();

                string query = "SELECT SUM(luong) AS luong FROM nhanvien";

                using (sqlCommand = new SqlCommand(query, sqlConnection))
                {
                    SqlDataReader sqlDataReader = sqlCommand.ExecuteReader();
                    if (sqlDataReader.Read())
                    {
                        int count = Convert.ToInt32(sqlDataReader[0]);
                        home_tongLuong.Text = count.ToString();
                    }
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                sqlConnection.Close();
            }
        }

        /// <summary>
        /// Tính tổng lương nhân viên từng bộ phận hiện lên các lable
        /// </summary>
        /// <param name="chucVu"></param>
        /// <returns></returns>
        public int tongLuongTungBoPhan(string chucVu)
        {
            int count = 0;

            //string chonChucVu = comboBox_home_tongNhanVienBoPhan.SelectedItem.ToString();

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                string query = "SELECT SUM(luong) FROM nhanvien WHERE chucvu = @chucvu";
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@chucvu", chucVu);
                try
                {
                    sqlConnection.Open();
                    count = (int)sqlCommand.ExecuteScalar();


                    //SqlDataReader reader = sqlCommand.ExecuteReader();
                    //int count = Convert.ToInt32(reader[0]);
                    home_tongLuongTungBoPhan.Text = count.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return count;

        }


        /// <summary>
        /// Tính tổng lương trung bình từng bộ phận hiện lên các lable
        /// </summary>
        /// <param name="chucVu"></param>
        /// <returns></returns>
        public int luongTBTungBoPhan(string chucVu)
        {
            int count = 0;

            //string chonChucVu = comboBox_home_tongNhanVienBoPhan.SelectedItem.ToString();

            using (SqlConnection sqlConnection = Connection.getConnection())
            {
                string query = "SELECT AVG(luong) FROM nhanvien WHERE chucvu = @chucvu";
                sqlCommand = new SqlCommand(query, sqlConnection);
                sqlCommand.Parameters.AddWithValue("@chucvu", chucVu);
                try
                {
                    sqlConnection.Open();
                    count = (int)sqlCommand.ExecuteScalar();


                    //SqlDataReader reader = sqlCommand.ExecuteReader();
                    //int count = Convert.ToInt32(reader[0]);
                    home_luongTrungTungBoPhan.Text = count.ToString();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            return count;

        }


        private void FormHomeMain_Load(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click_2(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// Chọn chức vụ cho trong combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_home_tongNhanVienBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chonChucVu = comboBox_home_tongNhanVienBoPhan.SelectedItem.ToString();

            int demNhanVien = tongNhanVienBoPhan(chonChucVu);

        }

        /// <summary>
        /// Chọn chức vụ cho trong combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_home_tongLuongBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chonChucVu = comboBox_home_tongLuongBoPhan.SelectedItem.ToString();

            int demNhanVien = tongLuongTungBoPhan(chonChucVu);
        }


        /// <summary>
        /// Chọn chức vụ cho trong combobox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBox_home_luongTBBoPhan_SelectedIndexChanged(object sender, EventArgs e)
        {
            string chonChucVu = comboBox_home_luongTBBoPhan.SelectedItem.ToString();

            int demNhanVien = luongTBTungBoPhan(chonChucVu);
        }

        private void home_tongNhanVien_Click(object sender, EventArgs e)
        {

        }
    }
}
