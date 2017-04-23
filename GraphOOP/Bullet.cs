﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphOOP
{
    class Bullet:Figure
    {
        public Bullet(int _x, int _y, int _width, int _heght, Pen _pen) : base (_x, _y, _width, _heght, _pen) { }

        public override void Drow(Graphics g)
        {
            Point[] ver = { new Point(x+width/2, y), new Point(x+width*3/4, y + heght/2), new Point(x+width/2, y+heght),
                new Point(x+width/4, y+heght/2), new Point(x + width / 2, y) };
            Point[] hor = { new Point(x, y + heght / 2), new Point(x + width/2, y + heght / 4),
                new Point(x + width, y + heght / 2), new Point(x + width / 2, y + heght / 4 * 3) };

            g.FillPolygon(pen.Brush, hor);
            g.FillPolygon(pen.Brush, ver);
        }

    }
}
