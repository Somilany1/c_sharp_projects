using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Text.RegularExpressions;

namespace Laba3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void открытьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            OpenFileDialog OpenDlg = new OpenFileDialog();

            if (OpenDlg.ShowDialog() == DialogResult.OK)
            {
                StreamReader Reader = new StreamReader(OpenDlg.FileName, Encoding.Default);
                richTextBox1.Text = Reader.ReadToEnd();
                Reader.Close();
            }
            OpenDlg.Dispose();
        }

        private void сохранитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SaveFileDialog SaveDlg = new SaveFileDialog();
            if (SaveDlg.ShowDialog() == DialogResult.OK)
            {
                StreamWriter Writer = new StreamWriter(SaveDlg.FileName);
                for (int i = 0; i < listBox2.Items.Count; i++)
                {
                    Writer.WriteLine((string)listBox2.Items[i]);
                }
                Writer.Close();
            }
            SaveDlg.Dispose();
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            listBox1.BeginUpdate();
            string[] Strings = richTextBox1.Text.Split(new char[] { '\n','\t', ' ' },
            StringSplitOptions.RemoveEmptyEntries);
            foreach (string s in Strings)
            {
                string Str = s.Trim();
                if (Str == String.Empty) continue;
                if (radioButton1.Checked) listBox1.Items.Add(Str);
                if (radioButton2.Checked)
                {
                    if (Regex.IsMatch(Str, @"\d")) listBox1.Items.Add(Str);
                }
                if (radioButton3.Checked)
                {
                    if (Regex.IsMatch(Str, @"\w+@\w+\.\w+")) listBox1.Items.Add(Str);
                }
            }
            listBox1.EndUpdate();
        }

        private void button13_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
            listBox2.Items.Clear();
            richTextBox1.Text = string.Empty;
            textBox1.Text = string.Empty;
            radioButton1.Checked = true;
            radioButton2.Checked = true;    
            radioButton3.Checked = true;
            checkBox1.Checked = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            listBox3.Items.Clear();
            string Find = textBox1.Text;
            if (checkBox1.Checked) {
                foreach (string String in listBox1.Items)
                {
                    if (String.Contains(Find)) listBox3.Items.Add(String);
                }
            }
            if (checkBox2.Checked)
            {
                foreach (string String in listBox2.Items)
                {
                    if (String.Contains(Find)) listBox3.Items.Add(String);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            Form2 AddRec = new Form2();
            AddRec.Owner = this;
            AddRec.ShowDialog();
        }

        ListBox activeListBox;
        private void DeleteSelectedStrings(ListBox listbox)
        {
            for (int i = listbox.Items.Count - 1; i >= 0; i--)
            {
                if (listbox.GetSelected(i)) listbox.Items.RemoveAt(i);
            }
        }
        private void button8_Click(object sender, EventArgs e)
        {
            DeleteSelectedStrings(activeListBox);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeListBox = listBox1 as ListBox;
        }

        private void listBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            activeListBox = listBox2 as ListBox;
        }

        private void PerenosVseh(ListBox listBoxTo, ListBox listBoxFrom)
        {
            listBoxTo.Items.AddRange(listBoxFrom.Items);
            listBoxFrom.Items.Clear();
        }

        private void Perenos(ListBox ListBoxTo, ListBox ListBoxFrom)
        {
            ListBoxTo.BeginUpdate();

            var selectedItems = ListBoxFrom.SelectedItems.Cast<object>().ToList();

            foreach (object Item in selectedItems)
            {
                ListBoxTo.Items.Add(Item);
                ListBoxFrom.Items.Remove(Item);
            }
            ListBoxTo.EndUpdate();
        }
        private void button3_Click(object sender, EventArgs e)
        {
            PerenosVseh(listBox2, listBox1);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            PerenosVseh(listBox1, listBox2);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Perenos(listBox2, listBox1);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Perenos(listBox1, listBox2);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            int index = -1;
            index = comboBox1.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Не выбран пункт сортировки");
                return;
            }
            else if (index == 0)
            {
                listBox2.Sorted = true;
            }
            else if (index == 1)
            {
                listBox1.Sorted = false;
                string[] itemsArray = new string[listBox1.Items.Count];
                listBox1.Items.CopyTo(itemsArray, 0);
                Array.Reverse(itemsArray); // Переворачиваем массив
                listBox1.Items.Clear();
                listBox1.Items.AddRange(itemsArray);
            }
            else if (index == 2)
            {
                string[] itemsArray = new string[listBox1.Items.Count];
                listBox1.Items.CopyTo(itemsArray, 0);
                // Сортируем массив по длине строк
                Array.Sort(itemsArray, (x, y) => x.Length.CompareTo(y.Length));
                listBox1.Items.Clear();
                listBox1.Items.AddRange(itemsArray);
            }
            else
            {
                string[] itemsArray = new string[listBox1.Items.Count];
                listBox1.Items.CopyTo(itemsArray, 0);
                // Сортируем массив по длине строк
                Array.Sort(itemsArray, (x, y) => y.Length.CompareTo(x.Length));
                listBox1.Items.Clear();
                listBox1.Items.AddRange(itemsArray);
            }
        }

        private void button9_Click(object sender, EventArgs e)
        {
            int index = -1;
            index = comboBox2.SelectedIndex;
            if (index == -1)
            {
                MessageBox.Show("Не выбран пункт сортировки");
                return;
            }
            else if (index == 0)
            {
                listBox2.Sorted = true;
            }
            else if (index == 1)
            {
                listBox2.Sorted = false;
                string[] itemsArray = new string[listBox2.Items.Count];
                listBox2.Items.CopyTo(itemsArray, 0);
                Array.Reverse(itemsArray); // Переворачиваем массив
                listBox2.Items.Clear();
                listBox2.Items.AddRange(itemsArray);
            }
            else if (index == 2)
            {
                string[] itemsArray = new string[listBox2.Items.Count];
                listBox2.Items.CopyTo(itemsArray, 0);
                // Сортируем массив по длине строк
                Array.Sort(itemsArray, (x, y) => x.Length.CompareTo(y.Length));
                listBox2.Items.Clear();
                listBox2.Items.AddRange(itemsArray);
            }
            else
            {
                string[] itemsArray = new string[listBox2.Items.Count];
                listBox2.Items.CopyTo(itemsArray, 0);
                // Сортируем массив по длине строк
                Array.Sort(itemsArray, (x, y) => y.Length.CompareTo(x.Length));
                listBox2.Items.Clear();
                listBox2.Items.AddRange(itemsArray);
            }
        }

        private void button10_Click(object sender, EventArgs e)
        {
            listBox2.Items.Clear();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            listBox1.Items.Clear();
        }
    }
}
