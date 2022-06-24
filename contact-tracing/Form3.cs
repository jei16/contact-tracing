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
            StreamReader reader;
            reader = File.OpenText(@"C:\Users\Jc\Desktop\contact tracing\ContactTracing.txt");
            {

                while (!reader.EndOfStream)
                {
                    Infoss.Items.Add(reader.ReadLine());
                }
            }
           reader.Close(); 


        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
