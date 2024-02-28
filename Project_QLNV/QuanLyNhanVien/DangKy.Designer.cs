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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox_sdt = new System.Windows.Forms.TextBox();
            this.label_mkt2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button_dangKy
            // 
            this.button_dangKy.BackColor = System.Drawing.Color.Turquoise;
            this.button_dangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dangKy.ForeColor = System.Drawing.Color.Blue;
            this.button_dangKy.Location = new System.Drawing.Point(293, 652);
            this.button_dangKy.Name = "button_dangKy";
            this.button_dangKy.Size = new System.Drawing.Size(163, 57);
            this.button_dangKy.TabIndex = 1;
            this.button_dangKy.Text = "Đăng Ký";
            this.button_dangKy.UseVisualStyleBackColor = false;
            this.button_dangKy.Click += new System.EventHandler(this.button_dangKy_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(33, 306);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(151, 25);
            this.label2.TabIndex = 2;
            this.label2.Text = "Tên tài khoản:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(33, 356);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(108, 25);
            this.label3.TabIndex = 3;
            this.label3.Text = "Mật khẩu:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(33, 416);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(205, 25);
            this.label4.TabIndex = 4;
            this.label4.Text = "Xác nhận mật khẩu:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(33, 472);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 25);
            this.label5.TabIndex = 5;
            this.label5.Text = "Email:";
            // 
            // textBox_tenTaiKhoan
            // 
            this.textBox_tenTaiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_tenTaiKhoan.Location = new System.Drawing.Point(311, 294);
            this.textBox_tenTaiKhoan.Multiline = true;
            this.textBox_tenTaiKhoan.Name = "textBox_tenTaiKhoan";
            this.textBox_tenTaiKhoan.Size = new System.Drawing.Size(366, 37);
            this.textBox_tenTaiKhoan.TabIndex = 6;
            this.textBox_tenTaiKhoan.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // textBox_matKhau
            // 
            this.textBox_matKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_matKhau.Location = new System.Drawing.Point(311, 356);
            this.textBox_matKhau.Multiline = true;
            this.textBox_matKhau.Name = "textBox_matKhau";
            this.textBox_matKhau.PasswordChar = '*';
            this.textBox_matKhau.Size = new System.Drawing.Size(366, 31);
            this.textBox_matKhau.TabIndex = 7;
            // 
            // textBox_xacNhanMatKhau
            // 
            this.textBox_xacNhanMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_xacNhanMatKhau.Location = new System.Drawing.Point(311, 413);
            this.textBox_xacNhanMatKhau.Multiline = true;
            this.textBox_xacNhanMatKhau.Name = "textBox_xacNhanMatKhau";
            this.textBox_xacNhanMatKhau.PasswordChar = '*';
            this.textBox_xacNhanMatKhau.Size = new System.Drawing.Size(366, 39);
            this.textBox_xacNhanMatKhau.TabIndex = 8;
            this.textBox_xacNhanMatKhau.TextChanged += new System.EventHandler(this.textBox3_TextChanged);
            // 
            // textBox_email
            // 
            this.textBox_email.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_email.Location = new System.Drawing.Point(311, 472);
            this.textBox_email.Multiline = true;
            this.textBox_email.Name = "textBox_email";
            this.textBox_email.Size = new System.Drawing.Size(366, 36);
            this.textBox_email.TabIndex = 9;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(293, 27);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(210, 215);
            this.pictureBox1.TabIndex = 10;
            this.pictureBox1.TabStop = false;
            // 
            // textBox_sdt
            // 
            this.textBox_sdt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_sdt.Location = new System.Drawing.Point(311, 529);
            this.textBox_sdt.Multiline = true;
            this.textBox_sdt.Name = "textBox_sdt";
            this.textBox_sdt.Size = new System.Drawing.Size(366, 36);
            this.textBox_sdt.TabIndex = 12;
            this.textBox_sdt.TextChanged += new System.EventHandler(this.textBox_matKhauThu2_TextChanged);
            // 
            // label_mkt2
            // 
            this.label_mkt2.AutoSize = true;
            this.label_mkt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_mkt2.Location = new System.Drawing.Point(33, 529);
            this.label_mkt2.Name = "label_mkt2";
            this.label_mkt2.Size = new System.Drawing.Size(157, 25);
            this.label_mkt2.TabIndex = 11;
            this.label_mkt2.Text = "Mật thẩu thứ 2:";
            // 
            // DangKy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(798, 818);
            this.Controls.Add(this.textBox_sdt);
            this.Controls.Add(this.label_mkt2);
            this.Controls.Add(this.pictureBox1);
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
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox_sdt;
        private System.Windows.Forms.Label label_mkt2;
    }
}