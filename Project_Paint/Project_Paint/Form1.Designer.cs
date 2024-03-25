namespace Project_Paint
{
    partial class Form1
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.clear_Btn = new System.Windows.Forms.Button();
            this.save_Btn = new System.Windows.Forms.Button();
            this.line_Btn = new System.Windows.Forms.Button();
            this.color_Btn = new System.Windows.Forms.Button();
            this.rectangle_Btn = new System.Windows.Forms.Button();
            this.elipse_Btn = new System.Windows.Forms.Button();
            this.eraser_Btn = new System.Windows.Forms.Button();
            this.pencill_Btn = new System.Windows.Forms.Button();
            this.fill_Btn = new System.Windows.Forms.Button();
            this.pic_color = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pic = new System.Windows.Forms.PictureBox();
            this.color_picker = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel1.Controls.Add(this.clear_Btn);
            this.panel1.Controls.Add(this.save_Btn);
            this.panel1.Controls.Add(this.color_picker);
            this.panel1.Controls.Add(this.line_Btn);
            this.panel1.Controls.Add(this.color_Btn);
            this.panel1.Controls.Add(this.rectangle_Btn);
            this.panel1.Controls.Add(this.elipse_Btn);
            this.panel1.Controls.Add(this.eraser_Btn);
            this.panel1.Controls.Add(this.pencill_Btn);
            this.panel1.Controls.Add(this.fill_Btn);
            this.panel1.Controls.Add(this.pic_color);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1299, 140);
            this.panel1.TabIndex = 0;
            // 
            // clear_Btn
            // 
            this.clear_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.clear_Btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.clear_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.clear_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.clear_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.clear_Btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.clear_Btn.Location = new System.Drawing.Point(1150, 78);
            this.clear_Btn.Name = "clear_Btn";
            this.clear_Btn.Size = new System.Drawing.Size(118, 34);
            this.clear_Btn.TabIndex = 10;
            this.clear_Btn.Text = "Clear";
            this.clear_Btn.UseVisualStyleBackColor = true;
            this.clear_Btn.Click += new System.EventHandler(this.clear_Btn_Click);
            // 
            // save_Btn
            // 
            this.save_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.save_Btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.save_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.save_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.save_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.save_Btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.save_Btn.Location = new System.Drawing.Point(1150, 24);
            this.save_Btn.Name = "save_Btn";
            this.save_Btn.Size = new System.Drawing.Size(118, 38);
            this.save_Btn.TabIndex = 9;
            this.save_Btn.Text = "Save";
            this.save_Btn.UseVisualStyleBackColor = true;
            this.save_Btn.Click += new System.EventHandler(this.save_Btn_Click);
            // 
            // line_Btn
            // 
            this.line_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.line_Btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.line_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.line_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.line_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.line_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.line_Btn.Image = global::Project_Paint.Properties.Resources.line;
            this.line_Btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.line_Btn.Location = new System.Drawing.Point(1038, 33);
            this.line_Btn.Name = "line_Btn";
            this.line_Btn.Size = new System.Drawing.Size(83, 73);
            this.line_Btn.TabIndex = 7;
            this.line_Btn.Text = "Line";
            this.line_Btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.line_Btn.UseVisualStyleBackColor = true;
            this.line_Btn.Click += new System.EventHandler(this.line_Btn_Click);
            // 
            // color_Btn
            // 
            this.color_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.color_Btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.color_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.color_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.color_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.color_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.color_Btn.Image = global::Project_Paint.Properties.Resources.color;
            this.color_Btn.Location = new System.Drawing.Point(496, 33);
            this.color_Btn.Name = "color_Btn";
            this.color_Btn.Size = new System.Drawing.Size(83, 73);
            this.color_Btn.TabIndex = 6;
            this.color_Btn.Text = "Color";
            this.color_Btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.color_Btn.UseVisualStyleBackColor = true;
            this.color_Btn.Click += new System.EventHandler(this.color_Btn_Click);
            // 
            // rectangle_Btn
            // 
            this.rectangle_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.rectangle_Btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.rectangle_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.rectangle_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.rectangle_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rectangle_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.rectangle_Btn.Image = global::Project_Paint.Properties.Resources.rectangle;
            this.rectangle_Btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.rectangle_Btn.Location = new System.Drawing.Point(941, 33);
            this.rectangle_Btn.Name = "rectangle_Btn";
            this.rectangle_Btn.Size = new System.Drawing.Size(91, 73);
            this.rectangle_Btn.TabIndex = 5;
            this.rectangle_Btn.Text = "Rectangle";
            this.rectangle_Btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.rectangle_Btn.UseVisualStyleBackColor = true;
            this.rectangle_Btn.Click += new System.EventHandler(this.rectangle_Btn_Click);
            // 
            // elipse_Btn
            // 
            this.elipse_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.elipse_Btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.elipse_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.elipse_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.elipse_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.elipse_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.elipse_Btn.Image = global::Project_Paint.Properties.Resources.circle;
            this.elipse_Btn.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.elipse_Btn.Location = new System.Drawing.Point(852, 33);
            this.elipse_Btn.Name = "elipse_Btn";
            this.elipse_Btn.Size = new System.Drawing.Size(83, 73);
            this.elipse_Btn.TabIndex = 4;
            this.elipse_Btn.Text = "Elipse";
            this.elipse_Btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.elipse_Btn.UseVisualStyleBackColor = true;
            this.elipse_Btn.Click += new System.EventHandler(this.elipse_Btn_Click);
            // 
            // eraser_Btn
            // 
            this.eraser_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.eraser_Btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.eraser_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.eraser_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.eraser_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.eraser_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.eraser_Btn.Image = global::Project_Paint.Properties.Resources.eraser;
            this.eraser_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.eraser_Btn.Location = new System.Drawing.Point(763, 33);
            this.eraser_Btn.Name = "eraser_Btn";
            this.eraser_Btn.Size = new System.Drawing.Size(83, 73);
            this.eraser_Btn.TabIndex = 3;
            this.eraser_Btn.Text = "Eraser";
            this.eraser_Btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.eraser_Btn.UseVisualStyleBackColor = true;
            this.eraser_Btn.Click += new System.EventHandler(this.eraser_Btn_Click);
            // 
            // pencill_Btn
            // 
            this.pencill_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pencill_Btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.pencill_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.pencill_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.pencill_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.pencill_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pencill_Btn.Image = global::Project_Paint.Properties.Resources.pencil;
            this.pencill_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.pencill_Btn.Location = new System.Drawing.Point(674, 33);
            this.pencill_Btn.Name = "pencill_Btn";
            this.pencill_Btn.Size = new System.Drawing.Size(83, 73);
            this.pencill_Btn.TabIndex = 2;
            this.pencill_Btn.Text = "Pencill";
            this.pencill_Btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.pencill_Btn.UseVisualStyleBackColor = true;
            this.pencill_Btn.Click += new System.EventHandler(this.pencill_Btn_Click);
            // 
            // fill_Btn
            // 
            this.fill_Btn.Cursor = System.Windows.Forms.Cursors.Hand;
            this.fill_Btn.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.fill_Btn.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Maroon;
            this.fill_Btn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.fill_Btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.fill_Btn.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.fill_Btn.Image = global::Project_Paint.Properties.Resources.bucket;
            this.fill_Btn.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.fill_Btn.Location = new System.Drawing.Point(585, 33);
            this.fill_Btn.Name = "fill_Btn";
            this.fill_Btn.Size = new System.Drawing.Size(83, 73);
            this.fill_Btn.TabIndex = 1;
            this.fill_Btn.Text = "Fill";
            this.fill_Btn.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.fill_Btn.UseVisualStyleBackColor = true;
            this.fill_Btn.Click += new System.EventHandler(this.fill_Btn_Click);
            // 
            // pic_color
            // 
            this.pic_color.Location = new System.Drawing.Point(418, 53);
            this.pic_color.Name = "pic_color";
            this.pic_color.Size = new System.Drawing.Size(44, 38);
            this.pic_color.TabIndex = 0;
            this.pic_color.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel2.Location = new System.Drawing.Point(0, 603);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1299, 26);
            this.panel2.TabIndex = 1;
            // 
            // pic
            // 
            this.pic.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.pic.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pic.Location = new System.Drawing.Point(0, 140);
            this.pic.Name = "pic";
            this.pic.Size = new System.Drawing.Size(1299, 463);
            this.pic.TabIndex = 2;
            this.pic.TabStop = false;
            this.pic.Paint += new System.Windows.Forms.PaintEventHandler(this.pic_Paint);
            this.pic.MouseClick += new System.Windows.Forms.MouseEventHandler(this.pic_MouseClick);
            this.pic.MouseDown += new System.Windows.Forms.MouseEventHandler(this.pic_MouseDown);
            this.pic.MouseMove += new System.Windows.Forms.MouseEventHandler(this.pic_MouseMove);
            this.pic.MouseUp += new System.Windows.Forms.MouseEventHandler(this.pic_MouseUp);
            // 
            // color_picker
            // 
            this.color_picker.Image = global::Project_Paint.Properties.Resources.color_palette;
            this.color_picker.Location = new System.Drawing.Point(3, -3);
            this.color_picker.Name = "color_picker";
            this.color_picker.Size = new System.Drawing.Size(386, 140);
            this.color_picker.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.color_picker.TabIndex = 8;
            this.color_picker.TabStop = false;
            this.color_picker.MouseClick += new System.Windows.Forms.MouseEventHandler(this.color_picker_MouseClick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1299, 629);
            this.Controls.Add(this.pic);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.color_picker)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.PictureBox pic;
        private System.Windows.Forms.Button fill_Btn;
        private System.Windows.Forms.Button pic_color;
        private System.Windows.Forms.Button line_Btn;
        private System.Windows.Forms.Button color_Btn;
        private System.Windows.Forms.Button rectangle_Btn;
        private System.Windows.Forms.Button elipse_Btn;
        private System.Windows.Forms.Button eraser_Btn;
        private System.Windows.Forms.Button pencill_Btn;
        private System.Windows.Forms.Button clear_Btn;
        private System.Windows.Forms.Button save_Btn;
        private System.Windows.Forms.PictureBox color_picker;
    }
}

