using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Enum_and_Delegate
{
    public partial class Form1 : Form
    {
        Summa summa;
        Random rand = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }

        public void Show(string message)
        {
            
            for(Count i = Count.One; i < Count.Ta_daaam; i++)
            {
                messenger.Text = "Calculating... Please wait... " + i.ToString()+ "   ";
                BackColor = Color.FromArgb(rand.Next(150, 255), rand.Next(150, 255), rand.Next(150, 255));
                Thread.Sleep(1000);
                Refresh();
            }
            messenger.Text = Count.Ta_daaam.ToString() + "!!!";           
            sum.Text = message;            
        }

        private void equate_Click(object sender, EventArgs e)
        {
            summa = new Summa(int.Parse(num1.Text), int.Parse(num2.Text));
            summa.Sum(summa.a, summa.b, Show);
        }
    }
}
