using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Imaging;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba5
{
    public partial class Form4 : Form
    {
        Image imageToSave = Form1.image;

        public Form4()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDialog = new SaveFileDialog
            {
                Filter = "JPEG Image|*.jpg|Bitmap Image|*.bmp|GIF Image|*.gif|PNG Image|*.png",
                Title = "Save an Image File",
                FilterIndex = 4
            };

            if (SaveDialog.ShowDialog() == DialogResult.OK)
            {
                if (SaveDialog.FileName != "")
                {
                    using (System.IO.FileStream fs = (System.IO.FileStream)SaveDialog.OpenFile())
                    {
                        switch (SaveDialog.FilterIndex)
                        {
                            case 1:
                                imageToSave.Save(fs, ImageFormat.Jpeg);
                                break;
                            case 2:
                                imageToSave.Save(fs, ImageFormat.Bmp);
                                break;
                            case 3:
                                imageToSave.Save(fs, ImageFormat.Gif);
                                break;
                            case 4:
                                imageToSave.Save(fs, ImageFormat.Png);
                                break;
                        }
                    }
                }
                else
                {
                    MessageBox.Show("Введите имя файла");
                    return;
                }
                this.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1.exit = true;
            this.Close();
        }
    }
}

