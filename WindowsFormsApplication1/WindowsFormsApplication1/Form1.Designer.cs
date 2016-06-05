namespace WindowsFormsApplication1
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.buttonCeasar = new System.Windows.Forms.Button();
            this.buttonVernam = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonCeasar
            // 
            this.buttonCeasar.Location = new System.Drawing.Point(75, 34);
            this.buttonCeasar.Name = "buttonCeasar";
            this.buttonCeasar.Size = new System.Drawing.Size(128, 23);
            this.buttonCeasar.TabIndex = 0;
            this.buttonCeasar.Text = "Алгоритм Цезаря";
            this.buttonCeasar.UseVisualStyleBackColor = true;
            // 
            // buttonVernam
            // 
            this.buttonVernam.Location = new System.Drawing.Point(75, 63);
            this.buttonVernam.Name = "buttonVernam";
            this.buttonVernam.Size = new System.Drawing.Size(128, 23);
            this.buttonVernam.TabIndex = 1;
            this.buttonVernam.Text = "Алгоритм Вернама";
            this.buttonVernam.UseVisualStyleBackColor = true;
            this.buttonVernam.Click += new System.EventHandler(this.buttonVernam_Click_1);
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(75, 92);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(128, 23);
            this.button3.TabIndex = 2;
            this.button3.Text = "RSA";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(75, 121);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(128, 23);
            this.button4.TabIndex = 3;
            this.button4.Text = "Вихід";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // Form1
            // 
            this.ClientSize = new System.Drawing.Size(284, 261);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.buttonVernam);
            this.Controls.Add(this.buttonCeasar);
            this.Font = new System.Drawing.Font("Calibri", 10F);
            this.Name = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form1_FormClosed);
            this.ResumeLayout(false);

        }

        #endregion


        private System.Windows.Forms.Button buttonCeasar;
        private System.Windows.Forms.Button buttonVernam;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button4;
    }
}

