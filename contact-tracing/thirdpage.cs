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
    public partial class thirdpage : Form
    {
        public static thirdpage instance;
        public thirdpage()
        {
            InitializeComponent();
            instance = this;
        }

        private void thirdpage_Load(object sender, EventArgs e)
        {

        }

        private void Back_Click(object sender, EventArgs e)
        {
            Firstpage.instance.Show();
            this.Close();
        }

        private void showinfo_Click(object sender, EventArgs e)
            
        {
            try
            {
                StreamReader reader;
                reader = File.OpenText(@"C:\Users\Jc\Desktop\contact tracing\date2day\" + Month2day.Text + " " + Day2day.Text + " " + Year2day.Text + ".txt");
                {

                    while (!reader.EndOfStream)
                    {
                        Infoss24.Items.Add(reader.ReadLine());
                        Infoss24.Visible = true;
                        showinfo2.Visible = false;
                        showinfo1.Visible = true;
                        Infoss23.Items.Clear();
                        Infoss23.Visible = false;
                    }
                }

                reader.Close();
            }
            catch
            {
                StreamReader reader;
                reader = File.OpenText(@"C:\Users\Jc\Desktop\contact tracing\date2day\None.txt");
                {

                    while (!reader.EndOfStream)
                    {
                        Infoss24.Items.Add(reader.ReadLine());
                        Infoss24.Visible = true;
                        showinfo2.Visible = false;
                        showinfo1.Visible = true;
                        Infoss23.Items.Clear();
                        Infoss23.Visible = false;
                    }
                }

                reader.Close();
            }
        }

       

        private void showinfo1_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader reader;
                reader = File.OpenText(@"C:\Users\Jc\Desktop\contact tracing\date2day\" + Month2day.Text + " " + Day2day.Text + " " + Year2day.Text + ".txt");
                {

                    while (!reader.EndOfStream)
                    {
                        Infoss23.Items.Add(reader.ReadLine());
                        Infoss23.Visible = true;
                        showinfo2.Visible = true;
                        showinfo1.Visible = false;
                        Infoss24.Items.Clear();
                        Infoss24.Visible = false;
                    }
                }

                reader.Close();
            }
            catch
            {
                StreamReader reader;
                reader = File.OpenText(@"C:\Users\Jc\Desktop\contact tracing\date2day\None.txt");
                {

                    while (!reader.EndOfStream)
                    {
                        Infoss23.Items.Add(reader.ReadLine());
                        Infoss23.Visible = true;
                        showinfo2.Visible = true;
                        showinfo1.Visible = false;
                        Infoss24.Items.Clear();
                        Infoss24.Visible = false;
                    }
                }

                reader.Close();
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void label16_Click(object sender, EventArgs e)
        {

        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
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

        private void Day2day_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Year2day_ValueChanged(object sender, EventArgs e)
        {

        }

        private void Infoss24_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Infoss23_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void next1_Click(object sender, EventArgs e)
        {
            fourthpage form = new fourthpage();
            form.Show();
            this.Hide();
        }
    }
}
