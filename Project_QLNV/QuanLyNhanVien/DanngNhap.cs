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
            
            QuenMatKhau quenMatKhau = new QuenMatKhau();
            quenMatKhau.ShowDialog();

        }


        /// <summary>
        /// Chuyển FormĐăngKý khi bấm vào đăng ký
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="link dang ky"></param>
        private void linkLabel_dangKy_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            DangKy dangKy = new DangKy();
            dangKy.ShowDialog();
        }


        ModifyLogin modifyLogin = new ModifyLogin();

        private void button_dangKy_Click(object sender, EventArgs e)
        {
            //khai báo biến cho dòng được nhập vào textBox tài khoản và mật khẩu
            string tenTk = textBox_taiKhoan.Text;
            string matKhau = textBox_matKhau.Text;

            // kiểm tra dòng tài khoản và mật khẩu có để trống không
            if (tenTk.Trim() == "") { MessageBox.Show("Vui lòng nhập tên tài khoản"); return; }
            else if(matKhau.Trim() == ""){ MessageBox.Show("Vui lòng nhập mật khẩu"); return; }
            else
            {
                // khai báo câu lệch sql để tìm ra tài khoản với mật khẩu có trùng hay không để đăng nhập vào
                string query = "SELECT * FROM taikhoan WHERE tentaikhoan = '" + tenTk + "' AND matkhau = '" + matKhau + "'";

                //nếu file modifyLogin đọc tài khoản và mật khẩu chính xác thì xuất ra dòng thông báo,
                //còn ngược lại thì 
                if (modifyLogin.TaiKhoans(query).Count != 0)
                {
                    MessageBox.Show("Đăng nhập thành công!","Thông Báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
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
    }
}
