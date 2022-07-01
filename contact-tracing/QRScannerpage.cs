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
                  Firstpage.instance.FirstName.Text = result.ToString();
                    QRScanTimer.Stop();
                    if (device.IsRunning)
                        device.Stop();
                   /*Firstpage form = new Firstpage();
                    form.Show();
                    this.Hide();*/
                }
                
            }

            
        }
    }
}
