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
    public partial class RSAKeyDialog : Form
    {
        public RSAKeyDialog()
        {
            InitializeComponent();
        }

        private void bckBtn_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void RSAKeyDialog_FormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void RSAKeyDialog_Load(object sender, EventArgs e)
        {
            string[] keys = File.ReadAllLines(@"RSAkeys.txt");
            if (keys.Length == 3)
            {
                textBoxE.Text = keys[0]; // e
                textBoxD.Text = keys[1]; // d
                textBoxN.Text = keys[2]; // n
            }
        }

        private void accBtn_Click(object sender, EventArgs e)
        {
            if (textBoxE.Text != "" && textBoxD.Text != "" && textBoxN.Text != "")
            {
                string[] keys = new string[3];
                keys[0] = textBoxE.Text;
                keys[1] = textBoxD.Text;
                keys[2] = textBoxN.Text;
                File.WriteAllLines(@"RSAkeys.txt", keys);
            }
            else
                MessageBox.Show("Введіть дані!");
        }
    }
}
