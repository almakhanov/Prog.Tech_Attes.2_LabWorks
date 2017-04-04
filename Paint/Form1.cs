using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Paint
{
    public enum Shapes
    {
        Free,
        Line,
        Ellipse,
        Rectangle,
        Triangle,
        Eraser,
        FloodFill
    }

    public partial class Form1 : Form
    {
        Point prevPoint;
        Point currentPoint;
        Color color = Color.Black;
        Shapes currentShape = Shapes.Free;
        Graphics g;
        Bitmap bmp;
        GraphicsPath gp = new GraphicsPath();
        int penSize = 1;

        public Form1()
        {
            InitializeComponent();
            bmp = new Bitmap(paper.Width, paper.Height);
            paper.Image = bmp;
            g = Graphics.FromImage(paper.Image);
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            e.Graphics.DrawPath(new Pen(color, penSize), gp);
        }

        private void paper_MouseDown(object sender, MouseEventArgs e)
        {
            prevPoint = e.Location;
        }

        private void paper_MouseMove(object sender, MouseEventArgs e)
        {
            if(e.Button == MouseButtons.Left)
            {
                switch (currentShape)
                {
                    case Shapes.Free:
                        currentPoint = e.Location;
                        paper.Cursor = Cursors.Arrow;
                        g.DrawLine(new Pen(color, penSize), prevPoint, currentPoint);
                        prevPoint = currentPoint;
                        break;
                    case Shapes.Line:
                        currentPoint = e.Location;
                        gp.Reset();                       
                        gp.AddLine(prevPoint, currentPoint);
                        break;
                    case Shapes.Ellipse:
                        currentPoint = e.Location;
                        gp.Reset();
                        gp.AddEllipse(new Rectangle(Math.Min(prevPoint.X, currentPoint.X), Math.Min(prevPoint.Y, currentPoint.Y),
                            Math.Abs(currentPoint.X - prevPoint.X), Math.Abs(currentPoint.Y - prevPoint.Y)));
                        break;
                    case Shapes.Rectangle:
                        currentPoint = e.Location;
                        gp.Reset();                        
                        gp.AddRectangle(new Rectangle(Math.Min(prevPoint.X,currentPoint.X), Math.Min(prevPoint.Y, currentPoint.Y),  
                            Math.Abs(currentPoint.X - prevPoint.X), Math.Abs(currentPoint.Y - prevPoint.Y)));   
                            break;
                    case Shapes.Triangle:

                        break;
                    case Shapes.Eraser:
                        currentPoint = e.Location;
                        paper.Cursor = Cursors.Cross;
                        g.DrawLine(new Pen(Color.White, penSize+10), prevPoint, currentPoint);
                        prevPoint = currentPoint;
                        break;
                    case Shapes.FloodFill:
                        paper.BackColor = color;
                        break;
                    default:
                        break;
                }
            }            
            MouseLocation.Text = string.Format("X: {0}; Y: {1}", e.X, e.Y);
            paper.Refresh();
        }

        private void LineBtn_Click(object sender, EventArgs e)
        {
            currentShape = Shapes.Line;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void RectBtn_Click(object sender, EventArgs e)
        {
            currentShape = Shapes.Rectangle;
        }

        private void TrianBtn_Click(object sender, EventArgs e)
        {
            currentShape = Shapes.Triangle;
        }

        private void EllipseBtn_Click(object sender, EventArgs e)
        {
            currentShape = Shapes.Ellipse;
        }

        private void EraseBtn_Click(object sender, EventArgs e)
        {
            currentShape = Shapes.Eraser;
        }

        private void FloodBtn_Click(object sender, EventArgs e)
        {
            currentShape = Shapes.FloodFill;
        }

        private void ColorBtn_Click(object sender, EventArgs e)
        {
            ColorDialog c = new ColorDialog();
            if(c.ShowDialog() == DialogResult.OK)
            {
                color = c.Color;
                ColorShow.BackColor = color;
            }
        }

        private void PenSizeBtn_Scroll(object sender, EventArgs e)
        {
            penSize = PenSizeBtn.Value;
            label1.Text = "PenSize: " + penSize;
        }

        private void BrushBtn_Click(object sender, EventArgs e)
        {
            currentShape = Shapes.Free;
        }

        private void paper_MouseUp(object sender, MouseEventArgs e)
        {
            g.DrawPath(new Pen(color, penSize), gp);
            gp.Reset();
        }
    }
}
