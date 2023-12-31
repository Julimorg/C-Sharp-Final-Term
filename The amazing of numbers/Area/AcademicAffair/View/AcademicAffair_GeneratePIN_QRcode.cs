using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.AcademicAffair.Controllers;
using The_amazing_of_numbers.Area.Lecturer.Controllers;

namespace The_amazing_of_numbers.Area.AcademicAffair.View
{
    public partial class AcademicAffair_GeneratePIN_QRcode : Form
    {
        AcademicAffairController academicAffairController = new AcademicAffairController();
        private string user_id = string.Empty;
        public AcademicAffair_GeneratePIN_QRcode(string id)
        {
            InitializeComponent();
            this.user_id = id;
        }
        private void CrtPinBtn_Click(object sender, EventArgs e)
        {
            string PIN = PINbar.Text;
            //Console.WriteLine("User id: " + id);
            bool DoesUserHasPIN = false;
            academicAffairController.AddingPIN(PIN, user_id, ref DoesUserHasPIN);
            string notice = (DoesUserHasPIN) ? "Your PIN has been updated" : "Your PIN has been created";
            MessageBox.Show(notice);

        }

        private void CrtQRBtn_Click(object sender, EventArgs e)
        {
            QRcodeBox.Enabled = true;
            QRcodeBox.Visible = true;
            QRcodeBox.Image = academicAffairController.AddingQRCode(user_id);

            SaveBtn.Enabled = true;
            SaveBtn.Visible = true;
        }

        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetImage(QRcodeBox.Image);
            MessageBox.Show("Đã Copy QR Code!");
        }

        private void PINbar_TextChanged(object sender, EventArgs e)
        {
            Guna2TextBox PIN = (Guna2TextBox)sender;
            if (PIN.Text.Length > 0 && (PIN.Text.All(char.IsDigit) == false))
            {
                Notice.Visible = true;
                Notice.ForeColor = Color.Firebrick;
                Notice.Text = "*Your PIN should only be in digits";
            }
            else if (PIN.Text.Length > 6)
            {//Firebrick
                Notice.Visible = true;
                Notice.ForeColor = Color.Firebrick;
                Notice.Text = "*Your PIN should not be over 6 digits";
            }
            else if (PIN.Text.Length > 0 && PIN.Text.Length < 6)
            {
                Notice.Visible = true;
                Notice.ForeColor = Color.Firebrick;
                Notice.Text = "*Your PIN is too short";
            }
            else if (PIN.Text.Length == 6)
            {
                Notice.Visible = true;
                Notice.ForeColor = Color.MediumSeaGreen;
                Notice.Text = "*Qualified";
            }
            else if (PIN.Text.Length == 0)
            {
                Notice.Visible = false;
            }
        }
    }
}
