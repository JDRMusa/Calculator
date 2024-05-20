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
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int a = int.Parse(textBox1.Text);
            int b = int.Parse(textBox2.Text);
            int c;
            if (radioButton1.Checked)
            {
                c = a + b;
                label4.Text = "Total: " + c.ToString();
            }
            if (radioButton2.Checked)
            {
                c = a - b;
                label4.Text = "Total: " + c.ToString();
            }
            if (radioButton3.Checked)
            {
                c = a * b;
                label4.Text = "Total: " + c.ToString();
            }
            if (radioButton4.Checked)
            {
                c = a / b;
                label4.Text = "Total: " + c.ToString();
            }
            if (radioButton5.Checked)
            {
                c = a % b;
                label4.Text = "Total: " + c.ToString();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            textBox2.Text = "";
            label5.Text = "";
        }

        private void button1_MouseHover(object sender, EventArgs e)
        {
            button1.BackColor = Color.Aqua;
        }
        private void button1_MouseLeave(object sender, EventArgs e)
        {
            button1.BackColor = Color.White;
        }
        private void button1_MouseDown(object sender, MouseEventArgs e)
        {
            button1.BackColor = Color.Gray;
        }
        private void button2_MouseHover(object sender, EventArgs e)
        {
            button2.BackColor = Color.Firebrick;
        }
        private void button2_MouseLeave(object sender, EventArgs e)
        {
            button2.BackColor = Color.White;
        }
        private void button2_MouseDown(object sender, MouseEventArgs e)
        {
            button2.BackColor = Color.Gray;
        }
    }
}
