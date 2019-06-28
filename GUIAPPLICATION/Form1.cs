using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.IO;

namespace GUIAPPLICATION
{
    public partial class Form1 : Form
    {

        private bool mousedown;
        private Point lastlocation;

        int texturestyle = 0;
        int selectshape = 0;

        Color paintcolor = Color.Black;

        Graphics g;
        Pen p;
        Brush br;
        int x, y = 0;
        int x1, y1, x2, y2 = 0;
        public Form1()
        {

            InitializeComponent();
            g = drawareapanel.CreateGraphics();
            p = new Pen(showcolorbox.BackColor);

            int x_canvas = drawareapanel.Width / 2;
            int y_canvas = drawareapanel.Height / 2;
            lbl_StartPosX.Text = x_canvas.ToString();
            lbl_StartPosY.Text = y_canvas.ToString();
            lbl_canvasx.Text = x_canvas.ToString();
            lbl_canvasy.Text = y_canvas.ToString();


            br = new HatchBrush(HatchStyle.Vertical, Color.Red, Color.FromArgb(255, 128, 255, 255));
            g.FillEllipse(br, 0, 0, 100, 60);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            texturestyle = 0;
            ColorDialog c = new ColorDialog();
            c.ShowDialog();
            paintcolor = c.Color;

            showcolorbox.BackColor = paintcolor;
            p.Color = c.Color;
        }

        private void btnpen_Click(object sender, EventArgs e)
        {
            selectshape = 1;
        }

        private void btneclipse_Click(object sender, EventArgs e)
        {
            selectshape = 2;
        }

        private void btntriangle_Click(object sender, EventArgs e)
        {
            selectshape = 3;
        }

        private void btnrectangle_Click(object sender, EventArgs e)
        {
            selectshape = 4;
        }

        private void btnsquare_Click(object sender, EventArgs e)
        {
            selectshape = 5;
        }

        private void btnploygon_Click(object sender, EventArgs e)
        {
            selectshape = 6;
        }

        private void drawareapanel_Paint(object sender, PaintEventArgs e)
        {

        }
        bool start;
        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            mousedown = true;
            lastlocation = e.Location;
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            if (mousedown)
            {
                this.Location = new Point(
                    (this.Location.X - lastlocation.X) + e.X, (this.Location.Y - lastlocation.Y) + e.Y);

                this.Update();
            }
        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {
            mousedown = false;
        }

        private void btn_console1clear_Click(object sender, EventArgs e)
        {
            rtxt_console.Text = "";
        }

        private void drawareapanel_MouseClick(object sender, MouseEventArgs e)
        {
            lbl_StartPosX.Text = (e.X).ToString();
            lbl_StartPosY.Text = (e.Y).ToString();
        }

        private void drawareapanel_MouseDown(object sender, MouseEventArgs e)
        {
            start = true;
            x1 = e.X;
            y1 = e.Y;
        }

        private void drawareapanel_MouseLeave(object sender, EventArgs e)
        {
            start = false;
            x = 0;
            y = 0;
        }

        private void drawareapanel_MouseMove(object sender, MouseEventArgs e)
        {
            lbl_cursorx.Text = e.X.ToString();
            lbl_cursory.Text = e.Y.ToString();
            if (start)
            {
                if (selectshape == 1)
                {
                    if (x > 0 && y > 00)
                    {
                        g.DrawLine(p, x, y, e.X, e.Y);
                    }

                    x = e.X;
                    y = e.Y;
                }
                else if (selectshape == 2)
                {

                    if (x > 0 && y > 00)
                    {

                        g.FillRectangle(new SolidBrush(paintcolor), x1, y1, e.X - x1, e.Y - y1);
                    }

                    x = e.X;
                    y = e.Y;
                }
                else if (selectshape == 4)
                {


                    if (x > 0 && y > 00)
                    {
                        g.FillEllipse(new SolidBrush(paintcolor), e.X, e.Y, 40, 50);
                    }


                    x = e.X;
                    y = e.Y;
                }
            }
        }
    }
}
