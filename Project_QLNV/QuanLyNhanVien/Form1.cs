using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace QuanLyNhanVien
{
    public partial class FormHome : Form
    {
        public FormHome()
        {
            InitializeComponent();
        }

        Modify modify;
        NhanVien nhanVien;

        private void Form1_Load(object sender, EventArgs e)
        {
            modify = new Modify();
            try
            {
                dataGridView1.DataSource = modify.getAllNhanVien();
            }
            catch(Exception ex) 
            {
                MessageBox.Show("Loi: " + ex.Message, "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Thêm thông tin nhân viên vào database
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonThem_Click(object sender, EventArgs e)
        {
            string manv = this.textBoxMANV.Text;
            string hoTen = this.textBoxHOTEN.Text;
            string gt = (radioButtonNam.Checked ? radioButtonNam.Text : radioButtonNu.Text);
            DateTime ngaySinh = this.dateTimePickerNgaySinh.Value;
            if (int.TryParse(this.textBoxLuong.Text, out int luong))
            {
                // Nếu chuỗi có thể chuyển đổi thành số nguyên, thì luong sẽ được gán giá trị tương ứng
            }
            else
            {
                // Xử lý trường hợp không thể chuyển đổi được chuỗi thành số nguyên
                MessageBox.Show("Lương không hợp lệ. Vui lòng nhập một số nguyên.");
            }
            string maph = this.textBoxMaph.Text;
            string sdt = this.textBoxSDT.Text;
            DateTime ngayBC = this.dateTimePickerNgayBC.Value;
            nhanVien = new NhanVien(manv, hoTen, gt, ngaySinh, luong, maph, sdt, ngayBC);
            if (modify.insert(nhanVien))
            {
                dataGridView1.DataSource = modify.getAllNhanVien();
            }
            else
            {
                MessageBox.Show("Loi: Khong them vao duoc", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        /// <summary>
        /// Sửa thông tin nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void buttonSua_Click(object sender, EventArgs e)
        {
            string manv = this.textBoxMANV.Text;
            string hoTen = this.textBoxHOTEN.Text;
            string gt = (radioButtonNam.Checked ? radioButtonNam.Text : radioButtonNu.Text);
            DateTime ngaySinh = this.dateTimePickerNgaySinh.Value;
            if (int.TryParse(this.textBoxLuong.Text, out int luong))
            {
                // Nếu chuỗi có thể chuyển đổi thành số nguyên, thì luong sẽ được gán giá trị tương ứng
            }
            else
            {
                // Xử lý trường hợp không thể chuyển đổi được chuỗi thành số nguyên
                MessageBox.Show("Lương không hợp lệ. Vui lòng nhập một số nguyên.");
            }
            string maph = this.textBoxMaph.Text;
            string sdt = this.textBoxSDT.Text;
            DateTime ngayBC = this.dateTimePickerNgayBC.Value;
            nhanVien = new NhanVien(manv, hoTen, gt, ngaySinh, luong, maph, sdt, ngayBC);
            if (modify.update(nhanVien))
            {
                dataGridView1.DataSource = modify.getAllNhanVien();
            }
            else
            {
                MessageBox.Show("Loi: Khong sua duoc", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void buttonXoa_Click(object sender, EventArgs e)
        {
            string id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            if (modify.delete(id))
            {
                dataGridView1.DataSource = modify.getAllNhanVien();
            }
            else
            {
                MessageBox.Show("Loi: Khong xoa duoc ", "Loi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }



        private void labelMaNV_Click(object sender, EventArgs e)
        {

        }

        private void labelNgaySinh_Click(object sender, EventArgs e)
        {

        }

        private void labelThongTin_Click(object sender, EventArgs e)
        {

        }

       

        private void listBoxDiaChi_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void button_DangXuat_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Bạn có muốn đăng xuất không ?","Thông Báo",MessageBoxButtons.YesNo,MessageBoxIcon.Information) == DialogResult.Yes)
            {   
                this.Hide();
                DangNhap dangNhap = new DangNhap();
                dangNhap.ShowDialog();

            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void textBoxLuong_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
