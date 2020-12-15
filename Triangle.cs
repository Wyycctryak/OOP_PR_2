using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace OOP_LB_2
{
    class Triangle : Shape
    {
        public Triangle(int x, int y, int width, int height) : base(x, y, width, height)
        {
            this.x = x;
            this.y = y;
            this.width = width;
            this.height = height;
        }
        public override double Area()
        {
            return 0.5 * width * height;
        }
        public override void Draw(PictureBox pictureBox1, Color colr)
        {
            Pen pen = new Pen(colr, 2);
            Graphics g = Graphics.FromHwnd(pictureBox1.Handle);

            Point point1 = new Point(x, y);
            Point point2 = new Point(x - width / 2, y);
            Point point3 = new Point(x, y - height);
            Point point4 = new Point(x + width / 2, y);



            Point[] curvePoints =
            {
                 point1,
                 point2,
                 point3,
                 point4


             };

            g.DrawPolygon(pen, curvePoints);
        }
    }

}
