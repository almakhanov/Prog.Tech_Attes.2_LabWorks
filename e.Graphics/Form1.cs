using System;
using System.Drawing;
using System.Windows.Forms;

namespace e.G
{
    public partial class Form1 : Form
    {

        Graphics g;

        public Form1()
        {
            InitializeComponent();
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Pen p = new Pen(Color.White, 5);
            Pen polPen = new Pen(Color.Yellow, 5);


            e.Graphics.FillEllipse(p.Brush, new Rectangle(100/5,168/5, 40, 40));
            e.Graphics.FillEllipse(p.Brush, new Rectangle(300, 20, 40, 40));
            e.Graphics.FillEllipse(p.Brush, new Rectangle(500, 40, 40, 40));
            e.Graphics.FillEllipse(p.Brush, new Rectangle(600, 70, 40, 40));
            e.Graphics.FillEllipse(p.Brush, new Rectangle(550, 300, 40, 40));
            e.Graphics.FillEllipse(p.Brush, new Rectangle(600, 400, 40, 40));
            e.Graphics.FillEllipse(p.Brush, new Rectangle(20, 350, 40, 40));
            e.Graphics.FillEllipse(p.Brush, new Rectangle(300, 300, 40, 40));
            #region Polygon
            Point point1 = new Point(450, 250);
            Point point2 = new Point(550, 300);
            Point point3 = new Point(550, 350);
            Point point4 = new Point(450, 400);
           
            Point[] curvePoints =
                     {
                 point1,
                 point2,
                 point3,
                 point4,
                
             };            
            e.Graphics.FillPolygon(polPen.Brush, curvePoints);

            Point point5 = new Point(450, 250);
            Point point6 = new Point(350, 300);
            Point point7 = new Point(350, 350);
            Point point8 = new Point(450, 400);
            Point[] curvePoints2 =
                     {
                 point5,
                 point6,
                 point7,
                 point8,

             };
            e.Graphics.FillPolygon(polPen.Brush, curvePoints2);
            #endregion

            Pen thrPen = new Pen(Color.Green, 5);
            Point pointa = new Point(450, 280);
            Point pointb = new Point(500, 330);
            Point pointc = new Point(400, 330);
            Point pointd = new Point(450, 280);

            Point[] curvePointsABC =
                     {
                 pointa,
                 pointb,
                 pointc,
                 pointd,

             };
            e.Graphics.FillPolygon(thrPen.Brush, curvePointsABC);

            e.Graphics.FillRectangle(thrPen.Brush, new Rectangle(425, 330, 50, 50));
            ////////////////////////////////////////////////////////////////////////////////
            Pen starPen = new Pen(Color.Red, 3);
            Point[] starP = { new Point(100, 40), new Point(135, 100), new Point(65, 100), new Point(100, 40) };
            e.Graphics.FillPolygon(starPen.Brush, starP);
            Point[] starP2 = { new Point(100, 120), new Point(135, 60), new Point(65, 60), new Point(100, 120) };
            e.Graphics.FillPolygon(starPen.Brush, starP2);

            Point[] starP3 = { new Point(100+40, 40+300), new Point(135+40, 100+300), new Point(65+40, 100+300), new Point(100+40, 40+300) };
            e.Graphics.FillPolygon(starPen.Brush, starP3);
            Point[] starP4 = { new Point(100+40, 120+300), new Point(135+40, 60+300), new Point(65+40, 60+300), new Point(100+40, 120+300) };
            e.Graphics.FillPolygon(starPen.Brush, starP4);

            Point[] starP5 = { new Point(100 + 300, 40), new Point(135+300, 100), new Point(65+300, 100), new Point(100+300, 40) };
            e.Graphics.FillPolygon(starPen.Brush, starP5);
            Point[] starP6 = { new Point(100+300, 120), new Point(135+300, 60), new Point(65+300, 60), new Point(100+300, 120) };
            e.Graphics.FillPolygon(starPen.Brush, starP6);

            Point[] romb = { new Point(500, 150), new Point(520, 200), new Point(500, 250), new Point(480, 200), new Point(500, 150) };
            e.Graphics.FillPolygon(thrPen.Brush, romb);

            Point[] romb1 = { new Point(500, 180), new Point(550, 200), new Point(500, 220), new Point(450, 200), new Point(500, 180) };
            e.Graphics.FillPolygon(thrPen.Brush, romb1);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
