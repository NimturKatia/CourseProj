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

namespace WindowsFormsApplication1
{
    public partial class CaesarForm : Form
    {
        string abc = "abcdefghijklmnopqrstuvwxyz";
        public CaesarForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("EMPTY KEY FIELD");
                return;
            }
            int key = Convert.ToInt32(textBox1.Text);
            string input = richTextBox1.Text.ToLower();
            string crypted = "";

            for (int i = 0; i < input.Length; i++)
            {
                if (abc.IndexOf(input[i]) >= 0)
                {
                    crypted += abc[(abc.IndexOf(input[i]) + key) % abc.Length];
                }
                else if (abc.IndexOf(input[i]) == -1)
                    crypted += " ";
            }
            richTextBox2.Text = crypted;
        }

        private void CaesarForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Form1().Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "")
            {
                MessageBox.Show("EMPTY KEY FIELD");
                return;
            }
            int key = Convert.ToInt32(textBox1.Text);
            string output = "";
            string crp = richTextBox1.Text;
            int it = 0;
            for (int i = 0; i < crp.Length; i++)
            {
                while ((abc.IndexOf(crp[i]) - key + it) < 0) { 
                    it += abc.Length;
                }
                if (abc.IndexOf(crp[i]) == -1)
                {
                    output += " ";
                    continue;
                }
                output += abc[(abc.IndexOf(crp[i]) - key) % abc.Length];
            }
            richTextBox2.Text = output;
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBox1.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовий документ (*.txt)|*.txt|Всі файли (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.WriteLine(richTextBox2.Text);
                streamWriter.Close();
            }
        }
    }
}
