using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace contact_tracing
{
    public partial class secondpage : Form
    {
        public static secondpage instance;
        public secondpage()
        {
            InitializeComponent();
            instance = this;
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void submitadmin_Click(object sender, EventArgs e)
        {
            if (magicword.Text == "imissyou")
            {
                Firstpage.instance.Info.Visible = true;
                Firstpage.instance.logout.Visible = true;
                Firstpage.instance.Month2day.Enabled = true;
                Firstpage.instance.Day2day.Enabled = true;
                Firstpage.instance.Year2day.Enabled = true;
                Firstpage.instance.AdminButton.Visible = false;
                Firstpage.instance.FirstName.Text = "";
                Firstpage.instance.FirstName.Enabled = false;
                Firstpage.instance.MiddleName.Text = "";
                Firstpage.instance.MiddleName.Enabled = false;
                Firstpage.instance.LastName.Text = "";
                Firstpage.instance.LastName.Enabled = false;
                Firstpage.instance.Age.Text = "";
                Firstpage.instance.Age.Enabled = false;
                Firstpage.instance.Month.Text = "";
                Firstpage.instance.Month.Enabled = false;
                Firstpage.instance.Day.Text = "";
                Firstpage.instance.Day.Enabled = false;
                Firstpage.instance.Year.Text = "";
                Firstpage.instance.Year.Enabled = false;
                Firstpage.instance.Gender.Text = "";
                Firstpage.instance.Gender.Enabled = false;
                Firstpage.instance.Address.Text = "";
                Firstpage.instance.Address.Enabled = false;
                Firstpage.instance.ContactNumber.Text = "";
                Firstpage.instance.ContactNumber.Enabled = false;
                Firstpage.instance.Email.Text = "";
                Firstpage.instance.Email.Enabled = false;
                Firstpage.instance.Vaccinated.Text = "";
                Firstpage.instance.Vaccinated.Enabled = false;
                Firstpage.instance.Booster.Text = "";
                Firstpage.instance.Booster.Enabled = false;
                Firstpage.instance.NoSymptoms.Checked = false;
                Firstpage.instance.NoSymptoms.Enabled = false;
                Firstpage.instance.HasSymptoms.Checked = false;
                Firstpage.instance.HasSymptoms.Enabled = false;
                Firstpage.instance.SubmitButton.Enabled = false;
                Firstpage.instance.Fnlabel.Enabled = false;
                Firstpage.instance.mnlabel.Enabled = false;
                Firstpage.instance.lnlabel.Enabled = false;
                Firstpage.instance.agelabel.Enabled = false;
                Firstpage.instance.bdaylabel.Enabled = false;
                Firstpage.instance.genderlabel.Enabled = false;
                Firstpage.instance.addresslabel.Enabled = false;
                Firstpage.instance.emaillabel.Enabled = false;
                Firstpage.instance.contactlabel.Enabled = false;
                Firstpage.instance.receivedlabel.Enabled = false;
                Firstpage.instance.boosterlabel.Enabled = false;
                Firstpage.instance.symplabel.Enabled = false;
                Firstpage.instance.scanbtn.Enabled = false;
                Firstpage.instance.Registerbutton.Enabled = false;





                if (MessageBox.Show("Correct!") == DialogResult.OK)
                {
                   this.Close();
                }

            }
            else
            {
                MessageBox.Show("Incorrect!");
            }
        }
    }
}
