namespace WindowsFormsApplication1
{
    partial class RSAKeyDialog
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.bckBtn = new System.Windows.Forms.Button();
            this.accBtn = new System.Windows.Forms.Button();
            this.textBoxE = new System.Windows.Forms.TextBox();
            this.textBoxD = new System.Windows.Forms.TextBox();
            this.textBoxN = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(32, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(54, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Ключ e:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(32, 54);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Ключ d:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 83);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Добуток N:";
            // 
            // bckBtn
            // 
            this.bckBtn.Location = new System.Drawing.Point(327, 124);
            this.bckBtn.Name = "bckBtn";
            this.bckBtn.Size = new System.Drawing.Size(75, 23);
            this.bckBtn.TabIndex = 3;
            this.bckBtn.Text = "Назад";
            this.bckBtn.UseVisualStyleBackColor = true;
            this.bckBtn.Click += new System.EventHandler(this.bckBtn_Click);
            // 
            // accBtn
            // 
            this.accBtn.Location = new System.Drawing.Point(12, 124);
            this.accBtn.Name = "accBtn";
            this.accBtn.Size = new System.Drawing.Size(75, 23);
            this.accBtn.TabIndex = 4;
            this.accBtn.Text = "ОК";
            this.accBtn.UseVisualStyleBackColor = true;
            this.accBtn.Click += new System.EventHandler(this.accBtn_Click);
            // 
            // textBoxE
            // 
            this.textBoxE.Location = new System.Drawing.Point(92, 21);
            this.textBoxE.Name = "textBoxE";
            this.textBoxE.Size = new System.Drawing.Size(310, 24);
            this.textBoxE.TabIndex = 5;
            // 
            // textBoxD
            // 
            this.textBoxD.Location = new System.Drawing.Point(92, 54);
            this.textBoxD.Name = "textBoxD";
            this.textBoxD.Size = new System.Drawing.Size(310, 24);
            this.textBoxD.TabIndex = 6;
            // 
            // textBoxN
            // 
            this.textBoxN.Location = new System.Drawing.Point(92, 83);
            this.textBoxN.Name = "textBoxN";
            this.textBoxN.Size = new System.Drawing.Size(310, 24);
            this.textBoxN.TabIndex = 7;
            // 
            // RSAKeyDialog
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(414, 166);
            this.Controls.Add(this.textBoxN);
            this.Controls.Add(this.textBoxD);
            this.Controls.Add(this.textBoxE);
            this.Controls.Add(this.accBtn);
            this.Controls.Add(this.bckBtn);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Font = new System.Drawing.Font("Calibri", 10F);
            this.Name = "RSAKeyDialog";
            this.Text = "Ключі";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.RSAKeyDialog_FormClosed);
            this.Load += new System.EventHandler(this.RSAKeyDialog_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button bckBtn;
        private System.Windows.Forms.Button accBtn;
        private System.Windows.Forms.TextBox textBoxE;
        private System.Windows.Forms.TextBox textBoxD;
        private System.Windows.Forms.TextBox textBoxN;
    }
}