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
    public partial class Form1 : Form
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

        Form1 instance;
        public Form1()
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

            if(Month.Text == "April")
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
            StreamWriter outputfile = File.AppendText(@"C:\Users\Jc\Desktop\contact tracing\Contact Tracing.txt");
            outputfile.WriteLine("Name:" + " " + LastName.Text + "," + " " + FirstName.Text + " " + MiddleName.Text);
            outputfile.WriteLine( " " );
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
            outputfile.WriteLine("Received COVID-19 Vaccine Booster Shot?:" + " " + booster);
            outputfile.WriteLine(" ");
            outputfile.WriteLine("Experiencing COVID-19 symptoms?:" + " " + symptoms);
            outputfile.WriteLine(" ");

            if (NoSymptoms.Checked == false)
            {
                outputfile.WriteLine("Symptoms list:" + " " + coughh + " / " + feverr + " / " + sorethroatt + " / " + shortbreath + " / " + runnynosee + " / " + losssmelltaste + " / " + othersymp);
            }
            else
            {
                outputfile.WriteLine("") ;
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
                Address.Text= "";
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
                Othersymptext.Enabled = false;
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
                OtherTextBox.ReadOnly = false;
            }
            else
            {
                OtherTextBox.ReadOnly = true;
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
            Form2 form = new Form2();
            form.Show();
        }
    }
}
