using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class DangNhap : Form
    {
        public DangNhap()
        {
            InitializeComponent();
        }



        /// <summary>
        /// Chuyển Form Quên mật khẩu khi bấm vào quên mật khẩu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="link quên mật khẩu"></param>
        private void linkLabel_quenMatKhau_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            quenMatKhau.ShowDialog();
            this.Close();
        }


        /// <summary>
        /// Chuyển FormĐăngKý khi bấm vào đăng ký
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="link dang ky"></param>
        private void linkLabel_dangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
            this.Close();

        }


        ModifyLogin modifyLogin = new ModifyLogin();

        private void button_dangKy_Click(object sender, EventArgs e)
        {
            //string username = textBox_taiKhoan.Text;
            //string password = textBox_matKhau.Text;

            //// Chuỗi kết nối đến cơ sở dữ liệu
            //string connectionString = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=D:\C_Shap\Project_QLNV\QuanLyNhanVien\DatabaseQLNV.mdf;Integrated Security=True";

            //// Tạo kết nối đến cơ sở dữ liệu
            //using (SqlConnection connection = new SqlConnection(connectionString))
            //{
            //    // Mở kết nối
            //    connection.Open();

            //    // Tạo truy vấn SQL để kiểm tra thông tin đăng nhập
            //    string query = "SELECT COUNT(*) FROM taikhoan WHERE @tentaikhoan = '"+ username +"'  AND @matkhau = '"+ password +"' ";
            //    using (SqlCommand command = new SqlCommand(query, connection))
            //    {
            //        // Thêm các tham số vào truy vấn để tránh tấn công SQL Injection
            //        command.Parameters.AddWithValue("@tentaikhoan", username);
            //        command.Parameters.AddWithValue("@matkhau", password);

            //        // Thực thi truy vấn
            //        int count = (int)command.ExecuteScalar();

            //        // Kiểm tra kết quả của truy vấn để xác định xem người dùng có hợp lệ hay không
            //        if (count > 0)
            //        {
            //            // Đăng nhập thành công
            //            MessageBox.Show("Đăng nhập thành công!");
            //            // Thực hiện các thao tác cần thiết sau khi đăng nhập thành công
            //            this.Hide();
            //            FormHome formHome = new FormHome();
            //            formHome.ShowDialog();
            //            this.Close();
            //        }

            //        else
            //        {
            //            // Đăng nhập thất bại
            //            MessageBox.Show("Tên người dùng hoặc mật khẩu không đúng!");
            //        }
            //    }


            //khai báo biến cho dòng được nhập vào textBox tài khoản và mật khẩu
            string tenTk = textBox_taiKhoan.Text;
            string matKhau = textBox_matKhau.Text;

            // kiểm tra dòng tài khoản và mật khẩu có để trống không
            if (tenTk.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản"); return; }
            else if (matKhau.Trim() == "") { MessageBox.Show("Vui lòng nhập mật khẩu"); return; }
            else
            {
                // khai báo câu lệch sql để tìm ra tài khoản với mật khẩu có trùng hay không để đăng nhập vào
                string query = "SELECT * FROM taikhoan WHERE tentaikhoan = '" + tenTk + "' AND matkhau = '" + matKhau + "'";

                //nếu file modifyLogin đọc tài khoản và mật khẩu chính xác thì xuất ra dòng thông báo,
                //còn ngược lại thì 
                if (modifyLogin.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    // ẩn cửa sổ đăng nhập vào form chính 
                    this.Hide();
                    FormHome formHome = new FormHome();
                    formHome.ShowDialog();
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản hoặc mật khẩu không chính xác!", "Thông Báo", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }


            }


        }

        private void dn_hienMatKhau_CheckedChanged(object sender, EventArgs e)
        {
            textBox_matKhau.PasswordChar = dn_hienMatKhau.Checked ? '\0' : '*'; 
        }

        private void textBox_taiKhoan_TextChanged(object sender, EventArgs e)
        {

        }

        private void DangNhap_Load(object sender, EventArgs e)
        {
            this.KeyPreview = true;

            this.KeyDown += DangNhap_KeyDown;
        }

        private void DangNhap_KeyDown(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter)
            {
                button_dangNhap.Focus();
            }
        }
    }
}
