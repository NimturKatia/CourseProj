using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Vigenere : Form
    {
        public Vigenere()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string abc = "abcdefghijklmnopqrstuvwxyz";
            string key = textBoxVigenereKey.Text.ToLower();
            string input = richTextBoxVigenereInput.Text.ToLower();
            richTextBoxVigenereOutput.Text = Encrypt(abc, input, key);
        }

        private string Encrypt(string abc, string input, string key)
        {
            string crp = "";
            string fullkey = "";
            int iter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (iter >= key.Length)
                    iter = 0;
                fullkey += key[iter];
                iter++;
            }

            for (int i = 0; i < input.Length; i++)
            {
                int inKey = abc.IndexOf(input[i]);
                int keKey = abc.IndexOf(fullkey[i]);
                if (inKey >= 0 && keKey >= 0)
                    crp += abc[(inKey + keKey) % abc.Length];
                else
                    crp += " ";
            }

            return crp;
        }

        private string Decrypt(string abc, string input, string key)
        {
            string crp = "";
            string fullkey = "";
            int iter = 0;
            for (int i = 0; i < input.Length; i++)
            {
                if (iter >= key.Length)
                    iter = 0;
                fullkey += key[iter];
                iter++;
            }

            for (int i = 0; i < input.Length; i++)
            {
                int inKey = abc.IndexOf(input[i]);
                int keKey = abc.IndexOf(fullkey[i]);
                if (inKey >= 0 && keKey >= 0)
                    crp += abc[(inKey - keKey + abc.Length) % abc.Length];
                else
                    crp += " ";
            }

            return crp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Vigenere_FormClosed(object sender, FormClosedEventArgs e)
        {
            new FormMenu().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string abc = "abcdefghijklmnopqrstuvwxyz";
            string key = textBoxVigenereKey.Text.ToLower();
            string input = richTextBoxVigenereInput.Text.ToLower();
            richTextBoxVigenereOutput.Text = Decrypt(abc, input, key);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBoxVigenereInput.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);

            }
        }
    }
}
