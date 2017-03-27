using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
{
    public partial class Form1 : Form
    {
        bool isButtonPressed = false;
        double value = 0;
        double memory = 0;
        string operation = "";
        bool floatNum = false;
        bool operand_pressed = false;
        bool dotPressed = false;

        public Form1()
        {
            InitializeComponent();
            diplay.Text = "0";
            equation.Text = "";
            value = 0;
        }

        private void btn_Click(object sender, EventArgs e)
        {
            isButtonPressed = true;
            if (diplay.Text == "0" && isButtonPressed == true)
            {
                diplay.Clear();
            }
            if (operand_pressed)
            {
                diplay.Clear();
                operand_pressed = false;
            }
            Button btn = (Button)sender;
            diplay.Text += btn.Text;
        }

        private void btn_clear_Click(object sender, EventArgs e)
        {
            diplay.Clear();
            diplay.Text = "0";
        }

        private void Persentage(object sender, EventArgs e)
        {
            switch (operation)
            {
                case "+":
                    value = value + (value / 100 * double.Parse(diplay.Text));
                    diplay.Text = value.ToString();
                    dotPressed = false;
                    break;
                case "-":
                    value = value - (value / 100 * double.Parse(diplay.Text));
                    diplay.Text = value.ToString();
                    dotPressed = false;
                    break;
                case "x":
                    value = value / 100 * double.Parse(diplay.Text);
                    dotPressed = false;
                    diplay.Text = value.ToString();
                    break;
            }
        }

        private void operands(object sender, EventArgs e)
        {
            dotPressed = false;
            Button btn = (Button)sender;
            value = double.Parse(diplay.Text);
            operation = btn.Text;
            operand_pressed = true;
            equation.Text = value + " " + operation;

        }

        private void result_Click(object sender, EventArgs e)
        {
            dotPressed = false;

            for (int i = 0; i < diplay.Text.Length; i++)
            {
                if (diplay.Text[i] == ',')
                {
                    dotPressed = true;
                }
            }
            equation.Text = "";
            switch (operation)
            {
                case "+":
                    value = value + (double.Parse(diplay.Text));
                    diplay.Text = value.ToString();
                    dotPressed = false;
                    break;
                case "-":
                    value = value - (double.Parse(diplay.Text));
                    diplay.Text = value.ToString();
                    dotPressed = false;
                    
                    break;
                case "x":
                    value = value * (double.Parse(diplay.Text));
                    diplay.Text = value.ToString();
                    dotPressed = false;
                    break;
                case "/":
                    value = value / (double.Parse(diplay.Text));
                    diplay.Text = value.ToString();
                    dotPressed = false;
                    break;
                case "div":
                    value = Convert.ToInt32(value);
                    value = (value) % (int.Parse(diplay.Text));
                    value = Convert.ToInt32(value);
                    diplay.Text = value.ToString();

                    break;
            }
        }

        private void divide_x_Click(object sender, EventArgs e)
        {
            value = double.Parse(diplay.Text);
            diplay.Text = (1 / value).ToString();
        }

        private void square_Click(object sender, EventArgs e)
        {
            value = double.Parse(diplay.Text);
            diplay.Text = (value * value).ToString();
        }

        private void root_Click(object sender, EventArgs e)
        {
            value = double.Parse(diplay.Text);
            diplay.Text = (Math.Sqrt(value)).ToString();
        }

        private void ms_Click(object sender, EventArgs e)
        {
            memory = double.Parse(diplay.Text);
        }

        private void m_min_Click(object sender, EventArgs e)
        {
            value = value - memory;
            diplay.Text = value.ToString();
        }

        private void m_plus_Click(object sender, EventArgs e)
        {
            value = value + memory;
            diplay.Text = value.ToString();
        }

        private void m_clear_Click(object sender, EventArgs e)
        {
            memory = 0;
        }

        private void Clear_all_Click(object sender, EventArgs e)
        {
            diplay.Text = "0";
            equation.Text = "";
            value = 0;
        }

        private void sign_Click(object sender, EventArgs e)
        {
            value = double.Parse(diplay.Text);        
            value = value * (-1);
            diplay.Text = value.ToString();            
        }

        private void dot_Click(object sender, EventArgs e)
        {
            for(int i = 0; i < diplay.Text.Length; i++)
            {
                if(diplay.Text[i] == ',')
                {
                    dotPressed = true;
                }
            }

            if (!dotPressed)
            {
                Button btn = (Button)sender;
                diplay.Text += btn.Text;
                btn.Enabled = false;
                dotPressed = true;
            }
            if (dotPressed)
            {
                Button btn = (Button)sender;
                btn.Enabled = true;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void MR_Click(object sender, EventArgs e)
        {
            diplay.Text = memory.ToString();
        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.Gray;
        }

        private void Form1_MouseLeave(object sender, EventArgs e)
        {
            Button btn = sender as Button;
            btn.BackColor = Color.White;
        }
    }
}
