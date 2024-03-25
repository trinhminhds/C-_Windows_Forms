using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyNhanVien
{
    public partial class FormSalary : UserControl
    {
        public FormSalary()
        {
            InitializeComponent();
        }


        Modify modify;
        NhanVien_salary nhanVien_Salary;

        private void labelTenNV_Click(object sender, EventArgs e)
        {

        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        /// <summary>
        /// Tìm kiếm thông tin nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void luongNhanVien_timKiem_TextChanged(object sender, EventArgs e)
        {
            string timKiem = luongNhanVien_timKiem.Text;

            if (!string.IsNullOrEmpty(timKiem))
            {
                DataTable dataTable = (DataTable)luongNhanVien_dataGridView.DataSource;
                DataView dataView = dataTable.DefaultView;
                string locTimKiem = string.Format("manhanvien LIKE '%{0}%' OR ten LIKE '%{0}%' OR ho LIKE '%{0}%' OR chucvu LIKE '%{0}%'", timKiem);
                dataView.RowFilter = locTimKiem;
                luongNhanVien_dataGridView.DataSource= dataView.ToTable();
            }
            else
            {
                ((DataTable)luongNhanVien_dataGridView.DataSource).DefaultView.RowFilter = string.Empty;
            }
        }



        private void label2_Click(object sender, EventArgs e)
        {

        }

        /// <summary>
        /// Khi ta chọn 1 hàng trong bảng thì những thông tin của nhân viên sẽ hiện lên các TextBox
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void luongNhanVien_dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
            luongNhanVien_manv.Text = luongNhanVien_dataGridView.CurrentRow.Cells[0].Value.ToString();
            luongNhanVien_ho.Text = luongNhanVien_dataGridView.CurrentRow.Cells[1].Value.ToString();
            luongNhanVien_ten.Text = luongNhanVien_dataGridView.CurrentRow.Cells[2].Value.ToString();
            luongNhanVien_luong.Text = luongNhanVien_dataGridView.CurrentRow.Cells[3].Value.ToString();
            luongNhanVien_chucVu.Text = luongNhanVien_dataGridView.SelectedCells[4].Value.ToString();
           
        }

        /// <summary>
        /// Sửa thông tin nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void luongNhanVien_sua_Click(object sender, EventArgs e)
        {
            string manv = this.luongNhanVien_manv.Text;
            string ho = this.luongNhanVien_ho.Text;
            string ten = this.luongNhanVien_ten.Text; 
            if (int.TryParse(this.luongNhanVien_luong.Text, out int luong))
            {
                // Nếu chuỗi có thể chuyển đổi thành số nguyên, thì luong sẽ được gán giá trị tương ứng
            }
            else
            {
                // Xử lý trường hợp không thể chuyển đổi được chuỗi thành số nguyên
                MessageBox.Show("Lương không hợp lệ. Vui lòng nhập một số nguyên.");
            }
            string chucVu = this.luongNhanVien_chucVu.Text;

            nhanVien_Salary = new NhanVien_salary(manv, ho, ten, luong, chucVu);

            if (MessageBox.Show("Thông Báo: Bạn có muốn sửa thông tin của nhân viên "+ luongNhanVien_manv.Text +" ?","Thông Báo",
                MessageBoxButtons.YesNo,MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (modify.update_salary(nhanVien_Salary))
                {
                    luongNhanVien_dataGridView.DataSource = modify.getAllNhanVien_salary();
                    luongNhanVien_datLai_Click(sender, e);
                    MessageBox.Show("Thông Báo: Sửa thành công", "Thông Báo");
                }
                else
                {
                    MessageBox.Show("Lỗi: Không sửa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            } 
        }

        /// <summary>
        /// Xóa thông tin nhân viên
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void luongNhanVien_xoa_Click(object sender, EventArgs e)
        {
            String id = luongNhanVien_dataGridView.SelectedRows[0].Cells[0].Value.ToString();

            if (MessageBox.Show("Thông Báo: Bạn có muốn xóa nhân viên " + luongNhanVien_manv + " ?", "Thông Báo",
                MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                if (modify.delete_salary(id))
                {
                    MessageBox.Show("Thông báo: Đã xóa thành công", "Thông báo");
                    luongNhanVien_dataGridView.DataSource = modify.getAllNhanVien_salary();
                    luongNhanVien_datLai_Click(sender, e);
                }
                else
                {
                    MessageBox.Show("Lỗi: Không xóa được", "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
        

        /// <summary>
        /// Xóa các giá trị điền trước đó
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void luongNhanVien_datLai_Click(object sender, EventArgs e)
        {
            luongNhanVien_manv.Text = "";
            luongNhanVien_ho.Text = "";
            luongNhanVien_ten.Text = "";
            luongNhanVien_luong.Text = "";
            luongNhanVien_chucVu.SelectedText.Clone();
        }

        /// <summary>
        /// Hiện bảng dữ liệu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void panel2_Paint_1(object sender, PaintEventArgs e)
        {
            modify = new Modify();
            try
            {
                luongNhanVien_dataGridView.DataSource = modify.getAllNhanVien_salary();
                luongNhanVien_timKiem_TextChanged(sender, e);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message, "Lỗi", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void FormSalary_Load(object sender, EventArgs e)
        {
            
        }

        private void luongNhanVien_chucVu_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
    
}
