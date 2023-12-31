using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Area.AdminArea.Controllers;
using The_amazing_of_numbers.Controller;

namespace The_amazing_of_numbers.Area.AdminArea.View
{
    public partial class AdminChangePass : Form
    {
        AdminController adminController = new AdminController();
        LoginController loginController = new LoginController();
        string user_id = string.Empty;
        public AdminChangePass(string id)
        {
            InitializeComponent();
            user_id = id;
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
            adminController.UpdatePassWord(user_id, newPass);
            /*string notice = "Your password has been updated";
            MessageBox.Show(notice);*/
        }

    }
}
