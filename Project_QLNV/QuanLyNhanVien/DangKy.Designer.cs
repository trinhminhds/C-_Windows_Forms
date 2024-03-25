namespace QuanLyNhanVien
{
    partial class DangKy
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangKy));
            this.button_dangKy = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_tenTaiKhoan = new System.Windows.Forms.TextBox();
            this.textBox_matKhau = new System.Windows.Forms.TextBox();
            this.textBox_xacNhanMatKhau = new System.Windows.Forms.TextBox();
            this.textBox_email = new System.Windows.Forms.TextBox();
            this.textBox_sdt = new System.Windows.Forms.TextBox();
            this.label_mkt2 = new System.Windows.Forms.Label();
            this.dk_hienmatkhau = new System.Windows.Forms.CheckBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.dk_dangNhap = new System.Windows.Forms.Button();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_dangKy
            // 
            this.button_dangKy.BackColor = System.Drawing.Color.LightSeaGreen;
            this.button_dangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dangKy.ForeColor = System.Drawing.Color.Transparent;
            this.button_dangKy.Location = new System.Drawing.Point(652, 529);
            this.button_dangKy.Name = "button_dangKy";
            this.button_dangKy.Size = new System.Drawing.Size(182, 50);
            this.button_dangKy.TabIndex = 1;
            this.button_dangKy.Text = "Đăng Ký";
            this.button_dangKy.UseVisualStyleBackColor = false;
            this.button_dangKy.Click += new System.EventHandler(this.button_dangKy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(495, 155);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(137, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên tài khoản:";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(495, 220);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu:";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(495, 276);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Xác nhận mật khẩu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(495, 375);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email:";
            this.label5.Click += new System.EventHandler(this.label5_Click);
            // 
            // textBox_tenTaiKhoan
            // 
            this.textBox_tenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tenTaiKhoan.Location = new System.Drawing.Point(685, 155);
            this.textBox_tenTaiKhoan.Multiline = true;
            this.textBox_tenTaiKhoan.Name = "textBox_tenTaiKhoan";
            this.textBox_tenTaiKhoan.Size = new System.Drawing.Size(286, 33);
            this.textBox_tenTaiKhoan.TabIndex = 6;
            this.textBox_tenTaiKhoan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_matKhau
            // 
            this.textBox_matKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_matKhau.Location = new System.Drawing.Point(685, 217);
            this.textBox_matKhau.Multiline = true;
            this.textBox_matKhau.Name = "textBox_matKhau";
            this.textBox_matKhau.PasswordChar = '*';
            this.textBox_matKhau.Size = new System.Drawing.Size(286, 34);
            this.textBox_matKhau.TabIndex = 7;
            // 
            // textBox_xacNhanMatKhau
            // 
            this.textBox_xacNhanMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_xacNhanMatKhau.Location = new System.Drawing.Point(685, 277);
            this.textBox_xacNhanMatKhau.Multiline = true;
            this.textBox_xacNhanMatKhau.Name = "textBox_xacNhanMatKhau";
            this.textBox_xacNhanMatKhau.PasswordChar = '*';
            this.textBox_xacNhanMatKhau.Size = new System.Drawing.Size(286, 32);
            this.textBox_xacNhanMatKhau.TabIndex = 8;
            this.textBox_xacNhanMatKhau.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.Location = new System.Drawing.Point(685, 376);
            this.textBox_email.Multiline = true;
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(286, 31);
            this.textBox_email.TabIndex = 9;
            this.textBox_email.TextChanged += new System.EventHandler(this.textBox_email_TextChanged);
            // 
            // textBox_sdt
            // 
            this.textBox_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sdt.Location = new System.Drawing.Point(685, 433);
            this.textBox_sdt.Multiline = true;
            this.textBox_sdt.Name = "textBox_sdt";
            this.textBox_sdt.Size = new System.Drawing.Size(286, 31);
            this.textBox_sdt.TabIndex = 12;
            this.textBox_sdt.TextChanged += new System.EventHandler(this.textBox_matKhauThu2_TextChanged);
            // 
            // label_mkt2
            // 
            this.label_mkt2.AutoSize = true;
            this.label_mkt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mkt2.Location = new System.Drawing.Point(495, 432);
            this.label_mkt2.Name = "label_mkt2";
            this.label_mkt2.Size = new System.Drawing.Size(132, 25);
            this.label_mkt2.TabIndex = 11;
            this.label_mkt2.Text = "Số điện thoại:";
            this.label_mkt2.Click += new System.EventHandler(this.label_mkt2_Click);
            // 
            // dk_hienmatkhau
            // 
            this.dk_hienmatkhau.AutoSize = true;
            this.dk_hienmatkhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dk_hienmatkhau.Location = new System.Drawing.Point(824, 324);
            this.dk_hienmatkhau.Name = "dk_hienmatkhau";
            this.dk_hienmatkhau.Size = new System.Drawing.Size(147, 26);
            this.dk_hienmatkhau.TabIndex = 13;
            this.dk_hienmatkhau.Text = "Hiện mật khẩu";
            this.dk_hienmatkhau.UseVisualStyleBackColor = true;
            this.dk_hienmatkhau.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.dk_dangNhap);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(464, 670);
            this.panel1.TabIndex = 14;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(171, 167);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(106, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Transparent;
            this.label1.Location = new System.Drawing.Point(56, 300);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(337, 36);
            this.label1.TabIndex = 1;
            this.label1.Text = "QUẢN LÝ NHÂN VIÊN";
            // 
            // dk_dangNhap
            // 
            this.dk_dangNhap.BackColor = System.Drawing.Color.Teal;
            this.dk_dangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dk_dangNhap.ForeColor = System.Drawing.Color.Transparent;
            this.dk_dangNhap.Location = new System.Drawing.Point(126, 485);
            this.dk_dangNhap.Name = "dk_dangNhap";
            this.dk_dangNhap.Size = new System.Drawing.Size(182, 50);
            this.dk_dangNhap.TabIndex = 2;
            this.dk_dangNhap.Text = "Đăng Nhập";
            this.dk_dangNhap.UseVisualStyleBackColor = false;
            this.dk_dangNhap.Click += new System.EventHandler(this.dk_dangNhap_Click);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.MintCream;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label6.Location = new System.Drawing.Point(657, 44);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(177, 39);
            this.label6.TabIndex = 15;
            this.label6.Text = "ĐĂNG KÝ";
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(1037, 670);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.dk_hienmatkhau);
            this.Controls.Add(this.textBox_sdt);
            this.Controls.Add(this.label_mkt2);
            this.Controls.Add(this.textBox_email);
            this.Controls.Add(this.textBox_xacNhanMatKhau);
            this.Controls.Add(this.textBox_matKhau);
            this.Controls.Add(this.textBox_tenTaiKhoan);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button_dangKy);
            this.Name = "DangKy";
            this.Text = "DangKy";
            this.Load += new System.EventHandler(this.DangKy_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button button_dangKy;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox textBox_tenTaiKhoan;
        private System.Windows.Forms.TextBox textBox_matKhau;
        private System.Windows.Forms.TextBox textBox_xacNhanMatKhau;
        private System.Windows.Forms.TextBox textBox_email;
        private System.Windows.Forms.TextBox textBox_sdt;
        private System.Windows.Forms.Label label_mkt2;
        private System.Windows.Forms.CheckBox dk_hienmatkhau;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button dk_dangNhap;
        private System.Windows.Forms.Label label6;
    }
}