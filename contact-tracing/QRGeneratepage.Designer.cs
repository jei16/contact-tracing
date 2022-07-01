namespace contact_tracing
{
    partial class QRGeneratepage
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
            this.Downloadbtn = new System.Windows.Forms.Button();
            this.qrpic = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.GenerateAgain = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.qrpic)).BeginInit();
            this.SuspendLayout();
            // 
            // Downloadbtn
            // 
            this.Downloadbtn.Location = new System.Drawing.Point(222, 554);
            this.Downloadbtn.Name = "Downloadbtn";
            this.Downloadbtn.Size = new System.Drawing.Size(75, 23);
            this.Downloadbtn.TabIndex = 0;
            this.Downloadbtn.Text = "Download";
            this.Downloadbtn.UseVisualStyleBackColor = true;
            this.Downloadbtn.Click += new System.EventHandler(this.Downloadbtn_Click);
            // 
            // qrpic
            // 
            this.qrpic.BackColor = System.Drawing.SystemColors.Control;
            this.qrpic.ImageLocation = "";
            this.qrpic.Location = new System.Drawing.Point(41, 105);
            this.qrpic.Name = "qrpic";
            this.qrpic.Size = new System.Drawing.Size(437, 404);
            this.qrpic.TabIndex = 2;
            this.qrpic.TabStop = false;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 40);
            this.label1.TabIndex = 3;
            this.label1.Text = "Contact Tracing Information\r\n      QR Code Generator";
            // 
            // GenerateAgain
            // 
            this.GenerateAgain.Location = new System.Drawing.Point(209, 604);
            this.GenerateAgain.Name = "GenerateAgain";
            this.GenerateAgain.Size = new System.Drawing.Size(106, 23);
            this.GenerateAgain.TabIndex = 4;
            this.GenerateAgain.Text = "Generate Again";
            this.GenerateAgain.UseVisualStyleBackColor = true;
            this.GenerateAgain.Click += new System.EventHandler(this.GenerateAgain_Click);
            // 
            // QRGeneratepage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(527, 666);
            this.Controls.Add(this.GenerateAgain);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.qrpic);
            this.Controls.Add(this.Downloadbtn);
            this.MaximizeBox = false;
            this.Name = "QRGeneratepage";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "QR Code Generator";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.qrpic)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Downloadbtn;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button GenerateAgain;
        public System.Windows.Forms.PictureBox qrpic;
    }
}