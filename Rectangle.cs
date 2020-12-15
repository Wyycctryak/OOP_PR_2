using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
namespace OOP_LB_2
{
    class Rectangle : Shape
    {
        public Rectangle(int x, int y, int width, int height) : base(x, y, width, height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }

        public override double Area()
        {
            return height * width;
        }

        public override void Draw(PictureBox pictBox, Color colr)
        {
            Pen pen = new Pen(colr, 2);
            Graphics g = Graphics.FromHwnd(pictBox.Handle);
            g.DrawRectangle(pen, x, y, width, height);
        }
    }

}
