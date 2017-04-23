using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphOOP
{
    class Gun:Figure
    {
        public Gun(int _x, int _y, int _width, int _heght, Pen _pen) : base (_x, _y, _width, _heght, _pen) { }

        public override void Drow(Graphics g)
        {
            Point[] triangle = { new Point(x + width / 2, y + heght / 4),
                new Point(x + width / 2 + width / 4, y + heght / 2), new Point(x + width / 2 - width / 4, y+heght/2) };
            g.FillPolygon(pen.Brush, triangle);
            g.FillRectangle(pen.Brush, x + width / 2 - width / 8, y + heght / 2, width / 4, heght / 4);
        }
    }

}
