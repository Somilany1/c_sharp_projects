using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba5
{
    public partial class Form1 : Form
    {

        //Задание.Создать графический редактор, позволяющий:
        //Создавать, редактировать, загружать, сохранять изображения;
        //Рисовать с помощью мыши
        //(При нажатии левой кнопки мыши и её перемещении отображается кривая движения указателя мыши.
        //При нажатии правой кнопки мыши появляется функция ластика);
        //Задавать цвет, толщину и стиль линии;
        //Пользоваться историей изменений в обе стороны – undo и redo.

        private SaveFileDialog SaveDialog;
        bool drawing;
        GraphicsPath currentPath;
        Point oldLocation;
        Pen currentPen;
        DashStyle currentDashStyle;
        public static Image image;
        public static bool exit;

        int historyCounter; //Счетчик истории
        List<Image> History = new List<Image>(); //Инициализация списка для истории
        public static Color historyColor = Color.Black;

        public Form1()
        {
            InitializeComponent();
            InitializeSaveDialog();

            drawing = false; //Переменная, ответственная за рисование

            Image image = pictureBox1.Image;

            currentPen = new Pen(Color.Black); //Инициализация пера с черным цветом
            currentPen.Width = trackBar1.Value; //Инициализация толщины пера
        }

        private void InitializeSaveDialog()
        {
            SaveDialog = new SaveFileDialog
            {
                Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png",
                Title = "Save an Image File",
                FilterIndex = 4
            };
        }

        // New
        private void newToolStripMenuItem_Click(object sender, EventArgs e)
        {
            History.Clear();
            historyCounter = 0;

            if (pictureBox1.Image != null)
            {
                var result = MessageBox.Show("Сохранить текущее изображение перед созданием нового рисунка ? ",
                "Предупреждение", MessageBoxButtons.YesNoCancel);
                switch (result)
                {
                    case DialogResult.No: break;
                    case DialogResult.Yes: saveToolStripMenuItem_Click(sender ,e); break;
                    case DialogResult.Cancel: return;
                }
                
            }
            Bitmap pic = new Bitmap(pictureBox1.Width, pictureBox1.Height);
            pictureBox1.Image = pic;

            History.Add(new Bitmap(pictureBox1.Image));
        }

        // Save
        private void saveToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveDialog.ShowDialog();

            if (SaveDialog.ShowDialog() == DialogResult.OK)
            {
                if (SaveDialog.FileName != "") 
                {
                    System.IO.FileStream fs = (System.IO.FileStream)SaveDialog.OpenFile();
                    switch (SaveDialog.FilterIndex)
                    {
                        case 1:
                            this.pictureBox1.Image.Save(fs, ImageFormat.Jpeg);
                            break;
                        case 2:
                            this.pictureBox1.Image.Save(fs, ImageFormat.Bmp);
                            break;
                        case 3:
                            this.pictureBox1.Image.Save(fs, ImageFormat.Gif);
                            break;
                        case 4:
                            this.pictureBox1.Image.Save(fs, ImageFormat.Png);
                            break;
                    }
                    fs.Close();
                } else
                {
                    MessageBox.Show("Введите имя файла");
                    return;
                }
            }
        }

        // Open
        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OP = new OpenFileDialog();
            OP.Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png";
            OP.Title = "Open an Image File";
            OP.FilterIndex = 1; //По умолчанию будет выбрано первое расширение *.jpg

            if (OP.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Load(OP.FileName);
                pictureBox1.AutoSize = true;
            }

            pictureBox1.AutoSize = true;
        }

        private void toolStripButtonNew_Click(object sender, EventArgs e)
        {
            newToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButtonOpen_Click(object sender, EventArgs e)
        {
            openToolStripMenuItem_Click(sender, e);
        }

        private void toolStripButtonSave_Click(object sender, EventArgs e)
        {
            saveToolStripMenuItem_Click(sender, e);
        }

        private void pictureBox1_MouseDown(object sender, MouseEventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Cоздайте новый файл!");
                return;
            }

            if (e.Button == MouseButtons.Right)
            {

                // Устанавливаем цвет пера на цвет фона
                currentPen.Color = pictureBox1.BackColor;
                currentPen.Width = trackBar1.Value;

                currentDashStyle = currentPen.DashStyle;
                currentPen.DashStyle = DashStyle.Solid;

                drawing = true;
                oldLocation = e.Location;
                currentPath = new GraphicsPath();
            }


            if (e.Button == MouseButtons.Left)
            {
                currentPen.DashStyle = currentDashStyle;
                currentPen.Color = historyColor;

                drawing = true;
                oldLocation = e.Location;
                currentPath = new GraphicsPath();
            }
        }

        private void pictureBox1_MouseMove(object sender, MouseEventArgs e)
        {
            Coordinate.Text = e.X.ToString() + ", " + e.Y.ToString();
             
            if (drawing)
            {
                Graphics g = Graphics.FromImage(pictureBox1.Image);
                currentPath.AddLine(oldLocation, e.Location);
                g.DrawPath(currentPen, currentPath);
                oldLocation = e.Location;
                g.Dispose();
                pictureBox1.Invalidate();
            }
        }

        private void pictureBox1_MouseUp(object sender, MouseEventArgs e)
        {
            if (historyCounter + 1 < History.Count)
            {
                History.RemoveRange(historyCounter + 1, History.Count - historyCounter - 1);
            }

            // Добавляем текущее изображение в историю
            History.Add(new Bitmap(pictureBox1.Image));

            if (historyCounter + 1 < 10) historyCounter++;
            if (History.Count - 1 == 10) History.RemoveAt(0);

            drawing = false;

            if (currentPath != null)
            {
                try
                {
                    currentPath.Dispose();
                    currentPath = null; // Убедимся, что указатель не указывает на старый объект
                }
                catch
                {
                    // Логируем или обрабатываем исключения, если требуется
                }
            }
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            currentPen.Width = trackBar1.Value;
        }

        private void undoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (History.Count != 0 && historyCounter != 0) pictureBox1.Image = new Bitmap(History[--historyCounter]);
            else MessageBox.Show("История пуста");
        }

        private void redoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (historyCounter < History.Count - 1)
            {
                pictureBox1.Image = new Bitmap(History[++historyCounter]);
            }
            else MessageBox.Show("История пуста");
        }

        private void solidToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Solid;
            solidToolStripMenuItem.Checked = true;
            dotToolStripMenuItem.Checked = false;
            dashDotDotToolStripMenuItem.Checked = false;

            currentDashStyle = DashStyle.Solid;
        }

        private void dotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.Dot;
            solidToolStripMenuItem.Checked = false;
            dotToolStripMenuItem.Checked = true;
            dashDotDotToolStripMenuItem.Checked = false;

            currentDashStyle = DashStyle.Dot;
        }

        private void dashDotDotToolStripMenuItem_Click(object sender, EventArgs e)
        {
            currentPen.DashStyle = DashStyle.DashDotDot;
            solidToolStripMenuItem.Checked = false;
            dotToolStripMenuItem.Checked = false;
            dashDotDotToolStripMenuItem.Checked = true;

            currentDashStyle = DashStyle.DashDotDot;
        }

        private void colorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)   //проверка на инициализацию (создание нового файла)
            {
                MessageBox.Show("Сначала создайте новый файл!");
                return;
            }

            currentPen.Color = historyColor;
            Form2 form = new Form2();
            form.Owner = this;
            form.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            toolStripButtonExit_Click(sender, e);
        }

        private void toolStripButtonExit_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                this.Close();
            } else
            {
                image = pictureBox1.Image;
                Form4 form = new Form4();
                form.Owner = this;
                form.ShowDialog();

                if (exit == true) this.Close();
            }
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Я-редактор)");
        }
    }
}
