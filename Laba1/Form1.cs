using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Project
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }


        // Задание 1
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


        // Задание 2
        private void button4_Click(object sender, EventArgs e)
        {
            double x, y, z;

            if (!double.TryParse(textBox4.Text, out x))
            {
                MessageBox.Show("Некорректное значение для X.");
                return;
            }

            if (!double.TryParse(textBox5.Text, out y))
            {
                MessageBox.Show("Некорректное значение для Y.");
                return;
            }

            if (!double.TryParse(textBox6.Text, out z))
            {
                MessageBox.Show("Некорректное значение для Z.");
                return;
            }

            textBox7.Text += Environment.NewLine + "X = " + x.ToString();
            textBox7.Text += Environment.NewLine + "Y = " + y.ToString();
            textBox7.Text += Environment.NewLine + "Z = " + z.ToString();

            double a = (1 + Math.Pow(Math.Sin(x + y), 2)) * Math.Pow(x, Math.Abs(y));
            double b = Math.Abs(x - (2 * y / 1 + Math.Pow(x, 2) * Math.Pow(y, 2)));
            double c = Math.Pow(Math.Cos(Math.Atan(1 / z)), 2);

            double v = a / b + c;
            textBox7.Text += Environment.NewLine + "Результат V = " + v.ToString();

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private double func(double x)
        {
            double f;

            if (!radioButton1.Checked && !radioButton2.Checked && !radioButton3.Checked)
            {
                radioButton2.Checked = true;
                f = Math.Pow(x, 2);
                MessageBox.Show("Вы не выбрали функцию, по умолчанию стоит функция f = x ^ 2");
                return f;
            }

            if (radioButton1.Checked) f = Math.Sinh(x);
            else if (radioButton2.Checked) f = Math.Pow(x, 2);
            else f = Math.Exp(x);
            return f;
        }


        // Задание 3
        private void button5_Click(object sender, EventArgs e)
        {
            textBox8.Clear();

            double x, y;

            if (!double.TryParse(textBox10.Text, out x))
            {
                MessageBox.Show("Некорректное значение для X.");
                return;
            }

            if (!double.TryParse(textBox11.Text, out y))
            {
                MessageBox.Show("Некорректное значение для Y.");
                return;
            }

            double res;

            if (x - y == 0)
            {
                res = Math.Pow(func(x), 2) + Math.Pow(y, 2) + Math.Sin(y);
            }
            else if (x - y > 0)
            {
                res = Math.Pow((func(x) - y), 2) + Math.Cos(y);
            }
            else
            {
                res = Math.Pow((y - func(x)), 2) + Math.Tan(y);
            }

            textBox8.Text += Environment.NewLine + "Результат = " + res.ToString();
        }


        // Задание 4
        private void button6_Click(object sender, EventArgs e)
        {
            textBox9.Clear();

            double x0, x1, dx, a, b;
            if (!double.TryParse(textBox12.Text, out x0))
            {
                MessageBox.Show("Введите корректное значение для x начального.");
                return;
            }

            if (!double.TryParse(textBox13.Text, out x1))
            {
                MessageBox.Show("Введите корректное значение для х конечного.");
                return;
            }

            if (!double.TryParse(textBox14.Text, out dx))
            {
                MessageBox.Show("Введите корректное значение для dx.");
                return;
            }

            if (dx == 0)
            {
                MessageBox.Show("Значение dx не может быть равно 0.");
                return;
            }

            if (!double.TryParse(textBox15.Text, out a))
            {
                MessageBox.Show("Введите корректное значение для a.");
                return;
            }

            if (!double.TryParse(textBox16.Text, out b))
            {
                MessageBox.Show("Введите корректное значение для b.");
                return;
            }

            textBox9.Text += "x начальное = " + x0.ToString();
            textBox9.Text += Environment.NewLine + "х конечное = " + x1.ToString();
            textBox9.Text += Environment.NewLine + "dx = " + dx.ToString();
            textBox9.Text += Environment.NewLine + "a = " + a.ToString();
            textBox9.Text += Environment.NewLine + "b = " + b.ToString() + Environment.NewLine + Environment.NewLine;

            // Проверяем порядок x0 и x1, чтобы правильно обработать шаг dx
            if (x0 < x1)
            {
                if (dx <= 0) // Проверка на корректность шага
                {
                    MessageBox.Show("Некорректное значение для dx при x начальном меньше x конечного.");
                    return;
                }

                // Когда x0 < x1, увеличиваем x
                for (double x = x0; x <= (x1 + dx / 2); x += dx)
                {
                    double y = 0.1 * a * Math.Pow(x, 3) * Math.Tan(a - b * x);
                    textBox9.Text += "x = " + x.ToString() + " ; y = " + y.ToString() + Environment.NewLine;
                }
            }
            else if (x0 > x1)
            {
                if (dx >= 0) // Проверка на корректность шага при уменьшении x
                {
                    MessageBox.Show("Некорректное значение для dx при x начальном больше x конечного.");
                    return;
                }

                // Когда x0 > x1, уменьшаем x
                for (double x = x0; x >= (x1 - dx / 2); x += dx) // Используем увеличение, так как dx отрицательное
                {
                    double y = 0.1 * a * Math.Pow(x, 3) * Math.Tan(a - b * x);
                    textBox9.Text += "x = " + x.ToString() + " ; y = " + y.ToString() + Environment.NewLine;
                }
            }
            else
            {
                // Когда x0 == x1, вычисляем значение для одного x
                double y = 0.1 * a * Math.Pow(x0, 3) * Math.Tan(a - b * x0);
                textBox9.Text += "x = " + x0.ToString() + " ; y = " + y.ToString() + Environment.NewLine;
            }
        }
    }
}