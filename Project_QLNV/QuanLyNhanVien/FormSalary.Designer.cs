namespace QuanLyNhanVien
{
    partial class FormSalary
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.luongNhanVien_chucVu = new System.Windows.Forms.ComboBox();
            this.luongNhanVien_datLai = new System.Windows.Forms.Button();
            this.luongNhanVien_sua = new System.Windows.Forms.Button();
            this.labelNgayBC = new System.Windows.Forms.Label();
            this.luongNhanVien_luong = new System.Windows.Forms.TextBox();
            this.labelLuong = new System.Windows.Forms.Label();
            this.luongNhanVien_ten = new System.Windows.Forms.TextBox();
            this.labelMaNV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTenNV = new System.Windows.Forms.Label();
            this.luongNhanVien_manv = new System.Windows.Forms.TextBox();
            this.luongNhanVien_ho = new System.Windows.Forms.TextBox();
            this.luongNhanVien_timKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.luongNhanVien_dataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.luongNhanVien_xoa = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luongNhanVien_dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.luongNhanVien_chucVu);
            this.panel1.Controls.Add(this.luongNhanVien_datLai);
            this.panel1.Controls.Add(this.luongNhanVien_xoa);
            this.panel1.Controls.Add(this.luongNhanVien_sua);
            this.panel1.Controls.Add(this.labelNgayBC);
            this.panel1.Controls.Add(this.luongNhanVien_luong);
            this.panel1.Controls.Add(this.labelLuong);
            this.panel1.Controls.Add(this.luongNhanVien_ten);
            this.panel1.Controls.Add(this.labelMaNV);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.labelTenNV);
            this.panel1.Controls.Add(this.luongNhanVien_manv);
            this.panel1.Controls.Add(this.luongNhanVien_ho);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(280, 551);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // luongNhanVien_chucVu
            // 
            this.luongNhanVien_chucVu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.luongNhanVien_chucVu.FormattingEnabled = true;
            this.luongNhanVien_chucVu.Items.AddRange(new object[] {
            "Nhân viên",
            "Kỹ sư",
            "Chuyên gia nước ngoài",
            "Công nhân",
            "Thực tập sinh",
            "Lao động phổ thông",
            "Người làm bán thời gian",
            "Cán bộ quản lý",
            "Nhân sự thử việc"});
            this.luongNhanVien_chucVu.Location = new System.Drawing.Point(36, 294);
            this.luongNhanVien_chucVu.Name = "luongNhanVien_chucVu";
            this.luongNhanVien_chucVu.Size = new System.Drawing.Size(195, 24);
            this.luongNhanVien_chucVu.TabIndex = 77;
            this.luongNhanVien_chucVu.SelectedIndexChanged += new System.EventHandler(this.luongNhanVien_chucVu_SelectedIndexChanged);
            // 
            // luongNhanVien_datLai
            // 
            this.luongNhanVien_datLai.BackColor = System.Drawing.Color.LightSeaGreen;
            this.luongNhanVien_datLai.Cursor = System.Windows.Forms.Cursors.Hand;
            this.luongNhanVien_datLai.FlatAppearance.BorderSize = 0;
            this.luongNhanVien_datLai.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.luongNhanVien_datLai.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luongNhanVien_datLai.ForeColor = System.Drawing.Color.Transparent;
            this.luongNhanVien_datLai.Location = new System.Drawing.Point(148, 367);
            this.luongNhanVien_datLai.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.luongNhanVien_datLai.Name = "luongNhanVien_datLai";
            this.luongNhanVien_datLai.Size = new System.Drawing.Size(98, 47);
            this.luongNhanVien_datLai.TabIndex = 85;
            this.luongNhanVien_datLai.Text = "Đặt lại";
            this.luongNhanVien_datLai.UseVisualStyleBackColor = false;
            this.luongNhanVien_datLai.Click += new System.EventHandler(this.luongNhanVien_datLai_Click);
            // 
            // luongNhanVien_sua
            // 
            this.luongNhanVien_sua.BackColor = System.Drawing.Color.LightSeaGreen;
            this.luongNhanVien_sua.Cursor = System.Windows.Forms.Cursors.Hand;
            this.luongNhanVien_sua.FlatAppearance.BorderSize = 0;
            this.luongNhanVien_sua.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.luongNhanVien_sua.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luongNhanVien_sua.ForeColor = System.Drawing.Color.Transparent;
            this.luongNhanVien_sua.Location = new System.Drawing.Point(27, 366);
            this.luongNhanVien_sua.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.luongNhanVien_sua.Name = "luongNhanVien_sua";
            this.luongNhanVien_sua.Size = new System.Drawing.Size(98, 48);
            this.luongNhanVien_sua.TabIndex = 83;
            this.luongNhanVien_sua.Text = "Sửa";
            this.luongNhanVien_sua.UseVisualStyleBackColor = false;
            this.luongNhanVien_sua.Click += new System.EventHandler(this.luongNhanVien_sua_Click);
            // 
            // labelNgayBC
            // 
            this.labelNgayBC.AutoSize = true;
            this.labelNgayBC.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNgayBC.Location = new System.Drawing.Point(32, 271);
            this.labelNgayBC.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelNgayBC.Name = "labelNgayBC";
            this.labelNgayBC.Size = new System.Drawing.Size(78, 20);
            this.labelNgayBC.TabIndex = 80;
            this.labelNgayBC.Text = "Chức Vụ:";
            // 
            // luongNhanVien_luong
            // 
            this.luongNhanVien_luong.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.luongNhanVien_luong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luongNhanVien_luong.Location = new System.Drawing.Point(36, 230);
            this.luongNhanVien_luong.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.luongNhanVien_luong.Name = "luongNhanVien_luong";
            this.luongNhanVien_luong.Size = new System.Drawing.Size(195, 27);
            this.luongNhanVien_luong.TabIndex = 79;
            // 
            // labelLuong
            // 
            this.labelLuong.AutoSize = true;
            this.labelLuong.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelLuong.Location = new System.Drawing.Point(32, 205);
            this.labelLuong.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelLuong.Name = "labelLuong";
            this.labelLuong.Size = new System.Drawing.Size(60, 20);
            this.labelLuong.TabIndex = 78;
            this.labelLuong.Text = "Lương:";
            // 
            // luongNhanVien_ten
            // 
            this.luongNhanVien_ten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.luongNhanVien_ten.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luongNhanVien_ten.Location = new System.Drawing.Point(36, 163);
            this.luongNhanVien_ten.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.luongNhanVien_ten.Name = "luongNhanVien_ten";
            this.luongNhanVien_ten.Size = new System.Drawing.Size(195, 27);
            this.luongNhanVien_ten.TabIndex = 77;
            // 
            // labelMaNV
            // 
            this.labelMaNV.AutoSize = true;
            this.labelMaNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelMaNV.Location = new System.Drawing.Point(32, 30);
            this.labelMaNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelMaNV.Name = "labelMaNV";
            this.labelMaNV.Size = new System.Drawing.Size(119, 20);
            this.labelMaNV.TabIndex = 72;
            this.labelMaNV.Text = "Mã Nhân Viên:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(32, 138);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 20);
            this.label1.TabIndex = 76;
            this.label1.Text = "Tên:";
            // 
            // labelTenNV
            // 
            this.labelTenNV.AutoSize = true;
            this.labelTenNV.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTenNV.Location = new System.Drawing.Point(32, 85);
            this.labelTenNV.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTenNV.Name = "labelTenNV";
            this.labelTenNV.Size = new System.Drawing.Size(36, 20);
            this.labelTenNV.TabIndex = 73;
            this.labelTenNV.Text = "Họ:";
            this.labelTenNV.Click += new System.EventHandler(this.labelTenNV_Click);
            // 
            // luongNhanVien_manv
            // 
            this.luongNhanVien_manv.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.luongNhanVien_manv.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luongNhanVien_manv.Location = new System.Drawing.Point(36, 55);
            this.luongNhanVien_manv.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.luongNhanVien_manv.Name = "luongNhanVien_manv";
            this.luongNhanVien_manv.Size = new System.Drawing.Size(195, 27);
            this.luongNhanVien_manv.TabIndex = 74;
            // 
            // luongNhanVien_ho
            // 
            this.luongNhanVien_ho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.luongNhanVien_ho.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luongNhanVien_ho.Location = new System.Drawing.Point(36, 110);
            this.luongNhanVien_ho.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.luongNhanVien_ho.Name = "luongNhanVien_ho";
            this.luongNhanVien_ho.Size = new System.Drawing.Size(195, 27);
            this.luongNhanVien_ho.TabIndex = 75;
            // 
            // luongNhanVien_timKiem
            // 
            this.luongNhanVien_timKiem.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luongNhanVien_timKiem.Location = new System.Drawing.Point(109, 73);
            this.luongNhanVien_timKiem.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.luongNhanVien_timKiem.Multiline = true;
            this.luongNhanVien_timKiem.Name = "luongNhanVien_timKiem";
            this.luongNhanVien_timKiem.Size = new System.Drawing.Size(169, 23);
            this.luongNhanVien_timKiem.TabIndex = 75;
            this.luongNhanVien_timKiem.TextChanged += new System.EventHandler(this.luongNhanVien_timKiem_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Location = new System.Drawing.Point(244, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(269, 32);
            this.label2.TabIndex = 49;
            this.label2.Text = "Dữ Liệu Nhân Viên";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // luongNhanVien_dataGridView
            // 
            this.luongNhanVien_dataGridView.BackgroundColor = System.Drawing.SystemColors.ButtonHighlight;
            this.luongNhanVien_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.luongNhanVien_dataGridView.Location = new System.Drawing.Point(25, 111);
            this.luongNhanVien_dataGridView.Name = "luongNhanVien_dataGridView";
            this.luongNhanVien_dataGridView.ReadOnly = true;
            this.luongNhanVien_dataGridView.RowHeadersWidth = 51;
            this.luongNhanVien_dataGridView.RowTemplate.Height = 24;
            this.luongNhanVien_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.luongNhanVien_dataGridView.Size = new System.Drawing.Size(687, 420);
            this.luongNhanVien_dataGridView.TabIndex = 47;
            this.luongNhanVien_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.luongNhanVien_dataGridView_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.Controls.Add(this.label3);
            this.panel2.Controls.Add(this.luongNhanVien_dataGridView);
            this.panel2.Controls.Add(this.label2);
            this.panel2.Controls.Add(this.luongNhanVien_timKiem);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Right;
            this.panel2.Location = new System.Drawing.Point(286, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(732, 551);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint_1);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Tahoma", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(16, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(86, 21);
            this.label3.TabIndex = 76;
            this.label3.Text = "Tìm Kiếm:";
            // 
            // luongNhanVien_xoa
            // 
            this.luongNhanVien_xoa.BackColor = System.Drawing.Color.LightSeaGreen;
            this.luongNhanVien_xoa.Cursor = System.Windows.Forms.Cursors.Hand;
            this.luongNhanVien_xoa.FlatAppearance.BorderSize = 0;
            this.luongNhanVien_xoa.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.luongNhanVien_xoa.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.luongNhanVien_xoa.ForeColor = System.Drawing.Color.Transparent;
            this.luongNhanVien_xoa.Location = new System.Drawing.Point(84, 436);
            this.luongNhanVien_xoa.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.luongNhanVien_xoa.Name = "luongNhanVien_xoa";
            this.luongNhanVien_xoa.Size = new System.Drawing.Size(98, 47);
            this.luongNhanVien_xoa.TabIndex = 84;
            this.luongNhanVien_xoa.Text = "Xóa";
            this.luongNhanVien_xoa.UseVisualStyleBackColor = false;
            this.luongNhanVien_xoa.Click += new System.EventHandler(this.luongNhanVien_xoa_Click);
            // 
            // FormSalary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormSalary";
            this.Size = new System.Drawing.Size(1018, 551);
            this.Load += new System.EventHandler(this.FormSalary_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.luongNhanVien_dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.DataGridView luongNhanVien_dataGridView;
        private System.Windows.Forms.TextBox luongNhanVien_ten;
        private System.Windows.Forms.Label labelMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTenNV;
        private System.Windows.Forms.TextBox luongNhanVien_manv;
        private System.Windows.Forms.TextBox luongNhanVien_ho;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox luongNhanVien_luong;
        private System.Windows.Forms.Label labelLuong;
        private System.Windows.Forms.Label labelNgayBC;
        private System.Windows.Forms.Button luongNhanVien_sua;
        private System.Windows.Forms.Button luongNhanVien_datLai;
        private System.Windows.Forms.TextBox luongNhanVien_timKiem;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox luongNhanVien_chucVu;
        private System.Windows.Forms.Button luongNhanVien_xoa;
    }
}
