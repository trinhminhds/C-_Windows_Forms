namespace QuanLyNhanVien
{
    partial class FormAddEmployees
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddEmployees));
            this.panel1 = new System.Windows.Forms.Panel();
            this.label3 = new System.Windows.Forms.Label();
            this.addNhanVien_timKiem = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.addNhanVien_dataGridView = new System.Windows.Forms.DataGridView();
            this.panel2 = new System.Windows.Forms.Panel();
            this.addNhanVien_chucVu = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.addNhanVien_gioiTinh = new System.Windows.Forms.ComboBox();
            this.addNhanVien_datLaiNhanVien = new System.Windows.Forms.Button();
            this.addNhanVien_xoaNhanVien = new System.Windows.Forms.Button();
            this.addNhanVien_suaNhanVien = new System.Windows.Forms.Button();
            this.addNhanVien_themNhanVien = new System.Windows.Forms.Button();
            this.addNhanVien_ten = new System.Windows.Forms.TextBox();
            this.labelMaNV = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.labelTenNV = new System.Windows.Forms.Label();
            this.addNhanVien_manhanvien = new System.Windows.Forms.TextBox();
            this.addNhanVien_diaChi = new System.Windows.Forms.TextBox();
            this.addNhanVien_ho = new System.Windows.Forms.TextBox();
            this.addNhanVien_ngaySinh = new System.Windows.Forms.DateTimePicker();
            this.addNhanVien_sdt = new System.Windows.Forms.TextBox();
            this.labelNgayBC = new System.Windows.Forms.Label();
            this.labelNgaySinh = new System.Windows.Forms.Label();
            this.labelDiaChi = new System.Windows.Forms.Label();
            this.labelSDT = new System.Windows.Forms.Label();
            this.qLNHANVIENJAVADataSet = new QuanLyNhanVien.QLNHANVIENJAVADataSet();
            this.nhanvienTableAdapter = new QuanLyNhanVien.QLNHANVIENJAVADataSetTableAdapters.nhanvienTableAdapter();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addNhanVien_dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANVIENJAVADataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.addNhanVien_timKiem);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.addNhanVien_dataGridView);
            resources.ApplyResources(this.panel1, "panel1");
            this.panel1.Name = "panel1";
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // label3
            // 
            resources.ApplyResources(this.label3, "label3");
            this.label3.Name = "label3";
            // 
            // addNhanVien_timKiem
            // 
            resources.ApplyResources(this.addNhanVien_timKiem, "addNhanVien_timKiem");
            this.addNhanVien_timKiem.Name = "addNhanVien_timKiem";
            this.addNhanVien_timKiem.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            this.addNhanVien_timKiem.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addNhanVien_timKiem_KeyPress);
            this.addNhanVien_timKiem.Leave += new System.EventHandler(this.addNhanVien_timKiem_Leave);
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.label2.ForeColor = System.Drawing.Color.LightSeaGreen;
            this.label2.Name = "label2";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // addNhanVien_dataGridView
            // 
            this.addNhanVien_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.addNhanVien_dataGridView.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.addNhanVien_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            resources.ApplyResources(this.addNhanVien_dataGridView, "addNhanVien_dataGridView");
            this.addNhanVien_dataGridView.Name = "addNhanVien_dataGridView";
            this.addNhanVien_dataGridView.ReadOnly = true;
            this.addNhanVien_dataGridView.RowTemplate.Height = 24;
            this.addNhanVien_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.addNhanVien_dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.addNhanVien_dataGridView_CellContentClick);
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel2.Controls.Add(this.addNhanVien_chucVu);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Controls.Add(this.addNhanVien_gioiTinh);
            this.panel2.Controls.Add(this.addNhanVien_datLaiNhanVien);
            this.panel2.Controls.Add(this.addNhanVien_xoaNhanVien);
            this.panel2.Controls.Add(this.addNhanVien_suaNhanVien);
            this.panel2.Controls.Add(this.addNhanVien_themNhanVien);
            this.panel2.Controls.Add(this.addNhanVien_ten);
            this.panel2.Controls.Add(this.labelMaNV);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.labelTenNV);
            this.panel2.Controls.Add(this.addNhanVien_manhanvien);
            this.panel2.Controls.Add(this.addNhanVien_diaChi);
            this.panel2.Controls.Add(this.addNhanVien_ho);
            this.panel2.Controls.Add(this.addNhanVien_ngaySinh);
            this.panel2.Controls.Add(this.addNhanVien_sdt);
            this.panel2.Controls.Add(this.labelNgayBC);
            this.panel2.Controls.Add(this.labelNgaySinh);
            this.panel2.Controls.Add(this.labelDiaChi);
            this.panel2.Controls.Add(this.labelSDT);
            resources.ApplyResources(this.panel2, "panel2");
            this.panel2.Name = "panel2";
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // addNhanVien_chucVu
            // 
            this.addNhanVien_chucVu.FormattingEnabled = true;
            this.addNhanVien_chucVu.Items.AddRange(new object[] {
            resources.GetString("addNhanVien_chucVu.Items"),
            resources.GetString("addNhanVien_chucVu.Items1"),
            resources.GetString("addNhanVien_chucVu.Items2"),
            resources.GetString("addNhanVien_chucVu.Items3"),
            resources.GetString("addNhanVien_chucVu.Items4"),
            resources.GetString("addNhanVien_chucVu.Items5"),
            resources.GetString("addNhanVien_chucVu.Items6"),
            resources.GetString("addNhanVien_chucVu.Items7"),
            resources.GetString("addNhanVien_chucVu.Items8")});
            resources.ApplyResources(this.addNhanVien_chucVu, "addNhanVien_chucVu");
            this.addNhanVien_chucVu.Name = "addNhanVien_chucVu";
            // 
            // label4
            // 
            resources.ApplyResources(this.label4, "label4");
            this.label4.Name = "label4";
            // 
            // addNhanVien_gioiTinh
            // 
            this.addNhanVien_gioiTinh.FormattingEnabled = true;
            this.addNhanVien_gioiTinh.Items.AddRange(new object[] {
            resources.GetString("addNhanVien_gioiTinh.Items"),
            resources.GetString("addNhanVien_gioiTinh.Items1"),
            resources.GetString("addNhanVien_gioiTinh.Items2")});
            resources.ApplyResources(this.addNhanVien_gioiTinh, "addNhanVien_gioiTinh");
            this.addNhanVien_gioiTinh.Name = "addNhanVien_gioiTinh";
            // 
            // addNhanVien_datLaiNhanVien
            // 
            this.addNhanVien_datLaiNhanVien.BackColor = System.Drawing.Color.LightSeaGreen;
            this.addNhanVien_datLaiNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.addNhanVien_datLaiNhanVien, "addNhanVien_datLaiNhanVien");
            this.addNhanVien_datLaiNhanVien.ForeColor = System.Drawing.Color.Transparent;
            this.addNhanVien_datLaiNhanVien.Name = "addNhanVien_datLaiNhanVien";
            this.addNhanVien_datLaiNhanVien.UseVisualStyleBackColor = false;
            this.addNhanVien_datLaiNhanVien.Click += new System.EventHandler(this.addNhanVien_datLaiNhanVien_Click);
            // 
            // addNhanVien_xoaNhanVien
            // 
            this.addNhanVien_xoaNhanVien.BackColor = System.Drawing.Color.LightSeaGreen;
            this.addNhanVien_xoaNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.addNhanVien_xoaNhanVien, "addNhanVien_xoaNhanVien");
            this.addNhanVien_xoaNhanVien.ForeColor = System.Drawing.Color.Transparent;
            this.addNhanVien_xoaNhanVien.Name = "addNhanVien_xoaNhanVien";
            this.addNhanVien_xoaNhanVien.UseVisualStyleBackColor = false;
            this.addNhanVien_xoaNhanVien.Click += new System.EventHandler(this.addNhanVien_xoaNhanVien_Click);
            // 
            // addNhanVien_suaNhanVien
            // 
            this.addNhanVien_suaNhanVien.BackColor = System.Drawing.Color.LightSeaGreen;
            this.addNhanVien_suaNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.addNhanVien_suaNhanVien, "addNhanVien_suaNhanVien");
            this.addNhanVien_suaNhanVien.ForeColor = System.Drawing.Color.Transparent;
            this.addNhanVien_suaNhanVien.Name = "addNhanVien_suaNhanVien";
            this.addNhanVien_suaNhanVien.UseVisualStyleBackColor = false;
            this.addNhanVien_suaNhanVien.Click += new System.EventHandler(this.addNhanVien_suaNhanVien_Click);
            // 
            // addNhanVien_themNhanVien
            // 
            this.addNhanVien_themNhanVien.BackColor = System.Drawing.Color.LightSeaGreen;
            this.addNhanVien_themNhanVien.Cursor = System.Windows.Forms.Cursors.Hand;
            resources.ApplyResources(this.addNhanVien_themNhanVien, "addNhanVien_themNhanVien");
            this.addNhanVien_themNhanVien.ForeColor = System.Drawing.Color.Transparent;
            this.addNhanVien_themNhanVien.Name = "addNhanVien_themNhanVien";
            this.addNhanVien_themNhanVien.UseVisualStyleBackColor = false;
            this.addNhanVien_themNhanVien.Click += new System.EventHandler(this.addNhanVien_themNhanVien_Click);
            // 
            // addNhanVien_ten
            // 
            this.addNhanVien_ten.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.addNhanVien_ten, "addNhanVien_ten");
            this.addNhanVien_ten.Name = "addNhanVien_ten";
            // 
            // labelMaNV
            // 
            resources.ApplyResources(this.labelMaNV, "labelMaNV");
            this.labelMaNV.Name = "labelMaNV";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.Name = "label1";
            // 
            // labelTenNV
            // 
            resources.ApplyResources(this.labelTenNV, "labelTenNV");
            this.labelTenNV.Name = "labelTenNV";
            this.labelTenNV.Click += new System.EventHandler(this.labelTenNV_Click);
            // 
            // addNhanVien_manhanvien
            // 
            this.addNhanVien_manhanvien.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.addNhanVien_manhanvien, "addNhanVien_manhanvien");
            this.addNhanVien_manhanvien.Name = "addNhanVien_manhanvien";
            // 
            // addNhanVien_diaChi
            // 
            this.addNhanVien_diaChi.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.addNhanVien_diaChi, "addNhanVien_diaChi");
            this.addNhanVien_diaChi.Name = "addNhanVien_diaChi";
            // 
            // addNhanVien_ho
            // 
            this.addNhanVien_ho.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.addNhanVien_ho, "addNhanVien_ho");
            this.addNhanVien_ho.Name = "addNhanVien_ho";
            // 
            // addNhanVien_ngaySinh
            // 
            resources.ApplyResources(this.addNhanVien_ngaySinh, "addNhanVien_ngaySinh");
            this.addNhanVien_ngaySinh.Name = "addNhanVien_ngaySinh";
            this.addNhanVien_ngaySinh.Value = new System.DateTime(2024, 2, 21, 0, 0, 0, 0);
            // 
            // addNhanVien_sdt
            // 
            this.addNhanVien_sdt.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            resources.ApplyResources(this.addNhanVien_sdt, "addNhanVien_sdt");
            this.addNhanVien_sdt.Name = "addNhanVien_sdt";
            // 
            // labelNgayBC
            // 
            resources.ApplyResources(this.labelNgayBC, "labelNgayBC");
            this.labelNgayBC.Name = "labelNgayBC";
            // 
            // labelNgaySinh
            // 
            resources.ApplyResources(this.labelNgaySinh, "labelNgaySinh");
            this.labelNgaySinh.Name = "labelNgaySinh";
            // 
            // labelDiaChi
            // 
            resources.ApplyResources(this.labelDiaChi, "labelDiaChi");
            this.labelDiaChi.Name = "labelDiaChi";
            // 
            // labelSDT
            // 
            resources.ApplyResources(this.labelSDT, "labelSDT");
            this.labelSDT.Name = "labelSDT";
            this.labelSDT.Click += new System.EventHandler(this.labelSDT_Click);
            // 
            // qLNHANVIENJAVADataSet
            // 
            this.qLNHANVIENJAVADataSet.DataSetName = "QLNHANVIENJAVADataSet";
            this.qLNHANVIENJAVADataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // nhanvienTableAdapter
            // 
            this.nhanvienTableAdapter.ClearBeforeFill = true;
            // 
            // FormAddEmployees
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Name = "FormAddEmployees";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.addNhanVien_dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.qLNHANVIENJAVADataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.TextBox addNhanVien_ten;
        private System.Windows.Forms.Label labelMaNV;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label labelTenNV;
        private System.Windows.Forms.TextBox addNhanVien_manhanvien;
        private System.Windows.Forms.TextBox addNhanVien_diaChi;
        private System.Windows.Forms.TextBox addNhanVien_ho;
        private System.Windows.Forms.DateTimePicker addNhanVien_ngaySinh;
        private System.Windows.Forms.TextBox addNhanVien_sdt;
        private System.Windows.Forms.Label labelNgayBC;
        private System.Windows.Forms.Label labelNgaySinh;
        private System.Windows.Forms.Label labelDiaChi;
        private System.Windows.Forms.Label labelSDT;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView addNhanVien_dataGridView;
        private System.Windows.Forms.TextBox addNhanVien_timKiem;
        private System.Windows.Forms.Button addNhanVien_datLaiNhanVien;
        private System.Windows.Forms.Button addNhanVien_xoaNhanVien;
        private System.Windows.Forms.Button addNhanVien_suaNhanVien;
        private System.Windows.Forms.Button addNhanVien_themNhanVien;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox addNhanVien_gioiTinh;
        private System.Windows.Forms.ComboBox addNhanVien_chucVu;
        private QLNHANVIENJAVADataSet qLNHANVIENJAVADataSet;
        private QLNHANVIENJAVADataSetTableAdapters.nhanvienTableAdapter nhanvienTableAdapter;
    }
}
