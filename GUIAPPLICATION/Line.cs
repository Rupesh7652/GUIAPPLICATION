using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Windows.Forms;

namespace GUIAPPLICATION
{
    class Line : Shape
    {
        int x, y, size, size1;
        Color c1;
        int texturestyle;
        Brush bb;
        public override void draw(Graphics g)
        {
            Pen p = new Pen(c1, 5);
            if (texturestyle == 0)
            {
                g.DrawLine(p, x, y, size, size1);
            }
            else
            {
                g.DrawLine(p, x, y, size, size1);
            }
        }
    }
}
