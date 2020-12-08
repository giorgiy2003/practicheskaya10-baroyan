using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Lib_15;

namespace _10
{
    public partial class Form1 : Form
    {
        List<int> list = new List<int>();
        public Form1()
        {
            InitializeComponent();
        }

        private void сгенерироватьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.Clear();
            listBox1.Items.Clear();
            Random random = new Random();
            for (int i = 0; i < Convert.ToInt32(nudKol.Value); i++) 
            {
                list.Add(random.Next(Convert.ToInt32(nudMin.Value), Convert.ToInt32(nudMax.Value)));
                listBox1.Items.Add(list[i]);
            }
        }

        private void сброситьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            list.Clear();
            listBox1.Items.Clear();
            textBoxAdd.Clear();
        }

        private void добавитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Int32.TryParse(textBoxAdd.Text,out int dop))
            {
                list.Add(dop);
                listBox1.Items.Clear();
                for (int i = 0; i < list.Count; i++)
                {
                    listBox1.Items.Add(list[i]);
                }
                textBoxAdd.Clear();
            }
            else
            {
                MessageBox.Show("Ошибка конвертации");
            }
        }

        private void удалитьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int i = listBox1.SelectedIndex;
            if (i != -1)
            {
                listBox1.Items.RemoveAt(i);
                list.RemoveAt(i);
            }
            else
            {
                MessageBox.Show("Элемент не выбран!");
            }
        }

        private void рассчитатьToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if(Lib_15.Task.Work(list))
            {
                MessageBox.Show("В списке есть соседние элементы, отличающиеся друг от друга не более чем на 2");
            }  
            else
            {
                MessageBox.Show("В списке нет соседних элементов, отличающиеся друг от друга не более чем на 2");
            }
            
        }

        private void сброситьToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            list.Clear();
            listBox1.Items.Clear();
            textBoxAdd.Text = "";
        }

        private void оПрограммеToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Проверить, имеется ли в одномерном массиве два соседних элемента, отличающихся друг от друга не более чем на два.");
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
