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

        private void Form1_Load(object sender, EventArgs e)
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

        

        private void button2_Click(object sender, EventArgs e)
        {
            formAddEmployees1.Visible = true;
            formSalary1.Visible = false;
            formHomeMain1.Visible = false;

            FormAddEmployees formAddEmployees = new FormAddEmployees();

            if (formAddEmployees != null)
            {
                formAddEmployees.Refresh();
            }

            
           
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

  
        private void button3_Click(object sender, EventArgs e)
        {
            formAddEmployees1.Visible = false;
            formSalary1.Visible = true;
            formHomeMain1.Visible = false;

            FormSalary formSalary = new FormSalary();
       
            if (formSalary != null)
            {
                formSalary.Refresh();
            }

        }


        private void button1_Click(object sender, EventArgs e)
        {
            formAddEmployees1.Visible = false;
            formSalary1.Visible = false;
            formHomeMain1.Visible = true;

            FormHomeMain formHomeMain = new FormHomeMain();

            if (formHomeMain != null)
            {
                formHomeMain.Refresh();
            }

        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

    }
    
}
