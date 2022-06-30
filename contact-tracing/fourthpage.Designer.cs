namespace contact_tracing
{
    partial class fourthpage
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
            this.components = new System.ComponentModel.Container();
            this.label16 = new System.Windows.Forms.Label();
            this.showinfo2 = new System.Windows.Forms.Button();
            this.Back2 = new System.Windows.Forms.Button();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Infoss23 = new System.Windows.Forms.ListBox();
            this.showinfo1 = new System.Windows.Forms.Button();
            this.Infoss24 = new System.Windows.Forms.ListBox();
            this.LastName = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.MiddleName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(12, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(87, 13);
            this.label16.TabIndex = 81;
            this.label16.Text = "Name Search:";
            // 
            // showinfo2
            // 
            this.showinfo2.Location = new System.Drawing.Point(435, 11);
            this.showinfo2.Name = "showinfo2";
            this.showinfo2.Size = new System.Drawing.Size(75, 23);
            this.showinfo2.TabIndex = 80;
            this.showinfo2.Text = "Show";
            this.showinfo2.UseVisualStyleBackColor = true;
            this.showinfo2.Click += new System.EventHandler(this.showinfo2_Click);
            // 
            // Back2
            // 
            this.Back2.Location = new System.Drawing.Point(229, 690);
            this.Back2.Name = "Back2";
            this.Back2.Size = new System.Drawing.Size(75, 23);
            this.Back2.TabIndex = 79;
            this.Back2.Text = "Back";
            this.Back2.UseVisualStyleBackColor = true;
            this.Back2.Click += new System.EventHandler(this.Back2_Click);
            // 
            // Infoss23
            // 
            this.Infoss23.FormattingEnabled = true;
            this.Infoss23.Location = new System.Drawing.Point(36, 62);
            this.Infoss23.Name = "Infoss23";
            this.Infoss23.Size = new System.Drawing.Size(455, 576);
            this.Infoss23.TabIndex = 87;
            // 
            // showinfo1
            // 
            this.showinfo1.Location = new System.Drawing.Point(435, 11);
            this.showinfo1.Name = "showinfo1";
            this.showinfo1.Size = new System.Drawing.Size(75, 23);
            this.showinfo1.TabIndex = 86;
            this.showinfo1.Text = "Show";
            this.showinfo1.UseVisualStyleBackColor = true;
            this.showinfo1.Click += new System.EventHandler(this.showinfo1_Click);
            // 
            // Infoss24
            // 
            this.Infoss24.FormattingEnabled = true;
            this.Infoss24.Location = new System.Drawing.Point(36, 62);
            this.Infoss24.Name = "Infoss24";
            this.Infoss24.Size = new System.Drawing.Size(455, 576);
            this.Infoss24.TabIndex = 85;
            // 
            // LastName
            // 
            this.LastName.Location = new System.Drawing.Point(105, 12);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(100, 20);
            this.LastName.TabIndex = 88;
            // 
            // FirstName
            // 
            this.FirstName.Location = new System.Drawing.Point(211, 12);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(100, 20);
            this.FirstName.TabIndex = 89;
            // 
            // MiddleName
            // 
            this.MiddleName.Location = new System.Drawing.Point(317, 12);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(100, 20);
            this.MiddleName.TabIndex = 90;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label1.Location = new System.Drawing.Point(138, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 13);
            this.label1.TabIndex = 91;
            this.label1.Text = "L.N.";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(245, 35);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 13);
            this.label3.TabIndex = 93;
            this.label3.Text = "F.N.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label2.Location = new System.Drawing.Point(351, 35);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(30, 13);
            this.label2.TabIndex = 94;
            this.label2.Text = "M.N.";
            // 
            // fourthpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 725);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.showinfo2);
            this.Controls.Add(this.Back2);
            this.Controls.Add(this.Infoss23);
            this.Controls.Add(this.showinfo1);
            this.Controls.Add(this.Infoss24);
            this.MaximizeBox = false;
            this.Name = "fourthpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Information";
            this.Load += new System.EventHandler(this.fourthpage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Button showinfo2;
        private System.Windows.Forms.Button Back2;
        private System.Windows.Forms.BindingSource bindingSource1;
        private System.Windows.Forms.ListBox Infoss23;
        private System.Windows.Forms.Button showinfo1;
        private System.Windows.Forms.ListBox Infoss24;
        private System.Windows.Forms.TextBox LastName;
        private System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.TextBox MiddleName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}