using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphOOP
{
    class Star : Figure
    {
        public Star(int x, int y, int width, int height, Pen pen):base(x,y,width,height, pen) { }
        public void Drow(Graphics g)
        {
            Point[] up = { new Point(x + width / 2, y), new Point(x + width, y + heght / 4 * 3),
                new Point(x, y + heght / 4 * 3), new Point(x + width / 2, y) };
            Point[] down = { new Point(x + width / 2, y+heght), new Point(x, y + heght / 4),
                new Point(x + width, y + heght / 4), new Point(x + width / 2, y+heght) };

            g.FillPolygon(pen.Brush, up);
            g.FillPolygon(pen.Brush, down);
        }
    }
}
