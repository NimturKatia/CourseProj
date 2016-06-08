namespace WindowsFormsApplication1
{
    partial class FormVernamKey
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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonVernamKeyLoadFromFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.richTextBoxVernamKey = new System.Windows.Forms.RichTextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonSave = new System.Windows.Forms.Button();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.SuspendLayout();
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(12, 180);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(116, 18);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Генерувати ключ";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(185, 246);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(87, 23);
            this.buttonCancel.TabIndex = 2;
            this.buttonCancel.Text = "Відмінити";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonAccept
            // 
            this.buttonAccept.Location = new System.Drawing.Point(12, 246);
            this.buttonAccept.Name = "buttonAccept";
            this.buttonAccept.Size = new System.Drawing.Size(87, 23);
            this.buttonAccept.TabIndex = 3;
            this.buttonAccept.Text = "Підтвердити";
            this.buttonAccept.UseVisualStyleBackColor = true;
            this.buttonAccept.Click += new System.EventHandler(this.buttonAccept_Click);
            // 
            // buttonVernamKeyLoadFromFile
            // 
            this.buttonVernamKeyLoadFromFile.Location = new System.Drawing.Point(12, 145);
            this.buttonVernamKeyLoadFromFile.Name = "buttonVernamKeyLoadFromFile";
            this.buttonVernamKeyLoadFromFile.Size = new System.Drawing.Size(131, 23);
            this.buttonVernamKeyLoadFromFile.TabIndex = 4;
            this.buttonVernamKeyLoadFromFile.Text = "Завантажити з файлу";
            this.buttonVernamKeyLoadFromFile.UseVisualStyleBackColor = true;
            this.buttonVernamKeyLoadFromFile.Click += new System.EventHandler(this.buttonVernamKeyLoadFromFile_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // richTextBoxVernamKey
            // 
            this.richTextBoxVernamKey.Location = new System.Drawing.Point(12, 12);
            this.richTextBoxVernamKey.Name = "richTextBoxVernamKey";
            this.richTextBoxVernamKey.Size = new System.Drawing.Size(248, 127);
            this.richTextBoxVernamKey.TabIndex = 5;
            this.richTextBoxVernamKey.Text = "";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 201);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(154, 14);
            this.label1.TabIndex = 6;
            this.label1.Text = "Введіть кількість символів:";
            // 
            // buttonSave
            // 
            this.buttonSave.Location = new System.Drawing.Point(164, 145);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(96, 23);
            this.buttonSave.TabIndex = 8;
            this.buttonSave.Text = "Зберегти ключ";
            this.buttonSave.UseVisualStyleBackColor = true;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // FormVernamKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.richTextBoxVernamKey);
            this.Controls.Add(this.buttonVernamKeyLoadFromFile);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.checkBox1);
            this.Font = new System.Drawing.Font("Calibri", 9F);
            this.Name = "FormVernamKey";
            this.Text = "Ключ";
            this.Load += new System.EventHandler(this.FormVernamKey_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonVernamKeyLoadFromFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.RichTextBox richTextBoxVernamKey;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonSave;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}