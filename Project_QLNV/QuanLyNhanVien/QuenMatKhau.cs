using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class QuenMatKhau : Form
    {
        public QuenMatKhau()
        {
            InitializeComponent();
            label5.Text = "";
        }

        ModifyLogin modifyLogin = new ModifyLogin();

        private void button_layLaiMatKhau_Click(object sender, EventArgs e)
        {
            string email = textBox_emailDangKy.Text;
            string sdt = textBox_sdt.Text;

            if(email.Trim() == "")//nếu là khoảng các thì nhập lại email 
            {
                MessageBox.Show("Vui lòng nhập email đăng ký!");
            }
            else if(sdt.Trim() == "")
            {
                MessageBox.Show("Vui lòng nhập mật khẩu thứ 2!");
            }
            else
            {
                // câu lệnh sql nếu email nhập này giống với email có trong bảng thì in ra mật khẩu 
                string query = "SELECT * FROM taikhoan WHERE email = '" + email + "' AND matkhauthu2 = '" + sdt + "'";
                if(modifyLogin.TaiKhoans(query).Count != 0) { //nếu khác 0 thì in dòng mật khẩu
                    label5.ForeColor = Color.Blue;
                    label5.Text = "Mật khẩu: " + modifyLogin.TaiKhoans(query)[0].MatKhau; // Lấy dòng mật khẩu ra
                }
                else // ngược lại in chữ màu đỏ
                { 
                    label5.ForeColor = Color.Red;
                    label5.Text = "Email này chưa được đăng kí hoặc mật khẩu thứ 2 không đúng!";
                }
            }





        }

        private void textBox_sdt_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
            this.Close();  
        }
    }
}
