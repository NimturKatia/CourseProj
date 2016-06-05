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
            this.textBoxVernamKeyField = new System.Windows.Forms.TextBox();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonAccept = new System.Windows.Forms.Button();
            this.buttonVernamKeyLoadFromFile = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.SuspendLayout();
            // 
            // textBoxVernamKeyField
            // 
            this.textBoxVernamKeyField.Location = new System.Drawing.Point(12, 34);
            this.textBoxVernamKeyField.Multiline = true;
            this.textBoxVernamKeyField.Name = "textBoxVernamKeyField";
            this.textBoxVernamKeyField.Size = new System.Drawing.Size(260, 104);
            this.textBoxVernamKeyField.TabIndex = 0;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Checked = true;
            this.checkBox1.CheckState = System.Windows.Forms.CheckState.Checked;
            this.checkBox1.Location = new System.Drawing.Point(12, 156);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(248, 18);
            this.checkBox1.TabIndex = 1;
            this.checkBox1.Text = "Використовувати вже згенерований ключ";
            this.checkBox1.UseVisualStyleBackColor = true;
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
            this.buttonVernamKeyLoadFromFile.Location = new System.Drawing.Point(12, 180);
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
            // FormVernamKey
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 14F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 281);
            this.Controls.Add(this.buttonVernamKeyLoadFromFile);
            this.Controls.Add(this.buttonAccept);
            this.Controls.Add(this.buttonCancel);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.textBoxVernamKeyField);
            this.Font = new System.Drawing.Font("Calibri", 9F);
            this.Name = "FormVernamKey";
            this.Text = "Ключ";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBoxVernamKeyField;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonAccept;
        private System.Windows.Forms.Button buttonVernamKeyLoadFromFile;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
    }
}