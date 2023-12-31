using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using The_amazing_of_numbers.Controller;

namespace The_amazing_of_numbers.View
{
    public partial class ForgetPassView : Form
    {
        Login cur_form = null;
        LoginController loginController = new LoginController();
        public ForgetPassView(Login cur_form)
        {
            InitializeComponent();
            this.cur_form = cur_form;
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void SendingPassBtn_Click(object sender, EventArgs e)
        {
            string id = UserBar.Texts;
            string message = "Set your password to default";
            string title = "Notice";
            MessageBoxButtons buttons = MessageBoxButtons.OKCancel;
            DialogResult result = MessageBox.Show(message, title, buttons, MessageBoxIcon.Question, MessageBoxDefaultButton.Button1);
            if (result == DialogResult.OK) //Reset password in DB
            {
                string default_pass = loginController.SetPassToDefault(id);
                if (default_pass.Equals("Your ID may not correct"))
                {
                    MessageBox.Show(default_pass);
                    UserBar.Focus();
                    UserBar.Texts = "";
                }
                else
                {
                    MessageBox.Show("Your password has been reset");
                    label1.Visible = true;
                    DefaultPass.Visible = true;
                    DefaultPass.Text = default_pass;
                    SaveBtn.Visible = true;
                    SaveBtn.Enabled = true;
                }
            }
            else
            {
                this.Close();
            }
        }
        private void SaveBtn_Click(object sender, EventArgs e)
        {
            Clipboard.SetText(DefaultPass.Text);
            MessageBox.Show("Đã sao chép!");
        }
    }
}
