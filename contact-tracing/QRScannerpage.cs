using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;
using ZXing;

namespace contact_tracing
{
    public partial class QRScannerpage : Form
    {
        public static QRScannerpage instance;
        public QRScannerpage()
        {
            InitializeComponent();
            instance = this;
        }

        FilterInfoCollection infoCollection;
        VideoCaptureDevice device;

        private void QRScannerpage_Load(object sender, EventArgs e)
        {
            infoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            foreach(FilterInfo filter in infoCollection)    
                QRCombobox.Items.Add(filter.Name);
            QRCombobox.SelectedIndex = 0;

            device = new VideoCaptureDevice(infoCollection[QRCombobox.SelectedIndex].MonikerString);
            device.NewFrame += Device_NewFrame;
            device.Start();
            QRScanTimer.Start();

        }

        private void Scanbutton_Click(object sender, EventArgs e)
        {


        }



        private void Device_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            QRScannerpic.Image=(Bitmap)eventArgs.Frame.Clone();
        }

        private void QRScannerpage_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (device.IsRunning)
                device.Stop();
        }

        private void QRScanTimer_Tick(object sender, EventArgs e)
        {
            if (QRScannerpic.Image != null)
            {
                BarcodeReader barcode = new BarcodeReader();
                Result result = barcode.Decode((Bitmap)QRScannerpic.Image);
                if (result != null)
                { 
                    result.ToString();
                    string[] array = result.ToString().Split(new char[] {'\n'});
                    if (array.Length > 0)
                    {
                        Firstpage.instance.LastName.Text = array[0];
                        Firstpage.instance.FirstName.Text = array[1];
                        Firstpage.instance.MiddleName.Text = array[2];
                        Firstpage.instance.Age.Text = array[3];
                        Firstpage.instance.Month.Text = array[4];
                        Firstpage.instance.Day.Text = array[5];
                        Firstpage.instance.Year.Text = array[6];
                        Firstpage.instance.Gender.Text = array[7];
                        Firstpage.instance.Address.Text = array[8];
                        Firstpage.instance.ContactNumber.Text = array[9];
                        Firstpage.instance.Email.Text = array[10];
                        Firstpage.instance.Vaccinated.Text = array[11];
                        Firstpage.instance.Booster.Text = array[12];

                        //12
                    }
                    QRScanTimer.Stop();
                    if (device.IsRunning)
                        device.Stop();
                    this.Close();
                    Firstpage.instance.SubmitButton.Visible = true;
                    Firstpage.instance.Pls.Visible = true;
                    Firstpage.instance.Plspanel.BackColor = Color.AliceBlue;
                }
                
            }

            
        }
    }
}
