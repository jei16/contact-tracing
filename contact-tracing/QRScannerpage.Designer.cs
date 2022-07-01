namespace contact_tracing
{
    partial class QRScannerpage
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
            this.Scanbutton = new System.Windows.Forms.Button();
            this.QRCombobox = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.QRScannerpic = new System.Windows.Forms.PictureBox();
            this.QRScanTimer = new System.Windows.Forms.Timer(this.components);
            this.QRScantxtbox = new System.Windows.Forms.RichTextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.QRScannerpic)).BeginInit();
            this.SuspendLayout();
            // 
            // Scanbutton
            // 
            this.Scanbutton.Location = new System.Drawing.Point(306, 456);
            this.Scanbutton.Name = "Scanbutton";
            this.Scanbutton.Size = new System.Drawing.Size(75, 23);
            this.Scanbutton.TabIndex = 0;
            this.Scanbutton.Text = "button1";
            this.Scanbutton.UseVisualStyleBackColor = true;
            this.Scanbutton.Click += new System.EventHandler(this.Scanbutton_Click);
            // 
            // QRCombobox
            // 
            this.QRCombobox.FormattingEnabled = true;
            this.QRCombobox.Location = new System.Drawing.Point(153, 20);
            this.QRCombobox.Name = "QRCombobox";
            this.QRCombobox.Size = new System.Drawing.Size(121, 21);
            this.QRCombobox.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(91, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "label1";
            // 
            // QRScannerpic
            // 
            this.QRScannerpic.Location = new System.Drawing.Point(56, 64);
            this.QRScannerpic.Name = "QRScannerpic";
            this.QRScannerpic.Size = new System.Drawing.Size(380, 287);
            this.QRScannerpic.TabIndex = 4;
            this.QRScannerpic.TabStop = false;
            // 
            // QRScanTimer
            // 
            this.QRScanTimer.Interval = 1000;
            this.QRScanTimer.Tick += new System.EventHandler(this.QRScanTimer_Tick);
            // 
            // QRScantxtbox
            // 
            this.QRScantxtbox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.QRScantxtbox.Cursor = System.Windows.Forms.Cursors.Default;
            this.QRScantxtbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.QRScantxtbox.Location = new System.Drawing.Point(462, 20);
            this.QRScantxtbox.Name = "QRScantxtbox";
            this.QRScantxtbox.ReadOnly = true;
            this.QRScantxtbox.Size = new System.Drawing.Size(350, 422);
            this.QRScantxtbox.TabIndex = 5;
            this.QRScantxtbox.Text = "";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(70, 384);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 6;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(94, 422);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 7;
            // 
            // QRScannerpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(857, 725);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.QRScantxtbox);
            this.Controls.Add(this.QRScannerpic);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.QRCombobox);
            this.Controls.Add(this.Scanbutton);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.Name = "QRScannerpage";
            this.Text = "Form7";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QRScannerpage_FormClosing);
            this.Load += new System.EventHandler(this.QRScannerpage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QRScannerpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Timer QRScanTimer;
        private System.Windows.Forms.RichTextBox QRScantxtbox;
        public System.Windows.Forms.PictureBox QRScannerpic;
        public System.Windows.Forms.Button Scanbutton;
        public System.Windows.Forms.ComboBox QRCombobox;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
    }
}