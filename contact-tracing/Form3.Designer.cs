namespace contact_tracing
{
    partial class thirdpage
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
            this.Back = new System.Windows.Forms.Button();
            this.showinfo = new System.Windows.Forms.Button();
            this.Infoss = new System.Windows.Forms.ListBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Back
            // 
            this.Back.Location = new System.Drawing.Point(227, 690);
            this.Back.Name = "Back";
            this.Back.Size = new System.Drawing.Size(75, 23);
            this.Back.TabIndex = 0;
            this.Back.Text = "Back";
            this.Back.UseVisualStyleBackColor = true;
            this.Back.Click += new System.EventHandler(this.Back_Click);
            // 
            // showinfo
            // 
            this.showinfo.Location = new System.Drawing.Point(325, 12);
            this.showinfo.Name = "showinfo";
            this.showinfo.Size = new System.Drawing.Size(75, 23);
            this.showinfo.TabIndex = 2;
            this.showinfo.Text = "show";
            this.showinfo.UseVisualStyleBackColor = true;
            this.showinfo.Click += new System.EventHandler(this.showinfo_Click);
            // 
            // Infoss
            // 
            this.Infoss.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Infoss.FormattingEnabled = true;
            this.Infoss.Location = new System.Drawing.Point(25, 53);
            this.Infoss.Name = "Infoss";
            this.Infoss.Size = new System.Drawing.Size(477, 576);
            this.Infoss.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(184, 14);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(126, 20);
            this.textBox1.TabIndex = 4;
            // 
            // thirdpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 725);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.Infoss);
            this.Controls.Add(this.showinfo);
            this.Controls.Add(this.Back);
            this.MaximizeBox = false;
            this.Name = "thirdpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Information";
            this.Load += new System.EventHandler(this.thirdpage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button showinfo;
        private System.Windows.Forms.ListBox Infoss;
        private System.Windows.Forms.TextBox textBox1;
    }
}