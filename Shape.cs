using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OOP_LB_2
{
    abstract class Shape
    {
        public int x, y, width, height;
        public Shape(int x, int y, int width, int height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
        abstract public double Area();
        abstract public void Draw(PictureBox pictBox, Color colr);

    }
}
