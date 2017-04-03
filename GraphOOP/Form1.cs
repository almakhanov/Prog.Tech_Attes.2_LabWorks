using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;

namespace GraphOOP
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            Ellipse ellipse = new Ellipse(50, 80, 25, 25, new Pen(Color.White));
            ellipse.Drow(e.Graphics);
            Ellipse ellipse1 = new Ellipse(300, 60, 25, 25, new Pen(Color.White));
            ellipse1.Drow(e.Graphics);
            Ellipse ellipse2 = new Ellipse(450, 100, 25, 25, new Pen(Color.White));
            ellipse2.Drow(e.Graphics);
            Ellipse ellipse3 = new Ellipse(700, 200, 25, 25, new Pen(Color.White));
            ellipse3.Drow(e.Graphics);
            Ellipse ellipse4 = new Ellipse(600, 275, 25, 25, new Pen(Color.White));
            ellipse4.Drow(e.Graphics);
            Ellipse ellipse5 = new Ellipse(700, 400, 25, 25, new Pen(Color.White));
            ellipse5.Drow(e.Graphics);
            Ellipse ellipse6 = new Ellipse(300, 340, 25, 25, new Pen(Color.White));
            ellipse6.Drow(e.Graphics);
            Ellipse ellipse7 = new Ellipse(50, 350, 25, 25, new Pen(Color.White));
            ellipse7.Drow(e.Graphics);

            Star star = new Star(150, 150, 50, 50, new Pen(Color.Red));
            star.Drow(e.Graphics);
            Star star1 = new Star(600, 130, 50, 50, new Pen(Color.Red));
            star1.Drow(e.Graphics);
            Star star2 = new Star(190, 270, 50, 50, new Pen(Color.Red));
            star2.Drow(e.Graphics);
            Star star3 = new Star(500, 350, 50, 50, new Pen(Color.Red));
            star3.Drow(e.Graphics);

            Spaceship spaceship = new Spaceship(350, 200, 100, 100, new Pen(Color.Yellow));
            spaceship.Drow(e.Graphics);

            Gun gun = new Gun(350, 200, 100, 100, new Pen(Color.Green));
            gun.Drow(e.Graphics);

            Bullet bullet = new Bullet(400, 150, 30, 30, new Pen(Color.Green));
            bullet.Drow(e.Graphics);

        }
    }
}
