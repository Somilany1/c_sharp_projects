using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using System.Drawing.Drawing2D;
using System.IO;

namespace Laba4
{
    public partial class Form1 : Form
    {
        private int boxHeight;
        private int boxWidth;

        private Color selectedColor = Color.White; // Сохраняем выбранный цвет


        public Form1()
        {
            InitializeComponent();
            this.Load += new System.EventHandler(this.Form1_Load);

            SetCircleColor(selectedColor); 
            pictureBox2.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            boxHeight = pictureBox2.Height;
            boxWidth = pictureBox2.Width;

            y0 = boxHeight / 2;
            x0 = boxWidth / 2;
        }


        // ЗАДАНИЕ 1

        private bool shouldDrawGraph = false;

        Font font = new Font("Times New Roman", 8, FontStyle.Bold);
        SolidBrush brush = new SolidBrush(Color.Black);

        // Функция 1
        private double function(double x)
        {
            return x * Math.Sin(Math.Pow(x, 3)) + x + (Math.Pow(x, 2) / 2) + (Math.Pow(x, 3) / 6);
        }

        private void FontButton_Click(object sender, EventArgs e)
        {
            using (FontDialog fontDialog = new FontDialog())

                if (fontDialog.ShowDialog() == DialogResult.OK)
                {
                    brush.Color = fontDialog.Color;
                    font = fontDialog.Font;
                }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            if (!shouldDrawGraph)
                return; // Выходим, если флаг не установлен

            // Получаем размеры PictureBox
            int boxWidth = pictureBox1.Width;
            int boxHeight = pictureBox1.Height;

            // Устанавливаем начальные координаты осей, чтобы оси были симметричны относительно PictureBox
            int x0 = boxWidth / 10;
            int y0 = (int)(boxHeight * 0.85);

            // Масштаб по оси X и оси Y
            int Mx = boxWidth - 2 * x0; // Учитываем отступы по краям
            int My = (int)((y0) / 20.0); // Масштаб для Y, чтобы график помещался в диапазон [0, 20]

            // Число точек графика
            int M = (int)PointsNumericUpDown.Value;

            // Создание графического объекта
            Graphics G = e.Graphics;
            G.Clear(Color.White);

            // Рисуем сетку для удобства
            Pen gridPen = new Pen(Color.LightGray, 1);
            // Рисуем сетку для интервала [1, 3]
            for (int i = 0; i <= 4; i++)
            {
                double x = 1.0 + i * 0.5; // шаг 0.5, чтобы было 4 линии между 1 и 3 (1.0, 1.5, 2.0, 2.5, 3.0)
                int xi = (int)(x0 + Mx * ((x - 1) / 2.0)); // Преобразование x для диапазона [1, 3]
                G.DrawLine(gridPen, xi, y0 - My * (int)20, xi, y0); // Вертикальная линия сетки
            }

            for (int i = 0; i <= 10; i++)
            {
                int yi = (int)(y0 - My * i * 2);
                G.DrawLine(gridPen, x0, yi, x0 + Mx, yi); // Горизонтальная линия сетки
            }

            // Описание и создание массива точек
            Point[] p = new Point[M];
            double minY = 0.0;
            double maxY = 20.0;

            // Цикл по числу точек графика
            for (int n = 0; n < M; n++)
            {
                double x = 1.0 + 2.0 * n / (M - 1); // Преобразуем x в диапазон [1, 3]
                double y = function(x);

                int xi = (int)(x0 + Mx * ((x - 1) / 2.0)); // масштабируем x от 1 до 3
                int yi = (int)(y0 - My * y);               // масштабируем y так, чтобы ось Y увеличивалась вверх

                p[n] = new Point(xi, yi);

                // Отображаем каждую точку на графике в виде более крупного круга
                G.FillEllipse(Brushes.Red, xi - 3, yi - 3, 6, 6); // Радиус точки 6 пикселей
            }

            // Коэффициент упругости графика
            float tension = (float)TensionNumericUpDown.Value;

            // Рисование графика
            G.DrawCurve(Pens.Blue, p, tension);

            // Рисование оси X
            G.DrawLine(Pens.Black, x0, y0, x0 + Mx, y0);
            // Рисование оси Y
            G.DrawLine(Pens.Black, x0, y0 - My * (int)maxY, x0, y0);

            // Подготовка для разметки оси X и Y
            Brush brush = Brushes.Black;
            Font font = new Font("Arial", 8);

            // Разметка оси X от 1 до 3
            for (int n = 1; n <= 3; n++)
            {
                int xi = (int)(x0 + Mx * ((n - 1) / 2.0));
                G.DrawLine(Pens.Black, xi, y0, xi, y0 + 4);
                G.DrawString(n.ToString(), font, brush, xi - 9, y0 + 4);
            }

            // Разметка оси Y от 0 до 20
            int ySteps = 10; // Количество шагов по оси Y (например, каждые 2 единицы)
            for (int i = 0; i <= ySteps; i++)
            {
                double yValue = minY + i * (maxY - minY) / ySteps;
                int yi = (int)(y0 - My * yValue);

                // Рисуем штрихи и значения по оси Y
                G.DrawLine(Pens.Black, x0 - 4, yi, x0, yi);
                G.DrawString(yValue.ToString(), font, brush, x0 - 25, yi - 8);
            }
        }


