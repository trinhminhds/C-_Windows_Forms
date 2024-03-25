namespace QuanLyNhanVien
{
    partial class FormHome
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormHome));
            this.button_DangXuat = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.button_luong = new System.Windows.Forms.Button();
            this.button_addNhanVien = new System.Windows.Forms.Button();
            this.button_home = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.formHomeMain1 = new QuanLyNhanVien.FormHomeMain();
            this.formAddEmployees1 = new QuanLyNhanVien.FormAddEmployees();
            this.formSalary1 = new QuanLyNhanVien.FormSalary();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_DangXuat
            // 
            this.button_DangXuat.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_DangXuat.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_DangXuat.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.button_DangXuat.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button_DangXuat.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button_DangXuat.Image = ((System.Drawing.Image)(resources.GetObject("button_DangXuat.Image")));
            this.button_DangXuat.Location = new System.Drawing.Point(14, 624);
            this.button_DangXuat.Name = "button_DangXuat";
            this.button_DangXuat.Size = new System.Drawing.Size(50, 43);
            this.button_DangXuat.TabIndex = 27;
            this.button_DangXuat.UseVisualStyleBackColor = false;
            this.button_DangXuat.Click += new System.EventHandler(this.button_DangXuat_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightSeaGreen;
            this.panel1.Controls.Add(this.button_luong);
            this.panel1.Controls.Add(this.button_addNhanVien);
            this.panel1.Controls.Add(this.button_home);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Controls.Add(this.button_DangXuat);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(265, 682);
            this.panel1.TabIndex = 32;
            // 
            // button_luong
            // 
            this.button_luong.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_luong.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_luong.FlatAppearance.BorderSize = 0;
            this.button_luong.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.button_luong.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button_luong.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button_luong.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_luong.ForeColor = System.Drawing.Color.Transparent;
            this.button_luong.Image = ((System.Drawing.Image)(resources.GetObject("button_luong.Image")));
            this.button_luong.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_luong.Location = new System.Drawing.Point(32, 397);
            this.button_luong.Name = "button_luong";
            this.button_luong.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.button_luong.Size = new System.Drawing.Size(210, 46);
            this.button_luong.TabIndex = 31;
            this.button_luong.Text = "Lương";
            this.button_luong.UseVisualStyleBackColor = false;
            this.button_luong.Click += new System.EventHandler(this.button3_Click);
            // 
            // button_addNhanVien
            // 
            this.button_addNhanVien.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_addNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_addNhanVien.FlatAppearance.BorderColor = System.Drawing.Color.DarkSlateGray;
            this.button_addNhanVien.FlatAppearance.BorderSize = 0;
            this.button_addNhanVien.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.button_addNhanVien.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Teal;
            this.button_addNhanVien.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Teal;
            this.button_addNhanVien.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_addNhanVien.ForeColor = System.Drawing.Color.Transparent;
            this.button_addNhanVien.Image = ((System.Drawing.Image)(resources.GetObject("button_addNhanVien.Image")));
            this.button_addNhanVien.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_addNhanVien.Location = new System.Drawing.Point(32, 328);
            this.button_addNhanVien.Name = "button_addNhanVien";
            this.button_addNhanVien.Size = new System.Drawing.Size(210, 46);
            this.button_addNhanVien.TabIndex = 30;
            this.button_addNhanVien.Text = "Thêm Nhân Viên";
            this.button_addNhanVien.UseVisualStyleBackColor = false;
            this.button_addNhanVien.Click += new System.EventHandler(this.button2_Click);
            // 
            // button_home
            // 
            this.button_home.BackColor = System.Drawing.Color.DarkSlateGray;
            this.button_home.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button_home.FlatAppearance.BorderColor = System.Drawing.Color.LightSeaGreen;
            this.button_home.FlatAppearance.CheckedBackColor = System.Drawing.Color.Teal;
            this.button_home.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Aquamarine;
            this.button_home.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Aquamarine;
            this.button_home.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button_home.ForeColor = System.Drawing.Color.Transparent;
            this.button_home.Image = ((System.Drawing.Image)(resources.GetObject("button_home.Image")));
            this.button_home.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button_home.Location = new System.Drawing.Point(32, 259);
            this.button_home.Name = "button_home";
            this.button_home.Size = new System.Drawing.Size(210, 46);
            this.button_home.TabIndex = 29;
            this.button_home.Text = "Home";
            this.button_home.UseVisualStyleBackColor = false;
            this.button_home.Click += new System.EventHandler(this.button1_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.Transparent;
            this.label3.Location = new System.Drawing.Point(70, 633);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 25);
            this.label3.TabIndex = 28;
            this.label3.Text = "Đăng Xuất";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(75, 68);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(110, 100);
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.panel2.Controls.Add(this.formHomeMain1);
            this.panel2.Controls.Add(this.formAddEmployees1);
            this.panel2.Controls.Add(this.formSalary1);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(261, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1170, 682);
            this.panel2.TabIndex = 33;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // formHomeMain1
            // 
            this.formHomeMain1.BackColor = System.Drawing.Color.Gainsboro;
            this.formHomeMain1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formHomeMain1.Location = new System.Drawing.Point(0, 0);
            this.formHomeMain1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.formHomeMain1.Name = "formHomeMain1";
            this.formHomeMain1.Size = new System.Drawing.Size(1170, 682);
            this.formHomeMain1.TabIndex = 2;
            // 
            // formAddEmployees1
            // 
            this.formAddEmployees1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.formAddEmployees1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formAddEmployees1.Location = new System.Drawing.Point(0, 0);
            this.formAddEmployees1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.formAddEmployees1.Name = "formAddEmployees1";
            this.formAddEmployees1.Size = new System.Drawing.Size(1170, 682);
            this.formAddEmployees1.TabIndex = 1;
            // 
            // formSalary1
            // 
            this.formSalary1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.formSalary1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.formSalary1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.formSalary1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.formSalary1.Location = new System.Drawing.Point(0, 0);
            this.formSalary1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.formSalary1.Name = "formSalary1";
            this.formSalary1.Size = new System.Drawing.Size(1170, 682);
            this.formSalary1.TabIndex = 0;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(1431, 682);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormHome";
            this.Text = "Quản Lý Nhân Sự";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button_DangXuat;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button_luong;
        private System.Windows.Forms.Button button_addNhanVien;
        private System.Windows.Forms.Button button_home;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Panel panel2;
        private FormHomeMain formHomeMain1;
        private FormAddEmployees formAddEmployees1;
        private FormSalary formSalary1;
    }
}

