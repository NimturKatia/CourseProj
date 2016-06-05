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
    public partial class FormVernamKey : Form
    {
        public FormVernamKey()
        {
            InitializeComponent();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if (checkBox1.Checked)
            {
                this.Close();
                return;
            }
            if (textBoxVernamKeyField.Text == "")
            {
                MessageBox.Show("Введіть ключ!");
            } else
            {
                System.IO.File.WriteAllText(@"vernamKey.txt", textBoxVernamKeyField.Text);
                this.Close();
            }
        }

        private void buttonCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonVernamKeyLoadFromFile_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Текстовий документ (*.txt)|*.txt|Всі файли (*.*)|*.*";
            if (openFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK && openFileDialog1.FileName != string.Empty)
            {
                textBoxVernamKeyField.Text = File.ReadAllText(openFileDialog.FileName); ;
            }
        }
    }
}
