using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.Lecturer.Controllers;
using The_amazing_of_numbers.Area.Student.View;
using The_amazing_of_numbers.Controller;

namespace The_amazing_of_numbers.Area.Lecturer.View
{
    public partial class Lecture_ChangePass : Form
    {
        LecturerController lecturerController = new LecturerController();
        LoginController loginController = new LoginController();
        private string user_id = string.Empty;
        public Lecture_ChangePass(string id)
        {
            InitializeComponent();
            this.user_id = id;
        }

        private void modelEffect_Timer_Tick(object sender, EventArgs e)
        {

        }
        int i;
        private void Lecture_ChangePass_Load(object sender, EventArgs e)
        {

        }
        private void JustifyBtn_Click(object sender, EventArgs e)
        {
            string oldPass = OldPassBar.Text;
            string temp_role = ""; //this will not be used
            if (loginController.CheckValid(user_id, oldPass, ref temp_role))
            {
                //Allow to update password
                NewPassBar.Enabled = true;
                NewPassBar.Visible = true;
                UpdateBtn.Enabled = true;
                UpdateBtn.Visible = true;
                Notice.Visible = false;
                Notice.Enabled = false;
            }
            else
            {
                Notice.Text = "*Your password is incorrect";
                Notice.Visible = true;
                Notice.Enabled = true;
            }
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string newPass = NewPassBar.Text;
            lecturerController.UpdatePassWord(user_id, newPass);
            string notice = "Your password has been updated";
            MessageBox.Show(notice);
        }
    }
}
