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
            File.Delete(@"vernamKey.txt");
            new Form1().Show();
        }
        private void buttonBack_Click(object sender, EventArgs e)
        {
            File.Delete(@"vernamKey.txt");
            this.Close();
        }

        private void buttonEncrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string key = File.ReadAllText(@"vernamKey.txt"); //Зчитування ключа
                if (InputDataTextBox.Text == "")
                {
                    MessageBox.Show("Введіть дані для дешифрування!");
                    return;
                }
                if (key.Length != InputDataTextBox.Text.Length)
                {
                    MessageBox.Show("Розмір ключа не співпадає з розміром тексту!");
                    return;
                }
                OutputDataTextBox.Text = Vernam.Encrypt(InputDataTextBox.Text, key);
            }
            catch (Exception err) // Якщо файлу не існує
            {
                MessageBox.Show("Введіть ключ!");
            }
            if (InputDataTextBox.Text == "")
            {
                MessageBox.Show("Введіть дані для шифрування!");
                return;
            }
            
        }

        private void saveFileDialog1_FileOk(object sender, CancelEventArgs e) 
        {
        
        }

        private void buttonDecrypt_Click(object sender, EventArgs e)
        {
            try
            {
                string key = File.ReadAllText(@"vernamKey.txt"); //Зчитування ключа
                if (InputDataTextBox.Text == "")
                {
                    MessageBox.Show("Введіть дані для дешифрування!");
                    return;
                }
                if (key.Length != InputDataTextBox.Text.Length)
                {
                    MessageBox.Show("Розмір ключа не співпадає з розміром тексту!");
                }
                OutputDataTextBox.Text = Vernam.Encrypt(InputDataTextBox.Text, key);
            }
            catch (Exception err) // Якщо файлу не існує
            {
                new FormVernamKey().ShowDialog();

            }

        }

        private void buttonKey_Click(object sender, EventArgs e)
        {
            File.WriteAllText(@"vernamnum", Convert.ToString(InputDataTextBox.Text.Length));
            new FormVernamKey().ShowDialog();   
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовий документ (*.txt)|*.txt|Всі файли (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.WriteLine(OutputDataTextBox.Text);
                streamWriter.Close();
            }
        }

        private void buttonVernamSaveKey_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовий документ (*.txt)|*.txt|Всі файли (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                string key = File.ReadAllText(@"vernamKey.txt");
                streamWriter.WriteLine(key);
                streamWriter.Close();
            }
        }
    }
}
