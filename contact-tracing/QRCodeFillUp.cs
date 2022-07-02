using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using QRCoder;
using System.IO;


namespace contact_tracing
{
    public partial class QRCodeFillUp : Form
    {

        string gender;
        string vaccinated;
        string booster;

        public static QRCodeFillUp instance;
        public QRCodeFillUp()
        {
            InitializeComponent();
            instance = this;
        }

        private void QRCodeFillUp_Load(object sender, EventArgs e)
        {

        }

        private void Generatebutton_Click(object sender, EventArgs e)
        {
            if (fullyvac.Checked == true)
            {
                var qrinfoo = LastName.Text + "\n" + FirstName.Text + "\n" + MiddleName.Text + "\n"
                          + Age.Text + "\n" + Month.Text + "\n" + Day.Value + "\n" + Year.Value + "\n" +
                          gender + "\n" + Address.Text + "\n" + ContactNumber.Text + "\n" + Email.Text + "\n" +
                          vaccinated + "\n" + booster;

                QRGeneratepage form = new QRGeneratepage();
                form.Show();
                this.Hide();

                QRCodeGenerator qrpic = new QRCodeGenerator();
                QRCodeData info = qrpic.CreateQrCode(qrinfoo, QRCodeGenerator.ECCLevel.Q);
                QRCode qr = new QRCode(info);
                QRGeneratepage.instance.qrpic.Image = qr.GetGraphic(5);
            }
            else
            {
                var qrinfoo = LastName.Text + "\n" + FirstName.Text + "\n" + MiddleName.Text + "\n"
                          + Age.Text + "\n" + Month.Text + "\n" + Day.Value + "\n" + Year.Value + "\n" +
                          gender + "\n" + Address.Text + "\n" + ContactNumber.Text + "\n" + Email.Text + "\n" +
                          vaccinated + "\n" + "No" ;

                QRGeneratepage form = new QRGeneratepage();
                form.Show();
                this.Hide();

                QRCodeGenerator qrpic = new QRCodeGenerator();
                QRCodeData info = qrpic.CreateQrCode(qrinfoo, QRCodeGenerator.ECCLevel.Q);
                QRCode qr = new QRCode(info);
                QRGeneratepage.instance.qrpic.Image = qr.GetGraphic(8);
            }


        }

        private void MaleButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void FemaleButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void OtherTextBox_TextChanged(object sender, EventArgs e)
        {
            gender = OtherTextBox.Text;
        }

        private void Othersbutton_CheckedChanged(object sender, EventArgs e)
        {
            if (Othersbutton.Checked == true)
            {
                OtherTextBox.Enabled = true;
            }
            else
            {
                OtherTextBox.Enabled = false;
                OtherTextBox.Text = " ";
            }
        }

        private void Month_SelectedItemChanged(object sender, EventArgs e)
        {
            if (Month.Text == "January")
            {
                Day.Minimum = 1;
                Day.Maximum = 31;
            }


            if (Month.Text == "February")
            {
                Day.Minimum = 1;
                Day.Maximum = 29;
            }


            if (Month.Text == "March")
            {
                Day.Minimum = 1;
                Day.Maximum = 31;
            }

            if (Month.Text == "April")
            {
                Day.Minimum = 1;
                Day.Maximum = 30;
            }

            if (Month.Text == "May")
            {
                Day.Minimum = 1;
                Day.Maximum = 31;
            }

            if (Month.Text == "June")
            {
                Day.Minimum = 1;
                Day.Maximum = 30;
            }

            if (Month.Text == "July")
            {
                Day.Minimum = 1;
                Day.Maximum = 31;
            }

            if (Month.Text == "August")
            {
                Day.Minimum = 1;
                Day.Maximum = 31;
            }

            if (Month.Text == "September")
            {
                Day.Minimum = 1;
                Day.Maximum = 30;
            }

            if (Month.Text == "October")
            {
                Day.Minimum = 1;
                Day.Maximum = 31;
            }

            if (Month.Text == "November")
            {
                Day.Minimum = 1;
                Day.Maximum = 30;
            }

            if (Month.Text == "December")
            {
                Day.Minimum = 1;
                Day.Maximum = 31;
            }
        }

        private void NoVac_CheckedChanged(object sender, EventArgs e)
        {
            vaccinated = "No";
        }

        private void firstdosevac_CheckedChanged(object sender, EventArgs e)
        {
            vaccinated = "Yes, 1st Dose only";
        }

        private void fullyvac_CheckedChanged(object sender, EventArgs e)
        {
            vaccinated = "Yes, Fully Vaccinated (1st and 2nd Dose)";

            if (fullyvac.Checked == true)
            {
                NoBooster.Enabled = true;
                HasBooster.Enabled = true;
                boosterlabel.ForeColor = Color.Black;
            }
            else
            {
                NoBooster.Enabled = false;
                HasBooster.Enabled = false;
                boosterlabel.ForeColor = Color.Gray;
                NoBooster.Checked = false;
                HasBooster.Checked = false;
            }
        }

        private void NoBooster_CheckedChanged(object sender, EventArgs e)
        {
            booster = "No";
        }

        private void HasBooster_CheckedChanged(object sender, EventArgs e)
        {
            booster = "Yes";
        }

        private void Backbtn_Click(object sender, EventArgs e)
        {
            Firstpage form = new Firstpage();
            form.Show();
            this.Close();
        }
    }
}
