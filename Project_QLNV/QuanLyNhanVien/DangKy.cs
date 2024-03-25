using System;
using System.Text.RegularExpressions; //thư viện giới hạn kí tự
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class DangKy : Form
    {
        public DangKy()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        // kiểm tra tài khoản và mật khẩu có độ dài phải trên 6 và dưới 24
        // và chỉ được dùng ký tự số và chữ không có ký tự đặt biệt
        public bool checkAccount(string account)
        {
            return Regex.IsMatch(account, "^[a-zA-Z0-9]{6,24}$");
        }


        // kiểm tra email có độ dài phải trên 3 và dưới 20
        // và chỉ được dùng ký tự số _ . và chữ không có ký tự đặt biệt khác 
        // có đuôi @gmail.com hoặc .vn
        public bool checkEmail(string email)
        {
            return Regex.IsMatch(email, "^[a-zA-Z0-9_.]{3,20}@gmail.com(.vn|)$");
        }

        ModifyLogin modifyLogin = new ModifyLogin();

        /// <summary>
        /// Kiểm tra điều kiện các dòng để đăng ký
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button_dangKy_Click(object sender, EventArgs e)
        {
            string tenTk = textBox_tenTaiKhoan.Text;
            string matKhau = textBox_matKhau.Text;
            string xacNhanMatKhau = textBox_xacNhanMatKhau.Text;
            string email = textBox_email.Text;
            string sdt = textBox_sdt.Text;

            if (!checkAccount(tenTk))
            {
                MessageBox.Show("Vui lòng nhập tài khoản dài 6 - 24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường!", "Thông Báo");
                return;
            }

            if (!checkAccount(matKhau))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu dài 6 - 24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường!", "Thông Báo");
                return;
            }

            if (xacNhanMatKhau != matKhau)
            {
                MessageBox.Show("Vui lòng xác nhận lại mật khẩu!", "Thông Báo");
                return;
            }

            if (!checkEmail(email))
            {
                MessageBox.Show("Vui lòng nhập đúng định dạng Email!", "Thông Báo");
                return;
            }

            if (!checkAccount(sdt))
            {
                MessageBox.Show("Vui lòng nhập mật khẩu thứ 2 dài 6 - 24 ký tự, với các ký tự chữ và số, chữ hoa và chữ thường!", "Thông Báo");
                return;
            }

            if (modifyLogin.TaiKhoans("SELECT * FROM taikhoan WHERE email = '" + email + "'").Count != 0)
            {
                MessageBox.Show("Email này đã được đăng ký, vui lòng đăng ký email khác!", "Thông Báo");
                return;
            }

            try
            {
                string query = "INSERT INTO taikhoan VALUES('" + tenTk + "','" + matKhau + "','" + email + "','" + sdt + "')";
                modifyLogin.Command(query);
                if (MessageBox.Show("Đăng ký thành công!,Bạn có muốn đăng nhập không ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Information) == DialogResult.Yes)
                {
                    this.Close();
                }

            }
            catch
            {
                MessageBox.Show("Tên tài khoản này đã được đăng kí, vui lòng đăng kí tên tài khoản khác!", "Thông Báo");
            }

        }

        private void dk_dangNhap_Click(object sender, EventArgs e)
        {
            this.Hide();
            DangNhap dangNhap = new DangNhap();
            dangNhap.ShowDialog();
            this.Close();

        }

        private void textBox_matKhauThu2_TextChanged(object sender, EventArgs e)
        {

        }

        private void DangKy_Load(object sender, EventArgs e)
        {

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            textBox_matKhau.PasswordChar = dk_hienmatkhau.Checked ? '\0' : '*';
            textBox_xacNhanMatKhau.PasswordChar = dk_hienmatkhau.Checked ? '\0' : '*';
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label_mkt2_Click(object sender, EventArgs e)
        {

        }

        private void textBox_email_TextChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

    }
}
