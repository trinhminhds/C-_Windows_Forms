using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project_Paint
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();  

            this.Width = 1000; 
            this.Height = 600;
            bitmap = new Bitmap(pic.Width, pic.Height);
            graphics = Graphics.FromImage(bitmap);
            graphics.Clear(Color.White);
            pic.Image = bitmap;
            
        }


        Bitmap bitmap;
        Graphics graphics;
        bool paint = false;
        Point px, py;
        Pen pen = new Pen(Color.Black, 1);
        Pen erase = new Pen (Color.White, 10);
        int index;
        int x,y, sX, sY, cX, cY;
        ColorDialog cd  = new ColorDialog();
        Color new_color;
        

        private void pic_MouseDown(object sender, MouseEventArgs e)
        {
            paint = true;
            py = e.Location;

            cX = e.X; 
            cY = e.Y;
        }

        

        private void pic_MouseMove(object sender, MouseEventArgs e)
        {
            if (paint)
            {
                if(index == 1)
                {
                    px = e.Location;
                    graphics.DrawLine(pen, px, py);
                    py = px;
                }
                if (index == 2)
                {
                    px = e.Location;
                    graphics.DrawLine(erase, px, py);
                    py = px;
                }
            }
            pic.Refresh();

            x = e.X; 
            y = e.Y;
            sX = e.X - cX;
            sY = e.Y - cY;

        }

        private void pic_Paint(object sender, PaintEventArgs e)
        {
            Graphics graphics = e.Graphics;
            if (paint)
            {
                if (index == 3)
                {
                    graphics.DrawEllipse(pen, cX, cY, sX, sY);
                }
                if (index == 4)
                {
                    graphics.DrawRectangle(pen, cX, cY, sX, sY);
                }
                if (index == 5)
                {
                    graphics.DrawLine(pen, cX, cY, x, y);
                }
            }
        }

        

        private void pic_MouseUp(object sender, MouseEventArgs e)
        {
            paint = false;

            sX = x - cX;
            sY = y - cY;


            if (index == 3)
            {
                graphics.DrawEllipse(pen, cX, cY, sX, sY);
            }
            if(index == 4)
            {
                graphics.DrawRectangle(pen, cX, cY, sX,sY);
            }
            if(index == 5) {
                graphics.DrawLine(pen, cX, cY, x, y);
            }


        }

        

        private void pencill_Btn_Click(object sender, EventArgs e)
        {
            index = 1;
        }

        

        private void eraser_Btn_Click(object sender, EventArgs e)
        {
            index = 2;
        }

        private void elipse_Btn_Click(object sender, EventArgs e)
        {
            index = 3;
        }

        

        private void rectangle_Btn_Click(object sender, EventArgs e)
        {
            index = 4;
        }

        private void line_Btn_Click(object sender, EventArgs e)
        {
            index = 5;
        }

        private void clear_Btn_Click(object sender, EventArgs e)
        {
            graphics.Clear(Color.White);
            pic.Image = bitmap;
            index = 0;
        }

        

        private void save_Btn_Click(object sender, EventArgs e)
        {

        }

       

        private void color_Btn_Click(object sender, EventArgs e)
        {
            
                cd.ShowDialog();
                new_color = cd.Color;
                pic_color.BackColor = cd.Color;
                pen.Color = cd.Color;
                
        }


        private void color_picker_MouseClick(object sender, MouseEventArgs e)
        {
        
        }

        private void validate(Bitmap bitmap, Stack<Point> stack, int x, int y, Color old_color, Color new_color)
        {
            Color color = bitmap.GetPixel(x, y);
            if (color == old_color)
            {
                stack.Push(new Point(x, y));
                bitmap.SetPixel(x, y, new_color);
            }
        }

        public void Fill(Bitmap bitmap, int x, int y, Color new_color)
        {
            Color old_color = bitmap.GetPixel(x, y);
            Stack<Point> pixel = new Stack<Point>();
            pixel.Push(new Point(x, y));
            bitmap.SetPixel(x, y, new_color);
            if (old_color == new_color)
            {
                return;
            }

            while (pixel.Count > 0)
            {
                Point point = pixel.Pop();
                if (point.X > 0 && point.Y > 0 && point.X < bitmap.Width - 1 && point.Y < bitmap.Height - 1)
                {
                    validate(bitmap, pixel, point.X - 1, point.Y, old_color, new_color);
                    validate(bitmap, pixel, point.X, point.Y - 1, old_color, new_color);
                    validate(bitmap, pixel, point.X + 1, point.Y, old_color, new_color);
                    validate(bitmap, pixel, point.X, point.Y + 1, old_color, new_color);

                }

            }

        }

        private void pic_MouseClick(object sender, MouseEventArgs e)
        {
            if(index == 7) {
                Point point = new Point(e.X, e.Y);
                Fill(bitmap,point.X,point.Y,new_color);
            }

        }

        private void fill_Btn_Click(object sender, EventArgs e)
        {
            index = 7;
        }


       




    }
}
