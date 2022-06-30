namespace contact_tracing
{
    partial class QRCodeFillUp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.Othersbutton = new System.Windows.Forms.RadioButton();
            this.FemaleButton = new System.Windows.Forms.RadioButton();
            this.MaleButton = new System.Windows.Forms.RadioButton();
            this.genderlabel = new System.Windows.Forms.Label();
            this.OtherTextBox = new System.Windows.Forms.TextBox();
            this.FirstName = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Year = new System.Windows.Forms.NumericUpDown();
            this.Day = new System.Windows.Forms.NumericUpDown();
            this.Email = new System.Windows.Forms.TextBox();
            this.emaillabel = new System.Windows.Forms.Label();
            this.ContactNumber = new System.Windows.Forms.TextBox();
            this.contactlabel = new System.Windows.Forms.Label();
            this.MiddleName = new System.Windows.Forms.TextBox();
            this.mnlabel = new System.Windows.Forms.Label();
            this.LastName = new System.Windows.Forms.TextBox();
            this.Address = new System.Windows.Forms.TextBox();
            this.addresslabel = new System.Windows.Forms.Label();
            this.Month = new System.Windows.Forms.DomainUpDown();
            this.bdaylabel = new System.Windows.Forms.Label();
            this.Age = new System.Windows.Forms.TextBox();
            this.agelabel = new System.Windows.Forms.Label();
            this.lnlabel = new System.Windows.Forms.Label();
            this.Fnlabel = new System.Windows.Forms.Label();
            this.panel6 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.HasBooster = new System.Windows.Forms.RadioButton();
            this.NoBooster = new System.Windows.Forms.RadioButton();
            this.boosterlabel = new System.Windows.Forms.Label();
            this.fullyvac = new System.Windows.Forms.RadioButton();
            this.firstdosevac = new System.Windows.Forms.RadioButton();
            this.NoVac = new System.Windows.Forms.RadioButton();
            this.receivedlabel = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.panel4 = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.Generatebutton = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Year)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day)).BeginInit();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel4.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(125, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(266, 40);
            this.label1.TabIndex = 4;
            this.label1.Text = "Contact Tracing Information\r\n      QR Code Generator";
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Othersbutton);
            this.panel1.Controls.Add(this.FemaleButton);
            this.panel1.Controls.Add(this.MaleButton);
            this.panel1.Controls.Add(this.genderlabel);
            this.panel1.Controls.Add(this.OtherTextBox);
            this.panel1.Location = new System.Drawing.Point(276, 185);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(239, 147);
            this.panel1.TabIndex = 81;
            // 
            // Othersbutton
            // 
            this.Othersbutton.AutoSize = true;
            this.Othersbutton.Location = new System.Drawing.Point(19, 88);
            this.Othersbutton.Name = "Othersbutton";
            this.Othersbutton.Size = new System.Drawing.Size(132, 17);
            this.Othersbutton.TabIndex = 11;
            this.Othersbutton.TabStop = true;
            this.Othersbutton.Text = "Others (please specify)";
            this.Othersbutton.UseVisualStyleBackColor = true;
            this.Othersbutton.CheckedChanged += new System.EventHandler(this.Othersbutton_CheckedChanged);
            // 
            // FemaleButton
            // 
            this.FemaleButton.AutoSize = true;
            this.FemaleButton.Location = new System.Drawing.Point(19, 65);
            this.FemaleButton.Name = "FemaleButton";
            this.FemaleButton.Size = new System.Drawing.Size(59, 17);
            this.FemaleButton.TabIndex = 8;
            this.FemaleButton.TabStop = true;
            this.FemaleButton.Text = "Female";
            this.FemaleButton.UseVisualStyleBackColor = true;
            this.FemaleButton.CheckedChanged += new System.EventHandler(this.FemaleButton_CheckedChanged);
            // 
            // MaleButton
            // 
            this.MaleButton.AutoSize = true;
            this.MaleButton.Location = new System.Drawing.Point(19, 38);
            this.MaleButton.Name = "MaleButton";
            this.MaleButton.Size = new System.Drawing.Size(48, 17);
            this.MaleButton.TabIndex = 7;
            this.MaleButton.TabStop = true;
            this.MaleButton.Text = "Male";
            this.MaleButton.UseVisualStyleBackColor = true;
            this.MaleButton.CheckedChanged += new System.EventHandler(this.MaleButton_CheckedChanged);
            // 
            // genderlabel
            // 
            this.genderlabel.AutoSize = true;
            this.genderlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.genderlabel.Location = new System.Drawing.Point(16, 13);
            this.genderlabel.Name = "genderlabel";
            this.genderlabel.Size = new System.Drawing.Size(48, 13);
            this.genderlabel.TabIndex = 6;
            this.genderlabel.Text = "Gender";
            // 
            // OtherTextBox
            // 
            this.OtherTextBox.Enabled = false;
            this.OtherTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F);
            this.OtherTextBox.Location = new System.Drawing.Point(22, 105);
            this.OtherTextBox.Name = "OtherTextBox";
            this.OtherTextBox.Size = new System.Drawing.Size(214, 20);
            this.OtherTextBox.TabIndex = 10;
            this.OtherTextBox.TextChanged += new System.EventHandler(this.OtherTextBox_TextChanged);
            // 
            // FirstName
            // 
            this.FirstName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.FirstName.Location = new System.Drawing.Point(17, 149);
            this.FirstName.Name = "FirstName";
            this.FirstName.Size = new System.Drawing.Size(156, 30);
            this.FirstName.TabIndex = 80;
            this.FirstName.TabStop = false;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label12.Location = new System.Drawing.Point(116, 278);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 79;
            this.label12.Text = "Y";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label11.Location = new System.Drawing.Point(116, 252);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(15, 13);
            this.label11.TabIndex = 78;
            this.label11.Text = "D";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label10.Location = new System.Drawing.Point(116, 227);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(16, 13);
            this.label10.TabIndex = 77;
            this.label10.Text = "M";
            // 
            // Year
            // 
            this.Year.Location = new System.Drawing.Point(138, 276);
            this.Year.Maximum = new decimal(new int[] {
            2022,
            0,
            0,
            0});
            this.Year.Minimum = new decimal(new int[] {
            1900,
            0,
            0,
            0});
            this.Year.Name = "Year";
            this.Year.Size = new System.Drawing.Size(120, 20);
            this.Year.TabIndex = 76;
            this.Year.Value = new decimal(new int[] {
            2003,
            0,
            0,
            0});
            // 
            // Day
            // 
            this.Day.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Day.Location = new System.Drawing.Point(138, 250);
            this.Day.Maximum = new decimal(new int[] {
            31,
            0,
            0,
            0});
            this.Day.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.Day.Name = "Day";
            this.Day.Size = new System.Drawing.Size(120, 20);
            this.Day.TabIndex = 75;
            this.Day.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // Email
            // 
            this.Email.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Email.Location = new System.Drawing.Point(230, 408);
            this.Email.Name = "Email";
            this.Email.Size = new System.Drawing.Size(282, 30);
            this.Email.TabIndex = 74;
            // 
            // emaillabel
            // 
            this.emaillabel.AutoSize = true;
            this.emaillabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emaillabel.Location = new System.Drawing.Point(227, 392);
            this.emaillabel.Name = "emaillabel";
            this.emaillabel.Size = new System.Drawing.Size(86, 13);
            this.emaillabel.TabIndex = 73;
            this.emaillabel.Text = "Email Address";
            // 
            // ContactNumber
            // 
            this.ContactNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.ContactNumber.Location = new System.Drawing.Point(17, 408);
            this.ContactNumber.Name = "ContactNumber";
            this.ContactNumber.Size = new System.Drawing.Size(174, 30);
            this.ContactNumber.TabIndex = 72;
            // 
            // contactlabel
            // 
            this.contactlabel.AutoSize = true;
            this.contactlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.contactlabel.Location = new System.Drawing.Point(14, 392);
            this.contactlabel.Name = "contactlabel";
            this.contactlabel.Size = new System.Drawing.Size(98, 13);
            this.contactlabel.TabIndex = 71;
            this.contactlabel.Text = "Contact Number";
            // 
            // MiddleName
            // 
            this.MiddleName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.MiddleName.Location = new System.Drawing.Point(185, 149);
            this.MiddleName.Name = "MiddleName";
            this.MiddleName.Size = new System.Drawing.Size(156, 30);
            this.MiddleName.TabIndex = 70;
            // 
            // mnlabel
            // 
            this.mnlabel.AutoSize = true;
            this.mnlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mnlabel.Location = new System.Drawing.Point(185, 133);
            this.mnlabel.Name = "mnlabel";
            this.mnlabel.Size = new System.Drawing.Size(80, 13);
            this.mnlabel.TabIndex = 69;
            this.mnlabel.Text = "Middle Name";
            // 
            // LastName
            // 
            this.LastName.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.LastName.Location = new System.Drawing.Point(359, 149);
            this.LastName.Name = "LastName";
            this.LastName.Size = new System.Drawing.Size(156, 30);
            this.LastName.TabIndex = 68;
            // 
            // Address
            // 
            this.Address.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Address.Location = new System.Drawing.Point(17, 344);
            this.Address.Name = "Address";
            this.Address.Size = new System.Drawing.Size(498, 30);
            this.Address.TabIndex = 67;
            // 
            // addresslabel
            // 
            this.addresslabel.AutoSize = true;
            this.addresslabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addresslabel.Location = new System.Drawing.Point(14, 328);
            this.addresslabel.Name = "addresslabel";
            this.addresslabel.Size = new System.Drawing.Size(52, 13);
            this.addresslabel.TabIndex = 66;
            this.addresslabel.Text = "Address";
            // 
            // Month
            // 
            this.Month.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.Month.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Month.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.Month.Items.Add("January");
            this.Month.Items.Add("February");
            this.Month.Items.Add("March");
            this.Month.Items.Add("April");
            this.Month.Items.Add("May");
            this.Month.Items.Add("June");
            this.Month.Items.Add("July");
            this.Month.Items.Add("August");
            this.Month.Items.Add("September");
            this.Month.Items.Add("October");
            this.Month.Items.Add("November");
            this.Month.Items.Add("December");
            this.Month.Location = new System.Drawing.Point(138, 224);
            this.Month.Name = "Month";
            this.Month.ReadOnly = true;
            this.Month.Size = new System.Drawing.Size(120, 20);
            this.Month.TabIndex = 65;
            this.Month.Text = "January";
            this.Month.SelectedItemChanged += new System.EventHandler(this.Month_SelectedItemChanged);
            // 
            // bdaylabel
            // 
            this.bdaylabel.AutoSize = true;
            this.bdaylabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bdaylabel.Location = new System.Drawing.Point(113, 199);
            this.bdaylabel.Name = "bdaylabel";
            this.bdaylabel.Size = new System.Drawing.Size(53, 13);
            this.bdaylabel.TabIndex = 64;
            this.bdaylabel.Text = "Birthday";
            // 
            // Age
            // 
            this.Age.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F);
            this.Age.Location = new System.Drawing.Point(17, 224);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(57, 30);
            this.Age.TabIndex = 63;
            this.Age.TabStop = false;
            // 
            // agelabel
            // 
            this.agelabel.AutoSize = true;
            this.agelabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.agelabel.Location = new System.Drawing.Point(14, 199);
            this.agelabel.Name = "agelabel";
            this.agelabel.Size = new System.Drawing.Size(29, 13);
            this.agelabel.TabIndex = 62;
            this.agelabel.Text = "Age";
            // 
            // lnlabel
            // 
            this.lnlabel.AutoSize = true;
            this.lnlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lnlabel.Location = new System.Drawing.Point(356, 133);
            this.lnlabel.Name = "lnlabel";
            this.lnlabel.Size = new System.Drawing.Size(67, 13);
            this.lnlabel.TabIndex = 61;
            this.lnlabel.Text = "Last Name";
            // 
            // Fnlabel
            // 
            this.Fnlabel.AutoSize = true;
            this.Fnlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Fnlabel.Location = new System.Drawing.Point(14, 133);
            this.Fnlabel.Name = "Fnlabel";
            this.Fnlabel.Size = new System.Drawing.Size(67, 13);
            this.Fnlabel.TabIndex = 60;
            this.Fnlabel.Text = "First Name";
            // 
            // panel6
            // 
            this.panel6.Location = new System.Drawing.Point(102, 189);
            this.panel6.Name = "panel6";
            this.panel6.Size = new System.Drawing.Size(168, 121);
            this.panel6.TabIndex = 82;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.HasBooster);
            this.panel2.Controls.Add(this.NoBooster);
            this.panel2.Controls.Add(this.boosterlabel);
            this.panel2.Location = new System.Drawing.Point(286, 462);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(101, 114);
            this.panel2.TabIndex = 93;
            // 
            // HasBooster
            // 
            this.HasBooster.AutoSize = true;
            this.HasBooster.Enabled = false;
            this.HasBooster.Location = new System.Drawing.Point(12, 55);
            this.HasBooster.Name = "HasBooster";
            this.HasBooster.Size = new System.Drawing.Size(43, 17);
            this.HasBooster.TabIndex = 33;
            this.HasBooster.TabStop = true;
            this.HasBooster.Text = "Yes";
            this.HasBooster.UseVisualStyleBackColor = true;
            this.HasBooster.CheckedChanged += new System.EventHandler(this.HasBooster_CheckedChanged);
            // 
            // NoBooster
            // 
            this.NoBooster.AutoSize = true;
            this.NoBooster.Enabled = false;
            this.NoBooster.Location = new System.Drawing.Point(12, 32);
            this.NoBooster.Name = "NoBooster";
            this.NoBooster.Size = new System.Drawing.Size(39, 17);
            this.NoBooster.TabIndex = 32;
            this.NoBooster.TabStop = true;
            this.NoBooster.Text = "No";
            this.NoBooster.UseVisualStyleBackColor = true;
            this.NoBooster.CheckedChanged += new System.EventHandler(this.NoBooster_CheckedChanged);
            // 
            // boosterlabel
            // 
            this.boosterlabel.AutoSize = true;
            this.boosterlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.boosterlabel.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.boosterlabel.Location = new System.Drawing.Point(9, 12);
            this.boosterlabel.Name = "boosterlabel";
            this.boosterlabel.Size = new System.Drawing.Size(87, 13);
            this.boosterlabel.TabIndex = 31;
            this.boosterlabel.Text = "Booster Shot?";
            // 
            // fullyvac
            // 
            this.fullyvac.AutoSize = true;
            this.fullyvac.Location = new System.Drawing.Point(17, 539);
            this.fullyvac.Name = "fullyvac";
            this.fullyvac.Size = new System.Drawing.Size(220, 17);
            this.fullyvac.TabIndex = 92;
            this.fullyvac.TabStop = true;
            this.fullyvac.Text = "Yes, Fully Vaccinated (1st and 2nd Dose)";
            this.fullyvac.UseVisualStyleBackColor = true;
            this.fullyvac.CheckedChanged += new System.EventHandler(this.fullyvac_CheckedChanged);
            // 
            // firstdosevac
            // 
            this.firstdosevac.AutoSize = true;
            this.firstdosevac.Location = new System.Drawing.Point(17, 516);
            this.firstdosevac.Name = "firstdosevac";
            this.firstdosevac.Size = new System.Drawing.Size(113, 17);
            this.firstdosevac.TabIndex = 91;
            this.firstdosevac.TabStop = true;
            this.firstdosevac.Text = "Yes, 1st Dose only";
            this.firstdosevac.UseVisualStyleBackColor = true;
            this.firstdosevac.CheckedChanged += new System.EventHandler(this.firstdosevac_CheckedChanged);
            // 
            // NoVac
            // 
            this.NoVac.AutoSize = true;
            this.NoVac.Location = new System.Drawing.Point(17, 493);
            this.NoVac.Name = "NoVac";
            this.NoVac.Size = new System.Drawing.Size(39, 17);
            this.NoVac.TabIndex = 90;
            this.NoVac.TabStop = true;
            this.NoVac.Text = "No";
            this.NoVac.UseVisualStyleBackColor = true;
            this.NoVac.CheckedChanged += new System.EventHandler(this.NoVac_CheckedChanged);
            // 
            // receivedlabel
            // 
            this.receivedlabel.AutoSize = true;
            this.receivedlabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.receivedlabel.Location = new System.Drawing.Point(14, 473);
            this.receivedlabel.Name = "receivedlabel";
            this.receivedlabel.Size = new System.Drawing.Size(231, 13);
            this.receivedlabel.TabIndex = 89;
            this.receivedlabel.Text = "Have you received COVID-19 Vaccine?";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.panel4);
            this.panel3.Location = new System.Drawing.Point(5, 459);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(253, 114);
            this.panel3.TabIndex = 94;
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.panel5);
            this.panel4.Location = new System.Drawing.Point(0, 111);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(253, 46);
            this.panel4.TabIndex = 58;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(92, 3);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(415, 206);
            this.panel5.TabIndex = 63;
            // 
            // Generatebutton
            // 
            this.Generatebutton.Location = new System.Drawing.Point(207, 632);
            this.Generatebutton.Name = "Generatebutton";
            this.Generatebutton.Size = new System.Drawing.Size(106, 34);
            this.Generatebutton.TabIndex = 95;
            this.Generatebutton.Text = "Generate";
            this.Generatebutton.UseVisualStyleBackColor = true;
            this.Generatebutton.Click += new System.EventHandler(this.Generatebutton_Click);
            // 
            // QRCodeFillUp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(527, 725);
            this.Controls.Add(this.Generatebutton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.fullyvac);
            this.Controls.Add(this.firstdosevac);
            this.Controls.Add(this.NoVac);
            this.Controls.Add(this.receivedlabel);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.FirstName);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.Year);
            this.Controls.Add(this.Day);
            this.Controls.Add(this.Email);
            this.Controls.Add(this.emaillabel);
            this.Controls.Add(this.ContactNumber);
            this.Controls.Add(this.contactlabel);
            this.Controls.Add(this.MiddleName);
            this.Controls.Add(this.mnlabel);
            this.Controls.Add(this.LastName);
            this.Controls.Add(this.Address);
            this.Controls.Add(this.addresslabel);
            this.Controls.Add(this.Month);
            this.Controls.Add(this.bdaylabel);
            this.Controls.Add(this.Age);
            this.Controls.Add(this.agelabel);
            this.Controls.Add(this.lnlabel);
            this.Controls.Add(this.Fnlabel);
            this.Controls.Add(this.panel6);
            this.Controls.Add(this.label1);
            this.Name = "QRCodeFillUp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form6";
            this.Load += new System.EventHandler(this.QRCodeFillUp_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Year)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Day)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel4.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.RadioButton Othersbutton;
        public System.Windows.Forms.RadioButton FemaleButton;
        public System.Windows.Forms.RadioButton MaleButton;
        public System.Windows.Forms.Label genderlabel;
        private System.Windows.Forms.TextBox OtherTextBox;
        public System.Windows.Forms.TextBox FirstName;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        public System.Windows.Forms.NumericUpDown Year;
        public System.Windows.Forms.NumericUpDown Day;
        public System.Windows.Forms.TextBox Email;
        public System.Windows.Forms.Label emaillabel;
        public System.Windows.Forms.TextBox ContactNumber;
        public System.Windows.Forms.Label contactlabel;
        public System.Windows.Forms.TextBox MiddleName;
        public System.Windows.Forms.Label mnlabel;
        public System.Windows.Forms.TextBox LastName;
        public System.Windows.Forms.TextBox Address;
        public System.Windows.Forms.Label addresslabel;
        public System.Windows.Forms.DomainUpDown Month;
        public System.Windows.Forms.Label bdaylabel;
        public System.Windows.Forms.TextBox Age;
        public System.Windows.Forms.Label agelabel;
        public System.Windows.Forms.Label lnlabel;
        public System.Windows.Forms.Label Fnlabel;
        private System.Windows.Forms.Panel panel6;
        private System.Windows.Forms.Panel panel2;
        public System.Windows.Forms.RadioButton HasBooster;
        public System.Windows.Forms.RadioButton NoBooster;
        public System.Windows.Forms.Label boosterlabel;
        public System.Windows.Forms.RadioButton fullyvac;
        public System.Windows.Forms.RadioButton firstdosevac;
        public System.Windows.Forms.RadioButton NoVac;
        public System.Windows.Forms.Label receivedlabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Button Generatebutton;
    }
}