        private void GraphicButton_Click(object sender, EventArgs e)
        {
            // Проверка значений перед отрисовкой
            int M = (int)PointsNumericUpDown.Value;
            float tension = (float)TensionNumericUpDown.Value;

            if (M < 3)
            {
                MessageBox.Show("Недостаточное число точек для рисования кривой");
                return;
            }

            if (tension < 0 || tension > 1)
            {
                MessageBox.Show("Упругость должна быть в диапазоне от 0 до 1");
                return;
            }

            // Устанавливаем флаг и перерисовываем график
            shouldDrawGraph = true;
            pictureBox1.Refresh(); // Перерисовываем только после нажатия кнопки

        }

        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }



        // ЗАДАНИЕ 2
        //Постройте график функции из задания 1 с помощью элемента управления Chart.
        //Добавьте второй график для произвольной функции.

        // Функция 2
        private double function2(double x)
        {
            return Math.Sin(x);
        }

        // Отрисовка функции
        private void button1_Click(object sender, EventArgs e)
        {
            double Xmin = 1;
            double Xmax = 3;

            if (double.TryParse(Step.Text, out double step))
            {
                if (step <= 0 || step >= 3)
                {
                    MessageBox.Show("Число для шага должно находиться в диапазоне (0,2], так как x имеет ограничения");
                    return;
                }
            }
            else
            {
                MessageBox.Show("Введено некорректное выражение для шага");
                return;
            }

            // Количество точек графика
            int count = (int)Math.Ceiling((Xmax - Xmin) / step) + 1;
            // Массив значений X – общий для обоих графиков
            double[] x = new double[count];
            // Два массива Y – по одному для каждого графика
            double[] y1 = new double[count];
            double[] y2 = new double[count];
            // Расчитываем точки для графиков функции
            for (int i = 0; i < count; i++)
            {
                // Вычисляем значение X
                x[i] = Xmin + step * i;
                // Вычисляем значение функций в точке X
                y1[i] = function(x[i]);
                y2[i] = function2(x[i]);
            }

            // Настраиваем оси графика
            Graphic.ChartAreas[0].AxisX.Minimum = Xmin;
            Graphic.ChartAreas[0].AxisX.Maximum = Xmax;
            // Определяем шаг сетки
            Graphic.ChartAreas[0].AxisX.MajorGrid.Interval = step;
            // Добавляем вычисленные значения в графики
            Graphic.Series[0].Points.DataBindXY(x, y1);
            Graphic.Series[1].Points.DataBindXY(x, y2);
        }



        //ЗАДАНИЕ 3
        //Выполнить пример*. Изменить траекторию движения фигуры:
        //От центра области рисования влево. От стенки – к центру

        // Определяем переменную для хранения цвета

        private HatchBrush hb;
        GraphicsPath path = new GraphicsPath();

        int x0;
        int y0;
        int radius = 30;
        int xDir = 1;

        public void SetCircleColor(Color color)
        {
            selectedColor = color; // Сохраняем цвет, чтобы он запоминался для повторного использования
            hb = new HatchBrush(HatchStyle.ZigZag, Color.Black, color);
            pictureBox2.Invalidate();
        }

        // Получаем цвет из свойства CircleColor


        // Теперь переменная selectedColor содержит текущий цвет круга

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            if (hb == null)
            {
                // Инициализация hb по умолчанию, если цвет не был установлен
                hb = new HatchBrush(HatchStyle.ZigZag, Color.Black, Color.White);
            }

            Graphics g = e.Graphics;
            g.Clear(Color.White);
            g.FillEllipse(hb, x0 - radius, y0 - radius, 2 * radius, 2 * radius);
            g.DrawEllipse(new Pen(Brushes.Black, 2), x0 - radius, y0 - radius, 2 * radius, 2 * radius);
            //очищаем фигуру
            path.Reset();
            //начинаем формирование фигуры
            path.StartFigure();
            //добавляем круг в фигуру
            path.AddEllipse(x0 - radius, y0 - radius, 2 * radius, 2 * radius);
            //завершаем формирование фигуры
            path.CloseFigure();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //если круг "подлетел" к левой стенке,
            if (x0 < (boxWidth / 2))
                xDir = 1; //то начинаем двигаться вправо
                          //если к правой стенке,
            if (x0 + radius + 5 > pictureBox2.Width)
                xDir = -1; //то влево
                           //если к верхней стенке,
            x0 += xDir;
            //обновляем область рисования (перерисовываем круг)
            pictureBox2.Invalidate();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            //изменяем значение интервала таймера на выбранное
            timer1.Interval = trackBar1.Value;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Form2 form = new Form2();
            form.CircleColor = selectedColor;
            if (form.ShowDialog() == DialogResult.OK)
            {
                // Устанавливаем цвет, выбранный в Form2
                SetCircleColor(form.CircleColor);
            }
        }

        private void pictureBox2_MouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                Point pt = new Point(e.X, e.Y);
                if (path.IsVisible(pt))
                {
                    // Открываем форму выбора цвета с текущим цветом
                    Form2 form = new Form2();
                    form.CircleColor = selectedColor; // Передаем текущий цвет в Form2

                    if (form.ShowDialog() == DialogResult.OK)
                    {
                        // Устанавливаем цвет, выбранный в Form2
                        SetCircleColor(form.CircleColor);
                    }
                }
            }
        }
    }
}


