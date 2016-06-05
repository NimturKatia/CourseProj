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
    public partial class FormVernam : Form
    {
        public FormVernam()
        {
            InitializeComponent();
        }

        private void FormVernam_Load(object sender, EventArgs e)
        {

        }

        private void FormVernam_FormClosed(object sender, FormClosedEventArgs e)
        {
            new Form1().Show();
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            if (InputDataTextBox.Text == "")
            {
                MessageBox.Show("Введіть дані для шифрування!");
                return;
            }
            string key = Vernam.genKey(InputDataTextBox.Text.Length);
            string crp = Vernam.Encrypt(InputDataTextBox.Text, key);
            OutpuDataTextBox.Text = crp;
            System.IO.File.WriteAllText(@"vernamKey.txt", key);

        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e) 
        {
        
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string key = System.IO.File.ReadAllText(@"vernamKey.txt"); //Зчитування ключа
                if (InputDataTextBox.Text == "")
                {
                    MessageBox.Show("Введіть дані для дешифрування!");
                    return;
                }
                if (key.Length != InputDataTextBox.Text.Length)
                {
                    MessageBox.Show("Розмір ключа не співпадає з розміром тексту!");
                }
                OutpuDataTextBox.Text = Vernam.Encrypt(InputDataTextBox.Text, key);
            }
            catch (Exception err) // Якщо файлу не існує
            {
                MessageBox.Show("Файлу не існує!");
            }
            
        }

        private void buttonKey_Click(object sender, EventArgs e)
        {
            new FormVernamKey().ShowDialog();   
        }
    }
}
