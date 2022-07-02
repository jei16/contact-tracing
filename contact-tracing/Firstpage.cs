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

        

        private void FirstName_TextChanged(object sender, EventArgs e)
        {

        }

        
        private void SubmitButton_Click(object sender, EventArgs e)
        {
            {
                StreamWriter outputfile = File.AppendText(@"C:\Users\Jc\Desktop\contact tracing\date2day\" + Month2day.Text + " " + Day2day.Text + " " + Year2day.Text + ".txt" );
                outputfile.WriteLine("Date today:" + " " + Month2day.Text + " " + Day2day.Text + " " + Year2day.Text);
                outputfile.WriteLine("");
                outputfile.WriteLine("Name:" + " " + LastName.Text + "," + " " + FirstName.Text + " " + MiddleName.Text);
                outputfile.WriteLine(" ");
                outputfile.WriteLine("Age:" + " " + Age.Text);
                outputfile.WriteLine(" ");
                outputfile.WriteLine("Birthday:" + " " + Month.Text + " " + Day.Text + "," + " " + Year.Text);
                outputfile.WriteLine(" ");
                outputfile.WriteLine("Gender:" + " " + Gender.Text);
                outputfile.WriteLine(" ");
                outputfile.WriteLine("Address:" + " " + Address.Text);
                outputfile.WriteLine(" ");
                outputfile.WriteLine("Contact number:" + " " + ContactNumber.Text);
                outputfile.WriteLine(" ");
                outputfile.WriteLine("Email:" + " " + Email.Text);
                outputfile.WriteLine(" ");
                outputfile.WriteLine("Received COVID-19 Vaccine?:" + " " + Vaccinated.Text);
                outputfile.WriteLine(" ");
                 outputfile.WriteLine("Received COVID-19 Vaccine Booster Shot?:" + " " + Booster.Text);

                outputfile.WriteLine(" ");
                outputfile.WriteLine("Experiencing COVID-19 symptoms?:" + " " + symptoms);
                outputfile.WriteLine(" ");

                if (NoSymptoms.Checked == false)
                {

                    outputfile.WriteLine("Symptoms list:");
                    if (cough.Checked == true)
                    {
                        outputfile.WriteLine(coughh);
                    }


                    if (fever.Checked == true)
                    {
                        outputfile.WriteLine(feverr);
                    }


                    if (sorethroat.Checked == true)
                    {
                        outputfile.WriteLine(sorethroatt);
                    }


                    if (shortnessofbreath.Checked == true)
                    {
                        outputfile.WriteLine(shortbreath);
                    }


                    if (runnynose.Checked == true)
                    {
                        outputfile.WriteLine(runnynosee);
                    }


                    if (lossofsmellortaste.Checked == true)
                    {
                        outputfile.WriteLine(losssmelltaste);
                    }


                    outputfile.WriteLine(othersymp);
                }
                else
                {
                    outputfile.WriteLine("");
                }

                outputfile.WriteLine(" ");
                outputfile.WriteLine(" --------------------------------------------------------------------------------------------------------------------------------------------- ");
                outputfile.WriteLine(" ");

                outputfile.Close();
            }
            
            {
                StreamWriter outputfile = File.AppendText(@"C:\Users\Jc\Desktop\contact tracing\name\" + LastName.Text + "," + " " + FirstName.Text + " " + MiddleName.Text + ".txt");
                outputfile.WriteLine("Date today:" + " " + Month2day.Text + " " + Day2day.Text + " " + Year2day.Text);
                outputfile.WriteLine("");
                outputfile.WriteLine("Name:" + " " + LastName.Text + "," + " " + FirstName.Text + " " + MiddleName.Text);
                outputfile.WriteLine(" ");
                outputfile.WriteLine("Age:" + " " + Age.Text);
                outputfile.WriteLine(" ");
                outputfile.WriteLine("Birthday:" + " " + Month.Text + " " + Day.Text + "," + " " + Year.Text);
                outputfile.WriteLine(" ");
                outputfile.WriteLine("Gender:" + " " + Gender.Text);
                outputfile.WriteLine(" ");
                outputfile.WriteLine("Address:" + " " + Address.Text);
                outputfile.WriteLine(" ");
                outputfile.WriteLine("Contact number:" + " " + ContactNumber.Text);
                outputfile.WriteLine(" ");
                outputfile.WriteLine("Email:" + " " + Email.Text);
                outputfile.WriteLine(" ");
                outputfile.WriteLine("Received COVID-19 Vaccine?:" + " " + Vaccinated.Text);
                outputfile.WriteLine(" ");
                outputfile.WriteLine("Received COVID-19 Vaccine Booster Shot?:" + " " + Booster.Text);

                outputfile.WriteLine(" ");
                outputfile.WriteLine("Experiencing COVID-19 symptoms?:" + " " + symptoms);
                outputfile.WriteLine(" ");

                if (NoSymptoms.Checked == false)
                {

                    outputfile.WriteLine("Symptoms list:");

                    if (cough.Checked == true)
                    {
                        outputfile.WriteLine(coughh);
                    }
                   

                    if (fever.Checked == true)
                    {
                        outputfile.WriteLine(feverr);
                    }
                   
                
                    if (sorethroat.Checked == true)
                    {
                        outputfile.WriteLine(sorethroatt);
                    }
                    

                    if (shortnessofbreath.Checked == true)
                    {
                        outputfile.WriteLine(shortbreath);
                    }
                    

                    if (runnynose.Checked == true)
                    {
                        outputfile.WriteLine(runnynosee);
                    }
                   

                    if (lossofsmellortaste.Checked == true)
                    {
                        outputfile.WriteLine(losssmelltaste);
                    }
                   

                    outputfile.WriteLine(othersymp);
                }
                else
                {
                    outputfile.WriteLine("");
                }

                outputfile.WriteLine(" ");
                outputfile.WriteLine(" --------------------------------------------------------------------------------------------------------------------------------------------- ");
                outputfile.WriteLine(" ");

                outputfile.Close();
            }
            
            if (MessageBox.Show("Submitted!") == DialogResult.OK)
            {
                FirstName.Text = "";
                MiddleName.Text = "";
                LastName.Text = "";
                Age.Text = "";
                Month.Text = "";
                Address.Text = "";
                ContactNumber.Text = "";
                Email.Text = "";
                Gender.Text = "";
                Vaccinated.Text = "";
                Booster.Text = "";
                SubmitButton.Visible = false;
                Pls.Visible = false;
                Plspanel.BackColor = Color.White;
                NoSymptoms.Checked = false;
                HasSymptoms.Checked = false;

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
            Month2day.Enabled = false;
            Day2day.Enabled = false;
            Year2day.Enabled = false;
            AdminButton.Visible = true;
            FirstName.Text = "";
            FirstName.Enabled = true;
            MiddleName.Text = "";
            MiddleName.Enabled = true;
            LastName.Text = "";
            LastName.Enabled = true;
            Age.Text = "";
            Age.Enabled = true;
            Month.Text = "";
            Month.Enabled = true;
            Day.Text = "";
            Day.Enabled = true;
            Year.Text = "";
            Year.Enabled = true;
            Address.Text = "";
            Address.Enabled = true;
            ContactNumber.Text = "";
            ContactNumber.Enabled = true;
            Email.Text = "";
            Email.Enabled = true;
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
           scanbtn.Enabled = true;
           Registerbutton.Enabled = true;
           Gender.Text = "";
           Gender.Enabled = true;
            Vaccinated.Text = "";
            Vaccinated.Enabled = true;
           Booster.Text = "";
            Booster.Enabled = true;
        }

       

        private void Date2day_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Month2day_SelectedItemChanged(object sender, EventArgs e)
        {
            if (Month2day.Text == "January")
            {
                Day2day.Minimum = 1;
                Day2day.Maximum = 31;
            }


            if (Month2day.Text == "February")
            {
                Day2day.Minimum = 1;
                Day2day.Maximum = 29;
            }


            if (Month2day.Text == "March")
            {
                Day2day.Minimum = 1;
                Day2day.Maximum = 31;
            }

            if (Month2day.Text == "April")
            {
                Day2day.Minimum = 1;
                Day2day.Maximum = 30;
            }

            if (Month2day.Text == "May")
            {
                Day2day.Minimum = 1;
                Day2day.Maximum = 31;
            }

            if (Month2day.Text == "June")
            {
                Day2day.Minimum = 1;
                Day2day.Maximum = 30;
            }

            if (Month2day.Text == "July")
            {
                Day2day.Minimum = 1;
                Day2day.Maximum = 31;
            }

            if (Month2day.Text == "August")
            {
                Day2day.Minimum = 1;
                Day2day.Maximum = 31;
            }

            if (Month2day.Text == "September")
            {
                Day2day.Minimum = 1;
                Day2day.Maximum = 30;
            }

            if (Month2day.Text == "October")
            {
                Day2day.Minimum = 1;
                Day2day.Maximum = 31;
            }

            if (Month2day.Text == "November")
            {
                Day2day.Minimum = 1;
                Day2day.Maximum = 30;
            }

            if (Month2day.Text == "December")
            {
                Day2day.Minimum = 1;
                Day2day.Maximum = 31;
            }
        }

        private void scanbtn_Click(object sender, EventArgs e)
        {
            QRScannerpage form = new QRScannerpage();
            form.Show();
            
        }

        private void Registerbutton_Click(object sender, EventArgs e)
        {
            QRCodeFillUp form = new QRCodeFillUp();
            form.Show();
            this.Hide();
        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

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

        private void NoSymptoms_CheckedChanged(object sender, EventArgs e)
        {
            symptoms = "No";
        }

        private void receivedlabel_Click(object sender, EventArgs e)
        {

        }
    }
}
