using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace contact_tracing
{
    
    public partial class Firstpage : Form
    {
        string gender;
        string vaccinated;
        string booster;
        string symptoms;
        string coughh;
        string feverr;
        string sorethroatt;
        string shortbreath;
        string runnynosee;
        string losssmelltaste;
        string othersymp;
        

        public static Firstpage instance;

       
        public Firstpage()
        {
            InitializeComponent();
            instance = this;

        }



        private void label2_Click(object sender, EventArgs e)
        {

        }


        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {

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


        private void SubmitButton_Click(object sender, EventArgs e)
        {
            StreamWriter outputfile = File.AppendText(@"C:\Users\Jc\Desktop\contact tracing\ContactTracing.txt");
            outputfile.WriteLine("Date today:" + " " + date2day.Text);
            outputfile.WriteLine("");
            outputfile.WriteLine("Name:" + " " + LastName.Text + "," + " " + FirstName.Text + " " + MiddleName.Text);
            outputfile.WriteLine(" ");
            outputfile.WriteLine("Age:" + " " + Age.Text);
            outputfile.WriteLine(" ");
            outputfile.WriteLine("Birthday:" + " " + Month.Text + " " + Day.Text + "," + " " + Year.Text);
            outputfile.WriteLine(" ");
            outputfile.WriteLine("Gender:" + " " + gender);
            outputfile.WriteLine(" ");
            outputfile.WriteLine("Address:" + " " + Address.Text);
            outputfile.WriteLine(" ");
            outputfile.WriteLine("Contact number:" + " " + ContactNumber.Text);
            outputfile.WriteLine(" ");
            outputfile.WriteLine("Email:" + " " + Email.Text);
            outputfile.WriteLine(" ");
            outputfile.WriteLine("Received COVID-19 Vaccine?:" + " " + vaccinated);
            outputfile.WriteLine(" ");

            if (fullyvac.Checked == true)
            {
                outputfile.WriteLine("Received COVID-19 Vaccine Booster Shot?:" + " " + booster);
            }
            else
            {
                outputfile.WriteLine("Received COVID-19 Vaccine Booster Shot?:" + " " + "No");
            }

            outputfile.WriteLine(" ");
            outputfile.WriteLine("Experiencing COVID-19 symptoms?:" + " " + symptoms);
            outputfile.WriteLine(" ");

            if (NoSymptoms.Checked == false)
            {
                // +" " + coughh + " / " + feverr + " / " + sorethroatt + " / " + shortbreath + " / " + runnynosee + " / " + losssmelltaste + " / " + othersymp);
                outputfile.WriteLine(" ");
                outputfile.WriteLine("Symptoms list:");
                outputfile.WriteLine(coughh);
                outputfile.WriteLine(sorethroatt);
                outputfile.WriteLine(shortbreath);
                outputfile.WriteLine(runnynosee);
                outputfile.WriteLine(losssmelltaste);
                outputfile.WriteLine(othersymp);
            }
            else
            {
                outputfile.WriteLine("");
            }

            outputfile.WriteLine(" ");
            outputfile.WriteLine(" ------------------------------------------- ");
            outputfile.WriteLine(" ");

            outputfile.Close();

            if (MessageBox.Show("Submitted!") == DialogResult.OK)
            {
                FirstName.Text = "";
                MiddleName.Text = "";
                LastName.Text = "";
                Age.Text = "";
                Month.Text = "January";
                Day.Value = 1;
                Year.Value = 2000;
                MaleButton.Checked = false;
                FemaleButton.Checked = false;
                Othersbutton.Checked = false;
                Address.Text = "";
                ContactNumber.Text = "";
                Email.Text = "";
                NoVac.Checked = false;
                firstdosevac.Checked = false;
                fullyvac.Checked = false;
                NoBooster.Checked = false;
                HasBooster.Checked = false;
                NoSymptoms.Checked = false;
                HasSymptoms.Checked = false;


            }
        }

        private void FemaleButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
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

        private void NoSymptoms_CheckedChanged(object sender, EventArgs e)
        {
            symptoms = "No";
        }

        private void HasSymptoms_CheckedChanged(object sender, EventArgs e)
        {
            symptoms = "Yes";

            if (HasSymptoms.Checked == true)
            {
                cough.Enabled = true;
                fever.Enabled = true;
                sorethroat.Enabled = true;
                shortnessofbreath.Enabled = true;
                runnynose.Enabled = true;
                lossofsmellortaste.Enabled = true;
                Othersymptext.Enabled = true;
                ifyes.ForeColor = Color.Black;
                otherslabel.ForeColor = Color.Black;

            }
            else
            {
                cough.Enabled = false;
                fever.Enabled = false;
                sorethroat.Enabled = false;
                shortnessofbreath.Enabled = false;
                runnynose.Enabled = false;
                lossofsmellortaste.Enabled = false;
                Othersymptext.Enabled = false;
                Othersymptext.Text = " ";
                cough.Checked = false;
                fever.Checked = false;
                sorethroat.Checked = false;
                shortnessofbreath.Checked = false;
                runnynose.Checked = false;
                lossofsmellortaste.Checked = false;
                ifyes.ForeColor = Color.Gray;
                otherslabel.ForeColor = Color.Gray;
            }
        }

        private void cough_CheckedChanged(object sender, EventArgs e)
        {
            coughh = "Cough";
        }

        private void fever_CheckedChanged(object sender, EventArgs e)
        {
            feverr = "Fever";
        }

        private void sorethroat_CheckedChanged(object sender, EventArgs e)
        {
            sorethroatt = "Sore throat";
        }

        private void shortnessofbreath_CheckedChanged(object sender, EventArgs e)
        {
            shortbreath = "Shortness of breath";
        }

        private void runnynose_CheckedChanged(object sender, EventArgs e)
        {
            runnynosee = "Runny nose";
        }

        private void lossofsmellortaste_CheckedChanged(object sender, EventArgs e)
        {
            losssmelltaste = "Loss of smell or taste";
        }


        private void OtherTextBox_TextChanged(object sender, EventArgs e)
        {
            gender = OtherTextBox.Text;
        }


        private void radioButton1_CheckedChanged_1(object sender, EventArgs e)
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


        private void Othersymptext_TextChanged(object sender, EventArgs e)
        {
            othersymp = Othersymptext.Text;
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel7_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Year_ValueChanged(object sender, EventArgs e)
        {


        }

        private void Day_ValueChanged(object sender, EventArgs e)
        {

        }

        private void InfoButton_Click(object sender, EventArgs e)
        {
            secondpage form = new secondpage();
            form.Show();
        }

        private void Info_Click(object sender, EventArgs e)
        {

            thirdpage form = new thirdpage();
            form.Show();
            this.Hide();

        }


        private void logout_Click(object sender, EventArgs e)
        {
            Info.Visible = false;
            logout.Visible = false;
            date2day.Enabled = false;
            AdminButton.Visible = true;
            FirstName.Text = "";
            FirstName.Enabled = true;
            MiddleName.Text = "";
            MiddleName.Enabled = true;
            LastName.Text = "";
            LastName.Enabled = true;
            Age.Text = "";
            Age.Enabled = true;
            Month.Text = "January";
            Month.Enabled = true;
            Day.Value = 1;
            Day.Enabled = true;
            Year.Value = 2000;
            Year.Enabled = true;
            MaleButton.Checked = false;
            MaleButton.Enabled = true;
            FemaleButton.Checked = false;
            FemaleButton.Enabled = true;
            Othersbutton.Checked = false;
            Othersbutton.Enabled = true;
            Address.Text = "";
            Address.Enabled = true;
            ContactNumber.Text = "";
            ContactNumber.Enabled = true;
            Email.Text = "";
            Email.Enabled = true;
            NoVac.Checked = false;
            NoVac.Enabled = true;
            firstdosevac.Checked = false;
            firstdosevac.Enabled = true;
            fullyvac.Checked = false;
            fullyvac.Enabled = true;
            NoBooster.Checked = false;
            NoBooster.Enabled = false;
            HasBooster.Checked = false;
            HasBooster.Enabled = false;
            NoSymptoms.Checked = false;
            NoSymptoms.Enabled = true;
            HasSymptoms.Checked = false;
            HasSymptoms.Enabled = true;
            SubmitButton.Enabled = true;
            Fnlabel.Enabled = true;
            mnlabel.Enabled = true;
            lnlabel.Enabled = true;
            agelabel.Enabled = true;
            bdaylabel.Enabled = true;
            genderlabel.Enabled = true;
            addresslabel.Enabled = true;
            emaillabel.Enabled = true;
            contactlabel.Enabled = true;
            receivedlabel.Enabled = true;
            boosterlabel.Enabled = true;
            symplabel.Enabled = true;
        }
    }
}
