namespace writingMultipleRegister
{
    partial class writeMultipleReg
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
            this.WriteMultiRegister = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.WriteMultiRegister.SuspendLayout();
            this.SuspendLayout();
            // 
            // WriteMultiRegister
            // 
            this.WriteMultiRegister.Controls.Add(this.label1);
            this.WriteMultiRegister.Controls.Add(this.textBox1);
            this.WriteMultiRegister.Location = new System.Drawing.Point(13, 13);
            this.WriteMultiRegister.Name = "WriteMultiRegister";
            this.WriteMultiRegister.Size = new System.Drawing.Size(559, 128);
            this.WriteMultiRegister.TabIndex = 0;
            this.WriteMultiRegister.TabStop = false;
            this.WriteMultiRegister.Text = "WriteMultiReg";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(6, 64);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(547, 58);
            this.textBox1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Values : ";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(19, 159);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(190, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.btnSendMultiReg_Click);
            // 
            // writeMultipleReg
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(584, 199);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.WriteMultiRegister);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "writeMultipleReg";
            this.Text = "FC16";
            this.Load += new System.EventHandler(this.writeMultipleReg_Load);
            this.WriteMultiRegister.ResumeLayout(false);
            this.WriteMultiRegister.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox WriteMultiRegister;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}

