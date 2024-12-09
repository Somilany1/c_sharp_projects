using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba4
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        public Color CircleColor
        {
            get
            {
                // Проверка выбранной радиокнопки и возврат соответствующего цвета
                if (radioButton1.Checked) return Color.Black;
                if (radioButton2.Checked) return Color.Gray;
                if (radioButton3.Checked) return Color.Red;
                if (radioButton4.Checked) return Color.Yellow;
                if (radioButton5.Checked) return Color.Green;
                if (radioButton6.Checked) return Color.Blue;
                return Color.Empty;
            }
            set
            {
                // Сброс радиокнопок перед установкой нового цвета
                radioButton1.Checked = (value == Color.Black);
                radioButton2.Checked = (value == Color.Gray);
                radioButton3.Checked = (value == Color.Red);
                radioButton4.Checked = (value == Color.Yellow);
                radioButton5.Checked = (value == Color.Green);
                radioButton6.Checked = (value == Color.Blue);
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}

