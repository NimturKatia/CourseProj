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
            this.InputDataTextBox = new System.Windows.Forms.TextBox();
            this.OutputDataTextBox = new System.Windows.Forms.TextBox();
            this.buttonEncrypt = new System.Windows.Forms.Button();
            this.buttonSave = new System.Windows.Forms.Button();
            this.buttonDecrypt = new System.Windows.Forms.Button();
            this.buttonBack = new System.Windows.Forms.Button();
            this.buttonKey = new System.Windows.Forms.Button();
            this.buttonVernamSaveKey = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // InputDataTextBox
            // 
            this.InputDataTextBox.Location = new System.Drawing.Point(14, 50);
            this.InputDataTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.InputDataTextBox.Multiline = true;
            this.InputDataTextBox.Name = "InputDataTextBox";
            this.InputDataTextBox.Size = new System.Drawing.Size(247, 388);
            this.InputDataTextBox.TabIndex = 0;
            // 
            // OutputDataTextBox
            // 
            this.OutputDataTextBox.Location = new System.Drawing.Point(449, 50);
            this.OutputDataTextBox.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.OutputDataTextBox.Multiline = true;
            this.OutputDataTextBox.Name = "OutputDataTextBox";
            this.OutputDataTextBox.Size = new System.Drawing.Size(247, 388);
            this.OutputDataTextBox.TabIndex = 1;
            // 
            // buttonEncrypt
            // 
            this.buttonEncrypt.Location = new System.Drawing.Point(278, 166);
            this.buttonEncrypt.Name = "buttonEncrypt";
            this.buttonEncrypt.Size = new System.Drawing.Size(155, 23);
            this.buttonEncrypt.TabIndex = 2;
            this.buttonEncrypt.Text = "Зашифрувати";
            this.buttonEncrypt.UseVisualStyleBackColor = true;
            this.buttonEncrypt.Click += new System.EventHandler(this.buttonEncrypt_Click);
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(278, 253);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(155, 23);
            this.buttonSave.TabIndex = 3;
            this.buttonSave.Text = "Зберегти отримані дані";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // buttonDecrypt
            // 
            this.buttonDecrypt.Location = new System.Drawing.Point(278, 195);
            this.buttonDecrypt.Name = "buttonDecrypt";
            this.buttonDecrypt.Size = new System.Drawing.Size(155, 23);
            this.buttonDecrypt.TabIndex = 4;
            this.buttonDecrypt.Text = "Розшифрувати";
            this.buttonDecrypt.UseVisualStyleBackColor = true;
            this.buttonDecrypt.Click += new System.EventHandler(this.buttonDecrypt_Click);
            // 
            // buttonBack
            // 
            this.buttonBack.Location = new System.Drawing.Point(621, 460);
            this.buttonBack.Name = "buttonBack";
            this.buttonBack.Size = new System.Drawing.Size(75, 23);
            this.buttonBack.TabIndex = 5;
            this.buttonBack.Text = "Назад";
            this.buttonBack.UseVisualStyleBackColor = true;
            this.buttonBack.Click += new System.EventHandler(this.buttonBack_Click);
            // 
            // buttonKey
            // 
            this.buttonKey.Location = new System.Drawing.Point(278, 137);
            this.buttonKey.Name = "buttonKey";
            this.buttonKey.Size = new System.Drawing.Size(155, 23);
            this.buttonKey.TabIndex = 6;
            this.buttonKey.Text = "Ключ";
            this.buttonKey.UseVisualStyleBackColor = true;
            this.buttonKey.Click += new System.EventHandler(this.buttonKey_Click);
            // 
            // buttonVernamSaveKey
            // 
            this.buttonVernamSaveKey.Location = new System.Drawing.Point(278, 224);
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
            this.label2.Location = new System.Drawing.Point(446, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(68, 17);
            this.label2.TabIndex = 9;
            this.label2.Text = "Результат:";
            // 
            // FormVernam
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 495);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonVernamSaveKey);
            this.Controls.Add(this.buttonKey);
            this.Controls.Add(this.buttonBack);
            this.Controls.Add(this.buttonDecrypt);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.buttonEncrypt);
            this.Controls.Add(this.OutputDataTextBox);
            this.Controls.Add(this.InputDataTextBox);
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

        private System.Windows.Forms.TextBox InputDataTextBox;
        private System.Windows.Forms.TextBox OutputDataTextBox;
        private System.Windows.Forms.Button buttonEncrypt;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.Button buttonDecrypt;
        private System.Windows.Forms.Button buttonBack;
        private System.Windows.Forms.Button buttonKey;
        private System.Windows.Forms.Button buttonVernamSaveKey;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}