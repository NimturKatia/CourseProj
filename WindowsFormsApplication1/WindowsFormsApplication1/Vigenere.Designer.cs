namespace WindowsFormsApplication1
{
    partial class Vigenere
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
            this.textBoxVigenereKey = new System.Windows.Forms.TextBox();
            this.richTextBoxVigenereInput = new System.Windows.Forms.RichTextBox();
            this.richTextBoxVigenereOutput = new System.Windows.Forms.RichTextBox();
            this.buttonVigenereBack = new System.Windows.Forms.Button();
            this.buttonVigenereEncrypt = new System.Windows.Forms.Button();
            this.buttonVigenereDecrypt = new System.Windows.Forms.Button();
            this.buttonVigenereOpen = new System.Windows.Forms.Button();
            this.buttonVigenereSave = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBoxVigenereKey
            // 
            this.textBoxVigenereKey.Location = new System.Drawing.Point(379, 12);
            this.textBoxVigenereKey.Name = "textBoxVigenereKey";
            this.textBoxVigenereKey.Size = new System.Drawing.Size(116, 24);
            this.textBoxVigenereKey.TabIndex = 0;
            // 
            // richTextBoxVigenereInput
            // 
            this.richTextBoxVigenereInput.Location = new System.Drawing.Point(14, 59);
            this.richTextBoxVigenereInput.Name = "richTextBoxVigenereInput";
            this.richTextBoxVigenereInput.Size = new System.Drawing.Size(481, 146);
            this.richTextBoxVigenereInput.TabIndex = 1;
            this.richTextBoxVigenereInput.Text = "";
            // 
            // richTextBoxVigenereOutput
            // 
            this.richTextBoxVigenereOutput.Location = new System.Drawing.Point(14, 238);
            this.richTextBoxVigenereOutput.Name = "richTextBoxVigenereOutput";
            this.richTextBoxVigenereOutput.Size = new System.Drawing.Size(481, 157);
            this.richTextBoxVigenereOutput.TabIndex = 2;
            this.richTextBoxVigenereOutput.Text = "";
            // 
            // buttonVigenereBack
            // 
            this.buttonVigenereBack.Location = new System.Drawing.Point(501, 372);
            this.buttonVigenereBack.Name = "buttonVigenereBack";
            this.buttonVigenereBack.Size = new System.Drawing.Size(107, 23);
            this.buttonVigenereBack.TabIndex = 3;
            this.buttonVigenereBack.Text = "Назад";
            this.buttonVigenereBack.UseVisualStyleBackColor = true;
            this.buttonVigenereBack.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonVigenereEncrypt
            // 
            this.buttonVigenereEncrypt.Location = new System.Drawing.Point(501, 59);
            this.buttonVigenereEncrypt.Name = "buttonVigenereEncrypt";
            this.buttonVigenereEncrypt.Size = new System.Drawing.Size(107, 23);
            this.buttonVigenereEncrypt.TabIndex = 4;
            this.buttonVigenereEncrypt.Text = "Зашифрувати";
            this.buttonVigenereEncrypt.UseVisualStyleBackColor = true;
            this.buttonVigenereEncrypt.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonVigenereDecrypt
            // 
            this.buttonVigenereDecrypt.Location = new System.Drawing.Point(501, 88);
            this.buttonVigenereDecrypt.Name = "buttonVigenereDecrypt";
            this.buttonVigenereDecrypt.Size = new System.Drawing.Size(107, 23);
            this.buttonVigenereDecrypt.TabIndex = 5;
            this.buttonVigenereDecrypt.Text = "Розшифрувати";
            this.buttonVigenereDecrypt.UseVisualStyleBackColor = true;
            this.buttonVigenereDecrypt.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonVigenereOpen
            // 
            this.buttonVigenereOpen.Location = new System.Drawing.Point(501, 267);
            this.buttonVigenereOpen.Name = "buttonVigenereOpen";
            this.buttonVigenereOpen.Size = new System.Drawing.Size(107, 23);
            this.buttonVigenereOpen.TabIndex = 6;
            this.buttonVigenereOpen.Text = "Відкр. файл";
            this.buttonVigenereOpen.UseVisualStyleBackColor = true;
            this.buttonVigenereOpen.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonVigenereSave
            // 
            this.buttonVigenereSave.Location = new System.Drawing.Point(501, 238);
            this.buttonVigenereSave.Name = "buttonVigenereSave";
            this.buttonVigenereSave.Size = new System.Drawing.Size(107, 23);
            this.buttonVigenereSave.TabIndex = 7;
            this.buttonVigenereSave.Text = "Збер. файл";
            this.buttonVigenereSave.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(331, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(40, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Ключ";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 30);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Вхідні дані";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 218);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 17);
            this.label3.TabIndex = 10;
            this.label3.Text = "Вихідні дані";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // Vigenere
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(620, 407);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonVigenereSave);
            this.Controls.Add(this.buttonVigenereOpen);
            this.Controls.Add(this.buttonVigenereDecrypt);
            this.Controls.Add(this.buttonVigenereEncrypt);
            this.Controls.Add(this.buttonVigenereBack);
            this.Controls.Add(this.richTextBoxVigenereOutput);
            this.Controls.Add(this.richTextBoxVigenereInput);
            this.Controls.Add(this.textBoxVigenereKey);
            this.Font = new System.Drawing.Font("Calibri", 10F);
            this.Name = "Vigenere";
            this.Text = "Алгоритм Віженера";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Vigenere_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxVigenereKey;
        private System.Windows.Forms.RichTextBox richTextBoxVigenereInput;
        private System.Windows.Forms.RichTextBox richTextBoxVigenereOutput;
        private System.Windows.Forms.Button buttonVigenereBack;
        private System.Windows.Forms.Button buttonVigenereEncrypt;
        private System.Windows.Forms.Button buttonVigenereDecrypt;
        private System.Windows.Forms.Button buttonVigenereOpen;
        private System.Windows.Forms.Button buttonVigenereSave;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}