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

        private void imageToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog o = new OpenFileDialog();
            o.Filter = "PNG Files|*.png|JPEG Files|*.jpeg|Bitmap|*.bmp";
            if (o.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                drawareapanel.BackgroundImage = (Image)Image.FromFile(o.FileName).Clone();
                drawareapanel.BackgroundImageLayout = ImageLayout.Zoom;
            }
            MessageBox.Show("open");
        }

        private void imageToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfdlg = new SaveFileDialog();
            sfdlg.Title = "Save Dialog";
            sfdlg.Filter = "Bitmap Images (*.bmp)|*.bmp|All files(*.*)|*.*";
            if (sfdlg.ShowDialog(this) == DialogResult.OK)
            {
                using (Bitmap bmp = new Bitmap(drawareapanel.Width, drawareapanel.Height))
                {

               
                    drawareapanel.BackgroundImage = new Bitmap(drawareapanel.Width, drawareapanel.Height);
                    drawareapanel.BackgroundImage.Save(sfdlg.FileName);
                    bmp.Save(sfdlg.FileName);
                    MessageBox.Show("Saved Successfully.....");

                }
            }
        }

        private void textToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog op = new OpenFileDialog();
            if (op.ShowDialog() == DialogResult.OK)
            {
                rtxt_console.LoadFile(op.FileName, RichTextBoxStreamType.PlainText);
                this.Text = op.FileName;
            }
        }

        private void textToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                rtxt_console.SaveFile(sv.FileName, RichTextBoxStreamType.PlainText);
                this.Text = sv.FileName;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SaveFileDialog sv = new SaveFileDialog();
            sv.Filter = "Text Document(*.txt)|*.txt|All Files(*.*)|*.*";
            if (sv.ShowDialog() == DialogResult.OK)
            {
                rtxt_console.SaveFile(sv.FileName, RichTextBoxStreamType.PlainText);
                this.Text = sv.FileName;
            }
        }



        //\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
        //==============================================================================================================
        //======================-----=====----======================DECLARING =========================---------- *  *  * * * * ** * 
        public int _size1, _size2, _size3, _size4, _size5, _size6, _size7, _size8, _size9, _size10, _size11, _size12;



        /// <summary>
        /// declaring variable for triangle
        /// </summary>
        public int xi1, yi1, xi2, yi2, xii1, yii1, xii2, yii2, xiii1, yiii1, xiii2, yiii2;




        /// <summary>
        /// declaring variable for repeat number
        /// </summary>
        public int _repeatNo;

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
