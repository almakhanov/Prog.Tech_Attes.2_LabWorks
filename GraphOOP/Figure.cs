using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GraphOOP
{
    class Figure
    {
        public int x;
        public int y;
        public int width;
        public int heght;
        public Pen pen;

        public Figure(int _x, int _y, int _width, int _heght, Pen _pen)
        {
            x = _x;
            y = _y;
            width = _width;
            heght = _heght;
            pen = _pen;
        }
    }
}
