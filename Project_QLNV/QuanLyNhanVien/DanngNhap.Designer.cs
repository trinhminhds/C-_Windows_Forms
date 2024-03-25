namespace QuanLyNhanVien
{
    partial class DangNhap
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(DangNhap));
            this.textBox_taiKhoan = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.textBox_matKhau = new System.Windows.Forms.TextBox();
            this.button_dangNhap = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.linkLabel_quenMatKhau = new System.Windows.Forms.LinkLabel();
            this.linkLabel_dangKy = new System.Windows.Forms.LinkLabel();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.dn_hienMatKhau = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox_taiKhoan
            // 
            this.textBox_taiKhoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_taiKhoan.Location = new System.Drawing.Point(149, 349);
            this.textBox_taiKhoan.Multiline = true;
            this.textBox_taiKhoan.Name = "textBox_taiKhoan";
            this.textBox_taiKhoan.Size = new System.Drawing.Size(270, 31);
            this.textBox_taiKhoan.TabIndex = 1;
            this.textBox_taiKhoan.TextChanged += new System.EventHandler(this.textBox_taiKhoan_TextChanged);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // textBox_matKhau
            // 
            this.textBox_matKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_matKhau.Location = new System.Drawing.Point(149, 396);
            this.textBox_matKhau.Multiline = true;
            this.textBox_matKhau.Name = "textBox_matKhau";
            this.textBox_matKhau.PasswordChar = '*';
            this.textBox_matKhau.Size = new System.Drawing.Size(270, 31);
            this.textBox_matKhau.TabIndex = 2;
            // 
            // button_dangNhap
            // 
            this.button_dangNhap.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.button_dangNhap.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_dangNhap.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.button_dangNhap.Location = new System.Drawing.Point(149, 562);
            this.button_dangNhap.Name = "button_dangNhap";
            this.button_dangNhap.Size = new System.Drawing.Size(198, 52);
            this.button_dangNhap.TabIndex = 3;
            this.button_dangNhap.Text = "Đăng Nhập";
            this.button_dangNhap.UseVisualStyleBackColor = false;
            this.button_dangNhap.Click += new System.EventHandler(this.button_dangKy_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(70, 349);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(32, 30);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(70, 396);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(32, 31);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // linkLabel_quenMatKhau
            // 
            this.linkLabel_quenMatKhau.AutoSize = true;
            this.linkLabel_quenMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_quenMatKhau.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.linkLabel_quenMatKhau.Location = new System.Drawing.Point(76, 508);
            this.linkLabel_quenMatKhau.Name = "linkLabel_quenMatKhau";
            this.linkLabel_quenMatKhau.Size = new System.Drawing.Size(151, 25);
            this.linkLabel_quenMatKhau.TabIndex = 8;
            this.linkLabel_quenMatKhau.TabStop = true;
            this.linkLabel_quenMatKhau.Text = "Quên Mật Khẩu";
            this.linkLabel_quenMatKhau.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_quenMatKhau_LinkClicked);
            // 
            // linkLabel_dangKy
            // 
            this.linkLabel_dangKy.AutoSize = true;
            this.linkLabel_dangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linkLabel_dangKy.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.linkLabel_dangKy.Location = new System.Drawing.Point(299, 508);
            this.linkLabel_dangKy.Name = "linkLabel_dangKy";
            this.linkLabel_dangKy.Size = new System.Drawing.Size(88, 25);
            this.linkLabel_dangKy.TabIndex = 9;
            this.linkLabel_dangKy.TabStop = true;
            this.linkLabel_dangKy.Text = "Đăng Ký";
            this.linkLabel_dangKy.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLabel_dangKy_LinkClicked);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(-6, -2);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(1064, 662);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 10;
            this.pictureBox3.TabStop = false;
            // 
            // dn_hienMatKhau
            // 
            this.dn_hienMatKhau.AutoSize = true;
            this.dn_hienMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dn_hienMatKhau.Location = new System.Drawing.Point(280, 451);
            this.dn_hienMatKhau.Name = "dn_hienMatKhau";
            this.dn_hienMatKhau.Size = new System.Drawing.Size(139, 24);
            this.dn_hienMatKhau.TabIndex = 11;
            this.dn_hienMatKhau.Text = "Hiện mật khẩu";
            this.dn_hienMatKhau.UseVisualStyleBackColor = true;
            this.dn_hienMatKhau.CheckedChanged += new System.EventHandler(this.dn_hienMatKhau_CheckedChanged);
            // 
            // DangNhap
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 663);
            this.Controls.Add(this.dn_hienMatKhau);
            this.Controls.Add(this.linkLabel_dangKy);
            this.Controls.Add(this.linkLabel_quenMatKhau);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.button_dangNhap);
            this.Controls.Add(this.textBox_matKhau);
            this.Controls.Add(this.textBox_taiKhoan);
            this.Controls.Add(this.pictureBox3);
            this.Name = "DangNhap";
            this.Text = "DangNhap";
            this.Load += new System.EventHandler(this.DangNhap_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_taiKhoan;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.TextBox textBox_matKhau;
        private System.Windows.Forms.Button button_dangNhap;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.LinkLabel linkLabel_quenMatKhau;
        private System.Windows.Forms.LinkLabel linkLabel_dangKy;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.CheckBox dn_hienMatKhau;
    }
}