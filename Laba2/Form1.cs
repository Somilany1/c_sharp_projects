using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Laba2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        //Задание 1
        int y1 = 10;
        int y2 = 20;
        private void panel1_Click(object sender, EventArgs e)
        {
            Button b = new Button();
            b.Text = "Button";
            b.Parent = panel1;
            b.Location = new Point(10, y1);
            y1 += 30;
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {
            TextBox t = new TextBox();
            t.Text = "TextBox";
            t.Parent = tabPage1;
            t.Location = new Point(400, y2);
            y2 += 30;
        }


        //Задание 2
        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            int index = listBox1.SelectedIndex;
            string str = (string)listBox1.Items[index];
            int length = str.Length;
            int count = 0;
            string punctuation = ",./<>?!@#$%^&*()_+=-№;:";

            foreach (char symbol in str)
            {
                if (punctuation.Contains(symbol))
                {
                    count++;
                }
            }

            label2.Text = count.ToString();

        }

        //Задание 3

        int[] Mas1 = new int[18];
        int[] Mas2 = new int[18];
        private bool isFirstButtonClicked = false;

        private void button1_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
            
            Random rand = new Random();
            isFirstButtonClicked = true;
            for (int i = 0; i < 18; i++)
            {
                Mas1[i] = rand.Next(-50,50);
                listBox2.Items.Add("Mas1[" + i.ToString() + "]= " + Mas1[i].ToString());
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();

            if  (isFirstButtonClicked) {
                for (int i = 0; i < 18; i++)
                {
                    Mas2[i] = (int)(0.13 * Math.Pow(Mas1[i], 3) - (2.5 * Mas1[i]) + 8);
                    listBox3.Items.Add("Mas2[" + i.ToString() + "]= " + Mas2[i].ToString());
                }
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            listBox4.Items.Clear();

            for (int i = 0; i < 18; i++)
            {
                if (Mas2[i] < 0)
                {
                    listBox4.Items.Add("Mas3[" + i.ToString() + "]= " + Mas2[i].ToString());
                }
            }
        }

        //Задание 4
        private void button4_Click(object sender, EventArgs e)
        {
            dataGridView1.RowCount = 10;
            dataGridView1.ColumnCount = 10;
            dataGridView2.RowCount = 10;
            dataGridView2.ColumnCount = 10;
            int[,] a = new int[10, 10];
            int[,] b = new int[10, 10];
            int i, j;
            int sum = 0;

            Random rand = new Random();
            for (i = 0; i < 10; i++) 
                for (j = 0; j < 10; j++)
                {
                    a[i, j] = rand.Next(-100, 100);
                }

            for (i = 0; i < 10; i++)
                for (j = 0; j < 10; j++) 
                {
                    dataGridView1.Rows[i].Cells[j].Value = a[i, j].ToString();
                }

            for (i = 0; i < 10; i++)
                for (j = 0; j < 10; j++)
                {
                    if (i == j)
                    {
                        sum += a[i, j];
                    }
                }

            textBox1.Text = sum.ToString();

            if (sum > 10)
            {
                for (i = 0; i < 10; i++)
                    for (j = 0; j < 10; j++)
                    {
                        b[i, j] = (int)(a[i, j] + 13.5);
                        dataGridView2.Rows[i].Cells[j].Value = b[i, j].ToString();
                    }
            } else
            {
                for (i = 0; i < 10; i++)
                    for (j = 0; j < 10; j++)
                    {
                        b[i, j] = (int)(Math.Pow(a[i, j],2) - 1.5);
                        dataGridView2.Rows[i].Cells[j].Value = b[i, j].ToString();
                    }
            }
        }
    }
}
