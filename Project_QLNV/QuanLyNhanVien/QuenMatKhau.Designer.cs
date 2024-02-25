namespace QuanLyNhanVien
{
    partial class QuenMatKhau
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.textBox_emailDangKy = new System.Windows.Forms.TextBox();
            this.button_layLaiMatKhau = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.textBox_mkt2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(209, 106);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(267, 39);
            this.label1.TabIndex = 0;
            this.label1.Text = "Quên Mật Khẩu";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(62, 284);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(183, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Email đăng ký:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(62, 410);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 29);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kết quả:";
            // 
            // textBox_emailDangKy
            // 
            this.textBox_emailDangKy.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_emailDangKy.Location = new System.Drawing.Point(280, 282);
            this.textBox_emailDangKy.Multiline = true;
            this.textBox_emailDangKy.Name = "textBox_emailDangKy";
            this.textBox_emailDangKy.Size = new System.Drawing.Size(329, 39);
            this.textBox_emailDangKy.TabIndex = 3;
            // 
            // button_layLaiMatKhau
            // 
            this.button_layLaiMatKhau.BackColor = System.Drawing.Color.SkyBlue;
            this.button_layLaiMatKhau.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button_layLaiMatKhau.Location = new System.Drawing.Point(250, 479);
            this.button_layLaiMatKhau.Name = "button_layLaiMatKhau";
            this.button_layLaiMatKhau.Size = new System.Drawing.Size(226, 46);
            this.button_layLaiMatKhau.TabIndex = 4;
            this.button_layLaiMatKhau.Text = "Lấy Lại Mật Khẩu";
            this.button_layLaiMatKhau.UseVisualStyleBackColor = false;
            this.button_layLaiMatKhau.Click += new System.EventHandler(this.button_layLaiMatKhau_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(197, 410);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(20, 29);
            this.label5.TabIndex = 6;
            this.label5.Text = " ";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(62, 347);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(187, 29);
            this.label6.TabIndex = 7;
            this.label6.Text = "Mật khẩu thứ 2:";
            // 
            // textBox_mkt2
            // 
            this.textBox_mkt2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox_mkt2.Location = new System.Drawing.Point(280, 341);
            this.textBox_mkt2.Multiline = true;
            this.textBox_mkt2.Name = "textBox_mkt2";
            this.textBox_mkt2.Size = new System.Drawing.Size(329, 35);
            this.textBox_mkt2.TabIndex = 8;
            // 
            // QuenMatKhau
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(746, 739);
            this.Controls.Add(this.textBox_mkt2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button_layLaiMatKhau);
            this.Controls.Add(this.textBox_emailDangKy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "QuenMatKhau";
            this.Text = "QuenMatKhau";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox textBox_emailDangKy;
        private System.Windows.Forms.Button button_layLaiMatKhau;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox textBox_mkt2;
    }
}