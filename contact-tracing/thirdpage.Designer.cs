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
            this.components = new System.ComponentModel.Container();
            this.Back = new System.Windows.Forms.Button();
            this.showinfo2 = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.bindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.Month2day = new System.Windows.Forms.DomainUpDown();
            this.Day2day = new System.Windows.Forms.NumericUpDown();
            this.Year2day = new System.Windows.Forms.NumericUpDown();
            this.Infoss24 = new System.Windows.Forms.ListBox();
            this.showinfo1 = new System.Windows.Forms.Button();
            this.Infoss23 = new System.Windows.Forms.ListBox();
            this.next1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day2day)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year2day)).BeginInit();
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
            // showinfo2
            // 
            this.showinfo2.Location = new System.Drawing.Point(351, 11);
            this.showinfo2.Name = "showinfo2";
            this.showinfo2.Size = new System.Drawing.Size(75, 23);
            this.showinfo2.TabIndex = 2;
            this.showinfo2.Text = "Show";
            this.showinfo2.UseVisualStyleBackColor = true;
            this.showinfo2.Click += new System.EventHandler(this.showinfo_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(74, 15);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(82, 13);
            this.label16.TabIndex = 71;
            this.label16.Text = "Date Search:";
            this.label16.Click += new System.EventHandler(this.label16_Click);
            // 
            // bindingSource1
            // 
            this.bindingSource1.CurrentChanged += new System.EventHandler(this.bindingSource1_CurrentChanged);
            // 
            // Month2day
            // 
            this.Month2day.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Month2day.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Month2day.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Month2day.Items.Add("January");
            this.Month2day.Items.Add("February");
            this.Month2day.Items.Add("March");
            this.Month2day.Items.Add("April");
            this.Month2day.Items.Add("May");
            this.Month2day.Items.Add("June");
            this.Month2day.Items.Add("July");
            this.Month2day.Items.Add("August");
            this.Month2day.Items.Add("September");
            this.Month2day.Items.Add("October");
            this.Month2day.Items.Add("November");
            this.Month2day.Items.Add("December");
            this.Month2day.Location = new System.Drawing.Point(164, 13);
            this.Month2day.Name = "Month2day";
            this.Month2day.ReadOnly = true;
            this.Month2day.Size = new System.Drawing.Size(82, 20);
            this.Month2day.TabIndex = 72;
            this.Month2day.Text = "June";
            this.Month2day.SelectedItemChanged += new System.EventHandler(this.Month2day_SelectedItemChanged);
            // 
            // Day2day
            // 
            this.Day2day.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Day2day.Location = new System.Drawing.Point(251, 13);
            this.Day2day.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.Day2day.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Day2day.Name = "Day2day";
            this.Day2day.Size = new System.Drawing.Size(35, 20);
            this.Day2day.TabIndex = 73;
            this.Day2day.Value = new decimal(new int[] {
            24,
            0,
            0,
            0});
            this.Day2day.ValueChanged += new System.EventHandler(this.Day2day_ValueChanged);
            // 
            // Year2day
            // 
            this.Year2day.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Year2day.Location = new System.Drawing.Point(293, 13);
            this.Year2day.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.Year2day.Minimum = new decimal(new int[] {
            2020,
            0,
            0,
            0});
            this.Year2day.Name = "Year2day";
            this.Year2day.Size = new System.Drawing.Size(51, 20);
            this.Year2day.TabIndex = 74;
            this.Year2day.Value = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.Year2day.ValueChanged += new System.EventHandler(this.Year2day_ValueChanged);
            // 
            // Infoss24
            // 
            this.Infoss24.FormattingEnabled = true;
            this.Infoss24.Location = new System.Drawing.Point(34, 62);
            this.Infoss24.Name = "Infoss24";
            this.Infoss24.Size = new System.Drawing.Size(455, 576);
            this.Infoss24.TabIndex = 75;
            this.Infoss24.SelectedIndexChanged += new System.EventHandler(this.Infoss24_SelectedIndexChanged);
            // 
            // showinfo1
            // 
            this.showinfo1.Location = new System.Drawing.Point(351, 11);
            this.showinfo1.Name = "showinfo1";
            this.showinfo1.Size = new System.Drawing.Size(75, 23);
            this.showinfo1.TabIndex = 76;
            this.showinfo1.Text = "Show";
            this.showinfo1.UseVisualStyleBackColor = true;
            this.showinfo1.Click += new System.EventHandler(this.showinfo1_Click);
            // 
            // Infoss23
            // 
            this.Infoss23.FormattingEnabled = true;
            this.Infoss23.Location = new System.Drawing.Point(34, 62);
            this.Infoss23.Name = "Infoss23";
            this.Infoss23.Size = new System.Drawing.Size(455, 576);
            this.Infoss23.TabIndex = 77;
            this.Infoss23.SelectedIndexChanged += new System.EventHandler(this.Infoss23_SelectedIndexChanged);
            // 
            // next1
            // 
            this.next1.Location = new System.Drawing.Point(227, 647);
            this.next1.Name = "next1";
            this.next1.Size = new System.Drawing.Size(75, 23);
            this.next1.TabIndex = 79;
            this.next1.Text = "Next";
            this.next1.UseVisualStyleBackColor = true;
            this.next1.Click += new System.EventHandler(this.next1_Click);
            // 
            // thirdpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 725);
            this.Controls.Add(this.next1);
            this.Controls.Add(this.Infoss23);
            this.Controls.Add(this.showinfo1);
            this.Controls.Add(this.Infoss24);
            this.Controls.Add(this.Year2day);
            this.Controls.Add(this.Day2day);
            this.Controls.Add(this.Month2day);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.showinfo2);
            this.Controls.Add(this.Back);
            this.MaximizeBox = false;
            this.Name = "thirdpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Contact Information";
            this.Load += new System.EventHandler(this.thirdpage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day2day)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Year2day)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Back;
        private System.Windows.Forms.Button showinfo2;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.BindingSource bindingSource1;
        public System.Windows.Forms.DomainUpDown Month2day;
        public System.Windows.Forms.NumericUpDown Day2day;
        public System.Windows.Forms.NumericUpDown Year2day;
        private System.Windows.Forms.ListBox Infoss24;
        private System.Windows.Forms.Button showinfo1;
        private System.Windows.Forms.ListBox Infoss23;
        private System.Windows.Forms.Button next1;
    }
}