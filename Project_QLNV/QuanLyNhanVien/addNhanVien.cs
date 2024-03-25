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
    public partial class FormAddEmployees : UserControl
    {
        public FormAddEmployees()
        {
            InitializeComponent();
        }

        Modify modify;
        NhanVien_add nhanVien_add;

        private void labelTenNV_Click(object sender, EventArgs e)
        {

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Tìm Kiếm thông tin nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            string timKiem = addNhanVien_timKiem.Text;

            if (!string.IsNullOrEmpty(timKiem))
            {

                DataTable dataTable = (DataTable)addNhanVien_dataGridView.DataSource;
                DataView dataView = dataTable.DefaultView;
                string locTimKiem = string.Format("manhanvien LIKE '%{0}%' OR ten LIKE '%{0}%' OR ho LIKE '%{0}%' OR gioiTinh LIKE '%{0}%' OR diachi LIKE '%{0}%' OR chucvu LIKE '%{0}%'", timKiem);
                dataView.RowFilter = locTimKiem;
                addNhanVien_dataGridView.DataSource = dataView.ToTable();
            }
            else
            {
                ((DataTable)addNhanVien_dataGridView.DataSource).DefaultView.RowFilter = string.Empty;               
            }

        }

        private void labelSDT_Click(object sender, EventArgs e)
        {

        }
        
        /// <summary>
        /// Khi ta chọn vào 1 hàng dữ liệu thì nó sẽ hiện tên các textbox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNhanVien_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            addNhanVien_manhanvien.Text = addNhanVien_dataGridView.CurrentRow.Cells[0].Value.ToString();
            addNhanVien_ho.Text = addNhanVien_dataGridView.CurrentRow.Cells[1].Value.ToString();
            addNhanVien_ten.Text = addNhanVien_dataGridView.CurrentRow.Cells[2].Value.ToString();
            addNhanVien_ngaySinh.Text = addNhanVien_dataGridView.CurrentRow.Cells[3].Value.ToString();
            addNhanVien_gioiTinh.Text = addNhanVien_dataGridView.SelectedCells[4].Value.ToString();
            addNhanVien_diaChi.Text = addNhanVien_dataGridView.CurrentRow.Cells[5].Value.ToString();
            addNhanVien_sdt.Text = addNhanVien_dataGridView.CurrentRow.Cells[6].Value.ToString();
            addNhanVien_chucVu.Text = addNhanVien_dataGridView.SelectedCells[7].Value.ToString();

        }



        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            modify = new Modify();
            try
            {
                addNhanVien_dataGridView.DataSource = modify.getAllNhanVien_add();
                textBox1_TextChanged(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


    /// <summary>
    /// Thêm thông tin nhân viên vào database
    /// </summary>
    /// <param name="sender"></param>
    /// <param name="e"></param>
    private void addNhanVien_themNhanVien_Click(object sender, EventArgs e)
    {
            string manv = this.addNhanVien_manhanvien.Text;
            string ho = this.addNhanVien_ho.Text;
            string ten = this.addNhanVien_ten.Text;
            DateTime ngaySinh = this.addNhanVien_ngaySinh.Value;
            string gioiTinh = this.addNhanVien_gioiTinh.Text;
            string diaChi = this.addNhanVien_diaChi.Text;
            string soDienThoai = this.addNhanVien_sdt.Text;
            string chucVu = this.addNhanVien_chucVu.Text;

            nhanVien_add = new NhanVien_add(manv, ho, ten, ngaySinh, gioiTinh, diaChi, soDienThoai, chucVu);
            if (modify.insert_add(nhanVien_add))
            {
               addNhanVien_dataGridView.DataSource = modify.getAllNhanVien_add();
               MessageBox.Show("Thông báo: Đã thêm thành công","Thông báo",MessageBoxButtons.OK,MessageBoxIcon.Information);
               addNhanVien_datLaiNhanVien_Click(this, EventArgs.Empty);
            }
            else
            {
                MessageBox.Show("Lỗi: Không thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

    }

        /// <summary>
        /// Xoá thông tin Nhân Viên 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNhanVien_xoaNhanVien_Click(object sender, EventArgs e)
        {
            String id = addNhanVien_dataGridView.SelectedRows[0].Cells[0].Value.ToString();

            if (MessageBox.Show("Thông Báo: Bạn muốn xóa nhân viên " + addNhanVien_manhanvien.Text + " ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (modify.delete_add(id)){ 
                    
                    addNhanVien_dataGridView.DataSource = modify.getAllNhanVien_add();
                    MessageBox.Show("Thông báo: Đã xóa thành công", "Thông báo");
                    addNhanVien_datLaiNhanVien_Click(sender, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Lỗi: Không xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
           
        }

        /// <summary>
        /// Xoá hết dữ liệu đã nhập trước đó
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void addNhanVien_datLaiNhanVien_Click(object sender, EventArgs e)
        {
            addNhanVien_manhanvien.Text = "";
            addNhanVien_ho.Text = "";
            addNhanVien_ten.Text = "";
            addNhanVien_gioiTinh.Text = "";
            addNhanVien_diaChi.Text = "";
            addNhanVien_sdt.Text = "";
            addNhanVien_chucVu.Text = "";
        }

        private void addNhanVien_timKiem_KeyPress(object sender, KeyPressEventArgs e)
        {
            
        }

        private void addNhanVien_timKiem_Leave(object sender, EventArgs e)
        {
          
        }

        /// <summary>
        /// Sửa thông tin nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void addNhanVien_suaNhanVien_Click(object sender, EventArgs e)
        {
            string manv = this.addNhanVien_manhanvien.Text;
            string ho = this.addNhanVien_ho.Text;
            string ten = this.addNhanVien_ten.Text;
            DateTime ngaySinh = this.addNhanVien_ngaySinh.Value;
            string gioiTinh = this.addNhanVien_gioiTinh.Text;
            string diaChi = this.addNhanVien_diaChi.Text;
            string soDienThoai = this.addNhanVien_sdt.Text;
            string chucVu = this.addNhanVien_chucVu.Text;

            nhanVien_add = new NhanVien_add(manv, ho, ten, ngaySinh, gioiTinh, diaChi, soDienThoai, chucVu);
            if (MessageBox.Show("Thông Báo: Bạn có muốn sửa thông tin của nhân viên " + addNhanVien_manhanvien.Text + " ?", "Thông Báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (modify.update_add(nhanVien_add))
                {
                    MessageBox.Show("Thông Báo: Sửa thành công", "Thông Báo");
                    addNhanVien_dataGridView.DataSource = modify.getAllNhanVien_add();
                    addNhanVien_datLaiNhanVien_Click(sender, EventArgs.Empty);
                }
                else
                {
                    MessageBox.Show("Lỗi: Không thêm vào được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }










    }
}
