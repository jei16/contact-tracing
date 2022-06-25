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
    public partial class fourthpage : Form
    {
        public static fourthpage instance;
        public fourthpage()
        {
            InitializeComponent();
            instance = this;
        }

        private void fourthpage_Load(object sender, EventArgs e)
        {

        }

        private void Back2_Click(object sender, EventArgs e)
        {
            thirdpage.instance.Show();
            this.Close();
        }

        private void showinfo1_Click(object sender, EventArgs e)
        {
            StreamReader reader;
            reader = File.OpenText(@"C:\Users\Jc\Desktop\contact tracing\name\" + LastName.Text + "," + " " + FirstName.Text + " " + MiddleName.Text + ".txt");
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

        private void showinfo2_Click(object sender, EventArgs e)
        {
            StreamReader reader;
            reader = File.OpenText(@"C:\Users\Jc\Desktop\contact tracing\name\" + LastName.Text + "," + " " + FirstName.Text + " " + MiddleName.Text + ".txt");
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
}
