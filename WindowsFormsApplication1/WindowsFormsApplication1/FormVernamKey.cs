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
    public partial class FormVernamKey : Form
    {
        public FormVernamKey()
        {
            InitializeComponent();
        }

        private void buttonAccept_Click(object sender, EventArgs e)
        {
            if ((checkBox1.Checked))
            {
                int num = Convert.ToInt32(File.ReadAllText(@"vernamnum"));
                string key = Vernam.genKey(num);
                System.IO.File.WriteAllText(@"vernamKey.txt", key);
                this.Close();
                return;
            }
            if (richTextBoxVernamKey.Text == "")
            {
                MessageBox.Show("Введіть ключ!");
            } else
            {
                System.IO.File.WriteAllText(@"vernamKey.txt", richTextBoxVernamKey.Text);
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
            openFileDialog.Filter = "txt files|*.txt";
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                richTextBoxVernamKey.LoadFile(openFileDialog.FileName, RichTextBoxStreamType.PlainText);

            }
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FormVernamKey_Load(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(@"vernamKey.txt"))
            {
                richTextBoxVernamKey.Text = System.IO.File.ReadAllText(@"vernamKey.txt");
            }
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog();
            saveFileDialog.Filter = "Текстовий документ (*.txt)|*.txt|Всі файли (*.*)|*.*";

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                StreamWriter streamWriter = new StreamWriter(saveFileDialog.FileName);
                streamWriter.WriteLine(richTextBoxVernamKey.Text);
                streamWriter.Close();
            }
        }
    }
}
