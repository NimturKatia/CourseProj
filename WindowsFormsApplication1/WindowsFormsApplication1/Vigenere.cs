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
            string key = textBox1.Text.ToLower();
            string input = richTextBox1.Text.ToLower();
            richTextBox2.Text = Encrypt(abc, input, key);
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
            new Form1().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            string abc = "abcdefghijklmnopqrstuvwxyz";
            string key = textBox1.Text.ToLower();
            string input = richTextBox1.Text.ToLower();
            richTextBox2.Text = Decrypt(abc, input, key);
        }
    }
}
