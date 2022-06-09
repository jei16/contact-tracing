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
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Male";
        }

        private void domainUpDown1_SelectedItemChanged(object sender, EventArgs e)
        {

        }

        private void radioButton9_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void FirstName_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Month_SelectedItemChanged(object sender, EventArgs e)
        {

        }


        private void SubmitButton_Click(object sender, EventArgs e)
        {
            StreamWriter file = File.AppendText(@"C:\Users\Jc\Desktop\contact tracing\test.txt");
            file.WriteLine("First Name:"+" "+FirstName.Text);
            file.WriteLine("Middle Name:" + " " + MiddleName.Text);
            file.WriteLine("Last Name:" + " " + LastName.Text);
            file.WriteLine("Age:" + " " + Age.Text);
            file.WriteLine("Birthday:" + " " + Month.Text + " " + Day.Text + "," + " " + Year.Text);
            file.WriteLine("Gender:" + " " + gender);
            file.WriteLine("Address:" + " " + Address.Text);
            file.WriteLine("Contact number:" + " " + ContactNumber.Text);
            file.WriteLine("Email:" + " " + Email.Text);
            file.WriteLine("Received COVID-19 Vaccine?:" + " " + vaccinated);
            file.WriteLine("Received COVID-19 Vaccine Booster Shot?:" + " " + booster);






            file.Close();

            MessageBox.Show("Submitted!");
        }

        private void FemaleButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = "Female";
        }

        private void OtherButton_CheckedChanged(object sender, EventArgs e)
        {
            gender = Other.Text;
     
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
    }
}
