using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphOOP
{
    class Ellipse : Figure
    {    
        public Ellipse(int _x, int _y, int _width, int _heght, Pen _pen) : base (_x, _y, _width, _heght, _pen) { }
        public void Drow(Graphics g)
        {
            g.FillEllipse(pen.Brush, new Rectangle(x, y, width, heght));
        }
    }
}
