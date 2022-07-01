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

namespace contact_tracing
{
    public partial class QRGeneratepage : Form
    {
        public static QRGeneratepage instance;
        public QRGeneratepage()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form5_Load(object sender, EventArgs e)
        {

        }


        private void GenerateAgain_Click(object sender, EventArgs e)
        {
            QRCodeFillUp form = new QRCodeFillUp();
            form.Show();
            this.Close();

            QRCodeFillUp.instance.FirstName.Clear();
            QRCodeFillUp.instance.MiddleName.Clear();
            QRCodeFillUp.instance.LastName.Clear();
            QRCodeFillUp.instance.Age.Clear();
            QRCodeFillUp.instance.Month.Text = "January";
            QRCodeFillUp.instance.Day.Value = 1;
            QRCodeFillUp.instance.Year.Value = 2000;
            QRCodeFillUp.instance.MaleButton.Checked = false;
            QRCodeFillUp.instance.FemaleButton.Checked = false;
            QRCodeFillUp.instance.Othersbutton.Checked = false;
            QRCodeFillUp.instance.Address.Clear();
            QRCodeFillUp.instance.ContactNumber.Clear();
            QRCodeFillUp.instance.Email.Clear();
            QRCodeFillUp.instance.NoVac.Checked = false;
            QRCodeFillUp.instance.firstdosevac.Checked = false;
            QRCodeFillUp.instance.fullyvac.Checked = false;
        }

        private void Downloadbtn_Click(object sender, EventArgs e)
        {
            qrpic.Image.Save(@"C:\Users\Jc\Desktop\contact tracing\qrcodes\" + QRCodeFillUp.instance.LastName.Text + "," + " " + QRCodeFillUp.instance.FirstName.Text + " " + QRCodeFillUp.instance.MiddleName.Text + ".jpg");

            MessageBox.Show("Downloaded!");
        }
    }
}

