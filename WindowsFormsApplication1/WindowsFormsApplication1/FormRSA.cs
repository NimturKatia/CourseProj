using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApplication1
{
    public partial class FormRSA : Form
    {
        List<int> keys;
        RSA rsa;
        int[] crp;

        public FormRSA()
        {
            
            InitializeComponent();
            rsa = new RSA();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormRSA_FormClosed(object sender, FormClosedEventArgs e)
        {
            new FormMenu().Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            new RSAKeyDialog().ShowDialog();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            richTextBoxRsaOutput.Text = "";
            if (textBoxP.Text == "" && textBoxQ.Text == "")
            {
                MessageBox.Show("Введіть дані!");
                return;
            }
            int p1 = Convert.ToInt32(textBoxP.Text);
            int p2 = Convert.ToInt32(textBoxQ.Text);

            if (!rsa.isPrime(p1) || !rsa.isPrime(p2))
            {
                MessageBox.Show("Введіть прості числа!");
                return;
            }
            string[] _keys = new string[3];
            keys = rsa.generatePairs(p1, p2);
            _keys[0] = keys[1].ToString();
            _keys[1] = keys[2].ToString();
            _keys[2] = keys[0].ToString();
            File.WriteAllLines(@"RSAkeys.txt", _keys);
            string input = richTextBoxRsaInput.Text;
            crp = rsa.Encrypt(keys, input);
            for (int i = 0; i < crp.Length; i += 2)
                richTextBoxRsaOutput.Text += crp[i] + " ";

        }

        private void button4_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовий документ (*.txt)|*.txt|Всі файли (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.WriteLine(richTextBoxRsaOutput.Text);
                streamWriter.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            bool flag = false;
            foreach (char c in richTextBoxRsaOutput.Text)
            {
                if ((c<48)||(c>57))
                {
                    flag = true;
                    MessageBox.Show("Перевірте введені дані!");
                    return;
                }
            }
            richTextBoxRsaOutput.Text = "";
            string[] bytes = richTextBoxRsaInput.Text.Split(' ');
            int[] byteArr = new int[(bytes.Length-1)*2];
            int it = 0;
            for (int i = 0; i < byteArr.Length; i++) {
                if (i % 2 == 1)
                {
                    byteArr[i] = 0;
                    continue;
                }
                byteArr[i] = Int32.Parse(bytes[it]);
                it++;
            }
            string[] _keys = File.ReadAllLines(@"RSAkeys.txt");
            keys[0] = Convert.ToInt32(_keys[2]);
            keys[1] = Convert.ToInt32(_keys[0]);
            keys[2] = Convert.ToInt32(_keys[1]);
            richTextBoxRsaOutput.Text = rsa.Decrypt(keys, byteArr);
            

        }

        private void button6_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "txt files|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBoxRsaInput.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);

            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            richTextBoxRsaOutput.Text = "";
            keys = new List<int>();
            string[] keysArr = File.ReadAllLines(@"RSAkeys.txt");
            if (keysArr.Length >= 3)
            {
                keys.Add(Convert.ToInt32(keysArr[2]));
                keys.Add(Convert.ToInt32(keysArr[0]));
                keys.Add(Convert.ToInt32(keysArr[1]));
                string input = richTextBoxRsaInput.Text;
                crp = rsa.Encrypt(keys, input);
                for (int i = 0; i < crp.Length; i += 2)
                    richTextBoxRsaOutput.Text += crp[i] + " ";
            }
        }
    }
}
