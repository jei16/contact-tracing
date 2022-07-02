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
            this.QRCombobox = new System.Windows.Forms.ComboBox();
            this.QRScannerpic = new System.Windows.Forms.PictureBox();
            this.QRScanTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.QRScannerpic)).BeginInit();
            this.SuspendLayout();
            // 
            // QRCombobox
            // 
            this.QRCombobox.FormattingEnabled = true;
            this.QRCombobox.Location = new System.Drawing.Point(200, 424);
            this.QRCombobox.Name = "QRCombobox";
            this.QRCombobox.Size = new System.Drawing.Size(121, 21);
            this.QRCombobox.TabIndex = 2;
            this.QRCombobox.Visible = false;
            // 
            // QRScannerpic
            // 
            this.QRScannerpic.Location = new System.Drawing.Point(47, 89);
            this.QRScannerpic.Name = "QRScannerpic";
            this.QRScannerpic.Size = new System.Drawing.Size(430, 312);
            this.QRScannerpic.TabIndex = 4;
            this.QRScannerpic.TabStop = false;
            // 
            // QRScanTimer
            // 
            this.QRScanTimer.Interval = 1000;
            this.QRScanTimer.Tick += new System.EventHandler(this.QRScanTimer_Tick);
            // 
            // QRScannerpage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 460);
            this.Controls.Add(this.QRScannerpic);
            this.Controls.Add(this.QRCombobox);
            this.Cursor = System.Windows.Forms.Cursors.Default;
            this.MaximizeBox = false;
            this.Name = "QRScannerpage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code Scanner";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.QRScannerpage_FormClosing);
            this.Load += new System.EventHandler(this.QRScannerpage_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QRScannerpic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer QRScanTimer;
        public System.Windows.Forms.PictureBox QRScannerpic;
        public System.Windows.Forms.ComboBox QRCombobox;
    }
}