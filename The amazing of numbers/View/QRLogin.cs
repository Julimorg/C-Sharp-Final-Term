using AForge.Video;
using AForge.Video.DirectShow;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using System.Windows.Media;
using The_amazing_of_numbers.Controller;
using ZXing;

namespace The_amazing_of_numbers
{
    public partial class QRLogin : Form
    {
        Login cur_form = null;
        public QRLogin(Login cur_form)
        {
            InitializeComponent();
            this.Opacity = 1;
            this.cur_form = cur_form;
        }
        FilterInfoCollection filterInfoCollection;
        VideoCaptureDevice captureDevice;

        private void QRLogin_Load(object sender, EventArgs e)
        {
            filterInfoCollection = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            
            foreach (FilterInfo filter in filterInfoCollection)
            {
                cboDevice.Items.Add(filter.Name);
            }
            if (cboDevice.Items.Count == 0)
            {
                string message = "Cannot find your camera";
                string title = "Notice";
                MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
                DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
                if (result == DialogResult.OK) //Reset password in DB
                {
                    this.Close();
                }
                else
                {
                    // Do something
                }
            }
            else
            {
                cboDevice.SelectedIndex = 0;
            }   
        }

        private void ScanBtn_Click(object sender, EventArgs e)
        {
            pictureBox.Visible = true;
            pictureBox.Enabled = true;
            captureDevice = new VideoCaptureDevice(filterInfoCollection[cboDevice.SelectedIndex].MonikerString);
         
            captureDevice.NewFrame += CaptureDevice_NewFrame;
            captureDevice.Start();
            timer1.Start();
        }

        private void CaptureDevice_NewFrame(object sender, NewFrameEventArgs eventArgs)
        {
            pictureBox.Image = (Bitmap)eventArgs.Frame.Clone();
        }

        private void QRLogin_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (captureDevice != null && captureDevice.IsRunning)
            {
                captureDevice.Stop();
            }
        }
        LoginController lgController = new LoginController();
        private void timer1_Tick(object sender, EventArgs e)
        {
            string user_role = "";
            if (pictureBox.Image != null)
            {
                BarcodeReader barcodeReader = new BarcodeReader();
                Result result = barcodeReader.Decode((Bitmap)pictureBox.Image);
                if (result != null)
                {
                    string res = result.ToString();
                    string[] collection = res.Split('\n');
                    timer1.Stop();
                    if (captureDevice.IsRunning)
                    {
                        captureDevice.Stop();
                        try
                        {
                            Console.WriteLine("Test: " + collection[0]);
                            if (collection.Count() > 1 && lgController.CheckValid(collection[0], collection[1], ref user_role))
                            {
                                //MessageBox.Show("Login Successfully!!!");
                                lgController.DirectDifferentAutorization(user_role, cur_form);
                            }
                            else if (lgController.CheckValidPIN(collection[0], ref user_role))
                            {
                                lgController.DirectDifferentAutorization(user_role, cur_form);
                            }
                            else
                            {
                                MessageBox.Show("Your ID or Password\nmay have been incorrect!!!");
                                pictureBox.Visible = false;
                                pictureBox.Enabled = false;
                                pictureBox.Image = null;
                                ScanBtn_Click(sender, e);
                            }
                        }
                        catch
                        {
                            MessageBox.Show("Error");
                            QRLogin_Load(sender, e);
                        }
                    }
                }
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
