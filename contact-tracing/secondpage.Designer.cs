namespace contact_tracing
{
    partial class secondpage
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
            this.magicword = new System.Windows.Forms.TextBox();
            this.submitadmin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(66, 26);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(189, 18);
            this.label1.TabIndex = 0;
            this.label1.Text = "What\'s the magic word?";
            // 
            // magicword
            // 
            this.magicword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.magicword.Location = new System.Drawing.Point(58, 62);
            this.magicword.Name = "magicword";
            this.magicword.Size = new System.Drawing.Size(206, 26);
            this.magicword.TabIndex = 2;
            this.magicword.UseSystemPasswordChar = true;
            // 
            // submitadmin
            // 
            this.submitadmin.Location = new System.Drawing.Point(123, 110);
            this.submitadmin.Name = "submitadmin";
            this.submitadmin.Size = new System.Drawing.Size(75, 23);
            this.submitadmin.TabIndex = 1;
            this.submitadmin.Text = "Enter";
            this.submitadmin.UseVisualStyleBackColor = true;
            this.submitadmin.Click += new System.EventHandler(this.submitadmin_Click);
            // 
            // secondpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 167);
            this.Controls.Add(this.submitadmin);
            this.Controls.Add(this.magicword);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "secondpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Admin Only";
            this.Load += new System.EventHandler(this.Form2_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox magicword;
        private System.Windows.Forms.Button submitadmin;
    }
}