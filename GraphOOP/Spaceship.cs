using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphOOP
{
    class Spaceship:Figure
    {
        public Spaceship(int _x, int _y, int _width, int _heght, Pen _pen) : base (_x, _y, _width, _heght, _pen) { }
        public void Drow(Graphics g)
        {
            Point[] space = { new Point(x + width / 2, y), new Point(x + width, y + heght / 4), new Point(x + width, y + heght / 4 * 3),
                new Point(x + width / 2, y + heght), new Point(x, y + heght / 4 * 3), new Point(x, y + heght / 4) };
            g.FillPolygon(pen.Brush, space);
        }
    }
}
