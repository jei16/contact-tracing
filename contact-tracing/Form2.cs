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
                Firstpage.instance.date2day.Enabled = true;
                Firstpage.instance.AdminButton.Visible = false;
                Firstpage.instance.FirstName.Text = "";
                Firstpage.instance.FirstName.Enabled = false;
                Firstpage.instance.MiddleName.Text = "";
                Firstpage.instance.MiddleName.Enabled = false;
                Firstpage.instance.LastName.Text = "";
                Firstpage.instance.LastName.Enabled = false;
                Firstpage.instance.Age.Text = "";
                Firstpage.instance.Age.Enabled = false;
                Firstpage.instance.Month.Text = "January";
                Firstpage.instance.Month.Enabled = false;
                Firstpage.instance.Day.Value = 1;
                Firstpage.instance.Day.Enabled = false;
                Firstpage.instance.Year.Value = 2000;
                Firstpage.instance.Year.Enabled = false;
                Firstpage.instance.MaleButton.Checked = false;
                Firstpage.instance.MaleButton.Enabled = false;
                Firstpage.instance.FemaleButton.Checked = false;
                Firstpage.instance.FemaleButton.Enabled = false;
                Firstpage.instance.Othersbutton.Checked = false;
                Firstpage.instance.Othersbutton.Enabled = false;
                Firstpage.instance.Address.Text = "";
                Firstpage.instance.Address.Enabled = false;
                Firstpage.instance.ContactNumber.Text = "";
                Firstpage.instance.ContactNumber.Enabled = false;
                Firstpage.instance.Email.Text = "";
                Firstpage.instance.Email.Enabled = false;
                Firstpage.instance.NoVac.Checked = false;
                Firstpage.instance.NoVac.Enabled = false;
                Firstpage.instance.firstdosevac.Checked = false;
                Firstpage.instance.firstdosevac.Enabled = false;
                Firstpage.instance.fullyvac.Checked = false;
                Firstpage.instance.fullyvac.Enabled = false;
                Firstpage.instance.NoBooster.Checked = false;
                Firstpage.instance.NoBooster.Enabled = false;
                Firstpage.instance.HasBooster.Checked = false;
                Firstpage.instance.HasBooster.Enabled = false;
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



                if (MessageBox.Show("Correct!") == DialogResult.OK)
                {
                    
                }

            }
            else
            {
                MessageBox.Show("Wrong Password");
            }
        }
    }
}
