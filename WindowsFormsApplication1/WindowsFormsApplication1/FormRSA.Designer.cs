namespace WindowsFormsApplication1
{
    partial class FormRSA
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
            this.backBtnRsa = new System.Windows.Forms.Button();
            this.textBoxP = new System.Windows.Forms.TextBox();
            this.richTextBoxRsaInput = new System.Windows.Forms.RichTextBox();
            this.richTextBoxRsaOutput = new System.Windows.Forms.RichTextBox();
            this.textBoxQ = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.buttonRsaEncryptByNum = new System.Windows.Forms.Button();
            this.buttonRsaDecrypt = new System.Windows.Forms.Button();
            this.buttonRsaKeys = new System.Windows.Forms.Button();
            this.buttonRsaSave = new System.Windows.Forms.Button();
            this.buttonRsaEncriptByKeys = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.buttonRsaOpen = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // backBtnRsa
            // 
            this.backBtnRsa.Location = new System.Drawing.Point(735, 383);
            this.backBtnRsa.Name = "backBtnRsa";
            this.backBtnRsa.Size = new System.Drawing.Size(108, 23);
            this.backBtnRsa.TabIndex = 0;
            this.backBtnRsa.Text = "Назад";
            this.backBtnRsa.UseVisualStyleBackColor = true;
            this.backBtnRsa.Click += new System.EventHandler(this.backBtn_Click);
            // 
            // textBoxP
            // 
            this.textBoxP.Location = new System.Drawing.Point(342, 22);
            this.textBoxP.Name = "textBoxP";
            this.textBoxP.Size = new System.Drawing.Size(140, 24);
            this.textBoxP.TabIndex = 1;
            // 
            // richTextBoxRsaInput
            // 
            this.richTextBoxRsaInput.Location = new System.Drawing.Point(12, 66);
            this.richTextBoxRsaInput.Name = "richTextBoxRsaInput";
            this.richTextBoxRsaInput.Size = new System.Drawing.Size(717, 142);
            this.richTextBoxRsaInput.TabIndex = 2;
            this.richTextBoxRsaInput.Text = "";
            // 
            // richTextBoxRsaOutput
            // 
            this.richTextBoxRsaOutput.Location = new System.Drawing.Point(12, 243);
            this.richTextBoxRsaOutput.Name = "richTextBoxRsaOutput";
            this.richTextBoxRsaOutput.Size = new System.Drawing.Size(717, 163);
            this.richTextBoxRsaOutput.TabIndex = 3;
            this.richTextBoxRsaOutput.Text = "";
            // 
            // textBoxQ
            // 
            this.textBoxQ.Location = new System.Drawing.Point(589, 22);
            this.textBoxQ.Name = "textBoxQ";
            this.textBoxQ.Size = new System.Drawing.Size(140, 24);
            this.textBoxQ.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(255, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 17);
            this.label1.TabIndex = 5;
            this.label1.Text = "Пр. число(p)";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(502, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Пр. число(q)";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 46);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 7;
            this.label3.Text = "Вхідні дані";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 223);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(79, 17);
            this.label4.TabIndex = 8;
            this.label4.Text = "Вихідні дані";
            // 
            // buttonRsaEncryptByNum
            // 
            this.buttonRsaEncryptByNum.Location = new System.Drawing.Point(735, 66);
            this.buttonRsaEncryptByNum.Name = "buttonRsaEncryptByNum";
            this.buttonRsaEncryptByNum.Size = new System.Drawing.Size(108, 23);
            this.buttonRsaEncryptByNum.TabIndex = 9;
            this.buttonRsaEncryptByNum.Text = "Заш. по числах";
            this.buttonRsaEncryptByNum.UseVisualStyleBackColor = true;
            this.buttonRsaEncryptByNum.Click += new System.EventHandler(this.button1_Click);
            // 
            // buttonRsaDecrypt
            // 
            this.buttonRsaDecrypt.Location = new System.Drawing.Point(735, 242);
            this.buttonRsaDecrypt.Name = "buttonRsaDecrypt";
            this.buttonRsaDecrypt.Size = new System.Drawing.Size(108, 23);
            this.buttonRsaDecrypt.TabIndex = 10;
            this.buttonRsaDecrypt.Text = "Розшифрувати";
            this.buttonRsaDecrypt.UseVisualStyleBackColor = true;
            this.buttonRsaDecrypt.Click += new System.EventHandler(this.button2_Click);
            // 
            // buttonRsaKeys
            // 
            this.buttonRsaKeys.Location = new System.Drawing.Point(735, 124);
            this.buttonRsaKeys.Name = "buttonRsaKeys";
            this.buttonRsaKeys.Size = new System.Drawing.Size(108, 23);
            this.buttonRsaKeys.TabIndex = 11;
            this.buttonRsaKeys.Text = "Ключі";
            this.buttonRsaKeys.UseVisualStyleBackColor = true;
            this.buttonRsaKeys.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonRsaSave
            // 
            this.buttonRsaSave.Location = new System.Drawing.Point(735, 271);
            this.buttonRsaSave.Name = "buttonRsaSave";
            this.buttonRsaSave.Size = new System.Drawing.Size(108, 23);
            this.buttonRsaSave.TabIndex = 12;
            this.buttonRsaSave.Text = "Зберегт. файл";
            this.buttonRsaSave.UseVisualStyleBackColor = true;
            this.buttonRsaSave.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonRsaEncriptByKeys
            // 
            this.buttonRsaEncriptByKeys.Location = new System.Drawing.Point(735, 95);
            this.buttonRsaEncriptByKeys.Name = "buttonRsaEncriptByKeys";
            this.buttonRsaEncriptByKeys.Size = new System.Drawing.Size(108, 23);
            this.buttonRsaEncriptByKeys.TabIndex = 13;
            this.buttonRsaEncriptByKeys.Text = "Заш. по ключах";
            this.buttonRsaEncriptByKeys.UseVisualStyleBackColor = true;
            this.buttonRsaEncriptByKeys.Click += new System.EventHandler(this.button5_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // buttonRsaOpen
            // 
            this.buttonRsaOpen.Location = new System.Drawing.Point(735, 300);
            this.buttonRsaOpen.Name = "buttonRsaOpen";
            this.buttonRsaOpen.Size = new System.Drawing.Size(108, 23);
            this.buttonRsaOpen.TabIndex = 14;
            this.buttonRsaOpen.Text = "Відкр. файл";
            this.buttonRsaOpen.UseVisualStyleBackColor = true;
            this.buttonRsaOpen.Click += new System.EventHandler(this.button6_Click);
            // 
            // FormRSA
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(855, 417);
            this.Controls.Add(this.buttonRsaOpen);
            this.Controls.Add(this.buttonRsaEncriptByKeys);
            this.Controls.Add(this.buttonRsaSave);
            this.Controls.Add(this.buttonRsaKeys);
            this.Controls.Add(this.buttonRsaDecrypt);
            this.Controls.Add(this.buttonRsaEncryptByNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textBoxQ);
            this.Controls.Add(this.richTextBoxRsaOutput);
            this.Controls.Add(this.richTextBoxRsaInput);
            this.Controls.Add(this.textBoxP);
            this.Controls.Add(this.backBtnRsa);
            this.Font = new System.Drawing.Font("Calibri", 10F);
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "FormRSA";
            this.Text = "RSA";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRSA_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button backBtnRsa;
        private System.Windows.Forms.TextBox textBoxP;
        private System.Windows.Forms.RichTextBox richTextBoxRsaInput;
        private System.Windows.Forms.RichTextBox richTextBoxRsaOutput;
        private System.Windows.Forms.TextBox textBoxQ;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button buttonRsaEncryptByNum;
        private System.Windows.Forms.Button buttonRsaDecrypt;
        private System.Windows.Forms.Button buttonRsaKeys;
        private System.Windows.Forms.Button buttonRsaSave;
        private System.Windows.Forms.Button buttonRsaEncriptByKeys;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button buttonRsaOpen;
    }
}