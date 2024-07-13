using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Connection_Sql_Server
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            modify = new Modify();
            try
            {
                dataGridView1.DataSource = modify.getAllSinhVien();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        Modify modify;
        SinhVien sinhVien;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click_1(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           
                string masv = this.textBox_Masv.Text;
                string Hoten = this.textBox_HoTen.Text;
                DateTime ngaySinh = this.dateTimePicker_NgaySinh.Value;
                string maKhoa = this.textBox_MaKhoa.Text;

                sinhVien = new SinhVien(masv, Hoten, ngaySinh, maKhoa);

                if (modify.insert_add(sinhVien))
                {
                    dataGridView1.DataSource = modify.getAllSinhVien();
                    MessageBox.Show("Thông báo: Đã thêm thành công", "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Information);

                }
                else
                {
                    MessageBox.Show("Lỗi: Không thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
  
                textBox_Masv.Text = dataGridView1.CurrentRow.Cells[0].Value.ToString();
                textBox_HoTen.Text = dataGridView1.CurrentRow.Cells[1].Value.ToString();
                dateTimePicker_NgaySinh.Text = dataGridView1.CurrentRow.Cells[2].Value.ToString();
                textBox_MaKhoa.Text = dataGridView1.CurrentRow.Cells[3].Value.ToString();

        }

        private void button_Sua_Click(object sender, EventArgs e)
        {
            string masv = this.textBox_Masv.Text;
            string Hoten = this.textBox_HoTen.Text;
            DateTime ngaySinh = this.dateTimePicker_NgaySinh.Value;
            string maKhoa = this.textBox_MaKhoa.Text;

            sinhVien = new SinhVien(masv, Hoten, ngaySinh, maKhoa);
            if (MessageBox.Show("Thông Báo: Bạn có muốn sửa thông tin của sinh viên " + textBox_Masv.Text + " ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (modify.update_add(sinhVien))
                {
                    MessageBox.Show("Thông Báo: Sửa thành công", "Thông Báo");
                    dataGridView1.DataSource = modify.getAllSinhVien();
                }
                else
                {
                    MessageBox.Show("Lỗi: Không thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }

        private void button_xoa_Click(object sender, EventArgs e)
        {
            String id = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();

            if (MessageBox.Show("Thông Báo: Bạn muốn xóa nhân viên " + textBox_Masv.Text + " ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (modify.delete_add(id))
                {

                    dataGridView1.DataSource = modify.getAllSinhVien();
                    MessageBox.Show("Thông báo: Đã xóa thành công", "Thông báo");
                }
                else
                {
                    MessageBox.Show("Lỗi: Không xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }

        }
    }
}
