namespace WindowsFormsApplication1
{
    partial class FormVernam
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
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonKey = new System.Windows.Forms.Button();
            this.buttonVernamSaveKey = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonVernamOpen = new System.Windows.Forms.Button();
            this.richTextBoxVernamInput = new System.Windows.Forms.RichTextBox();
            this.richTextBoxOutput = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(677, 97);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(155, 23);
            this.buttonEncrypt.TabIndex = 2;
            this.buttonEncrypt.Text = "Зашифрувати";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(677, 289);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(155, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Зберегти отримані дані";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(677, 231);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(155, 23);
            this.buttonDecrypt.TabIndex = 4;
            this.buttonDecrypt.Text = "Розшифрувати";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(757, 379);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonKey
            // 
            this.buttonKey.Location = new System.Drawing.Point(677, 39);
            this.buttonKey.Name = "buttonKey";
            this.buttonKey.Size = new System.Drawing.Size(155, 23);
            this.buttonKey.TabIndex = 6;
            this.buttonKey.Text = "Ключ";
            this.buttonKey.UseVisualStyleBackColor = true;
            this.buttonKey.Click += new System.EventHandler(this.buttonKey_Click);
            // 
            // buttonVernamSaveKey
            // 
            this.buttonVernamSaveKey.Location = new System.Drawing.Point(677, 260);
            this.buttonVernamSaveKey.Name = "buttonVernamSaveKey";
            this.buttonVernamSaveKey.Size = new System.Drawing.Size(155, 23);
            this.buttonVernamSaveKey.TabIndex = 7;
            this.buttonVernamSaveKey.Text = "Збрегти ключ";
            this.buttonVernamSaveKey.UseVisualStyleBackColor = true;
            this.buttonVernamSaveKey.Click += new System.EventHandler(this.buttonVernamSaveKey_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 17);
            this.label1.TabIndex = 8;
            this.label1.Text = "Вхідні дані:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 212);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Вихідні дані:";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonVernamOpen
            // 
            this.buttonVernamOpen.Location = new System.Drawing.Point(677, 68);
            this.buttonVernamOpen.Name = "buttonVernamOpen";
            this.buttonVernamOpen.Size = new System.Drawing.Size(155, 23);
            this.buttonVernamOpen.TabIndex = 10;
            this.buttonVernamOpen.Text = "Відкрити файл";
            this.buttonVernamOpen.UseVisualStyleBackColor = true;
            this.buttonVernamOpen.Click += new System.EventHandler(this.buttonVernamOpen_Click);
            // 
            // richTextBoxVernamInput
            // 
            this.richTextBoxVernamInput.Location = new System.Drawing.Point(12, 39);
            this.richTextBoxVernamInput.Name = "richTextBoxVernamInput";
            this.richTextBoxVernamInput.Size = new System.Drawing.Size(647, 170);
            this.richTextBoxVernamInput.TabIndex = 11;
            this.richTextBoxVernamInput.Text = "";
            // 
            // richTextBoxOutput
            // 
            this.richTextBoxOutput.Location = new System.Drawing.Point(12, 232);
            this.richTextBoxOutput.Name = "richTextBoxOutput";
            this.richTextBoxOutput.Size = new System.Drawing.Size(647, 170);
            this.richTextBoxOutput.TabIndex = 12;
            this.richTextBoxOutput.Text = "";
            // 
            // FormVernam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(844, 414);
            this.Controls.Add(this.richTextBoxOutput);
            this.Controls.Add(this.richTextBoxVernamInput);
            this.Controls.Add(this.buttonVernamOpen);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonVernamSaveKey);
            this.Controls.Add(this.buttonKey);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonEncrypt);
            this.Font = new System.Drawing.Font("Calibri", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormVernam";
            this.Text = " Алгоритм Вернама";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormVernam_FormClosed);
            this.Load += new System.EventHandler(this.FormVernam_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonKey;
        private System.Windows.Forms.Button buttonVernamSaveKey;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonVernamOpen;
        private System.Windows.Forms.RichTextBox richTextBoxVernamInput;
        private System.Windows.Forms.RichTextBox richTextBoxOutput;
    }
}