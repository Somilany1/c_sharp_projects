using Laba5;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba5
{
    public partial class Form2 : Form
    {
        public Color colorResult; // Для хранения выбранного цвета

        public Form2() // Конструктор
        {
            InitializeComponent();

            // Инициализация значений слайдеров и числовых полей
            Scroll_Red.Tag = numericRed;            // Привязка слайдера к числовому полю
            Scroll_Green.Tag = numericGreen;
            Scroll_Blue.Tag = numericBlue;

            numericRed.Tag = Scroll_Red;           // Привязка числовых полей к слайдерам
            numericGreen.Tag = Scroll_Green;
            numericBlue.Tag = Scroll_Blue;

            // Установка значений в числовых полях и слайдерах из текущего цвета
            CurrentColor = Form1.historyColor;
            numericRed.Value = CurrentColor.R;
            numericGreen.Value = CurrentColor.G;
            numericBlue.Value = CurrentColor.B;

            Scroll_Red.Value = CurrentColor.R;      // Установка значения слайдеров
            Scroll_Green.Value = CurrentColor.G;
            Scroll_Blue.Value = CurrentColor.B;

            // Привязываем события к методам
            Scroll_Red.ValueChanged += Scroll_ValueChanged;
            Scroll_Green.ValueChanged += Scroll_ValueChanged;
            Scroll_Blue.ValueChanged += Scroll_ValueChanged;

            numericRed.ValueChanged += numeric_ValueChanged;
            numericGreen.ValueChanged += numeric_ValueChanged;
            numericBlue.ValueChanged += numeric_ValueChanged;

            // Инициализация результата
            UpdateColor();
        }

        Color CurrentColor { get; set; } = Color.Black; //присваивает начальное значение свойству CurrentColor при его объявлении

        private void Scroll_ValueChanged(object sender, EventArgs e)
        {
            ScrollBar scrollBar = (ScrollBar)sender;
            NumericUpDown numericUpDown = (NumericUpDown)scrollBar.Tag;
            numericUpDown.Value = scrollBar.Value;
            UpdateColor(); // Обновляем цвет при изменении слайдера

            //sender — это объект, который вызвал событие(ползунок),
            //предполагаем, что этот объект — экземпляр ScrollBar.
            //С помощью (ScrollBar) преобразуем его в тип ScrollBar, чтобы мы могли работать с ним, как с объектом этого типа
            //(NumericUpDown) - С помощью этого приведения мы преобразуем значение Tag в тип NumericUpDown

        }

        private void numeric_ValueChanged(object sender, EventArgs e)
        {
            NumericUpDown numericUpDown = (NumericUpDown)sender;
            ScrollBar scrollBar = (ScrollBar)numericUpDown.Tag;
            scrollBar.Value = (int)numericUpDown.Value;
            UpdateColor(); // Обновляем цвет при изменении числового поля
        }

        private void UpdateColor()
        {
            // Обновляем цвет результата на основе значений
            colorResult = Color.FromArgb(Scroll_Red.Value, Scroll_Green.Value, Scroll_Blue.Value);
            pictureBox1.BackColor = colorResult; // Меняем цвет фона элемента
        }

        private void buttonOther_Click(object sender, EventArgs e)
        {
            ColorDialog colorDialog = new ColorDialog();
            if (colorDialog.ShowDialog() == DialogResult.OK)
            {
                Scroll_Red.Value = colorDialog.Color.R;         // Устанавливаем значения из диалога
                Scroll_Green.Value = colorDialog.Color.G;
                Scroll_Blue.Value = colorDialog.Color.B;
                colorResult = colorDialog.Color;
                UpdateColor(); // Обновляем цвет
            }
        }

        private void buttonOK_Click(object sender, EventArgs e)
        {
            //// Обновляем цвет пера в Form1
            Form1.historyColor = colorResult;
            this.Close();
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}

