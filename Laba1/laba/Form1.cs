using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Text = textBox1.Text;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label1.Text = textBox2.Text;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            label1.Text = textBox3.Text;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            double x = double.Parse(textBox4.Text);
            double y = double.Parse(textBox5.Text);
            double z = double.Parse(textBox6.Text);

            textBox7.Text += Environment.NewLine + "X = " + x.ToString();
            textBox7.Text += Environment.NewLine + "Y = " + y.ToString();
            textBox7.Text += Environment.NewLine + "Z = " + z.ToString();

            double a = 1 + Math.Pow(Math.Sin(x + y), 2) * Math.Pow(x, Math.Abs(y));
            double b = Math.Abs(x - (2 * y / 1 + Math.Pow(x, 2) * Math.Pow(y, 2)));
            double c = Math.Pow(Math.Cos(Math.Atan(1 / z)), 2);

            double v = a / b + c;
            textBox7.Text += Environment.NewLine + "Результат V = " + v.ToString();

        }
    }
}
